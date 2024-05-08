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
    Public Sub refresh_table()
        Dim connectionString As MySqlConnection = Module3.ConnectToDB()
        Dim dt As New DataTable()
        Using adapter As New MySqlDataAdapter("SELECT * FROM product", connectionString)
            adapter.Fill(dt)
        End Using
        DataGridView1.DataSource = dt
    End Sub


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None



    End Sub

    Private Sub Form1_Load_database(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim connection As MySqlConnection = Module1.ConnectToDB()
        If connection IsNot Nothing Then
            Dim command As New MySqlCommand("SELECT * FROM product", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table

        End If
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up columns
        ListView1.View = View.Details
        ListView1.Columns.Add("ITEM", 75, HorizontalAlignment.Left)
        ListView1.Columns.Add("MODEL", 75, HorizontalAlignment.Left)
        ListView1.Columns.Add("PRICE", 75, HorizontalAlignment.Left)
        ListView1.Columns.Add("AMOUNT", 75, HorizontalAlignment.Left)
        ListView1.Columns.Add("ID", 75, HorizontalAlignment.Left)

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

        ' Draw the item text idk how this works tbh
        e.Graphics.DrawString(itemText, itemFont, itemBrush, e.Bounds)
    End Sub

    Private sum As Integer = 0
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then

            Dim name As String = DataGridView1.Rows(e.RowIndex).Cells("Product_name").Value.ToString()
            Dim model As String = DataGridView1.Rows(e.RowIndex).Cells("Model").Value.ToString()
            Dim unitPrice As String = DataGridView1.Rows(e.RowIndex).Cells("Unit_price").Value.ToString()
            Dim id As String = DataGridView1.Rows(e.RowIndex).Cells("Product_id").Value.ToString()
            Dim stock As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("Available_stock").Value)

            ' check if item in lits
            Dim itemExists As Boolean = False
            For Each item As ListViewItem In ListView1.Items
                If item.SubItems(0).Text = name AndAlso item.SubItems(1).Text = model Then
                    item.SubItems(3).Text = (Convert.ToInt32(item.SubItems(3).Text) + 1).ToString()
                    itemExists = True
                    Exit For
                End If
            Next

            ' If the item doesn't exist in the ListView, add it
            If Not itemExists Then
                If stock > 0 Then
                    Dim newItem As New ListViewItem(name)
                    newItem.SubItems.Add(model)
                    newItem.SubItems.Add(unitPrice)
                    newItem.SubItems.Add("1") ' Start with amount 1
                    newItem.SubItems.Add(id)
                    ListView1.Items.Add(newItem)
                Else
                    MessageBox.Show("This item is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If



        Dim sum As Double = 0
        Dim total As Integer = 0

        For Each item As ListViewItem In ListView1.Items
            Dim unitp As Double
            Dim amount As Integer

            If Double.TryParse(item.SubItems(2).Text, unitp) Then
                If Integer.TryParse(item.SubItems(3).Text, amount) Then
                    sum += unitp * amount
                End If
            End If
        Next




        Charge_btn.Text = "Charge" & "  " & "₱ " & sum.ToString("0.00")
    End Sub
    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        'check if there is item on list
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim subItemValue As Integer
            'check if item is greater than 1
            If Integer.TryParse(selectedItem.SubItems(3).Text, subItemValue) Then
                'if yes subtract
                If subItemValue > 1 Then
                    subItemValue -= 1
                    selectedItem.SubItems(3).Text = subItemValue.ToString()
                    'if no remove
                ElseIf subItemValue = 1 Then
                    selectedItem.Remove()

                End If
            Else
                MessageBox.Show("Invalid Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Dim sum As Double = 0

        For Each item As ListViewItem In ListView1.Items
            Dim unitp As Double
            Dim amount As Integer

            If Double.TryParse(item.SubItems(2).Text, unitp) Then
                If Integer.TryParse(item.SubItems(3).Text, amount) Then
                    sum += unitp * amount
                End If
            End If
        Next


        Charge_btn.Text = "Charge" + "  " + "₱ " + sum.ToString()

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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Exit Application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub signOut_btn_Click(sender As Object, e As EventArgs) Handles signOut_btn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Sign Out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form3.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Charge_btn_Click(sender As Object, e As EventArgs) Handles Charge_btn.Click
        Dim open As New dialogOnly()


        For Each item As ListViewItem In ListView1.Items
            Dim newItem As New ListViewItem(item.SubItems(0).Text)
            newItem.SubItems.Add(item.SubItems(1).Text)
            newItem.SubItems.Add(item.SubItems(2).Text)
            newItem.SubItems.Add(item.SubItems(3).Text)
            newItem.SubItems.Add(item.SubItems(4).Text)

            open.dialog_list.Items.Add(newItem)
        Next



        Dim sum As Double = 0
        For Each item As ListViewItem In open.dialog_list.Items
            Dim unitp As Double
            Dim amount As Integer

            If Double.TryParse(item.SubItems(2).Text, unitp) Then
                If Integer.TryParse(item.SubItems(3).Text, amount) Then
                    sum += unitp * amount
                End If
            End If

        Next

        ' Display the total sum
        open.total_lbl.Text = sum.ToString("0.00")
        open.ShowDialog()


        Dim connection As MySqlConnection = Module3.ConnectToDB()
    End Sub


End Class
