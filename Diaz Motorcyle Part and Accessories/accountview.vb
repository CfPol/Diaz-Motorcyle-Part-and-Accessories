
Imports MySql.Data.MySqlClient

Public Class accountview
    Private Sub load_account(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As MySqlConnection = Module3.ConnectToDB()
        Dim query As String = "SELECT Username, Level FROM accounts"
        Using command As New MySqlCommand(query, connection)

            Using reader As MySqlDataReader = command.ExecuteReader()
                Dim dt As New DataTable()
                dt.Load(reader)
                DataGridView1.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        End If
    End Sub

    Private Shadows Sub add_click(sender As Object, e As EventArgs) Handles add_btn.Click
        Dim form As New Form4(Me)
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        add_panel.Controls.Add(form)
        form.Show()
    End Sub

    Private Shadows Sub delete_Click(sender As Object, e As EventArgs) Handles del_btn.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this account?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim name As String = selectedRow.Cells("Username").Value.ToString()

                Dim connectionString As String = "server=localhost; user id=root; password=; database=diaz"
                Dim query As String = "DELETE FROM accounts WHERE Username = @name"

                Using connection As New MySqlConnection(connectionString)
                    Using command As New MySqlCommand(query, connection)
                        connection.Open()

                        command.Parameters.AddWithValue("@name", name)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Refresh the DataGridView to reflect the changes
                Dim dt As New DataTable()
                Using adapter As New MySqlDataAdapter("SELECT * FROM accounts", connectionString)
                    adapter.Fill(dt)
                End Using
                DataGridView1.DataSource = dt
            End If
        End If
    End Sub
End Class