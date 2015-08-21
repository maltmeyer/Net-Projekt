<%@ Page MasterPageFile="~/MasterPage.master" Language="vb" AutoEventWireup="false" CodeBehind="profile.aspx.vb" Inherits="Pizzaversand.profile" %>

<asp:Content ID="content" ContentPlaceHolderID="phBody" Runat="Server">

    <h1>
        <asp:Label ID="lblHeader" runat="server" Text="Label"></asp:Label></h1>
      <asp:Label ID="lblGespeichert" runat="server" Text=""></asp:Label></h1>
    
    <table>
        <tr>
            <td align="center" style="height: 20px">Deine Information</td>
        </tr>
        <asp:RadioButton ID="rbH" runat="server" GroupName="Anrede" Text="Herr" />
        <asp:RadioButton ID="rbF" runat="server" GroupName="Anrede" Text="Frau" />
        <tr>
            <td>Vorname:</td>
            <td>
                <asp:TextBox ID="txtVorname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Nachname:</td>
            <td>
                <asp:TextBox ID="txtNachname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Straße:</td>
            <td>
                <asp:TextBox ID="txtStraße" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Hausnummer:</td>
            <td>
                <asp:TextBox ID="txtHausnummer" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>PLZ:</td>
            <td>
                <asp:TextBox ID="txtPLZ" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Ort:</td>
            <td>
                <asp:TextBox ID="txtOrt" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Telefonnummer:</td>
            <td>
                <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <asp:Button ID="btnSave" runat="server" Text="Speichern" />

    <asp:ChangePassword ID="ChangePassword1" runat="server">
        <ChangePasswordTemplate>
            <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                <tr>
                    <td>
                        <table cellpadding="0">
                            <tr>
                                <td align="center" colspan="2">Change Your Password</td>
                            </tr>
                            <tr>
                                <td align="right" style="height: 25px">
                                    <asp:Label ID="CurrentPasswordLabel" runat="server" AssociatedControlID="CurrentPassword">Password:</asp:Label>
                                </td>
                                <td style="height: 25px">
                                    <asp:TextBox ID="CurrentPassword" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="CurrentPasswordRequired" runat="server" ControlToValidate="CurrentPassword" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="NewPasswordLabel" runat="server" AssociatedControlID="NewPassword">New Password:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="NewPassword" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="NewPasswordRequired" runat="server" ControlToValidate="NewPassword" ErrorMessage="New Password is required." ToolTip="New Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="ConfirmNewPasswordLabel" runat="server" AssociatedControlID="ConfirmNewPassword">Confirm New Password:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="ConfirmNewPassword" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="ConfirmNewPasswordRequired" runat="server" ControlToValidate="ConfirmNewPassword" ErrorMessage="Confirm New Password is required." ToolTip="Confirm New Password is required." ValidationGroup="ChangePassword1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2" style="height: 20px">
                                    <asp:CompareValidator ID="NewPasswordCompare" runat="server" ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword" Display="Dynamic" ErrorMessage="The Confirm New Password must match the New Password entry." ValidationGroup="ChangePassword1"></asp:CompareValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2" style="color:Red;">
                                    <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">&nbsp;</td>
                                <td>
                                    <asp:Button ID="ChangePasswordPushButton" runat="server" CommandName="ChangePassword" Text="Change Password" ValidationGroup="ChangePassword1" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </ChangePasswordTemplate>
        <SuccessTemplate>
            <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                <tr>
                    <td>
                        <table cellpadding="0">
                            <tr>
                                <td align="center">Change Password Complete</td>
                            </tr>
                            <tr>
                                <td>Your password has been changed!</td>
                            </tr>
                            <tr>
                                <td align="right">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </SuccessTemplate>
    </asp:ChangePassword>
    </asp:Content>