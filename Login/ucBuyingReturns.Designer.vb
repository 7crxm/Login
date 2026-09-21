<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBuyingReturns
    Inherits System.Windows.Forms.UserControl

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        pnlBRSummary = New Panel()
        lblBRSummaryStatus = New Label()
        lblBRSummaryInfo = New Label()
        lblBRSummaryTitle = New Label()
        pnlTransactions = New Panel()
        lblDate3 = New Label()
        lblAmount3 = New Label()
        lblType3 = New Label()
        lblBRitem3 = New Label()
        lblDate2 = New Label()
        lblAmount2 = New Label()
        lblType2 = New Label()
        lblBRitem2 = New Label()
        lblDate1 = New Label()
        lblAmount1 = New Label()
        lblType1 = New Label()
        lblBRitem1 = New Label()
        lblHeaderDate = New Label()
        lblHeaderAmount = New Label()
        lblHeaderType = New Label()
        lblHeaderItem = New Label()
        lblRecentTitle = New Label()
        pnlBRForm = New Panel()
        btnLogEntry = New Button()
        txtAmount = New TextBox()
        lblBRAmount = New Label()
        txtType = New TextBox()
        lblBRType = New Label()
        txtItemName = New TextBox()
        lblBRItemField = New Label()
        lblBRdesc = New Label()
        lblBRhandling = New Label()
        pnlMain.SuspendLayout()
        pnlBRSummary.SuspendLayout()
        pnlTransactions.SuspendLayout()
        pnlBRForm.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlBRSummary)
        pnlMain.Controls.Add(lblBRSummaryTitle)
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(lblRecentTitle)
        pnlMain.Controls.Add(pnlBRForm)
        pnlMain.Controls.Add(lblBRdesc)
        pnlMain.Controls.Add(lblBRhandling)
        pnlMain.Location = New Point(3, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(960, 630)
        pnlMain.TabIndex = 3
        ' 
        ' pnlBRSummary
        ' 
        pnlBRSummary.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlBRSummary.Controls.Add(lblBRSummaryStatus)
        pnlBRSummary.Controls.Add(lblBRSummaryInfo)
        pnlBRSummary.Location = New Point(35, 524)
        pnlBRSummary.Name = "pnlBRSummary"
        pnlBRSummary.Size = New Size(855, 55)
        pnlBRSummary.TabIndex = 8
        ' 
        ' lblBRSummaryStatus
        ' 
        lblBRSummaryStatus.AutoSize = True
        lblBRSummaryStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBRSummaryStatus.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblBRSummaryStatus.Location = New Point(750, 20)
        lblBRSummaryStatus.Name = "lblBRSummaryStatus"
        lblBRSummaryStatus.Size = New Size(45, 15)
        lblBRSummaryStatus.TabIndex = 10
        lblBRSummaryStatus.Text = "TRACKED"
        ' 
        ' lblBRSummaryInfo
        ' 
        lblBRSummaryInfo.AutoSize = True
        lblBRSummaryInfo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBRSummaryInfo.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblBRSummaryInfo.Location = New Point(20, 19)
        lblBRSummaryInfo.Name = "lblBRSummaryInfo"
        lblBRSummaryInfo.Size = New Size(199, 15)
        lblBRSummaryInfo.TabIndex = 9
        lblBRSummaryInfo.Text = "2 purchases, 1 return this week"
        ' 
        ' lblBRSummaryTitle
        ' 
        lblBRSummaryTitle.AutoSize = True
        lblBRSummaryTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBRSummaryTitle.ForeColor = Color.White
        lblBRSummaryTitle.Location = New Point(35, 498)
        lblBRSummaryTitle.Name = "lblBRSummaryTitle"
        lblBRSummaryTitle.Size = New Size(128, 20)
        lblBRSummaryTitle.TabIndex = 7
        lblBRSummaryTitle.Text = "THIS WEEK"
        ' 
        ' pnlTransactions
        ' 
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(lblDate3)
        pnlTransactions.Controls.Add(lblAmount3)
        pnlTransactions.Controls.Add(lblType3)
        pnlTransactions.Controls.Add(lblBRitem3)
        pnlTransactions.Controls.Add(lblDate2)
        pnlTransactions.Controls.Add(lblAmount2)
        pnlTransactions.Controls.Add(lblType2)
        pnlTransactions.Controls.Add(lblBRitem2)
        pnlTransactions.Controls.Add(lblDate1)
        pnlTransactions.Controls.Add(lblAmount1)
        pnlTransactions.Controls.Add(lblType1)
        pnlTransactions.Controls.Add(lblBRitem1)
        pnlTransactions.Controls.Add(lblHeaderDate)
        pnlTransactions.Controls.Add(lblHeaderAmount)
        pnlTransactions.Controls.Add(lblHeaderType)
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
        ' lblHeaderType
        ' 
        lblHeaderType.AutoSize = True
        lblHeaderType.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderType.Location = New Point(248, 15)
        lblHeaderType.Name = "lblHeaderType"
        lblHeaderType.Size = New Size(33, 15)
        lblHeaderType.TabIndex = 1
        lblHeaderType.Text = "TYPE"
        ' 
        ' lblHeaderAmount
        ' 
        lblHeaderAmount.AutoSize = True
        lblHeaderAmount.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderAmount.Location = New Point(434, 15)
        lblHeaderAmount.Name = "lblHeaderAmount"
        lblHeaderAmount.Size = New Size(52, 15)
        lblHeaderAmount.TabIndex = 2
        lblHeaderAmount.Text = "AMOUNT"
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
        ' lblBRitem1
        ' 
        lblBRitem1.AutoSize = True
        lblBRitem1.ForeColor = Color.White
        lblBRitem1.Location = New Point(20, 55)
        lblBRitem1.Name = "lblBRitem1"
        lblBRitem1.Size = New Size(70, 15)
        lblBRitem1.TabIndex = 4
        lblBRitem1.Text = "Denim Jacket"
        ' 
        ' lblType1
        ' 
        lblType1.AutoSize = True
        lblType1.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblType1.Location = New Point(248, 55)
        lblType1.Name = "lblType1"
        lblType1.Size = New Size(35, 15)
        lblType1.TabIndex = 5
        lblType1.Text = "Buy"
        ' 
        ' lblAmount1
        ' 
        lblAmount1.AutoSize = True
        lblAmount1.ForeColor = Color.White
        lblAmount1.Location = New Point(434, 55)
        lblAmount1.Name = "lblAmount1"
        lblAmount1.Size = New Size(55, 15)
        lblAmount1.TabIndex = 6
        lblAmount1.Text = "₱1,200"
        ' 
        ' lblDate1
        ' 
        lblDate1.AutoSize = True
        lblDate1.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate1.Location = New Point(549, 55)
        lblDate1.Name = "lblDate1"
        lblDate1.Size = New Size(65, 15)
        lblDate1.TabIndex = 7
        lblDate1.Text = "Sep 8, 2026"
        ' 
        ' lblBRitem2
        ' 
        lblBRitem2.AutoSize = True
        lblBRitem2.ForeColor = Color.White
        lblBRitem2.Location = New Point(20, 90)
        lblBRitem2.Name = "lblBRitem2"
        lblBRitem2.Size = New Size(42, 15)
        lblBRitem2.TabIndex = 8
        lblBRitem2.Text = "T-Shirt"
        ' 
        ' lblType2
        ' 
        lblType2.AutoSize = True
        lblType2.ForeColor = Color.FromArgb(CByte(248), CByte(113), CByte(113))
        lblType2.Location = New Point(248, 90)
        lblType2.Name = "lblType2"
        lblType2.Size = New Size(50, 15)
        lblType2.TabIndex = 9
        lblType2.Text = "Return"
        ' 
        ' lblAmount2
        ' 
        lblAmount2.AutoSize = True
        lblAmount2.ForeColor = Color.White
        lblAmount2.Location = New Point(434, 90)
        lblAmount2.Name = "lblAmount2"
        lblAmount2.Size = New Size(45, 15)
        lblAmount2.TabIndex = 10
        lblAmount2.Text = "₱150"
        ' 
        ' lblDate2
        ' 
        lblDate2.AutoSize = True
        lblDate2.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate2.Location = New Point(549, 90)
        lblDate2.Name = "lblDate2"
        lblDate2.Size = New Size(65, 15)
        lblDate2.TabIndex = 11
        lblDate2.Text = "Sep 6, 2026"
        ' 
        ' lblBRitem3
        ' 
        lblBRitem3.AutoSize = True
        lblBRitem3.ForeColor = Color.White
        lblBRitem3.Location = New Point(20, 125)
        lblBRitem3.Name = "lblBRitem3"
        lblBRitem3.Size = New Size(70, 15)
        lblBRitem3.TabIndex = 12
        lblBRitem3.Text = "Cargo Pants"
        ' 
        ' lblType3
        ' 
        lblType3.AutoSize = True
        lblType3.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblType3.Location = New Point(248, 125)
        lblType3.Name = "lblType3"
        lblType3.Size = New Size(35, 15)
        lblType3.TabIndex = 13
        lblType3.Text = "Buy"
        ' 
        ' lblAmount3
        ' 
        lblAmount3.AutoSize = True
        lblAmount3.ForeColor = Color.White
        lblAmount3.Location = New Point(434, 125)
        lblAmount3.Name = "lblAmount3"
        lblAmount3.Size = New Size(55, 15)
        lblAmount3.TabIndex = 14
        lblAmount3.Text = "₱900"
        ' 
        ' lblDate3
        ' 
        lblDate3.AutoSize = True
        lblDate3.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate3.Location = New Point(549, 125)
        lblDate3.Name = "lblDate3"
        lblDate3.Size = New Size(65, 15)
        lblDate3.TabIndex = 15
        lblDate3.Text = "Sep 3, 2026"
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.BackColor = Color.Transparent
        lblRecentTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.ForeColor = Color.White
        lblRecentTitle.Location = New Point(35, 275)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(150, 20)
        lblRecentTitle.TabIndex = 5
        lblRecentTitle.Text = "Purchase & Return Log"
        ' 
        ' pnlBRForm
        ' 
        pnlBRForm.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlBRForm.Controls.Add(btnLogEntry)
        pnlBRForm.Controls.Add(txtAmount)
        pnlBRForm.Controls.Add(lblBRAmount)
        pnlBRForm.Controls.Add(txtType)
        pnlBRForm.Controls.Add(lblBRType)
        pnlBRForm.Controls.Add(txtItemName)
        pnlBRForm.Controls.Add(lblBRItemField)
        pnlBRForm.Location = New Point(55, 120)
        pnlBRForm.Name = "pnlBRForm"
        pnlBRForm.Size = New Size(785, 123)
        pnlBRForm.TabIndex = 2
        ' 
        ' lblBRItemField
        ' 
        lblBRItemField.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblBRItemField.Location = New Point(36, 20)
        lblBRItemField.Name = "lblBRItemField"
        lblBRItemField.Size = New Size(200, 25)
        lblBRItemField.TabIndex = 0
        lblBRItemField.Text = "ITEM NAME"
        ' 
        ' txtItemName
        ' 
        txtItemName.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtItemName.BorderStyle = BorderStyle.FixedSingle
        txtItemName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtItemName.ForeColor = Color.White
        txtItemName.Location = New Point(36, 62)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(160, 27)
        txtItemName.TabIndex = 12
        ' 
        ' lblBRType
        ' 
        lblBRType.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblBRType.Location = New Point(228, 20)
        lblBRType.Name = "lblBRType"
        lblBRType.Size = New Size(200, 25)
        lblBRType.TabIndex = 3
        lblBRType.Text = "TYPE (BUY / RETURN)"
        ' 
        ' txtType
        ' 
        txtType.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtType.BorderStyle = BorderStyle.FixedSingle
        txtType.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtType.ForeColor = Color.White
        txtType.Location = New Point(228, 63)
        txtType.Name = "txtType"
        txtType.Size = New Size(150, 27)
        txtType.TabIndex = 13
        ' 
        ' lblBRAmount
        ' 
        lblBRAmount.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblBRAmount.Location = New Point(414, 20)
        lblBRAmount.Name = "lblBRAmount"
        lblBRAmount.Size = New Size(200, 25)
        lblBRAmount.TabIndex = 4
        lblBRAmount.Text = "AMOUNT"
        ' 
        ' txtAmount
        ' 
        txtAmount.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtAmount.BorderStyle = BorderStyle.FixedSingle
        txtAmount.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAmount.ForeColor = Color.White
        txtAmount.Location = New Point(414, 63)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(80, 27)
        txtAmount.TabIndex = 14
        ' 
        ' btnLogEntry
        ' 
        btnLogEntry.AutoSize = True
        btnLogEntry.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        btnLogEntry.Cursor = Cursors.Hand
        btnLogEntry.FlatAppearance.BorderSize = 0
        btnLogEntry.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        btnLogEntry.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnLogEntry.FlatStyle = FlatStyle.Flat
        btnLogEntry.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogEntry.ForeColor = Color.White
        btnLogEntry.Location = New Point(608, 58)
        btnLogEntry.Name = "btnLogEntry"
        btnLogEntry.Size = New Size(135, 32)
        btnLogEntry.TabIndex = 11
        btnLogEntry.Text = "+ LOG ENTRY"
        btnLogEntry.UseVisualStyleBackColor = False
        ' 
        ' lblBRdesc
        ' 
        lblBRdesc.AutoSize = True
        lblBRdesc.BackColor = Color.Transparent
        lblBRdesc.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(12))
        Controls.Add(pnlMain)
        Name = "ucBuyingReturns"
        Size = New Size(963, 619)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlBRSummary.ResumeLayout(False)
        pnlBRSummary.PerformLayout()
        pnlTransactions.ResumeLayout(False)
        pnlTransactions.PerformLayout()
        pnlBRForm.ResumeLayout(False)
        pnlBRForm.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlBRSummary As Panel
    Friend WithEvents lblBRSummaryStatus As Label
    Friend WithEvents lblBRSummaryInfo As Label
    Friend WithEvents lblBRSummaryTitle As Label
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents lblDate3 As Label
    Friend WithEvents lblAmount3 As Label
    Friend WithEvents lblType3 As Label
    Friend WithEvents lblBRitem3 As Label
    Friend WithEvents lblDate2 As Label
    Friend WithEvents lblAmount2 As Label
    Friend WithEvents lblType2 As Label
    Friend WithEvents lblBRitem2 As Label
    Friend WithEvents lblDate1 As Label
    Friend WithEvents lblAmount1 As Label
    Friend WithEvents lblType1 As Label
    Friend WithEvents lblBRitem1 As Label
    Friend WithEvents lblHeaderDate As Label
    Friend WithEvents lblHeaderAmount As Label
    Friend WithEvents lblHeaderType As Label
    Friend WithEvents lblHeaderItem As Label
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents pnlBRForm As Panel
    Friend WithEvents lblBRItemField As Label
    Friend WithEvents lblBRdesc As Label
    Friend WithEvents lblBRhandling As Label
    Friend WithEvents lblBRType As Label
    Friend WithEvents lblBRAmount As Label
    Friend WithEvents btnLogEntry As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtItemName As TextBox

End Class
