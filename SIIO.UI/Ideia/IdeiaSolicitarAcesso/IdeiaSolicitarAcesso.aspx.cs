using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Ideia
{
    public partial class IdeiaSolicitarAcesso : Atomo.Web.Page
    {
        BO.Ideia ideiaBO = new BO.Ideia();
        BO.IdeiaSolicitacaoAcesso ideiaSolicitacaoAcessoBO = new BO.IdeiaSolicitacaoAcesso();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bool badRequest = true;

                int ideiaID;
                if (int.TryParse(Request.QueryString["ideiaID"], out ideiaID))
                {
                    Model.Ideia ideiaModel = ideiaBO.SelecionarPorID(ideiaID);
                    if (ideiaModel != null)
                        badRequest = false;
                }

                if (badRequest)
                    Server.Transfer("/erro/badRequest/badRequest.aspx");
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Model.IdeiaSolicitacaoAcesso modelIdeiaSolicitacaoAcesso = new Model.IdeiaSolicitacaoAcesso();
            modelIdeiaSolicitacaoAcesso.IdeiaID = int.Parse(Request["ideiaID"]);
            if (ucFormulario.Mensagem.Trim() != string.Empty)
                modelIdeiaSolicitacaoAcesso.Mensagem = ucFormulario.Mensagem.Trim();

            ideiaSolicitacaoAcessoBO.SolicitarAcesso(modelIdeiaSolicitacaoAcesso);
            Response.Redirect("/");
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("ideiaSolicitarAcesso");
            l.Add("botao");
            return l;
        }
    }
}