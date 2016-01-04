Imports System.Windows.Forms

Public Class InputBox
    ' this input box is used in the company organization/levels treeview.(in a dialogbox manner)
    Protected m_BlankValid As Boolean = True
    Protected m_ReturnText As String = ""

    Public Overloads Function ShowDialog(ByVal TitleText As String, _
   ByVal PromptText As String, _
   ByVal DefaultText As String, _
   ByRef EnteredText As String, _
   ByVal BlankValid As Boolean) As System.Windows.Forms.DialogResult

        m_BlankValid = BlankValid

        ' Me.Lbl_Prompt.Text = PromptText
        Me.Text = TitleText
        Me.Txt_TextEntry.Text = DefaultText
        Me.ShowDialog()
        EnteredText = m_ReturnText
        Return Me.DialogResult

    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.Txt_TextEntry.Text = "" Then
            Me.Bt_Ok.Enabled = m_BlankValid
        Else
            Me.Bt_Ok.Enabled = True
        End If
    End Sub



    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        m_ReturnText = ""
        Me.Close()
    End Sub


    Private Sub Bt_Ok_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Ok.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        m_ReturnText = Me.Txt_TextEntry.Text
        Me.Close()
    End Sub
End Class
