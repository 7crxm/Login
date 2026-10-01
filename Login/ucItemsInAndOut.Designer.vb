<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucItemsInAndOut
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlMain = New Panel()
        pnlTransactions = New Panel()
        dgvSold = New DataGridView()
        lblSoldHeader = New Label()
        dgvInStock = New DataGridView()
        lblInStockHeader = New Label()
        lblRecentTitle = New Label()
        pnlItemsIN = New Panel()
        btnDelete = New Button()
        btnOUTsell = New Button()
        txtQuantity = New TextBox()
        txtCategoryPrice = New TextBox()
        txtItemName = New TextBox()
        btnINAdd = New Button()
        lblINQuan = New Label()
        lblINCategory = New Label()
        lblItemsINTitle = New Label()
        lblINdesc = New Label()
        lblINhandling = New Label()
        pnlMain.SuspendLayout()
        pnlTransactions.SuspendLayout()
        CType(dgvSold, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvInStock, ComponentModel.ISupportInitialize).BeginInit()
        pnlItemsIN.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
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
        ' pnlTransactions
        ' 
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(dgvSold)
        pnlTransactions.Controls.Add(lblSoldHeader)
        pnlTransactions.Controls.Add(dgvInStock)
        pnlTransactions.Controls.Add(lblInStockHeader)
        pnlTransactions.Location = New Point(35, 315)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Padding = New Padding(10)
        pnlTransactions.Size = New Size(855, 240)
        pnlTransactions.TabIndex = 6
        ' 
        ' dgvSold
        ' 
        dgvSold.AllowUserToAddRows = False
        dgvSold.AllowUserToDeleteRows = False
        dgvSold.BackgroundColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvSold.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSold.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSold.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvSold.DefaultCellStyle = DataGridViewCellStyle2
        dgvSold.EnableHeadersVisualStyles = False
        dgvSold.GridColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        dgvSold.Location = New Point(430, 35)
        dgvSold.Name = "dgvSold"
        dgvSold.ReadOnly = True
        dgvSold.RowHeadersVisible = False
        dgvSold.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSold.Size = New Size(405, 195)
        dgvSold.TabIndex = 3
        ' 
        ' lblSoldHeader
        ' 
        lblSoldHeader.AutoSize = True
        lblSoldHeader.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSoldHeader.ForeColor = Color.White
        lblSoldHeader.Location = New Point(430, 8)
        lblSoldHeader.Name = "lblSoldHeader"
        lblSoldHeader.Size = New Size(84, 17)
        lblSoldHeader.TabIndex = 1
        lblSoldHeader.Text = "SOLD ITEMS"
        ' 
        ' dgvInStock
        ' 
        dgvInStock.AllowUserToAddRows = False
        dgvInStock.AllowUserToDeleteRows = False
        dgvInStock.BackgroundColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvInStock.BorderStyle = BorderStyle.None
        dgvInStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvInStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvInStock.DefaultCellStyle = DataGridViewCellStyle2
        dgvInStock.EnableHeadersVisualStyles = False
        dgvInStock.GridColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        dgvInStock.Location = New Point(10, 35)
        dgvInStock.Name = "dgvInStock"
        dgvInStock.ReadOnly = True
        dgvInStock.RowHeadersVisible = False
        dgvInStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInStock.Size = New Size(405, 195)
        dgvInStock.TabIndex = 2
        ' 
        ' lblInStockHeader
        ' 
        lblInStockHeader.AutoSize = True
        lblInStockHeader.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInStockHeader.ForeColor = Color.White
        lblInStockHeader.Location = New Point(10, 8)
        lblInStockHeader.Name = "lblInStockHeader"
        lblInStockHeader.Size = New Size(67, 17)
        lblInStockHeader.TabIndex = 0
        lblInStockHeader.Text = "IN STOCK"
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.BackColor = Color.Transparent
        lblRecentTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.ForeColor = Color.White
        lblRecentTitle.Location = New Point(35, 275)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(78, 20)
        lblRecentTitle.TabIndex = 5
        lblRecentTitle.Text = "Inventory"
        ' 
        ' pnlItemsIN
        ' 
        pnlItemsIN.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlItemsIN.Controls.Add(btnDelete)
        pnlItemsIN.Controls.Add(btnOUTsell)
        pnlItemsIN.Controls.Add(txtQuantity)
        pnlItemsIN.Controls.Add(txtCategoryPrice)
        pnlItemsIN.Controls.Add(txtItemName)
        pnlItemsIN.Controls.Add(btnINAdd)
        pnlItemsIN.Controls.Add(lblINQuan)
        pnlItemsIN.Controls.Add(lblINCategory)
        pnlItemsIN.Controls.Add(lblItemsINTitle)
        pnlItemsIN.Location = New Point(21, 120)
        pnlItemsIN.Name = "pnlItemsIN"
        pnlItemsIN.Size = New Size(890, 123)
        pnlItemsIN.TabIndex = 2
        ' 
        ' btnDelete
        ' 
        btnDelete.AutoSize = True
        btnDelete.BackColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(185), CByte(28), CByte(28))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(776, 57)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(95, 32)
        btnDelete.TabIndex = 16
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnOUTsell
        ' 
        btnOUTsell.AutoSize = True
        btnOUTsell.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        btnOUTsell.Cursor = Cursors.Hand
        btnOUTsell.FlatAppearance.BorderSize = 0
        btnOUTsell.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        btnOUTsell.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnOUTsell.FlatStyle = FlatStyle.Flat
        btnOUTsell.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOUTsell.ForeColor = Color.White
        btnOUTsell.Location = New Point(654, 57)
        btnOUTsell.Name = "btnOUTsell"
        btnOUTsell.Size = New Size(107, 32)
        btnOUTsell.TabIndex = 15
        btnOUTsell.Text = "- SELL ITEM"
        btnOUTsell.UseVisualStyleBackColor = False
        ' 
        ' txtQuantity
        ' 
        txtQuantity.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtQuantity.BorderStyle = BorderStyle.FixedSingle
        txtQuantity.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtQuantity.ForeColor = Color.White
        txtQuantity.Location = New Point(228, 62)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(80, 27)
        txtQuantity.TabIndex = 13
        ' 
        ' txtCategoryPrice
        ' 
        txtCategoryPrice.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtCategoryPrice.BorderStyle = BorderStyle.FixedSingle
        txtCategoryPrice.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCategoryPrice.ForeColor = Color.White
        txtCategoryPrice.Location = New Point(390, 62)
        txtCategoryPrice.Name = "txtCategoryPrice"
        txtCategoryPrice.Size = New Size(115, 27)
        txtCategoryPrice.TabIndex = 14
        ' 
        ' txtItemName
        ' 
        txtItemName.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtItemName.BorderStyle = BorderStyle.FixedSingle
        txtItemName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtItemName.ForeColor = Color.White
        txtItemName.Location = New Point(36, 62)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(115, 27)
        txtItemName.TabIndex = 12
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
        btnINAdd.Location = New Point(530, 57)
        btnINAdd.Name = "btnINAdd"
        btnINAdd.Size = New Size(107, 32)
        btnINAdd.TabIndex = 11
        btnINAdd.Text = "+ ADD ITEM"
        btnINAdd.UseVisualStyleBackColor = False
        ' 
        ' lblINQuan
        ' 
        lblINQuan.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblINQuan.Location = New Point(228, 20)
        lblINQuan.Name = "lblINQuan"
        lblINQuan.Size = New Size(155, 25)
        lblINQuan.TabIndex = 3
        lblINQuan.Text = "QUANTITY"
        ' 
        ' lblINCategory
        ' 
        lblINCategory.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblINCategory.Location = New Point(390, 20)
        lblINCategory.Name = "lblINCategory"
        lblINCategory.Size = New Size(200, 25)
        lblINCategory.TabIndex = 4
        lblINCategory.Text = "CATEGORY / PRICE"
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
        lblINdesc.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        lblINhandling.Size = New Size(356, 40)
        lblINhandling.TabIndex = 0
        lblINhandling.Text = "Items IN / OUT Handling"
        ' 
        ' ucItemsInAndOut
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(12))
        Controls.Add(pnlMain)
        Name = "ucItemsInAndOut"
        Size = New Size(963, 619)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlTransactions.ResumeLayout(False)
        pnlTransactions.PerformLayout()
        CType(dgvSold, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvInStock, ComponentModel.ISupportInitialize).EndInit()
        pnlItemsIN.ResumeLayout(False)
        pnlItemsIN.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents dgvInStock As DataGridView
    Friend WithEvents dgvSold As DataGridView
    Friend WithEvents lblInStockHeader As Label
    Friend WithEvents lblSoldHeader As Label
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents pnlItemsIN As Panel
    Friend WithEvents lblItemsINTitle As Label
    Friend WithEvents lblINdesc As Label
    Friend WithEvents lblINhandling As Label
    Friend WithEvents lblINQuan As Label
    Friend WithEvents lblINCategory As Label
    Friend WithEvents btnINAdd As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtCategoryPrice As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents btnOUTsell As Button
    Friend WithEvents btnDelete As Button

End Class