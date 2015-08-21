Public Class addIngredient
    Inherits System.Web.UI.UserControl



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub onConfirmClicked() Handles confirmButton.Click

        Dim name As String = ingedientNameBox.Text
        Dim price As Double = Val(priceBox.Text)

        Dim dataset As New DataSetZutatenTableAdapters.ZutatenTableAdapter

        dataset.InsertZutat(name, price)

    End Sub


End Class