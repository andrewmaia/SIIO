using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;


namespace SIIO.UI.Ideia.IdeiaSolicitarAcessoControles
{
    public partial class UcFormulario : Atomo.Web.UserControl
    {
        #region "Propriedades"
        public string Mensagem
        {
            get { return txtMensagem.Text; }
            set { txtMensagem.Text = value; }
        }
        #endregion

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("formulario");
            return l;
        }
    }
}