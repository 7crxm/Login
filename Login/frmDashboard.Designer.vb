<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        pnlTopBar = New Panel()
        lblTopSubtitle = New Label()
        lblTopLogo = New Label()
        pnlSidebar = New Panel()
        btnLogout = New Button()
        btnPlacement = New Button()
        btnBuyingReturns = New Button()
        Button2 = New Button()
        Button1 = New Button()
        btnItemsIN = New Button()
        btnDashboard = New Button()
        Label1 = New Label()
        lblShopName = New Label()
        pnlMain = New Panel()
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
        lblRecentTitle = New Label()
        pnlTransactions = New Panel()
        lblHeaderItem = New Label()
        lblHeaderType = New Label()
        lblHeaderQty = New Label()
        lblHeaderDate = New Label()
        lblItem1 = New Label()
        Label2 = New Label()
        lblQty1 = New Label()
        lblDate1 = New Label()
        lblDate2 = New Label()
        lblQty2 = New Label()
        lblType2 = New Label()
        lblItem2 = New Label()
        lblDate3 = New Label()
        lblQty3 = New Label()
        lblType3 = New Label()
        lblItem3 = New Label()
        lblPlacementTitle = New Label()
        pnlPlacement = New Panel()
        lblPlacementInfo = New Label()
        lblPlacementStatus = New Label()
        pnlTopBar.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlSuppliers.SuspendLayout()
        pnlItemsOUT.SuspendLayout()
        pnlItemsIN.SuspendLayout()
        pnlTransactions.SuspendLayout()
        pnlPlacement.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTopBar
        ' 
        pnlTopBar.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlTopBar.Controls.Add(lblTopSubtitle)
        pnlTopBar.Controls.Add(lblTopLogo)
        pnlTopBar.Location = New Point(0, 0)
        pnlTopBar.Margin = New Padding(4, 3, 4, 3)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.Size = New Size(1200, 70)
        pnlTopBar.TabIndex = 0
        ' 
        ' lblTopSubtitle
        ' 
        lblTopSubtitle.AutoSize = True
        lblTopSubtitle.BackColor = Color.Transparent
        lblTopSubtitle.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTopSubtitle.ForeColor = Color.FromArgb(CByte(161), CByte(161), CByte(170))
        lblTopSubtitle.Location = New Point(24, 38)
        lblTopSubtitle.Margin = New Padding(4, 0, 4, 0)
        lblTopSubtitle.Name = "lblTopSubtitle"
        lblTopSubtitle.Size = New Size(164, 13)
        lblTopSubtitle.TabIndex = 1
        lblTopSubtitle.Text = "UKAY-UKAY INVENTORY SYSTEM"
        lblTopSubtitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTopLogo
        ' 
        lblTopLogo.BackColor = Color.Transparent
        lblTopLogo.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTopLogo.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblTopLogo.Location = New Point(24, 10)
        lblTopLogo.Margin = New Padding(4, 0, 4, 0)
        lblTopLogo.Name = "lblTopLogo"
        lblTopLogo.Size = New Size(180, 35)
        lblTopLogo.TabIndex = 0
        lblTopLogo.Text = "UNICLOTH"
        lblTopLogo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnPlacement)
        pnlSidebar.Controls.Add(btnBuyingReturns)
        pnlSidebar.Controls.Add(Button2)
        pnlSidebar.Controls.Add(Button1)
        pnlSidebar.Controls.Add(btnItemsIN)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(Label1)
        pnlSidebar.Controls.Add(lblShopName)
        pnlSidebar.Location = New Point(0, 70)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(240, 630)
        pnlSidebar.TabIndex = 1
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.FromArgb(CByte(212), CByte(212), CByte(216))
        btnLogout.Location = New Point(15, 547)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(15, 0, 0, 0)
        btnLogout.Size = New Size(210, 45)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnPlacement
        ' 
        btnPlacement.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        btnPlacement.Cursor = Cursors.Hand
        btnPlacement.FlatAppearance.BorderSize = 0
        btnPlacement.FlatStyle = FlatStyle.Flat
        btnPlacement.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPlacement.ForeColor = Color.FromArgb(CByte(212), CByte(212), CByte(216))
        btnPlacement.Location = New Point(15, 365)
        btnPlacement.Name = "btnPlacement"
        btnPlacement.Padding = New Padding(15, 0, 0, 0)
        btnPlacement.Size = New Size(210, 45)
        btnPlacement.TabIndex = 7
        btnPlacement.Text = "Item Placement"
        btnPlacement.TextAlign = ContentAlignment.MiddleLeft
        btnPlacement.UseVisualStyleBackColor = False
        ' 
        ' btnBuyingReturns
        ' 
        btnBuyingReturns.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        btnBuyingReturns.Cursor = Cursors.Hand
        btnBuyingReturns.FlatAppearance.BorderSize = 0
        btnBuyingReturns.FlatStyle = FlatStyle.Flat
        btnBuyingReturns.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuyingReturns.ForeColor = Color.FromArgb(CByte(212), CByte(212), CByte(216))
        btnBuyingReturns.Location = New Point(15, 315)
        btnBuyingReturns.Name = "btnBuyingReturns"
        btnBuyingReturns.Padding = New Padding(15, 0, 0, 0)
        btnBuyingReturns.Size = New Size(210, 45)
        btnBuyingReturns.TabIndex = 6
        btnBuyingReturns.Text = "Buying and Returns"
        btnBuyingReturns.TextAlign = ContentAlignment.MiddleLeft
        btnBuyingReturns.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(212), CByte(212), CByte(216))
        Button2.Location = New Point(15, 265)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(15, 0, 0, 0)
        Button2.Size = New Size(210, 45)
        Button2.TabIndex = 5
        Button2.Text = "Supplier Information"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(212), CByte(212), CByte(216))
        Button1.Location = New Point(15, 215)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(15, 0, 0, 0)
        Button1.Size = New Size(210, 45)
        Button1.TabIndex = 4
        Button1.Text = "Items OUT Handling"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnItemsIN
        ' 
        btnItemsIN.BackColor = Color.FromArgb(CByte(16), CByte(16), CByte(22))
        btnItemsIN.Cursor = Cursors.Hand
        btnItemsIN.FlatAppearance.BorderSize = 0
        btnItemsIN.FlatStyle = FlatStyle.Flat
        btnItemsIN.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnItemsIN.ForeColor = Color.FromArgb(CByte(212), CByte(212), CByte(216))
        btnItemsIN.Location = New Point(15, 165)
        btnItemsIN.Name = "btnItemsIN"
        btnItemsIN.Padding = New Padding(15, 0, 0, 0)
        btnItemsIN.Size = New Size(210, 45)
        btnItemsIN.TabIndex = 3
        btnItemsIN.Text = "Items IN Handling"
        btnItemsIN.TextAlign = ContentAlignment.MiddleLeft
        btnItemsIN.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(139), CByte(92), CByte(246))
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(15, 115)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(15, 0, 0, 0)
        btnDashboard.Size = New Size(210, 45)
        btnDashboard.TabIndex = 2
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(113), CByte(113), CByte(122))
        Label1.Location = New Point(27, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 20)
        Label1.TabIndex = 1
        Label1.Text = "THRIFT SHOP MANAGEMENT"
        ' 
        ' lblShopName
        ' 
        lblShopName.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblShopName.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        lblShopName.Location = New Point(25, 25)
        lblShopName.Name = "lblShopName"
        lblShopName.Size = New Size(190, 35)
        lblShopName.TabIndex = 0
        lblShopName.Text = "UNICLOTH"
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlPlacement)
        pnlMain.Controls.Add(lblPlacementTitle)
        pnlMain.Controls.Add(pnlTransactions)
        pnlMain.Controls.Add(lblRecentTitle)
        pnlMain.Controls.Add(pnlSuppliers)
        pnlMain.Controls.Add(pnlItemsOUT)
        pnlMain.Controls.Add(pnlItemsIN)
        pnlMain.Controls.Add(lblWelcome)
        pnlMain.Controls.Add(lblDashboardTitle)
        pnlMain.Location = New Point(240, 70)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(960, 630)
        pnlMain.TabIndex = 2
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
        pnlTransactions.Controls.Add(Label2)
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
        lblHeaderType.Location = New Point(280, 15)
        lblHeaderType.Name = "lblHeaderType"
        lblHeaderType.Size = New Size(33, 15)
        lblHeaderType.TabIndex = 1
        lblHeaderType.Text = "TYPE"
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(168), CByte(85), CByte(247))
        Label2.Location = New Point(280, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(19, 15)
        Label2.TabIndex = 5
        Label2.Text = "IN"
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
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(8), CByte(12))
        ClientSize = New Size(1184, 661)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlTopBar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Unicloth - Dashboard"
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlSuppliers.ResumeLayout(False)
        pnlItemsOUT.ResumeLayout(False)
        pnlItemsIN.ResumeLayout(False)
        pnlTransactions.ResumeLayout(False)
        pnlTransactions.PerformLayout()
        pnlPlacement.ResumeLayout(False)
        pnlPlacement.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblTopLogo As Label
    Friend WithEvents lblTopSubtitle As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblShopName As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnItemsIN As Button
    Friend WithEvents btnPlacement As Button
    Friend WithEvents btnBuyingReturns As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents pnlSuppliers As Panel
    Friend WithEvents pnlItemsOUT As Panel
    Friend WithEvents pnlItemsIN As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblItemsINDesc As Label
    Friend WithEvents lblItemsINCount As Label
    Friend WithEvents lblItemsINTitle As Label
    Friend WithEvents lblSuppliersDesc As Label
    Friend WithEvents lblSuppliersCount As Label
    Friend WithEvents lblSuppliersTitle As Label
    Friend WithEvents lblItemsOUTDesc As Label
    Friend WithEvents lblItemsOUTCount As Label
    Friend WithEvents lblItemsOUTTitle As Label
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents pnlTransactions As Panel
    Friend WithEvents lblHeaderType As Label
    Friend WithEvents lblHeaderItem As Label
    Friend WithEvents lblItem1 As Label
    Friend WithEvents lblHeaderDate As Label
    Friend WithEvents lblHeaderQty As Label
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
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPlacementTitle As Label
    Friend WithEvents pnlPlacement As Panel
    Friend WithEvents lblPlacementInfo As Label
    Friend WithEvents lblPlacementStatus As Label
End Class
