<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="addDishControl.ascx.vb" Inherits="Pizzaversand.WebUserControl1" %>

<style type="text/css">
    .auto-style1 {
        width: 139px;
    }
    .auto-style2 {
        width: 321px;
    }
    .auto-style3 {
        width: 139px;
        height: 72px;
    }
    .auto-style4 {
        width: 321px;
        height: 72px;
    }
    .auto-style5 {
        height: 72px;
        width: 792px;
    }
    .auto-style6 {
        width: 792px;
    }
    .auto-style7 {
        width: 139px;
        height: 30px;
    }
    .auto-style8 {
        width: 321px;
        height: 30px;
    }
    .auto-style9 {
        width: 792px;
        height: 30px;
    }
</style>

<table style="width: 100%;">
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Name des Gerichts:"/>
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="dishText" runat="server" Width="428px"></asp:TextBox>
        </td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="Label2" runat="server" Text="Beschreibung:"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:TextBox ID="descBox" runat="server" TextMode="MultiLine" Width="427px" Height="53px"></asp:TextBox>
        </td>
        <td class="auto-style5"></td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="Label3" runat="server" Text="Zutaten:"></asp:Label>
        </td>
        <td class="auto-style8">
            <asp:TextBox ID="ingBox" runat="server" Width="428px"></asp:TextBox>
        </td>
        <td class="auto-style9">
            <asp:Button ID="ingedientButton" runat="server" Text="Hinzufügen" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Foto-URL:"></asp:Label>
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="picBox" runat="server" Width="428px"></asp:TextBox>
        </td>
        <td class="auto-style6">
            <asp:Button ID="picButton" runat="server" Text="Bild auswählen" />
        </td>
    </tr>
    <tr>
        <td>Preis:</td>
        <td class="auto-style2">
            <asp:TextBox ID="priceBox" runat="server" Width="428px"></asp:TextBox>
        </td>
        <td class="auto-style6"></td>
    </tr>
</table>
<asp:Button ID="saveDishButton" runat="server" Text="Gericht Speichern" />

