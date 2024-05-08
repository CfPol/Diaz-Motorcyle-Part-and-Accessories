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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        DataGridView1 = New DataGridView()
        searchbox = New TextBox()
        lbl_search = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        ListView1 = New ListView()
        Charge_btn = New Button()
        exit_btn = New Label()
        signOut_btn = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridView1.Location = New Point(12, 70)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(907, 903)
        DataGridView1.TabIndex = 0
        ' 
        ' searchbox
        ' 
        searchbox.Location = New Point(60, 33)
        searchbox.Name = "searchbox"
        searchbox.Size = New Size(287, 23)
        searchbox.TabIndex = 1
        ' 
        ' lbl_search
        ' 
        lbl_search.AutoSize = True
        lbl_search.Location = New Point(12, 36)
        lbl_search.Name = "lbl_search"
        lbl_search.Size = New Size(42, 15)
        lbl_search.TabIndex = 2
        lbl_search.Text = "Search"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(925, 70)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(311, 903)
        FlowLayoutPanel1.TabIndex = 3
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(925, 70)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(311, 778)
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Charge_btn
        ' 
        Charge_btn.BackColor = Color.LimeGreen
        Charge_btn.Cursor = Cursors.Hand
        Charge_btn.FlatStyle = FlatStyle.Popup
        Charge_btn.Font = New Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Charge_btn.ForeColor = SystemColors.ControlLightLight
        Charge_btn.Location = New Point(925, 854)
        Charge_btn.Name = "Charge_btn"
        Charge_btn.Size = New Size(311, 119)
        Charge_btn.TabIndex = 3
        Charge_btn.Text = "Charge     ₱  0.0"
        Charge_btn.UseVisualStyleBackColor = False
        ' 
        ' exit_btn
        ' 
        exit_btn.AutoSize = True
        exit_btn.BackColor = SystemColors.Control
        exit_btn.Cursor = Cursors.Hand
        exit_btn.Font = New Font("Courier New", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exit_btn.Location = New Point(1164, 18)
        exit_btn.Name = "exit_btn"
        exit_btn.Size = New Size(32, 33)
        exit_btn.TabIndex = 4
        exit_btn.Text = "X"
        ' 
        ' signOut_btn
        ' 
        signOut_btn.Image = CType(resources.GetObject("signOut_btn.Image"), Image)
        signOut_btn.Location = New Point(1202, 18)
        signOut_btn.Name = "signOut_btn"
        signOut_btn.Size = New Size(32, 30)
        signOut_btn.TabIndex = 6
        signOut_btn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 985)
        Controls.Add(signOut_btn)
        Controls.Add(exit_btn)
        Controls.Add(Charge_btn)
        Controls.Add(ListView1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(lbl_search)
        Controls.Add(searchbox)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents searchbox As TextBox
    Friend WithEvents lbl_search As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Charge_btn As Button
    Friend WithEvents exit_btn As Label
    Friend WithEvents signOut_btn As Button

End Class
