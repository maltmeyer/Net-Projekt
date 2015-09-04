Public Class Kaufabschluss
    Inherits System.Web.UI.Page
    Private Const WARENKORB = "warenkorb"
    Dim waren As List(Of Ware)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        phErfolg.Visible = False

        If IsNothing(Session(WARENKORB)) Then
            Server.Transfer("warenkorb.aspx", True)
        End If
        waren = Session(WARENKORB)
        If waren.Count = 0 Then
            Server.Transfer("warenkorb.aspx", True)
        End If

        Dim user As MembershipUser = Membership.GetUser(True)
        If Not IsPostBack Then
            If Not IsNothing(user) Then
                initProfildaten()
            End If
        End If

        lblWaren.Text = "Sie haben " & waren.Count & " Bestellungen im Wert von " & getGesamtpreis() & " €"




    End Sub

    Private Function getGesamtpreis() As Double
        Dim preis As Double = 0
        For Each w As Ware In waren
            preis += (w.gericht.preis * w.anzahl)
        Next
        Return preis
    End Function

    Private Function getValue(ByVal propertyName As String) As Object
        Return HttpContext.Current.Profile.GetPropertyValue(propertyName)
    End Function
    Private Sub initProfildaten()
        txtVorname.Text = getValue("vorname")
        txtNachname.Text = getValue("nachname")
        txtStraße.Text = getValue("strasse")
        txtHausnummer.Text = getValue("hausnummer")
        txtPLZ.Text = getValue("plz")
        txtOrt.Text = getValue("ort")
        txtTelefon.Text = getValue("telefon")
        If getValue("anrede") = "Frau" Then
            rbF.Checked = True
        Else
            rbH.Checked = True
        End If
    End Sub

    Private Sub btnKaufAbschließen_Click(sender As Object, e As EventArgs) Handles btnKaufAbschließen.Click
        Dim manager As DatenbankManager = DatenbankManager.Instance
        Dim anrede As String
        If rbH.Checked Then
            anrede = "Herr"
        Else
            anrede = "Frau"
        End If
        Dim bestellung As New Bestellung(txtVorname.Text, txtNachname.Text, txtHausnummer.Text, getGesamtpreis, anrede, txtPLZ.Text, txtStraße.Text, txtOrt.Text, txtTelefon.Text)
        bestellung.waren = waren
        manager.neueBestellung(bestellung)
        abschluss()

    End Sub

    Private Sub abschluss()
        phAbschluss.Visible = False
        phErfolg.Visible = True
        waren.Clear()
    End Sub


End Class