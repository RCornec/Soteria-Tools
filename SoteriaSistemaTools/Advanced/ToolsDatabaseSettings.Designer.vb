<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolsDatabaseSettings
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
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbpw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.tbDBName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbServer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.btnChanges = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbUser
        '
        Me.tbUser.Enabled = False
        Me.tbUser.Location = New System.Drawing.Point(144, 64)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(214, 20)
        Me.tbUser.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Database User Login:"
        '
        'tbpw
        '
        Me.tbpw.Enabled = False
        Me.tbpw.Location = New System.Drawing.Point(144, 90)
        Me.tbpw.Name = "tbpw"
        Me.tbpw.Size = New System.Drawing.Size(214, 20)
        Me.tbpw.TabIndex = 6
        Me.tbpw.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Database User Password:"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(14, 116)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(100, 23)
        Me.btnTest.TabIndex = 8
        Me.btnTest.Text = "Test Connection"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'tbDBName
        '
        Me.tbDBName.Enabled = False
        Me.tbDBName.Location = New System.Drawing.Point(144, 38)
        Me.tbDBName.Name = "tbDBName"
        Me.tbDBName.Size = New System.Drawing.Size(214, 20)
        Me.tbDBName.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Database Name:"
        '
        'tbServer
        '
        Me.tbServer.Enabled = False
        Me.tbServer.Location = New System.Drawing.Point(144, 12)
        Me.tbServer.Name = "tbServer"
        Me.tbServer.Size = New System.Drawing.Size(112, 20)
        Me.tbServer.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Server:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(227, 116)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save Configuration"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Port:"
        '
        'tbPort
        '
        Me.tbPort.Enabled = False
        Me.tbPort.Location = New System.Drawing.Point(298, 12)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New System.Drawing.Size(60, 20)
        Me.tbPort.TabIndex = 15
        '
        'btnChanges
        '
        Me.btnChanges.Location = New System.Drawing.Point(120, 116)
        Me.btnChanges.Name = "btnChanges"
        Me.btnChanges.Size = New System.Drawing.Size(101, 23)
        Me.btnChanges.TabIndex = 16
        Me.btnChanges.Text = "Make Changes"
        Me.btnChanges.UseVisualStyleBackColor = True
        '
        'ToolsDatabaseSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 143)
        Me.Controls.Add(Me.btnChanges)
        Me.Controls.Add(Me.tbPort)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbDBName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbServer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.tbpw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ToolsDatabaseSettings"
        Me.Text = "Tools Database Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbpw As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents tbDBName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbServer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbPort As System.Windows.Forms.TextBox
    Friend WithEvents btnChanges As System.Windows.Forms.Button
End Class
