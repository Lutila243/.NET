'Class TechnicianDB

Option Strict On


Imports System.Data.OleDb

Public Class TechnicianDB
    Public Shared Function GetTechnicianName(ByVal techID As Integer) As String
        Dim connection As OleDbConnection = TechSupportDB.GetConnection

        Dim selectStatement As String = String.Format(
        "SELECT Name FROM Technicians  WHERE techID = {0}",
        techID)

        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        Dim technicianName As String = String.Empty
        Try
            connection.Open()
            technicianName = CStr(selectCommand.ExecuteScalar())
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return technicianName
    End Function
    Public Shared Function GetTechnicianList() As List(Of Technician)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection

        Dim selectStatement As String =
        "SELECT TechID, Name " &
        "FROM Technicians " &
        "ORDER BY Name"

        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        Dim technicians As New List(Of Technician)
        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader()

            Dim technician As Technician
            Do While reader.Read
                technician = New Technician
                With technician
                    .TechID = CInt(reader("TechID"))
                    .Name = CStr(reader("Name"))
                End With
                technicians.Add(technician)
            Loop
            reader.Close()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return technicians

    End Function
    Public Shared Function GetTechnician(ByVal techID As Integer) As Technician

        Dim technician As New Technician

        Dim connection As OleDbConnection = TechSupportDB.GetConnection

        Dim selectStatement As String =
        "SELECT TechID, Name, Email, Phone " &
        "FROM Technicians " &
        "WHERE TechID = @TechID"

        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@TechID", techID)

        Try


            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)


            If reader.Read Then
                With technician
                    .TechID = CInt(reader("TechID"))
                    .Name = reader("Name").ToString
                    .Email = reader("Email").ToString
                    .Phone = reader("Phone").ToString
                End With
            Else

                technician = Nothing
            End If

            reader.Close()
        Catch ex As OleDbException

            Throw ex
        Finally
            connection.Close()
        End Try

        Return technician
    End Function

End Class
