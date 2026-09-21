Imports System.Data.SqlClient

Public Module modDatabase
    ' Centralized connection string shared by your whole app
    Public ReadOnly Property ConnString As String
        Get
            Return "Server=localhost;Database=UniclothDB;Trusted_Connection=True;"
        End Get
    End Property
End Module
