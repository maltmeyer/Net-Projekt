<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="addDishControl.ascx.vb" Inherits="Pizzaversand.WebUserControl1" %>

<asp:RequiredFieldValidator ID="nameValidator" runat="server" ErrorMessage="Bitte Namen angeben" ControlToValidate="dishText"></asp:RequiredFieldValidator><br />
<asp:RequiredFieldValidator ID="ingredientsValidator" runat="server" ErrorMessage="Keine Zutatenliste angegeben" ControlToValidate="ingBox"></asp:RequiredFieldValidator><br />
<asp:RegularExpressionValidator ID="ingredientsContentsValidator" runat="server" ErrorMessage="Zutatenliste muss aus Zahlen und Kommas bestehen"
    ControlToValidate="ingBox" ValidationExpression="([0-9]*, )*"></asp:RegularExpressionValidator><br />
<asp:PlaceHolder ID="phIngredients" runat="server"></asp:PlaceHolder><br />

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
            <asp:CheckBox ID="showCheck" runat="server" Text="Eintrag in Karte anzeigen"/>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Button ID="saveDishButton" runat="server" Text="Gericht Speichern" />
        </asp:TableCell>
    </asp:TableRow>
</asp:Table>




