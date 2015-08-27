﻿Public Class WebUserControl1
    Inherits System.Web.UI.UserControl



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ingDataset As New DataSetZutatenTableAdapters.ZutatenTableAdapter
        Dim datatable As Data.DataTable = ingDataset.GetData()

        If datatable.Rows.Count > 0 Then
            phIngredients.Controls.Clear()
            For Each row As DataSetZutaten.ZutatenRow In datatable.Rows
                Dim id As String = String.Format("0:00", row.Id)
                Dim price As String = String.Format("0:0.00", row.Preis)
                phIngredients.Controls.Add(New LiteralControl(id & " - " & row.Name & " - " & price & "€<br/>"))
            Next
        End If
    End Sub

    Protected Sub saveDishButtonClick() Handles saveDishButton.Click
        Dim dishName As String = dishText.Text
        Dim description As String = descBox.Text
        Dim price As Double = calculatePrice()
        Dim picPath As String = Upload.FileName
        Dim ingredients As String = ingBox.Text

        Dim dataset As New DataSetGerichteTableAdapters.GerichteTableAdapter

        dataset.InsertDish(dishName, description, picPath, showCheck.Enabled, ingredients, price)

    End Sub

    Private Function calculatePrice() As Double
        Dim price As Double = 0
        Dim dataset As New DataSetZutatenTableAdapters.ZutatenTableAdapter
        Dim ingredients() As String = Split(ingBox.Text, ", ")
        For Each value As String In ingredients
            price = price + dataset.getPreis(Val(value))
        Next
        price = price + (price * (5 / 100))
        Return price
    End Function

End Class