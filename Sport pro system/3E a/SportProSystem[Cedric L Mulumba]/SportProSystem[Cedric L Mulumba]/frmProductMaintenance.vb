Public Class frmProductMaintenance

    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Try
            Me.TableAdapterManager.UpdateAll(Me.TechSupportDataSet2A)
        Catch ex As Exception
            MsgBox("The rows Cannot accept Null Value")
        End Try
        Try
            Me.ProductsBindingSource.EndEdit()

        Catch ex As Exception
            MessageBox.Show("A concurrency  error occurrred. " &
                            "The row was not updated.", "Concurrency Exception")
        End Try
        Try

            Me.ProductsTableAdapter.Fill(Me.TechSupportDataSet2A.Products)
        Catch ex As DataException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
        Try

            ProductsBindingSource.CancelEdit()
        Catch ex As SqlClient.SqlException
            MessageBox.Show("SQL Server error # " & ex.Number &
                            ": " & ex.Message, ex.GetType.ToString)

        End Try


    End Sub

    Private Sub frmProductMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechSupportDataSet2A.Products' table. You can move, or remove it, as needed.
        Try
            Me.ProductsTableAdapter.Fill(Me.TechSupportDataSet2A.Products)
        Catch ex As Exception
            MessageBox.Show("DataBase Not Found ")


        End Try


    End Sub

private sub ProductsDataGridView_DataError(Byval sender As System.Object,
    Byval e As System.windows.Forms.DataGridViewDataErrorEventArgs) Handles ProductsDataGridView.DataError
        Dim row As Integer = e.RowIndex + 1
        Dim errorMessage As String = "A data error occurred." & vbCrLf & 
            "Row: " & e.Exception.Message 
        MessageBox.Show(errorMessage, "Data Error")
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class