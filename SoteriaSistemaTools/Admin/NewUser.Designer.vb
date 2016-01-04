<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPw = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.LabelInfos = New System.Windows.Forms.Label()
        Me.pbLogin = New System.Windows.Forms.PictureBox()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(98, 6)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(173, 20)
        Me.tbName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First & Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password:"
        '
        'tbPw
        '
        Me.tbPw.Location = New System.Drawing.Point(98, 58)
        Me.tbPw.Name = "tbPw"
        Me.tbPw.Size = New System.Drawing.Size(173, 20)
        Me.tbPw.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Login proposed:"
        '
        'tbLogin
        '
        Me.tbLogin.Location = New System.Drawing.Point(98, 32)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New System.Drawing.Size(173, 20)
        Me.tbLogin.TabIndex = 4
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(98, 125)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(83, 26)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(187, 125)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 26)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(9, 125)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(83, 26)
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'LabelInfos
        '
        Me.LabelInfos.AutoSize = True
        Me.LabelInfos.Location = New System.Drawing.Point(145, 94)
        Me.LabelInfos.Name = "LabelInfos"
        Me.LabelInfos.Size = New System.Drawing.Size(10, 13)
        Me.LabelInfos.TabIndex = 40
        Me.LabelInfos.Text = " "
        '
        'pbLogin
        '
        Me.pbLogin.Location = New System.Drawing.Point(98, 84)
        Me.pbLogin.Name = "pbLogin"
        Me.pbLogin.Size = New System.Drawing.Size(41, 35)
        Me.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogin.TabIndex = 39
        Me.pbLogin.TabStop = False
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 155)
        Me.Controls.Add(Me.LabelInfos)
        Me.Controls.Add(Me.pbLogin)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPw)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbName)
        Me.Name = "NewUser"
        Me.Text = "New User"
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbPw As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents LabelInfos As System.Windows.Forms.Label
    Friend WithEvents pbLogin As System.Windows.Forms.PictureBox
End Class
