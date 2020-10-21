using System;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using SIIO.UI.Common.Controles;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Ideia
{
    public partial class IdeiaInteresse : Atomo.Web.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Carregar();
            }
        }

        private void Carregar()
        {
            BO.IdeiaInteresse ideiaInteresseBO = new BO.IdeiaInteresse();
            gvIdeia.DataSource = ideiaInteresseBO.SelecionarPorUsuario();
            gvIdeia.DataBind();
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("tabela");
            l.Add("ideiaInteresse");
            return l;
        }
    }
}