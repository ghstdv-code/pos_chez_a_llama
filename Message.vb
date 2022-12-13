Public Class Message

    Dim role As SByte
    Public Enum AlertType
        Warning
        Warning2
        Info
        Info2
    End Enum

    'Public Property CM_Icon As Image
    '    Get
    '        Return _icon
    '    End Get
    '    Set(value As Image)
    '        _icon = value
    '        Message_Icon.Image = value
    '    End Set
    'End Property

    'Public Property CM_Message As String
    '    Get
    '        Return _message
    '    End Get
    '    Set(value As String)
    '        _message = value
    '        lbl_message.Text = value
    '    End Set
    'End Property

    Private Sub Message_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Public Overloads Sub Show(ByVal message As String, ByVal alerttype As AlertType)
        Select Case alerttype
            Case AlertType.Info
                Message_Icon.Image = icon_list.Images(0)
                btn_1.Visible = False
                btn_2.Text = "Exit"
                btn_2.Location = New Point((Me.Width / 2) - (btn_2.Width / 2), 119)
                lbl_message.Text = message
                role = 0

            Case AlertType.Warning2
                Message_Icon.Image = icon_list.Images(1)
                btn_1.Visible = False
                btn_2.Text = "Exit"
                btn_2.Location = New Point((Me.Width / 2) - (btn_2.Width / 2), 119)
                lbl_message.Text = message
                role = 0
        End Select
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        Select Case role
            Case 0
                Close()
        End Select
    End Sub
End Class