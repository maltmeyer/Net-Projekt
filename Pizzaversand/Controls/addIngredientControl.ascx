<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="addIngredientControl.ascx.vb" Inherits="Pizzaversand.addIngredient" %>

<asp:RequiredFieldValidator ID="nameThereValidator" runat="server" ErrorMessage="Bitte einen Namen eingeben" ControlToValidate="ingredientNameBox"></asp:RequiredFieldValidator>
<asp:RequiredFieldValidator ID="priceThereValidator" runat="server" ErrorMessage="Bitte einen Preis eingeben" ControlToValidate="priceBox"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="priceFormatValidator" runat="server" ErrorMessage="Preis entspricht nicht dem vorgegebenen Format (2 Dezimalstellen, Trennzeichen ist Punkt)" 
    ControlToValidate="priceBox" ValidationExpression="[0-9]\.[0-9]{2}"></asp:RegularExpressionValidator>

<asp:Table ID="mask" runat="server">
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label1" runat="server" Text="Zutat:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="ingedientNameBox" runat="server"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label3" runat="server" Text="Preis:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="priceBox" runat="server" TextMode="Number"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Button ID="confirmButton" runat="server" Text="Bestätigen" />
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>


