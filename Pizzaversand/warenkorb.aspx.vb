Public Class warenkorb
    Inherits System.Web.UI.Page
    Private Const WARENKORB = "warenkorb"
    Private Const ANZAHL = "anzahl"
    Dim listTextbox As List(Of TextBox)

    Dim hsDelete As Hashtable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnWeiter.Visible = False
        btnAktualisieren.Visible = False
        hsDelete = New Hashtable
        listTextbox = New List(Of TextBox)
        If Not IsNothing(Session(WARENKORB)) Then
            zeigeGerichte()
        Else
            addTag("<h3>Ihr Warenkorb ist leer</h3>")
        End If

    End Sub


    Private Sub zeigeGerichte()
        Dim waren As List(Of Ware) = Session(WARENKORB)
        Dim img As Image
        Dim textbox As TextBox
        phGerichte.Controls.Clear()
        Dim gesamtpreis As Double = 0
        Dim delete As Button

        hsDelete.Clear()
        listTextbox.Clear()
        Dim counter As Integer = 0

        If waren.Count = 0 Then
            addTag("<h3>Ihr Warenkorb ist leer</h3>")
            Exit Sub
        End If
        btnWeiter.Visible = True
        btnAktualisieren.Visible = True
        addTag("<table>")
        For Each ware As Ware In waren
            img = New Image
            img.ImageUrl = "~/UserUploadImages/" & ware.gericht.photo
            img.Width = 150
            img.Height = 150

            textbox = New TextBox
            textbox.ID = "txt" & counter

            addTag("<tr>")
            addTag("<td>")
            phGerichte.Controls.Add(img)
            addTag("<td>")

            addTag("<td>")
            addTag(ware.gericht.name)
            phGerichte.Controls.Add(textbox)

            'hsTextbox.Add(textbox, ware)

            'If textbox.Text = "" Then
            textbox.Text = ware.anzahl
            'End If
            listTextbox.Add(textbox)
            addTag("<br/>")
            addTag(ware.gericht.preis * ware.anzahl & " €")
            gesamtpreis += ware.gericht.preis * ware.anzahl
            addTag("<br/>")
            delete = New Button
            delete.ID = "btn" & counter
            delete.Text = "Entfernen"
            delete.CssClass = "btn btn-danger"
            AddHandler delete.Click, AddressOf btnDelete_Click
            hsDelete.Add(delete, counter)

            phGerichte.Controls.Add(delete)
            addTag("<td>")
            addTag("</tr>")


            counter += 1

        Next
        addTag("</table>")

        addTag("<h3>Gesamtpreis: " & gesamtpreis & "</h3>")


    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim btnDelete As Button = CType(sender, Button)

        Dim index As Integer = hsDelete(btnDelete)
        Dim waren As List(Of Ware) = Session(WARENKORB)
        Dim wareRemove As Ware = waren(index)
        waren.Remove(wareRemove)
        btnWeiter.Visible = False
        btnAktualisieren.Visible = False
        zeigeGerichte()

    End Sub


    ''' <summary>
    ''' Fügt ein neues html tag in phGerichte ein
    ''' </summary>
    ''' <param name="tag"></param>
    Private Sub addTag(ByVal tag As String)
        phGerichte.Controls.Add(New LiteralControl(tag))
    End Sub

    Private Sub btnAktualisieren_Click(sender As Object, e As EventArgs) Handles btnAktualisieren.Click

        Dim index As Integer = 0
        Dim textbox As TextBox
        If Not IsNothing(Session(WARENKORB)) Then
            Dim waren As List(Of Ware) = Session(WARENKORB)
            For Each ware As Ware In waren
                textbox = listTextbox.Item(index)
                Try
                    ware.anzahl = Val(textbox.Text)
                    If ware.anzahl <= 0 Then
                        ware.anzahl = 1
                    End If
                Catch ex As Exception
                    ware.anzahl = 1
                End Try

                index += 1
            Next
            zeigeGerichte()
        End If

    End Sub

    Private Sub btnWeiter_Click(sender As Object, e As EventArgs) Handles btnWeiter.Click
        Server.Transfer("Kaufabschluss.aspx", True)
    End Sub
End Class