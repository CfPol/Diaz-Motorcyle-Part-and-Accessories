<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel1 = New Panel()
        form2_search = New TextBox()
        Label6 = New Label()
        Panel2 = New Panel()
        delete = New Button()
        update_btn = New Button()
        add = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        address = New TextBox()
        contact_no = New TextBox()
        email = New TextBox()
        Supp_person = New TextBox()
        Supp_name = New TextBox()
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
        Panel2.Controls.Add(delete)
        Panel2.Controls.Add(update_btn)
        Panel2.Controls.Add(add)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(address)
        Panel2.Controls.Add(contact_no)
        Panel2.Controls.Add(email)
        Panel2.Controls.Add(Supp_person)
        Panel2.Controls.Add(Supp_name)
        Panel2.Location = New Point(2, 269)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(865, 182)
        Panel2.TabIndex = 1
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
        Label5.Location = New Point(416, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 9
        Label5.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 15)
        Label4.TabIndex = 8
        Label4.Text = "Supplier Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 15)
        Label3.TabIndex = 7
        Label3.Text = "Contact Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(403, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 6
        Label2.Text = "Address"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 15)
        Label1.TabIndex = 5
        Label1.Text = "Contact Person"
        ' 
        ' address
        ' 
        address.Location = New Point(458, 63)
        address.Name = "address"
        address.Size = New Size(232, 23)
        address.TabIndex = 4
        ' 
        ' contact_no
        ' 
        contact_no.Location = New Point(139, 103)
        contact_no.Name = "contact_no"
        contact_no.Size = New Size(126, 23)
        contact_no.TabIndex = 3
        ' 
        ' email
        ' 
        email.Location = New Point(458, 19)
        email.Name = "email"
        email.Size = New Size(232, 23)
        email.TabIndex = 2
        ' 
        ' Supp_person
        ' 
        Supp_person.Location = New Point(139, 63)
        Supp_person.Name = "Supp_person"
        Supp_person.Size = New Size(126, 23)
        Supp_person.TabIndex = 1
        ' 
        ' Supp_name
        ' 
        Supp_name.Location = New Point(139, 19)
        Supp_name.Name = "Supp_name"
        Supp_name.Size = New Size(126, 23)
        Supp_name.TabIndex = 0
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
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(870, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
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
    Friend WithEvents address As TextBox
    Friend WithEvents contact_no As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Supp_person As TextBox
    Friend WithEvents Supp_name As TextBox
    Friend WithEvents delete As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents add As Button
    Friend WithEvents form2_search As TextBox
    Friend WithEvents Label6 As Label
End Class
