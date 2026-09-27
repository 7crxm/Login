Public Class ucPlacement

    Private Sub ucPlacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrids()
    End Sub

    Private Sub btnMarkPlaced_Click(sender As Object, e As EventArgs) Handles btnMarkPlaced.Click

        If dgvAwaiting.CurrentRow Is Nothing Then
            MessageBox.Show("Select an item first.", "Unicloth",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim location As String = txtLocation.Text.Trim()
        If location = "" Then
            MessageBox.Show("Enter where this item is being placed.", "Unicloth",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLocation.Focus()
            Exit Sub
        End If

        Dim itemId As Integer = CInt(dgvAwaiting.CurrentRow.Cells("colItemID").Value)

        Try
            modItems.MarkAsPlaced(itemId, location)
            txtLocation.Clear()
            RefreshGrids()

        Catch ex As Exception
            MessageBox.Show("Could not update the item: " & ex.Message, "System Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub RefreshGrids()
        dgvAwaiting.DataSource = modItems.GetItemsAwaitingPlacement()

        dgvPlaced.DataSource = modItems.GetPlacedItems()
        If dgvPlaced.Columns.Contains("ItemID") Then dgvPlaced.Columns("ItemID").Visible = False
    End Sub

End Class