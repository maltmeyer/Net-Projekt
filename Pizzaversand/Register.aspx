<%@ Page MasterPageFile="~/MasterPage.master" Language="vb" AutoEventWireup="false" CodeBehind="register.aspx.vb" Inherits="Pizzaversand.register" %>
<asp:Content ID="content" ContentPlaceHolderID="phBody" Runat="Server">



    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" ContinueDestinationPageUrl="~/home.aspx">
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server">
                <ContentTemplate>
                    <table>
                        <tr>
                            <td align="center" colspan="2">Sign Up for Your New Account</td>
                        </tr>
                        <tr> <!-- Benutzername -->
                            <td align="right">
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="UserName" runat="server" ></asp:TextBox>
                                
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                         <%--<tr> <!-- Email -->
                            <td align="right" style="height: 42px">
                                <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:</asp:Label>
                            </td>
                            <td style="height: 42px">
                                <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" ErrorMessage="E-mail is required." ToolTip="E-mail is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>--%>
                        </tr>
                        <tr> <!-- Password -->
                            <td align="right">
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr> <!-- confirm password -->
                            <td align="right">
                                <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Password:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="Confirm Password is required." ToolTip="Confirm Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                       
         
                        <tr>
                            <td align="center" colspan="2">
                                <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="The Password and Confirmation Password must match." ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2" style="color:Red;">
                                <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:CreateUserWizardStep>
            <asp:WizardStep runat="server" AllowReturn="False" >
               <ContentTemplate>
                    <table>
                        <tr>
                            <td align="center" style="height: 20px">Additional information</td>
                        </tr>
                         <asp:RadioButton ID="rbH" runat="server" GroupName="Anrede" Text="Herr" />
                        <asp:RadioButton ID="rbF" runat="server" GroupName="Anrede" Text="Frau" />
                        <tr>
                            <td>Vorname:</td>
                            <td><asp:TextBox ID="txtVorname" runat="server"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>Nachname:</td>
                            <td><asp:TextBox ID="txtNachname" runat="server"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>Straße:</td>
                            <td><asp:TextBox ID="txtStraße" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Hausnummer:</td>
                            <td><asp:TextBox ID="txtHausnummer" runat="server"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>PLZ:</td>
                            <td><asp:TextBox ID="txtPLZ" runat="server"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>Ort:</td>
                            <td><asp:TextBox ID="txtOrt" runat="server"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>Telefonnummer:</td>
                            <td><asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox></td>
                        </tr>
                    </table>
             </ContentTemplate>

            </asp:WizardStep>
            <asp:CompleteWizardStep runat="server">
                <ContentTemplate>
                    <table>
                        <tr>
                            <td align="center">Complete</td>
                        </tr>
                        <tr>
                            <td>Your account has been successfully created.</td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Button ID="ContinueButton" runat="server" CausesValidation="False" CommandName="Continue" OnClick="ContinueButton_Click1" Text="Continue" ValidationGroup="CreateUserWizard1" />
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:CompleteWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>



</asp:Content>