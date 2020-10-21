using System;
using SIIO.Model; 
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIIO.UI.Common.Controles
{
    public partial class UcIdeia : Atomo.Web.UserControl
    {
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

        private string cssClass;

        public string CssClass
        {
            set { this.cssClass = value.Trim(); }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            Link.HRef = "/VisualizarIdeia?ideiaID=" + ideia.IdeiaID.ToString();
            Titulo.Text = ideia.Titulo;
            if (ideia.Restrita)
                Titulo.Text += "(Restrita)";
            PreDescricao.Text = ideia.PreDescricao;
            DataPostagem.Text = ideia.DataCadastro.ToString("dd/MM/yyyy");
            if (cssClass != string.Empty)
                divPrincipal.Attributes.Add("class", cssClass);

        }
    }
}