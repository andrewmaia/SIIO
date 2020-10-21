using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Ideia
{
    public partial class IdeiaAcessoGerenciar : Atomo.Web.Page
    {
        BO.IdeiaAcesso ideiaAcessoBO = new BO.IdeiaAcesso();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bool badRequest = true;

                int ideiaID;
                if (int.TryParse(Request.QueryString["ideiaID"], out ideiaID))
                {
                    BO.Ideia ideiaBO = new BO.Ideia();
                    Model.Ideia ideiaModel = ideiaBO.SelecionarPorID(ideiaID);
                    if (ideiaModel.Restrita)
                    {
                        if (ideiaBO.UsuarioLogadoEhDono(ideiaModel))
                        {
                            this.IdeiaID = ideiaID;
                            Carregar(ideiaID);
                            badRequest = false;
                        }
                    }
                }

                if (badRequest)
                    Server.Transfer("/erro/badRequest/badRequest.aspx");
            }
        }


        protected void ucAprovar_Aprovou(object sender, EventArgs e)
        {
            ExecutarAtivacao(true);
        }

        protected void ucAprovar_Reprovou(object sender, EventArgs e)
        {
            ExecutarAtivacao(false);
        }


        private void Carregar(int ideiaID)
        {
            gvIdeiaAcesso.DataSource = ideiaAcessoBO.SelecionarPorIdeia(ideiaID); 
            gvIdeiaAcesso.DataBind();
        }

        private void ExecutarAtivacao(bool aprovando)
        {
            CheckBox chk;
            int ideiaAcessoID;

            foreach (GridViewRow gvr in gvIdeiaAcesso.Rows)
            {

                chk = (CheckBox)gvr.FindControl("chkSelecionar");
                if (chk.Checked)
                {
                    ideiaAcessoID = int.Parse(gvIdeiaAcesso.DataKeys[gvr.RowIndex].Value.ToString());
                    if (aprovando)
                        ideiaAcessoBO.Ativar(ideiaAcessoID);
                    else
                        ideiaAcessoBO.Desativar(ideiaAcessoID);
                }
            }

            Carregar(this.IdeiaID);
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("ideiaAcessoGerenciar");
            l.Add("tabela");
            return l;
        }

        private int IdeiaID
        {
            get { return (int)ViewState["ideiaID"]; }
            set { ViewState["ideiaID"] = value; }
        }

    }
}