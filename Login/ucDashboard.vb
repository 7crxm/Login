Imports System.Data

Public Class ucDashboard

    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDashboard()
    End Sub

    Private Sub RefreshDashboard()
        lblItemsINCount.Text = modItems.GetInStockItems().Rows.Count.ToString()
        lblItemsOUTCount.Text = modItems.GetSoldItems().Rows.Count.ToString()
        lblSuppliersCount.Text = modSuppliers.GetAllSuppliers().Rows.Count.ToString()

        Dim activity = modItems.GetRecentActivity(3)
        LoadActivityRow(lblItem1, lblType1, lblQty1, lblDate1, activity, 0)
        LoadActivityRow(lblItem2, lblType2, lblQty2, lblDate2, activity, 1)
        LoadActivityRow(lblItem3, lblType3, lblQty3, lblDate3, activity, 2)

        Dim awaitingCount = modItems.GetItemsAwaitingPlacement().Rows.Count
        lblPlacementInfo.Text = $"{awaitingCount} item(s) scheduled for display today"
        lblPlacementStatus.Text = If(awaitingCount > 0, "READY", "ALL PLACED")
    End Sub

    Private Sub LoadActivityRow(itemLbl As Label, typeLbl As Label, qtyLbl As Label, dateLbl As Label,
                                 activity As DataTable, index As Integer)
        If index >= activity.Rows.Count Then
            itemLbl.Text = ""
            typeLbl.Text = ""
            qtyLbl.Text = ""
            dateLbl.Text = ""
            Exit Sub
        End If

        Dim row = activity.Rows(index)
        Dim eventType As String = row("EventType").ToString()

        itemLbl.Text = row("ItemName").ToString()
        typeLbl.Text = eventType
        typeLbl.ForeColor = ColorForEventType(eventType)
        qtyLbl.Text = row("Quantity").ToString()
        dateLbl.Text = CDate(row("EventDate")).ToString("MMM d, yyyy")
    End Sub

    Private Function ColorForEventType(eventType As String) As Color
        Select Case eventType
            Case "IN"
                Return Color.FromArgb(168, 85, 247)    ' purple — the original IN color
            Case "PLACED"
                Return Color.FromArgb(96, 165, 250)     ' blue
            Case "SOLD"
                Return Color.FromArgb(74, 222, 128)      ' green
            Case "RETURNED"
                Return Color.FromArgb(248, 113, 113)     ' red — matches Buying & Returns
            Case Else
                Return Color.White
        End Select
    End Function

End Class