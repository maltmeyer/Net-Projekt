Public Class warenkorb
    Inherits System.Web.UI.Page
    Private Const WARENKORB = "warenkorb"

    Dim hsTextbox As Hashtable
    Dim hsDelete As Hashtable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        hsTextbox = New Hashtable
        hsDelete = New Hashtable
        If Not IsNothing(Session(WARENKORB)) Then
            zeigeGerichte()

        End If

    End Sub


    Private Sub zeigeGerichte()
        Dim gerichte As List(Of Ware) = Session(WARENKORB)
        Dim img As Image
        Dim textbox As TextBox
        phGerichte.Controls.Clear()
        Dim gesamtpreis As Double = 0
        Dim delete As Button

        addTag("<table>")
        For Each ware As Ware In gerichte
            img = New Image
            img.ImageUrl = "~/UserUploadImages/" & ware.gericht.photo
            img.Width = 150
            img.Height = 150

            textbox = New TextBox

            addTag("<tr>")
            addTag("<td>")
            phGerichte.Controls.Add(img)
            addTag("<td>")

            addTag("<td>")
            addTag(ware.gericht.name)
            phGerichte.Controls.Add(textbox)

            hsTextbox.Add(textbox, ware)

            textbox.Text = ware.anzahl
            addTag("<br/>")
            addTag(ware.gericht.preis * ware.anzahl & " €")
            gesamtpreis += ware.gericht.preis * ware.anzahl
            addTag("<br/>")
            delete = New Button
            delete.Text = "Entfernen"
            delete.CssClass = "btn btn-danger"
            hsDelete.Add(delete, ware)
            AddHandler delete.Click, AddressOf btnDelete_Click
            phGerichte.Controls.Add(delete)
            addTag("<td>")
            addTag("</tr>")




        Next
        addTag("</table>")

        addTag("<h3>Gesamtpreis: " & gesamtpreis & "</h3>")

        Dim btnAktualisieren As New Button
        btnAktualisieren.Text = "Aktualisieren"
        AddHandler btnAktualisieren.Click, AddressOf btnAktualisieren_Click
        phGerichte.Controls.Add(btnAktualisieren)

    End Sub

    Protected Sub btnAktualisieren_Click(sender As Object, e As EventArgs)
        Dim entry As DictionaryEntry
        Dim ware As Ware
        Dim textbox As TextBox
        For Each entry In hsTextbox
            ware = CType(entry.Value, Ware)
            textbox = CType(entry.Key, TextBox)
            ware.anzahl = Val(textbox.Text)
        Next
        zeigeGerichte()
    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim btnDelete As Button = CType(sender, Button)

        Dim ware As Ware = hsDelete(btnDelete)
        Dim waren As List(Of Ware) = Session(WARENKORB)
        Dim wareRemove As Ware

        For Each w As Ware In waren
            If w.id = ware.id Then
                wareRemove = ware
            End If
        Next

        waren.Remove(ware)
        zeigeGerichte()

    End Sub


    ''' <summary>
    ''' Fügt ein neues html tag in phGerichte ein
    ''' </summary>
    ''' <param name="tag"></param>
    Private Sub addTag(ByVal tag As String)
        phGerichte.Controls.Add(New LiteralControl(tag))
    End Sub

End Class