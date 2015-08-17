<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="addDishControl.ascx.vb" Inherits="Pizzaversand.WebUserControl1" %>

<asp:Table ID="Table1" runat="server">
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label1" runat="server" Text="Name des Gerichts:"/>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="dishText" runat="server" Width="428px"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label2" runat="server" Text="Beschreibung:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="descBox" runat="server" TextMode="MultiLine" Width="427px" Height="53px"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label3" runat="server" Text="Zutaten:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="ingBox" runat="server" Width="428px"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell>
            <asp:Button ID="ingedientButton" runat="server" Text="Hinzufügen" />
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label4" runat="server" Text="Foto-URL:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:FileUpload ID="Upload" runat="server" />
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server" Text="Preis:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="priceBox" runat="server" Width="428px"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Button ID="saveDishButton" runat="server" Text="Gericht Speichern" />
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>




