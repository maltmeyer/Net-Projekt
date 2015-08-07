<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="addIngredientControl.ascx.vb" Inherits="Pizzaversand.addIngredient" %>


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
            <asp:Label ID="Label2" runat="server" Text="Beschreibung:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="descBox" runat="server" TextMode="MultiLine"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label3" runat="server" Text="Preis:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="priceBox" runat="server"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Button ID="confirmButton" runat="server" Text="Bestätigen" />
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>



