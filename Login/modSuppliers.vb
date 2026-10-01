Imports System.Data
Imports System.Data.SqlClient

Module modSuppliers

    ''' All suppliers, most recently added first. Backs the ucSupplier grid.
    Public Function GetAllSuppliers() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(modDatabase.ConnString)
            Dim sql As String = "SELECT SupplierID, Name, Contact, Address, DateAdded " &
                                 "FROM dbo.Suppliers ORDER BY DateAdded DESC"
            Using cmd As New SqlCommand(sql, conn)
                conn.Open()
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Sub AddSupplier(name As String, contact As String, address As String)
        Using conn As New SqlConnection(modDatabase.ConnString)
            Dim sql As String = "INSERT INTO dbo.Suppliers (Name, Contact, Address) VALUES (@Name, @Contact, @Address)"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Name", name)
                cmd.Parameters.AddWithValue("@Contact", If(String.IsNullOrWhiteSpace(contact), CObj(DBNull.Value), contact))
                cmd.Parameters.AddWithValue("@Address", If(String.IsNullOrWhiteSpace(address), CObj(DBNull.Value), address))
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module