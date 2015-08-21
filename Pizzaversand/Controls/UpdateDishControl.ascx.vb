Public Class UpdateDishControl
    Inherits System.Web.UI.UserControl

    Dim identifier As Integer
    Dim ingredientList As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dataset As New DataSetGerichteTableAdapters.GerichteTableAdapter
        Dim datatable As Data.DataTable = dataset.GetData()

        If datatable.Rows.Count > 0 Then
            phDishes.Controls.Clear()
            For Each row As DataSetGerichte.GerichteRow In datatable.Rows
                Dim idstr = String.Format("{0:00}", row.Id)
                phDishes.Controls.Add(New LiteralControl(idstr & " - " & row.Name & " - " & row.Beschreibung & " - " & row.Zutaten & " - " & row.Photo & "<br/>"))
            Next
        End If
    End Sub

    Private Sub selectButton_Click(sender As Object, e As EventArgs) Handles selectButton.Click
        Dim id As Integer = Val(idBox.Text)
        Dim dataset As New DataSetGerichteTableAdapters.GerichteTableAdapter
        Dim datatable As Data.DataTable = dataset.GetEntry(id)

        If datatable.Rows.Count > 0 Then
            Table2.Visible = True
            Label3.Text = "Daten des Gerichtes"
            For Each row As DataSetGerichte.GerichteRow In datatable.Rows
                identifier = Val(row.Id)
                nameBox.Text = row.Name
                descBox.Text = row.Beschreibung
                ingredientList = row.Zutaten
                ingBox.Text = ingredientList
                showCheck.Enabled = row.Zeigen
            Next
        Else
            Table2.Visible = True
            Label3.Text = "Keine gültige ID angegeben."
        End If
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim dataset As New DataSetGerichteTableAdapters.GerichteTableAdapter
        Dim price As Double = calculatePrice()
        dataset.DishUpdate(nameBox.Text, descBox.Text, picUpload.FileName, showCheck.Enabled, ingBox.Text, price, identifier)
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
End Class