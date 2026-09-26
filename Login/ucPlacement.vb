Public Class ucPlacement

    Private Sub ucPlacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub btnMarkPlaced_Click(sender As Object, e As EventArgs) Handles btnMarkPlaced.Click

        If dgvPlacement.CurrentRow Is Nothing Then
            MessageBox.Show("Select an item first.", "Unicloth",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim itemId As Integer = CInt(dgvPlacement.CurrentRow.Cells("colItemID").Value)

        Try
            modItems.MarkAsPlaced(itemId)
            RefreshGrid()

        Catch ex As Exception
            MessageBox.Show("Could not update the item: " & ex.Message, "System Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub RefreshGrid()
        Dim dt = modItems.GetItemsAwaitingPlacement()
        dgvPlacement.DataSource = dt

        lblPlacementSummaryInfo.Text = $"{dt.Rows.Count} item(s) scheduled for display today"
        lblPlacementSummaryStatus.Text = If(dt.Rows.Count > 0, "READY", "ALL PLACED")
    End Sub

End Class