﻿Public Class gerichte
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ladeGerichte1ProReihe()
        ladeGerichte()
    End Sub

    ''' <summary>
    ''' Lädt alle Gerichte aus der Datenbank(momentan noch nicht)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ladeGerichte2ProReihe()
        Dim liste As List(Of String)
        Dim imgFolderPath As String = Server.MapPath("~/UserUploadImages/")
        liste = getImageNames(imgFolderPath)


        Dim img As Image
        Dim label As LiteralControl
        Dim btnKaufen As Button
        Dim rowCounter As Integer = 0



        For Each datei As String In liste
            img = New Image
            img.ImageUrl = datei
            img.CssClass = "imgPanelGerichte"

            label = New LiteralControl
            label.Text = datei

            btnKaufen = New Button
            btnKaufen.Text = "In den Warenkorb"
            btnKaufen.CssClass = "btn btn-default"
            If rowCounter = 0 Then
                phGerichte.Controls.Add(New LiteralControl("<div class=""row"">"))
            End If



            phGerichte.Controls.Add(New LiteralControl("<div class=""col-lg-6"">"))
            phGerichte.Controls.Add(label)
            phGerichte.Controls.Add(New LiteralControl("<br/>"))
            phGerichte.Controls.Add(img)
            phGerichte.Controls.Add(New LiteralControl("<br/>"))

            phGerichte.Controls.Add(btnKaufen)
            phGerichte.Controls.Add(New LiteralControl("</div>"))

            If rowCounter = 1 Then
                phGerichte.Controls.Add(New LiteralControl("</div>")) 'row div
                phGerichte.Controls.Add(New LiteralControl("<div class=""row"">"))
                phGerichte.Controls.Add(New LiteralControl("<div class=""col-lg-6"">"))
                phGerichte.Controls.Add(New LiteralControl("<br/>"))
                phGerichte.Controls.Add(New LiteralControl("<br/>"))
                phGerichte.Controls.Add(New LiteralControl("<br/>"))
                phGerichte.Controls.Add(New LiteralControl("</div>"))

                phGerichte.Controls.Add(New LiteralControl("</div>"))
                rowCounter = 0
            Else
                rowCounter += 1
            End If
        Next

        'Bei ungerader anzahl Gerichte
        If rowCounter <> 0 Then
            phGerichte.Controls.Add(New LiteralControl("</div>"))
        End If

    End Sub


    Private Sub ladeGerichte()
        Dim dataset As New DataSetGerichteTableAdapters.GerichteTableAdapter
        Dim datatable As Data.DataTable = dataset.GetData
        Dim datasetZutaten As New DataSetZutatenTableAdapters.ZutatenTableAdapter

        Dim img As Image
        Dim label As LiteralControl
        Dim btnKaufen As Button

        If datatable.Rows.Count > 0 Then
            phGerichte.Controls.Clear()
            addTag("<Table>")
            For Each row As DataSetGerichte.GerichteRow In datatable.Rows
                img = New Image
                img.ImageUrl = "~/UserUploadImages/" & row.Photo
                img.CssClass = "imgPanelGerichte"

                label = New LiteralControl
                label.Text = row.Name

                btnKaufen = New Button
                btnKaufen.Text = "In den Warenkorb"
                btnKaufen.CssClass = "btn btn-default"

                addTag("<tr>")
                addTag("<td>")
                addTag("<div   class=""abstand"">")
                phGerichte.Controls.Add(img)
                addTag("</div>")
                addTag("<td>")
                addTag("<div class=""abstand2"">")
                addTag("<h3>" & row.Name & "</h3>")
                addTag("<p>" & row.Beschreibung & "</p>")
                addTag("<h4>" & "Zutaten" & "</h4>")




                For Each rowZutatID As DataSetConnectionGerichtZutat.Gericht_ZutatenRow In getZutaten(row.Id).Rows
                    Dim datatableZutat As Data.DataTable = datasetZutaten.getIngredient(rowZutatID.IdZutat)
                    For Each rowZutat As DataSetZutaten.ZutatenRow In datatableZutat.Rows
                        addTag("<p>" & rowZutat.Name & "</p>")
                    Next
                Next



                addTag("<p><b>" & String.Format("{0:0.00}", row.Preis) & " € </b></p>")
                phGerichte.Controls.Add(btnKaufen)
                addTag("</div>")
                addTag("</td>")
                addTag("</tr>")

            Next
            addTag("</table>")
        End If
    End Sub

    Private Function getZutaten(ByVal gerichtID As Integer) As Data.DataTable
        Dim dataset As New DataSetConnectionGerichtZutatTableAdapters.Gericht_ZutatenTableAdapter
        Dim datatable As Data.DataTable = dataset.getIngredients(gerichtID)
        Return datatable
    End Function

    ''' <summary>
    ''' Fügt ein neues html tag in phGerichte ein
    ''' </summary>
    ''' <param name="tag"></param>
    Private Sub addTag(ByVal tag As String)
        phGerichte.Controls.Add(New LiteralControl(tag))
    End Sub

    Public Sub ladeGerichte1ProReihe()
        Dim liste As List(Of String)
        Dim imgFolderPath As String = Server.MapPath("~/UserUploadImages/")
        liste = getImageNames(imgFolderPath)



        Dim img As Image
        Dim label As LiteralControl
        Dim btnKaufen As Button

        phGerichte.Controls.Add(New LiteralControl("<table>"))
        For Each datei As String In liste
            img = New Image
            img.ImageUrl = datei
            img.CssClass = "imgPanelGerichte"

            label = New LiteralControl
            label.Text = datei

            btnKaufen = New Button
            btnKaufen.Text = "In den Warenkorb"
            btnKaufen.CssClass = "btn btn-Default"

            phGerichte.Controls.Add(New LiteralControl("<tr>"))
            phGerichte.Controls.Add(New LiteralControl("<td>"))
            phGerichte.Controls.Add(New LiteralControl("<div   Class=""abstand"">"))
            phGerichte.Controls.Add(img)
            phGerichte.Controls.Add(New LiteralControl("</div"))
            phGerichte.Controls.Add(New LiteralControl("</td>"))

            phGerichte.Controls.Add(New LiteralControl("<td>"))
            phGerichte.Controls.Add(New LiteralControl("<div Class=""abstand2"">"))
            phGerichte.Controls.Add(New LiteralControl("<h3>" & "Super Salami Piza" & "</h3>"))

            phGerichte.Controls.Add(New LiteralControl("<p>" & _
                                                       "Diese mit extra Salami belegte Pizza schmeckt extrem gut" & _
                                                       "</p>"))

            phGerichte.Controls.Add(New LiteralControl("<h4>" & "Zutaten" & "</h4>"))
            phGerichte.Controls.Add(New LiteralControl("<ul>" & _
                                                       "<li>Salami</li>" & _
                                                       "<li>Salami</li>" & _
                                                       "<li>Käse</li>" & _
                                                       "</ul>"))
            phGerichte.Controls.Add(New LiteralControl("<p><b>" & "6, 99€" & "</b></p>"))

            phGerichte.Controls.Add(btnKaufen)
            phGerichte.Controls.Add(New LiteralControl("</div>"))
            phGerichte.Controls.Add(New LiteralControl("</td>"))
            phGerichte.Controls.Add(New LiteralControl("</tr>"))

        Next
        phGerichte.Controls.Add(New LiteralControl("</table>"))


    End Sub


    ''' <summary>
    ''' Gibt alle Dateinamen eines Ordners in passendem Format zurück(Kopie)
    ''' </summary>
    ''' <param name="imgFolderPath"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getImageNames(ByVal imgFolderPath As String) As List(Of String)
        Dim tmpName As String
        Dim images As New List(Of String)
        For Each s As String In My.Computer.FileSystem.GetFiles(imgFolderPath)
            Dim ind As Integer = s.LastIndexOf("\")
            tmpName = s.Substring(ind, s.Length - ind)
            tmpName = "~/UserUploadImages" & tmpName
            images.Add(tmpName)
        Next
        Return images
    End Function

    Protected Sub btn2Spalten_Click(sender As Object, e As EventArgs) Handles btn2Spalten.Click
        phGerichte.Controls.Clear()
        ladeGerichte2ProReihe()

    End Sub

    Protected Sub btn1Spalte_Click(sender As Object, e As EventArgs) Handles btn1Spalte.Click
        phGerichte.Controls.Clear()
        ladeGerichte1ProReihe()
    End Sub

End Class