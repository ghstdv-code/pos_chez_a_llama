<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_drinks
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_drinks))
        Me.Item_frame6 = New POS.item_frame()
        Me.Item_frame3 = New POS.item_frame()
        Me.Item_frame5 = New POS.item_frame()
        Me.Item_frame2 = New POS.item_frame()
        Me.Item_frame7 = New POS.item_frame()
        Me.Item_frame4 = New POS.item_frame()
        Me.Item_frame1 = New POS.item_frame()
        Me.SuspendLayout()
        '
        'Item_frame6
        '
        Me.Item_frame6.BackColor = System.Drawing.Color.White
        Me.Item_frame6.ItemIcon = CType(resources.GetObject("Item_frame6.ItemIcon"), System.Drawing.Image)
        Me.Item_frame6.ItemName = "San Miguel Beer"
        Me.Item_frame6.ItemPrice = "68.00"
        Me.Item_frame6.Location = New System.Drawing.Point(354, 240)
        Me.Item_frame6.Name = "Item_frame6"
        Me.Item_frame6.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame6.TabIndex = 0
        '
        'Item_frame3
        '
        Me.Item_frame3.BackColor = System.Drawing.Color.White
        Me.Item_frame3.ItemIcon = CType(resources.GetObject("Item_frame3.ItemIcon"), System.Drawing.Image)
        Me.Item_frame3.ItemName = "Pepsi  In-Can"
        Me.Item_frame3.ItemPrice = "30.00"
        Me.Item_frame3.Location = New System.Drawing.Point(354, 12)
        Me.Item_frame3.Name = "Item_frame3"
        Me.Item_frame3.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame3.TabIndex = 0
        '
        'Item_frame5
        '
        Me.Item_frame5.BackColor = System.Drawing.Color.White
        Me.Item_frame5.ItemIcon = CType(resources.GetObject("Item_frame5.ItemIcon"), System.Drawing.Image)
        Me.Item_frame5.ItemName = "Red Horse"
        Me.Item_frame5.ItemPrice = "48.00"
        Me.Item_frame5.Location = New System.Drawing.Point(183, 240)
        Me.Item_frame5.Name = "Item_frame5"
        Me.Item_frame5.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame5.TabIndex = 0
        '
        'Item_frame2
        '
        Me.Item_frame2.BackColor = System.Drawing.Color.White
        Me.Item_frame2.ItemIcon = CType(resources.GetObject("Item_frame2.ItemIcon"), System.Drawing.Image)
        Me.Item_frame2.ItemName = "Sprite"
        Me.Item_frame2.ItemPrice = "23.00"
        Me.Item_frame2.Location = New System.Drawing.Point(183, 12)
        Me.Item_frame2.Name = "Item_frame2"
        Me.Item_frame2.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame2.TabIndex = 0
        '
        'Item_frame7
        '
        Me.Item_frame7.BackColor = System.Drawing.Color.White
        Me.Item_frame7.ItemIcon = CType(resources.GetObject("Item_frame7.ItemIcon"), System.Drawing.Image)
        Me.Item_frame7.ItemName = "Water"
        Me.Item_frame7.ItemPrice = "18.00"
        Me.Item_frame7.Location = New System.Drawing.Point(12, 468)
        Me.Item_frame7.Name = "Item_frame7"
        Me.Item_frame7.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame7.TabIndex = 0
        '
        'Item_frame4
        '
        Me.Item_frame4.BackColor = System.Drawing.Color.White
        Me.Item_frame4.ItemIcon = CType(resources.GetObject("Item_frame4.ItemIcon"), System.Drawing.Image)
        Me.Item_frame4.ItemName = "Coffee"
        Me.Item_frame4.ItemPrice = "23.00"
        Me.Item_frame4.Location = New System.Drawing.Point(12, 240)
        Me.Item_frame4.Name = "Item_frame4"
        Me.Item_frame4.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame4.TabIndex = 0
        '
        'Item_frame1
        '
        Me.Item_frame1.BackColor = System.Drawing.Color.White
        Me.Item_frame1.ItemIcon = CType(resources.GetObject("Item_frame1.ItemIcon"), System.Drawing.Image)
        Me.Item_frame1.ItemName = "Coca Cola"
        Me.Item_frame1.ItemPrice = "23.00"
        Me.Item_frame1.Location = New System.Drawing.Point(12, 12)
        Me.Item_frame1.Name = "Item_frame1"
        Me.Item_frame1.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame1.TabIndex = 0
        '
        'menu_drinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Item_frame6)
        Me.Controls.Add(Me.Item_frame3)
        Me.Controls.Add(Me.Item_frame5)
        Me.Controls.Add(Me.Item_frame2)
        Me.Controls.Add(Me.Item_frame7)
        Me.Controls.Add(Me.Item_frame4)
        Me.Controls.Add(Me.Item_frame1)
        Me.Name = "menu_drinks"
        Me.Size = New System.Drawing.Size(529, 706)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Item_frame1 As item_frame
    Friend WithEvents Item_frame2 As item_frame
    Friend WithEvents Item_frame3 As item_frame
    Friend WithEvents Item_frame4 As item_frame
    Friend WithEvents Item_frame5 As item_frame
    Friend WithEvents Item_frame6 As item_frame
    Friend WithEvents Item_frame7 As item_frame
End Class
