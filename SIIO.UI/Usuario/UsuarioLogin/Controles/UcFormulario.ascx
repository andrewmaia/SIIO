<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcFormulario.ascx.cs" Inherits="SIIO.UI.Usuario.UsuarioLoginControles.UcFormulario" %>
<div id="usuarioLogin_formulario" class="formulario">
    <fieldset>
        <legend>Login</legend>
        <div class="campo">
            <asp:Label id="lblEmail" runat="server" AssociatedControlID= "txtEmail" >Email</asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" MaxLength="256"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Preencher Email" Display= "Static"  Text="*" ForeColor="" CssClass="validator"  ></asp:RequiredFieldValidator>
        </div>
        <div class="campo">
            <asp:Label id="lblSenha" runat="server" AssociatedControlID= "txtSenha" >Senha</asp:Label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" MaxLength="128"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvSenha" runat="server" Display= "Static" ControlToValidate="txtSenha" ErrorMessage="Preencher Senha" Text="*" ForeColor="" CssClass="validator"  ></asp:RequiredFieldValidator>
        </div>
        <div class="campo">
            <asp:Label id="lblContinuarConectado" runat="server" AssociatedControlID= "chkContinuarConectado" CssClass="checkbox" >
                <asp:CheckBox ID="chkContinuarConectado" runat="server" />
                Continuar Conectado
            </asp:Label>
        </div>
    </fieldset>
</div>