Public Class MenuClass
    ' I do not use percentages on purpose. I get the menu ordered by exact size: cleaner display

    Const MenuItemscount = 8
    Const Spacing = 1
    Const PredeterminedButtonHeight = 24
    Const PredeterminedListviewHeight = 0 ' they are 'closed' except when selected
    Const HorizontalSpacing = 3

    Shared ButtonText() As String = {"Companies", "Employees", "Trainings", "Classes", "Users", "Reports", "Data", "Settings"}
    Shared ListViewNames() As String = {"lvCompanies", "lvEmployees", "lvTrainings", "lvClasses", "lvUsers", "lvReports", "lvData", "lvSettings"}
    Shared NewStoredTopPoint As Integer = 3 ' Stores the top opint where the control will be placed ( allows to have all controls in a vertical order
    Shared predeterminedwidth As Integer

    shared PrivateReceivingPanel As New Panel


    Shared Sub getInfos()
        Dim i, j As Integer

        For Each ctrl As Control In PrivateReceivingPanel.Controls
            If TypeOf ctrl Is Button Then
                i += 1
            ElseIf TypeOf ctrl Is ListView Then
                j += 1
            End If
        Next
        '  MsgBox(i & " buttons found, " & j & "listviews found")
    End Sub

    Shared Sub Initialize(ReceivingPanel As SplitterPanel, SelectedMenuItem As Integer)
        predeterminedwidth = ReceivingPanel.Width - 6 ' determined by the size of the panel to fill, passed as a parameter

        ' Create controls
        For i As Integer = 0 To ButtonText.Count - 1
            Dim NewButton As New Button
            AddHandler NewButton.Click, AddressOf BtnOnclick
            With NewButton
                .Tag = i ' used later when user  clicks on menu
                .Name = "btn" & ButtonText(i).ToString
                .Left = HorizontalSpacing
                .Text = ButtonText(i).ToString
                .Height = PredeterminedButtonHeight
                .Top = NewStoredTopPoint
                .Width = predeterminedwidth - HorizontalSpacing
                NewStoredTopPoint += PredeterminedButtonHeight + Spacing
                .Anchor = AnchorStyles.Left + AnchorStyles.Right
            End With
            ReceivingPanel.Controls.Add(NewButton)

            Dim NewListView As New ListView
            With NewListView
                .Name = ListViewNames(i).ToString
                .Left = HorizontalSpacing
                .Top = NewStoredTopPoint
                .Width = predeterminedwidth - HorizontalSpacing
                .Anchor = AnchorStyles.Left + AnchorStyles.Right
                ' .Visible = False
                If SelectedMenuItem = i Then
                    .Height = SelectedLVHeight(ReceivingPanel.Height)
                    '.Visible = True
                Else
                    .Height = PredeterminedListviewHeight
                End If
                NewStoredTopPoint += NewListView.Height + Spacing
            End With
            ReceivingPanel.Controls.Add(NewListView)
        Next
        PrivateReceivingPanel = ReceivingPanel ' storage for later
    End Sub


    Private Shared Function SelectedLVHeight(PanelHeight As Integer) As Integer
        Dim combosize As Integer = Spacing + PredeterminedButtonHeight + Spacing + PredeterminedListviewHeight + Spacing
        Dim totalTakenspace As Integer = (combosize * MenuItemscount) + Spacing
        SelectedLVHeight = PanelHeight - totalTakenspace
    End Function


    Shared Sub reorganizeMenu(sender As Object)
        Dim SelectedItem As Integer = Convert.ToInt16(sender.tag)

        Dim topPoint As Integer = PrivateReceivingPanel.Top + Spacing

        For i = 0 To MenuItemscount - 1
            If i = SelectedItem Then
                GetButton(i).Top = topPoint
                topPoint += Spacing + PredeterminedButtonHeight + Spacing
                With getListView(i)
                    .Top = topPoint
                    topPoint += Spacing
                    .Height = SelectedLVHeight(PrivateReceivingPanel.Height)
                    topPoint += .Height + Spacing
                End With
            Else
                GetButton(i).Top = topPoint
                topPoint += Spacing + PredeterminedButtonHeight + Spacing
                With getListView(i)
                    .Top = topPoint
                    .Height = 0
                    topPoint += Spacing
                End With
            End If
        Next
        '  getInfos()
    End Sub


    Private Shared Sub BtnOnclick(sender As Object, e As EventArgs) Handles Me.btnClick
        reorganizeMenu(sender)
    End Sub

    Public Event btnClick(sender As Object, e As EventArgs)

    Private Shared Function GetButton(Index As Integer) As Button
        Try
            For Each btn In PrivateReceivingPanel.Controls
                If btn.name = "btn" & ButtonText(Index) Then
                    Return btn
                End If
            Next
        Catch ex As Exception
        End Try
        ' if still here, then
        Return Nothing
    End Function

    Private Shared Function getListView(index As Integer) As ListView
        Try
            For Each lv In PrivateReceivingPanel.Controls
                If lv.name = ListViewNames(index) Then
                    Return lv
                End If
            Next
        Catch ex As Exception
        End Try
        ' if still here, then
        Return Nothing
    End Function


End Class
