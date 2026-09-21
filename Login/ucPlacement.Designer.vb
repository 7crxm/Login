<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPlacement
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
        pnlPlacementSummary = New Panel()
        lblPlacementSummaryStatus = New Label()
        lblPlacementSummaryInfo = New Label()
        lblPlacementSummaryTitle = New Label()
        pnlTransactions = New Panel()
        lblDate3 = New Label()
        lblStatus3 = New Label()
        lblQty3 = New Label()
        lblPLitem3 = New Label()
        lblDate2 = New Label()
        lblStatus2 = New Label()
        lblQty2 = New Label()
        lblPLitem2 = New Label()
        lblDate1 = New Label()
        lblStatus1 = New Label()
        lblQty1 = New Label()
        lblPLitem1 = New Label()
        lblHeaderDate = New Label()
        lblHeaderStatus = New Label()
        lblHeaderQty = New Label()
        lblHeaderItem = New Label()
        lblRecentTitle = New Label()
        pnlPlacementForm = New Panel()
        btnMarkPlaced = New Button()
        txtLocation = New TextBox()
        lblPLLocation = New Label()
        txtQty = New TextBox()
        lblPLQty = New Label()
        txtItemName = New TextBox()
        lblPLItemField = New Label()
        lblPLdesc = New Label()
        lblPLhandling = New Label()
        pnlMain.SuspendLayout()
        pnlPlacementSummary.SuspendLayout()
        pnlTransactions.SuspendLayout()
        pnlPlacementForm.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlPlacementSummary)
        pnlMain.Controls.Add(lblPlacementSummaryTitle)
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(lblRecentTitle)
        pnlMain.Controls.Add(pnlPlacementForm)
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
        lblPlacementSummaryStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        lblPlacementSummaryInfo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlacementSummaryInfo.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblPlacementSummaryInfo.Location = New Point(20, 19)
        lblPlacementSummaryInfo.Name = "lblPlacementSummaryInfo"
        lblPlacementSummaryInfo.Size = New Size(199, 15)
        lblPlacementSummaryInfo.TabIndex = 9
        lblPlacementSummaryInfo.Text = "67 items scheduled for display today"
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
        ' 
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(lblDate3)
        pnlTransactions.Controls.Add(lblStatus3)
        pnlTransactions.Controls.Add(lblQty3)
        pnlTransactions.Controls.Add(lblPLitem3)
        pnlTransactions.Controls.Add(lblDate2)
        pnlTransactions.Controls.Add(lblStatus2)
        pnlTransactions.Controls.Add(lblQty2)
        pnlTransactions.Controls.Add(lblPLitem2)
        pnlTransactions.Controls.Add(lblDate1)
        pnlTransactions.Controls.Add(lblStatus1)
        pnlTransactions.Controls.Add(lblQty1)
        pnlTransactions.Controls.Add(lblPLitem1)
        pnlTransactions.Controls.Add(lblHeaderDate)
        pnlTransactions.Controls.Add(lblHeaderStatus)
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
        ' lblHeaderStatus
        ' 
        lblHeaderStatus.AutoSize = True
        lblHeaderStatus.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderStatus.Location = New Point(434, 15)
        lblHeaderStatus.Name = "lblHeaderStatus"
        lblHeaderStatus.Size = New Size(45, 15)
        lblHeaderStatus.TabIndex = 2
        lblHeaderStatus.Text = "STATUS"
        ' 
        ' lblHeaderDate
        ' 
        lblHeaderDate.AutoSize = True
        lblHeaderDate.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderDate.Location = New Point(549, 15)
        lblHeaderDate.Name = "lblHeaderDate"
        lblHeaderDate.Size = New Size(52, 15)
        lblHeaderDate.TabIndex = 3
        lblHeaderDate.Text = "ARRIVED"
        ' 
        ' lblPLitem1
        ' 
        lblPLitem1.AutoSize = True
        lblPLitem1.ForeColor = Color.White
        lblPLitem1.Location = New Point(20, 55)
        lblPLitem1.Name = "lblPLitem1"
        lblPLitem1.Size = New Size(42, 15)
        lblPLitem1.TabIndex = 4
        lblPLitem1.Text = "T-Shirt"
        ' 
        ' lblQty1
        ' 
        lblQty1.AutoSize = True
        lblQty1.ForeColor = Color.White
        lblQty1.Location = New Point(248, 55)
        lblQty1.Name = "lblQty1"
        lblQty1.Size = New Size(19, 15)
        lblQty1.TabIndex = 5
        lblQty1.Text = "20"
        ' 
        ' lblStatus1
        ' 
        lblStatus1.AutoSize = True
        lblStatus1.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblStatus1.Location = New Point(434, 55)
        lblStatus1.Name = "lblStatus1"
        lblStatus1.Size = New Size(49, 15)
        lblStatus1.TabIndex = 6
        lblStatus1.Text = "In Stock"
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
        ' lblPLitem2
        ' 
        lblPLitem2.AutoSize = True
        lblPLitem2.ForeColor = Color.White
        lblPLitem2.Location = New Point(20, 90)
        lblPLitem2.Name = "lblPLitem2"
        lblPLitem2.Size = New Size(75, 15)
        lblPLitem2.TabIndex = 8
        lblPLitem2.Text = "Denim Jacket"
        ' 
        ' lblQty2
        ' 
        lblQty2.AutoSize = True
        lblQty2.ForeColor = Color.White
        lblQty2.Location = New Point(248, 90)
        lblQty2.Name = "lblQty2"
        lblQty2.Size = New Size(13, 15)
        lblQty2.TabIndex = 9
        lblQty2.Text = "8"
        ' 
        ' lblStatus2
        ' 
        lblStatus2.AutoSize = True
        lblStatus2.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblStatus2.Location = New Point(434, 90)
        lblStatus2.Name = "lblStatus2"
        lblStatus2.Size = New Size(49, 15)
        lblStatus2.TabIndex = 10
        lblStatus2.Text = "In Stock"
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
        ' lblPLitem3
        ' 
        lblPLitem3.AutoSize = True
        lblPLitem3.ForeColor = Color.White
        lblPLitem3.Location = New Point(20, 125)
        lblPLitem3.Name = "lblPLitem3"
        lblPLitem3.Size = New Size(75, 15)
        lblPLitem3.TabIndex = 12
        lblPLitem3.Text = "Cargo Pants"
        ' 
        ' lblQty3
        ' 
        lblQty3.AutoSize = True
        lblQty3.ForeColor = Color.White
        lblQty3.Location = New Point(248, 125)
        lblQty3.Name = "lblQty3"
        lblQty3.Size = New Size(19, 15)
        lblQty3.TabIndex = 13
        lblQty3.Text = "15"
        ' 
        ' lblStatus3
        ' 
        lblStatus3.AutoSize = True
        lblStatus3.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblStatus3.Location = New Point(434, 125)
        lblStatus3.Name = "lblStatus3"
        lblStatus3.Size = New Size(49, 15)
        lblStatus3.TabIndex = 14
        lblStatus3.Text = "In Stock"
        ' 
        ' lblDate3
        ' 
        lblDate3.AutoSize = True
        lblDate3.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate3.Location = New Point(549, 125)
        lblDate3.Name = "lblDate3"
        lblDate3.Size = New Size(65, 15)
        lblDate3.TabIndex = 15
        lblDate3.Text = "Sep 4, 2026"
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.BackColor = Color.Transparent
        lblRecentTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.ForeColor = Color.White
        lblRecentTitle.Location = New Point(35, 275)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(155, 20)
        lblRecentTitle.TabIndex = 5
        lblRecentTitle.Text = "Waiting for Placement"
        ' 
        ' pnlPlacementForm
        ' 
        pnlPlacementForm.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlPlacementForm.Controls.Add(btnMarkPlaced)
        pnlPlacementForm.Controls.Add(txtLocation)
        pnlPlacementForm.Controls.Add(lblPLLocation)
        pnlPlacementForm.Controls.Add(txtQty)
        pnlPlacementForm.Controls.Add(lblPLQty)
        pnlPlacementForm.Controls.Add(txtItemName)
        pnlPlacementForm.Controls.Add(lblPLItemField)
        pnlPlacementForm.Location = New Point(55, 120)
        pnlPlacementForm.Name = "pnlPlacementForm"
        pnlPlacementForm.Size = New Size(785, 123)
        pnlPlacementForm.TabIndex = 2
        ' 
        ' lblPLItemField
        ' 
        lblPLItemField.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblPLItemField.Location = New Point(36, 20)
        lblPLItemField.Name = "lblPLItemField"
        lblPLItemField.Size = New Size(200, 25)
        lblPLItemField.TabIndex = 0
        lblPLItemField.Text = "ITEM"
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
        ' lblPLQty
        ' 
        lblPLQty.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblPLQty.Location = New Point(228, 20)
        lblPLQty.Name = "lblPLQty"
        lblPLQty.Size = New Size(200, 25)
        lblPLQty.TabIndex = 3
        lblPLQty.Text = "QUANTITY TO PLACE"
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
        ' lblPLLocation
        ' 
        lblPLLocation.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblPLLocation.Location = New Point(414, 20)
        lblPLLocation.Name = "lblPLLocation"
        lblPLLocation.Size = New Size(200, 25)
        lblPLLocation.TabIndex = 4
        lblPLLocation.Text = "DISPLAY AREA"
        ' 
        ' txtLocation
        ' 
        txtLocation.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtLocation.BorderStyle = BorderStyle.FixedSingle
        txtLocation.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLocation.ForeColor = Color.White
        txtLocation.Location = New Point(414, 63)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(150, 27)
        txtLocation.TabIndex = 14
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
        btnMarkPlaced.Location = New Point(608, 58)
        btnMarkPlaced.Name = "btnMarkPlaced"
        btnMarkPlaced.Size = New Size(135, 32)
        btnMarkPlaced.TabIndex = 11
        btnMarkPlaced.Text = "MARK PLACED"
        btnMarkPlaced.UseVisualStyleBackColor = False
        ' 
        ' lblPLdesc
        ' 
        lblPLdesc.AutoSize = True
        lblPLdesc.BackColor = Color.Transparent
        lblPLdesc.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPLdesc.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblPLdesc.Location = New Point(37, 70)
        lblPLdesc.Name = "lblPLdesc"
        lblPLdesc.Size = New Size(255, 15)
        lblPLdesc.TabIndex = 1
        lblPLdesc.Text = "Items in stock, waiting to go on display."
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
        AutoScaleDimensions = New SizeF(7F, 15F)
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
        pnlTransactions.PerformLayout()
        pnlPlacementForm.ResumeLayout(False)
        pnlPlacementForm.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlPlacementSummary As Panel
    Friend WithEvents lblPlacementSummaryStatus As Label
    Friend WithEvents lblPlacementSummaryInfo As Label
    Friend WithEvents lblPlacementSummaryTitle As Label
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents lblDate3 As Label
    Friend WithEvents lblStatus3 As Label
    Friend WithEvents lblQty3 As Label
    Friend WithEvents lblPLitem3 As Label
    Friend WithEvents lblDate2 As Label
    Friend WithEvents lblStatus2 As Label
    Friend WithEvents lblQty2 As Label
    Friend WithEvents lblPLitem2 As Label
    Friend WithEvents lblDate1 As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents lblQty1 As Label
    Friend WithEvents lblPLitem1 As Label
    Friend WithEvents lblHeaderDate As Label
    Friend WithEvents lblHeaderStatus As Label
    Friend WithEvents lblHeaderQty As Label
    Friend WithEvents lblHeaderItem As Label
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents pnlPlacementForm As Panel
    Friend WithEvents lblPLItemField As Label
    Friend WithEvents lblPLdesc As Label
    Friend WithEvents lblPLhandling As Label
    Friend WithEvents lblPLQty As Label
    Friend WithEvents lblPLLocation As Label
    Friend WithEvents btnMarkPlaced As Button
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtItemName As TextBox

End Class
