<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcFormulario.ascx.cs" Inherits="SIIO.UI.Ideia.IdeiaSolicitarAcessoControles.UcFormulario" %>
<div  id="ideiaSolicitarAcesso_formulario" class="formulario">
    <fieldset>
        <legend>Solicitação de Ideía</legend>
        <asp:label ID="lblMensagem" Runat="server" AssociatedControlID="txtMensagem">Mensagem</asp:label>
        <asp:TextBox ID="txtMensagem" TextMode="MultiLine" runat="server"></asp:TextBox>
    </fieldset>
</div>