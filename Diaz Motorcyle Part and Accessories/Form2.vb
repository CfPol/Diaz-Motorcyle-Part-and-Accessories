Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X500
Module Module2
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
            MsgBox("Database is not connected.", vbOKOnly, "Connection Error")
            Return Nothing
        End Try
    End Function
End Module

Public Class Form2
    Private Sub Form2_grid(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=localhost; user id=root; password=; database=diaz"
        Dim query As String = "SELECT * FROM supplier"

        Using connection As New MySqlConnection(connectionString)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            Dim Unique_id As String = selectedRow.Cells("Supplier_id").Value.ToString()
            'fill text box
            Supp_name.Text = selectedRow.Cells("Supplier_name").Value.ToString()
            Supp_person.Text = selectedRow.Cells("Contact_person").Value.ToString()
            contact_no.Text = selectedRow.Cells("Contact_number").Value.ToString()
            email.Text = selectedRow.Cells("Email").Value.ToString()
            address.Text = selectedRow.Cells("Address").Value.ToString()

        End If


    End Sub

    Private Sub ClearTextBoxes()
        Supp_name.Clear()
        Supp_person.Clear()
        contact_no.Clear()
        email.Clear()
        address.Clear()
    End Sub

    Private Shadows Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If String.IsNullOrWhiteSpace(Supp_name.Text) OrElse
        String.IsNullOrWhiteSpace(Supp_person.Text) OrElse
        String.IsNullOrWhiteSpace(contact_no.Text) OrElse
        String.IsNullOrWhiteSpace(email.Text) OrElse
        String.IsNullOrWhiteSpace(address.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not IsNumeric(contact_no.Text) Then
            MessageBox.Show("Contact number must not contain letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim connectionString As String = "server=localhost; user id=root; password=; database=diaz"
        Dim query As String = "INSERT INTO Supplier (Supplier_name, Contact_person, Contact_number, Email, Address) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"


        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                command.Parameters.AddWithValue("@Value1", Supp_name.Text)
                command.Parameters.AddWithValue("@Value2", Supp_person.Text)
                command.Parameters.AddWithValue("@Value3", contact_no.Text)
                command.Parameters.AddWithValue("@Value4", email.Text)
                command.Parameters.AddWithValue("@Value5", address.Text)

                command.ExecuteNonQuery()
            End Using
        End Using
        Dim dt As New DataTable()
        Using adapter As New MySqlDataAdapter("SELECT * FROM supplier", connectionString)
            adapter.Fill(dt)
        End Using
        DataGridView1.DataSource = dt


        ClearTextBoxes()
    End Sub

    Private Shadows Sub update_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim uniqueId As String = selectedRow.Cells("Supplier_id").Value.ToString()

            Dim connectionString As String = "server=localhost; user id=root; password=; database=diaz"
            Dim query As String = "UPDATE Supplier SET Supplier_name = @Value1, Contact_person = @Value2, Contact_number = @Value3, Email = @Value4, Address = @Value5 WHERE Supplier_id = @UniqueId"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    connection.Open()

                    command.Parameters.AddWithValue("@Value1", Supp_name.Text)
                    command.Parameters.AddWithValue("@Value2", Supp_person.Text)
                    command.Parameters.AddWithValue("@Value3", contact_no.Text)
                    command.Parameters.AddWithValue("@Value4", email.Text)
                    command.Parameters.AddWithValue("@Value5", address.Text)
                    command.Parameters.AddWithValue("@UniqueId", uniqueId)

                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Refresh the DataGridView to reflect the changes
            Dim dt As New DataTable()
            Using adapter As New MySqlDataAdapter("SELECT * FROM supplier", connectionString)
                adapter.Fill(dt)
            End Using
            DataGridView1.DataSource = dt
        End If
        ClearTextBoxes()

    End Sub

    Private Shadows Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim uniqueId As String = selectedRow.Cells("Supplier_id").Value.ToString()

                Dim connectionString As String = "server=localhost; user id=root; password=; database=diaz"
                Dim query As String = "DELETE FROM Supplier WHERE Supplier_id = @UniqueId"

                Using connection As New MySqlConnection(connectionString)
                    Using command As New MySqlCommand(query, connection)
                        connection.Open()

                        command.Parameters.AddWithValue("@UniqueId", uniqueId)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Refresh the DataGridView to reflect the changes
                Dim dt As New DataTable()
                Using adapter As New MySqlDataAdapter("SELECT * FROM supplier", connectionString)
                    adapter.Fill(dt)
                End Using
                DataGridView1.DataSource = dt
            End If
        End If
        ClearTextBoxes()
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles form2_search.TextChanged
        Dim connectionString As String = "server=localhost; user id=root; password=; database=diaz"
        Dim query As String = "SELECT * FROM supplier WHERE Supplier_name LIKE @Keyword OR Contact_person LIKE @Keyword"
        Dim keyword As String = "%" & form2_search.Text.Trim() & "%"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Keyword", keyword)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
End Class