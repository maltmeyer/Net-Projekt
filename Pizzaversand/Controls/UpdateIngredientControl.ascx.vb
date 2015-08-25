Imports Pizzaversand.DataSetZutatenTableAdapters

Public Class WebUserControl2
    Inherits System.Web.UI.UserControl

    Dim idOfIngredient As Integer
    Dim name As String
    Dim price As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dataset As New DataSetZutatenTableAdapters.ZutatenTableAdapter
        Dim datatable As Data.DataTable = dataset.GetData()

        If datatable.Rows.Count > 0 Then
            ingredients.Controls.Clear()
            For Each row As DataSetZutaten.ZutatenRow In datatable.Rows
                Dim pricestr As String = String.Format("{0:0.00}", row.Preis)
                Dim idstr As String = String.Format("{0:00}", row.Id)
                ingredients.Controls.Add(New LiteralControl(idstr & " - " & row.Name & " - " & pricestr & "€" & "<br />"))
            Next
        End If

    End Sub

    Private Sub getButton_Click(sender As Object, e As EventArgs) Handles getButton.Click
        Dim id As Integer = Val(idBox.Text)
        Dim dataset As New DataSetZutatenTableAdapters.ZutatenTableAdapter
        Dim datatable As Data.DataTable = DataSet.GetIngredient(id)

        If datatable.Rows.Count > 0 Then
            For Each row As DataSetZutaten.ZutatenRow In datatable.Rows
                idOfIngredient = Val(row.Id)
                name = row.Name
                price = String.Format("{0:0.00}", row.Preis)
            Next
            Label3.Text = "Gewählte Zutat bearbeiten"
            nameBox.Text = name
            priceBox.Text = price
        Else
            Label3.Text = "Id nicht vorhanden, bitte andere Zutat auswählen"
        End If

    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim dataset As New DataSetZutatenTableAdapters.ZutatenTableAdapter
        Dim price As Double = Val(priceBox.Text)
        dataset.IngredientUpdate(nameBox.Text, price, idOfIngredient)
    End Sub

End Class