<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accountview
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
        DataGridView1 = New DataGridView()
        add_btn = New Button()
        del_btn = New Button()
        add_panel = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(2, 153)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(240, 489)
        DataGridView1.TabIndex = 0
        ' 
        ' add_btn
        ' 
        add_btn.Location = New Point(437, 107)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(100, 40)
        add_btn.TabIndex = 1
        add_btn.Text = "Add Account"
        add_btn.UseVisualStyleBackColor = True
        ' 
        ' del_btn
        ' 
        del_btn.Location = New Point(602, 107)
        del_btn.Name = "del_btn"
        del_btn.Size = New Size(100, 40)
        del_btn.TabIndex = 2
        del_btn.Text = "Delete Account"
        del_btn.UseVisualStyleBackColor = True
        ' 
        ' add_panel
        ' 
        add_panel.BorderStyle = BorderStyle.FixedSingle
        add_panel.Location = New Point(248, 153)
        add_panel.Name = "add_panel"
        add_panel.Size = New Size(816, 489)
        add_panel.TabIndex = 3
        ' 
        ' accountview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1078, 852)
        Controls.Add(add_panel)
        Controls.Add(del_btn)
        Controls.Add(add_btn)
        Controls.Add(DataGridView1)
        Name = "accountview"
        Text = "accountview"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents add_btn As Button
    Friend WithEvents del_btn As Button
    Friend WithEvents add_panel As Panel
End Class
