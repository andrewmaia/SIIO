using System;
using SIIO.UI;
using System.Web;
using System.Web.Security;
using System.Web.Profile;
using System.Collections.Generic;


namespace SIIO.UI.Ideia
{
    public partial class IdeiaVisualizacao : Atomo.Web.Page
    {
        BO.Ideia ideiaBO = new BO.Ideia();
        BO.IdeiaArquivo ideiaArquivoBO = new BO.IdeiaArquivo();
        BO.Visualizacao visualizacaoBO = new BO.Visualizacao(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            bool badRequest = true;

            int ideiaID;
            if (int.TryParse(Request.QueryString["ideiaID"], out ideiaID))
            {
                Model.Ideia ideiaModel = ideiaBO.SelecionarPorID(ideiaID);
                if (ideiaModel != null)
                {
                    ProcessarIdeia(ideiaModel);
                    badRequest = false;
                }
            }

            if (badRequest)
                Server.Transfer("/erro/badRequest/badRequest.aspx");
        }

        private void ProcessarIdeia(Model.Ideia ideiaModel)
        {
            if (ideiaBO.NecessitaLogar(ideiaModel))
                FormsAuthentication.RedirectToLoginPage();

            if (!ideiaBO.PossuiAcesso(ideiaModel))
                Server.Transfer(string.Concat("/Ideia/IdeiaSolicitarAcesso/IdeiaSolicitarAcesso.aspx?ideiaID=", ideiaModel.IdeiaID.ToString()));

            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                ucIdeiaMarcarInteresse.Visible = true;
                ucIdeiaMarcarInteresse.Carregar(ideiaModel.IdeiaID);
            }

            ucIdeiaExibicao.Ideia = ideiaModel;
            ucIdeiaExibicao.IdeiaArquivo = ideiaArquivoBO.SelecionarPorIdeia(ideiaModel.IdeiaID);
            visualizacaoBO.AdicionarVisualizacao(ideiaModel.IdeiaID);
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("ideiaVisualizacao");
            return l;
        }

    }
}