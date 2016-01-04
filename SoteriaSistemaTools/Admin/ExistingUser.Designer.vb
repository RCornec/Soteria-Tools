<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistingUser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbUserID = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpName = New System.Windows.Forms.TabPage()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.pbName = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbFullName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.LabelLogin = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbProposedLogin = New System.Windows.Forms.TextBox()
        Me.tbActualLogin = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pbLogin = New System.Windows.Forms.PictureBox()
        Me.tpPw = New System.Windows.Forms.TabPage()
        Me.LabelPW = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbpwRetype = New System.Windows.Forms.TextBox()
        Me.tbPw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbpw = New System.Windows.Forms.PictureBox()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpName.SuspendLayout()
        CType(Me.pbName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpLogin.SuspendLayout()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPw.SuspendLayout()
        CType(Me.pbpw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.tbUserID)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.dgvUsers)
        Me.Panel1.Controls.Add(Me.tbSearch)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 204)
        Me.Panel1.TabIndex = 33
        '
        'tbUserID
        '
        Me.tbUserID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbUserID.Location = New System.Drawing.Point(514, 12)
        Me.tbUserID.Name = "tbUserID"
        Me.tbUserID.Size = New System.Drawing.Size(50, 20)
        Me.tbUserID.TabIndex = 37
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpName)
        Me.TabControl1.Controls.Add(Me.tpLogin)
        Me.TabControl1.Controls.Add(Me.tpPw)
        Me.TabControl1.Location = New System.Drawing.Point(311, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(343, 172)
        Me.TabControl1.TabIndex = 36
        '
        'tpName
        '
        Me.tpName.Controls.Add(Me.LabelName)
        Me.tpName.Controls.Add(Me.pbName)
        Me.tpName.Controls.Add(Me.Label11)
        Me.tpName.Controls.Add(Me.tbLastName)
        Me.tpName.Controls.Add(Me.tbFirstName)
        Me.tpName.Controls.Add(Me.tbFullName)
        Me.tpName.Controls.Add(Me.Label12)
        Me.tpName.Controls.Add(Me.Label8)
        Me.tpName.Location = New System.Drawing.Point(4, 22)
        Me.tpName.Name = "tpName"
        Me.tpName.Padding = New System.Windows.Forms.Padding(3)
        Me.tpName.Size = New System.Drawing.Size(335, 146)
        Me.tpName.TabIndex = 0
        Me.tpName.Text = "Name"
        Me.tpName.UseVisualStyleBackColor = True
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(117, 115)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(10, 13)
        Me.LabelName.TabIndex = 46
        Me.LabelName.Text = " "
        Me.LabelName.Visible = False
        '
        'pbName
        '
        Me.pbName.Location = New System.Drawing.Point(70, 105)
        Me.pbName.Name = "pbName"
        Me.pbName.Size = New System.Drawing.Size(41, 35)
        Me.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbName.TabIndex = 45
        Me.pbName.TabStop = False
        Me.pbName.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(54, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "New Last Name:"
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(146, 73)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(173, 20)
        Me.tbLastName.TabIndex = 43
        Me.tbLastName.Tag = "Open"
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(146, 47)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(173, 20)
        Me.tbFirstName.TabIndex = 41
        Me.tbFirstName.Tag = "Open"
        '
        'tbFullName
        '
        Me.tbFullName.Enabled = False
        Me.tbFullName.Location = New System.Drawing.Point(146, 11)
        Me.tbFullName.Name = "tbFullName"
        Me.tbFullName.Size = New System.Drawing.Size(173, 20)
        Me.tbFullName.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(56, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "New First Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Actual First && Last Name:"
        '
        'tpLogin
        '
        Me.tpLogin.Controls.Add(Me.LabelLogin)
        Me.tpLogin.Controls.Add(Me.Label10)
        Me.tpLogin.Controls.Add(Me.tbProposedLogin)
        Me.tpLogin.Controls.Add(Me.tbActualLogin)
        Me.tpLogin.Controls.Add(Me.Label9)
        Me.tpLogin.Controls.Add(Me.pbLogin)
        Me.tpLogin.Location = New System.Drawing.Point(4, 22)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLogin.Size = New System.Drawing.Size(335, 146)
        Me.tpLogin.TabIndex = 1
        Me.tpLogin.Text = "Login"
        Me.tpLogin.UseVisualStyleBackColor = True
        '
        'LabelLogin
        '
        Me.LabelLogin.AutoSize = True
        Me.LabelLogin.Location = New System.Drawing.Point(81, 93)
        Me.LabelLogin.Name = "LabelLogin"
        Me.LabelLogin.Size = New System.Drawing.Size(45, 13)
        Me.LabelLogin.TabIndex = 42
        Me.LabelLogin.Text = "Label13"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Proposed Login:"
        '
        'tbProposedLogin
        '
        Me.tbProposedLogin.Location = New System.Drawing.Point(146, 47)
        Me.tbProposedLogin.Name = "tbProposedLogin"
        Me.tbProposedLogin.Size = New System.Drawing.Size(173, 20)
        Me.tbProposedLogin.TabIndex = 39
        Me.tbProposedLogin.Tag = "Open"
        '
        'tbActualLogin
        '
        Me.tbActualLogin.Enabled = False
        Me.tbActualLogin.Location = New System.Drawing.Point(146, 11)
        Me.tbActualLogin.Name = "tbActualLogin"
        Me.tbActualLogin.Size = New System.Drawing.Size(173, 20)
        Me.tbActualLogin.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Actual Login:"
        '
        'pbLogin
        '
        Me.pbLogin.Location = New System.Drawing.Point(34, 83)
        Me.pbLogin.Name = "pbLogin"
        Me.pbLogin.Size = New System.Drawing.Size(41, 35)
        Me.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogin.TabIndex = 41
        Me.pbLogin.TabStop = False
        '
        'tpPw
        '
        Me.tpPw.Controls.Add(Me.LabelPW)
        Me.tpPw.Controls.Add(Me.Label6)
        Me.tpPw.Controls.Add(Me.tbpwRetype)
        Me.tpPw.Controls.Add(Me.tbPw)
        Me.tpPw.Controls.Add(Me.Label3)
        Me.tpPw.Controls.Add(Me.pbpw)
        Me.tpPw.Location = New System.Drawing.Point(4, 22)
        Me.tpPw.Name = "tpPw"
        Me.tpPw.Size = New System.Drawing.Size(335, 146)
        Me.tpPw.TabIndex = 2
        Me.tpPw.Text = "Password"
        Me.tpPw.UseVisualStyleBackColor = True
        '
        'LabelPW
        '
        Me.LabelPW.AutoSize = True
        Me.LabelPW.Location = New System.Drawing.Point(81, 93)
        Me.LabelPW.Name = "LabelPW"
        Me.LabelPW.Size = New System.Drawing.Size(10, 13)
        Me.LabelPW.TabIndex = 38
        Me.LabelPW.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Retype New Password:"
        '
        'tbpwRetype
        '
        Me.tbpwRetype.Enabled = False
        Me.tbpwRetype.Location = New System.Drawing.Point(146, 47)
        Me.tbpwRetype.Name = "tbpwRetype"
        Me.tbpwRetype.ShortcutsEnabled = False
        Me.tbpwRetype.Size = New System.Drawing.Size(173, 20)
        Me.tbpwRetype.TabIndex = 35
        Me.tbpwRetype.Tag = "Open"
        '
        'tbPw
        '
        Me.tbPw.Location = New System.Drawing.Point(146, 11)
        Me.tbPw.Name = "tbPw"
        Me.tbPw.Size = New System.Drawing.Size(173, 20)
        Me.tbPw.TabIndex = 32
        Me.tbPw.Tag = "Open"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Enter New Password:"
        '
        'pbpw
        '
        Me.pbpw.Location = New System.Drawing.Point(34, 83)
        Me.pbpw.Name = "pbpw"
        Me.pbpw.Size = New System.Drawing.Size(41, 35)
        Me.pbpw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbpw.TabIndex = 37
        Me.pbpw.TabStop = False
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToOrderColumns = True
        Me.dgvUsers.AllowUserToResizeColumns = False
        Me.dgvUsers.AllowUserToResizeRows = False
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(19, 46)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.Size = New System.Drawing.Size(270, 150)
        Me.dgvUsers.TabIndex = 35
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(71, 20)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(218, 20)
        Me.tbSearch.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Name:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Location = New System.Drawing.Point(0, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(661, 40)
        Me.Panel2.TabIndex = 34
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(333, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 26)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel Modifications"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(481, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(83, 26)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(570, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 26)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(660, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(183, 238)
        Me.ListBox1.TabIndex = 35
        '
        'ExistingUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 244)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExistingUser"
        Me.Text = "Existing User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpName.ResumeLayout(False)
        Me.tpName.PerformLayout()
        CType(Me.pbName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpLogin.ResumeLayout(False)
        Me.tpLogin.PerformLayout()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPw.ResumeLayout(False)
        Me.tpPw.PerformLayout()
        CType(Me.pbpw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpName As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbLastName As System.Windows.Forms.TextBox
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Friend WithEvents tbFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tpLogin As System.Windows.Forms.TabPage
    Friend WithEvents LabelLogin As System.Windows.Forms.Label
    Friend WithEvents pbLogin As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbProposedLogin As System.Windows.Forms.TextBox
    Friend WithEvents tbActualLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tpPw As System.Windows.Forms.TabPage
    Friend WithEvents LabelPW As System.Windows.Forms.Label
    Friend WithEvents pbpw As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbpwRetype As System.Windows.Forms.TextBox
    Friend WithEvents tbPw As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tbUserID As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents pbName As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
