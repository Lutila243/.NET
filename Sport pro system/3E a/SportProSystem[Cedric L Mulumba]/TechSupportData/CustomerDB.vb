'Class Customer

Imports System.Data.OleDb

Public Class CustomerDB
    Public Shared Function GetCustomerName(ByVal customerID As Integer) As String
        Dim connection As OleDbConnection = TechSupportDB.GetConnection

        Dim selectStatement As String = String.Format(
        "SELECT Name FROM Customers WHERE customerID = {0}",
        customerID)

        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        Dim customerName As String = String.Empty
        Try
            connection.Open()
            customerName = CStr(selectCommand.ExecuteScalar())
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return customerName
    End Function

    Public Shared Function GetCustomerList() As List(Of Customer)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection

        Dim selectStatement As String =
        "SELECT CustomerID, Name " &
        "FROM Customers " &
        "ORDER BY Name"

        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        Dim customers As New List(Of Customer)
        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader()

            Dim customer As Customer
            Do While reader.Read
                customer = New Customer
                With customer
                    .CustomerID = CInt(reader("CustomerID"))
                    .Name = CStr(reader("Name"))

                End With
                customers.Add(customer)
            Loop
            reader.Close()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return customers

    End Function
End Class
