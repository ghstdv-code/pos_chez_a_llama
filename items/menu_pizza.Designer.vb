<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_pizza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_pizza))
        Me.Item_frame2 = New POS.item_frame()
        Me.Item_frame1 = New POS.item_frame()
        Me.SuspendLayout()
        '
        'Item_frame2
        '
        Me.Item_frame2.BackColor = System.Drawing.Color.White
        Me.Item_frame2.ItemIcon = CType(resources.GetObject("Item_frame2.ItemIcon"), System.Drawing.Image)
        Me.Item_frame2.ItemName = "Special Pizza 2"
        Me.Item_frame2.ItemPrice = "159.00"
        Me.Item_frame2.Location = New System.Drawing.Point(183, 12)
        Me.Item_frame2.Name = "Item_frame2"
        Me.Item_frame2.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame2.TabIndex = 0
        '
        'Item_frame1
        '
        Me.Item_frame1.BackColor = System.Drawing.Color.White
        Me.Item_frame1.ItemIcon = CType(resources.GetObject("Item_frame1.ItemIcon"), System.Drawing.Image)
        Me.Item_frame1.ItemName = "Special Pizza 1"
        Me.Item_frame1.ItemPrice = "159.00"
        Me.Item_frame1.Location = New System.Drawing.Point(12, 12)
        Me.Item_frame1.Name = "Item_frame1"
        Me.Item_frame1.Size = New System.Drawing.Size(165, 222)
        Me.Item_frame1.TabIndex = 0
        '
        'menu_pizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Item_frame2)
        Me.Controls.Add(Me.Item_frame1)
        Me.Name = "menu_pizza"
        Me.Size = New System.Drawing.Size(529, 248)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Item_frame1 As item_frame
    Friend WithEvents Item_frame2 As item_frame
End Class
