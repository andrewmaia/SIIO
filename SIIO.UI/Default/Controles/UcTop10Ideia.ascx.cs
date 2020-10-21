using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;


namespace SIIO.UI.DefaultControles
{
    public partial class UcTop10Ideia : Atomo.Web.UserControl 
    {
        #region propriedades
        private List<Model.Ideia> ideias;
        public List<Model.Ideia> Ideias
        {
            get
            {
                return ideias;
            }
            set
            {
                ideias = value;
            }
        }

        private string titulo;
        public string  Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        #endregion


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            h2.InnerText = titulo ;
            UcIC.Ideias = ideias;
            UcIC.DataBind();
        }
    }
}