Imports System.Data.SqlClient

Public Class CompanyPhysicalOrganization

    Private Structure Level
        Dim nodeCsid As Integer
        Dim oldParentCsid As Integer
        Dim newParentCsid As Integer
        Dim oldLevelRank As Integer
        Dim newLevelRank As Integer
        Dim newNodeName As String
    End Structure

#Region "Declarations"
    ' Dim connString As String = "Data Source= 104.171.4.189,1433; network library=DBMSSOCN; Initial Catalog=TestDB; User ID=Tester1; Password=LtlRsK;"
    Dim connString As String = "Data Source= 104.171.4.189,1433; network library=DBMSSOCN; Initial Catalog=Soteria; User ID=NormalUser; Password=5&{YJ~N.93zt:PMK;"
    Dim results As New DataTable
    Dim coursesList As New DataTable
    Dim targetNode As TreeNode
    Dim movedNode As New Level
    Dim newNode As New Level
    Dim isNewMoveOk As Boolean
#End Region

#Region "User Actions"

    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBoxCompanies_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles ComboBoxCompanies.SelectedIndexChanged
        TreeView1.Nodes.Clear()
        FillDataTable()
        CreateTree()
        TreeView1.ExpandAll()
    End Sub

    Private Sub TreeView1_Click(sender As System.Object, e As System.EventArgs) Handles TreeView1.Click
        TreeView1.LabelEdit = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call cancelchanges()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Call Savechanges()
    End Sub

#End Region

