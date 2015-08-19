<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="UpdateIngredientControl.ascx.vb" Inherits="Pizzaversand.WebUserControl2" %>
<asp:PlaceHolder ID="ingredients" runat="server"></asp:PlaceHolder>

<asp:Table ID="Table1" runat="server">
    <asp:TableHeaderRow>
        <asp:TableHeaderCell>
            <asp:Label ID="Label2" runat="server" Text="Zutatenwahl über ID"></asp:Label>

        </asp:TableHeaderCell>
    </asp:TableHeaderRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label1" runat="server" Text="ZutatenId:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="idBox" runat="server" TextMode="Number"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell>
            <asp:Button ID="getButton" runat="server" Text="Laden" />
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>
<br />
<asp:Table ID="Table2" runat="server" Visible="False">
    <asp:TableHeaderRow>
        <asp:TableHeaderCell>
            <asp:Label ID="Label3" runat="server" Text="Gewählte Zutat bearbeiten"></asp:Label>
        </asp:TableHeaderCell>
    </asp:TableHeaderRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label4" runat="server" Text="Name der Zutat:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label5" runat="server" Text="Preis der Zutat:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="priceBox" runat="server"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Button ID="updateButton" runat="server" Text="Update" />
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>
