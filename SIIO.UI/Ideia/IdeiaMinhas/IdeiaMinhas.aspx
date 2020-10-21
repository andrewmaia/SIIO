<%@ Page Title="" Language="C#" MasterPageFile="/Master/UsuarioMaster/UsuarioMaster.master" AutoEventWireup="true" CodeBehind="IdeiaMinhas.aspx.cs" Inherits="SIIO.UI.Ideia.IdeiaMinhas" %>
<%@ Register src="/Common/Controles/UcGridVazio/UcGridVazio.ascx" tagname="UcGridVazio" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphUsuario_cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphUsuario_corpo" runat="server">
    <div id="ideiaMinhas_principal" class="tabela">
        <asp:GridView ID="gvIdeia" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:HyperLinkField DataTextField="titulo" HeaderText="Titulo" DataNavigateUrlFields="ideiaID"  DataNavigateUrlFormatString="/VisualizarIdeia?ideiaID={0}"  />
                <asp:BoundField HeaderText="Categoria" DataField="categoriaDescricao" />
                <asp:TemplateField HeaderText="Restrita" >
                    <ItemTemplate> <%# Boolean.Parse(Eval("restrita").ToString())? "Sim" : "Não" %> </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="dataCadastro" HeaderText="Data Cadastro"  DataFormatString="{0:dd/MM/yyyy}" />
                <asp:HyperLinkField  Text="Editar"  DataNavigateUrlFields="ideiaID"  DataNavigateUrlFormatString="/EditarIdeia?ideiaID={0}"  />
                <asp:TemplateField >
                    <ItemTemplate> <%# Boolean.Parse(Eval("restrita").ToString()) ? string.Concat("<a href=\"/GerenciarAcessoIdeia?ideiaID=",Eval("ideiaID").ToString() ,"\">Acessos</a>") : string.Empty%> </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                <uc2:UcGridVazio ID="UcGridVazio1" Texto="Você não possui nenhuma idéia cadastrada!" runat="server"  />
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
