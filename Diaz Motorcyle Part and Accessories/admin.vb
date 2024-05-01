Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
        Me.TopMost = True
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


End Class