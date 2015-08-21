Public Class Register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CreateUserWizard1.ActiveStepIndex = 0
        End If

    End Sub

    Protected Sub ContinueButton_Click(sender As Object, e As EventArgs)

    End Sub


    Protected Sub CreateUserWizard1_CreatedUser(sender As Object, e As EventArgs) Handles CreateUserWizard1.CreatedUser

    End Sub

    Private Sub setValue(ByVal propertyName As String, ByVal value As Object)
        HttpContext.Current.Profile.SetPropertyValue(propertyName, value)
    End Sub

    Private Sub CreateUserWizard1_FinishButtonClick(sender As Object, e As WizardNavigationEventArgs) Handles CreateUserWizard1.FinishButtonClick
        Dim txtUsername As TextBox = CType(CreateUserWizard1.CreateUserStep.ContentTemplateContainer.FindControl("UserName"), TextBox)

        Dim user As MembershipUser = Membership.GetUser(txtUsername.Text)

        'Profile.vorname funktioniert in einem Projekt nicht, nur Webseite
        setValue("anrede", rbH.Checked)
        setValue("vorname", txtVorname.Text)
        setValue("nachname", txtNachname.Text)
        setValue("strasse", txtStraße.Text)
        setValue("hausnummer", txtHausnummer.Text)
        setValue("plz", txtPLZ.Text)
        setValue("ort", txtOrt.Text)
        setValue("telefon", txtTelefon.Text)
        HttpContext.Current.Profile.Save()
    End Sub

    Protected Sub ContinueButton_Click1(sender As Object, e As EventArgs)
        'MsgBox(CreateUserWizard1.ActiveStepIndex)
        'If (CreateUserWizard1.ActiveStepIndex = 2) Then
        '    CreateUserWizard1.ActiveStepIndex = 0
        'End If
        'Server.Transfer("home.aspx")
    End Sub
End Class