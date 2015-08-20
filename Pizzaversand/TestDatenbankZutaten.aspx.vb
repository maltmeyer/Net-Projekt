Public Class TestDatenbankZutaten
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim member As MembershipUser
        member = Membership.CreateUser("Markus", "passwotT!", "altmeyer.m@gmx.de")

    End Sub

    Private Sub btnAddZutat_Click(sender As Object, e As EventArgs) Handles btnAddZutat.Click
        Dim name As String = txtName.Text
        Dim preisStr As String = txtPreis.Text
        preisStr = preisStr.Replace(",", ".")
        Dim preis As Double = Val(preisStr)

        Dim dataset As New DataSetZutatenTableAdapters.ZutatenTableAdapter

        dataset.InsertZutat(name, preis)



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