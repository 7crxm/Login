Public Class ucItemsIn

    Private Sub ucItemsIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub btnINAdd_Click(sender As Object, e As EventArgs) Handles btnINAdd.Click

        ' txtUsername = item name, TextBox1 = category, TextBox2 = quantity
        If txtUsername.Text.Trim() = "" Then
            MessageBox.Show("Please enter an item name.", "Unicloth",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If

        Dim qty As Integer
        If Not Integer.TryParse(TextBox2.Text.Trim(), qty) OrElse qty <= 0 Then
            MessageBox.Show("Quantity must be a whole number greater than 0.", "Unicloth",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
            Exit Sub
        End If

        Try
            modItems.AddItem(txtUsername.Text.Trim(), TextBox1.Text.Trim(), qty)

            txtUsername.Clear()
            TextBox1.Clear()
            TextBox2.Clear()
            txtUsername.Focus()

            RefreshGrid()

        Catch ex As Exception
            MessageBox.Show("Could not save the item: " & ex.Message, "System Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub RefreshGrid()
        dgvItems.DataSource = modItems.GetAllItems()
    End Sub

    Private Sub dgvItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellContentClick

    End Sub
End Class
