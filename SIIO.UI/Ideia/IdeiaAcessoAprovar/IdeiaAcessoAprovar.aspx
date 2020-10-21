<%@ Page Title="" Language="C#" MasterPageFile="/Master/UsuarioMaster/UsuarioMaster.master" AutoEventWireup="true" CodeBehind="IdeiaAcessoAprovar.aspx.cs" Inherits="SIIO.UI.Ideia.IdeiaAcessoAprovar" %>
<%@ Register src="/Common/Controles/UcGridVazio/UcGridVazio.ascx" tagname="UcGridVazio" tagprefix="uc2" %>
<%@ Register src="/Common/Controles/UcAprovar/UcAprovar.ascx" tagname="UcAprovar" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphUsuario_cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphUsuario_corpo" runat="server">
    <div id="ideiaAcessoAprovar_principal" class="tabela" >
        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" DataKeyNames="ideiaSolicitacaoAcessoID" >
            <Columns>
                <asp:BoundField HeaderText="Idéia" DataField="ideiaTitulo" />
                <asp:BoundField HeaderText="Solicitante" DataField="usuarioNome" />
                <asp:BoundField HeaderText="Mensagem" DataField="mensagem" />
                <asp:BoundField DataField="data" HeaderText="Data da Solicitação" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:TemplateField >
                    <ItemTemplate> <asp:CheckBox ID="chkSelecionar" runat="server" /> </ItemTemplate>
                </asp:TemplateField>            
            </Columns>
            <EmptyDataTemplate> 
                <uc2:UcGridVazio ID="UcGridVazio1" Texto="Não há solicitações de acesso a suas idéias." runat="server"  />
            </EmptyDataTemplate>
        </asp:GridView>
        <uc3:UcAprovar ID="UcAprovar1" runat="server" TextoAprovar="Aprovar Selecionados" TextoReprovar="Reprovar Selecionados" OnClicouAprovar="ucAprovar_Aprovou" OnClicouReprovar="ucAprovar_Reprovou" />
    </div>
</asp:Content>
