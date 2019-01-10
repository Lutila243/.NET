<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintainRegistrations
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
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim NameLabel1 As System.Windows.Forms.Label
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        NameLabel = New System.Windows.Forms.Label()
        NameLabel1 = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(TechSupportData.Customer)
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(28, 27)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(113, 17)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Customer Name:"
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Name", True))
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(31, 59)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(284, 24)
        Me.NameComboBox.TabIndex = 2
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = GetType(TechSupportData.Product)
        '
        'NameLabel1
        '
        NameLabel1.AutoSize = True
        NameLabel1.Location = New System.Drawing.Point(366, 27)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(61, 17)
        NameLabel1.TabIndex = 2
        NameLabel1.Text = "Product:"
        '
        'NameComboBox1
        '
        Me.NameComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Name", True))
        Me.NameComboBox1.FormattingEnabled = True
        Me.NameComboBox1.Location = New System.Drawing.Point(369, 59)
        Me.NameComboBox1.Name = "NameComboBox1"
        Me.NameComboBox1.Size = New System.Drawing.Size(289, 24)
        Me.NameComboBox1.TabIndex = 3
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(31, 111)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(145, 33)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(513, 111)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMaintainRegistrations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 185)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(NameLabel1)
        Me.Controls.Add(Me.NameComboBox1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameComboBox)
        Me.Name = "frmMaintainRegistrations"
        Me.Text = "Maintain Product resgistration"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NameComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
