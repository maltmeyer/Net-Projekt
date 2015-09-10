<%@ Page MasterPageFile="~/MasterPage.master" Language="vb" AutoEventWireup="false" CodeBehind="home.aspx.vb" Inherits="Pizzaversand.home" %>

<asp:Content ID="content" ContentPlaceHolderID="phBody" Runat="Server">
    <div class="jumbotron text-center ">
        <h2>Willkommen bei MegaPizza</h2>
    </div> 
    <div class="text-center ">
        <h2>Unsere Pizza für Sie</h2>
    </div>
   
    <asp:ScriptManager ID="ScriptManager1" runat="server" ClientIDMode="Static"></asp:ScriptManager>
     
     
   
   
   
     <div class="imgPanel">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate> 
           
            <asp:Timer ID="tImages" runat="server" Interval="5000" Enabled="true"></asp:Timer>
           
            <div class="imgPanel imgPanelGerichte ">
                <asp:Image ID="imgVorschau" runat="server" CssClass="imgPanelGerichte"/>
                <br />
                <asp:Label ID="lblVorschau" runat="server" Text="" Font-Size="Large"></asp:Label>
                
            </div>
</div>
               
            
     </ContentTemplate>
    </asp:UpdatePanel>
    </div>

     <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
         Text="Upload File" />&nbsp;<br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

</asp:Content>

