Public Class ucBuyingReturns

    Private Sub ucBuyingReturns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDropdowns()
        RefreshGrids()
    End Sub

    Private Sub LoadDropdowns()
        cboBuyItem.DataSource = modItems.GetUntaggedItems()
        cboBuyItem.DisplayMember = "ItemName"
        cboBuyItem.ValueMember = "ItemID"

        cboSupplier.DataSource = modSuppliers.GetAllSuppliers()
        cboSupplier.DisplayMember = "Name"
        cboSupplier.ValueMember = "SupplierID"

        ' Only sold items are eligible for a return.
        cboReturnItem.DataSource = modItems.GetSoldItems()
        cboReturnItem.DisplayMember = "ItemName"
        cboReturnItem.ValueMember = "ItemID"
    End Sub

    Private Sub RefreshGrids()
        dgvPurchases.DataSource = modItems.GetPurchaseLog()
        dgvReturns.DataSource = modItems.GetReturnLog()
    End Sub

    Private Sub btnLogPurchase_Click(sender As Object, e As EventArgs) Handles btnLogPurchase.Click
        If cboBuyItem.SelectedValue Is Nothing OrElse cboSupplier.SelectedValue Is Nothing Then
            MessageBox.Show("Select an item and a supplier.", "Unicloth", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim cost As Decimal
        If Not Decimal.TryParse(txtCost.Text.Trim(), cost) OrElse cost <= 0 Then
            MessageBox.Show("Enter a valid cost.", "Unicloth", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCost.Focus()
            Exit Sub
        End If

        Try
            modItems.LogPurchase(CInt(cboBuyItem.SelectedValue), CInt(cboSupplier.SelectedValue), cost)
            txtCost.Clear()
            LoadDropdowns()   ' the item just got tagged, so it drops out of the untagged list
            RefreshGrids()
        Catch ex As Exception
            MessageBox.Show("Could not log the purchase: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogReturn_Click(sender As Object, e As EventArgs) Handles btnLogReturn.Click
        If cboReturnItem.SelectedValue Is Nothing Then
            MessageBox.Show("Select a sold item to return.", "Unicloth", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 0 is allowed — a return with no cash refund (store credit, etc.) is still a valid return.
        Dim refund As Decimal
        If Not Decimal.TryParse(txtReturnAmount.Text.Trim(), refund) OrElse refund < 0 Then
            MessageBox.Show("Enter a valid refund amount.", "Unicloth", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtReturnAmount.Focus()
            Exit Sub
        End If

        Try
            modItems.LogReturn(CInt(cboReturnItem.SelectedValue), refund)
            txtReturnAmount.Clear()
            LoadDropdowns()   ' the item is no longer 'Sold', so it drops out of the return list
            RefreshGrids()
        Catch ex As Exception
            MessageBox.Show("Could not log the return: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class