<%@ Page Title="" Language="C#" MasterPageFile="/Master/UsuarioMaster/UsuarioMaster.master" AutoEventWireup="true" CodeBehind="IdeiaEditar.aspx.cs" Inherits="SIIO.UI.Ideia.IdeiaEditar" %>
<%@ Register src="Controles/UcFormulario.ascx" tagname="UcFormulario" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphUsuario_cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphUsuario_corpo" runat="server">
    <div id="ideiaEditar_principal">
        <uc1:UcFormulario ID="ucFormulario" runat="server" />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" onclick="btnSalvar_Click"  CssClass="botao"/>
    </div>
</asp:Content>
