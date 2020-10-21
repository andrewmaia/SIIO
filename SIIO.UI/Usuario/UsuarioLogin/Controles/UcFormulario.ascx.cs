using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Usuario.UsuarioLoginControles
{
    public partial class UcFormulario : Atomo.Web.UserControl
    {
        #region "Propriedades"
        public string Email
        {
            get { return txtEmail.Text; }
        }

        public string Senha
        {
            get { return txtSenha.Text; }
        }

        public bool ContinuarConectado
        {
            get { return chkContinuarConectado.Checked; }
        }


        #endregion

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("formulario");
            l.Add("validator");
            return l;
        }
    }
}