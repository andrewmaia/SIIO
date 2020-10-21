using System;
using SIIO.BO;
using SIIO.Model;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Usuario.UsuarioAlterarSenha
{
    public partial class UsuarioAlterarSenha : Atomo.Web.Page 
    {

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Salvar();
            }

        }

        private void Salvar()
        {
            Membership.GetUser().ChangePassword(ucFormulario.SenhaAtual, ucFormulario.NovaSenha);  
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("usuarioAlterarSenha");
            l.Add("botao");
            l.Add("validator");
            return l;
        }

    }
}