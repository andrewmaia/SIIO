using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Usuario.UsuarioCadastroControles
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

        public string Nome
        {
            get { return txtNome.Text; }
        }

        public DateTime DataNascimento
        {
            get { return DateTime.Parse(txtDataNascimento.Text); }
        }

        public int EstadoID
        {
            get { return int.Parse(ddlEstado.SelectedValue); }
        }

        public int CidadeID
        {
            get { return int.Parse(ddlCidade.SelectedValue); }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarEstados();
            }
        }

        protected void ExisteEmail_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = (Membership.GetUserNameByEmail(txtEmail.Text) == null);
        }

        protected void CheckBoxRequired_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = chkAceite.Checked;
        }

        protected void ddlEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCidades();
        }

        private void CarregarEstados()
        {
            BO.Estado estadoBO = new BO.Estado();

            ddlEstado.DataSource = estadoBO.SelecionarTodos();
            ddlEstado.DataBind();
            CarregarCidades();
        }

        private void CarregarCidades()
        {
            BO.Cidade cidadeBO = new BO.Cidade();
            ddlCidade.DataSource = cidadeBO.SelecionarPorEstado(int.Parse(ddlEstado.SelectedValue));
            ddlCidade.DataBind();
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