<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="UpdateDishControl.ascx.vb" Inherits="Pizzaversand.UpdateDishControl" %>
<asp:PlaceHolder ID="phDishes" runat="server"></asp:PlaceHolder>
<br />

<table>
    <tr>
        <th>
            <asp:Label ID="Label1" runat="server" Text="Welches Gericht?"></asp:Label>
        </th>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Id des Gerichtes:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="idBox" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="selectButton" runat="server" Text="Gericht wählen" />
        </td>
    </tr>
</table>
<br />
<table>
    <tr>
        <th>
            <asp:Label ID="Label3" runat="server" Text="Daten des Gerichtes"></asp:Label>
        </th>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Name des Gerichtes:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="Beschreibung des Gerichtes:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="descBox" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label6" runat="server" Text="Zutaten"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="ingBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label7" runat="server" Text="Photopfad:"></asp:Label>
        </td>
        <td>
            <asp:FileUpload ID="picUpload" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="showCheck" runat="server" Text="Eintrag in Karte anzeigen" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="updateButton" runat="server" Text="Gericht aktualisieren" />
        </td>
    </tr>
</table>

