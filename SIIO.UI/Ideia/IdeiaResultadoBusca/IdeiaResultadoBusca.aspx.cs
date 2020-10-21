using System;
using System.Web;
using System.Web.UI;
using SIIO.UI.Common.Controles;  
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Ideia
{
    public partial class IdeiaResultadoBusca : Atomo.Web.Page  
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string texto = Server.HtmlEncode(Request["texto"]);
            BO.Ideia ideiaBO = new BO.Ideia();
            ucIdeiaColecao.Ideias = (List<Model.Ideia>)ideiaBO.Buscar(texto);
            ucIdeiaColecao.DataBind();
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("ideiaResultadoBusca");
            return l;
        }
    }
}