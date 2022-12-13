<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reciept
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reciept))
        Me.header = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btn_checkout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.cbx_printer = New Guna.UI.WinForms.GunaComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaSeparator6 = New Guna.UI.WinForms.GunaSeparator()
        Me.fpanelGeneral = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.header.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.Controls.Add(Me.Guna2ControlBox1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.header.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.header.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.header.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.ShadowDecoration.Parent = Me.header
        Me.header.Size = New System.Drawing.Size(394, 28)
        Me.header.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.LightCoral
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(356, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.DarkOrange
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(38, 28)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btn_checkout
        '
        Me.btn_checkout.BorderRadius = 5
        Me.btn_checkout.CheckedState.Parent = Me.btn_checkout
        Me.btn_checkout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_checkout.CustomImages.Parent = Me.btn_checkout
        Me.btn_checkout.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_checkout.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_checkout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checkout.ForeColor = System.Drawing.Color.White
        Me.btn_checkout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btn_checkout.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_checkout.HoverState.Parent = Me.btn_checkout
        Me.btn_checkout.Image = CType(resources.GetObject("btn_checkout.Image"), System.Drawing.Image)
        Me.btn_checkout.ImageSize = New System.Drawing.Size(15, 15)
        Me.btn_checkout.Location = New System.Drawing.Point(296, 34)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.PressedColor = System.Drawing.Color.DarkOrange
        Me.btn_checkout.ShadowDecoration.Parent = Me.btn_checkout
        Me.btn_checkout.Size = New System.Drawing.Size(86, 26)
        Me.btn_checkout.TabIndex = 20
        Me.btn_checkout.Text = "Print"
        '
        'cbx_printer
        '
        Me.cbx_printer.BackColor = System.Drawing.Color.Transparent
        Me.cbx_printer.BaseColor = System.Drawing.Color.White
        Me.cbx_printer.BorderColor = System.Drawing.Color.Silver
        Me.cbx_printer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbx_printer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_printer.FocusedColor = System.Drawing.Color.Empty
        Me.cbx_printer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_printer.ForeColor = System.Drawing.Color.Black
        Me.cbx_printer.FormattingEnabled = True
        Me.cbx_printer.Location = New System.Drawing.Point(69, 34)
        Me.cbx_printer.Name = "cbx_printer"
        Me.cbx_printer.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbx_printer.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbx_printer.Size = New System.Drawing.Size(221, 26)
        Me.cbx_printer.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Printer:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaSeparator6
        '
        Me.GunaSeparator6.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator6.Location = New System.Drawing.Point(0, 64)
        Me.GunaSeparator6.Name = "GunaSeparator6"
        Me.GunaSeparator6.Size = New System.Drawing.Size(394, 10)
        Me.GunaSeparator6.TabIndex = 30
        Me.GunaSeparator6.Thickness = 2
        '
        'fpanelGeneral
        '
        Me.fpanelGeneral.AutoSize = True
        Me.fpanelGeneral.BackColor = System.Drawing.Color.Transparent
        Me.fpanelGeneral.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.fpanelGeneral.Location = New System.Drawing.Point(12, 80)
        Me.fpanelGeneral.Name = "fpanelGeneral"
        Me.fpanelGeneral.Size = New System.Drawing.Size(370, 364)
        Me.fpanelGeneral.TabIndex = 31
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.header
        '
        'PrintDocument1
        '
        '
        'Reciept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(394, 456)
        Me.Controls.Add(Me.fpanelGeneral)
        Me.Controls.Add(Me.cbx_printer)
        Me.Controls.Add(Me.GunaSeparator6)
        Me.Controls.Add(Me.btn_checkout)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reciept"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reciept"
        Me.header.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents cbx_printer As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btn_checkout As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaSeparator6 As Guna.UI.WinForms.GunaSeparator
    Public WithEvents fpanelGeneral As FlowLayoutPanel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
