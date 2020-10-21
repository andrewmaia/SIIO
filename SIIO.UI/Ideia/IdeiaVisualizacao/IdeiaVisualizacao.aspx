<%@ Page Title="" Language="C#" MasterPageFile="/Master/LogoMaster/LogoMaster.master" AutoEventWireup="true" CodeBehind="IdeiaVisualizacao.aspx.cs" Inherits="SIIO.UI.Ideia.IdeiaVisualizacao" %>
<%@ Register src="/Common/Controles/UcIdeiaExibicao/UcIdeiaExibicao.ascx" tagname="UcIdeiaExibicao" tagprefix="uc1" %>
<%@ Register src="/Ideia/IdeiaVisualizacao/Controles/IdeiaMarcarInteresse/UcIdeiaMarcarInteresse.ascx" tagname="UcIdeiaMarcarInteresse" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphLogo_cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphLogo_corpo" runat="server">
    <div id="ideiaVisualizacao_principal">
        <uc1:UcIdeiaExibicao ID="ucIdeiaExibicao" runat="server" />
        <uc2:UcIdeiaMarcarInteresse ID="ucIdeiaMarcarInteresse" runat="server"  Visible="false" />
    </div>
</asp:Content>