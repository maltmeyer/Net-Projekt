Public Class Bestellungen
    Inherits System.Web.UI.Page
    Dim manager As DatenbankManager
    Dim hsBestellungen As New Hashtable


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        manager = DatenbankManager.Instance
        zeigeBestellungen()

    End Sub

    Private Sub zeigeBestellungen()
        Dim bestellungen As List(Of Bestellung)
        bestellungen = manager.getAusstehendeBestellungen()
        Dim gesamtpreis As Double = 0
        Dim button As Button

        phBestellungen.Controls.Clear()
        hsBestellungen.Clear()
        addTag("<table class=""table table-hover"">")
        For Each bestellung In bestellungen
            addTag("<tr>")
            addTag("<td>")
            addTag("<b>" & bestellung.datum & "</b>")
            addTag("</br>")
            gesamtpreis = 0
            addTag("<b>Kontakt</b>")
            addTag("</br>")
            addTag(bestellung.anrede & " ")
            addTag(bestellung.nachname & " ")
            addTag(bestellung.vorname)
            addTag("</br>")
            addTag(bestellung.straße & " ")
            addTag(bestellung.hausnummer)
            addTag("</br>")
            addTag(bestellung.plz & " ")
            addTag(bestellung.wohnort)
            addTag("</br>")
            addTag("Tel: " & bestellung.telefon)
            addTag("</br>")
            addTag("<br/>")
            addTag("<b>Gerichte</b>")
            addTag("<ul>")
            For Each ware As Ware In bestellung.waren
                addTag("<li>")
                addTag(ware.gericht.name & " " & ware.anzahl & "x " & (ware.gericht.preis * ware.anzahl) & "€")
                addTag("</li>")
                gesamtpreis += ware.gericht.preis * ware.anzahl
            Next
            addTag("</ul>")
            addTag("Gesamtpreis:  " & gesamtpreis & "€")
            addTag("<br/>")
            button = New Button
            button.CssClass = "btn btn-primary"
            button.Text = "Bestellung abschließen"
            AddHandler button.Click, AddressOf btnBestellungAbschließen_Click
            phBestellungen.Controls.Add(button)
            hsBestellungen.Add(button, bestellung)
            'addTag("<br/>")
            'addTag("<br/>")
            'addTag("<br/>")
            addTag("</td>")
            addTag("</tr>")

        Next
        addTag("</table>")
    End Sub


    Private Sub btnBestellungAbschließen_Click(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Dim bestellung As Bestellung
        bestellung = hsBestellungen(button)
        manager.bestellungAbschließen(bestellung)
        zeigeBestellungen()
    End Sub


    ''' <summary>
    ''' Fügt ein neues html tag in phGerichte ein
    ''' </summary>
    ''' <param name="tag"></param>
    Private Sub addTag(ByVal tag As String)
        phBestellungen.Controls.Add(New LiteralControl(tag))
    End Sub


End Class