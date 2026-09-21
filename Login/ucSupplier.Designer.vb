<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSupplier
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
        pnlSupplierSummary = New Panel()
        lblSupplierSummaryStatus = New Label()
        lblSupplierSummaryInfo = New Label()
        lblSupplierSummaryTitle = New Label()
        pnlTransactions = New Panel()
        lblDate3 = New Label()
        lblAddress3 = New Label()
        lblContact3 = New Label()
        lblSupplierName3 = New Label()
        lblDate2 = New Label()
        lblAddress2 = New Label()
        lblContact2 = New Label()
        lblSupplierName2 = New Label()
        lblDate1 = New Label()
        lblAddress1 = New Label()
        lblContact1 = New Label()
        lblSupplierName1 = New Label()
        lblHeaderDate = New Label()
        lblHeaderAddress = New Label()
        lblHeaderContact = New Label()
        lblHeaderName = New Label()
        lblRecentTitle = New Label()
        pnlSupplierForm = New Panel()
        btnAddSupplier = New Button()
        txtAddress = New TextBox()
        lblSupplierAddress = New Label()
        txtContact = New TextBox()
        lblSupplierContact = New Label()
        txtSupplierName = New TextBox()
        lblSupplierNameField = New Label()
        lblSupplierDesc = New Label()
        lblSupplierHandling = New Label()
        pnlMain.SuspendLayout()
        pnlSupplierSummary.SuspendLayout()
        pnlTransactions.SuspendLayout()
        pnlSupplierForm.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlSupplierSummary)
        pnlMain.Controls.Add(lblSupplierSummaryTitle)
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(lblRecentTitle)
        pnlMain.Controls.Add(pnlSupplierForm)
        pnlMain.Controls.Add(lblSupplierDesc)
        pnlMain.Controls.Add(lblSupplierHandling)
        pnlMain.Location = New Point(3, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(960, 630)
        pnlMain.TabIndex = 3
        ' 
        ' pnlSupplierSummary
        ' 
        pnlSupplierSummary.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlSupplierSummary.Controls.Add(lblSupplierSummaryStatus)
        pnlSupplierSummary.Controls.Add(lblSupplierSummaryInfo)
        pnlSupplierSummary.Location = New Point(35, 524)
        pnlSupplierSummary.Name = "pnlSupplierSummary"
        pnlSupplierSummary.Size = New Size(855, 55)
        pnlSupplierSummary.TabIndex = 8
        ' 
        ' lblSupplierSummaryStatus
        ' 
        lblSupplierSummaryStatus.AutoSize = True
        lblSupplierSummaryStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSupplierSummaryStatus.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblSupplierSummaryStatus.Location = New Point(750, 20)
        lblSupplierSummaryStatus.Name = "lblSupplierSummaryStatus"
        lblSupplierSummaryStatus.Size = New Size(45, 15)
        lblSupplierSummaryStatus.TabIndex = 10
        lblSupplierSummaryStatus.Text = "ACTIVE"
        ' 
        ' lblSupplierSummaryInfo
        ' 
        lblSupplierSummaryInfo.AutoSize = True
        lblSupplierSummaryInfo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSupplierSummaryInfo.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblSupplierSummaryInfo.Location = New Point(20, 19)
        lblSupplierSummaryInfo.Name = "lblSupplierSummaryInfo"
        lblSupplierSummaryInfo.Size = New Size(199, 15)
        lblSupplierSummaryInfo.TabIndex = 9
        lblSupplierSummaryInfo.Text = "12 active suppliers on file"
        ' 
        ' lblSupplierSummaryTitle
        ' 
        lblSupplierSummaryTitle.AutoSize = True
        lblSupplierSummaryTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSupplierSummaryTitle.ForeColor = Color.White
        lblSupplierSummaryTitle.Location = New Point(35, 498)
        lblSupplierSummaryTitle.Name = "lblSupplierSummaryTitle"
        lblSupplierSummaryTitle.Size = New Size(128, 20)
        lblSupplierSummaryTitle.TabIndex = 7
        lblSupplierSummaryTitle.Text = "SUPPLIER STATUS"
        ' 
        ' pnlTransactions
        ' 
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(lblDate3)
        pnlTransactions.Controls.Add(lblAddress3)
        pnlTransactions.Controls.Add(lblContact3)
        pnlTransactions.Controls.Add(lblSupplierName3)
        pnlTransactions.Controls.Add(lblDate2)
        pnlTransactions.Controls.Add(lblAddress2)
        pnlTransactions.Controls.Add(lblContact2)
        pnlTransactions.Controls.Add(lblSupplierName2)
        pnlTransactions.Controls.Add(lblDate1)
        pnlTransactions.Controls.Add(lblAddress1)
        pnlTransactions.Controls.Add(lblContact1)
        pnlTransactions.Controls.Add(lblSupplierName1)
        pnlTransactions.Controls.Add(lblHeaderDate)
        pnlTransactions.Controls.Add(lblHeaderAddress)
        pnlTransactions.Controls.Add(lblHeaderContact)
        pnlTransactions.Controls.Add(lblHeaderName)
        pnlTransactions.Location = New Point(35, 315)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Size = New Size(855, 180)
        pnlTransactions.TabIndex = 6
        ' 
        ' lblHeaderName
        ' 
        lblHeaderName.AutoSize = True
        lblHeaderName.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderName.Location = New Point(20, 15)
        lblHeaderName.Name = "lblHeaderName"
        lblHeaderName.Size = New Size(56, 15)
        lblHeaderName.TabIndex = 0
        lblHeaderName.Text = "SUPPLIER"
        ' 
        ' lblHeaderContact
        ' 
        lblHeaderContact.AutoSize = True
        lblHeaderContact.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderContact.Location = New Point(248, 15)
        lblHeaderContact.Name = "lblHeaderContact"
        lblHeaderContact.Size = New Size(50, 15)
        lblHeaderContact.TabIndex = 1
        lblHeaderContact.Text = "CONTACT"
        ' 
        ' lblHeaderAddress
        ' 
        lblHeaderAddress.AutoSize = True
        lblHeaderAddress.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderAddress.Location = New Point(434, 15)
        lblHeaderAddress.Name = "lblHeaderAddress"
        lblHeaderAddress.Size = New Size(52, 15)
        lblHeaderAddress.TabIndex = 2
        lblHeaderAddress.Text = "ADDRESS"
        ' 
        ' lblHeaderDate
        ' 
        lblHeaderDate.AutoSize = True
        lblHeaderDate.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderDate.Location = New Point(700, 15)
        lblHeaderDate.Name = "lblHeaderDate"
        lblHeaderDate.Size = New Size(66, 15)
        lblHeaderDate.TabIndex = 3
        lblHeaderDate.Text = "DATE ADDED"
        ' 
        ' lblSupplierName1
        ' 
        lblSupplierName1.AutoSize = True
        lblSupplierName1.ForeColor = Color.White
        lblSupplierName1.Location = New Point(20, 55)
        lblSupplierName1.Name = "lblSupplierName1"
        lblSupplierName1.Size = New Size(100, 15)
        lblSupplierName1.TabIndex = 4
        lblSupplierName1.Text = "Reyes Trading"
        ' 
        ' lblContact1
        ' 
        lblContact1.AutoSize = True
        lblContact1.ForeColor = Color.White
        lblContact1.Location = New Point(248, 55)
        lblContact1.Name = "lblContact1"
        lblContact1.Size = New Size(90, 15)
        lblContact1.TabIndex = 5
        lblContact1.Text = "0917-123-4567"
        ' 
        ' lblAddress1
        ' 
        lblAddress1.AutoSize = True
        lblAddress1.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblAddress1.Location = New Point(434, 55)
        lblAddress1.Name = "lblAddress1"
        lblAddress1.Size = New Size(120, 15)
        lblAddress1.TabIndex = 6
        lblAddress1.Text = "Divisoria, Manila"
        ' 
        ' lblDate1
        ' 
        lblDate1.AutoSize = True
        lblDate1.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate1.Location = New Point(700, 55)
        lblDate1.Name = "lblDate1"
        lblDate1.Size = New Size(65, 15)
        lblDate1.TabIndex = 7
        lblDate1.Text = "Sep 1, 2026"
        ' 
        ' lblSupplierName2
        ' 
        lblSupplierName2.AutoSize = True
        lblSupplierName2.ForeColor = Color.White
        lblSupplierName2.Location = New Point(20, 90)
        lblSupplierName2.Name = "lblSupplierName2"
        lblSupplierName2.Size = New Size(90, 15)
        lblSupplierName2.TabIndex = 8
        lblSupplierName2.Text = "Bale Wholesale"
        ' 
        ' lblContact2
        ' 
        lblContact2.AutoSize = True
        lblContact2.ForeColor = Color.White
        lblContact2.Location = New Point(248, 90)
        lblContact2.Name = "lblContact2"
        lblContact2.Size = New Size(90, 15)
        lblContact2.TabIndex = 9
        lblContact2.Text = "0918-222-3333"
        ' 
        ' lblAddress2
        ' 
        lblAddress2.AutoSize = True
        lblAddress2.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblAddress2.Location = New Point(434, 90)
        lblAddress2.Name = "lblAddress2"
        lblAddress2.Size = New Size(130, 15)
        lblAddress2.TabIndex = 10
        lblAddress2.Text = "Baclaran, Parañaque"
        ' 
        ' lblDate2
        ' 
        lblDate2.AutoSize = True
        lblDate2.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate2.Location = New Point(700, 90)
        lblDate2.Name = "lblDate2"
        lblDate2.Size = New Size(65, 15)
        lblDate2.TabIndex = 11
        lblDate2.Text = "Aug 22, 2026"
        ' 
        ' lblSupplierName3
        ' 
        lblSupplierName3.AutoSize = True
        lblSupplierName3.ForeColor = Color.White
        lblSupplierName3.Location = New Point(20, 125)
        lblSupplierName3.Name = "lblSupplierName3"
        lblSupplierName3.Size = New Size(80, 15)
        lblSupplierName3.TabIndex = 12
        lblSupplierName3.Text = "JM Ukay Supply"
        ' 
        ' lblContact3
        ' 
        lblContact3.AutoSize = True
        lblContact3.ForeColor = Color.White
        lblContact3.Location = New Point(248, 125)
        lblContact3.Name = "lblContact3"
        lblContact3.Size = New Size(90, 15)
        lblContact3.TabIndex = 13
        lblContact3.Text = "0920-555-7890"
        ' 
        ' lblAddress3
        ' 
        lblAddress3.AutoSize = True
        lblAddress3.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblAddress3.Location = New Point(434, 125)
        lblAddress3.Name = "lblAddress3"
        lblAddress3.Size = New Size(110, 15)
        lblAddress3.TabIndex = 14
        lblAddress3.Text = "Taguig City"
        ' 
        ' lblDate3
        ' 
        lblDate3.AutoSize = True
        lblDate3.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate3.Location = New Point(700, 125)
        lblDate3.Name = "lblDate3"
        lblDate3.Size = New Size(65, 15)
        lblDate3.TabIndex = 15
        lblDate3.Text = "Aug 10, 2026"
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.BackColor = Color.Transparent
        lblRecentTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.ForeColor = Color.White
        lblRecentTitle.Location = New Point(35, 275)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(110, 20)
        lblRecentTitle.TabIndex = 5
        lblRecentTitle.Text = "Supplier Directory"
        ' 
        ' pnlSupplierForm
        ' 
        pnlSupplierForm.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlSupplierForm.Controls.Add(btnAddSupplier)
        pnlSupplierForm.Controls.Add(txtAddress)
        pnlSupplierForm.Controls.Add(lblSupplierAddress)
        pnlSupplierForm.Controls.Add(txtContact)
        pnlSupplierForm.Controls.Add(lblSupplierContact)
        pnlSupplierForm.Controls.Add(txtSupplierName)
        pnlSupplierForm.Controls.Add(lblSupplierNameField)
        pnlSupplierForm.Location = New Point(55, 120)
        pnlSupplierForm.Name = "pnlSupplierForm"
        pnlSupplierForm.Size = New Size(785, 123)
        pnlSupplierForm.TabIndex = 2
        ' 
        ' lblSupplierNameField
        ' 
        lblSupplierNameField.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblSupplierNameField.Location = New Point(36, 20)
        lblSupplierNameField.Name = "lblSupplierNameField"
        lblSupplierNameField.Size = New Size(200, 25)
        lblSupplierNameField.TabIndex = 0
        lblSupplierNameField.Text = "SUPPLIER NAME"
        ' 
        ' txtSupplierName
        ' 
        txtSupplierName.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtSupplierName.BorderStyle = BorderStyle.FixedSingle
        txtSupplierName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSupplierName.ForeColor = Color.White
        txtSupplierName.Location = New Point(36, 62)
        txtSupplierName.Name = "txtSupplierName"
        txtSupplierName.Size = New Size(160, 27)
        txtSupplierName.TabIndex = 12
        ' 
        ' lblSupplierContact
        ' 
        lblSupplierContact.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblSupplierContact.Location = New Point(228, 20)
        lblSupplierContact.Name = "lblSupplierContact"
        lblSupplierContact.Size = New Size(200, 25)
        lblSupplierContact.TabIndex = 3
        lblSupplierContact.Text = "CONTACT NUMBER"
        ' 
        ' txtContact
        ' 
        txtContact.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtContact.BorderStyle = BorderStyle.FixedSingle
        txtContact.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContact.ForeColor = Color.White
        txtContact.Location = New Point(228, 63)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(150, 27)
        txtContact.TabIndex = 13
        ' 
        ' lblSupplierAddress
        ' 
        lblSupplierAddress.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblSupplierAddress.Location = New Point(414, 20)
        lblSupplierAddress.Name = "lblSupplierAddress"
        lblSupplierAddress.Size = New Size(200, 25)
        lblSupplierAddress.TabIndex = 4
        lblSupplierAddress.Text = "ADDRESS"
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.FromArgb(CByte(14), CByte(12), CByte(21))
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.ForeColor = Color.White
        txtAddress.Location = New Point(414, 63)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(180, 27)
        txtAddress.TabIndex = 14
        ' 
        ' btnAddSupplier
        ' 
        btnAddSupplier.AutoSize = True
        btnAddSupplier.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        btnAddSupplier.Cursor = Cursors.Hand
        btnAddSupplier.FlatAppearance.BorderSize = 0
        btnAddSupplier.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        btnAddSupplier.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        btnAddSupplier.FlatStyle = FlatStyle.Flat
        btnAddSupplier.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddSupplier.ForeColor = Color.White
        btnAddSupplier.Location = New Point(608, 58)
        btnAddSupplier.Name = "btnAddSupplier"
        btnAddSupplier.Size = New Size(135, 32)
        btnAddSupplier.TabIndex = 11
        btnAddSupplier.Text = "+ ADD SUPPLIER"
        btnAddSupplier.UseVisualStyleBackColor = False
        ' 
        ' lblSupplierDesc
        ' 
        lblSupplierDesc.AutoSize = True
        lblSupplierDesc.BackColor = Color.Transparent
        lblSupplierDesc.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSupplierDesc.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblSupplierDesc.Location = New Point(37, 70)
        lblSupplierDesc.Name = "lblSupplierDesc"
        lblSupplierDesc.Size = New Size(225, 15)
        lblSupplierDesc.TabIndex = 1
        lblSupplierDesc.Text = "Manage suppliers you buy stock from."
        ' 
        ' lblSupplierHandling
        ' 
        lblSupplierHandling.AutoSize = True
        lblSupplierHandling.BackColor = Color.Transparent
        lblSupplierHandling.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSupplierHandling.ForeColor = Color.White
        lblSupplierHandling.Location = New Point(35, 30)
        lblSupplierHandling.Name = "lblSupplierHandling"
        lblSupplierHandling.Size = New Size(340, 40)
        lblSupplierHandling.TabIndex = 0
        lblSupplierHandling.Text = "Supplier Information"
        ' 
        ' ucSupplier
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(12))
        Controls.Add(pnlMain)
        Name = "ucSupplier"
        Size = New Size(963, 619)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlSupplierSummary.ResumeLayout(False)
        pnlSupplierSummary.PerformLayout()
        pnlTransactions.ResumeLayout(False)
        pnlTransactions.PerformLayout()
        pnlSupplierForm.ResumeLayout(False)
        pnlSupplierForm.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlSupplierSummary As Panel
    Friend WithEvents lblSupplierSummaryStatus As Label
    Friend WithEvents lblSupplierSummaryInfo As Label
    Friend WithEvents lblSupplierSummaryTitle As Label
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents lblDate3 As Label
    Friend WithEvents lblAddress3 As Label
    Friend WithEvents lblContact3 As Label
    Friend WithEvents lblSupplierName3 As Label
    Friend WithEvents lblDate2 As Label
    Friend WithEvents lblAddress2 As Label
    Friend WithEvents lblContact2 As Label
    Friend WithEvents lblSupplierName2 As Label
    Friend WithEvents lblDate1 As Label
    Friend WithEvents lblAddress1 As Label
    Friend WithEvents lblContact1 As Label
    Friend WithEvents lblSupplierName1 As Label
    Friend WithEvents lblHeaderDate As Label
    Friend WithEvents lblHeaderAddress As Label
    Friend WithEvents lblHeaderContact As Label
    Friend WithEvents lblHeaderName As Label
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents pnlSupplierForm As Panel
    Friend WithEvents lblSupplierNameField As Label
    Friend WithEvents lblSupplierDesc As Label
    Friend WithEvents lblSupplierHandling As Label
    Friend WithEvents lblSupplierContact As Label
    Friend WithEvents lblSupplierAddress As Label
    Friend WithEvents btnAddSupplier As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtSupplierName As TextBox

End Class
