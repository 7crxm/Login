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
        pnlTransactions = New Panel()
        dgvPlaced = New DataGridView()
        lblPlacedHeader = New Label()
        dgvAwaiting = New DataGridView()
        colItemID = New DataGridViewTextBoxColumn()
        colItemName = New DataGridViewTextBoxColumn()
        colCategory = New DataGridViewTextBoxColumn()
        colQuantity = New DataGridViewTextBoxColumn()
        colDateAdded = New DataGridViewTextBoxColumn()
        lblAwaitingHeader = New Label()
        lblRecentTitle = New Label()
        btnMarkPlaced = New Button()
        txtLocation = New TextBox()
        lblLocation = New Label()
        lblPLdesc = New Label()
        lblPLhandling = New Label()
        pnlMain.SuspendLayout()
        pnlTransactions.SuspendLayout()
        CType(dgvPlaced, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAwaiting, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' pnlMain
        '
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(lblRecentTitle)
        pnlMain.Controls.Add(btnMarkPlaced)
        pnlMain.Controls.Add(txtLocation)
        pnlMain.Controls.Add(lblLocation)
        pnlMain.Controls.Add(lblPLdesc)
        pnlMain.Controls.Add(lblPLhandling)
        pnlMain.Location = New Point(3, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(960, 630)
        pnlMain.TabIndex = 3
        '
        ' pnlTransactions
        '
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(dgvPlaced)
        pnlTransactions.Controls.Add(lblPlacedHeader)
        pnlTransactions.Controls.Add(dgvAwaiting)
        pnlTransactions.Controls.Add(lblAwaitingHeader)
        pnlTransactions.Location = New Point(35, 140)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Padding = New Padding(10)
        pnlTransactions.Size = New Size(855, 374)
        pnlTransactions.TabIndex = 6
        '
        ' lblAwaitingHeader
        '
        lblAwaitingHeader.AutoSize = True
        lblAwaitingHeader.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAwaitingHeader.ForeColor = Color.White
        lblAwaitingHeader.Location = New Point(10, 8)
        lblAwaitingHeader.Name = "lblAwaitingHeader"
        lblAwaitingHeader.Size = New Size(140, 17)
        lblAwaitingHeader.TabIndex = 0
        lblAwaitingHeader.Text = "AWAITING PLACEMENT"
        '
        ' lblPlacedHeader
        '
        lblPlacedHeader.AutoSize = True
        lblPlacedHeader.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlacedHeader.ForeColor = Color.White
        lblPlacedHeader.Location = New Point(430, 8)
        lblPlacedHeader.Name = "lblPlacedHeader"
        lblPlacedHeader.Size = New Size(130, 17)
        lblPlacedHeader.TabIndex = 1
        lblPlacedHeader.Text = "PLACED (LOCATION)"
        '
        ' dgvAwaiting (was dgvPlacement — renamed now that there are two grids)
        '
        dgvAwaiting.AllowUserToAddRows = False
        dgvAwaiting.AllowUserToDeleteRows = False
        dgvAwaiting.AutoGenerateColumns = False
        dgvAwaiting.BackgroundColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvAwaiting.BorderStyle = BorderStyle.None
        dgvAwaiting.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        dgvAwaiting.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        dgvAwaiting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvAwaiting.Columns.AddRange(New DataGridViewColumn() {colItemID, colItemName, colCategory, colQuantity, colDateAdded})
        dgvAwaiting.DefaultCellStyle.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvAwaiting.DefaultCellStyle.ForeColor = Color.White
        dgvAwaiting.DefaultCellStyle.SelectionBackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        dgvAwaiting.EnableHeadersVisualStyles = False
        dgvAwaiting.GridColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        dgvAwaiting.Location = New Point(10, 35)
        dgvAwaiting.MultiSelect = False
        dgvAwaiting.Name = "dgvAwaiting"
        dgvAwaiting.ReadOnly = True
        dgvAwaiting.RowHeadersVisible = False
        dgvAwaiting.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAwaiting.Size = New Size(405, 329)
        dgvAwaiting.TabIndex = 2
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
        colItemName.Width = 130
        '
        ' colCategory
        '
        colCategory.DataPropertyName = "Category"
        colCategory.HeaderText = "CATEGORY"
        colCategory.Name = "colCategory"
        colCategory.ReadOnly = True
        colCategory.Width = 100
        '
        ' colQuantity
        '
        colQuantity.DataPropertyName = "Quantity"
        colQuantity.HeaderText = "QTY"
        colQuantity.Name = "colQuantity"
        colQuantity.ReadOnly = True
        colQuantity.Width = 60
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
        ' dgvPlaced (Status = 'Placed' — shows where each item currently sits; drops a row the moment it's sold)
        '
        dgvPlaced.AllowUserToAddRows = False
        dgvPlaced.AllowUserToDeleteRows = False
        dgvPlaced.BackgroundColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvPlaced.BorderStyle = BorderStyle.None
        dgvPlaced.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        dgvPlaced.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        dgvPlaced.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPlaced.DefaultCellStyle.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvPlaced.DefaultCellStyle.ForeColor = Color.White
        dgvPlaced.DefaultCellStyle.SelectionBackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        dgvPlaced.EnableHeadersVisualStyles = False
        dgvPlaced.GridColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        dgvPlaced.Location = New Point(430, 35)
        dgvPlaced.MultiSelect = False
        dgvPlaced.Name = "dgvPlaced"
        dgvPlaced.ReadOnly = True
        dgvPlaced.RowHeadersVisible = False
        dgvPlaced.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPlaced.Size = New Size(405, 329)
        dgvPlaced.TabIndex = 3
        '
        ' lblRecentTitle
        '
        lblRecentTitle.AutoSize = True
        lblRecentTitle.BackColor = Color.Transparent
        lblRecentTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.ForeColor = Color.White
        lblRecentTitle.Location = New Point(35, 100)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(93, 20)
        lblRecentTitle.TabIndex = 5
        lblRecentTitle.Text = "Placement"
        '
        ' lblLocation
        '
        lblLocation.AutoSize = True
        lblLocation.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblLocation.Location = New Point(500, 40)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(64, 15)
        lblLocation.TabIndex = 3
        lblLocation.Text = "LOCATION"
        '
        ' txtLocation
        '
        txtLocation.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtLocation.BorderStyle = BorderStyle.FixedSingle
        txtLocation.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLocation.ForeColor = Color.White
        txtLocation.Location = New Point(500, 58)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(160, 27)
        txtLocation.TabIndex = 4
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
        btnMarkPlaced.TabIndex = 5
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
        lblPLdesc.Text = "Select an item below, set its location, then mark it placed."
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
        pnlTransactions.ResumeLayout(False)
        CType(dgvPlaced, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAwaiting, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents dgvAwaiting As DataGridView
    Friend WithEvents colItemID As DataGridViewTextBoxColumn
    Friend WithEvents colItemName As DataGridViewTextBoxColumn
    Friend WithEvents colCategory As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colDateAdded As DataGridViewTextBoxColumn
    Friend WithEvents lblAwaitingHeader As Label
    Friend WithEvents dgvPlaced As DataGridView
    Friend WithEvents lblPlacedHeader As Label
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents btnMarkPlaced As Button
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblPLdesc As Label
    Friend WithEvents lblPLhandling As Label

End Class