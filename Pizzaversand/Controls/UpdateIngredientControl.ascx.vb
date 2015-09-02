Imports Pizzaversand.DataSetZutatenTableAdapters

Public Class WebUserControl2
    Inherits System.Web.UI.UserControl

    Dim manager As DatenbankManager = DatenbankManager.Instance()
    Dim idOfIngredient As Integer = -1
    Dim name As String
    Dim price As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim zuList As List(Of Zutat) = manager.getZutaten()
        ingredients.Controls.Clear()
        For Each zutat As Zutat In zuList
            ingredients.Controls.Add(New LiteralControl(String.Format("{0:00}", zutat.id) & " - " & zutat.name() & " - " & String.Format("{0:0.00}", zutat.preis) & "<br \>"))
        Next
    End Sub

    Private Sub getButton_Click(sender As Object, e As EventArgs) Handles getButton.Click
        Dim id As Integer = Val(idBox.Text)
        Dim zutat As Zutat = manager.getZutat(id)

        If zutat IsNot Nothing Then
            Label3.Text = "Gewählte Zutat bearbeiten"
            idOfIngredient = Val(zutat.id)
            name = zutat.name
            price = String.Format("{0:0.00}", zutat.preis)
            nameBox.Text = name
            priceBox.Text = price
        Else
            Label3.Text = "Id nicht vorhanden, bitte andere Zutat auswählen"
        End If

    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim zutat As New Zutat(nameBox.Text, Val(priceBox.Text))
        zutat.id = idOfIngredient
        manager.updateOrAddZutat(zutat)
    End Sub

End Class