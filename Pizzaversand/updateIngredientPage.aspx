<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="updateIngredientPage.aspx.vb" Inherits="Pizzaversand.updateIngredientPage" %>
<%@ Register TagName="updateDishControl" TagPrefix="pizza" Src="~/Controls/UpdateIngredientControl.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phBody" runat="server">
    <pizza:updateDishControl ID="updateIngContr" runat="server" />
</asp:Content>
