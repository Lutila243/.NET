<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateIncident
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
        Me.lblIncidentID = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblTechnician = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDateOpened = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.txtIncidentID = New System.Windows.Forms.TextBox()
        Me.btnGetIncident = New System.Windows.Forms.Button()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtTechnician = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtDateOpened = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtTextToAdd = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCloseIncident = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIncidentID
        '
        Me.lblIncidentID.AutoSize = True
        Me.lblIncidentID.Location = New System.Drawing.Point(12, 36)
        Me.lblIncidentID.Name = "lblIncidentID"
        Me.lblIncidentID.Size = New System.Drawing.Size(78, 17)
        Me.lblIncidentID.TabIndex = 0
        Me.lblIncidentID.Text = "Incident ID:"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(12, 66)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(72, 17)
        Me.lblCustomer.TabIndex = 1
        Me.lblCustomer.Text = "Customer:"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(12, 95)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(61, 17)
        Me.lblProduct.TabIndex = 2
        Me.lblProduct.Text = "Product:"
        '
        'lblTechnician
        '
        Me.lblTechnician.AutoSize = True
        Me.lblTechnician.Location = New System.Drawing.Point(12, 124)
        Me.lblTechnician.Name = "lblTechnician"
        Me.lblTechnician.Size = New System.Drawing.Size(81, 17)
        Me.lblTechnician.TabIndex = 3
        Me.lblTechnician.Text = "Technician:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 153)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 17)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title:"
        '
        'lblDateOpened
        '
        Me.lblDateOpened.AutoSize = True
        Me.lblDateOpened.Location = New System.Drawing.Point(12, 181)
        Me.lblDateOpened.Name = "lblDateOpened"
        Me.lblDateOpened.Size = New System.Drawing.Size(94, 17)
        Me.lblDateOpened.TabIndex = 5
        Me.lblDateOpened.Text = "Date opened:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 209)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 17)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.Text = "Description:"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(12, 350)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(83, 17)
        Me.lblText.TabIndex = 7
        Me.lblText.Text = "Text to add:"
        '
        'txtIncidentID
        '
        Me.txtIncidentID.Location = New System.Drawing.Point(110, 36)
        Me.txtIncidentID.Name = "txtIncidentID"
        Me.txtIncidentID.Size = New System.Drawing.Size(100, 22)
        Me.txtIncidentID.TabIndex = 8
        '
        'btnGetIncident
        '
        Me.btnGetIncident.Location = New System.Drawing.Point(226, 36)
        Me.btnGetIncident.Name = "btnGetIncident"
        Me.btnGetIncident.Size = New System.Drawing.Size(115, 23)
        Me.btnGetIncident.TabIndex = 9
        Me.btnGetIncident.Text = "Get Incident"
        Me.btnGetIncident.UseVisualStyleBackColor = True
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(110, 66)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(342, 22)
        Me.txtCustomer.TabIndex = 10
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(110, 92)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(342, 22)
        Me.txtProduct.TabIndex = 11
        '
        'txtTechnician
        '
        Me.txtTechnician.Location = New System.Drawing.Point(110, 121)
        Me.txtTechnician.Name = "txtTechnician"
        Me.txtTechnician.Size = New System.Drawing.Size(342, 22)
        Me.txtTechnician.TabIndex = 12
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(110, 150)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(342, 22)
        Me.txtTitle.TabIndex = 13
        '
        'txtDateOpened
        '
        Me.txtDateOpened.Location = New System.Drawing.Point(110, 178)
        Me.txtDateOpened.Name = "txtDateOpened"
        Me.txtDateOpened.Size = New System.Drawing.Size(140, 22)
        Me.txtDateOpened.TabIndex = 14
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(110, 206)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(342, 142)
        Me.txtDescription.TabIndex = 15
        '
        'txtTextToAdd
        '
        Me.txtTextToAdd.Location = New System.Drawing.Point(110, 354)
        Me.txtTextToAdd.Multiline = True
        Me.txtTextToAdd.Name = "txtTextToAdd"
        Me.txtTextToAdd.Size = New System.Drawing.Size(342, 158)
        Me.txtTextToAdd.TabIndex = 16
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(110, 518)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCloseIncident
        '
        Me.btnCloseIncident.Location = New System.Drawing.Point(226, 518)
        Me.btnCloseIncident.Name = "btnCloseIncident"
        Me.btnCloseIncident.Size = New System.Drawing.Size(115, 23)
        Me.btnCloseIncident.TabIndex = 18
        Me.btnCloseIncident.Text = "Close Incident"
        Me.btnCloseIncident.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(377, 518)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmUpdateIncident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 553)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCloseIncident)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtTextToAdd)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtDateOpened)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtTechnician)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.btnGetIncident)
        Me.Controls.Add(Me.txtIncidentID)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblDateOpened)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblTechnician)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.lblIncidentID)
        Me.Name = "frmUpdateIncident"
        Me.Text = "frmUpdateIncident"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIncidentID As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents lblTechnician As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDateOpened As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents txtIncidentID As System.Windows.Forms.TextBox
    Friend WithEvents btnGetIncident As System.Windows.Forms.Button
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtTechnician As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtDateOpened As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtTextToAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCloseIncident As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
