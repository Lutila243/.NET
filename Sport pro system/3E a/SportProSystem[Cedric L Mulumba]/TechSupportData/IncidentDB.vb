Imports System.Data.OleDb
Public Class IncidentDB
    Public Shared Function GetOpenIncidents() As List(Of Incident)
        Dim IncidentList As New List(Of Incident)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectStatement As String =
            "SELECT CustomerID, ProductCode, TechID, DateOpened, Title " &
            "FROM Incidents " &
            "WHERE DateClosed IS NULL"


        Dim selectCommand As New OleDbCommand(selectStatement, connection)

        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader
            Dim Incident As Incident
            Do While reader.Read
                Incident = New Incident
                Incident.CustomerID = CInt(reader("CustomerID"))
                Incident.ProductCode = reader("ProductCode").ToString
                'NUllable TechID
                If IsDBNull(reader("TechID")) Then
                    Incident.TechID = Nothing
                Else
                    Incident.TechID = CInt(reader("TechID"))
                End If
                Incident.DateOpened = CDate(reader("DateOpened"))
                Incident.Title = reader("Title").ToString
                IncidentList.Add(Incident)
            Loop
            reader.Close()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return IncidentList
    End Function

    Public Shared Sub AddIncident(ByVal incident As Incident)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim insertStatement As String =
            "INSERT INTO Incidents " &
            "(CustomerID, ProductCode, DateOpened, Title, Description) " &
            "VALUES (@CustomerID, @ProductCode, @DateOpen, @Title, @Description)"
        Dim insertCommand As New OleDbCommand(insertStatement, connection)
        insertCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID)
        insertCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode)
        insertCommand.Parameters.AddWithValue("@DateOpen", incident.DateOpened)
        insertCommand.Parameters.AddWithValue("@Title", incident.Title)
        insertCommand.Parameters.AddWithValue("@Description", incident.Description)
        Try
            connection.Open()
            insertCommand.ExecuteNonQuery()
        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Sub

    Public Shared Function GetIncident(ByVal incidentID As Integer) As Incident
        Dim incident As New Incident
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectStatement As String =
            "SELECT IncidentID, CustomerID, ProductCode, TechID, DateOpened, DateClosed, Title, Description " &
            "FROM Incidents " &
            "WHERE IncidentID = @IncidentID"
        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@IncidentID", incidentID)
        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                incident.IncidentID = CInt(reader("IncidentID"))
                incident.CustomerID = CInt(reader("CustomerID"))
                incident.ProductCode = reader("ProductCode").ToString
                If IsDBNull(reader("TechID")) Then
                    incident.TechID = Nothing
                Else
                    incident.TechID = CInt(reader("TechID"))
                End If
                incident.DateOpened = CDate(reader("DateOpened"))
                If IsDBNull(reader("DateClosed")) Then
                    incident.DateClosed = Nothing
                Else
                    incident.DateClosed = CDate(reader("DateClosed"))
                End If
                incident.Title = reader("Title").ToString
                incident.Description = reader("Description").ToString
            Else
                incident = Nothing
            End If
            reader.Close()

        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
        Return incident
    End Function

    Public Shared Function UpdateIncident(ByVal incident As Incident, ByVal description As String) As Boolean
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim updatestatement As String =
            "UPDATE Incidents " &
            "SET Description = @NewDescription " &
            "WHERE IncidentID = @IncidnetID " &
            " AND Description = @Description " &
            " AND DateClosed IS NULL"
        Dim updateCommand As New OleDbCommand(updatestatement, connection)
        updateCommand.Parameters.AddWithValue("@NewDescription", description)
        updateCommand.Parameters.AddWithValue("@IncidnetID", incident.IncidentID)
        updateCommand.Parameters.AddWithValue("@Description", incident.Description)
        Try
            connection.Open()
            Dim count As Integer = updateCommand.ExecuteNonQuery
            If count > 0 Then
                Return True
            Else
                Return False
            End If


        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Function

    Public Shared Function CloseIncident(ByVal incident As Incident) As Boolean
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim updateStatement As String =
            "UPDATE Incidents " &
            "SET DateClosed = @DateClosed " &
            "WHERE IncidentID = @IncidentID " &
            " AND Description =@Description" &
            " AND DateClosed IS NULL"
        Dim updateCommand As New OleDbCommand(updateStatement, connection)
        updateCommand.Parameters.AddWithValue("@DateClosed", DateTime.Today)
        updateCommand.Parameters.AddWithValue("@IncidnetID", incident.IncidentID)
        updateCommand.Parameters.AddWithValue("@Description", incident.Description)
        Try
            connection.Open()
            Dim count As Integer = updateCommand.ExecuteNonQuery
            If count > 0 Then
                Return True
            Else
                Return False
            End If


        Catch ex As OleDbException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Function

    Public Shared Function GetOpenTechnicianIncidents(ByVal techID As Integer) As List(Of Incident)
        Dim incidentlist As New List(Of Incident)
        Dim connection As OleDbConnection = TechSupportDB.GetConnection
        Dim selectStatement As String =
            "SELECT CustomerID, ProductCode, DateOpened, Title, Description " &
            "FROM Incidents " &
            "WHERE TechID =@TechID " &
            " AND DateClosed IS NULL"
        Dim selectCommand As New OleDbCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("?TechID", techID)
        Try
            connection.Open()
            Dim reader As OleDbDataReader = selectCommand.ExecuteReader
            Dim incident As Incident
            Do While reader.Read
                incident = New Incident
                incident.CustomerID = CInt(reader("CustomerID"))
                incident.ProductCode = reader("ProductCode").ToString
                incident.DateOpened = CDate(reader("DateOpened"))
                incident.Title = reader("Title").ToString
                incident.Description = reader("Description").ToString
                incidentlist.Add(incident)
            Loop
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return incidentlist
    End Function




End Class
