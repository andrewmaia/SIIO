using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Usuario.UsuarioEditarControles
{
    public partial class UcFormulario : Atomo.Web.UserControl
    {

        #region "Propriedades"
        public string Nome
        {
            get { return txtNome.Text; }
            set { txtNome.Text=value;}
        }

        public DateTime DataNascimento
        {
            get { return DateTime.Parse(txtDataNascimento.Text) ; }
            set { txtDataNascimento.Text = value.ToString("dd/MM/yyyy"); }
        }

        public int Estado
        {
            get { return int.Parse(ddlEstado.SelectedValue); }
            set {
                    ddlEstado.SelectedIndex = ddlEstado.Items.IndexOf(ddlEstado.Items.FindByValue(value.ToString()));
                    CarregarCidades();
                }
        }

        public int Cidade
        {
            get { return int.Parse(ddlCidade.SelectedValue); }
            set { ddlCidade.SelectedIndex = ddlCidade.Items.IndexOf(ddlCidade.Items.FindByValue(value.ToString())); }
        }

        #endregion


        protected void ddlEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCidades();
        }


        private void CarregarCidades()
        {
            BO.Cidade cidadeBO = new BO.Cidade();
            ddlCidade.DataSource = cidadeBO.SelecionarPorEstado(int.Parse(ddlEstado.SelectedValue));
            ddlCidade.DataBind();
        }

        public void CarregarEstados()
        {
            BO.Estado estadoBO = new BO.Estado();
            ddlEstado.DataSource = estadoBO.SelecionarTodos();
            ddlEstado.DataBind();
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