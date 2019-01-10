'Name: Cedric L Mulumba
'Date: 12/15/16
'Project Name: 3E
'Project: Write code to create the command and parameter objects needed
'          to insert a new incident into the table.

Imports TechSupportData

Public Class frmMaintainRegistrations

    Private Sub frmMaintainRegistrations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.LoadComboBoxes()
    End Sub

    Private Sub LoadComboBoxes()
        Try
            Dim customerList As List(Of Customer)
            customerList = CustomerDB.GetCustomerList
            NameComboBox.DataSource = customerList
            NameComboBox.DisplayMember = "Name"
            NameComboBox.ValueMember = "CustomerID"

            Dim productList As List(Of Product)
            productList = ProductDB.GetProductList
            NameComboBox1.DataSource = productList
            NameComboBox1.DisplayMember = "Name"
            NameComboBox1.ValueMember = "ProductCode"

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Function RegistrationAllowed() As Boolean
        Dim customerID As Integer = CInt(NameComboBox.SelectedValue)
        Dim productCode As String = CStr(NameComboBox1.SelectedValue)
        If RegistrationDB.ProductRegistered(customerID, productCode) Then
            MessageBox.Show("This product is already registered to this customer", "Product already registered")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If RegistrationAllowed() Then
            Dim registration As New Registration
            registration.CustomerID = CInt(NameComboBox.SelectedValue)
            registration.ProductCode = CStr(NameComboBox1.SelectedValue)
            registration.DateOpened = DateTime.Today

            Try
                RegistrationDB.AddRegistration(registration)
                MessageBox.Show("The registration had been make.", "Registration Create", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.GetType.ToString)
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    
End Class