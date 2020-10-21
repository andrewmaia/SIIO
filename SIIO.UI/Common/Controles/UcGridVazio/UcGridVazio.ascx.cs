using System;
using SIIO.Model;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Common.Controles
{
    public partial class UcGridVazio : Atomo.Web.UserControl
    {
        public string Texto
        {
            set { this.texto = value.Trim(); }
        }
        private string texto;

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            lTexto.Text = this.texto;
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("ucGridVazio");
            return l;
        }
    }
}