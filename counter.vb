Imports System.ComponentModel
Public Class counter
    Private order_name As String
    Private order_quatity As Integer
    Private order_price As Double

    <Category("Custom Property")>
    Public Property N_Order As String
        Get
            Return order_name
        End Get
        Set(value As String)
            order_name = value
            lblItemName.Text = value
        End Set
    End Property
    <Category("Custom Property")>
    Public Property N_Qt As Integer
        Get
            Return order_quatity
        End Get
        Set(value As Integer)
            order_quatity = value
            quantity.Value = value
        End Set
    End Property
    <Category("Custom Property")>
    Public Property N_Price As Double
        Get
            Return order_price
        End Get
        Set(value As Double)
            order_price = value
            lblItemPrice.Text = "Php " & value.ToString("#.00")
        End Set
    End Property
    Private Sub quantity_ValueChanged(sender As Object, e As EventArgs) Handles quantity.ValueChanged
        lblItemPrice.Text = "Php " & (quantity.Value * order_price).ToString("#.00")
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        item_frame.temp_record.Remove(order_name)
        Me.Parent.Controls.Remove(Me)
    End Sub
End Class
