<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menu_apetizer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_apetizer))
        Me.Item_frame3 = New POS.item_frame()
        Me.Item_frame5 = New POS.item_frame()
        Me.Item_frame4 = New POS.item_frame()
        Me.Item_frame2 = New POS.item_frame()
        Me.Item_frame1 = New POS.item_frame()
        Me.SuspendLayout()
        '
        'Item_frame3
        '
        Me.Item_frame3.BackColor = System.Drawing.Color.White
        Me.Item_frame3.ItemIcon = CType(resources.GetObject("Item_frame3.ItemIcon"), System.Drawing.Image)
        Me.Item_frame3.ItemName = "Special Apetizer 3"
        Me.Item_frame3.ItemPrice = 39.0R
        Me.Item_frame3.Location = New System.Drawing.Point(354, 12)
        Me.Item_frame3.Name = "Item_frame3"
        Me.Item_frame3.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame3.TabIndex = 0
        '
        'Item_frame5
        '
        Me.Item_frame5.BackColor = System.Drawing.Color.White
        Me.Item_frame5.ItemIcon = CType(resources.GetObject("Item_frame5.ItemIcon"), System.Drawing.Image)
        Me.Item_frame5.ItemName = "Special Apetizer 5"
        Me.Item_frame5.ItemPrice = 15.0R
        Me.Item_frame5.Location = New System.Drawing.Point(183, 240)
        Me.Item_frame5.Name = "Item_frame5"
        Me.Item_frame5.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame5.TabIndex = 0
        '
        'Item_frame4
        '
        Me.Item_frame4.BackColor = System.Drawing.Color.White
        Me.Item_frame4.ItemIcon = CType(resources.GetObject("Item_frame4.ItemIcon"), System.Drawing.Image)
        Me.Item_frame4.ItemName = "Special Apetizer 4"
        Me.Item_frame4.ItemPrice = 30.0R
        Me.Item_frame4.Location = New System.Drawing.Point(12, 240)
        Me.Item_frame4.Name = "Item_frame4"
        Me.Item_frame4.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame4.TabIndex = 0
        '
        'Item_frame2
        '
        Me.Item_frame2.BackColor = System.Drawing.Color.White
        Me.Item_frame2.ItemIcon = CType(resources.GetObject("Item_frame2.ItemIcon"), System.Drawing.Image)
        Me.Item_frame2.ItemName = "Special Apetizer 2"
        Me.Item_frame2.ItemPrice = 25.0R
        Me.Item_frame2.Location = New System.Drawing.Point(183, 12)
        Me.Item_frame2.Name = "Item_frame2"
        Me.Item_frame2.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame2.TabIndex = 0
        '
        'Item_frame1
        '
        Me.Item_frame1.BackColor = System.Drawing.Color.White
        Me.Item_frame1.ItemIcon = CType(resources.GetObject("Item_frame1.ItemIcon"), System.Drawing.Image)
        Me.Item_frame1.ItemName = "Special Apetizer 1"
        Me.Item_frame1.ItemPrice = 35.0R
        Me.Item_frame1.Location = New System.Drawing.Point(12, 12)
        Me.Item_frame1.Name = "Item_frame1"
        Me.Item_frame1.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame1.TabIndex = 0
        '
        'menu_apetizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Item_frame3)
        Me.Controls.Add(Me.Item_frame5)
        Me.Controls.Add(Me.Item_frame4)
        Me.Controls.Add(Me.Item_frame2)
        Me.Controls.Add(Me.Item_frame1)
        Me.Name = "menu_apetizer"
        Me.Size = New System.Drawing.Size(529, 476)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Item_frame1 As item_frame
    Friend WithEvents Item_frame2 As item_frame
    Friend WithEvents Item_frame3 As item_frame
    Friend WithEvents Item_frame4 As item_frame
    Friend WithEvents Item_frame5 As item_frame
End Class