#Region "Loading Data"

    Private Sub FillDataTable()
        results.Reset()
        Try

            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand("SELECT CLID, LevelName, LevelParent, LevelRank FROM tblCompanyLevels WHERE CompanyId= @CompanyID ORDER BY LevelName", conn)
                    cmd.Parameters.AddWithValue("@CompanyID", Convert.ToInt32(ComboBoxCompanies.SelectedValue.ToString))
                    conn.Open()

                    Dim adapter As New SqlDataAdapter(cmd)

                    adapter.Fill(results)
                End Using
            End Using

            Dim i As Integer

            For i = 0 To results.Rows.Count - 1
                Dim ID1 As String = results.Rows(i).Item("CLID").ToString
                ' Next line useless for now, as the level rank is saved at creation of the node. Saves time (prevents recursive check every time)
                results.Rows(i).Item("LevelRank") = FindLevel(ID1, 0)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function FindLevel(ByVal ID As String, ByRef Level As Integer) As Integer
        Dim i As Integer

        For i = 0 To results.Rows.Count - 1
            Dim ID1 As String = results.Rows(i).Item("CLID").ToString
            Dim Parent1 As String = results.Rows(i).Item("LevelParent").ToString

            If ID = ID1 Then
                If Parent1 = "" Then
                    Return Level
                Else
                    Level += 1
                    FindLevel(Parent1, Level)
                End If
            End If
        Next

        Return Level
    End Function

    Private Sub FillcomboBoxCompanies()

        Try


            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim cmd As New SqlCommand("SELECT CompanyID, LevelName FROM tblCompanyLevels WHERE IsRoot = 1 ORDER BY LevelName", conn)
                Dim rs As SqlDataReader = cmd.ExecuteReader
                Dim dt As DataTable = New DataTable
                dt.Load(rs)
                ' Set  ValueMember and DisplayMember
                ' to the two columns of the returned table
                ComboBoxCompanies.ValueMember = "CompanyID"
                ComboBoxCompanies.DisplayMember = "LevelName"
                ComboBoxCompanies.DataSource = dt
            End Using 'conn

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Methods"

    Private Sub CreateTree()

        ' Display a wait cursor while the TreeNodes are being created.
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

        ' Suppress repainting the TreeView until all the objects have been created.
        TreeView1.BeginUpdate()

        ' Clear the TreeView each time the method is called.
        TreeView1.Nodes.Clear()

        Try

            Dim MaxLevel1 As Integer = CInt(Results.Compute("MAX(LevelRank)", ""))

            Dim i, j As Integer

            For i = 0 To MaxLevel1
                Dim Rows1() As DataRow = Results.Select("LevelRank = " & i)

                For j = 0 To Rows1.Count - 1
                    Dim ID1 As String = Rows1(j).Item("CLID").ToString
                    Dim Name1 As String = Rows1(j).Item("LevelName").ToString
                    Dim Parent1 As String = Rows1(j).Item("LevelParent").ToString

                    If Parent1 = "" Then
                        TreeView1.Nodes.Add(ID1, Name1)
                    Else
                        Dim TreeNodes1() As TreeNode = TreeView1.Nodes.Find(Parent1, True)

                        If TreeNodes1.Length > 0 Then
                            TreeNodes1(0).Nodes.Add(ID1, Name1)
                        End If
                    End If
                Next
            Next

            ' Begin repainting the TreeView.
            TreeView1.EndUpdate()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Reset the cursor to the default for all controls.
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Function RankLevel(ByVal Nodetocheck As TreeNode) As Integer
        Dim i As Integer = -1
        ' Walk up the tree until we find the root of the tree, keeping count of how many nodes we walk over in the process
        While Nodetocheck IsNot Nothing
            i += 1
            Nodetocheck = Nodetocheck.Parent
        End While

        Return i
    End Function

    Private Sub Toggledisplay(ToggleValue As Boolean)

        TreeView1.AllowDrop = ToggleValue
        Button1.Visible = Not ToggleValue
        Button3.Visible = Not ToggleValue
        Button2.Visible = ToggleValue
    End Sub


    Private Sub cancelchanges()
        CreateTree()
        TreeView1.ExpandAll()
        Toggledisplay(True)
    End Sub

    Private Sub Savechanges()
        Try
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand("UPDATE tblCompanyLevels SET tblCompanyLevels.LevelRank = @NodeNewRank, tblCompanyLevels.LevelParent = @NodeNewParentCSID WHERE tblCompanyLevels.CLID = @NodeCSID ;", conn)
                    cmd.Parameters.AddWithValue("@NodeNewRank", MovedNode.NewLevelRank)
                    cmd.Parameters.AddWithValue("@NodeNewParentCSID", MovedNode.NewParentCSID)
                    cmd.Parameters.AddWithValue("@NodeCSID", MovedNode.NodeCSID)
                    conn.Open()

                    Dim RowsEffected As Integer = cmd.ExecuteNonQuery()
                    ' MsgBox("No.of rows effected by update query: " & RowsEffected.ToString)

                    conn.Close()
                End Using
            End Using

            With MovedNode ' clean values for future potential use
                .NewLevelRank = vbNull
                .NewParentCSID = vbNull
                .NodeCSID = vbNull
                .OldLevelRank = vbNull
                .OldParentCSID = vbNull
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Toggledisplay(True)
        End Try
    End Sub


#End Region

#Region "form Level Events"

    Private Sub Form2_Load(sender As Object, e As System.EventArgs)
        FillcomboBoxCompanies()
        'Allow the TreeViews to be the target of a DragDrop operation
        'and populate it with some random TreeNodes for the example
        TreeView1.AllowDrop = True
        TreeView1.HideSelection = False
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs)
        If TreeView1.AllowDrop = False Then

            MsgBox("Please validate or cancel your changes before exiting this form.")
            e.Cancel = True
        End If
    End Sub

    Private Sub CreateLevels_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub CreateLevels_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Node ID: " & movedNode.nodeCsid)
        ListBox1.Items.Add("Node Name: " & movedNode.newNodeName)
        ListBox1.Items.Add("Old Level Rank: " & movedNode.oldLevelRank)
        ListBox1.Items.Add("Old Parent ID: " & movedNode.oldParentCsid)


        ' doesn't always work ( only the 1st time, but not anymore once another node has been selected)!
        ' We need to know if it a root that the user wants to delete.
        ' If so, prevent it! It can not be done from there!
        If movedNode.oldLevelRank = 0 Then
            MsgBox(" Nope!")
        Else

            Dim pt As Point = CType(sender, Form).PointToClient(New Point(e.X, e.Y))


            If pt.X > PictureBox1.Location.X And pt.X < PictureBox1.Location.X + PictureBox1.Width And pt.Y > PictureBox1.Location.Y And pt.Y < PictureBox1.Location.Y + PictureBox1.Height Then
                If MsgBox("do you want to delete the level " & movedNode.newNodeName & "?", vbExclamation + vbOKCancel, "Attention") = vbOK Then
                    DeleteNode(movedNode.nodeCsid)
                End If
            End If

        End If


    End Sub

    Private Sub CreateLevels_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        AllowDrop = True
        FillcomboBoxCompanies()

        'Allow the TreeViews to be the target of a DragDrop operation
        'and populate it with some random TreeNodes for the example
        TreeView1.AllowDrop = True
        TreeView1.HideSelection = False
    End Sub


