Imports Guna.UI2.WinForms
Imports POS.Helper

Public Class Main
    Shared Dtable As DataTable
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dispose()
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlCommand.PushCommand("SELECT * FROM tblRecords WHERE ID = (SELECT max(ID) FROM tblRecords)", SqlCommand.CommandType.GETID)
        new_or.Text = SqlCommand.ID + 1
        Dim scrollhelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
        scrollhelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(container, scroll, True)
        container.Controls.Add(menu_apetizer.Instance)
        category.Text = "Apetizer"
    End Sub
#Region "UserControl"
    Private Sub btn_meal_Click(sender As Object, e As EventArgs) Handles btn_meal.Click
        Switch(menu_meal.Instance)
        category.Text = "Meal"
    End Sub

    Sub Switch(ByVal panel As UserControl)
        container.Controls.Clear()
        'panel.TopLevel = False
        'panel.Location = New Point((container.Size.Width - panel.Width) / 2, (container.Size.Height - panel.Height) / 2)
        'panel.Anchor = AnchorStyles.None
        container.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Guna2GradientTileButton2_Click(sender As Object, e As EventArgs) Handles btn_beverage.Click
        Switch(menu_drinks.Instance)
        category.Text = "Beverage"
    End Sub

    Private Sub Guna2GradientTileButton3_Click(sender As Object, e As EventArgs) Handles btn_pizza.Click
        Switch(menu_pizza.Instance)
        category.Text = "Pizza"
    End Sub

    Private Sub Guna2GradientTileButton4_Click(sender As Object, e As EventArgs) Handles btn_dessert.Click
        Switch(menu_dessert.Instance)
        category.Text = "Dessert"
    End Sub

    Private Sub btn_apetizer_Click(sender As Object, e As EventArgs) Handles btn_apetizer.Click
        Switch(menu_apetizer.Instance)
        category.Text = "Apetizer"
    End Sub
#End Region
    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click
        If order_container.Controls.Count <= 0 Then
            Message.Show("Please Add Your Order Before Checkout", Message.AlertType.Info)
            Message.ShowDialog()
        Else
            Dim primary_data As New DataTable
            primary_data.Columns.Add("qt", GetType(Byte))
            primary_data.Columns.Add("name", GetType(String))
            primary_data.Columns.Add("price", GetType(Double))

            Dim total_main As Double = 0
            For Each samp As counter In Me.order_container.Controls
                total_main += CDbl(Separate_by_delim(samp.lblItemPrice.Text, " "))
                Dim row As DataRow = primary_data.NewRow
                row("qt") = samp.quantity.Value
                row("name") = samp.lblItemName.Text
                row("price") = CDbl(Separate_by_delim(samp.lblItemPrice.Text, " "))
                primary_data.Rows.Add(row)
            Next


            Dim Send_To_CheckOut As CheckOut = New CheckOut With {
            .Get_Data = primary_data,
            .Total_All = total_main,
            .Get_Or = Int32.Parse(new_or.Text)}
            Hide()
            Send_To_CheckOut.ShowDialog()
        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        item_frame.temp_record.Clear()
        order_container.Controls.Clear()
    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        SqlCommand.PushCommand("SELECT * FROM tblRecords ORDER BY ID DESC", SqlCommand.CommandType.READ)
        History.lblEntry.Text = Dtable.Rows.Count & " Record(s) Found!"
        For i As Integer = 0 To Dtable.Rows.Count - 1 Step 1
            Dim out, out2 As String
            If Double.Parse(Dtable(i)(5)) <= 0 Then
                out = "0.00"
            Else
                out = Double.Parse(Dtable(i)(5)).ToString("#.00")
            End If
            If Double.Parse(Dtable(i)(7)) <= 0 Then
                out2 = "0.00"
            Else
                out2 = Double.Parse(Dtable(i)(7)).ToString("#.00")
            End If

            History.dgvHistoryData.Rows.Add(Dtable(i)(1), DateTime.Parse(Dtable(i)(2)).ToString("yyyy-MM-dd HH:mm:ss"), Dtable(i)(3), Double.Parse(Dtable(i)(4)).ToString("#.00"), out, Double.Parse(Dtable(i)(6)).ToString("#.00"), out2)
        Next
        History.ShowDialog()
    End Sub

    Public Shared WriteOnly Property GetTable As DataTable
        Set(value As DataTable)
            Dtable = value
        End Set
    End Property

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
        About.ShowDialog()
    End Sub
End Class
