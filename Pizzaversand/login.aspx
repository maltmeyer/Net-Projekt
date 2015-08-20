
<%@ Page MasterPageFile="~/MasterPage.master" Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="Pizzaversand.Login" %>
<asp:Content ID="content" ContentPlaceHolderID="phBody" Runat="Server">
    <h1>Anmelden</h1>
    <asp:Login ID="Login1" runat="server" MembershipProvider="SqlMembershipProvider" DestinationPageUrl="~/home.aspx"></asp:Login>
    </asp:Content>