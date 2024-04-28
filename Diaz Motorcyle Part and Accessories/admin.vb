Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Visible = False
        Dim form2 As New accountview() ' Pass a reference to the current form
        form2.TopLevel = False
        form2.FormBorderStyle = FormBorderStyle.None
        form2.Dock = DockStyle.Fill
        Panel2.Controls.Add(form2)
        form2.Show()
        For Each ctrl As Control In Panel2.Controls
            If TypeOf ctrl Is Form2 Then
                Dim form1 As Form2 = DirectCast(ctrl, Form2)
                Panel2.Controls.Remove(form1)
                form1.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Form5_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub database(sender As Object, e As EventArgs) Handles data_btn.Click
        Panel3.Visible = True
        For Each ctrl As Control In Panel2.Controls
            If TypeOf ctrl Is accountview Then
                Dim form2 As accountview = DirectCast(ctrl, accountview)
                Panel2.Controls.Remove(form2)
                form2.Close()
                Exit For
            End If
        Next
        For Each ctrl As Control In Panel2.Controls
            If TypeOf ctrl Is Form2 Then
                Dim form2 As Form2 = DirectCast(ctrl, Form2)
                Panel2.Controls.Remove(form2)
                form2.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel3.Visible = True
        For Each ctrl As Control In Panel2.Controls
            If TypeOf ctrl Is Form2 Then
                Dim form2 As Form2 = DirectCast(ctrl, Form2)
                Panel2.Controls.Remove(form2)
                form2.Close()
                Exit For
            End If
        Next

        Dim prod As New Products()
        prod.TopLevel = False
        prod.FormBorderStyle = FormBorderStyle.None
        prod.Dock = DockStyle.Fill
        Panel2.Controls.Add(prod)
        prod.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel3.Visible = True
        Dim form As New Form2() ' Pass a reference to the current form
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        Panel2.Controls.Add(form)
        form.Show()
    End Sub
End Class