Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.Notice.Warning.Types
Imports System.Security.Cryptography

Public Class edit_acc
    Private _user As String
    Private acc_parent As accounts
    Public Sub UpdateTextBox(username As String, Level As String)
        _user = username
        name_txt.Text = username
        level_cbo.Text = Level
    End Sub
    Public Sub New(parent As accounts)
        InitializeComponent()
        acc_parent = parent
    End Sub

    Public Function usernameExists(username As String) As Boolean
        Dim connectionString As MySqlConnection = Module3.ConnectToDB()
        Dim query As String = "SELECT COUNT(*) FROM accounts WHERE Username = @username"
        Dim isUsernameInDatabase As Boolean = False


        Using command As New MySqlCommand(query, connectionString)
            command.Parameters.AddWithValue("@username", username)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            isUsernameInDatabase = count > 0
        End Using

        Return isUsernameInDatabase
    End Function

    Private Function ComputeSHA1Hash(input As String) As String
        Using sha1 As SHA1 = sha1.Create()
            Dim data As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hash As Byte() = sha1.ComputeHash(data)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub create_btn_Click(sender As Object, e As EventArgs) Handles create_btn.Click
        If String.IsNullOrWhiteSpace(name_txt.Text) OrElse
        String.IsNullOrWhiteSpace(pass_txt.Text) OrElse
        String.IsNullOrWhiteSpace(pass2_txt.Text) OrElse
            String.IsNullOrEmpty(level_cbo.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim uniqueId As String = _user
        Dim connection As MySqlConnection = Module3.ConnectToDB()
        Dim query As String = "UPDATE accounts SET Username = @Value1, Password = @Value2, Level = @Value3 WHERE Username = @UniqueId"
        Dim hashedPassword As String = ComputeSHA1Hash(pass2_txt.Text)
        Using command As New MySqlCommand(query, connection)
            If pass_txt.Text = pass2_txt.Text AndAlso Not usernameExists(name_txt.Text) Then
                command.Parameters.AddWithValue("@Value1", name_txt.Text)
                command.Parameters.AddWithValue("@Value2", hashedPassword)
                command.Parameters.AddWithValue("@Value3", level_cbo.Text)
                command.Parameters.AddWithValue("@UniqueId", uniqueId)
                command.ExecuteNonQuery()
                MessageBox.Show("New Account Updated Successfully", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf usernameExists(name_txt.Text) Then
                MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Password Does Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End Using
        acc_parent.refresh_table()
    End Sub

End Class
