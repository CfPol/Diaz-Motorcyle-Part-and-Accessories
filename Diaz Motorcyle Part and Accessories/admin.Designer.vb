﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        signOut_btn = New Button()
        account_btn = New Button()
        data_btn = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Button8 = New Button()
        Button7 = New Button()
        prod_btn = New Button()
        exit_btn = New Label()
        backup_btn = New Button()
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
        ImageList1.Images.SetKeyName(8, "icons8-backup-50.png")
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(signOut_btn)
        Panel1.Controls.Add(account_btn)
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
        ' signOut_btn
        ' 
        signOut_btn.ImageAlign = ContentAlignment.MiddleLeft
        signOut_btn.ImageIndex = 2
        signOut_btn.ImageList = ImageList1
        signOut_btn.Location = New Point(3, 415)
        signOut_btn.Name = "signOut_btn"
        signOut_btn.Size = New Size(147, 23)
        signOut_btn.TabIndex = 5
        signOut_btn.Text = "Sign Out"
        signOut_btn.UseVisualStyleBackColor = True
        ' 
        ' account_btn
        ' 
        account_btn.ImageAlign = ContentAlignment.MiddleLeft
        account_btn.ImageIndex = 1
        account_btn.ImageList = ImageList1
        account_btn.Location = New Point(3, 139)
        account_btn.Name = "account_btn"
        account_btn.Size = New Size(147, 23)
        account_btn.TabIndex = 4
        account_btn.Text = "Accounts"
        account_btn.UseVisualStyleBackColor = True
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
        Panel3.Controls.Add(backup_btn)
        Panel3.Controls.Add(Button8)
        Panel3.Controls.Add(Button7)
        Panel3.Controls.Add(prod_btn)
        Panel3.Location = New Point(158, 1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1011, 75)
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
        ' prod_btn
        ' 
        prod_btn.ImageAlign = ContentAlignment.MiddleLeft
        prod_btn.ImageIndex = 7
        prod_btn.ImageList = ImageList1
        prod_btn.Location = New Point(3, 49)
        prod_btn.Name = "prod_btn"
        prod_btn.Size = New Size(147, 23)
        prod_btn.TabIndex = 7
        prod_btn.Text = "Products"
        prod_btn.UseVisualStyleBackColor = True
        ' 
        ' exit_btn
        ' 
        exit_btn.AutoSize = True
        exit_btn.BackColor = SystemColors.Control
        exit_btn.Cursor = Cursors.Hand
        exit_btn.Font = New Font("Courier New", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exit_btn.Location = New Point(1202, 24)
        exit_btn.Name = "exit_btn"
        exit_btn.Size = New Size(32, 33)
        exit_btn.TabIndex = 3
        exit_btn.Text = "X"
        ' 
        ' backup_btn
        ' 
        backup_btn.ImageAlign = ContentAlignment.MiddleLeft
        backup_btn.ImageIndex = 8
        backup_btn.ImageList = ImageList1
        backup_btn.Location = New Point(624, 49)
        backup_btn.Name = "backup_btn"
        backup_btn.Size = New Size(147, 23)
        backup_btn.TabIndex = 10
        backup_btn.Text = "backup"
        backup_btn.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 1024)
        Controls.Add(exit_btn)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form5"
        Text = "Form5"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents signOut_btn As Button
    Friend WithEvents account_btn As Button
    Friend WithEvents backup_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents prod_btn As Button
    Friend WithEvents data_btn As Button
    Friend WithEvents exit_btn As Label
End Class
