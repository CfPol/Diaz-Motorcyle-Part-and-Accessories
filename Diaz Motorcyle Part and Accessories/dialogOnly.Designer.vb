<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialogOnly
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dialog_list = New ListView()
        total_lbl = New Label()
        Panel1 = New Panel()
        method_cbo = New ComboBox()
        costumer_name = New TextBox()
        date_cbo = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        exit_btn = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dialog_list
        ' 
        dialog_list.Location = New Point(42, 51)
        dialog_list.Name = "dialog_list"
        dialog_list.Size = New Size(404, 475)
        dialog_list.TabIndex = 0
        dialog_list.UseCompatibleStateImageBehavior = False
        ' 
        ' total_lbl
        ' 
        total_lbl.AutoSize = True
        total_lbl.Font = New Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        total_lbl.ForeColor = SystemColors.ActiveCaptionText
        total_lbl.Location = New Point(169, 13)
        total_lbl.Name = "total_lbl"
        total_lbl.Size = New Size(72, 29)
        total_lbl.TabIndex = 1
        total_lbl.Text = "0.00"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DeepSkyBlue
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(total_lbl)
        Panel1.Location = New Point(42, 532)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(404, 53)
        Panel1.TabIndex = 2
        ' 
        ' method_cbo
        ' 
        method_cbo.FormattingEnabled = True
        method_cbo.Items.AddRange(New Object() {"Gcash", "Cash", "Card"})
        method_cbo.Location = New Point(187, 659)
        method_cbo.Name = "method_cbo"
        method_cbo.Size = New Size(259, 23)
        method_cbo.TabIndex = 3
        ' 
        ' costumer_name
        ' 
        costumer_name.Location = New Point(187, 606)
        costumer_name.Name = "costumer_name"
        costumer_name.Size = New Size(259, 23)
        costumer_name.TabIndex = 4
        ' 
        ' date_cbo
        ' 
        date_cbo.Location = New Point(187, 716)
        date_cbo.Name = "date_cbo"
        date_cbo.Size = New Size(259, 23)
        date_cbo.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 609)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 15)
        Label2.TabIndex = 2
        Label2.Text = "Costumer Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 722)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 7
        Label3.Text = "Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 716)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 662)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 15)
        Label5.TabIndex = 9
        Label5.Text = "Payment Method"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LimeGreen
        Button1.Font = New Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(42, 766)
        Button1.Name = "Button1"
        Button1.Size = New Size(404, 59)
        Button1.TabIndex = 10
        Button1.Text = "ACCEPT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' exit_btn
        ' 
        exit_btn.AutoSize = True
        exit_btn.BackColor = SystemColors.ActiveCaption
        exit_btn.Cursor = Cursors.Hand
        exit_btn.Font = New Font("Courier New", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exit_btn.Location = New Point(414, 9)
        exit_btn.Name = "exit_btn"
        exit_btn.Size = New Size(32, 33)
        exit_btn.TabIndex = 11
        exit_btn.Text = "X"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(14, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 29)
        Label1.TabIndex = 2
        Label1.Text = "Total ₱"
        ' 
        ' dialogOnly
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(469, 846)
        Controls.Add(exit_btn)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(date_cbo)
        Controls.Add(costumer_name)
        Controls.Add(method_cbo)
        Controls.Add(Panel1)
        Controls.Add(dialog_list)
        Name = "dialogOnly"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dialog_list As ListView
    Friend WithEvents total_lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents method_cbo As ComboBox
    Friend WithEvents costumer_name As TextBox
    Friend WithEvents date_cbo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents exit_btn As Label
    Friend WithEvents Label1 As Label
End Class
