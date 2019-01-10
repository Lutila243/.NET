Imports TechSupportData

'Name: Cedric L Mulumba
'Date: 11/23/16
'Project Name: 3A
'Project: Add a form that displays all open incidents in a ListView control.


Public Class frmOpenIncidents
    Private Sub frmOpenIncidents_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim openIncidents As List(Of Incident)

        Try
            openIncidents = IncidentDB.GetOpenIncidents
            If openIncidents.Count > 0 Then
                For Each incident As Incident In openIncidents
                    Dim newItem As ListViewItem = _
                    lvwIncidents.Items.Add(incident.ProductCode)
                    newItem.SubItems.Add(incident.DateOpened.ToShortDateString)
                    newItem.SubItems.Add(incident.CustomerName)
                    newItem.SubItems.Add(incident.TechnicianName)
                    newItem.SubItems.Add(incident.Title)
                Next
            Else

                MessageBox.Show("All incidents not found or closed", "No Open Incidents", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message, ex.GetType.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub lstOpenIncidents_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lvwIncidents.SelectedIndexChanged
    End Sub

End Class