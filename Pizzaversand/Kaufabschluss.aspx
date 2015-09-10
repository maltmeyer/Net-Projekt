<%@ Page MasterPageFile="~/MasterPage.master" Language="vb" AutoEventWireup="false" CodeBehind="Kaufabschluss.aspx.vb" Inherits="Pizzaversand.Kaufabschluss" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phBody" Runat="Server">
    <asp:PlaceHolder ID="phAbschluss" runat="server">

    <h1>Kontaktdaten</h1>
     
    <asp:PlaceHolder ID="phGerichte" runat="server">
     <table>
        <tr>
             <asp:RadioButton ID="rbH" runat="server" GroupName="Anrede" Text="Herr" />
        <asp:RadioButton ID="rbF" runat="server" GroupName="Anrede" Text="Frau" />
        </tr>
      
        <tr>
            <td>Vorname:</td>
            <td>
                <asp:TextBox ID="txtVorname" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorVorname" runat="server" ErrorMessage="Vorname angeben" ControlToValidate="txtVorname" Display="Dynamic" ForeColor ="red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorVorname" runat="server" ErrorMessage="Ungültiger Vorname" ValidationExpression="^[a-zA-Z''-'\s]{1,40}$" ControlToValidate ="txtVorname" Display="Dynamic" ForeColor ="red"></asp:RegularExpressionValidator>
            </td>
                </tr>
        <tr>
            <td>Nachname:</td>
            <td>
                <asp:TextBox ID="txtNachname" runat="server"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidatorNachname" runat="server" ErrorMessage="Nachname angeben" ControlToValidate="txtNachname" Display="Dynamic" ForeColor ="red"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidatorNachname" runat="server" ErrorMessage="Ungültiger Nachname" ValidationExpression="^[a-zA-Z''-'\s]{1,40}$" ControlToValidate ="txtNachname" Display="Dynamic" ForeColor ="red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Straße:</td>
            <td>
                <asp:TextBox ID="txtStraße" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorStraße" runat="server" ErrorMessage="Straße angeben" ControlToValidate="txtStraße" Display="Dynamic" ForeColor ="red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorStraße" runat="server" ErrorMessage="Ungültige Straße" ValidationExpression="^[a-zA-Z''-'\s]{1,40}$" ControlToValidate ="txtStraße" Display="Dynamic" ForeColor ="red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Hausnummer:</td>
            <td>
                <asp:TextBox ID="txtHausnummer" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorHausnummer" runat="server" ErrorMessage="Hausnummer angeben" ControlToValidate="txtHausnummer" Display="Dynamic" ForeColor ="red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>PLZ:</td>
            <td>
                <asp:TextBox ID="txtPLZ" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPLZ" runat="server" ErrorMessage="Postleitzahl angeben" ControlToValidate="txtPLZ" Display="Dynamic" ForeColor ="red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorPLZ" runat="server" ErrorMessage="Ungültige PLZ" ValidationExpression="^\d+$" ControlToValidate ="txtPLZ" Display="Dynamic" ForeColor ="red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Ort:</td>
            <td>
                <asp:TextBox ID="txtOrt" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorOrt" runat="server" ErrorMessage="Wohnort angeben" ControlToValidate="txtOrt" Display="Dynamic" ForeColor ="red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorOrt" runat="server" ErrorMessage="Ungültiger Ort" ValidationExpression="^[a-zA-Z''-'\s]{1,40}$" ControlToValidate ="txtOrt" Display="Dynamic" ForeColor ="red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Telefonnummer:</td>
            <td>
                <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTelefon" runat="server" ErrorMessage="Telefonnummer angeben" ControlToValidate="txtTelefon" Display="Dynamic" ForeColor ="red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorTelefon" runat="server" ErrorMessage="Ungültige Telefonnummer" ValidationExpression="^\d+$" ControlToValidate ="txtTelefon" Display="Dynamic" ForeColor ="red"></asp:RegularExpressionValidator>
            </td>
        </tr>
    </table>
    </asp:PlaceHolder>

    <b><asp:Label ID="lblWaren" runat="server" Text=""></asp:Label></b>
    <br />

    <asp:Button ID="btnKaufAbschließen" runat="server" Text="Kauf abschließen" />
     
          
    </asp:PlaceHolder>

    <asp:PlaceHolder ID="phErfolg" runat="server">
        <asp:Label ID="lblErfolg" runat="server" Text="Auftrag erfoglreich abgeschlossen. Ihre Bestellung wird ihnen zugesendet.">
        </asp:Label>
    </asp:PlaceHolder>
    
</asp:Content>