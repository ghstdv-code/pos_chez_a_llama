Imports System.ComponentModel

Public Class PrintableItems
    <Category("Custom Properties")>
    Public WriteOnly Property SetItem As String
        Set(value As String)
            lblItemAndQt.Text = value
        End Set
    End Property
    <Category("Custom Properties")>
    Public WriteOnly Property SetPrice As String
        Set(value As String)
            lblPrice.Text = value
        End Set
    End Property

End Class
