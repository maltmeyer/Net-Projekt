Public Class home
    Inherits System.Web.UI.Page



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
        Dim imgFolderPath As String = Server.MapPath("~/UserUploadImages/")
        Dim images As List(Of String)
        images = getImageNames(imgFolderPath)
        Dim index As Integer = ViewState("imgCounter")
        If index >= images.Count Then
            index = 0
        End If
        imgAngebot.ImageUrl = images(index)
        index += 1
        ViewState("imgCounter") = index
    End Sub

    ''' <summary>
    ''' Gibt alle Dateinamen eines Ordners in passendem Format zurück
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
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ViewState("imgCounter") = 0
            showNextImage()

        End If

        'Dim user As MembershipUser = Membership.GetUser(True)
        'If Not IsNothing(user) Then
        '    Dim lbl As Label
        '    lbl = CType(Master.FindControl("lblUsername"), Label)
        '    lbl.Text = user.UserName

        'End If


    End Sub

End Class