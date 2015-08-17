Public Class WebUserControl1
    Inherits System.Web.UI.UserControl



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub saveDishButtonClick() Handles saveDishButton.Click
        Dim dishName As String = dishText.Text
        Dim description As String = descBox.Text
        Dim priceStr As String = priceBox.Text
        priceStr = priceStr.Replace(",", ".")
        Dim price As Double = Val(priceStr)
        Dim picPath As String = Upload.FileName
        Dim ingredients As String = ingBox.Text

        Dim dataset As New DataSetGerichteTableAdapters.GerichteTableAdapter

        dataset.InsertDish(dishName, description, picPath, True, ingredients, price)

    End Sub

    Protected Sub ingButtonClick() Handles ingedientButton.Click

    End Sub

End Class