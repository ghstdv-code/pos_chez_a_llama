Imports System.ComponentModel

Public Class PrintableHeader
    <Category("Custom Property")>
    Public WriteOnly Property SetHeader_OR As Int32
        Set(value As Int32)
            lblOrderNumber.Text = value
        End Set
    End Property
    Private Sub PrintableHeader_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
    End Sub
End Class
