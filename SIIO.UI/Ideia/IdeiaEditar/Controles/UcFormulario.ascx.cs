using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;


namespace SIIO.UI.Ideia.IdeiaEditarControles
{
    public partial class UcFormulario : Atomo.Web.UserControl
    {
        #region "Propriedades"
        public string Titulo
        {
            get { return txtTitulo.Text; }
            set { txtTitulo.Text = value; }
        }

        public string PreDescricao
        {
            get { return txtPreDescricao.Text; }
            set { txtPreDescricao.Text = value; }
        }

        public string Descricao
        {
            get { return txtDescricao.Text; }
            set { txtDescricao.Text = value; }
        }

        public int Categoria
        {
            get { return int.Parse(ddlCategoria.SelectedValue); }
            set { ddlCategoria.SelectedIndex = ddlCategoria.Items.IndexOf(ddlCategoria.Items.FindByValue(value.ToString())); }
        }

        public bool Restrita
        {
            get { return chkRestrita.Checked; }
            set { chkRestrita.Checked = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarCategoria();
            }
        }

        public void CarregarCategoria()
        {
            BO.Categoria categoriaBO = new BO.Categoria();

            ddlCategoria.DataSource = categoriaBO.SelecionarTodos();
            ddlCategoria.DataBind();
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