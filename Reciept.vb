Imports System.Text

Public Class Reciept
    Private Sub Reciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reciept.fpanelGeneral.Size = New Point(370, ((Reciept.fpanelGeneral.Controls.Count - 2) * 15) + 294)
        Size = New Point(Size.Width, 80 + fpanelGeneral.Height)
        GetInstalledPrinters()
    End Sub
    Sub GetInstalledPrinters()
        Dim inPrinters() As String
        For i As Integer = 0 To Printing.PrinterSettings.InstalledPrinters.Count - 1
            ReDim Preserve inPrinters(i)
            inPrinters(i) = Printing.PrinterSettings.InstalledPrinters.Item(i)
            cbx_printer.Items.Add(inPrinters(i))
            cbx_printer.SelectedIndex = 0
        Next
    End Sub
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Helper.ResetLayout(Main.container, Main.category, Main.order_container)
        Dispose()
        Main.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'fpanelGeneral.BackColor = Color.White
        Dim bmp As New Bitmap(fpanelGeneral.Width, fpanelGeneral.Height)
        fpanelGeneral.DrawToBitmap(bmp, New Rectangle(0, 0, fpanelGeneral.Width, fpanelGeneral.Height))
        e.Graphics.DrawImage(bmp, 0, 0)

        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click
        PrintDocument1.PrinterSettings.PrinterName = cbx_printer.Text
        PrintDocument1.Print()
    End Sub
End Class