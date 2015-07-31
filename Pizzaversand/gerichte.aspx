<%@ Page MasterPageFile="~/MasterPage.master" Language="vb" AutoEventWireup="false" CodeBehind="gerichte.aspx.vb" Inherits="Pizzaversand.gerichte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phBody" Runat="Server">

    <h1>All unsere Gerichte</h1>
    <asp:PlaceHolder ID="phGerichte" runat="server">
      <asp:Button runat="server" Text="1 Spalten" ID="btn1Spalte"/>
      <asp:Button runat="server" Text="2 Spalten" ID="btn2Spalten"/>

    </asp:PlaceHolder>

</asp:Content>
