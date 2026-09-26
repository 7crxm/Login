Public Class ucItemsOut

    Private Sub ucItemsOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSellableItems()
        RefreshGrid()
    End Sub

    Private Sub LoadSellableItems()
        Dim dt = modSales.GetSellableItems()
        cboItem.DataSource = dt
        cboItem.DisplayMember = "ItemName"
        cboItem.ValueMember = "ItemID"
    End Sub

    Private Sub btnOUTAdd_Click(sender As Object, e As EventArgs) Handles btnOUTAdd.Click

        If cboItem.SelectedValue Is Nothing Then
            MessageBox.Show("Select an item to sell.", "Unicloth",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim qty As Integer
        If Not Integer.TryParse(txtQty.Text.Trim(), qty) OrElse qty <= 0 Then
            MessageBox.Show("Quantity must be a whole number greater than 0.", "Unicloth",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQty.Focus()
            Exit Sub
        End If

        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text.Trim(), price) OrElse price < 0 Then
            MessageBox.Show("Enter a valid sale price.", "Unicloth",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Exit Sub
        End If

        Dim selectedRow As DataRowView = CType(cboItem.SelectedItem, DataRowView)
        Dim availableQty As Integer = CInt(selectedRow("Quantity"))

        If qty > availableQty Then
            MessageBox.Show($"Only {availableQty} left in stock.", "Unicloth",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            modSales.AddSale(CInt(cboItem.SelectedValue), cboItem.Text, qty, price)

            txtQty.Clear()
            txtPrice.Clear()

            LoadSellableItems()   ' quantities changed — refresh the dropdown too
            RefreshGrid()

        Catch ex As Exception
            MessageBox.Show("Could not log the sale: " & ex.Message, "System Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub RefreshGrid()
        Dim dt = modSales.GetAllSales()
        dgvSales.DataSource = dt
        lblSalesSummaryInfo.Text = $"{dt.Rows.Count} item(s) sold so far"
    End Sub

End Class