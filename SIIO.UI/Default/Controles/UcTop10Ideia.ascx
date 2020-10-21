<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcTop10Ideia.ascx.cs" Inherits="SIIO.UI.DefaultControles.UcTop10Ideia" %>
<%@ Register src="/Common/Controles/UcIdeiaColecao/UcIdeiaColecao.ascx" tagname="UcIdeiaColecao" tagprefix="uc1" %>
<div class="default_top10Ideia">
    <h2 runat="server" id="h2"></h2>
    <uc1:UcIdeiaColecao ID="UcIC" runat="server" CssClass="ideia" />
</div>