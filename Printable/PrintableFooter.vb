Public Class PrintableFooter
    Private Total, Cash As Double
    Public WriteOnly Property SetSubTotal As Double
        Set(value As Double)
            lblSubtotal.Text = value.ToString("#.00")
        End Set
    End Property
    Public WriteOnly Property SetDiscount As Double
        Set(value As Double)
            If Helper.CheckForZero(value) = True Then
                lblDiscount.Text = "0.00"
            Else
                lblDiscount.Text = value.ToString("#.00")
            End If
        End Set
    End Property
    Public WriteOnly Property SetCash As Double
        Set(value As Double)
            Cash = value
            lblCash.Text = value.ToString("#.00")
        End Set
    End Property
    Public WriteOnly Property SetTotal As Double
        Set(value As Double)
            Total = value
            lblTotal.Text = value.ToString("#.00")
        End Set
    End Property

    Private Sub PrintableFooter_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Helper.CheckForZero(Cash - Total) = True Then
            lblChange.Text = "0.00"
        Else
            lblChange.Text = (Cash - Total).ToString("#.00")
        End If

    End Sub
End Class
