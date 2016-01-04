Public NotInheritable Class SplashScreen


    Dim TextColor As Color = Color.FromArgb(67, 122, 198)
    Dim TransparencyColor As Color = Color.FromArgb(255, 30, 213)
    Dim SecondaryTextClor As Color = Color.FromArgb(63, 63, 63)
    Dim BackGndColor As Color = Color.Black


    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.TransparencyKey = TransparencyColor
        Me.ToolBoxLabel.ForeColor = SecondaryTextClor
        Me.PictureBox1.BackColor = BackGndColor
        Me.PictureBox2.BackColor = BackGndColor
        Me.ApplicationTitle.ForeColor = TextColor
        Me.Version.ForeColor = TextColor
        Me.Copyright.ForeColor = TextColor
        Me.Description.ForeColor = TextColor

        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Description.Text = My.Application.Info.Description
        Copyright.Text = My.Application.Info.Copyright
    End Sub

End Class
