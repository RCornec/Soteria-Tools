<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeEmployeePassword
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
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbpwRetype = New System.Windows.Forms.TextBox()
        Me.tbPw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToOrderColumns = True
        Me.dgvUsers.AllowUserToResizeColumns = False
        Me.dgvUsers.AllowUserToResizeRows = False
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(12, 38)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.Size = New System.Drawing.Size(270, 154)
        Me.dgvUsers.TabIndex = 38
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(64, 12)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(218, 20)
        Me.tbSearch.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Retype New Password:"
        '
        'tbpwRetype
        '
        Me.tbpwRetype.Enabled = False
        Me.tbpwRetype.Location = New System.Drawing.Point(423, 39)
        Me.tbpwRetype.Name = "tbpwRetype"
        Me.tbpwRetype.ShortcutsEnabled = False
        Me.tbpwRetype.Size = New System.Drawing.Size(173, 20)
        Me.tbpwRetype.TabIndex = 41
        Me.tbpwRetype.Tag = "Open"
        '
        'tbPw
        '
        Me.tbPw.Location = New System.Drawing.Point(423, 13)
        Me.tbPw.Name = "tbPw"
        Me.tbPw.Size = New System.Drawing.Size(173, 20)
        Me.tbPw.TabIndex = 39
        Me.tbPw.Tag = "Open"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Enter New Password:"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(296, 155)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 37)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel Changes"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(406, 154)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(98, 37)
        Me.btnValidate.TabIndex = 45
        Me.btnValidate.Text = "Validate changes"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(296, 67)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(300, 82)
        Me.ListBox1.TabIndex = 46
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(510, 154)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 37)
        Me.btnClose.TabIndex = 47
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ChangeUserPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 201)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbpwRetype)
        Me.Controls.Add(Me.tbPw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ChangeUserPassword"
        Me.Text = "User Password Change"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbpwRetype As System.Windows.Forms.TextBox
    Friend WithEvents tbPw As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnValidate As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
