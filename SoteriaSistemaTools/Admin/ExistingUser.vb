Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography


Public Class ExistingUser

    ' The following constants may be changed without breaking existing hashes.
    Public Const SALT_BYTE_SIZE As Integer = 24
    Public Const HASH_BYTE_SIZE As Integer = 24
    Public Const PBKDF2_ITERATIONS As Integer = 1000

    Public Const ITERATION_INDEX As Integer = 0
    Public Const SALT_INDEX As Integer = 1
    Public Const PBKDF2_INDEX As Integer = 2



#Region "Declarations"
    Dim GeneralDA As New SqlDataAdapter
    Dim Users As DataSet = New DataSet
    Dim UsersDT As New DataTable("Users")
    Dim UsersHand As Boolean ' determines if the user has 'caused' an event to fire. Avoids checks at form creation time that would otherwise throw errors.
    Dim namechange, Loginchange, Pwchange As Boolean
#End Region

#Region "Form level Events"
    Private Sub Existing_User_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LaunchForm()
    End Sub
#End Region

#Region "Buttons Clicks Events"
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ListBox1.Items.Clear()
        Dim PassHashed As String = ""
        Dim result As Integer = 0
        Try
            If namechange = True Then
                ListBox1.Items.Add("Name Change Detected")
                tbFullName.Text = tbFirstName.Text & " " & tbLastName.Text
                result = DAL.Tools.SaveExistingUserNamechange(Convert.ToInt32(tbUserID.Text), tbFullName.Text)
                namechange = False
            End If

            If Loginchange = True Then
                ListBox1.Items.Add("Login Change Detected")
                tbActualLogin.Text = tbProposedLogin.Text
                result = DAL.Tools.SaveExistingUserLoginchange(Convert.ToInt32(tbUserID.Text), tbActualLogin.Text)
                Loginchange = False
            End If

            If Pwchange = True Then
                ListBox1.Items.Add("Password Change Detected")
                PassHashed = DAL.Creds.CreateHash(tbPw.Text)
                result = DAL.Tools.SaveExistingUserPasswordChange(Convert.ToInt32(tbUserID.Text), PassHashed)
                Pwchange = False
            Else

            End If

            Select Case result
                Case 1 ' one row updated, everything is good
                    MsgBox("User Information Updated successfully!")
                Case 0 ' no row updated: error
                    MsgBox("An inconstency has arisen, user information update was unsuccessful!")
                Case Else ' multiple rows updated, big problem !
                    MsgBox("Several users have seen their infromation updated. Please contact an Admin immediately!")
            End Select

            Call LaunchForm()
            dgvUsers.Focus()
            DisplayButtons(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        displaySelectdUserInfos()
        DisplayButtons(False)
    End Sub
#End Region

#Region "Datagridview"
    ' DataGridView user Events
    Private Sub dgvUsers_Click(sender As Object, e As EventArgs) Handles dgvUsers.Click
        Try
            AllowWork(True)
            UsersHand = True
            displaySelectdUserInfos()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "From DGVUsers_Click")
        End Try
    End Sub
    ' relateld methods
    Private Sub FormatdgvUsers()
        With dgvUsers
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersVisible = False
            .Columns(0).Visible = False
            .Columns(1).Width = 90
            .Columns(1).HeaderText = "Login"
            .Columns(2).Width = 150
            .Columns(2).HeaderText = "User Name"
            .Columns(3).Width = 150
            .Columns(3).Visible = False
            .Columns(4).Width = 150
            .Columns(4).Visible = False
        End With
    End Sub
    Private Sub displaySelectdUserInfos()
        Try
            ClearDisplay()
            If UsersHand Then
                tbUserID.Text = dgvUsers.SelectedRows(0).Cells(0).Value.ToString
                Dim FullName As String = dgvUsers.SelectedRows(0).Cells(2).Value.ToString
                tbActualLogin.Text = dgvUsers.SelectedRows(0).Cells(1).Value.ToString
                ' check for middle names
                tbFullName.Text = FullName
                Select Case BAL.Verifications.CountWords(FullName)

                    Case 1
                        tbFirstName.Text = FullName
                    Case Else
                        Dim firstpart As String = FullName.Substring(0, FullName.LastIndexOf(" "))
                        Dim lastpart As String = FullName.Substring(FullName.LastIndexOf(" ") + 1)
                        tbFirstName.Text = firstpart
                        tbLastName.Text = lastpart
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "DisplaySelectedUserInfos")
        End Try
    End Sub
#End Region

