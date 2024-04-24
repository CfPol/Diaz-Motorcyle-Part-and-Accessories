<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        DataGridView1 = New DataGridView()
        searchbox = New TextBox()
        lbl_search = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        ListView1 = New ListView()
        Panel1 = New Panel()
        lbl_total = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lbl_charge = New Label()
        Supplier = New Button()
        Products = New Button()
        Invoice = New Button()
        Warranty = New Button()
        Service = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.MenuHighlight
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 39)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(522, 399)
        DataGridView1.TabIndex = 0
        ' 
        ' searchbox
        ' 
        searchbox.Location = New Point(59, 10)
        searchbox.Name = "searchbox"
        searchbox.Size = New Size(143, 23)
        searchbox.TabIndex = 1
        ' 
        ' lbl_search
        ' 
        lbl_search.AutoSize = True
        lbl_search.Location = New Point(12, 13)
        lbl_search.Name = "lbl_search"
        lbl_search.Size = New Size(42, 15)
        lbl_search.TabIndex = 2
        lbl_search.Text = "Search"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(ListView1)
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(540, 39)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(298, 399)
        FlowLayoutPanel1.TabIndex = 3
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(3, 3)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(292, 307)
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LimeGreen
        Panel1.Controls.Add(lbl_total)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lbl_charge)
        Panel1.Location = New Point(3, 316)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(292, 79)
        Panel1.TabIndex = 3
        ' 
        ' lbl_total
        ' 
        lbl_total.Anchor = AnchorStyles.Right
        lbl_total.AutoSize = True
        lbl_total.Font = New Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_total.ForeColor = SystemColors.ControlLightLight
        lbl_total.Location = New Point(201, 25)
        lbl_total.Name = "lbl_total"
        lbl_total.Size = New Size(46, 25)
        lbl_total.TabIndex = 3
        lbl_total.Text = "0.0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(131, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 25)
        Label2.TabIndex = 2
        Label2.Text = "₱"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(131, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 1
        ' 
        ' lbl_charge
        ' 
        lbl_charge.AutoSize = True
        lbl_charge.Font = New Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_charge.ForeColor = SystemColors.ControlLightLight
        lbl_charge.Location = New Point(3, 25)
        lbl_charge.Name = "lbl_charge"
        lbl_charge.Size = New Size(104, 25)
        lbl_charge.TabIndex = 0
        lbl_charge.Text = "CHARGE"
        ' 
        ' Supplier
        ' 
        Supplier.Location = New Point(265, 10)
        Supplier.Name = "Supplier"
        Supplier.Size = New Size(75, 23)
        Supplier.TabIndex = 4
        Supplier.Text = "Supplier"
        Supplier.UseVisualStyleBackColor = True
        ' 
        ' Products
        ' 
        Products.Location = New Point(346, 10)
        Products.Name = "Products"
        Products.Size = New Size(75, 23)
        Products.TabIndex = 5
        Products.Text = "Products"
        Products.UseVisualStyleBackColor = True
        ' 
        ' Invoice
        ' 
        Invoice.Location = New Point(427, 10)
        Invoice.Name = "Invoice"
        Invoice.Size = New Size(75, 23)
        Invoice.TabIndex = 6
        Invoice.Text = "Invoice"
        Invoice.UseVisualStyleBackColor = True
        ' 
        ' Warranty
        ' 
        Warranty.Location = New Point(508, 10)
        Warranty.Name = "Warranty"
        Warranty.Size = New Size(75, 23)
        Warranty.TabIndex = 7
        Warranty.Text = "Warranty"
        Warranty.UseVisualStyleBackColor = True
        ' 
        ' Service
        ' 
        Service.Location = New Point(589, 10)
        Service.Name = "Service"
        Service.Size = New Size(75, 23)
        Service.TabIndex = 8
        Service.Text = "Service"
        Service.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(850, 450)
        Controls.Add(Service)
        Controls.Add(Warranty)
        Controls.Add(Invoice)
        Controls.Add(Products)
        Controls.Add(Supplier)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(lbl_search)
        Controls.Add(searchbox)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents searchbox As TextBox
    Friend WithEvents lbl_search As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_charge As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Supplier As Button
    Friend WithEvents Products As Button
    Friend WithEvents Invoice As Button
    Friend WithEvents Warranty As Button
    Friend WithEvents Service As Button

End Class
