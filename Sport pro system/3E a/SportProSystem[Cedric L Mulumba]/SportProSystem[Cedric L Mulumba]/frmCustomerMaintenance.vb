Public Class frmCustomerMaintenance

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        'code to handle any data provider  or ADO.NET errors that may occur

        Me.Validate()
        If IsValidData() Then
            Try
                Me.CustomersBindingSource.EndEdit()
                Me.CustomersTableAdapter.Update(
                Me.TechSupportDataSet2B.Customers)
            Catch ex As ArgumentException
                ' This block catches exceptions such as a
                ' value that's beyond the maximum length for
                ' a column in a dataset.                 MessageBox.Show(ex.Message,"Argument Exception")
                CustomersBindingSource.CancelEdit()
            Catch ex As DBConcurrencyException
                MessageBox.Show("A concurrency error " &
                "occurred. The row was not updated.",
                "Concurrency Exception")
                Me.CustomersTableAdapter.Fill(
                Me.TechSupportDataSet2B.Customers)
            Catch ex As DataException
                MessageBox.Show(ex.Message,
                ex.GetType.ToString)
                CustomersBindingSource.CancelEdit()
            Catch ex As Exception
                MessageBox.Show("SQL Server error # " &
                 ": " & ex.Message,
                ex.GetType.ToString)
            End Try
        End If
    End Sub
    Private Function isvalidData() As Boolean
        If CustomersBindingSource.Count > 0 Then
            Return IsPresent(NameTextBox, "Name") AndAlso
                IsPresent(AddressTextBox, "Address") AndAlso
                IsPresent(CityTextBox, "City") AndAlso
                IsPresent(ZipCodeTextBox, "ZipCode")
        Else
            Return True

        End If
    End Function
    Private Function isPresent(ByVal control As Control, ByVal name As String) As Boolean
        If control.GetType.ToString =
        "System.Windows.Forms.TextBox" Then
            Dim textBox As TextBox = CType(control, TextBox)
            If textBox.Text = "" Then
                MessageBox.Show(
                name & " is a required field.",
                "Entry Error")
                textBox.Select()
                Return False
            Else
                Return True
            End If
        ElseIf control.GetType.ToString = "System.Windows.Forms.ComboBox" Then
            Dim ComboBox = CType(control, ComboBox)
            If ComboBox.SelectedIndex = -1 Then
                MessageBox.Show(name & " is a required field.", "Entry Error")
                ComboBox.Select()
                Return False
            Else
                Return False

            End If

        End If
        Return True
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechSupportDataSet2B.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.TechSupportDataSet2B.Customers)
        Dim Z As Binding = ZipCodeTextBox.DataBindings("text")
        AddHandler Z.Format, AddressOf FormatZipCode
        Try
            Me.CustomersTableAdapter.Fill(Me.TechSupportDataSet2B.Customers)

        Catch ex As Exception

        End Try

    End Sub
    Private Sub FormatZipCode(ByVal sender As Object,
                              ByVal e As ConvertEventArgs)
        If e.Value.GetType.ToString = "System.String" Then
            Dim s As String = e.Value.ToString
            If IsNumeric(s) Then
                If s.Length = 9 Then
                    e.Value = s.Substring(0.6) & "-"

                End If
            End If
        End If
    End Sub






    Private Sub frmCustomerMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TechSupportDataSet2B.States' table. You can move, or remove it, as needed.
        Me.StatesTableAdapter.Fill(Me.TechSupportDataSet2B.States)
        'TODO: This line of code loads data into the 'TechSupportDataSet2B.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.TechSupportDataSet2B.Customers)

    End Sub

    Private Sub CustomersBindingNavigatorCancelItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorCancelItem.Click
        'the event handler for the Cancel Button on the BingingNAvigatorToolstrip

        CustomersBindingSource.CancelEdit()

    End Sub


    Private Sub FillByCustomerCToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByCustomerCToolStripButton.Click

        Try
            Dim CustomerID As Integer =
            CInt(CustomerIDToolStripTextBox.Text)
            Me.CustomersTableAdapter.FillByCustomerC(
            Me.TechSupportDataSet2B.Customers, CustomerID)
        Catch ex As InvalidCastException
            MessageBox.Show("Vendor ID must be an integer.",
            "Entry Error")
        Catch ex As System.Exception
            MessageBox.Show("SQL Server error" &
            ": " & ex.Message, ex.GetType.ToString)
        End Try
    End Sub




End Class