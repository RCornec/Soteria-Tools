<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputBox
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_TextEntry = New System.Windows.Forms.TextBox()
        Me.Bt_Cancel = New System.Windows.Forms.Button()
        Me.Bt_Ok = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Entity Name:"
        '
        'Txt_TextEntry
        '
        Me.Txt_TextEntry.Location = New System.Drawing.Point(110, 10)
        Me.Txt_TextEntry.Name = "Txt_TextEntry"
        Me.Txt_TextEntry.Size = New System.Drawing.Size(183, 20)
        Me.Txt_TextEntry.TabIndex = 1
        '
        'Bt_Cancel
        '
        Me.Bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bt_Cancel.Location = New System.Drawing.Point(63, 51)
        Me.Bt_Cancel.Name = "Bt_Cancel"
        Me.Bt_Cancel.Size = New System.Drawing.Size(82, 23)
        Me.Bt_Cancel.TabIndex = 3
        Me.Bt_Cancel.Text = "Cancel"
        Me.Bt_Cancel.UseVisualStyleBackColor = True
        '
        'Bt_Ok
        '
        Me.Bt_Ok.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bt_Ok.Location = New System.Drawing.Point(165, 51)
        Me.Bt_Ok.Name = "Bt_Ok"
        Me.Bt_Ok.Size = New System.Drawing.Size(82, 23)
        Me.Bt_Ok.TabIndex = 4
        Me.Bt_Ok.Text = "Insert"
        Me.Bt_Ok.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(63, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(165, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Insert"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'InputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Bt_Cancel
        Me.ClientSize = New System.Drawing.Size(298, 83)
        Me.Controls.Add(Me.Bt_Ok)
        Me.Controls.Add(Me.Bt_Cancel)
        Me.Controls.Add(Me.Txt_TextEntry)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputBox"
        Me.Text = "Dialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_TextEntry As System.Windows.Forms.TextBox
    Friend WithEvents Bt_Cancel As System.Windows.Forms.Button
    Friend WithEvents Bt_Ok As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
