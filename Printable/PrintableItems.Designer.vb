<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintableItems
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
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblItemAndQt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Gray
        Me.lblPrice.Location = New System.Drawing.Point(234, -1)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(130, 22)
        Me.lblPrice.TabIndex = 37
        Me.lblPrice.Text = "@price"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemAndQt
        '
        Me.lblItemAndQt.BackColor = System.Drawing.Color.Transparent
        Me.lblItemAndQt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemAndQt.ForeColor = System.Drawing.Color.Gray
        Me.lblItemAndQt.Location = New System.Drawing.Point(6, -1)
        Me.lblItemAndQt.Name = "lblItemAndQt"
        Me.lblItemAndQt.Size = New System.Drawing.Size(148, 22)
        Me.lblItemAndQt.TabIndex = 38
        Me.lblItemAndQt.Text = "@item&qt"
        Me.lblItemAndQt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrintableItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblItemAndQt)
        Me.Name = "PrintableItems"
        Me.Size = New System.Drawing.Size(370, 20)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPrice As Label
    Friend WithEvents lblItemAndQt As Label
End Class
