<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="updateDishPage.aspx.vb" Inherits="Pizzaversand.updateDishPage" %>
<%@ Register TagPrefix="pizza" TagName="upDish" Src="~/Controls/UpdateDishControl.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phBody" runat="server">
    <pizza:upDish ID="upDishCon" runat="server" />
</asp:Content>
