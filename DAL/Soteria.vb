Imports System.Data.SqlClient

Public Class Soteria

    Public Shared Function SaveConnectionString(Server As String, port As String, DBName As String, User As String, pw As String) As Boolean
        Try
            Dim changeOccured As Boolean = False
            If Not String.Equals(My.Settings.SoteriaServer, Server) Then
                Global.DAL.My.Settings.Server = Server
                changeOccured = True
            End If
            If Not String.Equals(My.Settings.SoteriaPort, port) Then
                Global.DAL.My.Settings.Port = port
                changeOccured = True
            End If
            If Not String.Equals(My.Settings.SoteriaDBName, DBName) Then
                Global.DAL.My.Settings.DBName = DBName
                changeOccured = True
            End If
            If Not String.Equals(My.Settings.SoteriaUser, User) Then
                Global.DAL.My.Settings.User = User
                changeOccured = True
            End If
            If Not String.Equals(My.Settings.Soteriapw, pw) Then
                Global.DAL.My.Settings.pw = pw
                changeOccured = True
            End If
            If changeOccured = True Then
                Global.DAL.My.Settings.SoteriaConnectionString = "Data Source= " & Server & ", " & port & ";Network Library=DBMSSOCN; Initial Catalog= " & DBName & ";User ID= " & User & ";Password= " & pw & ";"
                Global.DAL.My.Settings.SoteriaLastChanged = Today
                Global.DAL.My.Settings.Save()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Sub LoadConnectionString(ByRef Server As String, ByRef port As String, ByRef DBName As String, ByRef User As String, ByRef pw As String)
        Server = Global.DAL.My.Settings.SoteriaServer
        port = Global.DAL.My.Settings.SoteriaPort
        DBName = Global.DAL.My.Settings.SoteriaDBName
        User = Global.DAL.My.Settings.SoteriaUser
        pw = Global.DAL.My.Settings.Soteriapw
    End Sub

    Public Shared Function InitializedConnectionString() As String
        Dim Server As String = My.Settings.SoteriaServer
        Dim Port As String = My.Settings.SoteriaPort
        Dim DBName As String = My.Settings.SoteriaDBName
        Dim User As String = My.Settings.SoteriaUser
        Dim PW As String = My.Settings.Soteriapw
        Return "Data Source= " & Server & ", " & Port & ";Network Library=DBMSSOCN; Initial Catalog= " & DBName & ";User ID= " & User & ";Password= " & PW & ";"

    End Function

    Public Shared Function ConnectionTest() As Boolean
        Using myConnection As New SqlConnection(InitializedConnectionString)
            myConnection.Open()
            If myConnection.State = ConnectionState.Broken Or myConnection.State = ConnectionState.Closed Then
                Return False
            Else
                Return True
                myConnection.Close()
            End If
        End Using
    End Function

End Class
