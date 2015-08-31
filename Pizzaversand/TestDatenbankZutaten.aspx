<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TestDatenbankZutaten.aspx.vb" Inherits="Pizzaversand.TestDatenbankZutaten" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnGetGerichte" runat="server" Text="Get Gerichte" />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtPreis" runat="server"></asp:TextBox>
        <asp:Button ID="btnAddZutat" runat="server" Text="Zutat hinzufügen" />
        <asp:Button ID="btnShowZutaten" runat="server" Text="Zutat anzeigen" />
        <br />
        <asp:Button ID="btnAddUser" runat="server" Text="Button" />
        <asp:PlaceHolder ID="phZutaten" runat="server"></asp:PlaceHolder>

    </div>
    </form>
</body>
</html>
