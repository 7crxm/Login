<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucBuyingReturns
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
        pnlBuyForm = New Panel()
        btnLogPurchase = New Button()
        txtCost = New TextBox()
        lblBuyCost = New Label()
        cboSupplier = New ComboBox()
        lblBuySupplier = New Label()
        cboBuyItem = New ComboBox()
        lblBuyItem = New Label()
        lblBuyTitle = New Label()
        pnlReturnForm = New Panel()
        btnLogReturn = New Button()
        txtReturnAmount = New TextBox()
        lblRefund = New Label()
        cboReturnItem = New ComboBox()
        lblReturnItem = New Label()
        lblReturnTitle = New Label()
        lblRecentTitle = New Label()
        pnlTransactions = New Panel()
        dgvReturns = New DataGridView()
        lblReturnsHeader = New Label()
        dgvPurchases = New DataGridView()
        lblPurchasesHeader = New Label()
        lblBRdesc = New Label()
        lblBRhandling = New Label()
        pnlMain.SuspendLayout()
        pnlBuyForm.SuspendLayout()
        pnlReturnForm.SuspendLayout()
        pnlTransactions.SuspendLayout()
        CType(dgvReturns, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPurchases, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' pnlMain
        '
        pnlMain.Controls.Add(pnlBuyForm)
        pnlMain.Controls.Add(pnlReturnForm)
        pnlMain.Controls.Add(lblRecentTitle)
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(lblBRdesc)
        pnlMain.Controls.Add(lblBRhandling)
        pnlMain.Location = New Point(3, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(960, 630)
        pnlMain.TabIndex = 3
        '
        ' pnlBuyForm
        '
        pnlBuyForm.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlBuyForm.Controls.Add(btnLogPurchase)
        pnlBuyForm.Controls.Add(txtCost)
        pnlBuyForm.Controls.Add(lblBuyCost)
        pnlBuyForm.Controls.Add(cboSupplier)
        pnlBuyForm.Controls.Add(lblBuySupplier)
        pnlBuyForm.Controls.Add(cboBuyItem)
        pnlBuyForm.Controls.Add(lblBuyItem)
        pnlBuyForm.Controls.Add(lblBuyTitle)
        pnlBuyForm.Location = New Point(35, 120)
        pnlBuyForm.Name = "pnlBuyForm"
        pnlBuyForm.Size = New Size(430, 150)
        pnlBuyForm.TabIndex = 2
        '
        ' lblBuyTitle
        '
        lblBuyTitle.AutoSize = True
        lblBuyTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBuyTitle.ForeColor = Color.White
        lblBuyTitle.Location = New Point(15, 8)
        lblBuyTitle.Name = "lblBuyTitle"
        lblBuyTitle.Size = New Size(30, 17)
        lblBuyTitle.TabIndex = 0
        lblBuyTitle.Text = "BUY"
        '
        ' lblBuyItem
        '
        lblBuyItem.AutoSize = True
        lblBuyItem.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblBuyItem.Location = New Point(15, 32)
        lblBuyItem.Name = "lblBuyItem"
        lblBuyItem.Size = New Size(29, 15)
        lblBuyItem.TabIndex = 1
        lblBuyItem.Text = "ITEM"
        '
        ' cboBuyItem (items not yet tagged with a supplier)
        '
        cboBuyItem.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        cboBuyItem.DropDownStyle = ComboBoxStyle.DropDownList
        cboBuyItem.FlatStyle = FlatStyle.Flat
        cboBuyItem.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboBuyItem.ForeColor = Color.White
        cboBuyItem.FormattingEnabled = True
        cboBuyItem.Location = New Point(15, 50)
        cboBuyItem.Name = "cboBuyItem"
        cboBuyItem.Size = New Size(180, 25)
        cboBuyItem.TabIndex = 10
        '
        ' lblBuySupplier
        '
        lblBuySupplier.AutoSize = True
        lblBuySupplier.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblBuySupplier.Location = New Point(205, 32)
        lblBuySupplier.Name = "lblBuySupplier"
        lblBuySupplier.Size = New Size(57, 15)
        lblBuySupplier.TabIndex = 2
        lblBuySupplier.Text = "SUPPLIER"
        '
        ' cboSupplier
        '
        cboSupplier.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList
        cboSupplier.FlatStyle = FlatStyle.Flat
        cboSupplier.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboSupplier.ForeColor = Color.White
        cboSupplier.FormattingEnabled = True
        cboSupplier.Location = New Point(205, 50)
        cboSupplier.Name = "cboSupplier"
        cboSupplier.Size = New Size(200, 25)
        cboSupplier.TabIndex = 11
        '
        ' lblBuyCost
        '
        lblBuyCost.AutoSize = True
        lblBuyCost.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblBuyCost.Location = New Point(15, 88)
        lblBuyCost.Name = "lblBuyCost"
        lblBuyCost.Size = New Size(33, 15)
        lblBuyCost.TabIndex = 3
        lblBuyCost.Text = "COST"
        '
        ' txtCost
        '
        txtCost.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtCost.BorderStyle = BorderStyle.FixedSingle
        txtCost.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCost.ForeColor = Color.White
        txtCost.Location = New Point(15, 106)
        txtCost.Name = "txtCost"
        txtCost.Size = New Size(100, 27)
        txtCost.TabIndex = 12
        '
        ' btnLogPurchase
        '
        btnLogPurchase.AutoSize = True
        btnLogPurchase.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        btnLogPurchase.Cursor = Cursors.Hand
        btnLogPurchase.FlatAppearance.BorderSize = 0
        btnLogPurchase.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        btnLogPurchase.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnLogPurchase.FlatStyle = FlatStyle.Flat
        btnLogPurchase.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogPurchase.ForeColor = Color.White
        btnLogPurchase.Location = New Point(205, 103)
        btnLogPurchase.Name = "btnLogPurchase"
        btnLogPurchase.Size = New Size(200, 32)
        btnLogPurchase.TabIndex = 13
        btnLogPurchase.Text = "+ LOG PURCHASE"
        btnLogPurchase.UseVisualStyleBackColor = False
        '
        ' pnlReturnForm
        '
        pnlReturnForm.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlReturnForm.Controls.Add(btnLogReturn)
        pnlReturnForm.Controls.Add(txtReturnAmount)
        pnlReturnForm.Controls.Add(lblRefund)
        pnlReturnForm.Controls.Add(cboReturnItem)
        pnlReturnForm.Controls.Add(lblReturnItem)
        pnlReturnForm.Controls.Add(lblReturnTitle)
        pnlReturnForm.Location = New Point(485, 120)
        pnlReturnForm.Name = "pnlReturnForm"
        pnlReturnForm.Size = New Size(430, 150)
        pnlReturnForm.TabIndex = 3
        '
        ' lblReturnTitle
        '
        lblReturnTitle.AutoSize = True
        lblReturnTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReturnTitle.ForeColor = Color.White
        lblReturnTitle.Location = New Point(15, 8)
        lblReturnTitle.Name = "lblReturnTitle"
        lblReturnTitle.Size = New Size(54, 17)
        lblReturnTitle.TabIndex = 0
        lblReturnTitle.Text = "RETURN"
        '
        ' lblReturnItem
        '
        lblReturnItem.AutoSize = True
        lblReturnItem.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblReturnItem.Location = New Point(15, 32)
        lblReturnItem.Name = "lblReturnItem"
        lblReturnItem.Size = New Size(72, 15)
        lblReturnItem.TabIndex = 1
        lblReturnItem.Text = "ITEM (SOLD)"
        '
        ' cboReturnItem (only sold items are eligible for return)
        '
        cboReturnItem.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        cboReturnItem.DropDownStyle = ComboBoxStyle.DropDownList
        cboReturnItem.FlatStyle = FlatStyle.Flat
        cboReturnItem.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboReturnItem.ForeColor = Color.White
        cboReturnItem.FormattingEnabled = True
        cboReturnItem.Location = New Point(15, 50)
        cboReturnItem.Name = "cboReturnItem"
        cboReturnItem.Size = New Size(250, 25)
        cboReturnItem.TabIndex = 10
        '
        ' lblRefund
        '
        lblRefund.AutoSize = True
        lblRefund.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblRefund.Location = New Point(15, 88)
        lblRefund.Name = "lblRefund"
        lblRefund.Size = New Size(101, 15)
        lblRefund.TabIndex = 2
        lblRefund.Text = "REFUND AMOUNT"
        '
        ' txtReturnAmount
        '
        txtReturnAmount.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtReturnAmount.BorderStyle = BorderStyle.FixedSingle
        txtReturnAmount.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtReturnAmount.ForeColor = Color.White
        txtReturnAmount.Location = New Point(15, 106)
        txtReturnAmount.Name = "txtReturnAmount"
        txtReturnAmount.Size = New Size(120, 27)
        txtReturnAmount.TabIndex = 11
        '
        ' btnLogReturn
        '
        btnLogReturn.AutoSize = True
        btnLogReturn.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        btnLogReturn.Cursor = Cursors.Hand
        btnLogReturn.FlatAppearance.BorderSize = 0
        btnLogReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        btnLogReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnLogReturn.FlatStyle = FlatStyle.Flat
        btnLogReturn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogReturn.ForeColor = Color.White
        btnLogReturn.Location = New Point(205, 103)
        btnLogReturn.Name = "btnLogReturn"
        btnLogReturn.Size = New Size(200, 32)
        btnLogReturn.TabIndex = 12
        btnLogReturn.Text = "+ LOG RETURN"
        btnLogReturn.UseVisualStyleBackColor = False
        '
        ' lblRecentTitle
        '
        lblRecentTitle.AutoSize = True
        lblRecentTitle.BackColor = Color.Transparent
        lblRecentTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.ForeColor = Color.White
        lblRecentTitle.Location = New Point(35, 285)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(150, 20)
        lblRecentTitle.TabIndex = 5
        lblRecentTitle.Text = "Purchase & Return Log"
        '
        ' pnlTransactions
        '
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(dgvReturns)
        pnlTransactions.Controls.Add(lblReturnsHeader)
        pnlTransactions.Controls.Add(dgvPurchases)
        pnlTransactions.Controls.Add(lblPurchasesHeader)
        pnlTransactions.Location = New Point(35, 325)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Padding = New Padding(10)
        pnlTransactions.Size = New Size(855, 240)
        pnlTransactions.TabIndex = 6
        '
        ' lblPurchasesHeader
        '
        lblPurchasesHeader.AutoSize = True
        lblPurchasesHeader.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPurchasesHeader.ForeColor = Color.White
        lblPurchasesHeader.Location = New Point(10, 8)
        lblPurchasesHeader.Name = "lblPurchasesHeader"
        lblPurchasesHeader.Size = New Size(80, 17)
        lblPurchasesHeader.TabIndex = 0
        lblPurchasesHeader.Text = "PURCHASES"
        '
        ' lblReturnsHeader
        '
        lblReturnsHeader.AutoSize = True
        lblReturnsHeader.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReturnsHeader.ForeColor = Color.White
        lblReturnsHeader.Location = New Point(430, 8)
        lblReturnsHeader.Name = "lblReturnsHeader"
        lblReturnsHeader.Size = New Size(63, 17)
        lblReturnsHeader.TabIndex = 1
        lblReturnsHeader.Text = "RETURNS"
        '
        ' dgvPurchases
        '
        dgvPurchases.AllowUserToAddRows = False
        dgvPurchases.AllowUserToDeleteRows = False
        dgvPurchases.BackgroundColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvPurchases.BorderStyle = BorderStyle.None
        dgvPurchases.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        dgvPurchases.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        dgvPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPurchases.DefaultCellStyle.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvPurchases.DefaultCellStyle.ForeColor = Color.White
        dgvPurchases.DefaultCellStyle.SelectionBackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        dgvPurchases.EnableHeadersVisualStyles = False
        dgvPurchases.GridColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        dgvPurchases.Location = New Point(10, 35)
        dgvPurchases.Name = "dgvPurchases"
        dgvPurchases.ReadOnly = True
        dgvPurchases.RowHeadersVisible = False
        dgvPurchases.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPurchases.Size = New Size(405, 195)
        dgvPurchases.TabIndex = 2
        '
        ' dgvReturns
        '
        dgvReturns.AllowUserToAddRows = False
        dgvReturns.AllowUserToDeleteRows = False
        dgvReturns.BackgroundColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvReturns.BorderStyle = BorderStyle.None
        dgvReturns.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        dgvReturns.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        dgvReturns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvReturns.DefaultCellStyle.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvReturns.DefaultCellStyle.ForeColor = Color.White
        dgvReturns.DefaultCellStyle.SelectionBackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        dgvReturns.EnableHeadersVisualStyles = False
        dgvReturns.GridColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        dgvReturns.Location = New Point(430, 35)
        dgvReturns.Name = "dgvReturns"
        dgvReturns.ReadOnly = True
        dgvReturns.RowHeadersVisible = False
        dgvReturns.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReturns.Size = New Size(405, 195)
        dgvReturns.TabIndex = 3
        '
        ' lblBRdesc
        '
        lblBRdesc.AutoSize = True
        lblBRdesc.BackColor = Color.Transparent
        lblBRdesc.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBRdesc.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblBRdesc.Location = New Point(37, 70)
        lblBRdesc.Name = "lblBRdesc"
        lblBRdesc.Size = New Size(280, 15)
        lblBRdesc.TabIndex = 1
        lblBRdesc.Text = "Log purchases from suppliers and process returns."
        '
        ' lblBRhandling
        '
        lblBRhandling.AutoSize = True
        lblBRhandling.BackColor = Color.Transparent
        lblBRhandling.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBRhandling.ForeColor = Color.White
        lblBRhandling.Location = New Point(35, 30)
        lblBRhandling.Name = "lblBRhandling"
        lblBRhandling.Size = New Size(340, 40)
        lblBRhandling.TabIndex = 0
        lblBRhandling.Text = "Buying and Returns"
        '
        ' ucBuyingReturns
        '
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(12))
        Controls.Add(pnlMain)
        Name = "ucBuyingReturns"
        Size = New Size(963, 619)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlBuyForm.ResumeLayout(False)
        pnlBuyForm.PerformLayout()
        pnlReturnForm.ResumeLayout(False)
        pnlReturnForm.PerformLayout()
        pnlTransactions.ResumeLayout(False)
        CType(dgvReturns, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPurchases, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlBuyForm As Panel
    Friend WithEvents lblBuyTitle As Label
    Friend WithEvents lblBuyItem As Label
    Friend WithEvents cboBuyItem As ComboBox
    Friend WithEvents lblBuySupplier As Label
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents lblBuyCost As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents btnLogPurchase As Button
    Friend WithEvents pnlReturnForm As Panel
    Friend WithEvents lblReturnTitle As Label
    Friend WithEvents lblReturnItem As Label
    Friend WithEvents cboReturnItem As ComboBox
    Friend WithEvents lblRefund As Label
    Friend WithEvents txtReturnAmount As TextBox
    Friend WithEvents btnLogReturn As Button
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents lblPurchasesHeader As Label
    Friend WithEvents dgvPurchases As DataGridView
    Friend WithEvents lblReturnsHeader As Label
    Friend WithEvents dgvReturns As DataGridView
    Friend WithEvents lblBRdesc As Label
    Friend WithEvents lblBRhandling As Label

End Class