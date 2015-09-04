''' <summary>
''' Singelton Klasse für Zugriffe auf die Datenbank
''' </summary>
Public NotInheritable Class DatenbankManager

    Private Shared ReadOnly _instance As New DatenbankManager
    Dim dsGerichte As New DataSetGerichteTableAdapters.GerichteTableAdapter
    Dim dsZutaten As New DataSetZutatenTableAdapters.ZutatenTableAdapter
    Dim dsGerichtZutaten As New DataSetConnectionGerichtZutatTableAdapters.Gericht_ZutatenTableAdapter
    Dim dsBestellungen As New DataSetBestellungenTableAdapters.BestellungenTableAdapter
    Dim dsBestellungGericht As New DataSetConnectionBestellungWareTableAdapters.Bestellung_GerichtTableAdapter

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As DatenbankManager
        Get
            Return _instance
        End Get
    End Property

    ''' <summary>
    ''' Gibt alle Gerichte mit zugehörigen Zutaten in der db zurück
    ''' </summary>
    ''' <returns>Gerichte falls vorhanden, sonts leere liste </returns>
    Public Function getGerichte() As List(Of Gericht)
        Dim datatable As Data.DataTable = dsGerichte.GetData
        Dim gerichte As New List(Of Gericht)
        Dim gericht As Gericht
        If datatable.Rows.Count > 0 Then
            For Each row As DataSetGerichte.GerichteRow In datatable.Rows
                gericht = New Gericht(row.Name, row.Beschreibung, row.Photo, row.Zeigen, row.Preis)
                gericht.id = row.Id
                gericht.zutaten = getZutaten(row.Id)
                gerichte.Add(gericht)
            Next
        End If
        Return gerichte
    End Function
    ''' <summary>
    ''' Gibt ein bestimmtes Gericht in der Datenbank zurück
    ''' </summary>
    ''' <param name="id">Id des Gerichtes</param>
    ''' <returns>Gericht, wenn vorhanden, sonst Nothing</returns>
    Public Function getGericht(ByVal id As Integer) As Gericht
        Dim datatable As Data.DataTable = dsGerichte.GetEntry(id)
        Dim gericht As Gericht = Nothing
        If datatable.Rows.Count > 0 Then
            For Each row As DataSetGerichte.GerichteRow In datatable.Rows
                gericht = New Gericht(row.Name, row.Beschreibung, row.Photo, row.Zeigen, row.Preis)
                gericht.id = row.Id
                gericht.zutaten = getZutaten(row.Id)
            Next
        End If
        Return gericht
    End Function

    ''' <summary>
    ''' Gibt alle Zutaten die zu einem Gericht gehören zurück.
    ''' </summary>
    ''' <param name="gerichtID">id des Gerichtes</param>
    ''' <returns>Zutaten des Gerichtes, sonst leere Liste</returns>
    Public Function getZutaten(ByVal gerichtID As Integer) As List(Of Zutat)
        Dim zutaten As New List(Of Zutat)

        Dim datatable As Data.DataTable = dsGerichtZutaten.getIngredients(gerichtID)

        For Each rowGerichtZutat As DataSetConnectionGerichtZutat.Gericht_ZutatenRow In datatable.Rows
            zutaten.Add(getZutat(rowGerichtZutat.IdZutat))
        Next
        Return zutaten
    End Function

    ''' <summary>
    ''' Gibt alle in der Datenbank vorhandenen Zutaten zurück
    ''' </summary>
    ''' <returns>Zutaten falls vorhanden, sonst leere liste</returns>
    Public Function getZutaten() As List(Of Zutat)
        Dim zutaten As New List(Of Zutat)
        Dim zutat As Zutat

        Dim datatable As Data.DataTable = dsZutaten.GetData

        For Each row As DataSetZutaten.ZutatenRow In datatable.Rows
            zutat = New Zutat(row.Name, row.Preis)
            zutat.id = row.Id
            zutaten.Add(zutat)
        Next
        Return zutaten
    End Function

    ''' <summary>
    ''' Gibt die Zutat mit der angegebenen id zurück
    ''' </summary>
    ''' <param name="id">id der Zutat</param>
    ''' <returns>Zutat falls vorhanden, sonst nothing</returns>
    Public Function getZutat(ByVal id As Integer) As Zutat
        Dim datatable As Data.DataTable = dsZutaten.getIngredient(id)
        Dim zutat As Zutat = Nothing

        For Each row As DataSetZutaten.ZutatenRow In datatable.Rows
            zutat = New Zutat(row.Name, row.Preis)
            zutat.id = row.Id
        Next
        Return zutat
    End Function


    ''' <summary>
    ''' Updated eine Zutat. Falls zutat noch nicht existiert wird dies neu in der db angelegt
    ''' </summary>
    ''' <param name="zutat"></param>
    Public Sub updateOrAddZutat(ByVal zutat As Zutat)
        If (zutat.id = -1) Then
            Dim id = dsZutaten.InsertZutat(zutat.name, zutat.preis)
            zutat.id = id
        Else
            dsZutaten.IngredientUpdate(zutat.name, zutat.preis, zutat.id)
        End If


    End Sub
    ''' <summary>
    ''' Updatet ein vorhandenes Gericht oder legt ein neues an.
    ''' Dabei werden automatisch neue Zutaten der db hinzugefügt. Um Zutaten vom Gericht zu löschen
    ''' genügt es Sie aus der Liste der Zutaten zu entfernen d.h gericht.zutaten.clear() löscht alle verbundingen zu Zutaten wenn gespeichert wird
    ''' </summary>
    ''' <param name="gericht"></param>
    ''' <returns></returns>
    Public Sub updateOrAddGericht(ByVal gericht As Gericht)
        'Speichere Gericht
        If (gericht.id = -1) Then
            Dim id As Integer = dsGerichte.InsertDish(gericht.name, gericht.beschreibung, gericht.photo, gericht.zeigen, gericht.preis)
            gericht.id = id
            For Each zutat As Zutat In gericht.zutaten
                updateOrAddZutat(zutat)
                setConnectionGerichtZutat(gericht, zutat)
            Next
        Else
            Dim gefunden As Boolean = False
            dsGerichte.dishUpdate(gericht.name, gericht.beschreibung, gericht.photo, gericht.zeigen, gericht.preis, gericht.id)

            'Connection von nicht merh vorhandenen Zutaten löschen
            Dim zutatenOriginal As List(Of Zutat)
            Dim zutatenZuLöschen As New List(Of Zutat)
            zutatenOriginal = getZutaten(gericht.id)
            For Each originalZutat In zutatenOriginal
                gefunden = False
                For Each zutat As Zutat In gericht.zutaten
                    If (originalZutat.id = zutat.id) Then
                        gefunden = True
                    End If
                Next
                If Not gefunden Then
                    zutatenZuLöschen.Add(originalZutat)
                End If
            Next
            For Each zutat As Zutat In zutatenZuLöschen
                deleteConnection(gericht, zutat)
            Next

            'Connection zu Zutaten setzen
            For Each zutat As Zutat In gericht.zutaten
                updateOrAddZutat(zutat)
                setConnectionGerichtZutat(gericht, zutat)
            Next



        End If

    End Sub

    ''' <summary>
    ''' Setzt eine verbindung zwischen einem Gericht und einer Zutat
    ''' </summary>
    ''' <param name="gericht"></param>
    ''' <param name="zutat"></param>
    Private Sub setConnectionGerichtZutat(ByVal gericht As Gericht, ByVal zutat As Zutat)
        dsGerichtZutaten.InsetConnection(gericht.id, zutat.id)
    End Sub

    ''' <summary>
    ''' Löscht eine Verbindung zwischen einem Gericht und einer Zutat
    ''' </summary>
    ''' <param name="gericht"></param>
    ''' <param name="zutat"></param>
    Private Sub deleteConnection(ByVal gericht As Gericht, ByVal zutat As Zutat)
        dsGerichtZutaten.deleteConnection(gericht.id, zutat.id)
    End Sub

    ''' <summary>
    ''' Legt eine neue Bestellung in der db an. dabei werden alle Gerichte aus der db miteinander verbunden
    ''' </summary>
    ''' <param name="bestellung"></param>
    Public Sub neueBestellung(ByVal bestellung As Bestellung)
        Dim datum As Date = Date.Now
        Dim id As Integer = dsBestellungen.InsertBestellung(bestellung.vorname, bestellung.nachname, bestellung.hausnummer, bestellung.gesamtpreis, bestellung.anrede, bestellung.plz, bestellung.straße, bestellung.wohnort, bestellung.telefon, datum)
        bestellung.id = id
        For Each ware As Ware In bestellung.waren
            setConnectionBestellungGericht(bestellung, ware)
        Next

    End Sub

    ''' <summary>
    ''' Setzt die Verbindung zwischen einer Bestellung und der Ware.
    ''' </summary>
    ''' <param name="bestellung"></param>
    ''' <param name="ware"></param>
    Private Sub setConnectionBestellungGericht(ByVal bestellung As Bestellung, ByVal ware As Ware)
        dsBestellungGericht.setConnection(bestellung.id, ware.gericht.id, ware.anzahl)
    End Sub

    ''' <summary>
    ''' Gibt alle Bestellungen zurück die noch icht bearbeitet wurden
    ''' </summary>
    ''' <returns></returns>
    Public Function getAusstehendeBestellungen() As List(Of Bestellung)
        Dim bestellungen As New List(Of Bestellung)

        Dim datatable As Data.DataTable = dsBestellungen.getAustehendeBestellungen()
        Dim bestellung As Bestellung = Nothing

        For Each row As DataSetBestellungen.BestellungenRow In datatable.Rows
            bestellung = New Bestellung(row.Vorname, row.Nachname, row.Hausnummer, row.Gesamtpreis, row.Anrede, row.Postleitzahl, row.Straße, row.Wohnort, row.Telefonnummer)
            bestellung.id = row.Id
            bestellung.datum = row.datum
            bestellung.waren = getWaren(bestellung.id)
            bestellungen.Add(bestellung)
        Next

        Return bestellungen
    End Function

    ''' <summary>
    ''' Gibt alle Waren mit Gericht und anzahl für eine Bestellung zurück
    ''' </summary>
    ''' <param name="idBestellung"></param>
    ''' <returns></returns>
    Private Function getWaren(ByVal idBestellung As Integer) As List(Of Ware)
        Dim waren As New List(Of Ware)

        Dim datatable As Data.DataTable = dsBestellungGericht.getWaren(idBestellung)

        Dim ware As Ware
        Dim gericht As Gericht
        For Each row As DataSetConnectionBestellungWare.Bestellung_GerichtRow In datatable.Rows
            gericht = getGericht(row.IdWare)
            ware = New Ware(gericht, row.AnzahlVonWare)
            waren.Add(ware)
        Next
        Return waren
    End Function

    ''' <summary>
    ''' Markiert eine Bestellung als bearbeitet
    ''' </summary>
    ''' <param name="bestellung"></param>
    Public Sub bestellungBearbeitet(ByVal bestellung As Bestellung)
        dsBestellungen.UpdateBestellungBearbeitet(bestellung.id)
    End Sub

    ''' <summary>
    ''' Schließt eine Bestellung ab.
    ''' </summary>
    ''' <param name="bestellung"></param>
    Public Sub bestellungAbschließen(ByVal bestellung As Bestellung)
        dsBestellungen.UpdateBestellungBearbeitet(bestellung.id)
    End Sub

End Class
