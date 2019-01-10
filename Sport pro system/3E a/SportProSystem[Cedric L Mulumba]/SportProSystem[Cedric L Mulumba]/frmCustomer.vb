Public Class frmCustomer

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechSupportDataSet2C.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.TechSupportDataSet2C.Customers)
        'TODO: This line of code loads data into the 'TechSupportDataSet2C.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.TechSupportDataSet2C.Customers)
        'TODO: This line of code loads data into the 'TechSupportDataSet2C.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.TechSupportDataSet2C.Customers)

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TechSupportDataSet2C)
    End Sub
End Class