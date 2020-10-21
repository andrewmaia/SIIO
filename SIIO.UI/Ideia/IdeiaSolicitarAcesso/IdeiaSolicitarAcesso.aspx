<%@ Page Title="" Language="C#" MasterPageFile="/Master/LogoMaster/LogoMaster.Master" AutoEventWireup="true" CodeBehind="IdeiaSolicitarAcesso.aspx.cs" Inherits="SIIO.UI.Ideia.IdeiaSolicitarAcesso" %>
<%@ Register src="Controles/UcFormulario.ascx" tagname="UcFormulario" tagprefix="uc1" %>
<%@ Register src="Controles/UcTexto.ascx" tagname="UcTexto" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLogo_cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLogo_corpo" runat="server">
    <div id="ideiaSolicitarAcesso_principal">
        <uc2:UcTexto ID="UcTexto1" runat="server" />
        <uc1:UcFormulario ID="ucFormulario" runat="server" />
        <div class="centralizar">
            <asp:Button ID="btnEnviar" runat="server"  Text="Enviar" OnClick="btnEnviar_Click" CssClass="botao" />
        </div>
    </div>
</asp:Content>
