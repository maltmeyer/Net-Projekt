Public Class home
    Inherits System.Web.UI.Page

    Dim manager As DatenbankManager = DatenbankManager.Instance

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        saveImage()

    End Sub

    ''' <summary>
    ''' Überprüft ein Bild im FileUpload und speichert es dann auf dem Server ab.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub saveImage()
        Dim fileOK As Boolean = False
        If FileUpload1.HasFile Then
            Try
                Dim path As String = Server.MapPath("~/UserUploadImages/" & FileUpload1.FileName)

                Dim fileExtension As String
                fileExtension = System.IO.Path. _
                    GetExtension(FileUpload1.FileName).ToLower()
                Dim allowedExtensions As String() = _
                    {".jpg", ".jpeg", ".png", ".gif"}
                For i As Integer = 0 To allowedExtensions.Length - 1
                    If fileExtension = allowedExtensions(i) Then
                        fileOK = True
                    End If
                Next
                If fileOK Then
                    FileUpload1.SaveAs(path)
                    Label1.Text = "File name: " & _
                       FileUpload1.PostedFile.FileName & "<br>" & _
                       "File Size: " & _
                       FileUpload1.PostedFile.ContentLength & " kb<br>" & _
                       "Content type: " & _
                       FileUpload1.PostedFile.ContentType
                End If

            Catch ex As Exception
                Label1.Text = "ERROR: " & ex.Message.ToString()
            End Try
        Else
            Label1.Text = "You have not specified a file."
        End If
    End Sub

    Protected Sub tImages_Tick(sender As Object, e As EventArgs) Handles tImages.Tick
        showNextImage()
    End Sub

    ''' <summary>
    ''' Holt sich die Liste aller aktuellen Bilder vom Server und zeigt das nächste Bild an.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub showNextImage()
        ' Dim imgFolderPath As String = Server.MapPath("~/UserUploadImages/")
        Dim imgFolderPath As String = "~/UserUploadImages/"

        Dim gerichte As List(Of Gericht) = manager.getGerichte
        If gerichte.Count > 0 Then
            Dim index As Integer = ViewState("imgCounter")
            If index >= gerichte.Count Then
                index = 0
            End If

            Dim gericht As Gericht = gerichte(index)
            lblVorschau.Text = gericht.name
            imgVorschau.ImageUrl = imgFolderPath & gericht.photo
            index += 1
            ViewState("imgCounter") = index

        End If


    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ViewState("imgCounter") = 0
            showNextImage()

        End If

    End Sub

End Class