using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Ideia.IdeiaAcessoAprovarControles
{
    public partial class UcAprovar : Atomo.Web.UserControl
    {
        public event EventHandler ClicouAprovar;
        public event EventHandler ClicouReprovar;

        protected void lkAprovar_Click(object sender, EventArgs e)
        {
            if (ClicouAprovar != null) ClicouAprovar(this, e);
        }

        protected void lkReprovar_Click(object sender, EventArgs e)
        {
            if (ClicouReprovar != null) ClicouReprovar(this, e);
        }
    }
}