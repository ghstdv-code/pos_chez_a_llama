<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btn_Exit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.container = New System.Windows.Forms.Panel()
        Me.ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.category = New System.Windows.Forms.Label()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.new_or = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.order_container = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_checkout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientTileButton1 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btn_history = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btn_dessert = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btn_pizza = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btn_beverage = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btn_apetizer = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btn_meal = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.GunaGradient2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Exit
        '
        Me.btn_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exit.FillColor = System.Drawing.Color.White
        Me.btn_Exit.HoverState.Parent = Me.btn_Exit
        Me.btn_Exit.IconColor = System.Drawing.Color.Gray
        Me.btn_Exit.Location = New System.Drawing.Point(968, 0)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.ShadowDecoration.Parent = Me.btn_Exit
        Me.btn_Exit.Size = New System.Drawing.Size(45, 29)
        Me.btn_Exit.TabIndex = 0
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(923, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel1.Controls.Add(Me.btn_dessert)
        Me.Guna2Panel1.Controls.Add(Me.btn_pizza)
        Me.Guna2Panel1.Controls.Add(Me.btn_beverage)
        Me.Guna2Panel1.Controls.Add(Me.btn_apetizer)
        Me.Guna2Panel1.Controls.Add(Me.btn_meal)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(100, 620)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Separator1.FillThickness = 5
        Me.Guna2Separator1.Location = New System.Drawing.Point(113, 114)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(887, 10)
        Me.Guna2Separator1.TabIndex = 3
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(107, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Chez Llama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(109, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Atimonan, Quezon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(113, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Category:"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me.container
        '
        'container
        '
        Me.container.BackColor = System.Drawing.SystemColors.ControlLight
        Me.container.Location = New System.Drawing.Point(116, 160)
        Me.container.Name = "container"
        Me.container.Size = New System.Drawing.Size(546, 438)
        Me.container.TabIndex = 13
        '
        'category
        '
        Me.category.AutoSize = True
        Me.category.BackColor = System.Drawing.Color.Transparent
        Me.category.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category.ForeColor = System.Drawing.Color.Gray
        Me.category.Location = New System.Drawing.Point(184, 127)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(34, 13)
        Me.category.TabIndex = 7
        Me.category.Text = "@cat"
        '
        'scroll
        '
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(652, 160)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.Silver
        Me.scroll.Size = New System.Drawing.Size(10, 419)
        Me.scroll.TabIndex = 14
        Me.scroll.ThumbColor = System.Drawing.Color.DimGray
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.new_or)
        Me.GunaGradient2Panel1.Controls.Add(Me.lbl)
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(670, 160)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Radius = 10
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(331, 100)
        Me.GunaGradient2Panel1.TabIndex = 0
        '
        'new_or
        '
        Me.new_or.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_or.ForeColor = System.Drawing.Color.White
        Me.new_or.Location = New System.Drawing.Point(153, 17)
        Me.new_or.Name = "new_or"
        Me.new_or.Size = New System.Drawing.Size(160, 18)
        Me.new_or.TabIndex = 0
        Me.new_or.Text = "5840356"
        Me.new_or.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.White
        Me.lbl.Location = New System.Drawing.Point(16, 17)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(131, 18)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Order Number:"
        '
        'order_container
        '
        Me.order_container.AutoScroll = True
        Me.order_container.BackColor = System.Drawing.SystemColors.ControlLight
        Me.order_container.Location = New System.Drawing.Point(670, 211)
        Me.order_container.Name = "order_container"
        Me.order_container.Size = New System.Drawing.Size(331, 342)
        Me.order_container.TabIndex = 0
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.BorderRadius = 5
        Me.Guna2GradientButton2.CheckedState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton2.CustomImages.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Image = CType(resources.GetObject("Guna2GradientButton2.Image"), System.Drawing.Image)
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(841, 559)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.PressedColor = System.Drawing.Color.DarkOrange
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(162, 36)
        Me.Guna2GradientButton2.TabIndex = 17
        Me.Guna2GradientButton2.Text = "Clear"
        '
        'btn_checkout
        '
        Me.btn_checkout.BorderRadius = 5
        Me.btn_checkout.CheckedState.Parent = Me.btn_checkout
        Me.btn_checkout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_checkout.CustomImages.Parent = Me.btn_checkout
        Me.btn_checkout.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_checkout.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_checkout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checkout.ForeColor = System.Drawing.Color.White
        Me.btn_checkout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btn_checkout.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_checkout.HoverState.Parent = Me.btn_checkout
        Me.btn_checkout.Image = CType(resources.GetObject("btn_checkout.Image"), System.Drawing.Image)
        Me.btn_checkout.Location = New System.Drawing.Point(670, 559)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.PressedColor = System.Drawing.Color.DarkOrange
        Me.btn_checkout.ShadowDecoration.Parent = Me.btn_checkout
        Me.btn_checkout.Size = New System.Drawing.Size(162, 36)
        Me.btn_checkout.TabIndex = 17
        Me.btn_checkout.Text = "Check Out"
        '
        'Guna2GradientTileButton1
        '
        Me.Guna2GradientTileButton1.BorderRadius = 5
        Me.Guna2GradientTileButton1.CheckedState.Parent = Me.Guna2GradientTileButton1
        Me.Guna2GradientTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientTileButton1.CustomImages.Parent = Me.Guna2GradientTileButton1
        Me.Guna2GradientTileButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientTileButton1.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientTileButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientTileButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientTileButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2GradientTileButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Guna2GradientTileButton1.HoverState.Image = CType(resources.GetObject("Guna2GradientTileButton1.HoverState.Image"), System.Drawing.Image)
        Me.Guna2GradientTileButton1.HoverState.Parent = Me.Guna2GradientTileButton1
        Me.Guna2GradientTileButton1.Image = CType(resources.GetObject("Guna2GradientTileButton1.Image"), System.Drawing.Image)
        Me.Guna2GradientTileButton1.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2GradientTileButton1.Location = New System.Drawing.Point(963, 62)
        Me.Guna2GradientTileButton1.Name = "Guna2GradientTileButton1"
        Me.Guna2GradientTileButton1.PressedColor = System.Drawing.Color.DarkOrange
        Me.Guna2GradientTileButton1.ShadowDecoration.Parent = Me.Guna2GradientTileButton1
        Me.Guna2GradientTileButton1.Size = New System.Drawing.Size(40, 40)
        Me.Guna2GradientTileButton1.TabIndex = 11
        Me.ttip.SetToolTip(Me.Guna2GradientTileButton1, "About")
        '
        'btn_history
        '
        Me.btn_history.BorderRadius = 5
        Me.btn_history.CheckedState.Parent = Me.btn_history
        Me.btn_history.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_history.CustomImages.Parent = Me.btn_history
        Me.btn_history.FillColor = System.Drawing.Color.Transparent
        Me.btn_history.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_history.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_history.ForeColor = System.Drawing.Color.White
        Me.btn_history.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_history.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_history.HoverState.Image = CType(resources.GetObject("btn_history.HoverState.Image"), System.Drawing.Image)
        Me.btn_history.HoverState.Parent = Me.btn_history
        Me.btn_history.Image = CType(resources.GetObject("btn_history.Image"), System.Drawing.Image)
        Me.btn_history.ImageSize = New System.Drawing.Size(25, 25)
        Me.btn_history.Location = New System.Drawing.Point(917, 62)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.PressedColor = System.Drawing.Color.DarkOrange
        Me.btn_history.ShadowDecoration.Parent = Me.btn_history
        Me.btn_history.Size = New System.Drawing.Size(40, 40)
        Me.btn_history.TabIndex = 11
        Me.ttip.SetToolTip(Me.btn_history, "History")
        '
        'btn_dessert
        '
        Me.btn_dessert.BorderRadius = 5
        Me.btn_dessert.CheckedState.Parent = Me.btn_dessert
        Me.btn_dessert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dessert.CustomImages.Parent = Me.btn_dessert
        Me.btn_dessert.FillColor = System.Drawing.Color.Transparent
        Me.btn_dessert.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_dessert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_dessert.ForeColor = System.Drawing.Color.Gray
        Me.btn_dessert.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_dessert.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_dessert.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_dessert.HoverState.Image = CType(resources.GetObject("btn_dessert.HoverState.Image"), System.Drawing.Image)
        Me.btn_dessert.HoverState.Parent = Me.btn_dessert
        Me.btn_dessert.Image = CType(resources.GetObject("btn_dessert.Image"), System.Drawing.Image)
        Me.btn_dessert.ImageOffset = New System.Drawing.Point(0, 7)
        Me.btn_dessert.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_dessert.Location = New System.Drawing.Point(12, 424)
        Me.btn_dessert.Name = "btn_dessert"
        Me.btn_dessert.PressedColor = System.Drawing.Color.DarkOrange
        Me.btn_dessert.ShadowDecoration.Parent = Me.btn_dessert
        Me.btn_dessert.Size = New System.Drawing.Size(60, 60)
        Me.btn_dessert.TabIndex = 4
        Me.btn_dessert.Text = "Dessert"
        '
        'btn_pizza
        '
        Me.btn_pizza.BorderRadius = 5
        Me.btn_pizza.CheckedState.Parent = Me.btn_pizza
        Me.btn_pizza.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pizza.CustomImages.Parent = Me.btn_pizza
        Me.btn_pizza.FillColor = System.Drawing.Color.Transparent
        Me.btn_pizza.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_pizza.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_pizza.ForeColor = System.Drawing.Color.Gray
        Me.btn_pizza.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_pizza.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_pizza.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_pizza.HoverState.Image = CType(resources.GetObject("btn_pizza.HoverState.Image"), System.Drawing.Image)
        Me.btn_pizza.HoverState.Parent = Me.btn_pizza
        Me.btn_pizza.Image = CType(resources.GetObject("btn_pizza.Image"), System.Drawing.Image)
        Me.btn_pizza.ImageOffset = New System.Drawing.Point(0, 7)
        Me.btn_pizza.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_pizza.Location = New System.Drawing.Point(12, 358)
        Me.btn_pizza.Name = "btn_pizza"
        Me.btn_pizza.PressedColor = System.Drawing.Color.DarkOrange
        Me.btn_pizza.ShadowDecoration.Parent = Me.btn_pizza
        Me.btn_pizza.Size = New System.Drawing.Size(60, 60)
        Me.btn_pizza.TabIndex = 4
        Me.btn_pizza.Text = "Pizza"
        '
        'btn_beverage
        '
        Me.btn_beverage.BorderRadius = 5
        Me.btn_beverage.CheckedState.Parent = Me.btn_beverage
        Me.btn_beverage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_beverage.CustomImages.Parent = Me.btn_beverage
        Me.btn_beverage.FillColor = System.Drawing.Color.Transparent
        Me.btn_beverage.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_beverage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_beverage.ForeColor = System.Drawing.Color.Gray
        Me.btn_beverage.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_beverage.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_beverage.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_beverage.HoverState.Image = CType(resources.GetObject("btn_beverage.HoverState.Image"), System.Drawing.Image)
        Me.btn_beverage.HoverState.Parent = Me.btn_beverage
        Me.btn_beverage.Image = CType(resources.GetObject("btn_beverage.Image"), System.Drawing.Image)
        Me.btn_beverage.ImageOffset = New System.Drawing.Point(0, 7)
        Me.btn_beverage.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_beverage.Location = New System.Drawing.Point(12, 292)
        Me.btn_beverage.Name = "btn_beverage"
        Me.btn_beverage.PressedColor = System.Drawing.Color.DarkOrange
        Me.btn_beverage.ShadowDecoration.Parent = Me.btn_beverage
        Me.btn_beverage.Size = New System.Drawing.Size(60, 60)
        Me.btn_beverage.TabIndex = 4
        Me.btn_beverage.Text = "Beverage"
        '
        'btn_apetizer
        '
        Me.btn_apetizer.BackColor = System.Drawing.Color.Transparent
        Me.btn_apetizer.BorderRadius = 5
        Me.btn_apetizer.CheckedState.Parent = Me.btn_apetizer
        Me.btn_apetizer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_apetizer.CustomImages.Parent = Me.btn_apetizer
        Me.btn_apetizer.FillColor = System.Drawing.Color.Transparent
        Me.btn_apetizer.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_apetizer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_apetizer.ForeColor = System.Drawing.Color.Gray
        Me.btn_apetizer.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_apetizer.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_apetizer.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_apetizer.HoverState.Image = CType(resources.GetObject("btn_apetizer.HoverState.Image"), System.Drawing.Image)
        Me.btn_apetizer.HoverState.Parent = Me.btn_apetizer
        Me.btn_apetizer.Image = CType(resources.GetObject("btn_apetizer.Image"), System.Drawing.Image)
        Me.btn_apetizer.ImageOffset = New System.Drawing.Point(0, 7)
        Me.btn_apetizer.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_apetizer.Location = New System.Drawing.Point(12, 160)
        Me.btn_apetizer.Name = "btn_apetizer"
        Me.btn_apetizer.PressedColor = System.Drawing.Color.DarkOrange
        Me.btn_apetizer.ShadowDecoration.Parent = Me.btn_apetizer
        Me.btn_apetizer.Size = New System.Drawing.Size(60, 60)
        Me.btn_apetizer.TabIndex = 4
        Me.btn_apetizer.Text = "Apetizer"
        '
        'btn_meal
        '
        Me.btn_meal.BackColor = System.Drawing.Color.Transparent
        Me.btn_meal.BorderRadius = 5
        Me.btn_meal.CheckedState.Parent = Me.btn_meal
        Me.btn_meal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_meal.CustomImages.Parent = Me.btn_meal
        Me.btn_meal.FillColor = System.Drawing.Color.Transparent
        Me.btn_meal.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_meal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_meal.ForeColor = System.Drawing.Color.Gray
        Me.btn_meal.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_meal.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_meal.HoverState.ForeColor = System.Drawing.Color.White
        Me.btn_meal.HoverState.Image = CType(resources.GetObject("btn_meal.HoverState.Image"), System.Drawing.Image)
        Me.btn_meal.HoverState.Parent = Me.btn_meal
        Me.btn_meal.Image = CType(resources.GetObject("btn_meal.Image"), System.Drawing.Image)
        Me.btn_meal.ImageOffset = New System.Drawing.Point(0, 7)
        Me.btn_meal.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_meal.Location = New System.Drawing.Point(12, 226)
        Me.btn_meal.Name = "btn_meal"
        Me.btn_meal.PressedColor = System.Drawing.Color.DarkOrange
        Me.btn_meal.ShadowDecoration.Parent = Me.btn_meal
        Me.btn_meal.Size = New System.Drawing.Size(60, 60)
        Me.btn_meal.TabIndex = 4
        Me.btn_meal.Text = "Meal"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(100, 140)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1013, 620)
        Me.Controls.Add(Me.order_container)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.Controls.Add(Me.Guna2GradientButton2)
        Me.Controls.Add(Me.btn_checkout)
        Me.Controls.Add(Me.container)
        Me.Controls.Add(Me.Guna2GradientTileButton1)
        Me.Controls.Add(Me.btn_history)
        Me.Controls.Add(Me.category)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.scroll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2Panel1.ResumeLayout(False)
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaGradient2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Exit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_dessert As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btn_pizza As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btn_beverage As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btn_meal As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btn_history As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents ttip As ToolTip
    Shadows WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents btn_apetizer As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btn_checkout As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents order_container As FlowLayoutPanel
    Friend WithEvents new_or As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Public WithEvents category As Label
    Friend WithEvents container As Panel
    Friend WithEvents Guna2GradientTileButton1 As Guna.UI2.WinForms.Guna2GradientTileButton
End Class
