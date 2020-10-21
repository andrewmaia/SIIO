<%@ Page Title="" Language="C#" MasterPageFile="/Master/UsuarioMaster/UsuarioMaster.master" AutoEventWireup="true" CodeBehind="IdeiaAcessoGerenciar.aspx.cs" Inherits="SIIO.UI.Ideia.IdeiaAcessoGerenciar" %>
<%@ Register src="/Common/Controles/UcGridVazio/UcGridVazio.ascx" tagname="UcGridVazio" tagprefix="uc2" %>
<%@ Register src="/Common/Controles/UcAprovar/UcAprovar.ascx" tagname="UcAprovar" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphUsuario_cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphUsuario_corpo" runat="server">
    <div id="ideiaAcessoGerenciar_principal" class="tabela">
        <asp:GridView ID="gvIdeiaAcesso" runat="server" AutoGenerateColumns="False" DataKeyNames="ideiaAcessoID" >
            <Columns>
                <asp:BoundField HeaderText="Idéia" DataField="ideiaTitulo" />
                <asp:BoundField HeaderText="Usuário" DataField="usuarioNome" />
                <asp:TemplateField HeaderText="Ativo" >
                    <ItemTemplate> <%# Boolean.Parse(Eval("ativo").ToString())? "Sim" : "Não" %> </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField >
                    <ItemTemplate> <asp:CheckBox ID="chkSelecionar" runat="server" /> </ItemTemplate>
                </asp:TemplateField>  
            </Columns>
            <EmptyDataTemplate>
                <uc2:UcGridVazio ID="UcGridVazio1" Texto="Não há acessos definidos para nenhum usuário!" runat="server"  />
            </EmptyDataTemplate>
        </asp:GridView>
        <uc3:UcAprovar ID="UcAprovar1" runat="server" TextoAprovar="Aprovar Selecionados" TextoReprovar="Reprovar Selecionados" OnClicouAprovar="ucAprovar_Aprovou" OnClicouReprovar="ucAprovar_Reprovou" />
    </div>
</asp:Content>
