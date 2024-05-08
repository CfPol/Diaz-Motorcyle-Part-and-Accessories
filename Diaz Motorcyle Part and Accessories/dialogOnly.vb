Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class dialogOnly

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up columns
        dialog_list.View = View.Details
        dialog_list.Columns.Add("ITEM", 110, HorizontalAlignment.Left)
        dialog_list.Columns.Add("MODEL", 110, HorizontalAlignment.Left)
        dialog_list.Columns.Add("PRICE", 110, HorizontalAlignment.Left)
        dialog_list.Columns.Add("AMOUNT", 110, HorizontalAlignment.Left)
        dialog_list.Columns.Add("ID", 75, HorizontalAlignment.Left)




    End Sub
    Private Sub dialog_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub
    Private Function GetProductNameById(productId As Integer) As String
        Dim productName As String = ""
        Dim conn As MySqlConnection = Module3.ConnectToDB()
        ' Assuming connectionString is your MySQL connection string

        Dim query As String = "SELECT Product_name FROM product WHERE Product_id = @productId"
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@productId", productId)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                productName = reader.GetString("Product_name")
            End If
        End Using


        Return productName
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(costumer_name.Text) OrElse
        method_cbo.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim invoiceId As Integer
        Dim warrantyId As Integer
        Dim connectionString As MySqlConnection = Module3.ConnectToDB()



        For Each item As ListViewItem In dialog_list.Items
            Dim query As String = "INSERT INTO invoice (Customer_name, Total_amount, Payment_method, Date, Warranty_number) VALUES (@Value1, @Value2, @Value3, @Value4,@Value5); SELECT LAST_INSERT_ID();"
            Dim query4 As String = "INSERT INTO invoice (Customer_name, Total_amount, Payment_method, Date) VALUES (@Value1, @Value2, @Value3, @Value4); SELECT LAST_INSERT_ID();"
            Dim productId As Integer = item.SubItems(4).Text
            Dim currentDate As DateTime = date_cbo.Value
            Dim futureDate As DateTime = currentDate.AddMonths(6)
            Dim productName As String = GetProductNameById(productId)
            If productName.ToLower() = "battery" Then
                MessageBox.Show("You have purchased a " + productName + " Warranty has been created", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim query3 As String = "INSERT INTO warranty (Product, Date_purchased, End_date) VALUES (@Product, @buy, @end); SELECT LAST_INSERT_ID();"
                Using command As New MySqlCommand(query3, connectionString)
                    command.Parameters.AddWithValue("@Product", productId)
                    command.Parameters.AddWithValue("@buy", date_cbo.Value)
                    command.Parameters.AddWithValue("@end", futureDate)
                    warrantyId = Convert.ToInt32(command.ExecuteScalar())

                    command.ExecuteNonQuery()
                End Using

                Using command As New MySqlCommand(query, connectionString)


                    command.Parameters.AddWithValue("@Value1", costumer_name.Text)
                    command.Parameters.AddWithValue("@Value2", total_lbl.Text)
                    command.Parameters.AddWithValue("@Value3", method_cbo.Text)
                    command.Parameters.AddWithValue("@Value4", date_cbo.Value)
                    command.Parameters.AddWithValue("@Value5", warrantyId)
                    invoiceId = Convert.ToInt32(command.ExecuteScalar())

                    command.ExecuteNonQuery()
                End Using
            Else
                Using command As New MySqlCommand(query4, connectionString)


                    command.Parameters.AddWithValue("@Value1", costumer_name.Text)
                    command.Parameters.AddWithValue("@Value2", total_lbl.Text)
                    command.Parameters.AddWithValue("@Value3", method_cbo.Text)
                    command.Parameters.AddWithValue("@Value4", date_cbo.Value)
                    invoiceId = Convert.ToInt32(command.ExecuteScalar())

                    command.ExecuteNonQuery()
                End Using
            End If
        Next



        For Each item As ListViewItem In dialog_list.Items

            Dim productId As Integer = item.SubItems(4).Text
            Dim quantity As Integer = Integer.Parse(item.SubItems(3).Text)
            Dim price As Double = Double.Parse(item.SubItems(2).Text)
            Dim total As Double = quantity * price
            Dim productName As String = GetProductNameById(productId)

            Dim query2 As String = "INSERT INTO invoice_items (Product, Invoice_ref, Quantity, Total_price) VALUES (@Product, @reference, @quantity, @Total)"


            Using command As New MySqlCommand(query2, connectionString)
                command.Parameters.AddWithValue("@Product", productId)
                command.Parameters.AddWithValue("@reference", invoiceId)
                command.Parameters.AddWithValue("@quantity", quantity)
                command.Parameters.AddWithValue("@Total", total)
                command.ExecuteNonQuery()
            End Using

            Dim updateQuery As String = "UPDATE product SET Available_stock = Available_stock - @quantity WHERE Product_id = @productId"
            Using updateCommand As New MySqlCommand(updateQuery, connectionString)
                updateCommand.Parameters.AddWithValue("@quantity", quantity)

                updateCommand.Parameters.AddWithValue("@productId", productId)
                updateCommand.ExecuteNonQuery()
            End Using


        Next
        Dim open As New Form1()
        open.refresh_table()
        MessageBox.Show("Invoice Created Successfully", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class