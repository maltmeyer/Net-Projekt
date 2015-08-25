<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="addDishControl.ascx.vb" Inherits="Pizzaversand.WebUserControl1" %>


<style type="text/css">
    .auto-style1 {
        width: 317px;
    }
</style>



<asp:PlaceHolder ID="phIngredients" runat="server"></asp:PlaceHolder><br />

<table style="width: 100%;">
    <tr>
        <td class="auto-style1">
            <asp:RequiredFieldValidator ID="nameValidator" runat="server" ErrorMessage="Bitte Namen angeben" Text="Name des Gerichts:" ControlToValidate="dishText" />
        </td>
        <td>
            <asp:TextBox ID="dishText" runat="server" Width="428px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="Beschreibung:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="descBox" runat="server" TextMode="MultiLine" Width="427px" Height="53px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:RequiredFieldValidator ID="ingredientsValidator" runat="server" Text="Zutaten:" ErrorMessage="Keine Zutatenliste angegeben" ControlToValidate="ingBox" ValidationGroup="ingLstVals" /><br />
            <asp:RegularExpressionValidator ID="ingredientsContentsValidator" runat="server" ErrorMessage="Zutatenliste muss aus Zahlen und Kommas bestehen"
                ControlToValidate="ingBox" ValidationExpression="([0-9]*, )*" ValidationGroup="ingLstVals" />
        </td>
        <td>
            <asp:TextBox ID="ingBox" runat="server" Width="428px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Foto-URL:"></asp:Label>
        </td>
        <td>
            <asp:FileUpload ID="Upload" runat="server" Width="434px" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="showCheck" runat="server" Text="Eintrag in Karte anzeigen"/>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="saveDishButton" runat="server" Text="Gericht Speichern" />
        </td>
    </tr>
</table>