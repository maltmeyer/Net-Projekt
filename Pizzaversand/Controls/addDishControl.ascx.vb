Public Class WebUserControl1
    Inherits System.Web.UI.UserControl

    Dim manager As DatenbankManager = DatenbankManager.Instance

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub saveImage()
        Dim fileOK As Boolean = False
        If FileUpload1.HasFile Then
            Try
                Dim path As String = Server.MapPath("~/UserUploadImages/" & FileUpload1.FileName)

                Dim fileExtension As String
                fileExtension = System.IO.Path.
                    GetExtension(FileUpload1.FileName).ToLower()
                Dim allowedExtensions As String() =
                    {".jpg", ".jpeg", ".png", ".gif"}
                For i As Integer = 0 To allowedExtensions.Length - 1
                    If fileExtension = allowedExtensions(i) Then
                        fileOK = True
                    End If
                Next
                If fileOK Then
                    FileUpload1.SaveAs(path)
                    Label1.Text = "File name: " &
                       FileUpload1.PostedFile.FileName & "<br>" &
                       "File Size: " &
                       FileUpload1.PostedFile.ContentLength & " kb<br>" &
                       "Content type: " &
                       FileUpload1.PostedFile.ContentType
                End If

            Catch ex As Exception
                Label3.Text = "ERROR: " & ex.Message.ToString()
            End Try
        Else
            Label3.Text = "You have not specified a file."
        End If
    End Sub

    Protected Sub buttonSave_Click() Handles buttonSave.Click
        Dim atLeastOneRowSelected As Boolean = False
        Dim zuList As New List(Of Zutat)
        For Each row As GridViewRow In gridViewIngredients.Rows
            Dim cb As CheckBox = row.FindControl("ingredientselector")
            If cb IsNot Nothing AndAlso cb.Checked Then
                atLeastOneRowSelected = True
                Dim s As String = row.Cells(0).Text
                zuList.Add(manager.getZutat(Val(s)))
            End If
        Next
        Dim price As Double = calculatePrice(zuList)
        Dim gericht As New Gericht(dishText.Text, descBox.Text, FileUpload1.FileName, showCheck.Checked, price)

        gericht.zutaten = zuList
        manager.updateOrAddGericht(gericht)
        saveImage()

        lblSucess.Text = "Gericht hinzugefügt"

    End Sub

    Private Function calculatePrice(ByVal zuList As List(Of Zutat)) As Double
        Dim price As Double = 0
        For Each zutat As Zutat In zuList
            price = price + zutat.preis
        Next
        price = price + (price * (5 / 100))
        Return price
    End Function


End Class