using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Ideia.IdeiaAcessoGerenciarControles
{
    public partial class UcAtivar : Atomo.Web.UserControl
    {
        public event EventHandler ClicouAtivar;
        public event EventHandler ClicouDesativar;

        protected void lkAtivar_Click(object sender, EventArgs e)
        {
            if (ClicouAtivar != null) ClicouAtivar(this, e);
        }

        protected void lkDesativar_Click(object sender, EventArgs e)
        {
            if (ClicouDesativar != null) ClicouDesativar(this, e);
        }   
    }
}