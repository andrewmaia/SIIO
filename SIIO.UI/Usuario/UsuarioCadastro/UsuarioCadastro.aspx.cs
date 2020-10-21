using System;
using SIIO.BO;
using SIIO.Model;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Usuario
{
    public partial class UsuarioCadastro : Atomo.Web.Page 
    {
        BO.Usuario usuarioBO = new BO.Usuario();

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Salvar();
            }
        }


        private void Salvar()
        {
            MembershipUser user = Membership.CreateUser(ucFormulario.Email, ucFormulario.Senha, ucFormulario.Email);
            Guid aspnet_userID = (Guid)user.ProviderUserKey;

            Model.Usuario usuarioModel = new Model.Usuario();
            usuarioModel.Aspnet_UserID = aspnet_userID;
            usuarioModel.Nome = ucFormulario.Nome;
            usuarioModel.DataNascimento = ucFormulario.DataNascimento;
            usuarioModel.EstadoID = ucFormulario.EstadoID;
            usuarioModel.CidadeID = ucFormulario.CidadeID;
            usuarioBO.Inserir(usuarioModel);
            FormsAuthentication.RedirectFromLoginPage(ucFormulario.Email, false);
        }


        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("usuarioCadastro");
            l.Add("botao");
            l.Add("validator");
            return l;
        }




    }
}