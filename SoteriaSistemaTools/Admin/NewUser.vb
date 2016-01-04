Public Class NewUser



#Region "Form level Events"
    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        DAL.Tools.ConnectionTest()
    End Sub
#End Region

#Region "Button Clicks Events"
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try


            If InfoPresent() = True Then
                Dim Hashedpw As String = DAL.Creds.CreateHash(tbPw.Text)
                ' calculate salt and hash

                Dim result As Integer = DAL.Tools.SaveNewUser(tbName.Text, tbLogin.Text, Hashedpw)

                If result = 1 Then
                    MsgBox("bingo")
                ElseIf result = 0 Then
                    MsgBox("No entry created")
                Else
                    MsgBox("Oops; too many entries created (" & result & ")")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region


#Region "Control Level Events"
    Private Sub tbName_Leave(sender As Object, e As EventArgs) Handles tbName.Leave
        If sender.Text.Length < 4 Then
            LabelInfos.Text = "Name Is Too Short"
            sender.focus()
            sender.clear()
        End If
    End Sub
    Private Sub tbLogin_Leave(sender As Object, e As EventArgs) Handles tbLogin.Leave
        Dim MessageTodisplay As String = ""

        If tbLogin.Text.Length < 4 Then
            LabelInfos.Text = LabelInfos.Text & ", Login Is Too Short"
        Else
            If BAL.Verifications.IsLoginValid(tbLogin.Text, MessageTodisplay) Then
                pbLogin.Image = My.Resources.valid
                LabelInfos.Text = MessageTodisplay
            Else
                pbLogin.Image = My.Resources.invalid
                LabelInfos.Text = "Login is already in use, please select antother one!"
            End If
            ShowFeedback()
        End If

    End Sub
#End Region

#Region "Methods"
    Private Function InfoPresent() As Boolean ' redio and check at evetn's leave directly. 
        InfoPresent = True
        LabelInfos.Text = ""
        If tbName.Text.Length < 4 Then
            LabelInfos.Text = "Name Is Too Short"
            InfoPresent = False
        End If
        If tbLogin.Text.Length < 4 Then
            LabelInfos.Text = LabelInfos.Text & ", Login Is Too Short"
            InfoPresent = False
        End If
        If tbPw.Text.Length <= 5 Then
            LabelInfos.Text = LabelInfos.Text & ", Password Is Too Short"
            InfoPresent = False
        End If

    End Function
    Private Sub ShowFeedback()
        pbLogin.Visible = True
        LabelInfos.Visible = True
        pbLogin.Visible = True
        LabelInfos.Visible = True
    End Sub
#End Region

  






End Class