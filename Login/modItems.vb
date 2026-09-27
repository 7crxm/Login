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

    ''' Items not yet sold (In Stock or Placed). Backs the left-hand grid in ucItemsInAndOut.
    Public Function GetInStockItems() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Category, Quantity " &
                         "FROM dbo.Items WHERE Status <> 'Sold' ORDER BY ItemID DESC")
    End Function

    ''' Items already sold. Backs the right-hand grid in ucItemsInAndOut.
    Public Function GetSoldItems() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Category, Quantity, Price " &
                         "FROM dbo.Items WHERE Status = 'Sold' ORDER BY ItemID DESC")
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