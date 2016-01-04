Public Class Login

    Dim TextColor As Color = Color.FromArgb(67, 122, 198)
    Dim TransparencyColor As Color = Color.FromArgb(255, 30, 213)
    Dim SecondaryTextClor As Color = Color.FromArgb(63, 63, 63)
    Dim BackGndColor As Color = Color.Black


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim User As String = UsernameTextBox.Text
        Dim pw As String = PasswordTextBox.Text
        Dim Claim As String = ""

        If DAL.Tools.LogIn(User, pw, Claim) Then
            Dim Appform As New MenuForm(User, Claim)
            Appform.Show()
            Me.Close()
        Else
            testerca()
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load

        ApplicationTitle.ForeColor = TextColor
        Description.ForeColor = TextColor
        UsernameLabel.ForeColor = TextColor
        PasswordLabel.ForeColor = TextColor
        OK.ForeColor = TextColor
        Cancel.ForeColor = TextColor

        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Description.Text = My.Application.Info.Description

    End Sub



    Private Sub testerca()
        Dim f As New MenuForm(1, "Test")
        Try
            With f
                .Width = 159
                '.Location = Me.PointToScreen(New Point(150, 150))
                .Left = 180
                ' .Show()
                .ShowDialog()
            End With
        Finally
            ' f.Dispose()
        End Try
    End Sub
End Class
