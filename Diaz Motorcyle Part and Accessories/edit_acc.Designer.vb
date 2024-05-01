<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_acc
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
        Label1 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        level_cbo = New ComboBox()
        create_btn = New Button()
        pass2_txt = New TextBox()
        pass_txt = New TextBox()
        name_txt = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(114, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 29)
        Label1.TabIndex = 0
        Label1.Text = "Edit Account"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(level_cbo)
        Panel1.Controls.Add(create_btn)
        Panel1.Controls.Add(pass2_txt)
        Panel1.Controls.Add(pass_txt)
        Panel1.Controls.Add(name_txt)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(114, 77)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(579, 287)
        Panel1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(45, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 18)
        Label3.TabIndex = 11
        Label3.Text = "Access Level"
        ' 
        ' level_cbo
        ' 
        level_cbo.FormattingEnabled = True
        level_cbo.Items.AddRange(New Object() {"Owner", "Manager", "Employee"})
        level_cbo.Location = New Point(160, 173)
        level_cbo.Name = "level_cbo"
        level_cbo.Size = New Size(159, 23)
        level_cbo.TabIndex = 10
        ' 
        ' create_btn
        ' 
        create_btn.BackColor = SystemColors.HotTrack
        create_btn.Cursor = Cursors.Hand
        create_btn.FlatStyle = FlatStyle.Popup
        create_btn.ForeColor = SystemColors.ControlLightLight
        create_btn.Location = New Point(244, 252)
        create_btn.Name = "create_btn"
        create_btn.Size = New Size(116, 23)
        create_btn.TabIndex = 9
        create_btn.Text = "Edit Account"
        create_btn.UseVisualStyleBackColor = False
        ' 
        ' pass2_txt
        ' 
        pass2_txt.Location = New Point(160, 131)
        pass2_txt.Name = "pass2_txt"
        pass2_txt.Size = New Size(159, 23)
        pass2_txt.TabIndex = 8
        ' 
        ' pass_txt
        ' 
        pass_txt.Location = New Point(160, 81)
        pass_txt.Name = "pass_txt"
        pass_txt.Size = New Size(159, 23)
        pass_txt.TabIndex = 7
        ' 
        ' name_txt
        ' 
        name_txt.Location = New Point(160, 30)
        name_txt.Name = "name_txt"
        name_txt.Size = New Size(242, 23)
        name_txt.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(31, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 18)
        Label5.TabIndex = 5
        Label5.Text = "New Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(5, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 18)
        Label4.TabIndex = 4
        Label4.Text = "Re-type Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(62, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 18)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' edit_acc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "edit_acc"
        Size = New Size(800, 450)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents create_btn As Button
    Friend WithEvents pass2_txt As TextBox
    Friend WithEvents pass_txt As TextBox
    Friend WithEvents name_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents level_cbo As ComboBox

End Class
