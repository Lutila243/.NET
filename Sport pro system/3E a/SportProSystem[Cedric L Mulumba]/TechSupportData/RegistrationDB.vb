Imports System.Data.OleDb

Public Class RegistrationDB
    Public Shared Function ProductRegistered(ByVal customerID As Integer, ByVal productCode As String) As Boolean
        Dim count As Integer = 0
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim productstatement As String =
            "SELECT Count(*) " &
            "FROM Registrations " &
            "WHERE CustomerID = @CustomerID " &
            "AND ProductCode = @ProductCode"
        Dim productCommand As New OleDbCommand(productstatement, connection)
        productCommand.Parameters.AddWithValue("@CustomerID", customerID)
        productCommand.Parameters.AddWithValue("@ProductCode", productCode)
        Try
            connection.Open()

            count = CInt(productCommand.ExecuteScalar)
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try

        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Sub AddRegistration(ByVal registration As Registration)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim insertStatement As String =
            "INSERT INTO Registrations (CustomerID, ProductCode, RegistrationDate) " &
            "VALUES (@CustomerID, @ProductCode, @RegistrationDate)"
        Dim insertCommand As New OleDbCommand(insertStatement, connection)
        insertCommand.Parameters.AddWithValue("@CustomerID", registration.CustomerID)
        insertCommand.Parameters.AddWithValue("@ProductCode", registration.ProductCode)
        insertCommand.Parameters.AddWithValue("@RegistrationDate", registration.DateOpened)

        Try
            connection.Open()
            insertCommand.ExecuteNonQuery()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Sub
End Class

