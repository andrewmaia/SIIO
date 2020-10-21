using System;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SIIO.UI
{
    public partial class Default : Atomo.Web.Page  
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BO.Ideia ideiaBO = new BO.Ideia();

            uciIdeiaRecentes.Ideias = (List<Model.Ideia>)ideiaBO.Recentes();
            uciIdeiaMaisVistos.Ideias = (List<Model.Ideia>)ideiaBO.MaisVistas();
        }



        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("default");
            return l;
        }
    }
}
