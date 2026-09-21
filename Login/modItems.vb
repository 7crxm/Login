Imports System.Data
Imports System.Data.SqlClient

Module modItems

    ''' <summary>All items, most recent first. Backs the ucItemsIn grid.</summary>
    Public Function GetAllItems() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Category, Quantity, Status, DateAdded, DatePlaced " &
                         "FROM dbo.Items ORDER BY DateAdded DESC")
    End Function

    ''' <summary>Items that have arrived but haven't been placed on the floor yet.</summary>
    Public Function GetItemsAwaitingPlacement() As DataTable
        Return RunQuery("SELECT ItemID, ItemName, Category, Quantity, DateAdded " &
                         "FROM dbo.Items WHERE Status = 'In Stock' ORDER BY DateAdded ASC")
    End Function

    ''' <summary>Logs a new arrival with Status = 'In Stock'.</summary>
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

    ''' <summary>Moves an item from 'In Stock' to 'Placed' and stamps the placement date.</summary>
    Public Sub MarkAsPlaced(itemId As Integer)
        Using conn As New SqlConnection(modDatabase.ConnString)
            Dim sql As String = "UPDATE dbo.Items SET Status = 'Placed', DatePlaced = SYSDATETIME() WHERE ItemID = @ItemID"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ItemID", itemId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ''' <summary>Shared helper so every query here opens/closes the connection the same way.</summary>
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
