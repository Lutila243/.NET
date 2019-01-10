<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpenIncidents
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
        Me.chProductCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDateOpen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCustomer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTechnician = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwIncidents = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'chProductCode
        '
        Me.chProductCode.Text = "Product Code"
        Me.chProductCode.Width = 112
        '
        'chDateOpen
        '
        Me.chDateOpen.Text = "Date Opened"
        Me.chDateOpen.Width = 109
        '
        'chCustomer
        '
        Me.chCustomer.Text = "Customer"
        Me.chCustomer.Width = 137
        '
        'chTechnician
        '
        Me.chTechnician.Text = "Technician"
        Me.chTechnician.Width = 128
        '
        'chTitle
        '
        Me.chTitle.Text = "Title"
        Me.chTitle.Width = 230
        '
        'lvwIncidents
        '
        Me.lvwIncidents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chProductCode, Me.chDateOpen, Me.chCustomer, Me.chTechnician, Me.chTitle})
        Me.lvwIncidents.Location = New System.Drawing.Point(12, 12)
        Me.lvwIncidents.Name = "lvwIncidents"
        Me.lvwIncidents.Size = New System.Drawing.Size(882, 453)
        Me.lvwIncidents.TabIndex = 0
        Me.lvwIncidents.UseCompatibleStateImageBehavior = False
        Me.lvwIncidents.View = System.Windows.Forms.View.Details
        '
        'frmOpenIncidents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 478)
        Me.Controls.Add(Me.lvwIncidents)
        Me.Name = "frmOpenIncidents"
        Me.Text = "Open Incidents[Cedric L Mulumba]"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chProductCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDateOpen As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCustomer As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTechnician As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwIncidents As System.Windows.Forms.ListView
End Class
