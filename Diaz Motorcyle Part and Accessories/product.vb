Imports MySql.Data.MySqlClient

Public Class product
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connection string to your SQL Server database
        Dim connectionString As MySqlConnection = Module3.ConnectToDB()

        ' SQL query to retrieve data
        Dim query As String = "SELECT Supplier_name FROM supplier"

        ' Create connection and command objects

        Using command As New MySqlCommand(query, connectionString)
            ' Execute the command and get the data reader
            Using reader As MySqlDataReader = command.ExecuteReader()
                ' Clear existing items in the ComboBox
                supplier_cbo.Items.Clear()

                ' Iterate over the data reader and add items to the ComboBox
                While reader.Read()
                    supplier_cbo.Items.Add(reader("Supplier_name").ToString())
                End While
            End Using
        End Using
    End Sub

    Private Sub prod_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As MySqlConnection = Module3.ConnectToDB()
        Dim query As String = "SELECT * FROM product"
        Using command As New MySqlCommand(query, connectionString)
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

            Dim Unique_id As String = selectedRow.Cells("Supplier_id").Value.ToString()
            'fill text box
            prod_name.Text = selectedRow.Cells("Product Name").Value.ToString()
            prod_brand.Text = selectedRow.Cells("Brand").Value.ToString()
            prod_model.Text = selectedRow.Cells("Model").Value.ToString()
            unit_price.Text = selectedRow.Cells("Unit Price").Value.ToString()
            stock.Text = selectedRow.Cells("In Stock").Value.ToString()
            supplier_cbo.Text = selectedRow.Cells("Supplier").Value.ToString()

        End If


    End Sub

    Private Sub ClearTextBoxes()
        prod_name.Clear()
        prod_brand.Clear()
        prod_model.Clear()
        unit_price.Clear()
        stock.Clear()
    End Sub

    Private Shadows Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If String.IsNullOrWhiteSpace(prod_name.Text) OrElse
        String.IsNullOrWhiteSpace(prod_brand.Text) OrElse
        String.IsNullOrWhiteSpace(prod_model.Text) OrElse
        String.IsNullOrWhiteSpace(unit_price.Text) OrElse
        String.IsNullOrWhiteSpace(stock.Text) OrElse
            String.IsNullOrWhiteSpace(supplier_cbo.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connectionString As MySqlConnection = Module3.ConnectToDB()
        Dim query As String = "INSERT INTO product (Supplier, Product_Name, Brand, Model, Unit_price, Available_stock) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @value6)"
        Dim supplierIdQuery As String = "SELECT Supplier_id FROM supplier WHERE Supplier_name = @SupplierName"

        Using command As New MySqlCommand(supplierIdQuery, connectionString)
            ' Set the parameter for the supplier name
            command.Parameters.AddWithValue("@SupplierName", supplier_cbo.SelectedItem.ToString())

            Dim supplierId As Integer = Convert.ToInt32(command.ExecuteScalar())

            Using command1 As New MySqlCommand(query, connectionString)


                command1.Parameters.AddWithValue("@Value6", stock.Text)
                command1.Parameters.AddWithValue("@Value2", prod_name.Text)
                command1.Parameters.AddWithValue("@Value3", prod_brand.Text)
                command1.Parameters.AddWithValue("@Value4", prod_model.Text)
                command1.Parameters.AddWithValue("@Value5", unit_price.Text)
                command1.Parameters.AddWithValue("@Value1", supplierId)

                command.ExecuteNonQuery()
            End Using
        End Using
        Dim dt As New DataTable()
        Using adapter As New MySqlDataAdapter("SELECT * FROM product", connectionString)
            adapter.Fill(dt)
        End Using
        DataGridView1.DataSource = dt


        ClearTextBoxes()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles supplier_cbo.SelectedIndexChanged

    End Sub
End Class
