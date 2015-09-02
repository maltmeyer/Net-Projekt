Public Class UpdateDishControl
    Inherits System.Web.UI.UserControl

    Dim manager As DatenbankManager = DatenbankManager.Instance
    Dim identifier As Integer
    Dim ingredientList As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dishList As List(Of Gericht) = manager.getGerichte()
        Dim zuList As New List(Of Zutat)
        Dim idList As String
        phDishes.Controls.Clear()
        For Each dish As Gericht In dishList
            zuList = dish.zutaten
            idList = ""
            For Each ing As Zutat In zuList
                idList = idList & ", " & ing.id
            Next
            phDishes.Controls.Add(New LiteralControl(String.Format("{0:00}", dish.id) & " - " & dish.name & " - " & dish.beschreibung & " - " & dish.photo & " - " & dish.zeigen & " - " & String.Format("{0:0.00}", dish.preis) & "<br />"))
        Next
    End Sub

    Private Sub selectButton_Click(sender As Object, e As EventArgs) Handles selectButton.Click
        Dim id As Integer = Val(idBox.Text)
        ingredientList = ""
        Dim gericht As Gericht = manager.getGericht(id)

        If gericht IsNot Nothing Then
            For Each entry As Zutat In gericht.zutaten
                ingredientList = ingredientList + ", " + String.Format("{0:00}", entry.id)
            Next
            Label3.Text = "Daten des Gerichtes"
            identifier = gericht.id
            nameBox.Text = gericht.name
            descBox.Text = gericht.beschreibung
            ingBox.Text = ingredientList
            showCheck.Enabled = gericht.zeigen
        Else
            Label3.Text = "Keine gültige ID angegeben."
        End If
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim price As Double = calculatePrice()
        Dim dish As New Gericht(nameBox.Text, descBox.Text, picUpload.FileName, showCheck.Enabled, price)
        dish.id = identifier
        manager.updateOrAddGericht(dish)
    End Sub

    Private Function calculatePrice() As Double
        Dim price As Double = 0
        Dim ing As Zutat = Nothing
        Dim ingredients() As String = Split(ingBox.Text, ", ")
        For Each value As String In ingredients
            ing = manager.getZutat(Val(value))
            price = price + ing.preis
        Next
        price = price + (price * (5 / 100))
        Return price
    End Function

End Class