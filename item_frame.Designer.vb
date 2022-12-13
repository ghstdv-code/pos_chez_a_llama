<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class item_frame
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(item_frame))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.image = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.item_price = New System.Windows.Forms.Label()
        Me.item_name = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'image
        '
        Me.image.Dock = System.Windows.Forms.DockStyle.Top
        Me.image.Image = CType(resources.GetObject("image.Image"), System.Drawing.Image)
        Me.image.Location = New System.Drawing.Point(0, 0)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(165, 129)
        Me.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image.TabIndex = 0
        Me.image.TabStop = False
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GradientPanel1.Controls.Add(Me.item_price)
        Me.Guna2GradientPanel1.Controls.Add(Me.item_name)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 129)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(165, 93)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.DarkCyan
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.Location = New System.Drawing.Point(16, 47)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.MediumTurquoise
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(132, 35)
        Me.Guna2Button1.TabIndex = 2
        Me.Guna2Button1.Text = "Add to Cart"
        '
        'item_price
        '
        Me.item_price.BackColor = System.Drawing.Color.Transparent
        Me.item_price.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_price.ForeColor = System.Drawing.Color.White
        Me.item_price.Location = New System.Drawing.Point(0, 22)
        Me.item_price.Name = "item_price"
        Me.item_price.Size = New System.Drawing.Size(165, 19)
        Me.item_price.TabIndex = 0
        Me.item_price.Text = "@price"
        Me.item_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'item_name
        '
        Me.item_name.BackColor = System.Drawing.Color.Transparent
        Me.item_name.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_name.ForeColor = System.Drawing.Color.White
        Me.item_name.Location = New System.Drawing.Point(0, 3)
        Me.item_name.Name = "item_name"
        Me.item_name.Size = New System.Drawing.Size(165, 19)
        Me.item_name.TabIndex = 0
        Me.item_name.Text = "@name"
        Me.item_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'item_frame
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.image)
        Me.Name = "item_frame"
        Me.Size = New System.Drawing.Size(165, 222)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents image As PictureBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents item_price As Label
    Friend WithEvents item_name As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
