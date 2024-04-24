Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X500
Module Module1
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
Public Class Form1
    Private Sub Form1_Load_database(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As MySqlConnection = Module1.ConnectToDB()
        If connection IsNot Nothing Then
            Dim command As New MySqlCommand("SELECT * FROM product", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up columns
        ListView1.View = View.Details
        ListView1.Columns.Add("ITEM", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("MODEL", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("PRICE", 100, HorizontalAlignment.Left)
    End Sub

    Private Sub Form1_list(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=localhost; user id=root; password=; database=diaz"
        Dim query As String = "SELECT * FROM product"

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

    Private Sub ListBox1_DrawItem(sender As Object, e As DrawItemEventArgs)
        If e.Index < 0 Then Exit Sub

        e.DrawBackground()
        e.DrawFocusRectangle()

        ' Get the item text
        Dim itemText = $"{e.Index + 1}. {ListView1.Items(e.Index).ToString}"

        ' Choose the font and color for the item
        Dim itemFont = ListView1.Font
        Dim itemBrush = Brushes.Black

        ' Draw the item text
        e.Graphics.DrawString(itemText, itemFont, itemBrush, e.Bounds)
    End Sub

    Private sum As Integer = 0
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim name As String = DataGridView1.Rows(e.RowIndex).Cells("Product_name").Value.ToString()
            Dim model As String = DataGridView1.Rows(e.RowIndex).Cells("Model").Value.ToString()
            Dim unitPrice As String = DataGridView1.Rows(e.RowIndex).Cells("Unit_price").Value.ToString()


            Dim newItem As New ListViewItem(name)
            newItem.SubItems.Add(model)
            newItem.SubItems.Add(unitPrice)
            ListView1.Items.Add(newItem)

        End If

        Dim sum As Integer = 0

        For Each item As ListViewItem In ListView1.Items
            Dim value As Integer
            If Integer.TryParse(item.SubItems(2).Text, value) Then
                sum += value
            End If
        Next


        lbl_total.Text = sum.ToString()
    End Sub
    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.Items.Remove(ListView1.SelectedItems(0))
            Dim sum As Integer = 0

            For Each item As ListViewItem In ListView1.Items
                Dim value As Integer
                If Integer.TryParse(item.SubItems(2).Text, value) Then
                    sum += value
                End If
            Next


            lbl_total.Text = sum.ToString()
        End If
    End Sub

    Private Sub Supplier_Click(sender As Object, e As EventArgs) Handles Supplier.Click
        Dim form2 As New Form2()
        form2.ShowDialog()




    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        Dim connectionString As String = "server=localhost; user id=root; password=; database=diaz"
        Dim query As String = "SELECT * FROM product WHERE Product_name LIKE @Keyword OR Model LIKE @Keyword OR Unit_price LIKE @Keyword"
        Dim keyword As String = "%" & searchbox.Text.Trim() & "%"

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
