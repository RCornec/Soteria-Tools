Public Class MenuForm
    ' Private MyArrayOfAuthorizations() As Boolean = {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1} ' an example for now, but will be replaced by the 'minimal' access possible: at least some reports!


    Const ButtonHeight = 26
    Const Spacing = 1
    Const NumOfMenus = 7
    Private Selection As Integer ' first menu displayed by default

    Public Property UserID As Int32
    Public Property Claim As String

    Sub New(ByVal UserId, ByVal claim)
        InitializeComponent()
    End Sub



#Region "User Click Events"
    Private Sub btnCompanies_Click(sender As System.Object, e As System.EventArgs) Handles btnCompanies.Click
        runMenu(1)
    End Sub

    Private Sub btnClasses_Click(sender As System.Object, e As System.EventArgs) Handles btnTrainings.Click
        runMenu(2)
    End Sub

    Private Sub btEmployees_Click(sender As System.Object, e As System.EventArgs) Handles btEmployees.Click
        runMenu(3)
    End Sub

    Private Sub btnUsers_Click(sender As System.Object, e As System.EventArgs) Handles btnUsers.Click
        runMenu(4)
    End Sub

    Private Sub btnSettings_Click_1(sender As System.Object, e As System.EventArgs) Handles btnUsers.Click
        runMenu(5)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles btnSettings.Click
        runMenu(6)
    End Sub

#End Region

