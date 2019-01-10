'Class ProductDB

Imports System.Data.OleDb

Public Class ProductDB
    Public Shared Function GetProductList() As List(Of Product)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection

        Dim selectStatement As String =
        "SELECT ProductCode, Name " &
        "FROM Products " &
        "ORDER BY Name"

        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        Dim products As New List(Of Product)
        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader()

            Dim product As Product
            Do While reader.Read
                product = New Product
                With product
                    .ProductCode = CStr(reader("ProductCode"))
                    .Name = CStr(reader("Name"))

                End With
                products.Add(product)
            Loop
            reader.Close()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return products

    End Function
    Public Shared Function GetProductName(ByVal productCode As String) As String
        Dim connection As OleDbConnection = TechSupportDB.GetConnection

        Dim selectStatement As String = String.Format(
        "Select Name FROM Products WHERE ProductCode = '{0}'",
        productCode)

        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        Dim productName As String = String.Empty
        Try
            connection.Open()
            productName = CStr(selectCommand.ExecuteScalar())
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return productName

    End Function
End Class