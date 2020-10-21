<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcFormulario.ascx.cs" Inherits="SIIO.UI.Usuario.UsuarioEditarControles.UcFormulario" %>
<div id="usuarioEditar_formulario" class="formulario">
    <fieldset>
        <legend>Editar Usuário</legend>
        <div class="campo">
            <asp:Label ID="lblNome" runat="server" AssociatedControlID="txtNome" >Nome</asp:Label>
            <asp:TextBox ID="txtNome" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome" Text="*" Display= "Static"  CssClass="validator" ForeColor=""></asp:RequiredFieldValidator>
        </div>
        <div class="campo">
            <asp:Label ID="lblDataNascimento" runat="server" AssociatedControlID="txtDataNascimento" >Data de Nascimento</asp:Label>
            <asp:TextBox ID="txtDataNascimento" runat="server" MaxLength="10"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDataNascimento" runat="server" ControlToValidate="txtDataNascimento" Display= "Static" Text="*" CssClass="validator" ForeColor=""></asp:RequiredFieldValidator>
            <asp:CompareValidator id="cvDataNascimento" runat="server" ControlToValidate="txtDataNascimento" Display= "None" ErrorMessage="Digite uma data no formato dd/mm/aaaa" Operator="DataTypeCheck" Type="Date" CssClass="validator" ForeColor=""> </asp:CompareValidator>
        </div>
        <div class="campo">
            <asp:Label ID="lblEstado" runat="server" AssociatedControlID="ddlEstado" >Estado</asp:Label>
            <asp:DropDownList ID="ddlEstado" runat="server" AutoPostBack="true" onselectedindexchanged="ddlEstado_SelectedIndexChanged" DataTextField="UF" DataValueField="estadoID"/>
        </div>
        <div class="campo">
            <asp:Label ID="lblCidade" runat="server" AssociatedControlID="ddlCidade" >Cidade</asp:Label>
            <asp:DropDownList ID="ddlCidade" runat="server" DataTextField="Nome" DataValueField="cidadeID"/>
        </div>
    </fieldset>
</div>