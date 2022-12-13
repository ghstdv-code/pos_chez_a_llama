Imports POS.Helper
Imports System.Text.RegularExpressions
Imports System.Text

Public Class CheckOut

    Private total As Double = 0
    Private item_table As DataTable
    Dim total_discount As Double = 0
    Private _or_number As Int32

    Public Property Get_Or As Int32
        Get
            Return _or_number
        End Get
        Set(value As Int32)
            _or_number = value
            Order_Number.Text = value
        End Set
    End Property
    Public Property Get_Data As DataTable
        Get
            Return item_table
        End Get
        Set(value As DataTable)
            item_table = value
            For i As Integer = 0 To item_table.Rows.Count - 1 Step 1
                data_item.Rows.Add(item_table(i)(0), item_table(i)(1), "Php " & Convert.ToDouble(item_table(i)(2)).ToString("#.00"))
            Next
        End Set
    End Property

    Public Property Total_All As Double
        Get
            Return total
        End Get
        Set(value As Double)
            total = value
            sub_total.Text = value.ToString("#.00")
            grand_total.Text = value.ToString("#.00")

        End Set
    End Property

    Sub DisplayComputationSummary()
        If Not total_discount <= 0 Then
            discount_total.Text = total_discount.ToString("#.00")
        Else
            discount_total.Text = "0.00"
        End If

        If Not total < total_discount Then
            grand_total.Text = (total - total_discount).ToString("#.00")
        Else
            grand_total.Text = "0.00"
        End If
    End Sub

    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        discount_total.Text = "0.00"
    End Sub

    Private Sub GunaWinSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles switch_0.CheckedChanged, switch_2.CheckedChanged, switch_1.CheckedChanged
        Dim switch As Guna.UI.WinForms.GunaWinSwitch = CType(sender, Guna.UI.WinForms.GunaWinSwitch)
        If switch.Checked = True Then
            Select Case switch.Name
                Case "switch_0"
                    total_discount += Percent_Grabber(total, 20)
                    switch_2.Enabled = False
                Case "switch_1"
                    total_discount += Percent_Grabber(total, 15)
                Case "switch_2"
                    total_discount += Percent_Grabber(total, 10)
                    switch_0.Enabled = False
            End Select
        Else
            Select Case switch.Name
                Case "switch_0"
                    total_discount -= Percent_Grabber(total, 20)
                    switch_2.Enabled = True
                Case "switch_1"
                    total_discount -= Percent_Grabber(total, 15)
                Case "switch_2"
                    total_discount -= Percent_Grabber(total, 10)
                    switch_0.Enabled = True
            End Select
        End If
        DisplayComputationSummary()
    End Sub

    'Private Sub Guna2TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles tbx_other.KeyUp
    '    Dim temp As Double
    '    Double.TryParse(tbx_other.Text, temp)

    ' End Sub

    Private Sub tbx_other_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            Else

            End If
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        'Main.order_container.Controls.Clear()
        'item_frame.temp_record.Clear()
        ResetLayout(Main.container, Main.category, Main.order_container)
        Me.Close()
        Message.Show("Your order has canceled!", Message.AlertType.Info)
        Message.ShowDialog()
        Main.Show()
    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click
        If Not String.IsNullOrEmpty(_payment.Text) Then
            Dim rgx As New Regex("^([0-9]+(\.[0-9]+)?)*$")
            If Not rgx.Match(_payment.Text).Success Then
                Message.Show("Invalid Currency Format", Message.AlertType.Warning2)
                Message.ShowDialog()
            Else
                If Check_Payment(Double.Parse(_payment.Text), Double.Parse(grand_total.Text)) = True Then
                    SqlCommand.Get_OrNumber = _or_number
                    SqlCommand.Get_TotalItems = item_table.Rows.Count
                    SqlCommand.Get_Total = Double.Parse(grand_total.Text)
                    SqlCommand.Get_Discount = total_discount
                    SqlCommand.Get_Cash = Double.Parse(_payment.Text)
                    SqlCommand.Get_Change = Double.Parse(_payment.Text) - Double.Parse(grand_total.Text)
                    SqlCommand.PushCommand("INSERT INTO tblRecords(OrderNumber, OrderDate, ItemCount, Total, Discount, Cash, Change) VALUES (@OrderNumber, @OrderDate, @ItemCount, @Total, @Discount, @Cash, @Change)", SqlCommand.CommandType.ADD)
                    Dim pheader As New PrintableHeader With {.SetHeader_OR = _or_number}
                    Reciept.fpanelGeneral.Controls.Add(pheader)
                    For i As Integer = 0 To item_table.Rows.Count - 1 Step 1
                        Dim pitems As New PrintableItems With {
                            .SetItem = item_table(i)(0) & "x " & item_table(i)(1),
                            .SetPrice = Convert.ToDouble(item_table(i)(2)).ToString("#.00")}
                        Reciept.fpanelGeneral.Controls.Add(pitems)
                    Next
                    Dim pfooter As New PrintableFooter With {
                    .SetSubTotal = total,
                    .SetDiscount = total_discount,
                    .SetTotal = Double.Parse(grand_total.Text),
                    .SetCash = Double.Parse(_payment.Text)}
                    Reciept.fpanelGeneral.Controls.Add(pfooter)
                    Hide()
                    SqlCommand.PushCommand("SELECT * FROM tblRecords WHERE ID = (SELECT max(ID) FROM tblRecords)", SqlCommand.CommandType.GETID)
                    Main.new_or.Text = SqlCommand.ID + 1
                    Reciept.Show()
                Else
                    Message.Show("Insufficient Payment", Message.AlertType.Warning2)
                    Message.ShowDialog()
                End If
            End If
        Else
            Message.Show("Please Input Payment", Message.AlertType.Warning2)
            Message.ShowDialog()
        End If
    End Sub

    Private Sub _payment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _payment.KeyPress
        'If Not (Asc(e.KeyChar) = 8) Then
        '    If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46) Then
        '        e.KeyChar = ChrW(0)
        '        e.Handled = True
        '    End If
        'End If
        'Dim rgx As New Regex("([0-9]+(.[0-9]+)?)")
        'Dim match = rgx.Match(e.KeyChar.ToString())
        'If Not rgx.Match(e.KeyChar.ToString()).Success Then
        '    e.Handled = True
        'End If

        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Asc(e.KeyChar) = 46) Then
            e.Handled = True
        End If

    End Sub

    'Private Sub tbx_other_Leave(sender As Object, e As EventArgs)
    '    'Dim out As Double
    '    'Double.TryParse(tbx_other.Text, out)
    '    'total_discount += out
    '    'DisplayComputationSummary()
    'End Sub

    'Private Sub cbx_other_discount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_other_discount.SelectedIndexChanged
    '    Dim old As Double = 0
    '    If Not cbx_other_discount.Text = "No Discount (0%)" Then
    '        total_discount -= old
    '        Dim t_value As String = Separate_by_delim(cbx_other_discount.Text, " ")
    '        t_value = t_value.Remove(0, 1)
    '        t_value = t_value.Remove(t_value.Length - 2, 2)
    '        old = total_discount
    '        total_discount += Percent_Grabber(total, Convert.ToInt32(t_value))
    '        DisplayComputationSummary()
    '    End If
    'End Sub
End Class