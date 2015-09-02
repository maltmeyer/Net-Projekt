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
                idList = idList + ", " + ing.id
            Next
            phDishes.Controls.Add(New LiteralControl(String.Format("{0:00}", dish.id) & " - " & dish.name & " - " & dish.beschreibung & " - " & dish.photo & " - " & dish.zeigen & " - " & String.Format("{0:0.00}", dish.preis)))
        Next
    End Sub

    Private Sub selectButton_Click(sender As Object, e As EventArgs) Handles selectButton.Click
        Dim id As Integer = Val(idBox.Text)
        ingredientList = ""
        Dim dataset As New DataSetGerichteTableAdapters.GerichteTableAdapter
        Dim connected As New DataSetConnectionGerichtZutatTableAdapters.Gericht_ZutatenTableAdapter
        Dim datatable As Data.DataTable = dataset.GetEntry(id)
        Dim ingTable As Data.DataTable = connected.getIngredients(id)

        If ingTable.Rows.Count > 0 Then
            For Each zuRow As DataSetConnectionGerichtZutat.Gericht_ZutatenRow In ingTable.Rows
                ingredientList = ingredientList & ", " & String.Format("{0:00}", zuRow.IdZutat)
            Next
        End If

        If datatable.Rows.Count > 0 Then
            Label3.Text = "Daten des Gerichtes"
            For Each row As DataSetGerichte.GerichteRow In datatable.Rows
                identifier = Val(row.Id)
                nameBox.Text = row.Name
                descBox.Text = row.Beschreibung
                ingBox.Text = ingredientList
                showCheck.Enabled = row.Zeigen
            Next
        Else
            Label3.Text = "Keine gültige ID angegeben."
        End If
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim dataset As New DataSetGerichteTableAdapters.GerichteTableAdapter
        Dim price As Double = calculatePrice()
        dataset.dishUpdate(nameBox.Text, descBox.Text, picUpload.FileName, showCheck.Enabled, price, identifier)
        connectionUpdate(ingBox.Text)
    End Sub

    Private Function calculatePrice() As Double
        Dim dataset As New DataSetZutatenTableAdapters.ZutatenTableAdapter
        Dim price As Double = 0
        Dim ingredients() As String = Split(ingredientList, ", ")
        For Each value As String In ingredients
            price = price + dataset.getPreis(Val(value))
        Next
        price = price + (price * (5 / 100))
        Return price
    End Function

    Private Sub connectionUpdate(idList As String)
        Dim dataset As New DataSetConnectionGerichtZutatTableAdapters.Gericht_ZutatenTableAdapter
        dataset.DeleteQuery(identifier)
        Dim array1() As String = Split(idList, ", ")
        For Each entry As String In array1
            dataset.InsetConnection(identifier, Val(entry))
        Next
    End Sub
End Class