#Region "Functions and Subs"
    Private Function GetListViewHeight() As Integer
        GetListViewHeight = Me.Height - (NumOfMenus * (ButtonHeight + Spacing) + Spacing) - 3
    End Function
    Private Sub runMenu(Index As Integer)
        Selection = Index
        Dim LvHeight As Integer = GetListViewHeight()
        Select Case Index

            Case 1 ' Companies expanded
                btnCompanies.ImageIndex = 0 ' no image
                lvCompanies.Top = btnCompanies.Top + ButtonHeight + Spacing
                lvCompanies.Height = LvHeight
                'Collapsed
                btnTrainings.ImageIndex = 1 ' down
                btnTrainings.Top = lvCompanies.Top + LvHeight + Spacing
                lvtrainings.Height = 0
                lvtrainings.Top = btnTrainings.Top
                'Collapsed
                btEmployees.ImageIndex = 1 ' down
                btEmployees.Top = btnTrainings.Top + ButtonHeight + Spacing
                LvEmployees.Height = 0
                LvEmployees.Top = btEmployees.Top
                'Collapsed
                btnUsers.ImageIndex = 1 ' down
                btnUsers.Top = btEmployees.Top + ButtonHeight + Spacing
                lvUsers.Height = 0
                lvUsers.Top = btnUsers.Top
                'Collapsed
                btnSettings.ImageIndex = 1 ' down
                btnSettings.Top = btnUsers.Top + ButtonHeight + Spacing
                lvSettings.Height = 0
                lvSettings.Top = btnSettings.Top

                'Button6.ImageIndex = 1 ' down
                'Button6.Top = btnSettings.Top + ButtonHeight + Spacing
                'ListView6.Height = 0
                'ListView6.Top = Button6.Top

                'Button7.ImageIndex = 1 ' down
                'Button7.Top = btnSettings.Top + ButtonHeight + Spacing
                'ListView7.Height = 0
                'ListView7.Top = Button7.Top


            Case 2
                ' collasped
                btnCompanies.ImageIndex = 1
                lvCompanies.Top = btnCompanies.Top
                lvCompanies.Height = 0

                'extended
                btnTrainings.ImageIndex = 0
                btnTrainings.Top = btnCompanies.Top + ButtonHeight + Spacing
                lvtrainings.Top = btnTrainings.Top + ButtonHeight + Spacing
                lvtrainings.Height = LvHeight

                'collapsed
                btEmployees.ImageIndex = 1
                btEmployees.Top = lvtrainings.Top + LvHeight + Spacing
                LvEmployees.Height = 0
                LvEmployees.Top = btEmployees.Top

                'collapsed
                btnUsers.ImageIndex = 1
                btnUsers.Top = btEmployees.Top + ButtonHeight + Spacing
                lvUsers.Height = 0
                lvUsers.Top = btnUsers.Top

                'collapsed
                btnSettings.ImageIndex = 1
                btnSettings.Top = btnUsers.Top + ButtonHeight + Spacing
                lvSettings.Height = 0
                lvSettings.Top = btnSettings.Top

                'Button6.ImageIndex = 1 ' down
                'Button6.Top = btnSettings.Top + ButtonHeight + Spacing
                'ListView6.Height = 0
                'ListView6.Top = Button6.Top

                'Button7.ImageIndex = 1 ' down
                'Button7.Top = btnSettings.Top + ButtonHeight + Spacing
                'ListView7.Height = 0
                'ListView7.Top = Button7.Top

            Case 3

                ' collasped
                btnCompanies.ImageIndex = 1
                lvCompanies.Top = btnCompanies.Top + ButtonHeight + Spacing
                lvCompanies.Height = 0
                lvtrainings.Top = btnCompanies.Top

                ' collasped
                btnTrainings.ImageIndex = 1
                btnTrainings.Top = btnCompanies.Top + ButtonHeight + Spacing
                lvtrainings.Height = 0
                lvtrainings.Top = btnTrainings.Top

                ' expanded
                btEmployees.ImageIndex = 0
                btEmployees.Top = btnTrainings.Top + ButtonHeight + Spacing
                LvEmployees.Height = LvHeight
                LvEmployees.Top = btEmployees.Top + ButtonHeight + Spacing

                ' collapsed
                btnUsers.ImageIndex = 1
                btnUsers.Top = LvEmployees.Top + LvHeight + Spacing
                lvUsers.Height = 0
                lvUsers.Top = btnUsers.Top

                ' collapsed
                btnSettings.ImageIndex = 1
                btnSettings.Top = btnUsers.Top + ButtonHeight + Spacing
                lvSettings.Height = 0
                lvSettings.Top = btnSettings.Top

                'Button6.ImageIndex = 1 ' down
                'Button6.Top = btnSettings.Top + ButtonHeight + Spacing
                'ListView6.Height = 0
                ' ListView6.Top = Button6.Top

                'Button7.ImageIndex = 1 ' down
                'Button7.Top = btnSettings.Top + ButtonHeight + Spacing
                'ListView7.Height = 0
                'ListView7.Top = Button7.Top

            Case 4
                ' collapsed
                btnCompanies.ImageIndex = 1
                lvCompanies.Top = btnCompanies.Top + ButtonHeight + Spacing
                lvCompanies.Height = 0
                lvtrainings.Top = btnCompanies.Top

                ' collapsed
                btnTrainings.ImageIndex = 1
                btnTrainings.Top = btnCompanies.Top + ButtonHeight + Spacing
                lvtrainings.Height = 0
                lvtrainings.Top = btnTrainings.Top

                'collapsed
                btEmployees.ImageIndex = 1
                btEmployees.Top = btnTrainings.Top + ButtonHeight + Spacing
                LvEmployees.Height = 0
                LvEmployees.Top = btEmployees.Top

                'expanded
                btnUsers.ImageIndex = 0
                btnUsers.Top = btEmployees.Top + ButtonHeight + Spacing
                lvUsers.Height = LvHeight
                lvUsers.Top = btnUsers.Top + ButtonHeight + Spacing

                ' collapsed
                btnSettings.ImageIndex = 1
                btnSettings.Top = lvUsers.Top + LvHeight + Spacing
                lvSettings.Top = btnSettings.Top
                lvSettings.Height = 0

                'Button6.ImageIndex = 1 ' down
                'Button6.Top = btnSettings.Top + ButtonHeight + Spacing
                'ListView6.Height = 0
                'ListView6.Top = Button6.Top

                'Button7.ImageIndex = 1 ' down
                'Button7.Top = btnSettings.Top + ButtonHeight + Spacing
                'ListView7.Height = 0
                'ListView7.Top = Button7.Top

            Case 5
                ' collapsed
                btnCompanies.ImageIndex = 1
                lvCompanies.Top = btnCompanies.Top + ButtonHeight + Spacing
                lvCompanies.Height = 0
                lvtrainings.Top = btnCompanies.Top

                ' collapsed
                btnTrainings.ImageIndex = 1
                btnTrainings.Top = btnCompanies.Top + ButtonHeight + Spacing
                lvtrainings.Height = 0
                lvtrainings.Top = btnTrainings.Top

                'collapsed
                btEmployees.ImageIndex = 1
                btEmployees.Top = btnTrainings.Top + ButtonHeight + Spacing
                LvEmployees.Height = 0
                LvEmployees.Top = btEmployees.Top

                'collapsed
                btnUsers.ImageIndex = 1
                btnUsers.Top = btEmployees.Top + ButtonHeight + Spacing
                lvUsers.Height = 0
                lvUsers.Top = btnUsers.Top

                'expanded
                btnSettings.ImageIndex = 0
                btnSettings.Top = btnUsers.Top + ButtonHeight + Spacing
                lvSettings.Height = LvHeight
                lvSettings.Top = btnSettings.Top + ButtonHeight + Spacing

                'Button6.ImageIndex = 1 ' down
                'Button6.Top = lvSettings.Top + LvHeight + Spacing
                'ListView6.Height = 0
                'ListView6.Top = Button6.Top

                'Button7.ImageIndex = 1 ' down
                'Button7.Top = btnSettings.Top + ButtonHeight + Spacing
                'ListView7.Height = 0
                'ListView7.Top = Button7.Top

            Case 6
                ' collapsed
                btnCompanies.ImageIndex = 1
                lvCompanies.Top = btnCompanies.Top + ButtonHeight + Spacing
                lvCompanies.Height = 0
                lvtrainings.Top = btnCompanies.Top

                ' collapsed
                btnTrainings.ImageIndex = 1
                btnTrainings.Top = btnCompanies.Top + ButtonHeight + Spacing
                lvtrainings.Height = 0
                lvtrainings.Top = btnTrainings.Top

                'collapsed
                btEmployees.ImageIndex = 1
                btEmployees.Top = btnTrainings.Top + ButtonHeight + Spacing
                LvEmployees.Height = 0
                LvEmployees.Top = btEmployees.Top

                'collapsed
                btnUsers.ImageIndex = 1
                btnUsers.Top = btEmployees.Top + ButtonHeight + Spacing
                lvUsers.Height = 0
                lvUsers.Top = btnUsers.Top

                'expanded
                btnSettings.ImageIndex = 1
                btnSettings.Top = btnUsers.Top + ButtonHeight + Spacing
                lvSettings.Height = 0
                lvSettings.Top = btnSettings.Top + ButtonHeight + Spacing

                'Button6.ImageIndex = 0 ' down
                'Button6.Top = btnSettings.Top + ButtonHeight + Spacing
                'ListView6.Height = LvHeight
                'ListView6.Top = Button6.Top + ButtonHeight + Spacing

                'Button7.ImageIndex = 1 ' down
                'Button7.Top = btnSettings.Top + ButtonHeight + Spacing
                'ListView7.Height = 0
                'ListView7.Top = Button7.Top

            Case 7

        End Select


    End Sub
    Private Sub Organizecontrols()
        Dim LeftForAll As Integer = btnCompanies.Left

        btnCompanies.Height = ButtonHeight

        btnTrainings.Height = ButtonHeight
        btnTrainings.Left = LeftForAll
        btnTrainings.Width = btnCompanies.Width

        btEmployees.Height = ButtonHeight
        btEmployees.Left = LeftForAll
        btEmployees.Width = btnCompanies.Width

        btnUsers.Height = ButtonHeight
        btnUsers.Left = LeftForAll
        btnUsers.Width = btnCompanies.Width
        btnSettings.Height = ButtonHeight
        btnSettings.Left = LeftForAll
        btnSettings.Width = btnCompanies.Width
        lvCompanies.Left = LeftForAll
        lvCompanies.Width = btnCompanies.Width
        lvtrainings.Left = LeftForAll
        lvtrainings.Width = btnCompanies.Width
        LvEmployees.Left = LeftForAll
        LvEmployees.Width = btnCompanies.Width
        lvUsers.Left = LeftForAll
        lvUsers.Width = btnCompanies.Width
        lvSettings.Left = LeftForAll
        lvSettings.Width = btnCompanies.Width
        Call runMenu(1)
    End Sub
