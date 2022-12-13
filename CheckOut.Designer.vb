<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckOut))
        Me.header = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Order_Number = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_item = New System.Windows.Forms.DataGridView()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.switch_2 = New Guna.UI.WinForms.GunaWinSwitch()
        Me.switch_1 = New Guna.UI.WinForms.GunaWinSwitch()
        Me.switch_0 = New Guna.UI.WinForms.GunaWinSwitch()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me._payment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sub_total = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.discount_total = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grand_total = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.btn_checkout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.header.SuspendLayout()
        CType(Me.data_item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        Me.header.TabIndex = 0
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(354, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.DarkOrange
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(38, 28)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(12, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Order Number:"
        '
        'Order_Number
        '
        Me.Order_Number.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order_Number.ForeColor = System.Drawing.Color.Gray
        Me.Order_Number.Location = New System.Drawing.Point(222, 42)
        Me.Order_Number.Name = "Order_Number"
        Me.Order_Number.Size = New System.Drawing.Size(160, 18)
        Me.Order_Number.TabIndex = 2
        Me.Order_Number.Text = "5840356"
        Me.Order_Number.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(256, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Price"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(90, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Item Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantity"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 95
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 150
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 98
        '
        'data_item
        '
        Me.data_item.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.data_item.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.data_item.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.data_item.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data_item.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.data_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data_item.ColumnHeadersVisible = False
        Me.data_item.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_item.DefaultCellStyle = DataGridViewCellStyle2
        Me.data_item.GridColor = System.Drawing.SystemColors.ControlLight
        Me.data_item.Location = New System.Drawing.Point(15, 101)
        Me.data_item.Name = "data_item"
        Me.data_item.ReadOnly = True
        Me.data_item.RowHeadersVisible = False
        Me.data_item.RowTemplate.ReadOnly = True
        Me.data_item.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_item.ShowEditingIcon = False
        Me.data_item.Size = New System.Drawing.Size(364, 169)
        Me.data_item.TabIndex = 3
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(15, 72)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel2
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(364, 28)
        Me.Guna2CustomGradientPanel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.switch_2)
        Me.GroupBox1.Controls.Add(Me.switch_1)
        Me.GroupBox1.Controls.Add(Me.switch_0)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(15, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 98)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'switch_2
        '
        Me.switch_2.BaseColor = System.Drawing.SystemColors.Control
        Me.switch_2.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.switch_2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.switch_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switch_2.FillColor = System.Drawing.Color.White
        Me.switch_2.Location = New System.Drawing.Point(309, 66)
        Me.switch_2.Name = "switch_2"
        Me.switch_2.Size = New System.Drawing.Size(40, 22)
        Me.switch_2.TabIndex = 1
        '
        'switch_1
        '
        Me.switch_1.BaseColor = System.Drawing.SystemColors.Control
        Me.switch_1.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.switch_1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.switch_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switch_1.FillColor = System.Drawing.Color.White
        Me.switch_1.Location = New System.Drawing.Point(309, 42)
        Me.switch_1.Name = "switch_1"
        Me.switch_1.Size = New System.Drawing.Size(40, 22)
        Me.switch_1.TabIndex = 1
        '
        'switch_0
        '
        Me.switch_0.BaseColor = System.Drawing.SystemColors.Control
        Me.switch_0.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.switch_0.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.switch_0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switch_0.FillColor = System.Drawing.Color.White
        Me.switch_0.Location = New System.Drawing.Point(309, 18)
        Me.switch_0.Name = "switch_0"
        Me.switch_0.Size = New System.Drawing.Size(40, 22)
        Me.switch_0.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(12, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(291, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Front-Liner Discount(10%)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(12, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(291, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Special Event's(15%)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(12, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(291, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Senior Discount(20%)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(12, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Discounts"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(27, 511)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Enter Payment:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_payment
        '
        Me._payment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._payment.DefaultText = ""
        Me._payment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me._payment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me._payment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me._payment.DisabledState.Parent = Me._payment
        Me._payment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me._payment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._payment.FocusedState.Parent = Me._payment
        Me._payment.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._payment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._payment.HoverState.Parent = Me._payment
        Me._payment.Location = New System.Drawing.Point(289, 509)
        Me._payment.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me._payment.Name = "_payment"
        Me._payment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me._payment.PlaceholderText = "0.00"
        Me._payment.SelectedText = ""
        Me._payment.ShadowDecoration.Parent = Me._payment
        Me._payment.Size = New System.Drawing.Size(90, 28)
        Me._payment.TabIndex = 2
        Me._payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(251, 515)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 14)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Php"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sub_total
        '
        Me.sub_total.BackColor = System.Drawing.Color.White
        Me.sub_total.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub_total.ForeColor = System.Drawing.Color.Gray
        Me.sub_total.Location = New System.Drawing.Point(259, 18)
        Me.sub_total.Name = "sub_total"
        Me.sub_total.Size = New System.Drawing.Size(90, 22)
        Me.sub_total.TabIndex = 0
        Me.sub_total.Text = "@subtotal"
        Me.sub_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.discount_total)
        Me.GroupBox3.Controls.Add(Me.sub_total)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(15, 375)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(364, 85)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'discount_total
        '
        Me.discount_total.BackColor = System.Drawing.Color.White
        Me.discount_total.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount_total.ForeColor = System.Drawing.Color.Gray
        Me.discount_total.Location = New System.Drawing.Point(259, 47)
        Me.discount_total.Name = "discount_total"
        Me.discount_total.Size = New System.Drawing.Size(90, 22)
        Me.discount_total.TabIndex = 0
        Me.discount_total.Text = "@distotal"
        Me.discount_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gray
        Me.Label12.Location = New System.Drawing.Point(13, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(213, 22)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Discount Total:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(12, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(213, 22)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Sub-Total:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.grand_total)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(15, 460)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(364, 38)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(12, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(158, 22)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Total:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grand_total
        '
        Me.grand_total.BackColor = System.Drawing.Color.White
        Me.grand_total.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grand_total.ForeColor = System.Drawing.Color.Gray
        Me.grand_total.Location = New System.Drawing.Point(259, 10)
        Me.grand_total.Name = "grand_total"
        Me.grand_total.Size = New System.Drawing.Size(90, 22)
        Me.grand_total.TabIndex = 0
        Me.grand_total.Text = "@grandtotal"
        Me.grand_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.header
        '
        'btn_checkout
        '
        Me.btn_checkout.BorderRadius = 5
        Me.btn_checkout.CheckedState.Parent = Me.btn_checkout
        Me.btn_checkout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_checkout.CustomImages.Parent = Me.btn_checkout
        Me.btn_checkout.FillColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_checkout.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btn_checkout.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.btn_checkout.ForeColor = System.Drawing.Color.White
        Me.btn_checkout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btn_checkout.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_checkout.HoverState.Parent = Me.btn_checkout
        Me.btn_checkout.Image = CType(resources.GetObject("btn_checkout.Image"), System.Drawing.Image)
        Me.btn_checkout.Location = New System.Drawing.Point(15, 557)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.PressedColor = System.Drawing.Color.DarkOrange
        Me.btn_checkout.ShadowDecoration.Parent = Me.btn_checkout
        Me.btn_checkout.Size = New System.Drawing.Size(367, 36)
        Me.btn_checkout.TabIndex = 18
        Me.btn_checkout.Text = "Pay Transaction"
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(394, 605)
        Me.Controls.Add(Me.btn_checkout)
        Me.Controls.Add(Me._payment)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Controls.Add(Me.data_item)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Order_Number)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CheckOut"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckOut"
        Me.header.ResumeLayout(False)
        CType(Me.data_item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Label5 As Label
    Friend WithEvents Order_Number As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents data_item As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents _payment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents switch_0 As Guna.UI.WinForms.GunaWinSwitch
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents grand_total As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents discount_total As Label
    Friend WithEvents sub_total As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btn_checkout As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents switch_2 As Guna.UI.WinForms.GunaWinSwitch
    Friend WithEvents switch_1 As Guna.UI.WinForms.GunaWinSwitch
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
