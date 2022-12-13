Public Class History

    Public PrvTable As New DataTable
    Public WriteOnly Property SetData As DataTable
        Set(value As DataTable)
            PrvTable = value
        End Set
    End Property
    Private Sub History_Load(sender As Object, e As EventArgs) Handles Me.Load
        'SqlCommand.PushCommand("SELECT * FROM tblRecords ORDER BY ID DESC", CommandType.READ)
        'If (Double.Parse(PrvTable.Rows.Count) Mod 15.0) <> 0 Then
        '    tbxentries.Text = Math.Round(Double.Parse(PrvTable.Rows.Count) / 15.0) + 1
        'End If
        ' SqlCommand.PushCommand("SELECT * FROM tblRecords ORDER BY ID DESC", CommandType.READ)

        ' MessageBox.Show(counter)
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Dispose()
    End Sub
End Class