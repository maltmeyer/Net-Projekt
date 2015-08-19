<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="UpdateDishControl.ascx.vb" Inherits="Pizzaversand.UpdateDishControl" %>
<asp:PlaceHolder ID="phDishes" runat="server"></asp:PlaceHolder>
<br />

<asp:Table ID="Table1" runat="server">
    <asp:TableHeaderRow>
        <asp:TableHeaderCell>
            <asp:Label ID="Label1" runat="server" Text="Welches Gericht?"></asp:Label>
        </asp:TableHeaderCell>
    </asp:TableHeaderRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label2" runat="server" Text="Id des Gerichtes:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="idBox" runat="server"></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell>
            <asp:Button ID="selectButton" runat="server" Text="Gericht wählen" />
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>
<br />
<asp:Table ID="Table2" runat="server" Visible="false">
    <asp:TableHeaderRow>
        <asp:TableHeaderCell>
            <asp:Label ID="Label3" runat="server" Text="Daten des Gerichtes"></asp:Label>
        </asp:TableHeaderCell>
    </asp:TableHeaderRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label4" runat="server" Text="Name des Gerichtes:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label5" runat="server" Text="Beschreibung des Gerichtes:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="descBox" runat="server" TextMode="MultiLine"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label6" runat="server" Text="Zutaten"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="ingBox" runat="server"></asp:TextBox>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label ID="Label7" runat="server" Text="Photopfad:"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
            <asp:FileUpload ID="picUpload" runat="server" />
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Button ID="updateButton" runat="server" Text="Gericht aktualisieren" />
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>

