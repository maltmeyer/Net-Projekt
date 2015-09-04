<%@ Page MasterPageFile="~/MasterPage.master" Language="vb" AutoEventWireup="false" CodeBehind="Kaufabschluss.aspx.vb" Inherits="Pizzaversand.Kaufabschluss" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phBody" Runat="Server">
    <asp:PlaceHolder ID="phAbschluss" runat="server">

    <h1>Kontaktdaten</h1>
    <asp:PlaceHolder ID="phGerichte" runat="server">
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