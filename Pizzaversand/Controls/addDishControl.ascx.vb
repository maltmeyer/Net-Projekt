Public Class WebUserControl1
    Inherits System.Web.UI.UserControl

    Dim manager As DatenbankManager = DatenbankManager.Instance

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ingList As List(Of Zutat) = manager.getZutaten()
        phIngredients.Controls.Clear()

        For Each zutat As Zutat In ingList
            phIngredients.Controls.Add(New LiteralControl(String.Format("{0:00}", zutat.id) & " - " & zutat.name & " - " & String.Format("{0:0.00}", zutat.preis) & "<br />"))
        Next

    End Sub

    Protected Sub saveDishButtonClick() Handles saveDishButton.Click
        Dim ingredientsList As String() = Split(ingBox.Text, ", ")
        Dim zuList As New List(Of Zutat)
        For Each num As String In ingredientsList
            zuList.Add(manager.getZutat(Val(num)))
        Next
        Dim price As Double = calculatePrice(zuList)
        Dim gericht As New Gericht(dishText.Text, descBox.Text, Upload.FileName, showCheck.Checked, price)

        gericht.zutaten = zuList
        manager.updateOrAddGericht(gericht)

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