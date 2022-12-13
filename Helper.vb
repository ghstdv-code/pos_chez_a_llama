Public Class Helper
    Shared Function CheckForZero(value As Double) As Boolean
        If value <= 0 Then
            Return 1
        End If
        Return False
    End Function
    Shared Function Separate_by_delim(ByVal str As String, ByVal delim As String) As String
        Dim temp() As String
        temp = str.Split(delim)
        Return temp(temp.Length - 1)
    End Function

    Shared Function Percent_Grabber(value As Double, percentage As SByte) As Double
        Return value * (percentage / 100)
    End Function

    Shared Function Check_Payment(payment As Double, total As Double) As Boolean
        If total <= payment Then
            Return 1
        End If
        Return 0
    End Function

    Shared Sub ResetLayout(MainPanel As Panel, MainText As Label, SubPanel As FlowLayoutPanel)
        item_frame.temp_record.Clear()
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(menu_apetizer.Instance)
        MainText.Text = "Apetizer"
        SubPanel.Controls.Clear()
    End Sub

End Class
