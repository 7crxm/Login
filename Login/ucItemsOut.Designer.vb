<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucItemsOut
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        pnlSalesSummary = New Panel()
        lblSalesSummaryStatus = New Label()
        lblSalesSummaryInfo = New Label()
        lblSalesSummaryTitle = New Label()
        pnlTransactions = New Panel()
        lblDate3 = New Label()
        lblPrice3 = New Label()
        lblQty3 = New Label()
        lblOUTitem3 = New Label()
        lblDate2 = New Label()
        lblPrice2 = New Label()
        lblQty2 = New Label()
        lblOUTitem2 = New Label()
        lblDate1 = New Label()
        lblPrice1 = New Label()
        lblQty1 = New Label()
        lblOUTitem1 = New Label()
        lblHeaderDate = New Label()
        lblHeaderPrice = New Label()
        lblHeaderQty = New Label()
        lblHeaderItem = New Label()
        lblRecentTitle = New Label()
        pnlItemsOUT = New Panel()
        btnOUTAdd = New Button()
        txtPrice = New TextBox()
        lblOUTPrice = New Label()
        txtQty = New TextBox()
        lblOUTQty = New Label()
        txtItemName = New TextBox()
        lblItemsOUTTitle = New Label()
        lblOUTdesc = New Label()
        lblOUThandling = New Label()
        pnlMain.SuspendLayout()
        pnlSalesSummary.SuspendLayout()
        pnlTransactions.SuspendLayout()
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
        lblSalesSummaryStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        lblSalesSummaryInfo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSalesSummaryInfo.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblSalesSummaryInfo.Location = New Point(20, 19)
        lblSalesSummaryInfo.Name = "lblSalesSummaryInfo"
        lblSalesSummaryInfo.Size = New Size(199, 15)
        lblSalesSummaryInfo.TabIndex = 9
        lblSalesSummaryInfo.Text = "5 items sold today"
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
        ' 
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(lblDate3)
        pnlTransactions.Controls.Add(lblPrice3)
        pnlTransactions.Controls.Add(lblQty3)
        pnlTransactions.Controls.Add(lblOUTitem3)
        pnlTransactions.Controls.Add(lblDate2)
        pnlTransactions.Controls.Add(lblPrice2)
        pnlTransactions.Controls.Add(lblQty2)
        pnlTransactions.Controls.Add(lblOUTitem2)
        pnlTransactions.Controls.Add(lblDate1)
        pnlTransactions.Controls.Add(lblPrice1)
        pnlTransactions.Controls.Add(lblQty1)
        pnlTransactions.Controls.Add(lblOUTitem1)
        pnlTransactions.Controls.Add(lblHeaderDate)
        pnlTransactions.Controls.Add(lblHeaderPrice)
        pnlTransactions.Controls.Add(lblHeaderQty)
        pnlTransactions.Controls.Add(lblHeaderItem)
        pnlTransactions.Location = New Point(35, 315)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Size = New Size(855, 180)
        pnlTransactions.TabIndex = 6
        ' 
        ' lblHeaderItem
        ' 
        lblHeaderItem.AutoSize = True
        lblHeaderItem.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderItem.Location = New Point(20, 15)
        lblHeaderItem.Name = "lblHeaderItem"
        lblHeaderItem.Size = New Size(33, 15)
        lblHeaderItem.TabIndex = 0
        lblHeaderItem.Text = "ITEM"
        ' 
        ' lblHeaderQty
        ' 
        lblHeaderQty.AutoSize = True
        lblHeaderQty.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderQty.Location = New Point(248, 15)
        lblHeaderQty.Name = "lblHeaderQty"
        lblHeaderQty.Size = New Size(28, 15)
        lblHeaderQty.TabIndex = 1
        lblHeaderQty.Text = "QTY"
        ' 
        ' lblHeaderPrice
        ' 
        lblHeaderPrice.AutoSize = True
        lblHeaderPrice.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderPrice.Location = New Point(434, 15)
        lblHeaderPrice.Name = "lblHeaderPrice"
        lblHeaderPrice.Size = New Size(37, 15)
        lblHeaderPrice.TabIndex = 2
        lblHeaderPrice.Text = "PRICE"
        ' 
        ' lblHeaderDate
        ' 
        lblHeaderDate.AutoSize = True
        lblHeaderDate.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderDate.Location = New Point(549, 15)
        lblHeaderDate.Name = "lblHeaderDate"
        lblHeaderDate.Size = New Size(34, 15)
        lblHeaderDate.TabIndex = 3
        lblHeaderDate.Text = "DATE"
        ' 
        ' lblOUTitem1
        ' 
        lblOUTitem1.AutoSize = True
        lblOUTitem1.ForeColor = Color.White
        lblOUTitem1.Location = New Point(20, 55)
        lblOUTitem1.Name = "lblOUTitem1"
        lblOUTitem1.Size = New Size(42, 15)
        lblOUTitem1.TabIndex = 4
        lblOUTitem1.Text = "T-Shirt"
        ' 
        ' lblQty1
        ' 
        lblQty1.AutoSize = True
        lblQty1.ForeColor = Color.White
        lblQty1.Location = New Point(248, 55)
        lblQty1.Name = "lblQty1"
        lblQty1.Size = New Size(13, 15)
        lblQty1.TabIndex = 5
        lblQty1.Text = "2"
        ' 
        ' lblPrice1
        ' 
        lblPrice1.AutoSize = True
        lblPrice1.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblPrice1.Location = New Point(434, 55)
        lblPrice1.Name = "lblPrice1"
        lblPrice1.Size = New Size(40, 15)
        lblPrice1.TabIndex = 6
        lblPrice1.Text = "₱300"
        ' 
        ' lblDate1
        ' 
        lblDate1.AutoSize = True
        lblDate1.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate1.Location = New Point(549, 55)
        lblDate1.Name = "lblDate1"
        lblDate1.Size = New Size(65, 15)
        lblDate1.TabIndex = 7
        lblDate1.Text = "Sep 5, 2026"
        ' 
        ' lblOUTitem2
        ' 
        lblOUTitem2.AutoSize = True
        lblOUTitem2.ForeColor = Color.White
        lblOUTitem2.Location = New Point(20, 90)
        lblOUTitem2.Name = "lblOUTitem2"
        lblOUTitem2.Size = New Size(70, 15)
        lblOUTitem2.TabIndex = 8
        lblOUTitem2.Text = "Cargo Pants"
        ' 
        ' lblQty2
        ' 
        lblQty2.AutoSize = True
        lblQty2.ForeColor = Color.White
        lblQty2.Location = New Point(248, 90)
        lblQty2.Name = "lblQty2"
        lblQty2.Size = New Size(13, 15)
        lblQty2.TabIndex = 9
        lblQty2.Text = "1"
        ' 
        ' lblPrice2
        ' 
        lblPrice2.AutoSize = True
        lblPrice2.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblPrice2.Location = New Point(434, 90)
        lblPrice2.Name = "lblPrice2"
        lblPrice2.Size = New Size(40, 15)
        lblPrice2.TabIndex = 10
        lblPrice2.Text = "₱180"
        ' 
        ' lblDate2
        ' 
        lblDate2.AutoSize = True
        lblDate2.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate2.Location = New Point(549, 90)
        lblDate2.Name = "lblDate2"
        lblDate2.Size = New Size(65, 15)
        lblDate2.TabIndex = 11
        lblDate2.Text = "Sep 5, 2026"
        ' 
        ' lblOUTitem3
        ' 
        lblOUTitem3.AutoSize = True
        lblOUTitem3.ForeColor = Color.White
        lblOUTitem3.Location = New Point(20, 125)
        lblOUTitem3.Name = "lblOUTitem3"
        lblOUTitem3.Size = New Size(50, 15)
        lblOUTitem3.TabIndex = 12
        lblOUTitem3.Text = "Hoodie"
        ' 
        ' lblQty3
        ' 
        lblQty3.AutoSize = True
        lblQty3.ForeColor = Color.White
        lblQty3.Location = New Point(248, 125)
        lblQty3.Name = "lblQty3"
        lblQty3.Size = New Size(13, 15)
        lblQty3.TabIndex = 13
        lblQty3.Text = "1"
        ' 
        ' lblPrice3
        ' 
        lblPrice3.AutoSize = True
        lblPrice3.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblPrice3.Location = New Point(434, 125)
        lblPrice3.Name = "lblPrice3"
        lblPrice3.Size = New Size(40, 15)
        lblPrice3.TabIndex = 14
        lblPrice3.Text = "₱220"
        ' 
        ' lblDate3
        ' 
        lblDate3.AutoSize = True
        lblDate3.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate3.Location = New Point(549, 125)
        lblDate3.Name = "lblDate3"
        lblDate3.Size = New Size(65, 15)
        lblDate3.TabIndex = 15
        lblDate3.Text = "Sep 5, 2026"
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
        pnlItemsOUT.Controls.Add(txtItemName)
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
        lblItemsOUTTitle.Text = "ITEM NAME"
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
        ' lblOUTQty
        ' 
        lblOUTQty.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblOUTQty.Location = New Point(228, 20)
        lblOUTQty.Name = "lblOUTQty"
        lblOUTQty.Size = New Size(200, 25)
        lblOUTQty.TabIndex = 3
        lblOUTQty.Text = "QUANTITY"
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
        lblOUTdesc.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        AutoScaleDimensions = New SizeF(7F, 15F)
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
        pnlTransactions.PerformLayout()
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
    Friend WithEvents lblDate3 As Label
    Friend WithEvents lblPrice3 As Label
    Friend WithEvents lblQty3 As Label
    Friend WithEvents lblOUTitem3 As Label
    Friend WithEvents lblDate2 As Label
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents lblQty2 As Label
    Friend WithEvents lblOUTitem2 As Label
    Friend WithEvents lblDate1 As Label
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents lblQty1 As Label
    Friend WithEvents lblOUTitem1 As Label
    Friend WithEvents lblHeaderDate As Label
    Friend WithEvents lblHeaderPrice As Label
    Friend WithEvents lblHeaderQty As Label
    Friend WithEvents lblHeaderItem As Label
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
    Friend WithEvents txtItemName As TextBox

End Class
