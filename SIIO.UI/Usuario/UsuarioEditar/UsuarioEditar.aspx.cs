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
    public partial class UsuarioEditar : Atomo.Web.Page
    {
        BO.Usuario usuarioBO = new BO.Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ucFormulario.CarregarEstados();
                Carregar();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Salvar();
            }
        }

        private void Carregar()
        {
            Model.Usuario usuarioModel = usuarioBO.SelecionarLogado();
            ucFormulario.Nome = usuarioModel.Nome;
            ucFormulario.DataNascimento = usuarioModel.DataNascimento;
            ucFormulario.Estado = usuarioModel.EstadoID;
            ucFormulario.Cidade = usuarioModel.CidadeID;
        }

        private void Salvar()
        {
            Model.Usuario usuarioModel = new Model.Usuario();
            usuarioModel.Nome = ucFormulario.Nome;
            usuarioModel.DataNascimento = ucFormulario.DataNascimento;
            usuarioModel.EstadoID = ucFormulario.Estado;
            usuarioModel.CidadeID = ucFormulario.Cidade;
            usuarioBO.AlterarUsuarioLogado(usuarioModel);
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("usuarioEditar");
            l.Add("botao");
            l.Add("validator");
            return l;
        }
    }
}