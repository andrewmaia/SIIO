using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Usuario.UsuarioAlterarSenhaControles
{
    public partial class UcFormulario : Atomo.Web.UserControl
    {
        #region "Propriedades"
        public string SenhaAtual
        {
            get { return txtSenhaAtual.Text; }
        }

        public string NovaSenha
        {
            get { return txtNovaSenha.Text; }
        }


        #endregion

        protected void ValidarSenha_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = Membership.ValidateUser(Membership.GetUser().UserName, txtSenhaAtual.Text);
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("formulario");
            l.Add("validator");
            return l;
        }
    }
}