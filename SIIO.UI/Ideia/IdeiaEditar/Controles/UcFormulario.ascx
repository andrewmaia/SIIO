<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcFormulario.ascx.cs" Inherits="SIIO.UI.Ideia.IdeiaEditarControles.UcFormulario" %>
<div id="ideiaEditar_formulario" class="formulario">
    <fieldset>
        <legend>Editar Idéia</legend>
        <div class="campo">
            <asp:label ID="lblTitulo" Runat="server" AssociatedControlID="txtTitulo">Título</asp:label>
            <asp:TextBox ID="txtTitulo" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ControlToValidate="txtTitulo" ErrorMessage="Preencher Titulo" Display= "Static" Text="*" CssClass="validator" ForeColor="" ></asp:RequiredFieldValidator>
        </div>
        <div class="campo">
            <asp:label ID="lblPreDescricao" Runat="server" AssociatedControlID="txtPreDescricao">Pré-Descrição</asp:label>
            <asp:TextBox ID="txtPreDescricao" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPreDescricao" runat="server" ControlToValidate="txtPreDescricao" ErrorMessage="Preencher Pré-Descrição" Display= "Static" Text="*" CssClass="validator" ForeColor="" ></asp:RequiredFieldValidator>
        </div>
        <div class="campo">
            <asp:label ID="lblDescricao" Runat="server" AssociatedControlID="txtDescricao">Descrição</asp:label>
            <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvDescricao" runat="server" ControlToValidate="txtDescricao" ErrorMessage="Preencher Descrição" Display="Static"   Text="*" CssClass="validator" ForeColor=""></asp:RequiredFieldValidator>
        </div>
        <div class="campo">
            <asp:label ID="lblCategoria" Runat="server" AssociatedControlID="ddlCategoria">Categoria</asp:label>
            <asp:DropDownList ID="ddlCategoria" runat="server"  DataTextField="descricao" DataValueField="categoriaID"/>
        </div>
        <div class="campo">
            <asp:label ID="lblRestrita" Runat="server" AssociatedControlID="chkRestrita">Restrita</asp:label>
            <asp:CheckBox ID="chkRestrita" runat="server" />
        </div>
    </fieldset>
</div>
