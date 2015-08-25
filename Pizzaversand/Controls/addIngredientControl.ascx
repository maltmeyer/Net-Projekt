<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="addIngredientControl.ascx.vb" Inherits="Pizzaversand.addIngredient" %>



<style type="text/css">
    .auto-style1 {
        width: 170px;
    }
</style>





<table style="width: 100%;">
    <tr>
        <td class="auto-style1">
            <asp:RequiredFieldValidator ID="nameThereValidator" runat="server" Text="Zutat:" ErrorMessage="Bitte einen Namen eingeben" ControlToValidate="ingredientNameBox" />
        </td>
        <td>
            <asp:TextBox ID="ingedientNameBox" runat="server" Width="230px"/>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:RequiredFieldValidator ID="priceThereValidator" runat="server" Text="Preis: (Format: 0.00)" ErrorMessage="Bitte einen Preis eingeben" ControlToValidate="priceBox" /><br />
            <asp:RegularExpressionValidator ID="priceFormatValidator" runat="server" ErrorMessage="Falsches Format." 
                ControlToValidate="priceBox" ValidationExpression="[0-9]\.[0-9]{2}" />
        </td>
        <td>
            <asp:TextBox ID="priceBox" runat="server" TextMode="Number" Width="230px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Button ID="confirmButton" runat="server" Text="Bestätigen" Width="166px" />
        </td>
    </tr>
</table>


