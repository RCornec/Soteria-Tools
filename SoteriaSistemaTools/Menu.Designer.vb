<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("DataBase Settings", "database configuration.png")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Application Settings", "settings1.png")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Options", "Settings3.png")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Change Name")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Change Login")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Change Password", "application-pgp-signature.png")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("New User", "user-group-new.png")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Remove User")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Users Time Logs", "clock.png")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Classes Offered", "classes.png")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Trainings", "Video.png")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Companies", 0)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Change Passwords", "Password.jpg")
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Assign Trainings", "training.png")
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Edit Informations", "EmployeesInfos.png")
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("New Employee", "EmployeesAdd.png")
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Change Name")
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Change Login")
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Change Password", "application-pgp-signature.png")
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("New User", "user-group-new.png")
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Remove User")
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Users Time Logs", "clock.png")
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Import Excel File")
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Import From Access", "access icon.png")
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Import From Binary File", "binary File.png")
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Check consistency Of Data On Server", "Data1.png")
        Me.lvSettings = New System.Windows.Forms.ListView()
        Me.ILSettings = New System.Windows.Forms.ImageList(Me.components)
        Me.lvUsers = New System.Windows.Forms.ListView()
        Me.ILUsers = New System.Windows.Forms.ImageList(Me.components)
        Me.lvtrainings = New System.Windows.Forms.ListView()
        Me.ILtrainings = New System.Windows.Forms.ImageList(Me.components)
        Me.lvCompanies = New System.Windows.Forms.ListView()
        Me.ILCompanies = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnTrainings = New System.Windows.Forms.Button()
        Me.btnCompanies = New System.Windows.Forms.Button()
        Me.ILEmployees = New System.Windows.Forms.ImageList(Me.components)
        Me.LvEmployees = New System.Windows.Forms.ListView()
        Me.btEmployees = New System.Windows.Forms.Button()
        Me.ILReports = New System.Windows.Forms.ImageList(Me.components)
        Me.lvReports = New System.Windows.Forms.ListView()
        Me.btnReporrts = New System.Windows.Forms.Button()
        Me.lvData = New System.Windows.Forms.ListView()
        Me.btnData = New System.Windows.Forms.Button()
        Me.ILData = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'lvSettings
        '
        Me.lvSettings.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.lvSettings.LargeImageList = Me.ILSettings
        Me.lvSettings.Location = New System.Drawing.Point(1, 497)
        Me.lvSettings.Name = "lvSettings"
        Me.lvSettings.Size = New System.Drawing.Size(186, 42)
        Me.lvSettings.TabIndex = 16
        Me.lvSettings.UseCompatibleStateImageBehavior = False
        '
        'ILSettings
        '
        Me.ILSettings.ImageStream = CType(resources.GetObject("ILSettings.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ILSettings.TransparentColor = System.Drawing.Color.Transparent
        Me.ILSettings.Images.SetKeyName(0, "settings1.png")
        Me.ILSettings.Images.SetKeyName(1, "Settings2.png")
        Me.ILSettings.Images.SetKeyName(2, "Settings3.png")
        Me.ILSettings.Images.SetKeyName(3, "database configuration.png")
        '
        'lvUsers
        '
        Me.lvUsers.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9})
        Me.lvUsers.LargeImageList = Me.ILUsers
        Me.lvUsers.Location = New System.Drawing.Point(1, 302)
        Me.lvUsers.Name = "lvUsers"
        Me.lvUsers.Size = New System.Drawing.Size(186, 42)
        Me.lvUsers.TabIndex = 15
        Me.lvUsers.UseCompatibleStateImageBehavior = False
        '
        'ILUsers
        '
        Me.ILUsers.ImageStream = CType(resources.GetObject("ILUsers.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ILUsers.TransparentColor = System.Drawing.Color.Transparent
        Me.ILUsers.Images.SetKeyName(0, "add-user-icon1.jpg")
        Me.ILUsers.Images.SetKeyName(1, "application-pgp-signature.png")
        Me.ILUsers.Images.SetKeyName(2, "clock.png")
        Me.ILUsers.Images.SetKeyName(3, "user_accounts.png")
        Me.ILUsers.Images.SetKeyName(4, "UserGroup.png")
        Me.ILUsers.Images.SetKeyName(5, "user-group-new.png")
        Me.ILUsers.Images.SetKeyName(6, "user-icon.jpeg")
        Me.ILUsers.Images.SetKeyName(7, "Users.png")
        '
        'lvtrainings
        '
        Me.lvtrainings.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem10, ListViewItem11})
        Me.lvtrainings.LargeImageList = Me.ILtrainings
        Me.lvtrainings.Location = New System.Drawing.Point(1, 117)
        Me.lvtrainings.Name = "lvtrainings"
        Me.lvtrainings.Size = New System.Drawing.Size(186, 66)
        Me.lvtrainings.TabIndex = 14
        Me.lvtrainings.UseCompatibleStateImageBehavior = False
        '
        'ILtrainings
        '
        Me.ILtrainings.ImageStream = CType(resources.GetObject("ILtrainings.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ILtrainings.TransparentColor = System.Drawing.Color.Transparent
        Me.ILtrainings.Images.SetKeyName(0, "classes.png")
        Me.ILtrainings.Images.SetKeyName(1, "Video.png")
        '
        'lvCompanies
        '
        ListViewItem12.ToolTipText = "Create companies here"
        Me.lvCompanies.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem12})
        Me.lvCompanies.LargeImageList = Me.ILCompanies
        Me.lvCompanies.Location = New System.Drawing.Point(1, 31)
        Me.lvCompanies.Name = "lvCompanies"
        Me.lvCompanies.Size = New System.Drawing.Size(186, 60)
        Me.lvCompanies.TabIndex = 13
        Me.lvCompanies.UseCompatibleStateImageBehavior = False
        '
        'ILCompanies
        '
        Me.ILCompanies.ImageStream = CType(resources.GetObject("ILCompanies.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ILCompanies.TransparentColor = System.Drawing.Color.Transparent
        Me.ILCompanies.Images.SetKeyName(0, "Company.png")
        Me.ILCompanies.Images.SetKeyName(1, "hierarchy.png")
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(1, 468)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(186, 23)
        Me.btnSettings.TabIndex = 12
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Location = New System.Drawing.Point(1, 273)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(186, 23)
        Me.btnUsers.TabIndex = 11
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnTrainings
        '
        Me.btnTrainings.Location = New System.Drawing.Point(1, 98)
        Me.btnTrainings.Name = "btnTrainings"
        Me.btnTrainings.Size = New System.Drawing.Size(186, 23)
        Me.btnTrainings.TabIndex = 10
        Me.btnTrainings.Text = "Trainings"
        Me.btnTrainings.UseVisualStyleBackColor = True
        '
        'btnCompanies
        '
        Me.btnCompanies.Location = New System.Drawing.Point(1, 2)
        Me.btnCompanies.Name = "btnCompanies"
        Me.btnCompanies.Size = New System.Drawing.Size(186, 23)
        Me.btnCompanies.TabIndex = 9
        Me.btnCompanies.Text = "Companies"
        Me.btnCompanies.UseVisualStyleBackColor = True
        '
        'ILEmployees
        '
        Me.ILEmployees.ImageStream = CType(resources.GetObject("ILEmployees.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ILEmployees.TransparentColor = System.Drawing.Color.Transparent
        Me.ILEmployees.Images.SetKeyName(0, "employees2.png")
        Me.ILEmployees.Images.SetKeyName(1, "Employees3.png")
        Me.ILEmployees.Images.SetKeyName(2, "Employees4.png")
        Me.ILEmployees.Images.SetKeyName(3, "EmployeesAdd.png")
        Me.ILEmployees.Images.SetKeyName(4, "team.png")
        Me.ILEmployees.Images.SetKeyName(5, "EmployeesInfos.png")
        Me.ILEmployees.Images.SetKeyName(6, "Infos.png")
        Me.ILEmployees.Images.SetKeyName(7, "Professionals.png")
        Me.ILEmployees.Images.SetKeyName(8, "Password.jpg")
        Me.ILEmployees.Images.SetKeyName(9, "training.png")
        '
        'LvEmployees
        '
        Me.LvEmployees.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16})
        Me.LvEmployees.LargeImageList = Me.ILEmployees
        Me.LvEmployees.Location = New System.Drawing.Point(1, 217)
        Me.LvEmployees.Name = "LvEmployees"
        Me.LvEmployees.Size = New System.Drawing.Size(186, 50)
        Me.LvEmployees.TabIndex = 18
        Me.LvEmployees.UseCompatibleStateImageBehavior = False
        '
        'btEmployees
        '
        Me.btEmployees.Location = New System.Drawing.Point(1, 188)
        Me.btEmployees.Name = "btEmployees"
        Me.btEmployees.Size = New System.Drawing.Size(186, 23)
        Me.btEmployees.TabIndex = 17
        Me.btEmployees.Text = "Employees"
        Me.btEmployees.UseVisualStyleBackColor = True
        '
        'ILReports
        '
        Me.ILReports.ImageStream = CType(resources.GetObject("ILReports.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ILReports.TransparentColor = System.Drawing.Color.Transparent
        Me.ILReports.Images.SetKeyName(0, "Apps-esd-icon.png")
        Me.ILReports.Images.SetKeyName(1, "Apps-utilities-system-monitor-icon.png")
        Me.ILReports.Images.SetKeyName(2, "graph_chart_business_report_device.png")
        Me.ILReports.Images.SetKeyName(3, "pie_chart.png")
        Me.ILReports.Images.SetKeyName(4, "report.jpg")
        Me.ILReports.Images.SetKeyName(5, "stats report jpeg.jpg")
        Me.ILReports.Images.SetKeyName(6, "stats.png")
        '
        'lvReports
        '
        Me.lvReports.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22})
        Me.lvReports.LargeImageList = Me.ILReports
        Me.lvReports.Location = New System.Drawing.Point(1, 380)
        Me.lvReports.Name = "lvReports"
        Me.lvReports.Size = New System.Drawing.Size(186, 42)
        Me.lvReports.TabIndex = 20
        Me.lvReports.UseCompatibleStateImageBehavior = False
        '
        'btnReporrts
        '
        Me.btnReporrts.Location = New System.Drawing.Point(1, 351)
        Me.btnReporrts.Name = "btnReporrts"
        Me.btnReporrts.Size = New System.Drawing.Size(186, 23)
        Me.btnReporrts.TabIndex = 19
        Me.btnReporrts.Text = "Reports"
        Me.btnReporrts.UseVisualStyleBackColor = True
        '
        'lvData
        '
        Me.lvData.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26})
        Me.lvData.LargeImageList = Me.ILData
        Me.lvData.Location = New System.Drawing.Point(1, 449)
        Me.lvData.Name = "lvData"
        Me.lvData.Size = New System.Drawing.Size(186, 13)
        Me.lvData.TabIndex = 22
        Me.lvData.UseCompatibleStateImageBehavior = False
        '
        'btnData
        '
        Me.btnData.Location = New System.Drawing.Point(1, 420)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(186, 23)
        Me.btnData.TabIndex = 21
        Me.btnData.Text = "Data"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'ILData
        '
        Me.ILData.ImageStream = CType(resources.GetObject("ILData.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ILData.TransparentColor = System.Drawing.Color.Transparent
        Me.ILData.Images.SetKeyName(0, "Data1.png")
        Me.ILData.Images.SetKeyName(1, "Data2.png")
        Me.ILData.Images.SetKeyName(2, "filesData.png")
        Me.ILData.Images.SetKeyName(3, "GroupData.png")
        Me.ILData.Images.SetKeyName(4, "excel.png")
        Me.ILData.Images.SetKeyName(5, "access icon.png")
        Me.ILData.Images.SetKeyName(6, "binary File.png")
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 541)
        Me.Controls.Add(Me.lvData)
        Me.Controls.Add(Me.btnData)
        Me.Controls.Add(Me.lvReports)
        Me.Controls.Add(Me.btnReporrts)
        Me.Controls.Add(Me.LvEmployees)
        Me.Controls.Add(Me.btEmployees)
        Me.Controls.Add(Me.lvSettings)
        Me.Controls.Add(Me.lvUsers)
        Me.Controls.Add(Me.lvtrainings)
        Me.Controls.Add(Me.lvCompanies)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnTrainings)
        Me.Controls.Add(Me.btnCompanies)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(205, 1000)
        Me.MinimizeBox = False
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Soteria Sistema ToolBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvSettings As System.Windows.Forms.ListView
    Friend WithEvents lvUsers As System.Windows.Forms.ListView
    Friend WithEvents lvtrainings As System.Windows.Forms.ListView
    Friend WithEvents lvCompanies As System.Windows.Forms.ListView
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnTrainings As System.Windows.Forms.Button
    Friend WithEvents btnCompanies As System.Windows.Forms.Button
    Friend WithEvents ILCompanies As System.Windows.Forms.ImageList
    Friend WithEvents ILtrainings As System.Windows.Forms.ImageList
    Friend WithEvents ILUsers As System.Windows.Forms.ImageList
    Friend WithEvents ILSettings As System.Windows.Forms.ImageList
    Friend WithEvents ILEmployees As System.Windows.Forms.ImageList
    Friend WithEvents LvEmployees As System.Windows.Forms.ListView
    Friend WithEvents btEmployees As System.Windows.Forms.Button
    Friend WithEvents ILReports As System.Windows.Forms.ImageList
    Friend WithEvents lvReports As System.Windows.Forms.ListView
    Friend WithEvents btnReporrts As System.Windows.Forms.Button
    Friend WithEvents lvData As System.Windows.Forms.ListView
    Friend WithEvents btnData As System.Windows.Forms.Button
    Friend WithEvents ILData As System.Windows.Forms.ImageList
End Class