#End Region

#Region "Form Events"

    Private Sub Main_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
        'If My.Settings.MainsplitterLocation <> SplitContainer1.SplitterDistance Then
        ' update the value
        'Settings.MainsplitterLocation = SplitContainer1.SplitterDistance
        'Persist values
        '  My.Settings.Save()
        '  End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Selection = 1
        'SplitContainer1.SplitterDistance = My.Settings.MainsplitterLocation
        ' Me.WindowState = FormWindowState.Maximized
        ' Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Call Organizecontrols()
        Call runMenu(1)
    End Sub
    Private Sub Main_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        ' SplitContainer1.SplitterDistance = My.Settings.MainsplitterLocation ' keep the distance
        Call runMenu(Selection)
    End Sub
#End Region

#Region " ListviewsIndexchange"

    'Private Sub lvCompanies_Click(sender As System.Object, e As System.EventArgs) Handles lvCompanies.Click

    '    ' MsgBox(lvCompanies.SelectedItems(0).Text)

    '    Select Case lvCompanies.SelectedItems(0).Text
    '        Case "Audit Log"
    '            Dim f As New AuditLog
    '            f.TopLevel = False
    '            Me.SplitContainer1.Panel2.Controls.Add(f)
    '            f.Dock = DockStyle.Fill
    '            f.Show()
    '        Case "Employees"
    '            Dim f As New Employees
    '            f.TopLevel = False
    '            Me.SplitContainer1.Panel2.Controls.Add(f)
    '            f.Show()
    '        Case "Passwords"

    '        Case "Privileges"

    '        Case "Errors Log"
    '            Dim f As New ErrorLogsConsult
    '            f.TopLevel = False
    '            Me.SplitContainer1.Panel2.Controls.Add(f)
    '            f.Dock = DockStyle.Fill
    '            f.Show()
    '        Case "Customers"


    '        Case Else
    '            ' oops should not happen

    '    End Select


    '    '  MsgBox(lvCompanies.SelectedItems(0).Text)



    'End Sub

    'Private Sub lvtrainings_Click(sender As System.Object, e As System.EventArgs) Handles lvtrainings.Click
    '    MsgBox(lvtrainings.SelectedItems(0).Text)

    '    Select Case lvtrainings.SelectedItems(0).Text

    '        Case "Inventory"
    '            Dim f As New Inventory
    '            f.TopLevel = False
    '            Me.SplitContainer1.Panel2.Controls.Add(f)
    '            f.Dock = DockStyle.Fill
    '            f.Show()
    '        Case ""

    '        Case ""
    '        Case Else

    '    End Select

    'End Sub

    'Private Sub LvEmployees_Click(sender As System.Object, e As System.EventArgs) Handles LvEmployees.Click
    '    ' MsgBox(LvEmployees.SelectedItems(0).Text)

    '    Select Case LvEmployees.SelectedItems(0).Text

    '        Case "Create Invoice"
    '            Dim f As New CreateInvoice
    '            f.TopLevel = False
    '            Me.SplitContainer1.Panel2.Controls.Add(f)
    '            f.Dock = DockStyle.Fill
    '            f.Show()
    '        Case ""

    '        Case ""
    '        Case Else

    '    End Select

    'End Sub

    'Private Sub lvUsers_Click(sender As System.Object, e As System.EventArgs) Handles lvUsers.Click
    '    MsgBox(lvUsers.SelectedItems(0).Text)
    'End Sub

    'Private Sub lvSettings_Click(sender As System.Object, e As System.EventArgs) Handles lvSettings.Click

    '    Select Case lvSettings.SelectedItems(0).Text
    '        Case "Settings"
    '            Dim f As New Settings
    '            f.TopLevel = False
    '            Me.SplitContainer1.Panel2.Controls.Add(f)
    '            ' f.Width = Me.SplitContainer1.Panel2.Width
    '            ' f.Height = Me.SplitContainer1.Panel2.Height
    '            f.Dock = DockStyle.Fill
    '            f.Show()
    '        Case "Options"
    '            Dim f As New Options
    '            f.TopLevel = False
    '            Me.SplitContainer1.Panel2.Controls.Add(f)
    '            ' f.Width = Me.SplitContainer1.Panel2.Width
    '            ' f.Height = Me.SplitContainer1.Panel2.Height
    '            f.Dock = DockStyle.Fill
    '            f.Show()
    '        Case "Security"
    '            Dim f As New Security
    '            f.TopLevel = False
    '            Me.SplitContainer1.Panel2.Controls.Add(f)
    '            ' f.Width = Me.SplitContainer1.Panel2.Width
    '            ' f.Height = Me.SplitContainer1.Panel2.Height
    '            f.Dock = DockStyle.Fill
    '            f.Show()

    '    End Select



    'End Sub

