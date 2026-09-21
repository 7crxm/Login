Public Class frmDashboard

    ' COLOR FUNCTION
    Private Sub SetActiveButton(activeButton As Button)

        ' Reset all buttons to normal color
        btnDashboard.BackColor = Color.FromArgb(16, 16, 22)
        btnItemsIN.BackColor = Color.FromArgb(16, 16, 22)
        btnItemsOUT.BackColor = Color.FromArgb(16, 16, 22)
        btnSupplier.BackColor = Color.FromArgb(16, 16, 22)
        btnBuyingReturns.BackColor = Color.FromArgb(16, 16, 22)
        btnPlacement.BackColor = Color.FromArgb(16, 16, 22)

        ' Make the clicked button purple
        activeButton.BackColor = Color.FromArgb(139, 92, 246)

    End Sub


    '======================
    ' BUTTON CLICK EVENTS =
    '======================


    ' Triggers when the Form first loads to show your main dashboard home page
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubPage(New ucDashboard())
    End Sub


    ' Navigates back to the main dashboard home page

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        SetActiveButton(btnDashboard)
        LoadSubPage(New ucDashboard())

    End Sub


    ' Navigates to the Items In page


    Private Sub btnItemsIN_Click(sender As Object, e As EventArgs) Handles btnItemsIN.Click
        SetActiveButton(btnItemsIN)
        LoadSubPage(New ucItemsIn())
    End Sub


    ''' Clears the dashboard panel and loads the specified User Control.
    Private Sub LoadSubPage(ByVal page As UserControl)
        ' 1. Clear out any existing controls currently in the panel
        pnlHome.Controls.Clear()

        ' 2. Make sure the new control stretches to fill the entire panel space
        page.Dock = DockStyle.Fill

        ' 3. Drop it into the panel to display it on screen
        pnlHome.Controls.Add(page)
    End Sub

    Private Sub btnItemsOUT_Click(sender As Object, e As EventArgs) Handles btnItemsOUT.Click
        SetActiveButton(btnItemsOUT)
        LoadSubPage(New ucItemsOut())
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        SetActiveButton(btnSupplier)
        LoadSubPage(New ucSupplier())
    End Sub

    Private Sub btnBuyingReturns_Click(sender As Object, e As EventArgs) Handles btnBuyingReturns.Click
        SetActiveButton(btnBuyingReturns)
        LoadSubPage(New ucBuyingReturns())
    End Sub

    Private Sub btnPlacement_Click(sender As Object, e As EventArgs) Handles btnPlacement.Click
        SetActiveButton(btnPlacement)
        LoadSubPage(New ucPlacement())
    End Sub
End Class