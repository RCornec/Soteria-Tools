Imports System.Data.SqlClient

Public Class ChangeUserName

#Region "Declarations"
    Dim GeneralDA As New SqlDataAdapter
    Dim UsersDT As New DataTable("Users")
    Dim StoredFirstName As String
    Dim StoredLastName As String
    Dim DGVSelection As Integer
#End Region

#Region "User click Events"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim NewName As String = ""
        Dim result As Integer = 0
        NewName = tbFirstName.Text & " " & tbLastName.Text
        result = DAL.Tools.SaveExistingUserNamechange(Convert.ToInt32(tbUserID.Text), NewName)
        ListBox1.Items.Clear()
        DGVSelection = dgvUsers.CurrentRow.Index
        Call LaunchForm() ' update information
        DisplayButtons(False)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        displaySelectdUserInfos()
        DisplayButtons(False)
    End Sub


    Private Sub dgvUsers_Click(sender As Object, e As EventArgs) Handles dgvUsers.Click
        Try
            displaySelectdUserInfos()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "From DGVUsers_Click")
        End Try
    End Sub

#End Region

#Region "User Data Changes Related Events"
    Private Sub TbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim tmptext As String = tbSearch.Text.Trim
        Select Case tmptext.Length
            Case 0  ' show entire list
                dgvUsers.DataSource = UsersDT
                FormatdgvUsers()
                '  UserAction = False ' prevents any attempt to display user's infos when no user is selected
            Case Else ' show filtered list
                Dim dv As New DataView(UsersDT)
                dv.RowFilter = String.Concat("CONVERT(", "UserName", ", System.String) LIKE '%", tmptext, "%'")
                dgvUsers.DataSource = dv
                If dv.Count > 0 Then
                Else
                End If
        End Select
    End Sub


#End Region

#Region "Methods"

    Private Sub LaunchForm()
        ' UserAction = False
        Try
            UsersDT = DAL.Tools.LoadUsers
            dgvUsers.DataSource = UsersDT
            FormatdgvUsers()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & " In Launchform")
        Finally

            If DGVSelection < dgvUsers.Rows.Count Then ' if previous selection existed, allows to reassign selection automatically
                dgvUsers.Rows(DGVSelection).Selected = True
                dgvUsers.CurrentCell = dgvUsers.Item(1, DGVSelection)
            End If
        End Try
    End Sub

    Private Sub displaySelectdUserInfos()
        Try
            ListBox1.Items.Clear()
            ClearDisplay()
            'If UserAction Then
            tbUserID.Text = dgvUsers.SelectedRows(0).Cells(0).Value.ToString
            Dim FullName As String = dgvUsers.SelectedRows(0).Cells(2).Value.ToString
            ' check for middle names
            LabelFullName.Text = FullName
            Select Case BAL.Verifications.CountWords(FullName)
                Case 1
                    tbFirstName.Text = FullName
                Case Else
                    Dim firstpart As String = FullName.Substring(0, FullName.LastIndexOf(" "))
                    Dim lastpart As String = FullName.Substring(FullName.LastIndexOf(" ") + 1)
                    tbFirstName.Text = firstpart
                    tbLastName.Text = lastpart
            End Select
            ' End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "DisplaySelectedUserInfos")
        End Try
    End Sub

    Private Sub FormatdgvUsers()
        With dgvUsers
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersVisible = False
            .Columns(0).Visible = False
            .Columns(1).Width = 90
            .Columns(1).HeaderText = "Login"
            .Columns(2).Width = 250
            .Columns(2).HeaderText = "User Name"
            .Columns(3).Width = 150
            .Columns(3).Visible = False
            .Columns(4).Width = 150
            .Columns(4).Visible = False
        End With
    End Sub

    Private Sub ClearDisplay()
        LabelFullName.Text = ""
        tbFirstName.Text = ""
        tbLastName.Text = ""
    End Sub

    Private Sub DisplayButtons(status As Boolean)
        btnCancel.Visible = status
        btnValidate.Visible = status
    End Sub

#End Region


#Region "Form Level Events"

    Private Sub ChangeUserName_Load(sender As Object, e As EventArgs) Handles Me.Load
        LaunchForm()
    End Sub

    Private Sub tbFirstName_Enter(sender As Object, e As EventArgs) Handles tbFirstName.Enter
        StoredFirstName = tbFirstName.Text
    End Sub

    Private Sub tbLastName_Enter(sender As Object, e As EventArgs) Handles tbLastName.Enter
        StoredLastName = tbLastName.Text
    End Sub

    Private Sub tbFirstName_Validated(sender As Object, e As EventArgs) Handles tbFirstName.Validated
        If String.Compare(StoredFirstName.Trim, tbFirstName.Text.Trim, False) <> 0 Then ' 0 means strings are equal. otherwise, the result can be weither 1 or -1 
            DisplayButtons(True)
            ListBox1.Items.Add("First Name modification")
            '   UserAction = False
        End If

    End Sub

    Private Sub tbLastName_Validated(sender As Object, e As EventArgs) Handles tbLastName.Validated
        If String.Compare(StoredLastName.Trim, tbLastName.Text.Trim, False) <> 0 Then
            DisplayButtons(True)
            ListBox1.Items.Add("Last Name modification")
            '  UserAction = False
        End If
    End Sub

#End Region



End Class