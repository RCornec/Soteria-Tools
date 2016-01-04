Imports System.Data.SqlClient

Public Class CompanyInfos

    Private Structure Level
        Dim nodeCsid As Integer
        Dim oldParentCsid As Integer
        Dim newParentCsid As Integer
        Dim oldLevelRank As Integer
        Dim newLevelRank As Integer
        Dim newNodeName As String
    End Structure

#Region "Declarations"

    Dim connString As String = "Data Source= 104.171.4.189,1433; network library=DBMSSOCN; Initial Catalog=Soteria; User ID=NormalUser; Password=5&{YJ~N.93zt:PMK;"
    Dim results As New DataTable
    Dim coursesList As New DataTable
    Dim targetNode As TreeNode
    Dim movedNode As New Level
    Dim newNode As New Level
    Dim isNewMoveOk As Boolean
#End Region


    Private Sub ComboBoxCompanies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCompanies.SelectedIndexChanged

        TreeView1.Nodes.Clear()
        FillDataTable()
        CreateTree()
        TreeView1.ExpandAll()
    End Sub


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


    Private Sub CompanyInfos_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillcomboBoxCompanies()
    End Sub
End Class