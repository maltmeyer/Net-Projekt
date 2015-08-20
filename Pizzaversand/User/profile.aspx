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
        <SuccessTemplate>
            <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                <tr>
                    <td>
                        <table cellpadding="0">
                            <tr>
                                <td align="center" colspan="2">Change Password Complete</td>
                            </tr>
                            <tr>
                                <td>Your password has been changed!</td>
                            </tr>
                            <tr>
                                <td align="right" colspan="2">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </SuccessTemplate>
    </asp:ChangePassword>
    </asp:Content>