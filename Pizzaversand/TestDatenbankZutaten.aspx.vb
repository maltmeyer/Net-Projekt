Public Class TestDatenbankZutaten
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        'Dim member As MembershipUser
        'member = Membership.CreateUser("User2", "passwotT!", "user2.m@gmx.de")
        Dim roleName As String = "roleAdmin"


        Dim member As MembershipUser = Membership.GetUser(True)
        If Not IsNothing(member) Then
            Dim name As String
            name = HttpContext.Current.Profile.GetPropertyValue("vorname")
            MsgBox(member.Email)
        End If
        If (Roles.RoleExists(roleName)) Then
            Roles.AddUserToRole(member.UserName, roleName)
        Else
            Roles.CreateRole(roleName)
            Roles.AddUserToRole(member.UserName, roleName)
        End If



    End Sub

    Private Sub btnAddZutat_Click(sender As Object, e As EventArgs) Handles btnAddZutat.Click
        Dim name As String = txtName.Text
        Dim preisStr As String = txtPreis.Text
        preisStr = preisStr.Replace(",", ".")
        Dim preis As Double = Val(preisStr)

        Dim dataset As New DataSetZutatenTableAdapters.ZutatenTableAdapter

        dataset.InsertZutat(name, preis)



    End Sub

    Private Sub btnGetGerichte_Click(sender As Object, e As EventArgs) Handles btnGetGerichte.Click
        Dim manager As DatenbankManager = DatenbankManager.Instance
        Dim gericht As Gericht = manager.getGerichte()(0)

        Dim ware As New Ware(gericht, 2)

        Dim bestellung As New Bestellung("Markus", "Altmeyer", 60, 13, "Herr", 66687, "Im Flürchen 60", "Nunkirchen", "068746558")
        bestellung.waren.Add(ware)
        manager.neueBestellung(bestellung)

    End Sub

    Private Sub btnShowZutaten_Click(sender As Object, e As EventArgs) Handles btnShowZutaten.Click
        Dim dataset As New DataSetZutatenTableAdapters.ZutatenTableAdapter


        Dim dataTable As Data.DataTable = dataset.GetData()

        If dataTable.Rows.Count > 0 Then
            '    Me.phContent.Controls.Add(New LiteralControl( _
            'CType(dtContent.Rows(0), dsPageContent.PageRow).Content))
            phZutaten.Controls.Clear()

            For Each row As DataSetZutaten.ZutatenRow In dataTable.Rows
                'row.name
                Dim preisStr As String = String.Format("{0:0.00}", row.Preis)
                phZutaten.Controls.Add(New LiteralControl(row.Name & " - " & preisStr & "€" & "<br />"))
            Next
        End If


    End Sub


End Class