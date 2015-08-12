Public Class addIngredient
    Inherits System.Web.UI.UserControl

    Dim name As String
    Dim desc As String
    Dim price As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub onConfirmClicked() Handles confirmButton.Click
        name = ingedientNameBox.Text
        desc = descBox.Text
        price = priceBox.Text
        updateTable()
    End Sub

    Protected Sub updateTable()

    End Sub

End Class