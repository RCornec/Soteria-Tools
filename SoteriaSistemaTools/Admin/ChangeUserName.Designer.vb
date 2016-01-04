<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeUserName
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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelFullName = New System.Windows.Forms.Label()
        Me.tbUserID = New System.Windows.Forms.TextBox()
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
        Me.dgvUsers.Size = New System.Drawing.Size(374, 154)
        Me.dgvUsers.TabIndex = 38
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(64, 12)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(322, 20)
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
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(406, 152)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 37)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel Changes"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(516, 151)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(98, 37)
        Me.btnValidate.TabIndex = 45
        Me.btnValidate.Text = "Validate changes"
        Me.btnValidate.UseVisualStyleBackColor = True
        Me.btnValidate.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(406, 103)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(300, 43)
        Me.ListBox1.TabIndex = 46
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(620, 151)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 37)
        Me.btnClose.TabIndex = 47
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(438, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "New Last Name:"
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(530, 77)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(173, 20)
        Me.tbLastName.TabIndex = 52
        Me.tbLastName.Tag = "Open"
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(531, 51)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(173, 20)
        Me.tbFirstName.TabIndex = 50
        Me.tbFirstName.Tag = "Open"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(440, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "New First Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(407, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "User Name:"
        '
        'LabelFullName
        '
        Me.LabelFullName.AutoSize = True
        Me.LabelFullName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFullName.Location = New System.Drawing.Point(476, 12)
        Me.LabelFullName.Name = "LabelFullName"
        Me.LabelFullName.Size = New System.Drawing.Size(159, 17)
        Me.LabelFullName.TabIndex = 54
        Me.LabelFullName.Text = "Actual First && Last Name"
        '
        'tbUserID
        '
        Me.tbUserID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbUserID.Location = New System.Drawing.Point(406, 35)
        Me.tbUserID.Name = "tbUserID"
        Me.tbUserID.Size = New System.Drawing.Size(50, 20)
        Me.tbUserID.TabIndex = 55
        Me.tbUserID.Visible = False
        '
        'ChangeUserName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 201)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbUserID)
        Me.Controls.Add(Me.LabelFullName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ChangeUserName"
        Me.Text = "User Password Change"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnValidate As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbLastName As System.Windows.Forms.TextBox
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabelFullName As System.Windows.Forms.Label
    Friend WithEvents tbUserID As System.Windows.Forms.TextBox
End Class
