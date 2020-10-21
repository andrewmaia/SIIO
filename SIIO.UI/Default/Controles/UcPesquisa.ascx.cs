using System;
using SIIO.Model;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.DefaultControles
{
    public partial class UcPesquisa : Atomo.Web.UserControl  
    {
        public string PostBackUrl
        {
            get;
            set;
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            Response.Redirect( string.Concat (this.PostBackUrl,"?texto=", txtPesquisa.Text));
        }

    }
}