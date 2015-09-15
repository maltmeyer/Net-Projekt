Public Class addIngredient
    Inherits System.Web.UI.UserControl

    Dim manager As DatenbankManager = DatenbankManager.Instance

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub onConfirmClicked() Handles confirmButton.Click

        Dim zutat As New Zutat(ingredientNameBox.Text, Val(priceBox.Text))
        manager.updateOrAddZutat(zutat)

    End Sub


End Class