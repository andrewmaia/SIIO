<%@ Page Title="" Language="C#" MasterPageFile="~/Master/LogoMaster/LogoMasterSemLogin.Master" AutoEventWireup="true" CodeBehind="UsuarioLogin.aspx.cs" Inherits="SIIO.UI.Usuario.UsuarioLogin" %>
<%@ Register src="Controles/UcFormulario.ascx" tagname="UcFormulario" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLogo_cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLogo_corpo" runat="server">
    <div id="usuarioLogin_principal">
        <uc2:UcFormulario ID="UcFormulario" runat="server" />
        <asp:Button ID="btnLogar" runat="server" Text="Logar"  onclick="btnLogar_Click" CssClass="botao" />
        <a href="/NovoUsuario">Não Tenho Cadastro</a>
        <asp:ValidationSummary ID="vs" runat="server" ValidationGroup="mensagem"  CssClass="validator" DisplayMode="List" ForeColor="" />
    </div>
</asp:Content>