#End Region

#Region "Drag & Drop"

    Public Sub TreeView1_ItemDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles TreeView1.ItemDrag

        'Set the drag node and initiate the DragDrop
        DoDragDrop(e.Item, DragDropEffects.Move)

    End Sub

    Public Sub TreeView1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragEnter
        Try

            'See if there is a TreeNode being dragged
            If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then
                'TreeNode found allow move effect
                e.Effect = DragDropEffects.Move
                'Save the TreeNode being dragged for potential cancelling of operation
                Dim dropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
                With movedNode
                    .nodeCsid = Convert.ToInt32(dropNode.Name)

                    .oldParentCsid = Convert.ToInt32(dropNode.Parent.Name)
                    .oldLevelRank = Convert.ToInt16(RankLevel(dropNode))
                End With
            Else
                'No TreeNode found, prevent move
                e.Effect = DragDropEffects.None
            End If

        Catch ex As NullReferenceException
            ' the node moved is root, and should not be moved
            e.Effect = DragDropEffects.None
        Catch ex As Exception

        End Try


    End Sub

    Public Sub TreeView1_DragOver(ByVal sender As System.Object, ByVal e As DragEventArgs) Handles TreeView1.DragOver ' , TreeView2.dragover ...

        'Check that there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = False Then Exit Sub

        'Get the TreeView raising the event (in case of multiple TreeViews on form)
        Dim selectedTreeview As TreeView = CType(sender, TreeView)

        'As the mouse moves over nodes, provide feedback to the user
        'by highlighting the node that is the current drop target
        Dim pt As Point = CType(sender, TreeView).PointToClient(New Point(e.X, e.Y))
        ' Dim targetNode As TreeNode = selectedTreeview.GetNodeAt(pt)
        targetNode = selectedTreeview.GetNodeAt(pt)
        'See if the targetNode is currently selected, if so no need to validate again
        If Not (selectedTreeview Is targetNode) Then
            'Select the node currently under the cursor
            selectedTreeview.SelectedNode = targetNode

            'Check that the selected node is not the dropNode and also that it
            'is not a child of the dropNode and therefore an invalid target
            Dim dropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
            Do Until targetNode Is Nothing
                If targetNode Is dropNode Then
                    e.Effect = DragDropEffects.None
                    Exit Sub
                End If
                targetNode = targetNode.Parent
            Loop
        End If

        'Currently selected node is a suitable target, allow the move
        e.Effect = DragDropEffects.Move


    End Sub

    Public Sub TreeView1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragDrop

        'Check that there is a TreeNode being dragged
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = False Then Exit Sub

        'Get the TreeView raising the event (incase multiple on form)
        Dim selectedTreeview As TreeView = CType(sender, TreeView)

        If Not selectedTreeview.SelectedNode Is Nothing Then ' otherwise, user clicked an 'empty' space in treeview
            'Get the TreeNode being dragged
            Dim dropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
            'The target node should be selected from the DragOver event
            Dim targetNode As TreeNode = selectedTreeview.SelectedNode
            Dim rank As Integer = RankLevel(targetNode) + 1
            MovedNode.NewParentCSID = Convert.ToInt32(targetNode.Name)
            MovedNode.NodeCSID = Convert.ToInt32(dropNode.Name)
            MovedNode.NewLevelRank = IIf(rank > 0, rank, vbNull)
            dropNode.Remove()
            'If there is no targetNode add dropNode to the bottom of the TreeView root
            'nodes, otherwise add it to the end of the dropNode child nodes
            If targetNode Is Nothing Then
                selectedTreeview.Nodes.Add(dropNode)
            Else
                targetNode.Nodes.Add(dropNode)
            End If
            'Ensure the newley created node is visible to the user and select it
            dropNode.EnsureVisible()
            selectedTreeview.SelectedNode = dropNode
            Toggledisplay(False)
        End If

    End Sub