#Region "Subs and functions Called By multiple sources"
    Private Sub LaunchForm()
        SetTriggers()
        UsersHand = False
        Try
            UsersDT = DAL.Tools.LoadUsers
            dgvUsers.DataSource = UsersDT
            FormatdgvUsers()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Launchform")
        Finally
            dgvUsers.ClearSelection()
            AllowWork(False)
            UsersHand = True
        End Try
    End Sub

    Private Sub AllowWork(status As Boolean)
        ' Edition should be available on ly after a user has been selected
        Dim allTxt As New List(Of Control)
        For Each txt As TextBox In FindControlRecursive(allTxt, Me, GetType(TextBox))
            If txt.Tag = "Open" Then
                txt.Enabled = status
            End If
        Next

    End Sub
    Private Sub SetTriggers()
        UsersHand = False
        namechange = False
        Loginchange = False
        Pwchange = False
    End Sub
    Private Sub ClearDisplay()
        ' Clear Cells
        tbUserID.Text = ""
        tbFullName.Text = ""
        tbFirstName.Text = ""
        tbLastName.Text = ""
        tbActualLogin.Text = ""
        tbProposedLogin.Text = ""
        tbPw.Text = ""
        tbpwRetype.Text = ""
        ' Also hide and reset feedback relateld controls
        pbLogin.Image = Nothing
        pbLogin.Visible = False
        LabelLogin.Visible = False
        pbpw.Image = Nothing
        pbpw.Visible = False
        LabelPW.Visible = False
        pbName.Visible = False
        pbName.Image = Nothing
        LabelName.Visible = False
    End Sub
#End Region

#Region "User Triggered Events From Controls"
    Private Sub tbPw_Validated(sender As Object, e As EventArgs) Handles tbPw.Validated
        With tbpwRetype
            .Enabled = True
            .Focus()
        End With
        tbPw.Enabled = False

        LabelPW.Text = "Please retype password"
    End Sub

    Private Sub TbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim tmptext As String = tbSearch.Text.Trim
        Select Case tmptext.Length
            Case 0  ' show entire list
                dgvUsers.DataSource = UsersDT
                FormatdgvUsers()
                UsersHand = False ' prevents any attempt to display user's infos when no user is selected
            Case Else ' show filtered list
                Dim dv As New DataView(UsersDT)
                dv.RowFilter = String.Concat("CONVERT(", "UserName", ", System.String) LIKE '%", tmptext, "%'")
                dgvUsers.DataSource = dv
                If dv.Count > 0 Then
                    UsersHand = True
                Else
                    UsersHand = False
                End If

        End Select
    End Sub
    Private Sub tbpwRetype_Leave(sender As Object, e As EventArgs) Handles tbpwRetype.Leave
        CheckIfPasswordsMatch(sender)
    End Sub
#End Region

#Region "checks and other validation algorithms"
    Private Sub CheckIfPasswordsMatch(Sender As Object)
        Select Case BAL.Verifications.StringMatch(tbpwRetype.Text, tbPw.Text, True)
            Case True ' passwords match
                SendFeedback(True, "the 2 passwords are identical", Sender, pbpw, LabelPW)
                Pwchange = True
            Case False ' passwords do not match
                SendFeedback(False, "The 2 passwords do not match", Sender, pbpw, LabelPW)
        End Select
    End Sub
    Private Sub VerifyEnteredName(sender As Object, e As EventArgs) Handles tbFirstName.Leave, tbLastName.Leave
        Dim messageToDisplay As String = "No invalid Characters Present"
        If sender.text.length = 0 Then
            Exit Sub
        Else
            SendFeedback(BAL.Verifications.VerifyEnteredName(sender.text.ToString, messageToDisplay), messageToDisplay, sender, pbName, LabelName)
            namechange = True
        End If
    End Sub
    Private Sub VerifyEnteredLogin(sender As Object, e As EventArgs) Handles tbActualLogin.Leave, tbProposedLogin.Leave
        If sender.text.length = 0 Then
            Exit Sub
        Else
            Dim MessagetoDisplay As String = ""
            SendFeedback(BAL.Verifications.IsLoginValid(sender.text.ToString, MessagetoDisplay), MessagetoDisplay, sender, pbLogin, LabelLogin)
            Loginchange = True
        End If
    End Sub
#End Region

#Region "Display Related Methods"
    Private Sub DisplayButtons(status As Boolean)
        btnCancel.Visible = status
        btnUpdate.Visible = status
    End Sub
    Private Sub SendFeedback(IsPositive As Boolean, Message As String, sender As Object, ReceiverPictureBox As PictureBox, ReceiverLabel As Label)
        Select Case IsPositive
            Case True
                ReceiverPictureBox.Image = My.Resources.valid
                ReceiverLabel.Text = Message
                DisplayButtons(True)
            Case Else
                ReceiverPictureBox.Image = My.Resources.invalid
                ReceiverLabel.Text = Message
                sender.Focus() 'Return Focus
                sender.Clear() 'Clear TextBox
        End Select
        ReceiverPictureBox.Visible = True
        ReceiverLabel.Visible = True
    End Sub
#End Region

#Region "Helping Methods"
    Private Function GetLogin() As String
        If tbActualLogin.Text.Length > 0 And tbProposedLogin.Text.Length = 0 Then
            Return tbActualLogin.Text
        Else
            Return tbProposedLogin.Text
        End If
    End Function

    Private Function FindControlRecursive(ByVal list As List(Of Control), ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
        If parent Is Nothing Then Return list
        If parent.GetType Is ctrlType Then
            list.Add(parent)
        End If
        For Each child As Control In parent.Controls
            FindControlRecursive(list, child, ctrlType)
        Next
        Return list
    End Function

#End Region






End Class