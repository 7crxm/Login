<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSupplier
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
        pnlSupplierSummary = New Panel()
        lblSupplierSummaryStatus = New Label()
        lblSupplierSummaryInfo = New Label()
        lblSupplierSummaryTitle = New Label()
        pnlTransactions = New Panel()
        dgvSuppliers = New DataGridView()
        colSupplierName = New DataGridViewTextBoxColumn()
        colSupplierContact = New DataGridViewTextBoxColumn()
        colSupplierAddress = New DataGridViewTextBoxColumn()
        colSupplierDate = New DataGridViewTextBoxColumn()
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
        CType(dgvSuppliers, ComponentModel.ISupportInitialize).BeginInit()
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
        lblSupplierSummaryStatus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        lblSupplierSummaryInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSupplierSummaryInfo.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblSupplierSummaryInfo.Location = New Point(20, 19)
        lblSupplierSummaryInfo.Name = "lblSupplierSummaryInfo"
        lblSupplierSummaryInfo.Size = New Size(199, 15)
        lblSupplierSummaryInfo.TabIndex = 9
        lblSupplierSummaryInfo.Text = "0 suppliers on file"
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
        ' -- was 3 fixed label rows, now a scrollable grid bound to dbo.Suppliers
        ' 
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(dgvSuppliers)
        pnlTransactions.Location = New Point(35, 315)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Padding = New Padding(10)
        pnlTransactions.Size = New Size(855, 200)
        pnlTransactions.TabIndex = 6
        ' 
        ' dgvSuppliers
        ' 
        dgvSuppliers.AllowUserToAddRows = False
        dgvSuppliers.AllowUserToDeleteRows = False
        dgvSuppliers.AutoGenerateColumns = False
        dgvSuppliers.BackgroundColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvSuppliers.BorderStyle = BorderStyle.None
        dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvSuppliers.Columns.AddRange(New DataGridViewColumn() {colSupplierName, colSupplierContact, colSupplierAddress, colSupplierDate})
        dgvSuppliers.DefaultCellStyle.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        dgvSuppliers.DefaultCellStyle.ForeColor = Color.White
        dgvSuppliers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        dgvSuppliers.Dock = DockStyle.Fill
        dgvSuppliers.EnableHeadersVisualStyles = False
        dgvSuppliers.GridColor = Color.FromArgb(CByte(40), CByte(40), CByte(50))
        dgvSuppliers.Location = New Point(10, 10)
        dgvSuppliers.Name = "dgvSuppliers"
        dgvSuppliers.ReadOnly = True
        dgvSuppliers.RowHeadersVisible = False
        dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSuppliers.Size = New Size(835, 180)
        dgvSuppliers.TabIndex = 0
        ' 
        ' colSupplierName
        ' 
        colSupplierName.DataPropertyName = "Name"
        colSupplierName.HeaderText = "SUPPLIER"
        colSupplierName.Name = "colSupplierName"
        colSupplierName.ReadOnly = True
        colSupplierName.Width = 220
        ' 
        ' colSupplierContact
        ' 
        colSupplierContact.DataPropertyName = "Contact"
        colSupplierContact.HeaderText = "CONTACT"
        colSupplierContact.Name = "colSupplierContact"
        colSupplierContact.ReadOnly = True
        colSupplierContact.Width = 150
        ' 
        ' colSupplierAddress
        ' 
        colSupplierAddress.DataPropertyName = "Address"
        colSupplierAddress.HeaderText = "ADDRESS"
        colSupplierAddress.Name = "colSupplierAddress"
        colSupplierAddress.ReadOnly = True
        colSupplierAddress.Width = 250
        ' 
        ' colSupplierDate
        ' 
        colSupplierDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colSupplierDate.DataPropertyName = "DateAdded"
        colSupplierDate.DefaultCellStyle.Format = "MMM d, yyyy"
        colSupplierDate.HeaderText = "DATE ADDED"
        colSupplierDate.Name = "colSupplierDate"
        colSupplierDate.ReadOnly = True
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
        lblSupplierDesc.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
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
        CType(dgvSuppliers, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents colSupplierName As DataGridViewTextBoxColumn
    Friend WithEvents colSupplierContact As DataGridViewTextBoxColumn
    Friend WithEvents colSupplierAddress As DataGridViewTextBoxColumn
    Friend WithEvents colSupplierDate As DataGridViewTextBoxColumn
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