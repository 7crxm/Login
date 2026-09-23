<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDashboard
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
        pnlDashboard = New Panel()
        pnlPlacement = New Panel()
        lblPlacementStatus = New Label()
        lblPlacementInfo = New Label()
        lblPlacementTitle = New Label()
        pnlTransactions = New Panel()
        lblDate3 = New Label()
        lblQty3 = New Label()
        lblType3 = New Label()
        lblItem3 = New Label()
        lblDate2 = New Label()
        lblQty2 = New Label()
        lblType2 = New Label()
        lblItem2 = New Label()
        lblDate1 = New Label()
        lblQty1 = New Label()
        lblType1 = New Label()
        lblItem1 = New Label()
        lblHeaderDate = New Label()
        lblHeaderQty = New Label()
        lblHeaderType = New Label()
        lblHeaderItem = New Label()
        lblRecentTitle = New Label()
        pnlSuppliers = New Panel()
        lblSuppliersDesc = New Label()
        lblSuppliersCount = New Label()
        lblSuppliersTitle = New Label()
        pnlItemsOUT = New Panel()
        lblItemsOUTDesc = New Label()
        lblItemsOUTCount = New Label()
        lblItemsOUTTitle = New Label()
        pnlItemsIN = New Panel()
        lblItemsINDesc = New Label()
        lblItemsINCount = New Label()
        lblItemsINTitle = New Label()
        lblWelcome = New Label()
        lblDashboardTitle = New Label()
        pnlDashboard.SuspendLayout()
        pnlPlacement.SuspendLayout()
        pnlTransactions.SuspendLayout()
        pnlSuppliers.SuspendLayout()
        pnlItemsOUT.SuspendLayout()
        pnlItemsIN.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(12))
        pnlDashboard.Controls.Add(pnlPlacement)
        pnlDashboard.Controls.Add(lblPlacementTitle)
        pnlDashboard.Controls.Add(pnlTransactions)
        pnlDashboard.Controls.Add(lblRecentTitle)
        pnlDashboard.Controls.Add(pnlSuppliers)
        pnlDashboard.Controls.Add(pnlItemsOUT)
        pnlDashboard.Controls.Add(pnlItemsIN)
        pnlDashboard.Controls.Add(lblWelcome)
        pnlDashboard.Controls.Add(lblDashboardTitle)
        pnlDashboard.Location = New Point(3, 3)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(960, 630)
        pnlDashboard.TabIndex = 3
        ' 
        ' pnlPlacement
        ' 
        pnlPlacement.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlPlacement.Controls.Add(lblPlacementStatus)
        pnlPlacement.Controls.Add(lblPlacementInfo)
        pnlPlacement.Location = New Point(35, 524)
        pnlPlacement.Name = "pnlPlacement"
        pnlPlacement.Size = New Size(855, 55)
        pnlPlacement.TabIndex = 8
        ' 
        ' lblPlacementStatus
        ' 
        lblPlacementStatus.AutoSize = True
        lblPlacementStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlacementStatus.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblPlacementStatus.Location = New Point(750, 20)
        lblPlacementStatus.Name = "lblPlacementStatus"
        lblPlacementStatus.Size = New Size(45, 15)
        lblPlacementStatus.TabIndex = 10
        lblPlacementStatus.Text = "READY"
        ' 
        ' lblPlacementInfo
        ' 
        lblPlacementInfo.AutoSize = True
        lblPlacementInfo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlacementInfo.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblPlacementInfo.Location = New Point(20, 19)
        lblPlacementInfo.Name = "lblPlacementInfo"
        lblPlacementInfo.Size = New Size(199, 15)
        lblPlacementInfo.TabIndex = 9
        lblPlacementInfo.Text = "67 items scheduled for display today"
        ' 
        ' lblPlacementTitle
        ' 
        lblPlacementTitle.AutoSize = True
        lblPlacementTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlacementTitle.ForeColor = Color.White
        lblPlacementTitle.Location = New Point(35, 498)
        lblPlacementTitle.Name = "lblPlacementTitle"
        lblPlacementTitle.Size = New Size(128, 20)
        lblPlacementTitle.TabIndex = 7
        lblPlacementTitle.Text = "ITEM PLACEMENT"
        ' 
        ' pnlTransactions
        ' 
        pnlTransactions.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTransactions.Controls.Add(lblDate3)
        pnlTransactions.Controls.Add(lblQty3)
        pnlTransactions.Controls.Add(lblType3)
        pnlTransactions.Controls.Add(lblItem3)
        pnlTransactions.Controls.Add(lblDate2)
        pnlTransactions.Controls.Add(lblQty2)
        pnlTransactions.Controls.Add(lblType2)
        pnlTransactions.Controls.Add(lblItem2)
        pnlTransactions.Controls.Add(lblDate1)
        pnlTransactions.Controls.Add(lblQty1)
        pnlTransactions.Controls.Add(lblType1)
        pnlTransactions.Controls.Add(lblItem1)
        pnlTransactions.Controls.Add(lblHeaderDate)
        pnlTransactions.Controls.Add(lblHeaderQty)
        pnlTransactions.Controls.Add(lblHeaderType)
        pnlTransactions.Controls.Add(lblHeaderItem)
        pnlTransactions.Location = New Point(35, 315)
        pnlTransactions.Name = "pnlTransactions"
        pnlTransactions.Size = New Size(855, 180)
        pnlTransactions.TabIndex = 6
        ' 
        ' lblDate3
        ' 
        lblDate3.AutoSize = True
        lblDate3.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate3.Location = New Point(600, 125)
        lblDate3.Name = "lblDate3"
        lblDate3.Size = New Size(65, 15)
        lblDate3.TabIndex = 15
        lblDate3.Text = "Sep 5, 2026"
        ' 
        ' lblQty3
        ' 
        lblQty3.AutoSize = True
        lblQty3.ForeColor = Color.White
        lblQty3.Location = New Point(450, 125)
        lblQty3.Name = "lblQty3"
        lblQty3.Size = New Size(19, 15)
        lblQty3.TabIndex = 14
        lblQty3.Text = "20"
        ' 
        ' lblType3
        ' 
        lblType3.AutoSize = True
        lblType3.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblType3.Location = New Point(280, 125)
        lblType3.Name = "lblType3"
        lblType3.Size = New Size(19, 15)
        lblType3.TabIndex = 13
        lblType3.Text = "IN"
        ' 
        ' lblItem3
        ' 
        lblItem3.AutoSize = True
        lblItem3.ForeColor = Color.White
        lblItem3.Location = New Point(20, 125)
        lblItem3.Name = "lblItem3"
        lblItem3.Size = New Size(42, 15)
        lblItem3.TabIndex = 12
        lblItem3.Text = "T-Shirt"
        ' 
        ' lblDate2
        ' 
        lblDate2.AutoSize = True
        lblDate2.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate2.Location = New Point(600, 90)
        lblDate2.Name = "lblDate2"
        lblDate2.Size = New Size(65, 15)
        lblDate2.TabIndex = 11
        lblDate2.Text = "Sep 5, 2026"
        ' 
        ' lblQty2
        ' 
        lblQty2.AutoSize = True
        lblQty2.ForeColor = Color.White
        lblQty2.Location = New Point(450, 90)
        lblQty2.Name = "lblQty2"
        lblQty2.Size = New Size(19, 15)
        lblQty2.TabIndex = 10
        lblQty2.Text = "20"
        ' 
        ' lblType2
        ' 
        lblType2.AutoSize = True
        lblType2.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblType2.Location = New Point(280, 90)
        lblType2.Name = "lblType2"
        lblType2.Size = New Size(19, 15)
        lblType2.TabIndex = 9
        lblType2.Text = "IN"
        ' 
        ' lblItem2
        ' 
        lblItem2.AutoSize = True
        lblItem2.ForeColor = Color.White
        lblItem2.Location = New Point(20, 90)
        lblItem2.Name = "lblItem2"
        lblItem2.Size = New Size(42, 15)
        lblItem2.TabIndex = 8
        lblItem2.Text = "T-Shirt"
        ' 
        ' lblDate1
        ' 
        lblDate1.AutoSize = True
        lblDate1.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblDate1.Location = New Point(600, 55)
        lblDate1.Name = "lblDate1"
        lblDate1.Size = New Size(65, 15)
        lblDate1.TabIndex = 7
        lblDate1.Text = "Sep 5, 2026"
        ' 
        ' lblQty1
        ' 
        lblQty1.AutoSize = True
        lblQty1.ForeColor = Color.White
        lblQty1.Location = New Point(450, 55)
        lblQty1.Name = "lblQty1"
        lblQty1.Size = New Size(19, 15)
        lblQty1.TabIndex = 6
        lblQty1.Text = "20"
        ' 
        ' lblType1
        ' 
        lblType1.AutoSize = True
        lblType1.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblType1.Location = New Point(280, 55)
        lblType1.Name = "lblType1"
        lblType1.Size = New Size(19, 15)
        lblType1.TabIndex = 5
        lblType1.Text = "IN"
        ' 
        ' lblItem1
        ' 
        lblItem1.AutoSize = True
        lblItem1.ForeColor = Color.White
        lblItem1.Location = New Point(20, 55)
        lblItem1.Name = "lblItem1"
        lblItem1.Size = New Size(42, 15)
        lblItem1.TabIndex = 4
        lblItem1.Text = "T-Shirt"
        ' 
        ' lblHeaderDate
        ' 
        lblHeaderDate.AutoSize = True
        lblHeaderDate.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderDate.Location = New Point(600, 15)
        lblHeaderDate.Name = "lblHeaderDate"
        lblHeaderDate.Size = New Size(34, 15)
        lblHeaderDate.TabIndex = 3
        lblHeaderDate.Text = "DATE"
        ' 
        ' lblHeaderQty
        ' 
        lblHeaderQty.AutoSize = True
        lblHeaderQty.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderQty.Location = New Point(450, 15)
        lblHeaderQty.Name = "lblHeaderQty"
        lblHeaderQty.Size = New Size(28, 15)
        lblHeaderQty.TabIndex = 2
        lblHeaderQty.Text = "QTY"
        ' 
        ' lblHeaderType
        ' 
        lblHeaderType.AutoSize = True
        lblHeaderType.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblHeaderType.Location = New Point(280, 15)
        lblHeaderType.Name = "lblHeaderType"
        lblHeaderType.Size = New Size(33, 15)
        lblHeaderType.TabIndex = 1
        lblHeaderType.Text = "TYPE"
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
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.BackColor = Color.Transparent
        lblRecentTitle.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentTitle.ForeColor = Color.White
        lblRecentTitle.Location = New Point(35, 275)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(188, 20)
        lblRecentTitle.TabIndex = 5
        lblRecentTitle.Text = "Recent Ukay Transactions"
        ' 
        ' pnlSuppliers
        ' 
        pnlSuppliers.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlSuppliers.Controls.Add(lblSuppliersDesc)
        pnlSuppliers.Controls.Add(lblSuppliersCount)
        pnlSuppliers.Controls.Add(lblSuppliersTitle)
        pnlSuppliers.Location = New Point(625, 120)
        pnlSuppliers.Name = "pnlSuppliers"
        pnlSuppliers.Size = New Size(275, 130)
        pnlSuppliers.TabIndex = 4
        ' 
        ' lblSuppliersDesc
        ' 
        lblSuppliersDesc.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSuppliersDesc.ForeColor = Color.FromArgb(CByte(113), CByte(113), CByte(122))
        lblSuppliersDesc.Location = New Point(20, 95)
        lblSuppliersDesc.Name = "lblSuppliersDesc"
        lblSuppliersDesc.Size = New Size(220, 62)
        lblSuppliersDesc.TabIndex = 8
        lblSuppliersDesc.Text = "Active suppliers"
        ' 
        ' lblSuppliersCount
        ' 
        lblSuppliersCount.Font = New Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSuppliersCount.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblSuppliersCount.Location = New Point(20, 45)
        lblSuppliersCount.Name = "lblSuppliersCount"
        lblSuppliersCount.Size = New Size(220, 62)
        lblSuppliersCount.TabIndex = 7
        lblSuppliersCount.Text = "12"
        ' 
        ' lblSuppliersTitle
        ' 
        lblSuppliersTitle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblSuppliersTitle.Location = New Point(20, 20)
        lblSuppliersTitle.Name = "lblSuppliersTitle"
        lblSuppliersTitle.Size = New Size(200, 25)
        lblSuppliersTitle.TabIndex = 6
        lblSuppliersTitle.Text = "SUPPLIERS"
        ' 
        ' pnlItemsOUT
        ' 
        pnlItemsOUT.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlItemsOUT.Controls.Add(lblItemsOUTDesc)
        pnlItemsOUT.Controls.Add(lblItemsOUTCount)
        pnlItemsOUT.Controls.Add(lblItemsOUTTitle)
        pnlItemsOUT.Location = New Point(330, 120)
        pnlItemsOUT.Name = "pnlItemsOUT"
        pnlItemsOUT.Size = New Size(275, 130)
        pnlItemsOUT.TabIndex = 3
        ' 
        ' lblItemsOUTDesc
        ' 
        lblItemsOUTDesc.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblItemsOUTDesc.ForeColor = Color.FromArgb(CByte(113), CByte(113), CByte(122))
        lblItemsOUTDesc.Location = New Point(19, 87)
        lblItemsOUTDesc.Name = "lblItemsOUTDesc"
        lblItemsOUTDesc.Size = New Size(220, 45)
        lblItemsOUTDesc.TabIndex = 5
        lblItemsOUTDesc.Text = "Sold items"
        ' 
        ' lblItemsOUTCount
        ' 
        lblItemsOUTCount.Font = New Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblItemsOUTCount.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblItemsOUTCount.Location = New Point(20, 45)
        lblItemsOUTCount.Name = "lblItemsOUTCount"
        lblItemsOUTCount.Size = New Size(220, 45)
        lblItemsOUTCount.TabIndex = 4
        lblItemsOUTCount.Text = "85"
        ' 
        ' lblItemsOUTTitle
        ' 
        lblItemsOUTTitle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblItemsOUTTitle.Location = New Point(20, 20)
        lblItemsOUTTitle.Name = "lblItemsOUTTitle"
        lblItemsOUTTitle.Size = New Size(200, 25)
        lblItemsOUTTitle.TabIndex = 3
        lblItemsOUTTitle.Text = "ITEMS OUT"
        ' 
        ' pnlItemsIN
        ' 
        pnlItemsIN.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(31))
        pnlItemsIN.Controls.Add(lblItemsINDesc)
        pnlItemsIN.Controls.Add(lblItemsINCount)
        pnlItemsIN.Controls.Add(lblItemsINTitle)
        pnlItemsIN.Location = New Point(35, 120)
        pnlItemsIN.Name = "pnlItemsIN"
        pnlItemsIN.Size = New Size(275, 130)
        pnlItemsIN.TabIndex = 2
        ' 
        ' lblItemsINDesc
        ' 
        lblItemsINDesc.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblItemsINDesc.ForeColor = Color.FromArgb(CByte(113), CByte(113), CByte(122))
        lblItemsINDesc.Location = New Point(20, 95)
        lblItemsINDesc.Name = "lblItemsINDesc"
        lblItemsINDesc.Size = New Size(220, 45)
        lblItemsINDesc.TabIndex = 2
        lblItemsINDesc.Text = "New arrivals"
        ' 
        ' lblItemsINCount
        ' 
        lblItemsINCount.Font = New Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblItemsINCount.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblItemsINCount.Location = New Point(20, 45)
        lblItemsINCount.Name = "lblItemsINCount"
        lblItemsINCount.Size = New Size(220, 45)
        lblItemsINCount.TabIndex = 1
        lblItemsINCount.Text = "120"
        ' 
        ' lblItemsINTitle
        ' 
        lblItemsINTitle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblItemsINTitle.Location = New Point(20, 20)
        lblItemsINTitle.Name = "lblItemsINTitle"
        lblItemsINTitle.Size = New Size(200, 25)
        lblItemsINTitle.TabIndex = 0
        lblItemsINTitle.Text = "ITEMS IN"
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblWelcome.Location = New Point(37, 70)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(233, 15)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Welcome back! Here's your shop overview."
        ' 
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.AutoSize = True
        lblDashboardTitle.BackColor = Color.Transparent
        lblDashboardTitle.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardTitle.ForeColor = Color.White
        lblDashboardTitle.Location = New Point(35, 30)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Size = New Size(197, 40)
        lblDashboardTitle.TabIndex = 0
        lblDashboardTitle.Text = "DASHBOARD"
        ' 
        ' ucDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(8))
        Controls.Add(pnlDashboard)
        Name = "ucDashboard"
        Size = New Size(976, 645)
        pnlDashboard.ResumeLayout(False)
        pnlDashboard.PerformLayout()
        pnlPlacement.ResumeLayout(False)
        pnlPlacement.PerformLayout()
        pnlTransactions.ResumeLayout(False)
        pnlTransactions.PerformLayout()
        pnlSuppliers.ResumeLayout(False)
        pnlItemsOUT.ResumeLayout(False)
        pnlItemsIN.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlPlacement As Panel
    Friend WithEvents lblPlacementStatus As Label
    Friend WithEvents lblPlacementInfo As Label
    Friend WithEvents lblPlacementTitle As Label
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents lblDate3 As Label
    Friend WithEvents lblQty3 As Label
    Friend WithEvents lblType3 As Label
    Friend WithEvents lblItem3 As Label
    Friend WithEvents lblDate2 As Label
    Friend WithEvents lblQty2 As Label
    Friend WithEvents lblType2 As Label
    Friend WithEvents lblItem2 As Label
    Friend WithEvents lblDate1 As Label
    Friend WithEvents lblQty1 As Label
    Friend WithEvents lblType1 As Label
    Friend WithEvents lblItem1 As Label
    Friend WithEvents lblHeaderDate As Label
    Friend WithEvents lblHeaderQty As Label
    Friend WithEvents lblHeaderType As Label
    Friend WithEvents lblHeaderItem As Label
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents pnlSuppliers As Panel
    Friend WithEvents lblSuppliersDesc As Label
    Friend WithEvents lblSuppliersCount As Label
    Friend WithEvents lblSuppliersTitle As Label
    Friend WithEvents pnlItemsOUT As Panel
    Friend WithEvents lblItemsOUTDesc As Label
    Friend WithEvents lblItemsOUTCount As Label
    Friend WithEvents lblItemsOUTTitle As Label
    Friend WithEvents pnlItemsIN As Panel
    Friend WithEvents lblItemsINDesc As Label
    Friend WithEvents lblItemsINCount As Label
    Friend WithEvents lblItemsINTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblDashboardTitle As Label

End Class
