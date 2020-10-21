using System;
using SIIO.Model;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;


namespace SIIO.UI.Common.Controles
{
    public partial class UcIdeiaColecao : System.Web.UI.UserControl
    {

        private string cssClass;

        public string CssClass
        {
            get { return this.cssClass; }
            set { this.cssClass = value.Trim(); }
        }

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

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

            Lista.ItemDataBound += new  RepeaterItemEventHandler(OnItemDataBound);
            Lista.DataSource = ideias;
            Lista.DataBind();
        }


        private void OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            UcIdeia ucIdeia = LoadControl("../UcIdeia/ucIdeia.ascx") as UcIdeia;
            ucIdeia.Ideia = e.Item.DataItem as Model.Ideia;
            if (cssClass != string.Empty)
                ucIdeia.CssClass = this.cssClass;
            e.Item.Controls.Add(ucIdeia);

        }
    }
}