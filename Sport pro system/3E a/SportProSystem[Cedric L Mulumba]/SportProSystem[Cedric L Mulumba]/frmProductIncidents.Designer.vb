<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductIncidents
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
        Dim ProductCodeLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim VersionLabel As System.Windows.Forms.Label
        Dim ReleaseDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductIncidents))
        Me.TechSupportDataSet2C = New SportProSystem_Cedric_L_Mulumba_.TechSupportDataSet2C()
        Me.IncidentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncidentsTableAdapter = New SportProSystem_Cedric_L_Mulumba_.TechSupportDataSet2CTableAdapters.IncidentsTableAdapter()
        Me.TableAdapterManager = New SportProSystem_Cedric_L_Mulumba_.TechSupportDataSet2CTableAdapters.TableAdapterManager()
        Me.ProductsTableAdapter = New SportProSystem_Cedric_L_Mulumba_.TechSupportDataSet2CTableAdapters.ProductsTableAdapter()
        Me.IncidentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IncidentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerInfo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.VersionTextBox = New System.Windows.Forms.TextBox()
        Me.ReleaseDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        ProductCodeLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        VersionLabel = New System.Windows.Forms.Label()
        ReleaseDateLabel = New System.Windows.Forms.Label()
        CType(Me.TechSupportDataSet2C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IncidentsBindingNavigator.SuspendLayout()
        CType(Me.IncidentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductCodeLabel
        '
        ProductCodeLabel.AutoSize = True
        ProductCodeLabel.Location = New System.Drawing.Point(31, 45)
        ProductCodeLabel.Name = "ProductCodeLabel"
        ProductCodeLabel.Size = New System.Drawing.Size(98, 17)
        ProductCodeLabel.TabIndex = 2
        ProductCodeLabel.Text = "Product Code:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(31, 76)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'VersionLabel
        '
        VersionLabel.AutoSize = True
        VersionLabel.Location = New System.Drawing.Point(31, 107)
        VersionLabel.Name = "VersionLabel"
        VersionLabel.Size = New System.Drawing.Size(60, 17)
        VersionLabel.TabIndex = 6
        VersionLabel.Text = "Version:"
        '
        'ReleaseDateLabel
        '
        ReleaseDateLabel.AutoSize = True
        ReleaseDateLabel.Location = New System.Drawing.Point(31, 139)
        ReleaseDateLabel.Name = "ReleaseDateLabel"
        ReleaseDateLabel.Size = New System.Drawing.Size(98, 17)
        ReleaseDateLabel.TabIndex = 8
        ReleaseDateLabel.Text = "Release Date:"
        '
        'TechSupportDataSet2C
        '
        Me.TechSupportDataSet2C.DataSetName = "TechSupportDataSet2C"
        Me.TechSupportDataSet2C.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IncidentsBindingSource
        '
        Me.IncidentsBindingSource.DataMember = "Incidents"
        Me.IncidentsBindingSource.DataSource = Me.TechSupportDataSet2C
        '
        'IncidentsTableAdapter
        '
        Me.IncidentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.UpdateOrder = SportProSystem_Cedric_L_Mulumba_.TechSupportDataSet2CTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'IncidentsBindingNavigator
        '
        Me.IncidentsBindingNavigator.AddNewItem = Nothing
        Me.IncidentsBindingNavigator.BindingSource = Me.IncidentsBindingSource
        Me.IncidentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IncidentsBindingNavigator.DeleteItem = Nothing
        Me.IncidentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.IncidentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.IncidentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IncidentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IncidentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IncidentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IncidentsBindingNavigator.Name = "IncidentsBindingNavigator"
        Me.IncidentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IncidentsBindingNavigator.Size = New System.Drawing.Size(818, 27)
        Me.IncidentsBindingNavigator.TabIndex = 0
        Me.IncidentsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'IncidentsDataGridView
        '
        Me.IncidentsDataGridView.AutoGenerateColumns = False
        Me.IncidentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IncidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IncidentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.CustomerInfo})
        Me.IncidentsDataGridView.DataSource = Me.IncidentsBindingSource
        Me.IncidentsDataGridView.Location = New System.Drawing.Point(34, 184)
        Me.IncidentsDataGridView.Name = "IncidentsDataGridView"
        Me.IncidentsDataGridView.RowTemplate.Height = 24
        Me.IncidentsDataGridView.Size = New System.Drawing.Size(772, 220)
        Me.IncidentsDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DateOpened"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DateOpened"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DateClosed"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DateClosed"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Customers"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Customers"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Technicians"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Technicians"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'CustomerInfo
        '
        Me.CustomerInfo.HeaderText = ""
        Me.CustomerInfo.Name = "CustomerInfo"
        Me.CustomerInfo.Text = "Customer Info"
        Me.CustomerInfo.UseColumnTextForButtonValue = True
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.TechSupportDataSet2C
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ProductCode", True))
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(144, 45)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ProductCodeTextBox.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(144, 73)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NameTextBox.TabIndex = 5
        '
        'VersionTextBox
        '
        Me.VersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Version", True))
        Me.VersionTextBox.Location = New System.Drawing.Point(144, 104)
        Me.VersionTextBox.Name = "VersionTextBox"
        Me.VersionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.VersionTextBox.TabIndex = 7
        '
        'ReleaseDateDateTimePicker
        '
        Me.ReleaseDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductsBindingSource, "ReleaseDate", True))
        Me.ReleaseDateDateTimePicker.Location = New System.Drawing.Point(144, 134)
        Me.ReleaseDateDateTimePicker.Name = "ReleaseDateDateTimePicker"
        Me.ReleaseDateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.ReleaseDateDateTimePicker.TabIndex = 9
        '
        'frmProductIncidents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 439)
        Me.Controls.Add(ProductCodeLabel)
        Me.Controls.Add(Me.ProductCodeTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(VersionLabel)
        Me.Controls.Add(Me.VersionTextBox)
        Me.Controls.Add(ReleaseDateLabel)
        Me.Controls.Add(Me.ReleaseDateDateTimePicker)
        Me.Controls.Add(Me.IncidentsDataGridView)
        Me.Controls.Add(Me.IncidentsBindingNavigator)
        Me.Name = "frmProductIncidents"
        Me.Text = "frmProductIncidents"
        CType(Me.TechSupportDataSet2C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IncidentsBindingNavigator.ResumeLayout(False)
        Me.IncidentsBindingNavigator.PerformLayout()
        CType(Me.IncidentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TechSupportDataSet2C As SportProSystem_Cedric_L_Mulumba_.TechSupportDataSet2C
    Friend WithEvents IncidentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IncidentsTableAdapter As SportProSystem_Cedric_L_Mulumba_.TechSupportDataSet2CTableAdapters.IncidentsTableAdapter
    Friend WithEvents TableAdapterManager As SportProSystem_Cedric_L_Mulumba_.TechSupportDataSet2CTableAdapters.TableAdapterManager
    Friend WithEvents IncidentsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProductsTableAdapter As SportProSystem_Cedric_L_Mulumba_.TechSupportDataSet2CTableAdapters.ProductsTableAdapter
    Friend WithEvents IncidentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VersionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReleaseDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerInfo As System.Windows.Forms.DataGridViewButtonColumn
End Class
