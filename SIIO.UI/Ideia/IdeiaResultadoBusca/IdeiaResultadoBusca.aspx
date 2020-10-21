<%@ Page Title="" Language="C#" MasterPageFile="/Master/LogoMaster/LogoMaster.master" AutoEventWireup="true" CodeBehind="IdeiaResultadoBusca.aspx.cs" Inherits="SIIO.UI.Ideia.IdeiaResultadoBusca" %>
<%@ Register src="../../Common/Controles/UcIdeiaColecao/UcIdeiaColecao.ascx" tagname="UcIdeiaColecao" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLogo_cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLogo_corpo" runat="server">
    <div id="IdeiaResultadoBusca_principal">
        <h2>Resultado:</h2>
        <uc1:UcIdeiaColecao ID="ucIdeiaColecao" runat="server" CssClass="ideia" />
    </div>
</asp:Content>
