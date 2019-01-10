Imports TechSupportData

Public Class Validator
    Private Shared m_Title As String = "Entry Error"

    Public Shared Property Title() As String
        Get
            Return m_Title
        End Get
        Set(ByVal value As String)
            m_Title = value
        End Set
    End Property

    Public Shared Function IsPresent(ByVal control As Control) As Boolean
        Dim incident As New Incident


        If control.GetType.ToString = "System.Windows.Forms.TextBox" Then
            Dim txtTitle As TextBox = CType(control, TextBox)
            If txtTitle.Text = "" Then
                MessageBox.Show("required field.", Title)
                txtTitle.Select()
                Return False
            Else
                Return True
            End If
            If String.IsNullOrEmpty(txtTitle.Text) Then
                MessageBox.Show("required field.", Title)

            End If
            Return False
        End If
        Return True
    End Function

    Public Shared Function IsDecimal(ByVal textBox As TextBox) As Boolean
        Try
            Convert.ToDecimal(textBox.Text)
            Return True
        Catch ex As FormatException
            MessageBox.Show(textBox.Tag.ToString & " must be a decimal value.", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        End Try

    End Function

    Public Shared Function IsInt32(ByVal textBox As TextBox) As Boolean

        Try

            Convert.ToInt32(textBox.Text)
            Return True
        Catch ex As FormatException
            MessageBox.Show(textBox.Tag.ToString & " must be an integer value.", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        End Try
    End Function

    Public Shared Function IsStateZipCode(ByVal textBox As TextBox,
            ByVal firstZip As Integer, ByVal lastZip As Integer) As Boolean
        Dim zipCode As Integer = CInt(textBox.Text)
        If zipCode <= firstZip OrElse zipCode >= lastZip Then
            MessageBox.Show(textBox.Tag.ToString & " must be within this range: " &
                firstZip & " to " & lastZip & ".", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsPhoneNumber(ByVal textBox As TextBox) As Boolean
        If Not IsNumeric(textBox.Text.Replace(".", "")) Then
            MessageBox.Show(textBox.Tag.ToString & " must be in this format: " &
                "999.999.9999.", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        Else
            Return True
        End If
    End Function
End Class
