
Public Class ToolsDatabaseSettings

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        If DAL.Tools.ConnectionTest() = True Then
            MsgBox("Connection Test Success!")
        Else
            MsgBox("Connection Test Failed.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DAL.Tools.SaveConnectionStringData(tbServer.Text, tbPort.Text, tbDBName.Text, tbUser.Text, tbpw.Text)
        ToggleAccessTofields()
    End Sub


    Private Sub ToggleAccessTofields()
        Static Toggle As Boolean
        tbServer.Enabled = Not Toggle
        tbPort.Enabled = Not Toggle
        tbDBName.Enabled = Not Toggle
        tbUser.Enabled = Not Toggle
        tbpw.Enabled = Not Toggle
        btnChanges.Visible = Toggle
        btnSave.Visible = Not Toggle
        Toggle = Not Toggle
    End Sub

    Private Sub displayInfos()
        Dim server As String = ""
        Dim port As String = ""
        Dim dbname As String = ""
        Dim user As String = ""
        Dim pw As String = ""

        DAL.Tools.LoadConnectionStringData(server, port, dbname, user, pw)
        tbServer.Text = server
        tbPort.Text = port
        tbDBName.Text = dbname
        tbUser.Text = user
        tbpw.Text = pw
    End Sub

    Private Sub DatabaseSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        displayInfos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnChanges.Click
        ToggleAccessTofields()
    End Sub
End Class