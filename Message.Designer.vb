<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Message))
        Me.lbl_message = New System.Windows.Forms.Label()
        Me.Message_Icon = New System.Windows.Forms.PictureBox()
        Me.btn_1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.icon_list = New System.Windows.Forms.ImageList(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        CType(Me.Message_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_message
        '
        Me.lbl_message.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_message.Location = New System.Drawing.Point(78, 48)
        Me.lbl_message.Name = "lbl_message"
        Me.lbl_message.Size = New System.Drawing.Size(223, 50)
        Me.lbl_message.TabIndex = 0
        Me.lbl_message.Text = "@message"
        Me.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Message_Icon
        '
        Me.Message_Icon.Image = CType(resources.GetObject("Message_Icon.Image"), System.Drawing.Image)
        Me.Message_Icon.Location = New System.Drawing.Point(22, 48)
        Me.Message_Icon.Name = "Message_Icon"
        Me.Message_Icon.Size = New System.Drawing.Size(50, 50)
        Me.Message_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Message_Icon.TabIndex = 1
        Me.Message_Icon.TabStop = False
        '
        'btn_1
        '
        Me.btn_1.BorderRadius = 5
        Me.btn_1.CheckedState.Parent = Me.btn_1
        Me.btn_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_1.CustomImages.Parent = Me.btn_1
        Me.btn_1.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_1.ForeColor = System.Drawing.Color.White
        Me.btn_1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btn_1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_1.HoverState.Parent = Me.btn_1
        Me.btn_1.Location = New System.Drawing.Point(46, 119)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.PressedColor = System.Drawing.Color.DarkOrange
        Me.btn_1.ShadowDecoration.Parent = Me.btn_1
        Me.btn_1.Size = New System.Drawing.Size(90, 31)
        Me.btn_1.TabIndex = 2
        Me.btn_1.Text = "@btn1value"
        '
        'btn_2
        '
        Me.btn_2.BorderRadius = 5
        Me.btn_2.CheckedState.Parent = Me.btn_2
        Me.btn_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_2.CustomImages.Parent = Me.btn_2
        Me.btn_2.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_2.ForeColor = System.Drawing.Color.White
        Me.btn_2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btn_2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_2.HoverState.Parent = Me.btn_2
        Me.btn_2.Location = New System.Drawing.Point(179, 119)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.PressedColor = System.Drawing.Color.DarkOrange
        Me.btn_2.ShadowDecoration.Parent = Me.btn_2
        Me.btn_2.Size = New System.Drawing.Size(90, 31)
        Me.btn_2.TabIndex = 2
        Me.btn_2.Text = "@btn2value"
        '
        'icon_list
        '
        Me.icon_list.ImageStream = CType(resources.GetObject("icon_list.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.icon_list.TransparentColor = System.Drawing.Color.Transparent
        Me.icon_list.Images.SetKeyName(0, "info_96px.png")
        Me.icon_list.Images.SetKeyName(1, "box_important_96px.png")
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(327, 28)
        Me.Guna2CustomGradientPanel1.TabIndex = 3
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE
        Me.Guna2AnimateWindow1.Interval = 1000
        '
        'Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(327, 162)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.Message_Icon)
        Me.Controls.Add(Me.lbl_message)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Message"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Message"
        CType(Me.Message_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_message As Label
    Friend WithEvents Message_Icon As PictureBox
    Friend WithEvents btn_1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents icon_list As ImageList
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
