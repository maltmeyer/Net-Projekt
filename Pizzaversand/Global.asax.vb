﻿Imports System.Web.SessionState

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
        ' Rollen generieren
        If Not Roles.RoleExists("admin") Then
            Roles.CreateRole("admin")
        End If
        If Not Roles.RoleExists("user") Then
            Roles.CreateRole("user")
        End If
        If Not Roles.RoleExists("employee") Then
            Roles.CreateRole("employee")
        End If



        'addAdmin()
    End Sub

    Private Sub addAdmin()
        Dim user As MembershipUser = Membership.CreateUser("admin", "admin_123")
        Roles.AddUserToRole("admin", "admin")
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

End Class