#End Region

#Region "Add New Node With Right click"


    Private m_OldSelectNode As TreeNode
    Private Sub TreeView1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseUp


        ' Show menu only if Right Mouse button is clicked
        If e.Button = MouseButtons.Right Then

            ' Point where mouse is clicked
            Dim p As Point = New Point(e.X, e.Y)

            ' Go to the node that the user clicked
            Dim node As TreeNode = TreeView1.GetNodeAt(p)
            If Not node Is Nothing Then

                ' Highlight the node that the user clicked.
                ' The node is highlighted until the Menu is displayed on the screen
                m_OldSelectNode = TreeView1.SelectedNode
                TreeView1.SelectedNode = node

                Dim Result As String = ResultInputBox()
                Select Case Result

                    Case vbEmpty
                        ' do nothing, cancelled by user
                    Case Else
                        NewNode.NewLevelRank = RankLevel(node.Parent) + 1
                        NewNode.NewParentCSID = node.Name
                        NewNode.NewNodeName = Result
                        AddEntitytoTable()
                End Select


                ' Find the appropriate ContextMenu based on the highlighted node
                Select Case node.Tag
                    Case "TextFile"
                        '  mnuTextFile.Show(TreeView1, p)
                    Case "File"
                        ' mnuFile.Show(TreeView1, p)
                End Select

                ' Highlight the selected node
                TreeView1.SelectedNode = m_OldSelectNode
                m_OldSelectNode = Nothing

            End If
        End If
    End Sub

    Private Function ResultInputBox() As String
        Dim TextReturned As String = ""
        Dim DialogInputBox As New InputBox

        If DialogInputBox.ShowDialog("Dialog", "Please enter the New entity's Name", "Default", TextReturned, False) = Windows.Forms.DialogResult.Cancel Then
            Return vbEmpty
        Else
            Return TextReturned
        End If

    End Function


    Private Sub AddEntitytoTable()
        Try
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand("INSERT INTO tblCompanyLevels ( CompanyId, LevelName, LevelRank, LevelParent ) SELECT @companyID , @NewNodeName, @NewRank, @NodeParentCSID; ", conn)
                    cmd.Parameters.AddWithValue("@companyID", ComboBoxCompanies.SelectedValue)
                    cmd.Parameters.AddWithValue("@NewNodeName", NewNode.NewNodeName)
                    cmd.Parameters.AddWithValue("@NewRank", NewNode.NewLevelRank)
                    cmd.Parameters.AddWithValue("@NodeParentCSID", NewNode.NewParentCSID)
                    conn.Open()

                    Dim RowsEffected As Integer = cmd.ExecuteNonQuery()
                    'MsgBox("No.of rows effected by Insert query: " & RowsEffected.ToString)

                    conn.Close()
                End Using
            End Using

            With MovedNode ' clean values for future potential use
                .NewLevelRank = vbNull
                .NewParentCSID = vbNull
                .NodeCSID = vbNull
                .OldLevelRank = vbNull
                .OldParentCSID = vbNull
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            TreeView1.AllowDrop = True
        End Try

        TreeView1.Nodes.Clear()
        FillDataTable()
        CreateTree()
        TreeView1.ExpandAll()
        Toggledisplay(True)

    End Sub


#End Region

