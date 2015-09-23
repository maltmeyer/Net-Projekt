<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="addDishControl.ascx.vb" Inherits="Pizzaversand.WebUserControl1" %>


<style type="text/css">
    .auto-style1 {
        width: 317px;
    }
</style>


<table style="width: 100%;">
    
    <tr>
        <td>
            <asp:Label Text="Gericht hinzufügen" runat="server" id="lblTag" Font-Size="Larger" Font-Bold="true" />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Name des Gerichts"></asp:Label>
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
        <td>
            <asp:Label ID="LabelIngrediants" runat="server" Text="Zutaten"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="gridViewIngredients" runat="server"  AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="299px"  >
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="nr" Visible="true" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Preis" HeaderText="Preis" SortExpression="Preis" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox runat="server" id="ingredientselector" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" SelectCommand="SELECT * FROM [Zutaten]">
            </asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Foto-URL:"></asp:Label>
        </td>
        <td>
            <asp:FileUpload ID="FileUpload1" runat="server" Width="434px" />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="showCheck" runat="server" Text="Eintrag in Karte anzeigen"/>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="buttonSave" runat="server" Text="Gericht speichern"/>
            <asp:Label ID="lblSucess" Text="" runat="server" /> 
        </td>
    </tr>
</table>
<asp:RequiredFieldValidator ID="nameValidator" runat="server" ErrorMessage="Bitte Namen angeben" ControlToValidate="dishText" /><br />
<asp:RequiredFieldValidator ID="uploadValidator" runat="server" ErrorMessage="Bitte Bild angeben" ControlToValidate="FileUpload1" />
<%--<asp:RequiredFieldValidator ID="ingredientsValidator" runat="server" ErrorMessage="Keine Zutatenliste angegeben" ControlToValidate="ingBox" ValidationGroup="ingLstVals" /><br />
<asp:RegularExpressionValidator ID="ingredientsContentsValidator" runat="server" ErrorMessage="Zutatenliste muss aus Zahlen und Kommas bestehen"
                ControlToValidate="ingBox" ValidationExpression="([0-9]+, )*|[0-9]+" ValidationGroup="ingLstVals" />--%>