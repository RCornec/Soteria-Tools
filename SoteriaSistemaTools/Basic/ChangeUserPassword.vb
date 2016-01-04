Public Class ChangeEmployeePassword

    Private Sub tbPw_Validated(sender As Object, e As EventArgs)

    End Sub
    Private Sub tbpwRetype_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbPw_Validated_1(sender As Object, e As EventArgs) Handles tbPw.Validated

    End Sub


    'Private Sub CheckIfPasswordsMatch(Sender As Object)
    '    Select Case BAL.Verifications.StringMatch(tbpwRetype.Text, tbPw.Text, True)
    '        Case True ' passwords match
    '            SendFeedback(True, "the 2 passwords are identical", Sender, pbpw, LabelPW)
    '            Pwchange = True
    '        Case False ' passwords do not match
    '            SendFeedback(False, "The 2 passwords do not match", Sender, pbpw, LabelPW)
    '    End Select
    'End Sub

    'Private Sub SendFeedback(IsPositive As Boolean, Message As String, sender As Object, ReceiverPictureBox As PictureBox, ReceiverLabel As Label)
    '    Select Case IsPositive
    '        Case True
    '            ReceiverPictureBox.Image = My.Resources.valid
    '            ReceiverLabel.Text = Message
    '            DisplayButtons(True)
    '        Case Else
    '            ReceiverPictureBox.Image = My.Resources.invalid
    '            ReceiverLabel.Text = Message
    '            sender.Focus() 'Return Focus
    '            sender.Clear() 'Clear TextBox
    '    End Select
    '    ReceiverPictureBox.Visible = True
    '    ReceiverLabel.Visible = True
    'End Sub

End Class