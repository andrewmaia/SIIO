<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcFormulario.ascx.cs" Inherits="SIIO.UI.Usuario.UsuarioCadastroControles.UcFormulario" %>
<div id="usuarioCadastro_formulario" class="formulario">
    <fieldset>
        <legend>Novo Usuário</legend>
        <div class="campo">
            <asp:Label id="lblNome" runat="server" AssociatedControlID= "txtNome" >Nome</asp:Label>
            <asp:TextBox ID="txtNome" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome" Text="*" Display= "Static" CssClass="validator" ForeColor=""  ></asp:RequiredFieldValidator>                
        </div>
        <div class="campo">
            <asp:Label id="lblEmail" runat="server" AssociatedControlID= "txtEmail" >Email</asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" Display= "Static" ControlToValidate="txtEmail" Text="*" CssClass="validator" ForeColor=""></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="E-mail em Formato Incorreto" Display= "None" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="validator" ForeColor=""></asp:RegularExpressionValidator>
            <asp:CustomValidator runat="server" ID="cvEmail" Display= "None"   OnServerValidate="ExisteEmail_ServerValidate" ErrorMessage="Este e-mail já existe" CssClass="validator" ForeColor=""></asp:CustomValidator>                
        </div>
        <div class="campo">
            <asp:Label id="lblSenha" runat="server" AssociatedControlID= "txtSenha" >Senha</asp:Label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"  MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvSenha" runat="server" Display= "Static" ControlToValidate="txtSenha" Text="*" CssClass="validator" ForeColor=""></asp:RequiredFieldValidator>
        </div>
        <div class="campo">
            <asp:Label id="lblConfirmarSenha" runat="server" AssociatedControlID= "txtConfirmarSenha" >Confirmar Senha</asp:Label>
            <asp:TextBox ID="txtConfirmarSenha" runat="server" TextMode="Password"  MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvConfirmarSenha" Display= "Static" runat="server" ControlToValidate="txtConfirmarSenha" Text="*" CssClass="validator" ForeColor=""></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cvConfirmarSenha" runat="server" Display= "None" ControlToCompare="txtSenha" ErrorMessage="Senha Confirmada Incorreta" ControlToValidate="txtConfirmarSenha" CssClass="validator" ForeColor=""></asp:CompareValidator>
        </div>
        <div class="campo">
            <asp:Label id="lblDataNascimento" runat="server" AssociatedControlID= "txtDataNascimento" >Data de Nascimento</asp:Label>
            <asp:TextBox ID="txtDataNascimento" runat="server" MaxLength="10"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDataNascimento" runat="server" ControlToValidate="txtDataNascimento" Display= "Static" Text="*" CssClass="validator" ForeColor=""></asp:RequiredFieldValidator>
            <asp:CompareValidator id="cvDataNascimento" runat="server" ControlToValidate="txtDataNascimento" Display= "None" ErrorMessage="Digite uma data no formato dd/mm/aaaa" Operator="DataTypeCheck" Type="Date" CssClass="validator" ForeColor=""> </asp:CompareValidator>
        </div>
        <div class="campo">
            <asp:Label id="lblEstado" runat="server" AssociatedControlID= "ddlEstado" >Estado</asp:Label>
            <asp:DropDownList ID="ddlEstado" runat="server" AutoPostBack="true" onselectedindexchanged="ddlEstado_SelectedIndexChanged" DataTextField="UF" DataValueField="estadoID"/>
        </div>
        <div class="campo">
            <asp:Label id="lblCidade" runat="server" AssociatedControlID= "ddlCidade" >Cidade</asp:Label>
            <asp:DropDownList ID="ddlCidade" runat="server" DataTextField="Nome" DataValueField="cidadeID"/>
        </div>
        <div class="campo">
            <asp:Label id="lblTermoUso" runat="server" AssociatedControlID= "txtTermoUso" >Termo de Uso</asp:Label>
            <asp:TextBox ID="txtTermoUso" runat="server" TextMode="MultiLine" ReadOnly="true" >Texto Termo de Uso</asp:TextBox>
        </div>
        <div class="campo">
            <asp:Label id="lblAceite" runat="server" AssociatedControlID= "chkAceite" CssClass="checkbox" >
                <asp:CheckBox ID="chkAceite" runat="server" />
                <asp:CustomValidator runat="server" ID="cvkAceite" Display= "None"  OnServerValidate="CheckBoxRequired_ServerValidate" ClientValidationFunction="ValidarTermo" ErrorMessage="É necessário aceitar o Termo de Uso" CssClass="validator" ForeColor="" ></asp:CustomValidator>
                Li e Aceito Termos de Uso
            </asp:Label>
        </div>
    </fieldset>
</div>