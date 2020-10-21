<%@ Page Title="" Language="C#" MasterPageFile="/Master/UsuarioMaster/UsuarioMaster.master" AutoEventWireup="true" CodeBehind="IdeiaInteresse.aspx.cs" Inherits="SIIO.UI.Ideia.IdeiaInteresse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphUsuario_cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphUsuario_corpo" runat="server">
    <div id="ideiaInteresse_principal" class="tabela">
        <asp:GridView ID="gvIdeia" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:HyperLinkField DataTextField="titulo" HeaderText="Titulo" DataNavigateUrlFields="ideiaID"  DataNavigateUrlFormatString="/VisualizarIdeia?ideiaID={0}"  />
                <asp:BoundField HeaderText="Categoria" DataField="categoriaDescricao" />
                <asp:BoundField HeaderText="Criador" DataField="UsuarioNome" />
                <asp:TemplateField HeaderText="Restrita" >
                    <ItemTemplate> <%# Boolean.Parse(Eval("restrita").ToString())? "Sim" : "Não" %> </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="dataCadastro" HeaderText="Data Cadastro" DataFormatString="{0:dd/MM/yyyy}" />
            </Columns>
            <EmptyDataTemplate>
                <div class="centralizar">
                    Você não marcou nenhuma idéia como interessante!
                </div>
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
