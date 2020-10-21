<%@ Page Title="" Language="C#" MasterPageFile="/Master/PrincipalMaster/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SIIO.UI.Default" %>
<%@ Register src="../Common/Controles/UcIdeiaColecao/UcIdeiaColecao.ascx" tagname="UcIdeiaColecao" tagprefix="uc2" %>
<%@ Register src="Controles/UcPesquisa.ascx" tagname="UcPesquisa" tagprefix="uc3" %>
<%@ Register src="Controles/UcTopo.ascx" tagname="UcTopo" tagprefix="uc1" %>
<%@ Register src="Controles/UcTop10Ideia.ascx" tagname="UcTop10Ideia" tagprefix="uc4" %>
<%@ Register src="Controles/UcComoFunciona.ascx" tagname="UcComoFunciona" tagprefix="uc5" %>
<%@ Register src="Controles/UcPublicidade.ascx" tagname="UcPublicidade" tagprefix="uc6" %>
<%@ Register src="Controles/UcRodape.ascx" tagname="UcRodape" tagprefix="uc7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPrincipal_cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal_corpo" runat="server">
    <div id="default_principal">
        <uc1:UcTopo ID="UcTopo1" runat="server" />
        <uc3:UcPesquisa ID="UcPesquisa1" runat="server" PostBackUrl="/Busca"  />
        <uc4:UcTop10Ideia ID="uciIdeiaRecentes" runat="server" Titulo="Mais Recentes" />
        <uc4:UcTop10Ideia ID="uciIdeiaMaisVistos" runat="server" Titulo="Mais Vistos" />
        <uc5:UcComoFunciona ID="UcComoFunciona1" runat="server" />
        <uc6:UcPublicidade ID="UcPublicidade1" runat="server" />
        <uc7:UcRodape ID="UcRodape" runat="server" />        
    </div>
</asp:Content>
