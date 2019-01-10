<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportIncidents5BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainProducts2AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainCustomers2BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainRegistrations3EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainTechnicians5GToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCustomersByProduct5FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateIncident3BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayIncidentsByProduct2CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateMailingList5CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayOpenIncidents3AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayIncidentsByCustomer5EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayIncidentsByProductAndTechnician5DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayOpenIncidentsByTechnician3DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateIncident3CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.RegistrationToolStripMenuItem, Me.IncidentsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(955, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportIncidents5BToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExportIncidents5BToolStripMenuItem
        '
        Me.ExportIncidents5BToolStripMenuItem.Name = "ExportIncidents5BToolStripMenuItem"
        Me.ExportIncidents5BToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ExportIncidents5BToolStripMenuItem.Text = "Export Incidents (5-B)"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaintainProducts2AToolStripMenuItem, Me.MaintainCustomers2BToolStripMenuItem, Me.MaintainRegistrations3EToolStripMenuItem, Me.MaintainTechnicians5GToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'MaintainProducts2AToolStripMenuItem
        '
        Me.MaintainProducts2AToolStripMenuItem.Name = "MaintainProducts2AToolStripMenuItem"
        Me.MaintainProducts2AToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.MaintainProducts2AToolStripMenuItem.Text = "Maintain Products (2-A)"
        '
        'MaintainCustomers2BToolStripMenuItem
        '
        Me.MaintainCustomers2BToolStripMenuItem.Name = "MaintainCustomers2BToolStripMenuItem"
        Me.MaintainCustomers2BToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.MaintainCustomers2BToolStripMenuItem.Text = "Maintain Customers (2-B)"
        '
        'MaintainRegistrations3EToolStripMenuItem
        '
        Me.MaintainRegistrations3EToolStripMenuItem.Name = "MaintainRegistrations3EToolStripMenuItem"
        Me.MaintainRegistrations3EToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.MaintainRegistrations3EToolStripMenuItem.Text = "Maintain Registrations (3-E)"
        '
        'MaintainTechnicians5GToolStripMenuItem
        '
        Me.MaintainTechnicians5GToolStripMenuItem.Name = "MaintainTechnicians5GToolStripMenuItem"
        Me.MaintainTechnicians5GToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.MaintainTechnicians5GToolStripMenuItem.Text = "Maintain Technicians (5-G)"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayCustomersByProduct5FToolStripMenuItem})
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'DisplayCustomersByProduct5FToolStripMenuItem
        '
        Me.DisplayCustomersByProduct5FToolStripMenuItem.Name = "DisplayCustomersByProduct5FToolStripMenuItem"
        Me.DisplayCustomersByProduct5FToolStripMenuItem.Size = New System.Drawing.Size(310, 24)
        Me.DisplayCustomersByProduct5FToolStripMenuItem.Text = "Display Customers by Product (5-F)"
        '
        'IncidentsToolStripMenuItem
        '
        Me.IncidentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateIncident3BToolStripMenuItem, Me.DisplayIncidentsByProduct2CToolStripMenuItem, Me.CreateMailingList5CToolStripMenuItem, Me.DisplayOpenIncidents3AToolStripMenuItem, Me.DisplayIncidentsByCustomer5EToolStripMenuItem, Me.DisplayIncidentsByProductAndTechnician5DToolStripMenuItem, Me.DisplayOpenIncidentsByTechnician3DToolStripMenuItem, Me.UpdateIncident3CToolStripMenuItem})
        Me.IncidentsToolStripMenuItem.Name = "IncidentsToolStripMenuItem"
        Me.IncidentsToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.IncidentsToolStripMenuItem.Text = "Incidents"
        '
        'CreateIncident3BToolStripMenuItem
        '
        Me.CreateIncident3BToolStripMenuItem.Name = "CreateIncident3BToolStripMenuItem"
        Me.CreateIncident3BToolStripMenuItem.Size = New System.Drawing.Size(406, 24)
        Me.CreateIncident3BToolStripMenuItem.Text = "Create Incident (3-B)"
        '
        'DisplayIncidentsByProduct2CToolStripMenuItem
        '
        Me.DisplayIncidentsByProduct2CToolStripMenuItem.Name = "DisplayIncidentsByProduct2CToolStripMenuItem"
        Me.DisplayIncidentsByProduct2CToolStripMenuItem.Size = New System.Drawing.Size(406, 24)
        Me.DisplayIncidentsByProduct2CToolStripMenuItem.Text = "Display Incidents by Product (2-C)"
        '
        'CreateMailingList5CToolStripMenuItem
        '
        Me.CreateMailingList5CToolStripMenuItem.Name = "CreateMailingList5CToolStripMenuItem"
        Me.CreateMailingList5CToolStripMenuItem.Size = New System.Drawing.Size(406, 24)
        Me.CreateMailingList5CToolStripMenuItem.Text = "Create Mailing List (5-C)"
        '
        'DisplayOpenIncidents3AToolStripMenuItem
        '
        Me.DisplayOpenIncidents3AToolStripMenuItem.Name = "DisplayOpenIncidents3AToolStripMenuItem"
        Me.DisplayOpenIncidents3AToolStripMenuItem.Size = New System.Drawing.Size(406, 24)
        Me.DisplayOpenIncidents3AToolStripMenuItem.Text = "Display Open Incidents (3-A)"
        '
        'DisplayIncidentsByCustomer5EToolStripMenuItem
        '
        Me.DisplayIncidentsByCustomer5EToolStripMenuItem.Name = "DisplayIncidentsByCustomer5EToolStripMenuItem"
        Me.DisplayIncidentsByCustomer5EToolStripMenuItem.Size = New System.Drawing.Size(406, 24)
        Me.DisplayIncidentsByCustomer5EToolStripMenuItem.Text = "Display Incidents by Customer (5-E)"
        '
        'DisplayIncidentsByProductAndTechnician5DToolStripMenuItem
        '
        Me.DisplayIncidentsByProductAndTechnician5DToolStripMenuItem.Name = "DisplayIncidentsByProductAndTechnician5DToolStripMenuItem"
        Me.DisplayIncidentsByProductAndTechnician5DToolStripMenuItem.Size = New System.Drawing.Size(406, 24)
        Me.DisplayIncidentsByProductAndTechnician5DToolStripMenuItem.Text = "Display Incidents by Product and Technician (5-D)"
        '
        'DisplayOpenIncidentsByTechnician3DToolStripMenuItem
        '
        Me.DisplayOpenIncidentsByTechnician3DToolStripMenuItem.Name = "DisplayOpenIncidentsByTechnician3DToolStripMenuItem"
        Me.DisplayOpenIncidentsByTechnician3DToolStripMenuItem.Size = New System.Drawing.Size(406, 24)
        Me.DisplayOpenIncidentsByTechnician3DToolStripMenuItem.Text = "Display Open Incidents by Technician (3-D)"
        '
        'UpdateIncident3CToolStripMenuItem
        '
        Me.UpdateIncident3CToolStripMenuItem.Name = "UpdateIncident3CToolStripMenuItem"
        Me.UpdateIncident3CToolStripMenuItem.Size = New System.Drawing.Size(406, 24)
        Me.UpdateIncident3CToolStripMenuItem.Text = "Update Incident (3-C)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(955, 632)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Sport Pro System by Cedric L Mulumba"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportIncidents5BToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintainProducts2AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintainCustomers2BToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintainRegistrations3EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintainTechnicians5GToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncidentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayCustomersByProduct5FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateIncident3BToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateIncident3CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayOpenIncidents3AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayOpenIncidentsByTechnician3DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayIncidentsByProduct2CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateMailingList5CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayIncidentsByProductAndTechnician5DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayIncidentsByCustomer5EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
