<%@ Page MasterPageFile="~/MasterPage.master" Language="vb" AutoEventWireup="false" CodeBehind="home.aspx.vb" Inherits="Pizzaversand.home" %>

<asp:Content ID="content" ContentPlaceHolderID="phBody" Runat="Server">
    <div style="background-color:orange;text-align: center ;">
        <h1>Willkommen auf meiner Seite</h1>
    </div> 
   
    <h2>Hier unsere Aktuellen Angebote</h2>
    <asp:ScriptManager ID="ScriptManager1" runat="server" ClientIDMode="Static"></asp:ScriptManager>
     
     
   
   
   
     <div class="imgPanel">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate> 
           
            <asp:Timer ID="tImages" runat="server" Interval="5000" Enabled="true"></asp:Timer>
            <asp:Image CssClass="imgPanel2" ID="imgAngebot" runat="server" />
      
     </ContentTemplate>
    </asp:UpdatePanel>
    </div>

     <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
         Text="Upload File" />&nbsp;<br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

</asp:Content>

