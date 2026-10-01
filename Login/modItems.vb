Imports System.Data
Imports System.Data.SqlClient

Module modItems

    '''All items, most recent first. Kept for any other screen still using it.
    Public Function GetAllItems() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Category, Quantity, Status, DateAdded, DatePlaced " &
                         "FROM dbo.Items ORDER BY DateAdded DESC")
    End Function

    ''' Items that have arrived but haven't been placed on the floor yet.
    Public Function GetItemsAwaitingPlacement() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Category, Quantity, DateAdded " &
                         "FROM dbo.Items WHERE Status = 'In Stock' ORDER BY DateAdded ASC")
    End Function

    ''' Items currently on the floor, with where they were put. Backs ucPlacement's right-hand grid.
    ''' Filters to Status = 'Placed', so a sold item drops out the moment SellItem runs.
    Public Function GetPlacedItems() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Category, Quantity, Location " &
                         "FROM dbo.Items WHERE Status = 'Placed' ORDER BY DatePlaced DESC")
    End Function

    ''' Items not yet sold (In Stock, Placed, or Returned). Backs the left-hand grid in ucItemsInAndOut.
    ''' Returned items land back here because they're Status <> 'Sold' again.
    Public Function GetInStockItems() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Category, Quantity " &
                         "FROM dbo.Items WHERE Status <> 'Sold' ORDER BY ItemID DESC")
    End Function

    ''' Items already sold. Backs the right-hand grid in ucItemsInAndOut and the Return dropdown.
    Public Function GetSoldItems() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Category, Quantity, Price " &
                         "FROM dbo.Items WHERE Status = 'Sold' ORDER BY ItemID DESC")
    End Function

    ''' In-stock items with no supplier tagged yet. Backs the Buy dropdown in ucBuyingReturns.
    Public Function GetUntaggedItems() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Category, Quantity " &
                         "FROM dbo.Items WHERE Status <> 'Sold' AND SupplierID IS NULL ORDER BY ItemID DESC")
    End Function

    ''' Items tagged with a supplier and cost. Backs the Purchases grid in ucBuyingReturns.
    Public Function GetPurchaseLog() As DataTable
        Return RunQuery("SELECT i.ItemID, i.ItemName, i.Category, s.Name AS Supplier, i.Cost " &
                         "FROM dbo.Items i JOIN dbo.Suppliers s ON i.SupplierID = s.SupplierID " &
                         "ORDER BY i.ItemID DESC")
    End Function

    ''' Items that came back after being sold. Backs the Returns grid in ucBuyingReturns.
    Public Function GetReturnLog() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Category, Quantity, ReturnAmount, ReturnDate " &
                         "FROM dbo.Items WHERE Status = 'Returned' ORDER BY ReturnDate DESC")
    End Function

    ''' A merged, real activity feed — arrivals, placements, sales, and returns, newest first.
    ''' Backs the dashboard's "Recent Transactions" list. Built from the same date columns
    ''' each screen already stamps (DateAdded/DatePlaced/SoldDate/ReturnDate) — no new schema.
    Public Function GetRecentActivity(topN As Integer) As DataTable
        Dim sql As String =
            "SELECT TOP (@TopN) * FROM (" &
            "  SELECT ItemName, 'IN' AS EventType, Quantity, DateAdded AS EventDate FROM dbo.Items" &
            "  UNION ALL" &
            "  SELECT ItemName, 'PLACED', Quantity, DatePlaced FROM dbo.Items WHERE DatePlaced IS NOT NULL" &
            "  UNION ALL" &
            "  SELECT ItemName, 'SOLD', Quantity, SoldDate FROM dbo.Items WHERE SoldDate IS NOT NULL" &
            "  UNION ALL" &
            "  SELECT ItemName, 'RETURNED', Quantity, ReturnDate FROM dbo.Items WHERE ReturnDate IS NOT NULL" &
            ") AS Activity ORDER BY EventDate DESC"

        Dim dt As New DataTable()
        Using conn As New SqlConnection(modDatabase.ConnString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@TopN", topN)
                conn.Open()
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    ''' Logs a new arrival with Status = 'In Stock'.
    Public Sub AddItem(itemName As String, category As String, quantity As Integer)
        Using conn As New SqlConnection(modDatabase.ConnString)
            Dim sql As String = "INSERT INTO dbo.Items (ItemName, Category, Quantity) " &
                                 "VALUES (@Name, @Category, @Qty)"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Name", itemName)
                cmd.Parameters.AddWithValue("@Category", If(String.IsNullOrWhiteSpace(category), CObj(DBNull.Value), category))
                cmd.Parameters.AddWithValue("@Qty", quantity)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' Moves an item from 'In Stock' to 'Placed', stamps the placement date, and records where it went.
    ''' Does not touch Price — placement and pricing are separate concerns.
    Public Sub MarkAsPlaced(itemId As Integer, location As String)
        Using conn As New SqlConnection(modDatabase.ConnString)
            Dim sql As String = "UPDATE dbo.Items SET Status = 'Placed', DatePlaced = SYSDATETIME(), Location = @Location " &
                                 "WHERE ItemID = @ItemID"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Location", location)
                cmd.Parameters.AddWithValue("@ItemID", itemId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' Sells the item's full remaining quantity at the given price and marks it Sold.
    Public Sub SellItem(itemId As Integer, price As Decimal)
        Using conn As New SqlConnection(modDatabase.ConnString)
            Dim sql As String = "UPDATE dbo.Items SET Status = 'Sold', Price = @Price, SoldDate = SYSDATETIME() " &
                                 "WHERE ItemID = @ItemID"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Price", price)
                cmd.Parameters.AddWithValue("@ItemID", itemId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' Permanently removes an item row. Used to undo a mistaken entry.
    Public Sub DeleteItem(itemId As Integer)
        Using conn As New SqlConnection(modDatabase.ConnString)
            Dim sql As String = "DELETE FROM dbo.Items WHERE ItemID = @ItemID"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ItemID", itemId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' Tags an in-stock item with the supplier it was bought from and its cost.
    Public Sub LogPurchase(itemId As Integer, supplierId As Integer, cost As Decimal)
        Using conn As New SqlConnection(modDatabase.ConnString)
            Dim sql As String = "UPDATE dbo.Items SET SupplierID = @SupplierID, Cost = @Cost WHERE ItemID = @ItemID"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@SupplierID", supplierId)
                cmd.Parameters.AddWithValue("@Cost", cost)
                cmd.Parameters.AddWithValue("@ItemID", itemId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' Marks a sold item as returned and puts it back in stock (Status <> 'Sold').
    Public Sub LogReturn(itemId As Integer, returnAmount As Decimal)
        Using conn As New SqlConnection(modDatabase.ConnString)
            Dim sql As String = "UPDATE dbo.Items SET Status = 'Returned', ReturnAmount = @ReturnAmount, ReturnDate = SYSDATETIME() " &
                                 "WHERE ItemID = @ItemID"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ReturnAmount", returnAmount)
                cmd.Parameters.AddWithValue("@ItemID", itemId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' Shared helper so every query here opens/closes the connection the same way.
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