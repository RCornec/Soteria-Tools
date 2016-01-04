Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings

Public Class Tools

#Region "functions done"

    Public Shared Function SaveConnectionStringData(Server As String, port As String, DBName As String, User As String, pw As String) As Boolean
        Try

            Dim changeOccured As Boolean = False

            If Not String.Equals(My.Settings.Server, Server) Then
                Global.DAL.My.Settings.Server = Server
                changeOccured = True
            End If

            If Not String.Equals(My.Settings.Port, port) Then
                Global.DAL.My.Settings.Port = port
                changeOccured = True
            End If

            If Not String.Equals(My.Settings.DBName, DBName) Then
                Global.DAL.My.Settings.DBName = DBName
                changeOccured = True
            End If

            If Not String.Equals(My.Settings.User, User) Then
                Global.DAL.My.Settings.User = User
                changeOccured = True
            End If

            If Not String.Equals(My.Settings.pw, pw) Then
                Global.DAL.My.Settings.pw = pw
                changeOccured = True
            End If

            If changeOccured = True Then

                Global.DAL.My.Settings.ConnectionString = "Data Source= " & Server & ", " & port & ";Network Library=DBMSSOCN; Initial Catalog= " & DBName & ";User ID= " & User & ";Password= " & pw & ";"
                Global.DAL.My.Settings.Lastchanged = Today
                Global.DAL.My.Settings.Save()
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Shared Sub LoadConnectionStringData(ByRef Server As String, ByRef port As String, ByRef DBName As String, ByRef User As String, ByRef pw As String)
        Server = Global.DAL.My.Settings.Server
        port = Global.DAL.My.Settings.Port
        DBName = Global.DAL.My.Settings.DBName
        User = Global.DAL.My.Settings.User
        pw = Global.DAL.My.Settings.pw
    End Sub
    Public Shared Sub InitializeConnectionString()
        Dim Server As String = My.Settings.Server
        Dim Port As String = My.Settings.Port
        Dim DBName As String = My.Settings.DBName
        Dim User As String = My.Settings.User
        Dim PW As String = My.Settings.pw


        ' ConnectionString = "Data Source= " & Server & ", " & Port & ";Network Library=DBMSSOCN; Initial Catalog= " & DBName & ";User ID= " & User & ";Password= " & PW & ";"

    End Sub
    Public Shared Function ConnectionTest() As Boolean
        '   SqlConnection.ClearAllPools()
        If My.Settings.ConnectionString.Length = 0 Then ' not initialized yet
            Call InitializeConnectionString()
        End If

        Dim objConn = New SqlConnection(My.Settings.ConnectionString)
        objConn.Open()
        If objConn.State = ConnectionState.Broken Or objConn.State = ConnectionState.Closed Then
            Return False
        Else
            Return True
            objConn.Close()
        End If
    End Function
    Public Shared Function LoadUsers() As DataTable
        Try
            Using Connection As New SqlConnection(My.Settings.ConnectionString)
                Dim query As String = "SELECT * FROM tblUsers;"
                Dim DataAdapter As New SqlDataAdapter(query, Connection)
                Dim dt As New DataTable
                Connection.Open()
                DataAdapter.Fill(dt)
                Return dt
                ' DataAdapter = tmpda
                Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox("DAL/LoadUsersInDataAdapterissue:" & vbCrLf & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function SaveNewUser(UserName As String, UserLogin As String, UserHash As String) As Integer
        Try
            Using Connection As New SqlConnection(My.Settings.ConnectionString)
                Dim query As String = "INSERT INTO  tblUsers (UserName, UserLogin, UserHashedSaltedPassword) SELECT @UserName as name, @UserLogin as login, @Hashedpw as Hashedpw ;"
                Using Command As New SqlCommand(query, Connection)
                    Command.Parameters.AddWithValue("@UserName", UserName)
                    Command.Parameters.AddWithValue("@UserLogin", UserLogin)
                    Command.Parameters.AddWithValue("@Hashedpw", UserHash)
                    Connection.Open()
                    Dim RowsEffected As Integer = Convert.ToInt16(Command.ExecuteNonQuery())
                    Return RowsEffected
                End Using
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Shared Function SaveExistingUserNamechange(UserID As Int32, UserName As String) As Integer
        Try
            Using Connection As New SqlConnection(My.Settings.ConnectionString)
                Dim query As String = "UPDATE tblUsers SET tblUsers.UserName = @UserName WHERE tblUsers.UID = @UserID;"
                Using Command As New SqlCommand(query, Connection)
                    Command.Parameters.AddWithValue("@UserName", UserName)
                    Command.Parameters.AddWithValue("@UserID", UserID)
                    Connection.Open()
                    Dim RowsEffected As Integer = Convert.ToInt16(Command.ExecuteNonQuery())
                    Return RowsEffected
                End Using
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Shared Function SaveExistingUserLoginchange(UserID As Int32, UserLogin As String) As Integer
        Try
            Using Connection As New SqlConnection(My.Settings.ConnectionString)
                Dim query As String = "UPDATE tblUsers SET tblUsers.UserLogin = @UserLogin WHERE tblUsers.UID = @UserID;"
                Using Command As New SqlCommand(query, Connection)
                    Command.Parameters.AddWithValue("@UserLogin", UserLogin)
                    Command.Parameters.AddWithValue("@UserID", UserID)
                    Connection.Open()
                    Dim RowsEffected As Integer = Convert.ToInt16(Command.ExecuteNonQuery())
                    Return RowsEffected
                End Using
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Shared Function SaveExistingUserPasswordChange(UserID As Int32, UserHash As String) As Integer
        Try
            Using Connection As New SqlConnection(My.Settings.ConnectionString)
                Dim query As String = "UPDATE tblUsers SET tblUsers.UserHashedSaltedPassword = @Hashedpw, tblUsers.PasswordchangedOn = @Datechanged WHERE tblUsers.UID = @UserID;"
                Using Command As New SqlCommand(query, Connection)
                    Command.Parameters.AddWithValue("@Hashedpw", UserHash)
                    Command.Parameters.AddWithValue("@Datechanged", Today)
                    Command.Parameters.AddWithValue("@UserID", UserID)
                    Connection.Open()
                    Dim RowsEffected As Integer = Convert.ToInt16(Command.ExecuteNonQuery())
                    Return RowsEffected
                End Using
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Shared Function LogIn(ByVal User As String, ByVal Password As String, ByRef claim As String) As Boolean
        Try
            Using Connection As New SqlConnection(My.Settings.ConnectionString)
                ' Dim query As String = " SELECT tblUsers.UID, tblUsers.UserHashedSaltedPassword  FROM tblUsers WHERE tblUsers.UserLogin= @UserLogin ;"
                Dim query As String = " SELECT  tblUsers.UserHashedSaltedPassword  FROM tblUsers WHERE tblUsers.UserLogin= @UserLogin ;"
                Using Command As New SqlCommand(query, Connection)
                    Command.Parameters.AddWithValue("@UserLogin", User)
                    Connection.Open()
                    Dim objreader As SqlDataReader = Command.ExecuteReader
                    With objreader
                        If .Read Then
                            'If DAL.Creds.ValidatePassword(Password, objreader(1).ToString) = True Then
                            If DAL.Creds.ValidatePassword(Password, objreader(0).ToString) = True Then
                                claim = claim(Convert.ToInt32(objreader(1).ToString))
                                Return True
                            End If
                        End If
                    End With
                    Return False
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "functions work In progress"

    Private Function Claim(UserID As Int32) As String
        Try
            Using Connection As New SqlConnection(My.Settings.ConnectionString)
                Dim query As String = "SELECT tblUsers.UID, tblRoles.RoleName  FROM tblUsers INNER JOIN (tblRoles INNER JOIN tblClaims ON tblRoles.RID = tblclaims.Role) ON tblUsers.UID = tblclaims.UserID  WHERE tblUsers.UID = @UserID;"
                Using Command As New SqlCommand(query, Connection)
                    Command.Parameters.AddWithValue("@UserID", UserID)
                    Connection.Open()
                    Claim = Command.ExecuteScalar
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Shared Function UsersCount() As Integer
        InitializeConnectionString()
        Try
            Dim Connection As New SqlConnection(My.Settings.ConnectionString)
            Connection.Open()
            Dim query As String = "SELECT count(*) FROM tblUsers ;"
            Dim Command As New SqlCommand(query, Connection)

            Dim count As Integer = Command.ExecuteScalar
            Return count
            Connection.Close()

        Catch ex As Exception
            Return False
        End Try
    End Function



#End Region


End Class
