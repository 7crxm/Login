<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucPlacement
    Inherits System.Windows.Forms.UserControl

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        pnlPlacementSummary = New Panel()
        lblPlacementSummaryStatus = New Label()
        lblPlacementSummaryInfo = New Label()
        lblPlacementSummaryTitle = New Label()
        pnlTransactions = New Panel()
        dgvPlacement = New DataGridView()
        colItemID = New DataGridViewTextBoxColumn()
        colItemName = New DataGridViewTextBoxColumn()
        colCategory = New DataGridViewTextBoxColumn()
        colQuantity = New DataGridViewTextBoxColumn()
        colDateAdded = New DataGridViewTextBoxColumn()
        lblRecentTitle = New Label()
        btnMarkPlaced = New Button()
        lblPLdesc = New Label()
        lblPLhandling = New Label()
        pnlMain.SuspendLayout()
        pnlPlacementSummary.SuspendLayout()
        pnlTransactions.SuspendLayout()
        CType(dgvPlacement, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlPlacementSummary)
        pnlMain.Controls.Add(lblPlacementSummaryTitle)
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(lblRecentTitle)
        pnlMain.Controls.Add(btnMarkPlaced)
        pnlMain.Controls.Add(lblPLdesc)
        pnlMain.Controls.Add(lblPLhandling)
        pnlMain.Location = New Point(3, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(960, 630)
        pnlMain.TabIndex = 3
        ' 
        ' pnlPlacementSummary
        ' 
        pnlPlacementSummary.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlPlacementSummary.Controls.Add(lblPlacementSummaryStatus)
        pnlPlacementSummary.Controls.Add(lblPlacementSummaryInfo)
        pnlPlacementSummary.Location = New Point(35, 524)
        pnlPlacementSummary.Name = "pnlPlacementSummary"
        pnlPlacementSummary.Size = New Size(855, 55)
        pnlPlacementSummary.TabIndex = 8
        ' 
        ' lblPlacementSummaryStatus
        ' 
        lblPlacementSummaryStatus.AutoSize = True
        lblPlacementSummaryStatus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlacementSummaryStatus.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblPlacementSummaryStatus.Location = New Point(750, 20)
        lblPlacementSummaryStatus.Name = "lblPlacementSummaryStatus"
        lblPlacementSummaryStatus.Size = New Size(45, 15)
        lblPlacementSummaryStatus.TabIndex = 10
        lblPlacementSummaryStatus.Text = "READY"
        ' 
        ' lblPlacementSummaryInfo
        ' 
        lblPlacementSummaryInfo.AutoSize = True
        lblPlacementSummaryInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlacementSummaryInfo.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblPlacementSummaryInfo.Location = New Point(20, 19)
        lblPlacementSummaryInfo.Name = "lblPlacementSummaryInfo"
        lblPlacementSummaryInfo.Size = New Size(260, 15)
        lblPlacementSummaryInfo.TabIndex = 9
        lblPlacementSummaryInfo.Text = "0 items scheduled for display today"
        ' 
        ' lblPlacementSummaryTitle
        ' 
        lblPlacementSummaryTitle.AutoSize = True
        lblPlacementSummaryTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlacementSummaryTitle.ForeColor = Color.White
        lblPlacementSummaryTitle.Location = New Point(35, 498)
        lblPlacementSummaryTitle.Name = "lblPlacementSummaryTitle"
        lblPlacementSummaryTitle.Size = New Size(128, 20)
        lblPlacementSummaryTitle.TabIndex = 7
        lblPlacementSummaryTitle.Text = "ITEM PLACEMENT"
        ' 
        ' pnlTransactions
        ' -- was 3 fixed label rows, now a scrollable grid bound to real data
        ' 
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(dgvPlacement)
        pnlTransactions.Location = New Point(35, 140)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Padding = New Padding(10)
        pnlTransactions.Size = New Size(855, 374)
        pnlTransactions.TabIndex = 6
        ' 
        ' dgvPlacement
        ' 
        dgvPlacement.AllowUserToAddRows = False
        dgvPlacement.AllowUserToDeleteRows = False
        dgvPlacement.AutoGenerateColumns = False
        dgvPlacement.BackgroundColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvPlacement.BorderStyle = BorderStyle.None
        dgvPlacement.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        dgvPlacement.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        dgvPlacement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPlacement.Columns.AddRange(New DataGridViewColumn() {colItemID, colItemName, colCategory, colQuantity, colDateAdded})
        dgvPlacement.DefaultCellStyle.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvPlacement.DefaultCellStyle.ForeColor = Color.White
        dgvPlacement.DefaultCellStyle.SelectionBackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        dgvPlacement.Dock = DockStyle.Fill
        dgvPlacement.EnableHeadersVisualStyles = False
        dgvPlacement.GridColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        dgvPlacement.Location = New Point(10, 10)
        dgvPlacement.MultiSelect = False
        dgvPlacement.Name = "dgvPlacement"
        dgvPlacement.ReadOnly = True
        dgvPlacement.RowHeadersVisible = False
        dgvPlacement.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPlacement.Size = New Size(835, 354)
        dgvPlacement.TabIndex = 0
        ' 
        ' colItemID  
        ' 
        colItemID.DataPropertyName = "ItemID"
        colItemID.HeaderText = "ID"
        colItemID.Name = "colItemID"
        colItemID.ReadOnly = True
        colItemID.Visible = False
        ' 
        ' colItemName
        ' 
        colItemName.DataPropertyName = "ItemName"
        colItemName.HeaderText = "ITEM"
        colItemName.Name = "colItemName"
        colItemName.ReadOnly = True
        colItemName.Width = 260
        ' 
        ' colCategory
        ' 
        colCategory.DataPropertyName = "Category"
        colCategory.HeaderText = "CATEGORY"
        colCategory.Name = "colCategory"
        colCategory.ReadOnly = True
        colCategory.Width = 180
        ' 
        ' colQuantity
        ' 
        colQuantity.DataPropertyName = "Quantity"
        colQuantity.HeaderText = "QTY"
        colQuantity.Name = "colQuantity"
        colQuantity.ReadOnly = True
        colQuantity.Width = 80
        ' 
        ' colDateAdded
        ' 
        colDateAdded.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colDateAdded.DataPropertyName = "DateAdded"
        colDateAdded.DefaultCellStyle.Format = "MMM d, yyyy"
        colDateAdded.HeaderText = "DATE ADDED"
        colDateAdded.Name = "colDateAdded"
        colDateAdded.ReadOnly = True
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.BackColor = Color.Transparent
        lblRecentTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.ForeColor = Color.White
        lblRecentTitle.Location = New Point(35, 100)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(160, 20)
        lblRecentTitle.TabIndex = 5
        lblRecentTitle.Text = "Waiting for Placement"
        ' 
        ' btnMarkPlaced
        ' 
        btnMarkPlaced.AutoSize = True
        btnMarkPlaced.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        btnMarkPlaced.Cursor = Cursors.Hand
        btnMarkPlaced.FlatAppearance.BorderSize = 0
        btnMarkPlaced.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        btnMarkPlaced.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnMarkPlaced.FlatStyle = FlatStyle.Flat
        btnMarkPlaced.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMarkPlaced.ForeColor = Color.White
        btnMarkPlaced.Location = New Point(680, 60)
        btnMarkPlaced.Name = "btnMarkPlaced"
        btnMarkPlaced.Size = New Size(210, 35)
        btnMarkPlaced.TabIndex = 2
        btnMarkPlaced.Text = "MARK AS PLACED"
        btnMarkPlaced.UseVisualStyleBackColor = False
        ' 
        ' lblPLdesc
        ' 
        lblPLdesc.AutoSize = True
        lblPLdesc.BackColor = Color.Transparent
        lblPLdesc.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPLdesc.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblPLdesc.Location = New Point(37, 70)
        lblPLdesc.Name = "lblPLdesc"
        lblPLdesc.Size = New Size(255, 15)
        lblPLdesc.TabIndex = 1
        lblPLdesc.Text = "Select an item below, then mark it placed."
        ' 
        ' lblPLhandling
        ' 
        lblPLhandling.AutoSize = True
        lblPLhandling.BackColor = Color.Transparent
        lblPLhandling.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPLhandling.ForeColor = Color.White
        lblPLhandling.Location = New Point(35, 30)
        lblPLhandling.Name = "lblPLhandling"
        lblPLhandling.Size = New Size(280, 40)
        lblPLhandling.TabIndex = 0
        lblPLhandling.Text = "Item Placement"
        ' 
        ' ucPlacement
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(12))
        Controls.Add(pnlMain)
        Name = "ucPlacement"
        Size = New Size(963, 619)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlPlacementSummary.ResumeLayout(False)
        pnlPlacementSummary.PerformLayout()
        pnlTransactions.ResumeLayout(False)
        CType(dgvPlacement, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlPlacementSummary As Panel
    Friend WithEvents lblPlacementSummaryStatus As Label
    Friend WithEvents lblPlacementSummaryInfo As Label
    Friend WithEvents lblPlacementSummaryTitle As Label
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents dgvPlacement As DataGridView
    Friend WithEvents colItemID As DataGridViewTextBoxColumn
    Friend WithEvents colItemName As DataGridViewTextBoxColumn
    Friend WithEvents colCategory As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colDateAdded As DataGridViewTextBoxColumn
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents btnMarkPlaced As Button
    Friend WithEvents lblPLdesc As Label
    Friend WithEvents lblPLhandling As Label

End Class