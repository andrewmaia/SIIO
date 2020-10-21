<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UcIdeiaExibicao.ascx.cs" Inherits="SIIO.UI.Common.Controles.UcIdeiaExibicao" %>
<div id="ucIdeiaExibicao_principal">
    <fieldset>
        <legend>Idéia</legend>
        <div class="campo">
            <asp:Label  ID="lblAutor" runat="server" Text="Autor" AssociatedControlID="txtAutor" ></asp:Label>
            <asp:TextBox ID="txtAutor" runat="server" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="campo">
            <asp:Label  ID="lblTItulo" runat="server" Text="Título" AssociatedControlID="txtTitulo" ></asp:Label>
            <asp:TextBox ID="txtTitulo" runat="server" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="campo">
            <asp:Label  ID="lblCategoria" runat="server" Text="Categoria" AssociatedControlID="txtCategoria" ></asp:Label>
            <asp:TextBox ID="txtCategoria" runat="server" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="campo">
            <asp:Label  ID="lblPreDescricao" runat="server" Text="Pré-Descrição" AssociatedControlID="txtPreDescricao" ></asp:Label>
            <asp:TextBox ID="txtPreDescricao" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="campo">
            <asp:Label  ID="lblDescricao" runat="server" Text="Descrição" AssociatedControlID="txtDescricao" ></asp:Label>
            <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
        </div>
        <div id="divAnexo" runat="server"  Visible="False" class="campo">
            <asp:Label  ID="lblAnexo" runat="server" Text="Anexo" AssociatedControlID="lkAnexo"></asp:Label>
            <asp:LinkButton ID="lkAnexo" runat="server" onclick="lkAnexo_Click"></asp:LinkButton>
        </div>
    </fieldset>
</div>