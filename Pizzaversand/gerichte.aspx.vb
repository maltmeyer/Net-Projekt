Public Class gerichte
    Inherits System.Web.UI.Page

    Dim manager As DatenbankManager
    Dim gerichtListe As Hashtable
    Private Const WARENKORB = "warenkorb"

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ladeGerichte1ProReihe()
        manager = DatenbankManager.Instance
        If IsNothing(Session(WARENKORB)) Then
            Session("warenkorb") = New List(Of Ware)
        End If
        gerichtListe = New Hashtable

        ladeGerichte()

    End Sub

    Private Sub ladeGerichte()

        Dim img As Image
        Dim label As LiteralControl
        Dim btnKaufen As Button

        phGerichte.Controls.Clear()
        addTag("<Table>")
        For Each gericht As Gericht In manager.getGerichte
            If gericht.zeigen Then

                img = New Image
                img.ImageUrl = "~/UserUploadImages/" & gericht.photo
                img.CssClass = "imgPanelGerichte"

                label = New LiteralControl
                label.Text = gericht.name

                btnKaufen = New Button
                btnKaufen.Text = "In den Warenkorb"
                btnKaufen.CssClass = "btn btn-default"
                gerichtListe.Add(btnKaufen, gericht)
                AddHandler btnKaufen.Click, AddressOf btnKaufen_Click

                addTag("<tr>")
                addTag("<td>")
                addTag("<div   class=""abstand"">")
                If gericht.photo <> "" Then
                    phGerichte.Controls.Add(img)
                End If


                addTag("</div>")
                    addTag("<td>")
                    addTag("<div class=""abstand2"">")
                    addTag("<h3>" & gericht.name & "</h3>")
                    addTag("<p>" & gericht.beschreibung & "</p>")
                    addTag("<h4>" & "Zutaten" & "</h4>")


                    addTag("<ul>")
                    For Each zutat As Zutat In gericht.zutaten
                        addTag("<li>" & zutat.name & "</li>")
                    Next
                    addTag("</ul>")


                    addTag("<p><b>" & String.Format("{0:0.00}", gericht.preis) & " € </b></p>")
                    phGerichte.Controls.Add(btnKaufen)
                    addTag("</div>")
                    addTag("</td>")
                    addTag("</tr>")
                End If

        Next
        addTag("</table>")

    End Sub


    ''' <summary>
    ''' Fügt ein neues html tag in phGerichte ein
    ''' </summary>
    ''' <param name="tag"></param>
    Private Sub addTag(ByVal tag As String)
        phGerichte.Controls.Add(New LiteralControl(tag))
    End Sub

    Protected Sub btnKaufen_Click(sender As Object, e As EventArgs)
        Dim btnKaufen As Button = CType(sender, Button)

        Dim gericht As Gericht = gerichtListe(btnKaufen)

        Dim gerichte As List(Of Ware) = Session(WARENKORB)
        Dim gefunden As Boolean = False

        'Suchen ob schon im Warenkorb
        For Each ware As Ware In gerichte
            If ware.gericht.id = gericht.id Then
                gefunden = True
                ware.anzahl += 1
            End If
        Next

        If Not gefunden Then
            gerichte.Add(New Ware(gericht, 1))
        End If



    End Sub


End Class