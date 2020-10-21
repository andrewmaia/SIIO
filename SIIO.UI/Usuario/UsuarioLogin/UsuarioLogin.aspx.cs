using System;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Usuario
{
    public partial class UsuarioLogin : Atomo.Web.Page 
    {
        protected void btnLogar_Click(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(UcFormulario.Email, UcFormulario.Senha))
            {
                FormsAuthentication.RedirectFromLoginPage(UcFormulario.Email, UcFormulario.ContinuarConectado);
            }
            else
            {
                CustomValidator cv = new CustomValidator();
                cv.ErrorMessage = "Email ou Senha Inválidos";
                cv.ValidationGroup = "mensagem";
                cv.IsValid = false;
                Page.Validators.Add(cv);
            }
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("login");
            l.Add("botao");
            l.Add("validator");
            return l;
        }
    }
}
