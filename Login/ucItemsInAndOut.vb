Public Class ucItemsInAndOut

    Private Sub ucItemsIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrids()
    End Sub

    Private Sub btnINAdd_Click(sender As Object, e As EventArgs) Handles btnINAdd.Click
        If txtItemName.Text.Trim() = "" Then
            MessageBox.Show("Please enter an item name.", "Unicloth", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtItemName.Focus()
            Exit Sub
        End If

        Dim qty As Integer
        If Not Integer.TryParse(txtQuantity.Text.Trim(), qty) OrElse qty <= 0 Then
            MessageBox.Show("Quantity must be a whole number greater than 0.", "Unicloth", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Exit Sub
        End If

        Try
            modItems.AddItem(txtItemName.Text.Trim(), txtCategoryPrice.Text.Trim(), qty)
            ClearInputs()
            RefreshGrids()
        Catch ex As Exception
            MessageBox.Show("Could not save the item: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOUTsell_Click(sender As Object, e As EventArgs) Handles btnOUTsell.Click
        ' Sell always moves the full remaining quantity of the selected row.
        ' txtCategoryPrice is repurposed here as the selling price (see lblINCategory text).
        If dgvInStock.CurrentRow Is Nothing Then
            MessageBox.Show("Select an item from the IN STOCK list to sell.", "Unicloth", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim price As Decimal
        If Not Decimal.TryParse(txtCategoryPrice.Text.Trim(), price) OrElse price <= 0 Then
            MessageBox.Show("Enter a valid selling price.", "Unicloth", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCategoryPrice.Focus()
            Exit Sub
        End If

        Dim itemId As Integer = CInt(dgvInStock.CurrentRow.Cells("ItemID").Value)

        Try
            modItems.SellItem(itemId, price)
            ClearInputs()
            RefreshGrids()
        Catch ex As Exception
            MessageBox.Show("Could not sell the item: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Deletes the selected IN STOCK row outright — for undoing an add mistake.
        ' Does not touch dgvSold: a completed sale is a different kind of correction.
        If dgvInStock.CurrentRow Is Nothing Then
            MessageBox.Show("Select an item from the IN STOCK list to delete.", "Unicloth", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim itemId As Integer = CInt(dgvInStock.CurrentRow.Cells("ItemID").Value)
        Dim itemName As String = dgvInStock.CurrentRow.Cells("ItemName").Value.ToString()

        Dim confirm = MessageBox.Show($"Delete '{itemName}'? This cannot be undone.", "Confirm Delete",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm <> DialogResult.Yes Then Exit Sub

        Try
            modItems.DeleteItem(itemId)
            ClearInputs()
            RefreshGrids()
        Catch ex As Exception
            MessageBox.Show("Could not delete the item: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvInStock_SelectionChanged(sender As Object, e As EventArgs) Handles dgvInStock.SelectionChanged
        If dgvInStock.CurrentRow Is Nothing Then Exit Sub
        txtItemName.Text = dgvInStock.CurrentRow.Cells("ItemName").Value.ToString()
    End Sub

    Private Sub RefreshGrids()
        dgvInStock.DataSource = modItems.GetInStockItems()
        If dgvInStock.Columns.Contains("ItemID") Then dgvInStock.Columns("ItemID").Visible = False

        dgvSold.DataSource = modItems.GetSoldItems()
        If dgvSold.Columns.Contains("ItemID") Then dgvSold.Columns("ItemID").Visible = False
    End Sub

    Private Sub ClearInputs()
        txtItemName.Clear()
        txtCategoryPrice.Clear()
        txtQuantity.Clear()
        txtItemName.Focus()
    End Sub

End Class