Imports System.ComponentModel
Imports System.Linq
Imports pos
Public Class item_frame
    Private _name As String
    Private _price As Double
    Private _icon As Image
    Public Shared temp_record As List(Of String) = New List(Of String)

    <Category("Custom Props")>
    Public Property ItemName As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
            item_name.Text = value
        End Set
    End Property


    <Category("Custom Props")>
    Public Property ItemPrice As Double
        Get
            Return _price
        End Get
        Set(value As Double)
            _price = value
            item_price.Text = "Php " + value.ToString("#.00")
        End Set
    End Property


    <Category("Custom Props")>
    Public Property ItemIcon As Image
        Get
            Return _icon
        End Get
        Set(value As Image)
            _icon = value
            image.Image = value
        End Set
    End Property


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If temp_record.Count + 1 <= 10 Then
            Dim record = From t_record In temp_record Where t_record = _name
            If Not record.Any() Then
                temp_record.Add(_name)
                Dim send As counter = New counter With {
                .N_Order = _name,
                .N_Price = _price}
                Main.order_container.Controls.Add(send)
            Else
                Message.Show($"Item is already in Cart", Message.AlertType.Info)
                Message.ShowDialog()
                ' Message.Icon_Type = Message.Icon_Type.Info
            End If
        Else
            Message.Show($"Maximum item to order reach!", Message.AlertType.Info)
            Message.ShowDialog()
        End If
    End Sub
End Class
