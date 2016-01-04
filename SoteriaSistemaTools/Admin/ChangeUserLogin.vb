Imports System.Data.SqlClient

Public Class ChangeUSerLogin

#Region "Declarations"
    Dim GeneralDA As New SqlDataAdapter
    Dim UsersDT As New DataTable("Users")
    Dim StoredLogin As String
    Dim DGVSelection As Integer
#End Region

#Region "User click Events"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim result As Integer = 0
        ListBox1.Items.Add("Login Change Detected")
        result = DAL.Tools.SaveExistingUserLoginchange(Convert.ToInt32(tbreTypedLogin.Text), tbProposedLogin.Text)
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

    Private Sub tbProposedLogin_Leave(sender As Object, e As EventArgs) Handles tbProposedLogin.Leave
        If sender.text.length = 0 Then
            Exit Sub
        Else
            tbreTypedLogin.Focus()
        End If
    End Sub

    Private Sub tbProposedLogin_Enter(sender As Object, e As EventArgs) Handles tbProposedLogin.Enter
        If tbProposedLogin.Text.Length > 0 Then
            tbProposedLogin.Enabled = False
        End If
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
            tbUserID.Text = dgvUsers.SelectedRows(0).Cells(0).Value.ToString
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
        tbProposedLogin.Text = ""
        tbreTypedLogin.Text = ""
    End Sub

    Private Sub DisplayButtons(status As Boolean)
        btnCancel.Visible = status
        btnValidate.Visible = status
    End Sub

    Private Sub VerifyEnteredLogin(sender As Object, e As EventArgs) Handles tbreTypedLogin.Leave
        If sender.text.length = 0 Then
            Exit Sub
        Else
            Dim MessagetoDisplay As String = ""
            Select Case BAL.Verifications.IsLoginValid(sender.text.ToString, MessagetoDisplay)
                Case True
                    DisplayButtons(True)
                Case False
                    sender.focus()
                    ClearDisplay()
            End Select
            ListBox1.Items.Add(MessagetoDisplay)
        End If
    End Sub

#End Region


#Region "Form Level Events"

    Private Sub ChangeUserLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        LaunchForm()
    End Sub


#End Region



End Class