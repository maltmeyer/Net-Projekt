Public Class WebUserControl1
    Inherits System.Web.UI.UserControl

    Dim dishName As String
    Dim description As String
    Dim price As String
    Dim picPath As String
    Dim ingredients As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dishName = ""
        description = ""
        price = ""
        picPath = ""
        ingredients = ""
    End Sub



    Protected Sub addDish()

    End Sub

    Protected Sub saveDishButtonClick() Handles saveDishButton.Click
        dishName = dishText.Text
        description = descBox.Text
        price = priceBox.Text
        picPath = picBox.Text
        ingredients = ingBox.Text
        addDish()
    End Sub

    Protected Sub picButtonClick() Handles picButton.Click

    End Sub

    Protected Sub ingButtonClick() Handles ingedientButton.Click

    End Sub

End Class