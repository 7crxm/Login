Public Class ucSupplier

    Private Sub ucSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click

        If txtSupplierName.Text.Trim() = "" Then
            MessageBox.Show("Please enter a supplier name.", "Unicloth",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSupplierName.Focus()
            Exit Sub
        End If

        Try
            modSuppliers.AddSupplier(txtSupplierName.Text.Trim(), txtContact.Text.Trim(), txtAddress.Text.Trim())

            txtSupplierName.Clear()
            txtContact.Clear()
            txtAddress.Clear()
            txtSupplierName.Focus()

            RefreshGrid()

        Catch ex As Exception
            MessageBox.Show("Could not save the supplier: " & ex.Message, "System Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub RefreshGrid()
        Dim dt = modSuppliers.GetAllSuppliers()
        dgvSuppliers.DataSource = dt
        lblSupplierSummaryInfo.Text = $"{dt.Rows.Count} supplier(s) on file"
    End Sub

End Class