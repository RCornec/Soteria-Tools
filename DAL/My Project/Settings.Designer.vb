﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("104.171.4.189")>  _
        Public Property Server() As String
            Get
                Return CType(Me("Server"),String)
            End Get
            Set
                Me("Server") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1433")>  _
        Public Property Port() As String
            Get
                Return CType(Me("Port"),String)
            End Get
            Set
                Me("Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DBTools")>  _
        Public Property DBName() As String
            Get
                Return CType(Me("DBName"),String)
            End Get
            Set
                Me("DBName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ToolUser")>  _
        Public Property User() As String
            Get
                Return CType(Me("User"),String)
            End Get
            Set
                Me("User") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("xS28SPCGVVEaw4vr")>  _
        Public Property pw() As String
            Get
                Return CType(Me("pw"),String)
            End Get
            Set
                Me("pw") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source= 104.171.4.189, 1433;Network Library=DBMSSOCN; Initial Catalog= DBToo"& _ 
            "ls ;User ID= ToolUser;Password= xS28SPCGVVEaw4vr;")>  _
        Public Property ConnectionString() As String
            Get
                Return CType(Me("ConnectionString"),String)
            End Get
            Set
                Me("ConnectionString") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2015-07-27")>  _
        Public Property Lastchanged() As Date
            Get
                Return CType(Me("Lastchanged"),Date)
            End Get
            Set
                Me("Lastchanged") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Soteria")>  _
        Public Property SoteriaDBName() As String
            Get
                Return CType(Me("SoteriaDBName"),String)
            End Get
            Set
                Me("SoteriaDBName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("Tester1")> _
        Public Property SoteriaUser() As String
            Get
                Return CType(Me("SoteriaUser"), String)
            End Get
            Set(value As String)
                Me("SoteriaUser") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("LtlRsK")> _
        Public Property Soteriapw() As String
            Get
                Return CType(Me("Soteriapw"), String)
            End Get
            Set(value As String)
                Me("Soteriapw") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property SoteriaConnectionString() As String
            Get
                Return CType(Me("SoteriaConnectionString"), String)
            End Get
            Set(value As String)
                Me("SoteriaConnectionString") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("2015-05-01")> _
        Public Property SoteriaLastChanged() As Date
            Get
                Return CType(Me("SoteriaLastChanged"), Date)
            End Get
            Set(value As Date)
                Me("SoteriaLastChanged") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("104.171.4.189")> _
        Public Property SoteriaServer() As String
            Get
                Return CType(Me("SoteriaServer"), String)
            End Get
            Set(value As String)
                Me("SoteriaServer") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("1433")> _
        Public Property SoteriaPort() As String
            Get
                Return CType(Me("SoteriaPort"), String)
            End Get
            Set(value As String)
                Me("SoteriaPort") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.DAL.My.MySettings
            Get
                Return Global.DAL.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace