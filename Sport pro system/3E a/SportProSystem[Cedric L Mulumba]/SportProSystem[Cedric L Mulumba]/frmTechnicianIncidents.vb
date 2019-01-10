'Name: Cedric L Mulumba
'Date: 12/12/16
'Project Name: 3D
'Project: Add a form that displays all the open incidents for a selected techician


Imports TechSupportData
Public Class frmTechnicianIncidents

    Private techList As List(Of Technician)
    Private Sub frmTechnicianIncidents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.GetTechnicianList()
        Me.GetTechnicianData()
    End Sub

    Private Sub GetTechnicianList()
        Try

            techList = TechnicianDB.GetTechnicianList
            ComboBox1.DataSource = techList
            ComboBox1.DisplayMember = "Name"
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub GetTechnicianData()
        Dim techID As Integer = techList(ComboBox1.SelectedIndex).TechID

        Try
            Dim technician As Technician = TechnicianDB.GetTechnician(techID)
            TechnicianBindingSource.Clear()
            TechnicianBindingSource.Add(technician)

            Dim incidentList As List(Of Incident)
            incidentList = IncidentDB.GetOpenTechnicianIncidents(techID)
            IncidentDataGridView.DataSource = incidentList
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.GetTechnicianData()
    End Sub

End Class