#Region "Edit Node Name"

    Dim mySelectedNode As TreeNode

    Private Sub treeView1_AfterLabelEdit(sender As Object, _
  e As System.Windows.Forms.NodeLabelEditEventArgs) Handles TreeView1.AfterLabelEdit
        If Not (e.Label Is Nothing) Then
            If e.Label.Length > 0 Then
                If e.Label.IndexOfAny(New Char() {"@"c, "."c, ","c, "!"c}) = -1 Then
                    ' Stop editing without canceling the label change.
                    e.Node.EndEdit(False)
                    UpdateNodeName(e.Label, e.Node.Name)
                Else
                    ' Cancel the label edit action, inform the user, and 
                    ' place the node in edit mode again. 
                    e.CancelEdit = True
                    MessageBox.Show("Invalid tree node label." & _
                      Microsoft.VisualBasic.ControlChars.Cr & _
                      "The invalid characters are: '@','.', ',', '!'", _
                      "Node Label Edit")
                    e.Node.BeginEdit()
                End If
            Else
                ' Cancel the label edit action, inform the user, and 
                ' place the node in edit mode again. 
                e.CancelEdit = True
                MessageBox.Show("Invalid tree node label." & _
                  Microsoft.VisualBasic.ControlChars.Cr & _
                  "The label cannot be blank", "Node Label Edit")
                e.Node.BeginEdit()
            End If
        End If
        TreeView1.LabelEdit = False
    End Sub

    Private Sub treeView1_MouseDown(sender As Object, _
      e As System.Windows.Forms.MouseEventArgs)
        mySelectedNode = TreeView1.GetNodeAt(e.X, e.Y)
    End Sub

    Private Sub menuItem1_Click(sender As Object, e As System.EventArgs)
        If Not (mySelectedNode Is Nothing) And _
          Not (mySelectedNode.Parent Is Nothing) Then
            TreeView1.SelectedNode = mySelectedNode
            TreeView1.LabelEdit = True
            If Not mySelectedNode.IsEditing Then
                mySelectedNode.BeginEdit()
            End If
        Else
            MessageBox.Show("No tree node selected or selected node is a root node." & _
              Microsoft.VisualBasic.ControlChars.Cr & _
              "Editing of root nodes is not allowed.", "Invalid selection")
        End If
    End Sub

    Dim sNodeText As String
    Private Sub TreeView1_BeforeLabelEdit()
        ' If the label is not empty store the string
        If Len(TreeView1.SelectedNode.Text) > 0 Then
            sNodeText = TreeView1.SelectedNode.Text
        End If
    End Sub
    Private Sub TreeView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ' If the user hits the Esc key then restore 
        '   the old label
        If e.KeyCode = Keys.Escape Then
            TreeView1.SelectedNode.Text = sNodeText
        End If
    End Sub


    Private Sub UpdateNodeName(newNodeName As String, nodeCsid As Integer)

        Try
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand("UPDATE tblCompanyLevels SET tblCompanyLevels.LevelName = @NewNodeName WHERE tblCompanyLevels.CLID = @NodeCSID ;", conn)
                    cmd.Parameters.AddWithValue("@NewNodeName", newNodeName)
                    cmd.Parameters.AddWithValue("@NodeCSID", nodeCSID)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    'Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    'MsgBox("No.of rows effected by update query: " & RowsEffected.ToString)

                    conn.Close()
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            TreeView1.AllowDrop = True
        End Try

        TreeView1.Nodes.Clear()
        FillDataTable()
        CreateTree()
        TreeView1.ExpandAll()
        Toggledisplay(True)
    End Sub

#End Region

    Public Sub DeleteNode(nodeID As Int32)
        Try
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand("DELETE FROM tblCompanyLevels WHERE tblCompanyLevels.CLID = @LevelCLID;", conn)
                    cmd.Parameters.AddWithValue("@LevelCLID", nodeID)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    'Dim rowsEffected As Integer = cmd.ExecuteNonQuery()
                    'MsgBox("No.of rows effected by Insert query: " & RowsEffected.ToString)
                    conn.Close()
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            TreeView1.AllowDrop = True
        End Try

        TreeView1.Nodes.Clear()
        FillDataTable()
        CreateTree()
        TreeView1.ExpandAll()
        Toggledisplay(True)
    End Sub


End Class
