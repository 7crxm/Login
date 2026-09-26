Imports System.Data
Imports System.Data.SqlClient

Module modSales

    ''' Items with stock left, for the "which item am I selling" dropdown.
    Public Function GetSellableItems() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Quantity FROM dbo.Items WHERE Quantity > 0 ORDER BY ItemName")
    End Function

    '''All logged sales, most recent first. Backs the ucItemsOut grid.
    Public Function GetAllSales() As DataTable
        Return RunQuery("SELECT SaleID, ItemName, Quantity, Price, DateSold FROM dbo.Sales ORDER BY DateSold DESC")
    End Function

    ''' 
    ''' Decrements the item's stock and logs the sale in one transaction —
    ''' either both happen or neither does, so stock and the sales log can't drift apart.
    '''
    Public Sub AddSale(itemId As Integer, itemName As String, quantity As Integer, price As Decimal)
        Using conn As New SqlConnection(modDatabase.ConnString)
            conn.Open()
            Dim txn As SqlTransaction = conn.BeginTransaction()

            Try
                Dim currentQty As Integer
                Using cmdCheck As New SqlCommand("SELECT Quantity FROM dbo.Items WHERE ItemID = @ItemID", conn, txn)
                    cmdCheck.Parameters.AddWithValue("@ItemID", itemId)
                    currentQty = CInt(cmdCheck.ExecuteScalar())
                End Using

                If quantity > currentQty Then
                    Throw New InvalidOperationException($"Only {currentQty} left in stock.")
                End If

                Using cmdUpdate As New SqlCommand("UPDATE dbo.Items SET Quantity = Quantity - @Qty WHERE ItemID = @ItemID", conn, txn)
                    cmdUpdate.Parameters.AddWithValue("@Qty", quantity)
                    cmdUpdate.Parameters.AddWithValue("@ItemID", itemId)
                    cmdUpdate.ExecuteNonQuery()
                End Using

                Using cmdInsert As New SqlCommand("INSERT INTO dbo.Sales (ItemID, ItemName, Quantity, Price) " &
                                                   "VALUES (@ItemID, @ItemName, @Qty, @Price)", conn, txn)
                    cmdInsert.Parameters.AddWithValue("@ItemID", itemId)
                    cmdInsert.Parameters.AddWithValue("@ItemName", itemName)
                    cmdInsert.Parameters.AddWithValue("@Qty", quantity)
                    cmdInsert.Parameters.AddWithValue("@Price", price)
                    cmdInsert.ExecuteNonQuery()
                End Using

                txn.Commit()

            Catch
                txn.Rollback()
                Throw
            End Try
        End Using
    End Sub

    Private Function RunQuery(sql As String) As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(modDatabase.ConnString)
            Using cmd As New SqlCommand(sql, conn)
                conn.Open()
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

End Module