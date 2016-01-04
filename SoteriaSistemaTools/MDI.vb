Imports System.Windows.Forms

Public Class MDI
    ' The code for the menu is contained in the menuclass.
    Private m_ChildFormNumber As Integer = 0

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub



    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            MenuClass.Initialize(Me.SplitContainer1.Panel1, 2)
        Catch ex As Exception
        End Try


    End Sub
    Private Sub AttachMenucontrolstoPanel()
        For Each ctrl As Control In Me.SplitContainer1.Panel1.Controls
            ctrl.Anchor = AnchorStyles.Left + AnchorStyles.Right
        Next

    End Sub

End Class
