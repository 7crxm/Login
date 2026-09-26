<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucItemsOut
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        pnlSalesSummary = New Panel()
        lblSalesSummaryStatus = New Label()
        lblSalesSummaryInfo = New Label()
        lblSalesSummaryTitle = New Label()
        pnlTransactions = New Panel()
        dgvSales = New DataGridView()
        colSaleItem = New DataGridViewTextBoxColumn()
        colSaleQty = New DataGridViewTextBoxColumn()
        colSalePrice = New DataGridViewTextBoxColumn()
        colSaleDate = New DataGridViewTextBoxColumn()
        lblRecentTitle = New Label()
        pnlItemsOUT = New Panel()
        btnOUTAdd = New Button()
        txtPrice = New TextBox()
        lblOUTPrice = New Label()
        txtQty = New TextBox()
        lblOUTQty = New Label()
        cboItem = New ComboBox()
        lblItemsOUTTitle = New Label()
        lblOUTdesc = New Label()
        lblOUThandling = New Label()
        pnlMain.SuspendLayout()
        pnlSalesSummary.SuspendLayout()
        pnlTransactions.SuspendLayout()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        pnlItemsOUT.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlSalesSummary)
        pnlMain.Controls.Add(lblSalesSummaryTitle)
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(lblRecentTitle)
        pnlMain.Controls.Add(pnlItemsOUT)
        pnlMain.Controls.Add(lblOUTdesc)
        pnlMain.Controls.Add(lblOUThandling)
        pnlMain.Location = New Point(3, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(960, 630)
        pnlMain.TabIndex = 3
        ' 
        ' pnlSalesSummary
        ' 
        pnlSalesSummary.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlSalesSummary.Controls.Add(lblSalesSummaryStatus)
        pnlSalesSummary.Controls.Add(lblSalesSummaryInfo)
        pnlSalesSummary.Location = New Point(35, 524)
        pnlSalesSummary.Name = "pnlSalesSummary"
        pnlSalesSummary.Size = New Size(855, 55)
        pnlSalesSummary.TabIndex = 8
        ' 
        ' lblSalesSummaryStatus
        ' 
        lblSalesSummaryStatus.AutoSize = True
        lblSalesSummaryStatus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSalesSummaryStatus.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblSalesSummaryStatus.Location = New Point(750, 20)
        lblSalesSummaryStatus.Name = "lblSalesSummaryStatus"
        lblSalesSummaryStatus.Size = New Size(45, 15)
        lblSalesSummaryStatus.TabIndex = 10
        lblSalesSummaryStatus.Text = "DONE"
        ' 
        ' lblSalesSummaryInfo
        ' 
        lblSalesSummaryInfo.AutoSize = True
        lblSalesSummaryInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSalesSummaryInfo.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblSalesSummaryInfo.Location = New Point(20, 19)
        lblSalesSummaryInfo.Name = "lblSalesSummaryInfo"
        lblSalesSummaryInfo.Size = New Size(199, 15)
        lblSalesSummaryInfo.TabIndex = 9
        lblSalesSummaryInfo.Text = "0 items sold today"
        ' 
        ' lblSalesSummaryTitle
        ' 
        lblSalesSummaryTitle.AutoSize = True
        lblSalesSummaryTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSalesSummaryTitle.ForeColor = Color.White
        lblSalesSummaryTitle.Location = New Point(35, 498)
        lblSalesSummaryTitle.Name = "lblSalesSummaryTitle"
        lblSalesSummaryTitle.Size = New Size(128, 20)
        lblSalesSummaryTitle.TabIndex = 7
        lblSalesSummaryTitle.Text = "TODAY'S SALES"
        ' 
        ' pnlTransactions
        ' --  scrollable grid bound to dbo.Sales
        ' 
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(dgvSales)
        pnlTransactions.Location = New Point(35, 315)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Padding = New Padding(10)
        pnlTransactions.Size = New Size(855, 200)
        pnlTransactions.TabIndex = 6
        ' 
        ' dgvSales
        ' 
        dgvSales.AllowUserToAddRows = False
        dgvSales.AllowUserToDeleteRows = False
        dgvSales.AutoGenerateColumns = False
        dgvSales.BackgroundColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvSales.BorderStyle = BorderStyle.None
        dgvSales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        dgvSales.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvSales.Columns.AddRange(New DataGridViewColumn() {colSaleItem, colSaleQty, colSalePrice, colSaleDate})
        dgvSales.DefaultCellStyle.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvSales.DefaultCellStyle.ForeColor = Color.White
        dgvSales.DefaultCellStyle.SelectionBackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        dgvSales.Dock = DockStyle.Fill
        dgvSales.EnableHeadersVisualStyles = False
        dgvSales.GridColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        dgvSales.Location = New Point(10, 10)
        dgvSales.Name = "dgvSales"
        dgvSales.ReadOnly = True
        dgvSales.RowHeadersVisible = False
        dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSales.Size = New Size(835, 180)
        dgvSales.TabIndex = 0
        ' 
        ' colSaleItem
        ' 
        colSaleItem.DataPropertyName = "ItemName"
        colSaleItem.HeaderText = "ITEM"
        colSaleItem.Name = "colSaleItem"
        colSaleItem.ReadOnly = True
        colSaleItem.Width = 260
        ' 
        ' colSaleQty
        ' 
        colSaleQty.DataPropertyName = "Quantity"
        colSaleQty.HeaderText = "QTY"
        colSaleQty.Name = "colSaleQty"
        colSaleQty.ReadOnly = True
        colSaleQty.Width = 70
        ' 
        ' colSalePrice
        ' 
        colSalePrice.DataPropertyName = "Price"
        colSalePrice.DefaultCellStyle.Format = "₱#,##0.00"
        colSalePrice.HeaderText = "PRICE"
        colSalePrice.Name = "colSalePrice"
        colSalePrice.ReadOnly = True
        colSalePrice.Width = 110
        ' 
        ' colSaleDate
        ' 
        colSaleDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colSaleDate.DataPropertyName = "DateSold"
        colSaleDate.DefaultCellStyle.Format = "MMM d, yyyy"
        colSaleDate.HeaderText = "DATE SOLD"
        colSaleDate.Name = "colSaleDate"
        colSaleDate.ReadOnly = True
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.BackColor = Color.Transparent
        lblRecentTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.ForeColor = Color.White
        lblRecentTitle.Location = New Point(35, 275)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(96, 20)
        lblRecentTitle.TabIndex = 5
        lblRecentTitle.Text = "Recent Sales"
        ' 
        ' pnlItemsOUT
        ' 
        pnlItemsOUT.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlItemsOUT.Controls.Add(btnOUTAdd)
        pnlItemsOUT.Controls.Add(txtPrice)
        pnlItemsOUT.Controls.Add(lblOUTPrice)
        pnlItemsOUT.Controls.Add(txtQty)
        pnlItemsOUT.Controls.Add(lblOUTQty)
        pnlItemsOUT.Controls.Add(cboItem)
        pnlItemsOUT.Controls.Add(lblItemsOUTTitle)
        pnlItemsOUT.Location = New Point(55, 120)
        pnlItemsOUT.Name = "pnlItemsOUT"
        pnlItemsOUT.Size = New Size(785, 123)
        pnlItemsOUT.TabIndex = 2
        ' 
        ' lblItemsOUTTitle
        ' 
        lblItemsOUTTitle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblItemsOUTTitle.Location = New Point(36, 20)
        lblItemsOUTTitle.Name = "lblItemsOUTTitle"
        lblItemsOUTTitle.Size = New Size(200, 25)
        lblItemsOUTTitle.TabIndex = 0
        lblItemsOUTTitle.Text = "ITEM"
        ' 
        ' cboItem  -- DropDownList so a sale
        '            always resolves to a real ItemID, never a typed guess.
        ' 
        cboItem.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        cboItem.DropDownStyle = ComboBoxStyle.DropDownList
        cboItem.FlatStyle = FlatStyle.Flat
        cboItem.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboItem.ForeColor = Color.White
        cboItem.FormattingEnabled = True
        cboItem.Location = New Point(36, 62)
        cboItem.Name = "cboItem"
        cboItem.Size = New Size(160, 28)
        cboItem.TabIndex = 12
        ' 
        ' lblOUTQty
        ' 
        lblOUTQty.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblOUTQty.Location = New Point(228, 20)
        lblOUTQty.Name = "lblOUTQty"
        lblOUTQty.Size = New Size(200, 25)
        lblOUTQty.TabIndex = 3
        lblOUTQty.Text = "QTY SOLD"
        ' 
        ' txtQty
        ' 
        txtQty.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtQty.BorderStyle = BorderStyle.FixedSingle
        txtQty.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtQty.ForeColor = Color.White
        txtQty.Location = New Point(228, 63)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(115, 27)
        txtQty.TabIndex = 13
        ' 
        ' lblOUTPrice
        ' 
        lblOUTPrice.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblOUTPrice.Location = New Point(414, 20)
        lblOUTPrice.Name = "lblOUTPrice"
        lblOUTPrice.Size = New Size(200, 25)
        lblOUTPrice.TabIndex = 4
        lblOUTPrice.Text = "SALE PRICE"
        ' 
        ' txtPrice
        ' 
        txtPrice.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtPrice.BorderStyle = BorderStyle.FixedSingle
        txtPrice.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPrice.ForeColor = Color.White
        txtPrice.Location = New Point(414, 62)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(80, 27)
        txtPrice.TabIndex = 14
        ' 
        ' btnOUTAdd
        ' 
        btnOUTAdd.AutoSize = True
        btnOUTAdd.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        btnOUTAdd.Cursor = Cursors.Hand
        btnOUTAdd.FlatAppearance.BorderSize = 0
        btnOUTAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        btnOUTAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnOUTAdd.FlatStyle = FlatStyle.Flat
        btnOUTAdd.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOUTAdd.ForeColor = Color.White
        btnOUTAdd.Location = New Point(608, 58)
        btnOUTAdd.Name = "btnOUTAdd"
        btnOUTAdd.Size = New Size(135, 32)
        btnOUTAdd.TabIndex = 11
        btnOUTAdd.Text = "MARK SOLD"
        btnOUTAdd.UseVisualStyleBackColor = False
        ' 
        ' lblOUTdesc
        ' 
        lblOUTdesc.AutoSize = True
        lblOUTdesc.BackColor = Color.Transparent
        lblOUTdesc.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOUTdesc.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblOUTdesc.Location = New Point(37, 70)
        lblOUTdesc.Name = "lblOUTdesc"
        lblOUTdesc.Size = New Size(217, 15)
        lblOUTdesc.TabIndex = 1
        lblOUTdesc.Text = "Log a sale and take it out of stock."
        ' 
        ' lblOUThandling
        ' 
        lblOUThandling.AutoSize = True
        lblOUThandling.BackColor = Color.Transparent
        lblOUThandling.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOUThandling.ForeColor = Color.White
        lblOUThandling.Location = New Point(35, 30)
        lblOUThandling.Name = "lblOUThandling"
        lblOUThandling.Size = New Size(310, 40)
        lblOUThandling.TabIndex = 0
        lblOUThandling.Text = "Items OUT Handling"
        ' 
        ' ucItemsOut
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(12))
        Controls.Add(pnlMain)
        Name = "ucItemsOut"
        Size = New Size(963, 619)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlSalesSummary.ResumeLayout(False)
        pnlSalesSummary.PerformLayout()
        pnlTransactions.ResumeLayout(False)
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        pnlItemsOUT.ResumeLayout(False)
        pnlItemsOUT.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlSalesSummary As Panel
    Friend WithEvents lblSalesSummaryStatus As Label
    Friend WithEvents lblSalesSummaryInfo As Label
    Friend WithEvents lblSalesSummaryTitle As Label
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents colSaleItem As DataGridViewTextBoxColumn
    Friend WithEvents colSaleQty As DataGridViewTextBoxColumn
    Friend WithEvents colSalePrice As DataGridViewTextBoxColumn
    Friend WithEvents colSaleDate As DataGridViewTextBoxColumn
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents pnlItemsOUT As Panel
    Friend WithEvents lblItemsOUTTitle As Label
    Friend WithEvents lblOUTdesc As Label
    Friend WithEvents lblOUThandling As Label
    Friend WithEvents lblOUTQty As Label
    Friend WithEvents lblOUTPrice As Label
    Friend WithEvents btnOUTAdd As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents cboItem As ComboBox

End Class