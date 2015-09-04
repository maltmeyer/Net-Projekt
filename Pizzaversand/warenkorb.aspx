<%@ Page MasterPageFile="~/MasterPage.master" Language="vb" AutoEventWireup="false" CodeBehind="warenkorb.aspx.vb" Inherits="Pizzaversand.warenkorb" %>

<asp:Content ID="content" ContentPlaceHolderID="phBody" Runat="Server">
     <h1>Warenkorb</h1>
    <asp:PlaceHolder ID="phGerichte" runat="server">

    </asp:PlaceHolder>
    <asp:Button ID="btnAktualisieren" runat="server" Text="Aktualisieren" />
    <asp:Button ID="btnWeiter" runat="server" Text="Weiter" />
</asp:Content>
