Public Class frmProductIncidents

    Private Sub frmProductIncidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechSupportDataSet2C.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.TechSupportDataSet2C.Products)
        'TODO: This line of code loads data into the 'TechSupportDataSet2C.Incidents' table. You can move, or remove it, as needed.
        Me.IncidentsTableAdapter.Fill(Me.TechSupportDataSet2C.Incidents)

    End Sub

    Private Sub IncidentsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles IncidentsDataGridView.CellContentClick
        If e.ColumnIndex = 5 Then
            frmCustomer.Show()
        End If
    End Sub
End Class