#End Region


    'Private Sub GetFOrmInPanel()
    '    If Me.SplitContainer1.Panel2.Contains(AuditLog) Then
    '        MsgBox("AUditLog found")
    '    End If
    'End Sub


    Private Sub GetOpenedForms()
        Dim frm As Form


        ' either check them all like this:
        Dim frmList() As String
        Dim i As Integer = 0 ' counter

        For Each frm In My.Application.OpenForms
            ReDim Preserve frmList(i)
            frmList(i) = frm.Name
            i += 1
        Next

        For j As Integer = 0 To i - 1
            ' do my thing
        Next


        ' or check if one is opened especially


        ' For Each frm In My.Application.OpenForms

        ' If frm Is My.Forms.AuditLog Then
        'do something
        '  End If
        ' Next

    End Sub


#Region "Fill the menu according to privileges and authorizations"

    Private Sub GetUserPrivileges()
        Select Case Claim

            Case "Basic"

            Case "Advanced"

            Case "Admin"

            Case "Intermediate"

            Case "GodMode"


        End Select
        'ideally, the listviews will be loaded from here with the items ( text & image) linking to the corresponding forms.
        ' Those listviews will then be filled according to claims/authorizations, showing the user the  tools appropriate to his/her functions.
    End Sub
    Private Sub FillOfficeListView()
        ' Now that the list is determined in getusersprivileges, pass all 'objects' to be added to the listview.
        '  If the object can be displayed, then load it with its appropriate picture index or key...
    End Sub

