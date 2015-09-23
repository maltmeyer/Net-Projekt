<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="UpdateDishControl.ascx.vb" Inherits="Pizzaversand.UpdateDishControl" %>
<asp:PlaceHolder ID="phDishes" runat="server"></asp:PlaceHolder>
<br />

<%--<table>
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
</table>--%>

<asp:GridView ID="GridViewDishes" AllowPaging="True" AllowSorting="True" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" style="margin-top: 0px" PageSize="10"  >
    <HeaderStyle BackColor="#507cd1" Font-Bold="true" ForeColor="White" />
    <RowStyle BackColor="#eff3fb" />
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id"  />
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" >
            <ControlStyle Width="100%" />
        </asp:BoundField>
        <asp:BoundField DataField="Beschreibung" HeaderText="Beschreibung" SortExpression="Beschreibung">
            <ControlStyle Width="100%" />
        </asp:BoundField>
        <%--<asp:BoundField DataField="Photo" HeaderText="Photo" SortExpression="Photo" />--%>
        <asp:TemplateField HeaderText="Photo" >
            <ItemTemplate>            
                <%#Eval("Photo")%>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:FileUpload ID="fileUpload" runat="server" text='<%#Eval("Photo")%>' />    
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:CheckBoxField DataField="Zeigen" HeaderText="Zeigen" SortExpression="Zeigen" />
        <asp:BoundField DataField="Preis" HeaderText="Preis" SortExpression="Preis" />
        <asp:CommandField ShowEditButton="true" HeaderText="edit" EditText="edit" />
           <asp:TemplateField HeaderText="delete" >
	        <ItemTemplate>
		        <asp:LinkButton ID="deleteButton" runat="server" CommandName="Delete" Text="delete"
                            OnClientClick="return confirm('Are you sure you want to delete this dish?');" />
	        </ItemTemplate>
        </asp:TemplateField>

    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" 
    SelectCommand="SELECT * FROM [Gerichte]"
    UpdateCommand="UPDATE [Gerichte] SET [Name] = @Name, [Beschreibung] = @Beschreibung, [Photo] = @Photo, [Zeigen] = @Zeigen, [Preis] = @Preis WHERE [Id] = @original_Id"
    DeleteCommand="DELETE FROM [Gerichte] WHERE [Id] = @original_Id"
    InsertCommand="INSERT INTO [Gerichte] ([Name], [Beschreibung], [Photo], [Zeigen], [Preis]) VALUES (@Name, @Beschreibung, @Photo, @Zeigen, @Preis)"
    OldValuesParameterFormatString="original_{0}"
    >
    <DeleteParameters>
        <asp:Parameter Name="original_Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Name" Type="String" />
        <asp:Parameter Name="Beschreibung" Type="String" />
        <asp:Parameter Name="Photo" Type="String" />
        <asp:Parameter Name="Zeigen" Type="Boolean" />
        <asp:Parameter Name="Preis" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Name" Type="String"   />
        <asp:Parameter Name="Beschreibung" Type="String" />
        <asp:Parameter Name="Photo" Type="String" />
        <asp:Parameter Name="Zeigen" Type="Boolean" />
        <asp:Parameter Name="Preis" Type="Decimal" />
        <asp:Parameter Name="original_Id" Type="Int32" />
    </UpdateParameters>

</asp:SqlDataSource>
