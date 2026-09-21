<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucItemsIn
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

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlMain = New Panel()
        pnlPlacement = New Panel()
        lblPlacementStatus = New Label()
        lblPlacementInfo = New Label()
        lblPlacementTitle = New Label()
        pnlTransactions = New Panel()
        dgvItems = New DataGridView()
        lblRecentTitle = New Label()
        pnlItemsIN = New Panel()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        txtUsername = New TextBox()
        btnINAdd = New Button()
        lblINQuan = New Label()
        lblINCategory = New Label()
        lblItemsINTitle = New Label()
        lblINdesc = New Label()
        lblINhandling = New Label()
        pnlMain.SuspendLayout()
        pnlPlacement.SuspendLayout()
        pnlTransactions.SuspendLayout()
        CType(dgvItems, ComponentModel.ISupportInitialize).BeginInit()
        pnlItemsIN.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlPlacement)
        pnlMain.Controls.Add(lblPlacementTitle)
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(lblRecentTitle)
        pnlMain.Controls.Add(pnlItemsIN)
        pnlMain.Controls.Add(lblINdesc)
        pnlMain.Controls.Add(lblINhandling)
        pnlMain.Location = New Point(3, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(960, 630)
        pnlMain.TabIndex = 3
        ' 
        ' pnlPlacement
        ' 
        pnlPlacement.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlPlacement.Controls.Add(lblPlacementStatus)
        pnlPlacement.Controls.Add(lblPlacementInfo)
        pnlPlacement.Location = New Point(35, 524)
        pnlPlacement.Name = "pnlPlacement"
        pnlPlacement.Size = New Size(855, 55)
        pnlPlacement.TabIndex = 8
        ' 
        ' lblPlacementStatus
        ' 
        lblPlacementStatus.AutoSize = True
        lblPlacementStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlacementStatus.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblPlacementStatus.Location = New Point(750, 20)
        lblPlacementStatus.Name = "lblPlacementStatus"
        lblPlacementStatus.Size = New Size(45, 15)
        lblPlacementStatus.TabIndex = 10
        lblPlacementStatus.Text = "READY"
        ' 
        ' lblPlacementInfo
        ' 
        lblPlacementInfo.AutoSize = True
        lblPlacementInfo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlacementInfo.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblPlacementInfo.Location = New Point(20, 19)
        lblPlacementInfo.Name = "lblPlacementInfo"
        lblPlacementInfo.Size = New Size(199, 15)
        lblPlacementInfo.TabIndex = 9
        lblPlacementInfo.Text = "67 items scheduled for display today"
        ' 
        ' lblPlacementTitle
        ' 
        lblPlacementTitle.AutoSize = True
        lblPlacementTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlacementTitle.ForeColor = Color.White
        lblPlacementTitle.Location = New Point(35, 498)
        lblPlacementTitle.Name = "lblPlacementTitle"
        lblPlacementTitle.Size = New Size(128, 20)
        lblPlacementTitle.TabIndex = 7
        lblPlacementTitle.Text = "ITEM PLACEMENT"
        ' 
        ' pnlTransactions
        ' 
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(dgvItems)
        pnlTransactions.Location = New Point(35, 315)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Padding = New Padding(10)
        pnlTransactions.Size = New Size(855, 200)
        pnlTransactions.TabIndex = 6
        ' 
        ' dgvItems
        ' 
        dgvItems.AllowUserToAddRows = False
        dgvItems.AllowUserToDeleteRows = False
        dgvItems.BackgroundColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvItems.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvItems.DefaultCellStyle = DataGridViewCellStyle2
        dgvItems.Dock = DockStyle.Fill
        dgvItems.EnableHeadersVisualStyles = False
        dgvItems.GridColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        dgvItems.Location = New Point(10, 10)
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.RowHeadersVisible = False
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItems.Size = New Size(835, 180)
        dgvItems.TabIndex = 0
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.BackColor = Color.Transparent
        lblRecentTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.ForeColor = Color.White
        lblRecentTitle.Location = New Point(35, 275)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(72, 20)
        lblRecentTitle.TabIndex = 5
        lblRecentTitle.Text = "All Items"
        ' 
        ' pnlItemsIN
        ' 
        pnlItemsIN.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlItemsIN.Controls.Add(TextBox2)
        pnlItemsIN.Controls.Add(TextBox1)
        pnlItemsIN.Controls.Add(txtUsername)
        pnlItemsIN.Controls.Add(btnINAdd)
        pnlItemsIN.Controls.Add(lblINQuan)
        pnlItemsIN.Controls.Add(lblINCategory)
        pnlItemsIN.Controls.Add(lblItemsINTitle)
        pnlItemsIN.Location = New Point(55, 120)
        pnlItemsIN.Name = "pnlItemsIN"
        pnlItemsIN.Size = New Size(785, 123)
        pnlItemsIN.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(414, 62)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(80, 27)
        TextBox2.TabIndex = 14
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(228, 63)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(115, 27)
        TextBox1.TabIndex = 13
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(36, 62)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(115, 27)
        txtUsername.TabIndex = 12
        ' 
        ' btnINAdd
        ' 
        btnINAdd.AutoSize = True
        btnINAdd.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        btnINAdd.Cursor = Cursors.Hand
        btnINAdd.FlatAppearance.BorderSize = 0
        btnINAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        btnINAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnINAdd.FlatStyle = FlatStyle.Flat
        btnINAdd.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnINAdd.ForeColor = Color.White
        btnINAdd.Location = New Point(608, 58)
        btnINAdd.Name = "btnINAdd"
        btnINAdd.Size = New Size(135, 32)
        btnINAdd.TabIndex = 11
        btnINAdd.Text = "+ ADD ITEM"
        btnINAdd.UseVisualStyleBackColor = False
        ' 
        ' lblINQuan
        ' 
        lblINQuan.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblINQuan.Location = New Point(414, 20)
        lblINQuan.Name = "lblINQuan"
        lblINQuan.Size = New Size(200, 25)
        lblINQuan.TabIndex = 4
        lblINQuan.Text = "QUANTITY"
        ' 
        ' lblINCategory
        ' 
        lblINCategory.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblINCategory.Location = New Point(228, 20)
        lblINCategory.Name = "lblINCategory"
        lblINCategory.Size = New Size(200, 25)
        lblINCategory.TabIndex = 3
        lblINCategory.Text = "CATEGORY"
        ' 
        ' lblItemsINTitle
        ' 
        lblItemsINTitle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblItemsINTitle.Location = New Point(36, 20)
        lblItemsINTitle.Name = "lblItemsINTitle"
        lblItemsINTitle.Size = New Size(200, 25)
        lblItemsINTitle.TabIndex = 0
        lblItemsINTitle.Text = "ITEMS NAME"
        ' 
        ' lblINdesc
        ' 
        lblINdesc.AutoSize = True
        lblINdesc.BackColor = Color.Transparent
        lblINdesc.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblINdesc.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblINdesc.Location = New Point(37, 70)
        lblINdesc.Name = "lblINdesc"
        lblINdesc.Size = New Size(183, 15)
        lblINdesc.TabIndex = 1
        lblINdesc.Text = "Log new stocks arriving the shop."
        ' 
        ' lblINhandling
        ' 
        lblINhandling.AutoSize = True
        lblINhandling.BackColor = Color.Transparent
        lblINhandling.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblINhandling.ForeColor = Color.White
        lblINhandling.Location = New Point(35, 30)
        lblINhandling.Name = "lblINhandling"
        lblINhandling.Size = New Size(267, 40)
        lblINhandling.TabIndex = 0
        lblINhandling.Text = "Items IN Handling"
        ' 
        ' ucItemsIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(12))
        Controls.Add(pnlMain)
        Name = "ucItemsIn"
        Size = New Size(963, 619)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlPlacement.ResumeLayout(False)
        pnlPlacement.PerformLayout()
        pnlTransactions.ResumeLayout(False)
        CType(dgvItems, ComponentModel.ISupportInitialize).EndInit()
        pnlItemsIN.ResumeLayout(False)
        pnlItemsIN.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlPlacement As Panel
    Friend WithEvents lblPlacementStatus As Label
    Friend WithEvents lblPlacementInfo As Label
    Friend WithEvents lblPlacementTitle As Label
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents colItemName As DataGridViewTextBoxColumn
    Friend WithEvents colCategory As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colDateAdded As DataGridViewTextBoxColumn
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents pnlItemsIN As Panel
    Friend WithEvents lblItemsINTitle As Label
    Friend WithEvents lblINdesc As Label
    Friend WithEvents lblINhandling As Label
    Friend WithEvents lblINQuan As Label
    Friend WithEvents lblINCategory As Label
    Friend WithEvents btnINAdd As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtUsername As TextBox

End Class
