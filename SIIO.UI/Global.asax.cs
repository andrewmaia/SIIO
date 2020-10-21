using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.Security;
using System.Diagnostics;
using System.Configuration;
using System.Web.Routing;
using System.Web.Compilation;



namespace SIIO.UI
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            SqlDependency.Start(ConfigurationManager.ConnectionStrings["CONNECTION_STRING"].ConnectionString);
            RegistrarRotas(RouteTable.Routes);
        }

        void Application_End(object sender, EventArgs e)
        {
            SqlDependency.Stop(ConfigurationManager.ConnectionStrings["CONNECTION_STRING"].ConnectionString);

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            
        }


        #region "Métodos"
        public void RegistrarRotas(RouteCollection routes)
        {
            routes.Add(new Route(string.Empty,new CustomRouteHandler("/Default/Default.aspx")));
            routes.Add(new Route("Login", new CustomRouteHandler("/Usuario/UsuarioLogin/UsuarioLogin.aspx")));
            routes.Add(new Route("NovoUsuario", new CustomRouteHandler("/Usuario/UsuarioCadastro/UsuarioCadastro.aspx")));
            routes.Add(new Route("VisualizarIdeia", new CustomRouteHandler("/Ideia/IdeiaVisualizacao/IdeiaVisualizacao.aspx")));
            routes.Add(new Route("Busca", new CustomRouteHandler("/Ideia/IdeiaResultadoBusca/IdeiaResultadoBusca.aspx")));
            routes.Add(new Route("MinhasIdeias", new CustomRouteHandler("/Ideia/IdeiaMinhas/IdeiaMinhas.aspx")));
            routes.Add(new Route("CriarIdeia", new CustomRouteHandler("/Ideia/IdeiaCadastro/IdeiaCadastro.aspx")));
            routes.Add(new Route("EditarIdeia", new CustomRouteHandler("/Ideia/IdeiaEditar/IdeiaEditar.aspx")));
            routes.Add(new Route("AprovarCompartilhamento", new CustomRouteHandler("/Ideia/IdeiaAcessoAprovar/IdeiaAcessoAprovar.aspx")));
            routes.Add(new Route("GerenciarAcessoIdeia", new CustomRouteHandler("/Ideia/IdeiaAcessoGerenciar/IdeiaAcessoGerenciar.aspx")));
            routes.Add(new Route("IdeiasInteressantes", new CustomRouteHandler("/Ideia/IdeiaInteresse/IdeiaInteresse.aspx")));
            routes.Add(new Route("Perfil", new CustomRouteHandler("/Usuario/UsuarioEditar/UsuarioEditar.aspx")));
            routes.Add(new Route("AlterarSenha", new CustomRouteHandler("/Usuario/UsuarioAlterarSenha/UsuarioAlterarSenha.aspx")));
            routes.Add(new Route("SolicitarAcesso", new CustomRouteHandler("/Ideia/IdeiaSolicitarAcesso/IdeiaSolicitarAcesso.aspx")));
            routes.Add(new Route("OcorreuErro", new CustomRouteHandler("/Erro/OcorreuErro/OcorreuErro.aspx")));
            routes.Add(new Route("BadRequest", new CustomRouteHandler("/Erro/BadRequest/BadRequest.aspx")));
        }
        #endregion
    }

    public class CustomRouteHandler : IRouteHandler
    {
        public CustomRouteHandler(string virtualPath)
        {
            this.VirtualPath = virtualPath;
        }

        public string VirtualPath { get; private set; }

        public IHttpHandler GetHttpHandler(RequestContext
              requestContext)
        {
            var page = BuildManager.CreateInstanceFromVirtualPath
                 (VirtualPath, typeof(Page)) as IHttpHandler;
            return page;
        }
    }
}
