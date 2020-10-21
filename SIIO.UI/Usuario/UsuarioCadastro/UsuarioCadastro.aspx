<%@ Page Title="" Language="C#" MasterPageFile="~/Master/LogoMaster/LogoMasterSemLogin.Master" AutoEventWireup="true" CodeBehind="UsuarioCadastro.aspx.cs" Inherits="SIIO.UI.Usuario.UsuarioCadastro" %>
<%@ Register src="Controles/UcFormulario.ascx" tagname="UcFormulario" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLogo_cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLogo_corpo" runat="server">
    <div id="usuarioCadastro_principal">
        <uc2:UcFormulario ID="ucFormulario" runat="server" />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" onclick="btnSalvar_Click" CssClass="botao"/>
        <asp:ValidationSummary ID="vs" runat="server" DisplayMode="List" CssClass="validator" ForeColor=""/>
    </div>
</asp:Content>


   