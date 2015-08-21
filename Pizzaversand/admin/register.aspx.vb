Public Class register1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim dropdown As DropDownList = CType(CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("RoleDropDownList"), DropDownList)
            dropdown.DataSource = Roles.GetAllRoles()

            dropdown.DataBind()

        End If
    End Sub

    Private Sub CreateUserWizard1_CreatedUser(sender As Object, e As EventArgs) Handles CreateUserWizard1.CreatedUser
        Dim dropdown As DropDownList = CType(CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("RoleDropDownList"), DropDownList)
        Roles.AddUserToRole(CreateUserWizard1.UserName, dropdown.SelectedValue)
    End Sub
End Class