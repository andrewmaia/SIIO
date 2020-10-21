<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcIdeiaMarcarInteresse.ascx.cs" Inherits="SIIO.UI.Ideia.IdeiaVisualizacaoControles.UcIdeiaMarcarInteresse" %>
    <div id="IdeiaVisualizacao_LkInteresse">
        <asp:LinkButton id="lkMarcarInteresse"  runat="server" onclick="lkMarcarInteresse_Click1"  Text="Adicionar a minha lista de idéias interessantes" ></asp:LinkButton> 
        <asp:LinkButton id="lkDesmarcarInteresse"  runat="server" onclick="lkDesmarcarInteresse_Click1" Text="Retirar da minha lista de idéias interessantes"   > </asp:LinkButton> 
    </div>