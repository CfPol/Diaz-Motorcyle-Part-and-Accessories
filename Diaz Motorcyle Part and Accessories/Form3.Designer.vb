<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Panel1 = New Panel()
        main = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        signin_btn = New Button()
        passwordtxt = New TextBox()
        usernametxt = New TextBox()
        signIN_lbl = New Label()
        main.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.download__2_
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(412, 451)
        Panel1.TabIndex = 0
        ' 
        ' main
        ' 
        main.BackColor = Color.Transparent
        main.Controls.Add(Label2)
        main.Controls.Add(Label1)
        main.Controls.Add(signin_btn)
        main.Controls.Add(passwordtxt)
        main.Controls.Add(usernametxt)
        main.Controls.Add(signIN_lbl)
        main.Font = New Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        main.Location = New Point(409, 0)
        main.Name = "main"
        main.Size = New Size(393, 451)
        main.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 18)
        Label2.TabIndex = 6
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 18)
        Label1.TabIndex = 5
        Label1.Text = "Username"
        ' 
        ' signin_btn
        ' 
        signin_btn.BackColor = Color.DodgerBlue
        signin_btn.Cursor = Cursors.Hand
        signin_btn.FlatStyle = FlatStyle.Popup
        signin_btn.ForeColor = SystemColors.ControlLightLight
        signin_btn.Location = New Point(135, 296)
        signin_btn.Name = "signin_btn"
        signin_btn.Size = New Size(75, 23)
        signin_btn.TabIndex = 3
        signin_btn.Text = "SIGN IN"
        signin_btn.UseVisualStyleBackColor = False
        ' 
        ' passwordtxt
        ' 
        passwordtxt.BorderStyle = BorderStyle.FixedSingle
        passwordtxt.Location = New Point(36, 229)
        passwordtxt.Name = "passwordtxt"
        passwordtxt.PasswordChar = "•"c
        passwordtxt.Size = New Size(322, 23)
        passwordtxt.TabIndex = 2
        ' 
        ' usernametxt
        ' 
        usernametxt.Location = New Point(36, 182)
        usernametxt.Name = "usernametxt"
        usernametxt.Size = New Size(322, 23)
        usernametxt.TabIndex = 1
        ' 
        ' signIN_lbl
        ' 
        signIN_lbl.AllowDrop = True
        signIN_lbl.AutoSize = True
        signIN_lbl.BackColor = Color.Transparent
        signIN_lbl.Font = New Font("Dubai", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signIN_lbl.Location = New Point(26, 121)
        signIN_lbl.Name = "signIN_lbl"
        signIN_lbl.Size = New Size(88, 40)
        signIN_lbl.TabIndex = 0
        signIN_lbl.Text = "Sign In"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(main)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        main.ResumeLayout(False)
        main.PerformLayout()
        ResumeLayout(False)


    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents main As Panel
    Friend WithEvents signIN_lbl As Label
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents signin_btn As Button
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
