<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="addIngredientsPage.aspx.vb" Inherits="Pizzaversand.addIngredientsPage" %>
<%@ Register TagPrefix="pizza" TagName="addIngredients" Src="~/Controls/addIngredientControl.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phBody" runat="server">
    <pizza:addIngredients ID="ingContr" runat="server" />
</asp:Content>
