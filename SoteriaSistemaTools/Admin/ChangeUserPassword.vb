Imports System.Data.SqlClient
Public Class ChangeUserPassword


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
        Dim PassHashed As String = ""
        Dim result As Integer = 0
        PassHashed = DAL.Creds.CreateHash(tbPw.Text)
        result = DAL.Tools.SaveExistingUserPasswordChange(Convert.ToInt32(tbUserID.Text), PassHashed)
        Select Case result
            Case 0 ' oops
                ListBox1.Items.Add("An inconsistency has arisen. Password was not changed.")
            Case 1 ' pk, password changed

            Case Else 'oops
                ListBox1.Items.Add("A Major issue has been detected. Several users' passwords have been changed.")
        End Select
        ListBox1.Items.Clear()
        DisplayButtons(False)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearDisplay() ' no information relating to the user needs to be displayed.
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
        tbPw.Text = ""
        tbpwRetype.Text = ""
    End Sub

    Private Sub DisplayButtons(status As Boolean)
        btnCancel.Visible = status
        btnValidate.Visible = status
    End Sub

#End Region


#Region "Form Level Events"
    Private Sub ChangeUserPassword_Load(sender As Object, e As EventArgs) Handles Me.Load
        LaunchForm()
    End Sub
#End Region



    Private Sub CheckIfPasswordsMatch()
        Select Case BAL.Verifications.StringMatch(tbpwRetype.Text, tbPw.Text, True)
            Case True ' passwords match
                ListBox1.Items.Add("Password is valid")
                DisplayButtons(True)
            Case False ' passwords do not match
                ListBox1.Items.Add("Password is not valid.No special characters allowed.")
                ClearDisplay()
                tbPw.Focus()
        End Select
    End Sub

    Private Sub tbPw_Validated(sender As Object, e As EventArgs) Handles tbPw.Validated
        tbpwRetype.Enabled = True
        tbpwRetype.Focus()
    End Sub

    Private Sub tbpwRetype_Validated(sender As Object, e As EventArgs) Handles tbpwRetype.Validated
        CheckIfPasswordsMatch()
    End Sub
End Class