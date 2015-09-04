Public Class Bestellungen
    Inherits System.Web.UI.Page
    Dim manager As DatenbankManager

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        manager = DatenbankManager.Instance
        zeigeBestellungen()

    End Sub

    Private Sub zeigeBestellungen()
        Dim bestellungen As List(Of Bestellung)
        bestellungen = manager.getAusstehendeBestellungen()
        Dim gesamtpreis As Double = 0
        Dim button As Button

        For Each bestellung In bestellungen
            gesamtpreis = 0
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
            addTag("Gesamtpreis:  " & gesamtpreis)
            addTag("<br/>")
            button = New Button
            button.CssClass = "btn btn-primary"
            button.Text = "Bestellung abschließen"
            phBestellungen.Controls.Add(button)
            addTag("<br/>")
            addTag("<br/>")
            addTag("<br/>")
        Next

    End Sub

    ''' <summary>
    ''' Fügt ein neues html tag in phGerichte ein
    ''' </summary>
    ''' <param name="tag"></param>
    Private Sub addTag(ByVal tag As String)
        phBestellungen.Controls.Add(New LiteralControl(tag))
    End Sub


End Class