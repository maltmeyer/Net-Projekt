<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="addDishPage.aspx.vb" Inherits="Pizzaversand.WebForm1" %>
<%@ Register TagPrefix="pizza" TagName="addDish" Src="~/Controls/addDishControl.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phBody" runat="server">
    <pizza:addDish ID="adDishCon" runat="server" />
</asp:Content>
