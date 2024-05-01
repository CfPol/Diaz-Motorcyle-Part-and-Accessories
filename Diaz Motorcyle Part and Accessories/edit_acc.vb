Public Class edit_acc
    Public Sub UpdateTextBox(username As String, level As String)
        MessageBox.Show(username, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        name_txt.Text = username
        level_cbo.Text = level
    End Sub
End Class
