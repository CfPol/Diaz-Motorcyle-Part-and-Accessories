Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X500
Imports System.Security.Cryptography

Module Module3
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public cm1 As New MySqlCommand
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public dt1 As New DataTable
    Public da As MySqlDataAdapter
    Public da1 As MySqlDataAdapter
    Public ds As DataSet
    Public Function ConnectToDB() As MySqlConnection
        Dim connection As New MySqlConnection
        Try
            connection.ConnectionString = "server=localhost; user id=root; password=; database=diaz"
            connection.Open()
            Return connection
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Module


Public Class Form3

    Private Function ComputeSHA1Hash(input As String) As String
        Using sha1 As SHA1 = sha1.Create()
            Dim data As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hash As Byte() = sha1.ComputeHash(data)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub login_logic(sender As Object, e As EventArgs) Handles signin_btn.Click
        Dim connection As MySqlConnection = Module3.ConnectToDB()

        ' Check database
        If connection Is Nothing Then
            ' return error if connectiion failed
            MessageBox.Show("Database is Offline", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim username As String = usernametxt.Text
        Dim hashedEnteredPassword As String = ComputeSHA1Hash(passwordtxt.Text)


        Dim query As String = "SELECT Level FROM accounts WHERE Username = @Username AND Password = @Password"
        Module3.cm = New MySqlCommand(query, connection)
        Module3.cm.Parameters.AddWithValue("@Username", username)
        Module3.cm.Parameters.AddWithValue("@Password", hashedEnteredPassword)
        Dim level As String = Convert.ToString(Module3.cm.ExecuteScalar())


        If Not String.IsNullOrEmpty(level) Then
            If level = "Owner" Then
                MessageBox.Show("Login Succesful as Owner", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim openform As New Form5()
                openform.Show()
                Me.Hide()
                If openform.IsDisposed Then
                    Application.Exit()
                End If
            ElseIf level = "Employee" Then
                MessageBox.Show("Login Succesful as Employee", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim openform As New Form1()
                openform.Show()
                Me.Hide()
                If openform.IsDisposed Then
                    Application.Exit()
                End If
            End If
        Else
            MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        usernametxt.Clear()
        passwordtxt.Clear()
    End Sub

    Private Sub usernametxt_TextChanged(sender As Object, e As EventArgs) Handles usernametxt.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class