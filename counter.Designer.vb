<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class counter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(counter))
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblItemPrice = New System.Windows.Forms.Label()
        Me.quantity = New Guna.UI.WinForms.GunaNumeric()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.SuspendLayout()
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(48, 15)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(89, 14)
        Me.lblItemName.TabIndex = 13
        Me.lblItemName.Text = "@item_name"
        '
        'lblItemPrice
        '
        Me.lblItemPrice.AutoSize = True
        Me.lblItemPrice.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.Location = New System.Drawing.Point(48, 42)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(77, 13)
        Me.lblItemPrice.TabIndex = 13
        Me.lblItemPrice.Text = "@item_price"
        '
        'quantity
        '
        Me.quantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.quantity.BaseColor = System.Drawing.Color.White
        Me.quantity.BorderColor = System.Drawing.Color.Silver
        Me.quantity.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.quantity.ButtonForeColor = System.Drawing.Color.White
        Me.quantity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.quantity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.quantity.ForeColor = System.Drawing.Color.Black
        Me.quantity.Location = New System.Drawing.Point(228, 17)
        Me.quantity.Maximum = CType(9999999, Long)
        Me.quantity.Minimum = CType(1, Long)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(60, 30)
        Me.quantity.TabIndex = 14
        Me.quantity.Text = "GunaNumeric1"
        Me.quantity.Value = CType(1, Long)
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ImageButton1.HoverState.Image = CType(resources.GetObject("Guna2ImageButton1.HoverState.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(12, 17)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.TabIndex = 15
        Me.Guna2ImageButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.ToolTip1.SetToolTip(Me.Guna2ImageButton1, "Remove")
        '
        'counter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.lblItemPrice)
        Me.Controls.Add(Me.lblItemName)
        Me.Name = "counter"
        Me.Size = New System.Drawing.Size(300, 70)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblItemPrice As Label
    Friend WithEvents quantity As Guna.UI.WinForms.GunaNumeric
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
End Class
