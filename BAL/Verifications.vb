Imports System.Text.RegularExpressions
Imports System.Data.SqlClient




Public Class Verifications

    Public Shared Function IsLoginValid(ByVal Login As String, ByRef Message As String) As Boolean

        If Not Regex.Match(Login, "^[a-z0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only alphanumerical characters (letters and numbers)
            Message = ("Letters and Numbers Only: No special characters allowed!") 'Inform User
            Return False
        Else
            If BAL.Verifications.IsLoginValid(Login, Message) = False Then ' Available
                Message = "This login is valid and available"
                Return True
            Else ' Login already used
                Message = "Login already attributed, please chose another one!"
                Return False
            End If
        End If
    End Function

    Public Shared Function VerifyEnteredName(ByVal Login As String, ByRef Message As String) As Boolean
        If Not Regex.Match(Login, "^[a-z- _.]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters
            Message = "Please Enter Alphabetic Characters Only!" 'Inform User
            Return False
        Else
            Message = "" 'no need to inform the user
            Return True
        End If
    End Function

    Public Shared Function StringMatch(String1 As String, String2 As String, Optional IscomparisonCaseSensitive As Boolean = True) As Boolean

        Select Case IscomparisonCaseSensitive
            Case False
                If String.Compare(String1, String2, StringComparison.OrdinalIgnoreCase) = 0 Then
                    Return True
                Else
                    Return False
                End If
            Case True
                If String.Compare(String1, String2) = 0 Then
                    Return True
                Else
                    Return False
                End If
            Case Else ' error!
                Return False
        End Select
    End Function

    Public Shared Function CountWords(ByVal value As String) As Integer
        ' Count matches.
        Dim collection As MatchCollection = Regex.Matches(value, "\S+")
        Return collection.Count
    End Function


End Class
