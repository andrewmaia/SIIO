using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;


namespace SIIO.UI.Common.Controles
{
    public partial class UcAprovar : Atomo.Web.UserControl
    {
        public event EventHandler ClicouAprovar;
        public event EventHandler ClicouReprovar;

        public string TextoAprovar
        {
            set { this.textoAprovar = value.Trim(); }
        }
        private string textoAprovar;

        public string TextoReprovar
        {
            set { this.textoReprovar = value.Trim(); }
        }
        private string textoReprovar;


        protected void lkAprovar_Click(object sender, EventArgs e)
        {
            if (ClicouAprovar != null) ClicouAprovar(this, e);
        }

        protected void lkReprovar_Click(object sender, EventArgs e)
        {
            if (ClicouReprovar != null) ClicouReprovar(this, e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            lkAprovar.Text = this.textoAprovar;
            lkReprovar.Text = this.textoReprovar;
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("ucAprovar");
            return l;
        }
    }
}