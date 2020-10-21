using System;
using SIIO.Model;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;


namespace SIIO.UI.Common.Controles
{
    public partial class UcIdeiaExibicao : Atomo.Web.UserControl
    {
        #region Propriedades

        private Model.Ideia ideia;

        public Model.Ideia Ideia
        {
            get
            {
                return ideia;
            }
            set
            {
                ideia = value;
            }
        }


        private Model.IdeiaArquivo ideiaArquivo;

        public Model.IdeiaArquivo IdeiaArquivo
        {
            get
            {
                return ideiaArquivo;
            }
            set
            {
                ideiaArquivo = value;
            }
        }

        #endregion 

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            if (this.ideia != null)
            {
                txtAutor.Text = ideia.UsuarioNome;
                txtCategoria.Text = ideia.CategoriaDescricao;
                txtTitulo.Text = ideia.Titulo;
                txtPreDescricao.Text = ideia.PreDescricao;
                txtDescricao.Text = ideia.Descricao;
            }

            if (this.ideiaArquivo != null)
            {
                divAnexo.Visible=true;
                lkAnexo.Text = this.ideiaArquivo.Nome; 
            }
        }

        protected void lkAnexo_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + ideiaArquivo.Nome );
            Response.AddHeader("Content-Length", ideiaArquivo.Binario.Length.ToString());
            Response.BinaryWrite (ideiaArquivo.Binario );
            Response.End();
        }


    }
}
