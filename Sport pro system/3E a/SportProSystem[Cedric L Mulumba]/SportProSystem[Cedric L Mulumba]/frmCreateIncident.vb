Imports TechSupportData
Public Class frmCreateIncident

    Private Sub frmCreateIncident_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LoadComboBoxes()
    End Sub

    Private Sub LoadComboBoxes()

        Dim customerlist As List(Of Customer)
        Dim productlist As List(Of Product)
        Try
            customerlist = CustomerDB.GetCustomerList
            cboCustomer.DataSource = customerlist
            cboCustomer.DisplayMember = "Name"
            cboCustomer.ValueMember = "customerID"

            productlist = ProductDB.GetProductList
            cboProduct.DataSource = productlist
            cboProduct.DisplayMember = "Name"
            cboProduct.ValueMember = "productCode"

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub btnIncident_Click(sender As Object, e As EventArgs) Handles btnIncident.Click
        If IsValidData() Then
            Dim incident As New Incident
            incident.CustomerID = CInt(cboCustomer.SelectedValue)
            incident.ProductCode = cboProduct.SelectedValue.ToString
            incident.DateOpened = DateTime.Today
            incident.Title = txtTitle.Text
            incident.Description = txtDescription.Text
            Try
                IncidentDB.AddIncident(incident)
                MessageBox.Show("The incident has been created.", "Incident Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.GetType.ToString)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Function IsValidData() As Boolean
        Dim customerID As String = CStr(cboCustomer.SelectedValue)
        Dim productCode As String = CStr(cboProduct.SelectedValue)
        If RegistrationDB.ProductRegistered(customerID, productCode) Then
            If Validator.IsPresent(txtTitle) AndAlso
             Validator.IsPresent(txtDescription) Then

                Return True
            Else
                Return False
            End If
        Else
            MessageBox.Show("This product is not registered to the customer you selected.", "Product not registered")
            cboCustomer.Select()
            Return False
        End If
    End Function
End Class