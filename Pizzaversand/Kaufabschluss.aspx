<%@ Page MasterPageFile="~/MasterPage.master" Language="vb" AutoEventWireup="false" CodeBehind="Kaufabschluss.aspx.vb" Inherits="Pizzaversand.Kaufabschluss" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phBody" Runat="Server">
    <asp:PlaceHolder ID="phAbschluss" runat="server">

    <h1>Kontaktdaten</h1>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <asp:PlaceHolder ID="phGerichte" runat="server">
     <table>
        <tr>
            <td  style="height: 20px">Deine Information</td>
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
    </asp:PlaceHolder>

    <b><asp:Label ID="lblWaren" runat="server" Text=""></asp:Label></b>
    <br />

    <asp:Button ID="btnKaufAbschließen" runat="server" Text="Kauf abschließen" />
        <!-- Required -->
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorVorname" runat="server" ErrorMessage="Vorname angeben" ControlToValidate="txtVorname"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNachname" runat="server" ErrorMessage="Nachname angeben" ControlToValidate="txtNachname"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorStraße" runat="server" ErrorMessage="Straße angeben" ControlToValidate="txtStraße"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorHausnummer" runat="server" ErrorMessage="Hausnummer angeben" ControlToValidate="txtHausnummer"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPLZ" runat="server" ErrorMessage="Postleitzahl angeben" ControlToValidate="txtPLZ"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorOrt" runat="server" ErrorMessage="Wohnort angeben" ControlToValidate="txtOrt"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorTelefon" runat="server" ErrorMessage="Telefonnummer angeben" ControlToValidate="txtTelefon"></asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator ID="RegularExpressionValidatorVorname" runat="server" ErrorMessage="Ungültiger Vorname" ValidationExpression="^[a-zA-Z''-'\s]{1,40}$" ControlToValidate ="txtVorname"></asp:RegularExpressionValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidatorNachname" runat="server" ErrorMessage="Ungültiger Nachname" ValidationExpression="^[a-zA-Z''-'\s]{1,40}$" ControlToValidate ="txtNachname"></asp:RegularExpressionValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidatorStraße" runat="server" ErrorMessage="Ungültige Straße" ValidationExpression="^[a-zA-Z''-'\s]{1,40}$" ControlToValidate ="txtStraße"></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorOrt" runat="server" ErrorMessage="Ungültiger Ort" ValidationExpression="^[a-zA-Z''-'\s]{1,40}$" ControlToValidate ="txtOrt"></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorTelefon" runat="server" ErrorMessage="Ungültige Telefonnummer" ValidationExpression="^\d+$" ControlToValidate ="txtTelefon"></asp:RegularExpressionValidator>
          <asp:RegularExpressionValidator ID="RegularExpressionValidatorPLZ" runat="server" ErrorMessage="Ungültige PLZ" ValidationExpression="^\d+$" ControlToValidate ="txtPLZ"></asp:RegularExpressionValidator>
    </asp:PlaceHolder>

    <asp:PlaceHolder ID="phErfolg" runat="server">
        <asp:Label ID="lblErfolg" runat="server" Text="Auftrag erfoglreich abgeschlossen. Ihre Bestellung wird ihnen zugesendet.">
        </asp:Label>
    </asp:PlaceHolder>
    
</asp:Content>