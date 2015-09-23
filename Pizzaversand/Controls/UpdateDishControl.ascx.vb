
Public Class UpdateDishControl
    Inherits System.Web.UI.UserControl


    Private Sub GridViewDishes_RowUpdating(sender As Object, e As GridViewUpdateEventArgs) Handles GridViewDishes.RowUpdating
        Dim index As Integer = GridViewDishes.EditIndex
        Dim row As GridViewRow = GridViewDishes.Rows(index)

        Dim photo As FileUpload = CType(row.FindControl("fileUpload"), FileUpload)
        e.NewValues("Photo") = photo.FileName

    End Sub


End Class