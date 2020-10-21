using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Ideia.IdeiaCadastroControles
{
    public partial class UcFormulario : Atomo.Web.UserControl
    {

        #region "Propriedades"
        public string Titulo
        {
            get { return txtTitulo.Text; }
        }

        public string PreDescricao
        {
            get { return txtPreDescricao.Text; }
        }

        public string Descricao
        {
            get { return txtDescricao.Text; }
        }

        public int Categoria
        {
            get { return int.Parse(ddlCategoria.SelectedValue); }
        }

        public bool Restrita
        {
            get { return chkRestrita.Checked ; }
        }

        public bool PossuiArquivo
        {
            get { return fuAnexo.HasFile; }
        }

        public string NomeArquivo
        {
            get { return fuAnexo.FileName; }
        }

        public byte[] BytesArquivo
        {
            get { return fuAnexo.FileBytes; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarCategoria();
            }
        }

        private void CarregarCategoria()
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