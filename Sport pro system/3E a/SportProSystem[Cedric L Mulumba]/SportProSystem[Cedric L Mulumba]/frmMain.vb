Public Class frmMain

    
    Private Sub MaintainProducts2AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintainProducts2AToolStripMenuItem.Click
        frmProductMaintenance.MdiParent = Me
        frmProductMaintenance.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'This code is executed when the user taps or clicks the Exit Window
        'button. It closes the window and terminates the program execution.

        Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MaintainCustomers2BToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintainCustomers2BToolStripMenuItem.Click
        frmCustomerMaintenance.MdiParent = Me
        frmCustomerMaintenance.Show()
    End Sub

    
    Private Sub DisplayIncidentsByProduct2CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayIncidentsByProduct2CToolStripMenuItem.Click
        frmProductIncidents.MdiParent = Me
        frmProductIncidents.Show()
    End Sub

    Private Sub DisplayOpenIncidents3AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayOpenIncidents3AToolStripMenuItem.Click

        frmOpenIncidents.MdiParent = Me
        frmOpenIncidents.Show()
    End Sub

   
    Private Sub CreateIncident3BToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateIncident3BToolStripMenuItem.Click
        frmCreateIncident.MdiParent = Me
        frmCreateIncident.Show()

    End Sub

    Private Sub UpdateIncident3CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateIncident3CToolStripMenuItem.Click
        frmUpdateIncident.MdiParent = Me
        frmUpdateIncident.Show()
    End Sub

    Private Sub DisplayOpenIncidentsByTechnician3DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayOpenIncidentsByTechnician3DToolStripMenuItem.Click
        frmTechnicianIncidents.MdiParent = Me
        frmTechnicianIncidents.Show()
    End Sub

    Private Sub MaintainRegistrations3EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintainRegistrations3EToolStripMenuItem.Click
        frmMaintainRegistrations.MdiParent = Me
        frmMaintainRegistrations.Show()
    End Sub
End Class
