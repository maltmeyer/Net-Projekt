Public Class profile
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim member As MembershipUser
        member = Membership.GetUser(True)
        If Not IsPostBack Then
            setUpProfile()
        End If
        lblHeader.Text = "Willkommen, " & member.UserName
        lblGespeichert.Text = ""



    End Sub

    Public Sub setUpProfile()
        txtVorname.Text = getValue("vorname")
        txtNachname.Text = getValue("nachname")
        txtStraße.Text = getValue("strasse")
        txtHausnummer.Text = getValue("hausnummer")
        txtPLZ.Text = getValue("plz")
        txtOrt.Text = getValue("ort")
        txtTelefon.Text = getValue("telefon")
        If getValue("anrede") Then
            rbH.Checked = True
        Else
            rbF.Checked = True
        End If
    End Sub

    Private Function getValue(ByVal propertyName As String) As Object
        Return HttpContext.Current.Profile.GetPropertyValue(propertyName)
    End Function
    Private Sub setValue(ByVal propertyName As String, ByVal value As Object)
        HttpContext.Current.Profile.SetPropertyValue(propertyName, value)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        setValue("anrede", rbH.Checked)
        setValue("vorname", txtVorname.Text)
        setValue("nachname", txtNachname.Text)
        setValue("strasse", txtStraße.Text)
        setValue("hausnummer", txtHausnummer.Text)
        setValue("plz", txtPLZ.Text)
        setValue("ort", txtOrt.Text)
        setValue("telefon", txtTelefon.Text)
        HttpContext.Current.Profile.Save()
        lblGespeichert.Text = "Profildaten wurden gespeichert"
    End Sub
End Class