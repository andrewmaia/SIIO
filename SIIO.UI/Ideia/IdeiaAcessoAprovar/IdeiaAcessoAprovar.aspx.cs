using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Ideia
{
    public partial class IdeiaAcessoAprovar : Atomo.Web.Page
    {
        BO.IdeiaSolicitacaoAcesso ideiaSolicitacaoAcessoBO = new BO.IdeiaSolicitacaoAcesso();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Carregar();
            }
        }


        protected void ucAprovar_Aprovou(object sender, EventArgs e)
        {
            ExecutarAprovacao(true);
        }

        protected void ucAprovar_Reprovou(object sender, EventArgs e)
        {
            ExecutarAprovacao(false);
        }

        private void Carregar()
        {
            gv.DataSource = ideiaSolicitacaoAcessoBO.SelecionarPendenteAprovacao();
            gv.DataBind();
        }

        private void ExecutarAprovacao(bool aprovando)
        {
            CheckBox chk;
            int ideiaSolicitacaoAcessoID;

            foreach (GridViewRow gvr in gv.Rows)
            {
                
                chk = (CheckBox)gvr.FindControl("chkSelecionar");
                if (chk.Checked)
                {
                    ideiaSolicitacaoAcessoID = int.Parse(gv.DataKeys[gvr.RowIndex].Value.ToString());
                    if (aprovando )
                        ideiaSolicitacaoAcessoBO.Aprovar(ideiaSolicitacaoAcessoID);  
                    else
                        ideiaSolicitacaoAcessoBO.Reprovar(ideiaSolicitacaoAcessoID);
                }
            }

            Carregar();
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("ideiaAcessoAprovar");
            l.Add("tabela");
            return l;
        }
    }
}