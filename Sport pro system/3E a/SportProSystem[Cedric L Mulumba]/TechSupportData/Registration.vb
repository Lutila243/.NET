Imports System.Data.OleDb
Public Class Registration

    Private m_CustomerID As Integer
    Private m_ProductCode As String
    Private m_RegistrationDate As Date

    Public Sub New()

    End Sub

    Public Property CustomerID() As Integer
        Get
            Return m_CustomerID
        End Get
        Set(value As Integer)
            m_CustomerID = value
        End Set
    End Property

    Public Property ProductCode() As String
        Get
            Return m_ProductCode
        End Get
        Set(value As String)
            m_ProductCode = value
        End Set
    End Property

    Public Property DateOpened() As Date
        Get
            Return m_RegistrationDate
        End Get
        Set(ByVal value As Date)
            m_RegistrationDate = value
        End Set
    End Property
End Class