#End Region



    Private Sub lvCompanies_Click(sender As System.Object, e As System.EventArgs) Handles lvCompanies.Click
        OpenForm(lvCompanies.SelectedItems(0).Text())
    End Sub

    Private Sub lvtrainings_Click(sender As System.Object, e As System.EventArgs) Handles lvtrainings.Click
        OpenForm(lvtrainings.SelectedItems(0).Text())
    End Sub

    Private Sub LvEmployees_Click(sender As System.Object, e As System.EventArgs) Handles LvEmployees.Click
        OpenForm(LvEmployees.SelectedItems(0).Text())
    End Sub

    Private Sub lvUsers_Click(sender As System.Object, e As System.EventArgs) Handles lvUsers.Click
        OpenForm(lvUsers.SelectedItems(0).Text())
    End Sub

    Private Sub lvSettings_Click(sender As System.Object, e As System.EventArgs) Handles lvSettings.Click
        OpenForm(lvSettings.SelectedItems(0).Text())
    End Sub

    ' Private Sub ListView6_Click(sender As System.Object, e As System.EventArgs) Handles ListView6.Click
    ' OpenForm(ListView6.SelectedItems(0).Text())
    ' End Sub


    Private Sub OpenForm(formtoopen As String)
        Try
            Select Case LCase(formtoopen)

                Case "store credit"

                    Dim newForm As New Login
                    ' newForm = New BetterSCGeneral
                    newForm.TopLevel = False
                    '  Me.SplitContainer1.Panel2.Controls.Add(newForm)
                    ' newForm.Top = Me.SplitContainer1.Panel2.Height / 2 - newForm.Height / 2 + 5
                    ' newForm.Left = Me.SplitContainer1.Panel2.Width / 2 - newForm.Width / 2 - 5
                    newForm.Show()
                    newForm = Nothing

                Case "create or edit customer account"

                    Dim newForm As New Form
                    ' newForm = New CustomersWIP
                    newForm.TopLevel = False
                    ' Me.SplitContainer1.Panel2.Controls.Add(newForm)
                    '  newForm.Top = Me.SplitContainer1.Panel2.Height / 2 - newForm.Height / 2 + 5
                    '  newForm.Left = Me.SplitContainer1.Panel2.Width / 2 - newForm.Width / 2 - 5
                    newForm.Show()
                    newForm = Nothing

                Case "merge duplicate accounts"

                    Dim newForm As New Form
                    'newForm = New MergeCustomerAccounts
                    newForm.TopLevel = False
                    '  Me.SplitContainer1.Panel2.Controls.Add(newForm)
                    'newForm.Top = Me.SplitContainer1.Panel2.Height / 2 - newForm.Height / 2 + 5
                    ' newForm.Left = Me.SplitContainer1.Panel2.Width / 2 - newForm.Width / 2 - 5
                    newForm.Show()
                    newForm = Nothing

                Case "options"

                Case "settings"
                    Dim newForm As New Form
                    ' newForm = New Settings
                    newForm.TopLevel = False
                    '  Me.SplitContainer1.Panel2.Controls.Add(newForm)

                    ' newForm.Top = Me.SplitContainer1.Panel2.Height / 2 - newForm.Height / 2 + 5
                    ' newForm.Left = Me.SplitContainer1.Panel2.Width / 2 - newForm.Width / 2 - 5
                    newForm.Show()

                    newForm = Nothing

                Case "items list"


                Case "visits over time"
                    Dim newForm As New Login
                    ' newForm = New Visits
                    newForm.TopLevel = False
                    ' Me.SplitContainer1.Panel2.Controls.Add(newForm)
                    ' newForm.Top = Me.SplitContainer1.Panel2.Height / 2 - newForm.Height / 2 + 5
                    ' newForm.Left = Me.SplitContainer1.Panel2.Width / 2 - newForm.Width / 2 - 5
                    newForm.Show()
                    newForm = Nothing

                Case "visitors count"
                    Dim newForm As New Form
                    'newForm = New visitors
                    newForm.TopLevel = False
                    '  Me.SplitContainer1.Panel2.Controls.Add(newForm)
                    ' newForm.Top = Me.SplitContainer1.Panel2.Height / 2 - newForm.Height / 2 + 5
                    ' newForm.Left = Me.SplitContainer1.Panel2.Width / 2 - newForm.Width / 2 - 5
                    newForm.Show()
                    newForm = Nothing

                Case Else
                    MsgBox(formtoopen)
            End Select


        Catch ex As ArgumentOutOfRangeException ' formtoopen doesn't exist: all 'misclicks' end here.

            Exit Sub
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub
End Class