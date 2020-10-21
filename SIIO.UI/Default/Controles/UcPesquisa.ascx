<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcPesquisa.ascx.cs" Inherits="SIIO.UI.DefaultControles.UcPesquisa" %>
<div id="default_pesquisa">
    <asp:TextBox ID="txtPesquisa" runat="server" MaxLength="50"  CssClass="txtPesquisa"  ></asp:TextBox>        
    <asp:RequiredFieldValidator  ID="rfvPesquisa" runat="server" Display="None" ControlToValidate="txtPesquisa"></asp:RequiredFieldValidator>
    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar"   CssClass="btnPesquisar" onclick="btnPesquisar_Click" />
</div>