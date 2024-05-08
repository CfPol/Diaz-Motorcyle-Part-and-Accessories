Imports MySql.Data.MySqlClient

Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub

    Private Sub open_prod()
        Dim open As New product()
        open.Dock = DockStyle.Fill
        Panel2.Controls.Add(open)
        open.BringToFront()
    End Sub

    Private Sub close_prod()
        Dim close As New product()
        Panel2.Controls.Remove(close)
    End Sub

    Private Sub open_supp()
        Dim open As New supplier()
        open.Dock = DockStyle.Fill
        Panel2.Controls.Add(open)
        open.BringToFront()
    End Sub
    Private Sub close_supp()
        Dim close As New supplier()
        Panel2.Controls.Remove(close)
    End Sub
    Private Sub open_accs()
        Dim open As New accounts()
        open.Dock = DockStyle.Fill
        Panel2.Controls.Add(open)
        open.BringToFront()
    End Sub
    Private Sub close_accs()
        Dim close As New accounts()
        Panel2.Controls.Remove(close)
    End Sub

    Private Sub open_inv()
        Dim open As New invoice()
        open.Dock = DockStyle.Fill
        Panel2.Controls.Add(open)
        open.BringToFront()
    End Sub

    Private Sub close_inv()
        Dim close As New invoice()
        Panel2.Controls.Remove(close)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles account_btn.Click
        Panel3.Visible = False
        close_supp()
        close_prod()
        open_accs()
    End Sub





    Private Sub database(sender As Object, e As EventArgs) Handles data_btn.Click
        Panel3.Visible = True
        close_accs()
        close_supp()
        close_prod()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles prod_btn.Click
        Panel3.Visible = True
        close_accs()
        close_supp()
        open_prod()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel3.Visible = True
        close_accs()
        close_prod()
        open_supp()
    End Sub

    Private Sub sign_out(sender As Object, e As EventArgs) Handles signOut_btn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Sign Out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form3.Show()
            Me.Close()
        End If
    End Sub

    Private Sub exit_call(sender As Object, e As EventArgs) Handles exit_btn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Exit Application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        close_prod()
        close_supp()
        close_accs()
        open_inv()

    End Sub

    Private Sub backup_btn_Click(sender As Object, e As EventArgs) Handles backup_btn.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "SQL Backup Files (*.sql)|*.sql"
        saveFileDialog.Title = "Save Backup File"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim backupFileName As String = saveFileDialog.FileName

            ' Get the MySQL connection string
            Dim connectionString As MySqlConnection = Module3.ConnectToDB()

            ' Use the mysqldump utility to create the backup
            Dim processStartInfo As New ProcessStartInfo()
            processStartInfo.FileName = "C:\xampp\mysql\bin\mysqldump.exe"
            processStartInfo.Arguments = $"--user=root --password= --host=localhost --databases diaz --result-file=""{backupFileName}"""
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden
            processStartInfo.UseShellExecute = False
            processStartInfo.RedirectStandardOutput = True

            Using process As Process = Process.Start(processStartInfo)
                process.WaitForExit()
            End Using

            MessageBox.Show("Backup created successfully.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class