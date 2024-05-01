Imports MySql.Data.MySqlClient

Public Class create_acc
    Shadows parentForm As Form
    Private connectionString As MySqlConnection = Module3.ConnectToDB()
    Private _parentUserControl As accounts

    Public Sub New(parent As accounts)
        InitializeComponent()
        _parentUserControl = parent
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

    Private Sub create_btn_Click(sender As Object, e As EventArgs) Handles create_btn.Click
        If String.IsNullOrWhiteSpace(name_txt.Text) OrElse
        String.IsNullOrWhiteSpace(pass_txt.Text) OrElse
        String.IsNullOrWhiteSpace(pass2_txt.Text) OrElse
            String.IsNullOrEmpty(level_cbo.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connection As MySqlConnection = Module3.ConnectToDB()
        Dim query As String = "INSERT INTO accounts(Username, Password, Level) VALUES (@value1, @value2,@value3)"



        Using command As New MySqlCommand(query, connection)
            If pass_txt.Text = pass2_txt.Text AndAlso Not usernameExists(name_txt.Text) Then
                command.Parameters.AddWithValue("@value1", name_txt.Text)
                command.Parameters.AddWithValue("@value2", pass_txt.Text)
                command.Parameters.AddWithValue("@value3", level_cbo.Text)
                command.ExecuteNonQuery()
                MessageBox.Show("New Account Created Successfully", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                _parentUserControl.refresh_table()
            ElseIf usernameExists(name_txt.Text) Then
                MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Password Does Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            _parentUserControl.refresh_table()
        End Using



    End Sub


End Class
