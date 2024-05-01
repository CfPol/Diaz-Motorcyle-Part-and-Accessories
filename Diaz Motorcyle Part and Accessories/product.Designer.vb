<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class product
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        form2_search = New TextBox()
        Label6 = New Label()
        Panel2 = New Panel()
        supplier_cbo = New ComboBox()
        Label7 = New Label()
        delete = New Button()
        update_btn = New Button()
        add = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        stock = New TextBox()
        prod_model = New TextBox()
        unit_price = New TextBox()
        prod_brand = New TextBox()
        prod_name = New TextBox()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Bisque
        Panel1.Controls.Add(form2_search)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(865, 50)
        Panel1.TabIndex = 0
        ' 
        ' form2_search
        ' 
        form2_search.Location = New Point(58, 22)
        form2_search.Name = "form2_search"
        form2_search.Size = New Size(126, 23)
        form2_search.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(10, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 13
        Label6.Text = "Search"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Bisque
        Panel2.Controls.Add(supplier_cbo)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(delete)
        Panel2.Controls.Add(update_btn)
        Panel2.Controls.Add(add)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(stock)
        Panel2.Controls.Add(prod_model)
        Panel2.Controls.Add(unit_price)
        Panel2.Controls.Add(prod_brand)
        Panel2.Controls.Add(prod_name)
        Panel2.Location = New Point(2, 269)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(865, 182)
        Panel2.TabIndex = 1
        ' 
        ' supplier_cbo
        ' 
        supplier_cbo.Location = New Point(458, 103)
        supplier_cbo.Name = "supplier_cbo"
        supplier_cbo.Size = New Size(232, 23)
        supplier_cbo.TabIndex = 15
        supplier_cbo.Text = "Choose Supplier"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(402, 106)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 15)
        Label7.TabIndex = 14
        Label7.Text = "Supplier"
        ' 
        ' delete
        ' 
        delete.BackColor = Color.Red
        delete.Cursor = Cursors.Hand
        delete.FlatStyle = FlatStyle.Popup
        delete.ForeColor = SystemColors.ControlLightLight
        delete.Location = New Point(615, 146)
        delete.Name = "delete"
        delete.Size = New Size(75, 23)
        delete.TabIndex = 12
        delete.Text = "DELETE"
        delete.UseVisualStyleBackColor = False
        ' 
        ' update_btn
        ' 
        update_btn.BackColor = Color.Blue
        update_btn.FlatStyle = FlatStyle.Popup
        update_btn.ForeColor = SystemColors.ControlLightLight
        update_btn.Location = New Point(377, 146)
        update_btn.Name = "update_btn"
        update_btn.Size = New Size(75, 23)
        update_btn.TabIndex = 11
        update_btn.Text = "UPDATE"
        update_btn.UseVisualStyleBackColor = False
        ' 
        ' add
        ' 
        add.BackColor = Color.Green
        add.FlatStyle = FlatStyle.Popup
        add.ForeColor = SystemColors.ControlLightLight
        add.Location = New Point(139, 146)
        add.Name = "add"
        add.Size = New Size(75, 23)
        add.TabIndex = 10
        add.Text = "ADD"
        add.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(394, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 9
        Label5.Text = "Unit Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 8
        Label4.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(91, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 7
        Label3.Text = "Model"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(365, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 15)
        Label2.TabIndex = 6
        Label2.Text = "Available Stock"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(94, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 5
        Label1.Text = "Brand"
        ' 
        ' stock
        ' 
        stock.Location = New Point(458, 63)
        stock.Name = "stock"
        stock.Size = New Size(232, 23)
        stock.TabIndex = 4
        ' 
        ' prod_model
        ' 
        prod_model.Location = New Point(139, 103)
        prod_model.Name = "prod_model"
        prod_model.Size = New Size(158, 23)
        prod_model.TabIndex = 3
        ' 
        ' unit_price
        ' 
        unit_price.Location = New Point(458, 19)
        unit_price.Name = "unit_price"
        unit_price.Size = New Size(232, 23)
        unit_price.TabIndex = 2
        ' 
        ' prod_brand
        ' 
        prod_brand.Location = New Point(139, 63)
        prod_brand.Name = "prod_brand"
        prod_brand.Size = New Size(158, 23)
        prod_brand.TabIndex = 1
        ' 
        ' prod_name
        ' 
        prod_name.Location = New Point(139, 19)
        prod_name.Name = "prod_name"
        prod_name.Size = New Size(158, 23)
        prod_name.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(2, 58)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(865, 205)
        DataGridView1.TabIndex = 2
        ' 
        ' product
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "product"
        Size = New Size(870, 450)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents stock As TextBox
    Friend WithEvents prod_model As TextBox
    Friend WithEvents unit_price As TextBox
    Friend WithEvents prod_brand As TextBox
    Friend WithEvents prod_name As TextBox
    Friend WithEvents delete As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents add As Button
    Friend WithEvents form2_search As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents supplier_cbo As ComboBox

End Class
