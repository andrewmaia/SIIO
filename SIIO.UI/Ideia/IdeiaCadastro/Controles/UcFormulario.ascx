<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcFormulario.ascx.cs" Inherits="SIIO.UI.Ideia.IdeiaCadastroControles.UcFormulario" %>
<div id="ideiaCadastro_formulario" class="formulario">
    <fieldset>
        <legend>Nova Idéia</legend>
        <div class="campo">
            <asp:label ID="lblTitulo" runat="server" AssociatedControlID="txtTitulo">Título</asp:label>
            <asp:TextBox ID="txtTitulo" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ControlToValidate="txtTitulo" ErrorMessage="Preencher Titulo" Display= "Static" Text="*" CssClass="validator" ForeColor="" ></asp:RequiredFieldValidator>
        </div>
        <div class="campo">
            <asp:label ID="lblPreDescricao" runat="server" AssociatedControlID="txtPreDescricao">Pré-Descrição</asp:label>
            <asp:TextBox ID="txtPreDescricao" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPreDescricao" runat="server" ControlToValidate="txtPreDescricao" ErrorMessage="Preencher Pré-Descrição" Display= "Static" Text="*" CssClass="validator" ForeColor=""></asp:RequiredFieldValidator>
        </div>
        <div class="campo">
            <asp:label ID="lblDescricao" runat="server" AssociatedControlID="txtDescricao">Descrição</asp:label>
            <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDescricao" runat="server" ControlToValidate="txtDescricao" ErrorMessage="Preencher Descrição" Display="Static"   Text="*" CssClass="validator" ForeColor=""></asp:RequiredFieldValidator>
        </div>
        <div class="campo">
            <asp:label ID="lblCategoria" runat="server" AssociatedControlID="ddlCategoria">Categoria</asp:label>
            <asp:DropDownList ID="ddlCategoria" runat="server"  DataTextField="descricao" DataValueField="categoriaID"/>
        </div>
        <div class="campo">
            <asp:label ID="lblRestrita" runat="server" AssociatedControlID="chkRestrita">Restrita</asp:label>
            <asp:CheckBox ID="chkRestrita" runat="server" />
        </div>
        <div class="campo">
            <asp:label ID="lblAnexo" runat="server" AssociatedControlID="fuAnexo">Arquivo para Upload</asp:label>
            <asp:FileUpload ID="fuAnexo" runat="server" />
        </div>
    </fieldset>
</div>