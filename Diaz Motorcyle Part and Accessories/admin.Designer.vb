<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        ImageList1 = New ImageList(components)
        Panel1 = New Panel()
        Label1 = New Label()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        data_btn = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "icons8-analytics-30.png")
        ImageList1.Images.SetKeyName(1, "icons8-community-50.png")
        ImageList1.Images.SetKeyName(2, "icons8-logout-24.png")
        ImageList1.Images.SetKeyName(3, "icons8-database-48.png")
        ImageList1.Images.SetKeyName(4, "icons8-home-32.png")
        ImageList1.Images.SetKeyName(5, "icons8-invoice-50.png")
        ImageList1.Images.SetKeyName(6, "icons8-supplier-50.png")
        ImageList1.Images.SetKeyName(7, "icons8-product-24.png")
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(data_btn)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(153, 972)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 25)
        Label1.TabIndex = 6
        Label1.Text = "Admin"
        ' 
        ' Button5
        ' 
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.ImageIndex = 2
        Button5.ImageList = ImageList1
        Button5.Location = New Point(3, 946)
        Button5.Name = "Button5"
        Button5.Size = New Size(147, 23)
        Button5.TabIndex = 5
        Button5.Text = "Sign Out"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.ImageIndex = 1
        Button4.ImageList = ImageList1
        Button4.Location = New Point(3, 168)
        Button4.Name = "Button4"
        Button4.Size = New Size(147, 23)
        Button4.TabIndex = 4
        Button4.Text = "Accounts"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.ImageIndex = 0
        Button3.ImageList = ImageList1
        Button3.Location = New Point(3, 139)
        Button3.Name = "Button3"
        Button3.Size = New Size(147, 23)
        Button3.TabIndex = 3
        Button3.Text = "Analytics"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' data_btn
        ' 
        data_btn.ImageAlign = ContentAlignment.MiddleLeft
        data_btn.ImageIndex = 3
        data_btn.ImageList = ImageList1
        data_btn.Location = New Point(3, 110)
        data_btn.Name = "data_btn"
        data_btn.Size = New Size(147, 23)
        data_btn.TabIndex = 2
        data_btn.Text = "Database"
        data_btn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.ImageIndex = 4
        Button1.ImageList = ImageList1
        Button1.Location = New Point(3, 81)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 23)
        Button1.TabIndex = 1
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Location = New Point(158, 82)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1094, 891)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button8)
        Panel3.Controls.Add(Button7)
        Panel3.Controls.Add(Button6)
        Panel3.Location = New Point(158, 1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1094, 75)
        Panel3.TabIndex = 2
        Panel3.Visible = False
        ' 
        ' Button8
        ' 
        Button8.ImageAlign = ContentAlignment.MiddleLeft
        Button8.ImageIndex = 5
        Button8.ImageList = ImageList1
        Button8.Location = New Point(439, 49)
        Button8.Name = "Button8"
        Button8.Size = New Size(147, 23)
        Button8.TabIndex = 9
        Button8.Text = "Invoice"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.ImageIndex = 6
        Button7.ImageList = ImageList1
        Button7.Location = New Point(226, 49)
        Button7.Name = "Button7"
        Button7.Size = New Size(147, 23)
        Button7.TabIndex = 8
        Button7.Text = "Suppliers"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.ImageIndex = 7
        Button6.ImageList = ImageList1
        Button6.Location = New Point(3, 49)
        Button6.Name = "Button6"
        Button6.Size = New Size(147, 23)
        Button6.TabIndex = 7
        Button6.Text = "Products"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 985)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form5"
        Text = "Form5"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents data_btn As Button
End Class
