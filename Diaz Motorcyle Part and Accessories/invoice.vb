Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports Mysqlx

Public Class invoice
    Private Sub load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As String = "server=localhost; user id=root; password=; database=diaz; convert zero datetime=True"
        Dim query As String = "SELECT * FROM invoice"
        Using connection As New MySqlConnection(conn)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)

                    DataGridView1.DataSource = dt
                End Using
            End Using
        End Using
    End Sub



    Private Sub form2_search_TextChanged(sender As Object, e As EventArgs) Handles form2_search.TextChanged
        Dim conn As MySqlConnection = Module3.ConnectToDB()
        Dim query As String = "SELECT * FROM supplier WHERE Supplier_name LIKE @Keyword OR Contact_person LIKE @Keyword"
        Dim keyword As String = "%" & form2_search.Text.Trim() & "%"

        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@Keyword", keyword)

            Using reader As MySqlDataReader = command.ExecuteReader()
                Dim dt As New DataTable()
                dt.Load(reader)
                DataGridView1.DataSource = dt
            End Using
        End Using
    End Sub
End Class
