<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="UpdateIngredientControl.ascx.vb" Inherits="Pizzaversand.WebUserControl2" %>
<asp:PlaceHolder ID="ingredients" runat="server"></asp:PlaceHolder>

<table>
    <tr>
        <th>
            <asp:Label ID="Label2" runat="server" Text="Zutatenwahl über ID"></asp:Label>
        </th>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="ZutatenId:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="idBox" runat="server" TextMode="Number"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="getButton" runat="server" Text="Laden" />
        </td>
    </tr>
</table>
<br />
<table>
    <tr>
        <th>
            <asp:Label ID="Label3" runat="server" Text="Gewählte Zutat bearbeiten"></asp:Label>
        </th>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Name der Zutat:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="Preis (Format 0.00):"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="priceBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="updateButton" runat="server" Text="Update" />
        </td>
    </tr>
</table>
<asp:RegularExpressionValidator ID="priceValidator" runat="server" ErrorMessage="Preis entspricht nicht dem vorgegebenen Format (2 Dezimalstellen, Trennzeichen ist Punkt)"
                ValidationExpression="[0-9]\.[0-9]{2}" ControlToValidate="priceBox" />