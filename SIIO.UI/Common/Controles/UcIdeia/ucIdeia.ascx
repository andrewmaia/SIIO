<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcIdeia.ascx.cs" Inherits="SIIO.UI.Common.Controles.UcIdeia" %>
<div id="divPrincipal" runat="server">
    <a id="Link" runat="server">
        <p>
            <strong><asp:Literal ID="Titulo" runat="server"></asp:Literal></strong>
        </p>
        <p>
            <asp:Literal ID="PreDescricao" runat="server"></asp:Literal>
        </p>
        <p>
            Postado em:<asp:Literal ID="DataPostagem" runat="server"></asp:Literal>
        </p>
    </a>
</div>



