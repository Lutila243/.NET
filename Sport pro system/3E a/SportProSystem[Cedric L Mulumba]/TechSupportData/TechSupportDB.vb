'Class TechSupportDB

Imports System.Data.OleDb
Public Class TechSupportDB

    Public Shared Function GetConnection() As OleDbConnection
        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\bob\TechSupport.mdb"
        Dim connection As New OleDbConnection(connectionString)
        Return connection
    End Function
End Class
