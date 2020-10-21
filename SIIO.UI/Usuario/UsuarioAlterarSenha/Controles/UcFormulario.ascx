<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcFormulario.ascx.cs" Inherits="SIIO.UI.Usuario.UsuarioAlterarSenhaControles.UcFormulario" %>
<div id="usuarioAlterarSenha_formulario" class="formulario" >
    <fieldset>
        <legend>Alterar Senha</legend>
        <div class="campo">
            <asp:Label ID="lblSenhaAtual" runat="server" AssociatedControlID="txtSenhaAtual" >Senha Atual</asp:Label>
            <asp:TextBox ID="txtSenhaAtual" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvSenhaAtual" runat="server" ControlToValidate="txtSenhaAtual" Text="*" Display= "Static" CssClass="validator" ForeColor="" ></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ID="cvSenhaAtual" Display= "None"   OnServerValidate="ValidarSenha_ServerValidate" ErrorMessage="Senha Atual Incorreta"></asp:CustomValidator>
        </div>
        <div class="campo">
            <asp:Label ID="lblNovaSenha" runat="server" AssociatedControlID="txtNovaSenha" >Nova Senha</asp:Label>
            <asp:TextBox ID="txtNovaSenha" runat="server" TextMode="Password"  MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNovaSenha" runat="server" Display= "Static" ControlToValidate="txtNovaSenha" Text="*" CssClass="validator" ForeColor=""></asp:RequiredFieldValidator>
        </div>
        <div class="campo">
            <asp:Label ID="lblConfirmarSenha" runat="server" AssociatedControlID="txtConfirmarSenha" >Confirmar Senha</asp:Label>
            <asp:TextBox ID="txtConfirmarSenha" runat="server" TextMode="Password"  MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvConfirmarSenha" Display= "Static" runat="server" ControlToValidate="txtConfirmarSenha" Text="*" CssClass="validator" ForeColor=""></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cvConfirmarSenha" runat="server" Display= "None" ControlToCompare="txtNovaSenha" ErrorMessage="Senha Confirmada Incorreta" ControlToValidate="txtConfirmarSenha"></asp:CompareValidator>
        </div>
    </fieldset>
</div>