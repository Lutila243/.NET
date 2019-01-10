'Name: Cedric L Mulumba
'Date: 12/05/16
'Project Name: 3C
'Project:  to add a form that lets the user update or close an incident


Imports TechSupportData

Public Class frmUpdateIncident

    Public incident As Incident


    Private Sub btnGetIncident_Click(sender As Object, e As EventArgs) Handles btnGetIncident.Click

        If Validator.IsPresent(txtIncidentID) AndAlso
           Validator.IsInt32(txtIncidentID) Then
            Dim incidentID As Integer = CInt(txtIncidentID.Text)
            Me.GetIncident(incidentID)
        End If
    End Sub

    Private Sub GetIncident(ByVal incidentID As Integer)
        Try
            incident = IncidentDB.GetIncident(incidentID)
            If incident Is Nothing Then
                MessageBox.Show("No incident found with this ID." & "Please try again.", "Incident not found")
                Me.ClearControls()
                Me.DisableControls()
                txtIncidentID.Select()
            ElseIf incident.DateClosed.HasValue Then
                MessageBox.Show("This incident is already close.", "Incident Close")
                Me.ClearControls()
                Me.DisableControls()
                txtIncidentID.Select()
            Else
                Me.EnabledControls()
                Me.DisplayIncident()
                txtTextToAdd.Select()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub DisableControls()
        btnUpdate.Enabled = False
        btnCloseIncident.Enabled = False
        txtTextToAdd.ReadOnly = True
        txtTextToAdd.TabStop = False
    End Sub

    Private Sub EnabledControls()
        btnUpdate.Enabled = True
        btnCloseIncident.Enabled = True
        txtTextToAdd.ReadOnly = False
        txtTextToAdd.TabStop = True
    End Sub

    Private Sub ClearControls()
        txtCustomer.Text = ""
        txtProduct.Text = ""
        txtTechnician.Text = ""
        txtTitle.Text = ""
        txtDateOpened.Text = ""
        txtDescription.Text = ""
        txtTextToAdd.Text = ""
    End Sub

    Private Sub DisplayIncident()
        txtCustomer.Text = incident.CustomerName
        txtProduct.Text = incident.ProductName
        txtTechnician.Text = incident.TechnicianName
        txtTitle.Text = incident.Title
        txtDateOpened.Text = incident.DateOpened.ToShortDateString
        txtDescription.Text = incident.Description
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Validator.IsPresent(txtTextToAdd) Then
            Dim update As Boolean = True
            Dim description As String
            description = txtDescription.Text & vbCrLf & "<" & Today() & "> " & txtTextToAdd.Text
            If description.Length > 2000 Then
                Dim result As DialogResult = MessageBox.Show("The description is to long", "characters and will be delete. Do you want to continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = Windows.Forms.DialogResult.No Then
                    update = False
                Else
                    description = description.Substring(0, 2000)
                End If
            End If
            If update Then
                If IncidentDB.UpdateIncident(incident, description) Then
                    incident.Description = description
                    txtDescription.Text = incident.Description
                    txtTextToAdd.Text = ""
                Else
                    MessageBox.Show("Another user have update this incident", "Datebase Error")
                End If
            End If
        End If
    End Sub

    Private Sub btnCloseIncident_Click(sender As Object, e As EventArgs) Handles btnCloseIncident.Click
        Dim close As DialogResult = MessageBox.Show("Are you sure you want to close this?", "Delete Incident", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            MessageBox.Show("Another user have update this incident", "Datebase Error")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()

    End Sub
End Class