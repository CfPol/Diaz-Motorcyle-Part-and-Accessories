Imports MySql.Data.MySqlClient
Imports Mysqlx.Connection

Public Class product
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As MySqlConnection = Module3.ConnectToDB()
        Dim query As String = "SELECT Supplier_name FROM supplier"
        Using command As New MySqlCommand(query, connectionString)
            Using reader As MySqlDataReader = command.ExecuteReader()
                supplier_cbo.Items.Clear()
                ' Iterate over the data reader and add items to the ComboBox
                While reader.Read()
                    supplier_cbo.Items.Add(reader("Supplier_name").ToString())
                End While
            End Using
        End Using
    End Sub
    'idk why I separated these two subs ?^?
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

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = DataGridView1.Columns("Available_stock").Index AndAlso e.RowIndex >= 0 Then
            Dim cellValue As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("Available_stock").Value)
            If cellValue = 0 Then
                DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                DataGridView1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            Else
                ' Set the default back color to white for rows with stock > 0
                DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                DataGridView1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            Dim Unique_id As String = selectedRow.Cells("Product_id").Value.ToString()
            ' Fill text boxes
            prod_name.Text = selectedRow.Cells("Product_name").Value.ToString()
            prod_brand.Text = selectedRow.Cells("Brand").Value.ToString()
            prod_model.Text = selectedRow.Cells("Model").Value.ToString()
            unit_price.Text = selectedRow.Cells("Unit_price").Value.ToString()
            stock.Text = selectedRow.Cells("Available_stock").Value.ToString()

            ' Retrieve supplier ID
            Dim supplierId As String = selectedRow.Cells("Supplier").Value.ToString()

            ' Query the database to retrieve the supplier name based on the supplier ID
            Dim connectionString As MySqlConnection = Module3.ConnectToDB()
            Dim query As String = "SELECT Supplier_name FROM supplier WHERE Supplier_id = @SupplierId"


            Using command As New MySqlCommand(query, connectionString)
                command.Parameters.AddWithValue("@SupplierId", supplierId)
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    supplier_cbo.Text = reader("Supplier_name").ToString()
                End If
                reader.Close()
            End Using

        End If


    End Sub

    Private Sub ClearTextBoxes()
        prod_name.Clear()
        prod_brand.Clear()
        prod_model.Clear()
        unit_price.Clear()
        stock.Clear()
    End Sub

    Private Sub refresh_table()
        Dim connectionString As MySqlConnection = Module3.ConnectToDB()
        Dim dt As New DataTable()
        Using adapter As New MySqlDataAdapter("SELECT * FROM product", connectionString)
            adapter.Fill(dt)
        End Using
        DataGridView1.DataSource = dt
    End Sub



    Public Function productExists(pname As String, brand As String, model As String, supplier As String) As Boolean
        Dim connectionString As MySqlConnection = Module3.ConnectToDB()
        Dim query As String = "SELECT COUNT(*) FROM product WHERE Product_Name = @pname AND Brand = @brand AND Model = @model AND Supplier = @supplier"
        Dim exists As Boolean = False

        Using command As New MySqlCommand(query, connectionString)
            command.Parameters.AddWithValue("@pname", pname)
            command.Parameters.AddWithValue("@brand", brand)
            command.Parameters.AddWithValue("@model", model)
            command.Parameters.AddWithValue("@supplier", supplier)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            exists = count > 0
        End Using

        Return exists
    End Function

    Private Shadows Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        'just to check if unitp and stock is int
        Dim unitPrice As Double
        Dim stockQuantity As Integer

        If String.IsNullOrWhiteSpace(prod_name.Text) OrElse
        String.IsNullOrWhiteSpace(prod_brand.Text) OrElse
        String.IsNullOrWhiteSpace(prod_model.Text) OrElse
        String.IsNullOrWhiteSpace(unit_price.Text) OrElse
            String.IsNullOrWhiteSpace(stock.Text) OrElse
            supplier_cbo.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        ElseIf Not Double.TryParse(unit_price.Text, unitPrice) OrElse Not Integer.TryParse(stock.Text, stockQuantity) Then
            MessageBox.Show("Non-numeric character in Unit Price or Stock detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                If Not productExists(prod_name.Text, prod_brand.Text, prod_model.Text, supplierId) Then
                    command1.Parameters.AddWithValue("@Value1", supplierId)
                    command1.Parameters.AddWithValue("@Value2", prod_name.Text)
                    command1.Parameters.AddWithValue("@Value3", prod_brand.Text)
                    command1.Parameters.AddWithValue("@Value4", prod_model.Text)
                    command1.Parameters.AddWithValue("@Value5", unit_price.Text)
                    command1.Parameters.AddWithValue("@Value6", stock.Text)
                    command1.ExecuteNonQuery()
                ElseIf productExists(prod_name.Text, prod_brand.Text, prod_model.Text, supplierId) Then
                    MessageBox.Show("Product Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


                End If
            End Using
        End Using
        refresh_table()
        ClearTextBoxes()
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim unitPrice As Double
        Dim stockQuantity As Integer

        If String.IsNullOrWhiteSpace(prod_name.Text) OrElse
        String.IsNullOrWhiteSpace(prod_brand.Text) OrElse
        String.IsNullOrWhiteSpace(prod_model.Text) OrElse
        String.IsNullOrWhiteSpace(unit_price.Text) OrElse
            String.IsNullOrWhiteSpace(stock.Text) OrElse
            supplier_cbo.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        ElseIf Not Double.TryParse(unit_price.Text, unitPrice) OrElse Not Integer.TryParse(stock.Text, stockQuantity) Then
            MessageBox.Show("Non-numeric character in Unit Price or Stock detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim uniqueId As String = selectedRow.Cells("Product_id").Value.ToString()

            Dim connection As MySqlConnection = Module3.ConnectToDB()
            Dim supplierIdQuery As String = "SELECT Supplier_id FROM supplier WHERE Supplier_name = @SupplierName"
            Dim query As String = "UPDATE Product SET Supplier = @Value1, 
                                    Product_name = @Value2, 
                                    Brand = @Value3, 
                                    Model = @Value4, 
                                    Unit_price = @Value5, 
                                    Available_stock = @Value6 
                                    WHERE Product_id = @UniqueId"

            Using command As New MySqlCommand(supplierIdQuery, connection)
                ' Set the parameter for the supplier name
                command.Parameters.AddWithValue("@SupplierName", supplier_cbo.SelectedItem.ToString())

                Dim supplierId As Integer = Convert.ToInt32(command.ExecuteScalar())

                Using command1 As New MySqlCommand(query, connection)

                    command1.Parameters.AddWithValue("@Value1", supplierId)
                    command1.Parameters.AddWithValue("@Value2", prod_name.Text)
                    command1.Parameters.AddWithValue("@Value3", prod_brand.Text)
                    command1.Parameters.AddWithValue("@Value4", prod_model.Text)
                    command1.Parameters.AddWithValue("@Value5", unit_price.Text)
                    command1.Parameters.AddWithValue("@Value6", stock.Text)
                    command1.Parameters.AddWithValue("@UniqueId", uniqueId)
                    command1.ExecuteNonQuery()

                End Using
            End Using
            refresh_table()
            ClearTextBoxes()

        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove stocks from this product?", "Remove Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DataGridView1.SelectedRows.Count > 0 And DialogResult.Yes Then

            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("Product_id").Value)

            Dim connectionString As MySqlConnection = Module3.ConnectToDB()
            Dim query As String = "UPDATE product SET Available_stock = 0 WHERE Product_id = @productId"


            Using command As New MySqlCommand(query, connectionString)
                command.Parameters.AddWithValue("@productId", productId)
                command.ExecuteNonQuery()
            End Using

        Else
            MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        refresh_table()
        ClearTextBoxes()
    End Sub
End Class
