using System;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using SIIO.UI.Common.Controles;
using System.Web.UI.WebControls;
using System.Collections.Generic;


namespace SIIO.UI.Ideia
{
    public partial class IdeiaMinhas : Atomo.Web.Page
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
            BO.Ideia ideiaBO = new BO.Ideia();
            gvIdeia.DataSource = ideiaBO.SelecionarPorUsuario();
            gvIdeia.DataBind();
        }


        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("tabela");
            l.Add("ideiaMinhas");
            return l;
        }
    }
}