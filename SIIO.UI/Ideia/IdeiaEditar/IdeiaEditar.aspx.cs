using System;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using SIIO.UI.Common.Controles;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Ideia
{
    public partial class IdeiaEditar : Atomo.Web.Page
    {
        BO.Ideia ideiaBO = new BO.Ideia();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int ideiaID;
                if (int.TryParse(Request.QueryString["ideiaID"], out ideiaID))
                {
                    this.IdeiaID = ideiaID;
                    ucFormulario.CarregarCategoria();
                    Carregar();
                }
                else
                    Server.Transfer("/erro/badRequest/badRequest.aspx");
                    
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }


        private void Carregar()
        {
            Model.Ideia ideiaModel = ideiaBO.SelecionarPorID(this.IdeiaID);
            if (ideiaBO.UsuarioLogadoEhDono(ideiaModel))
            {
                ucFormulario.Titulo = ideiaModel.Titulo;
                ucFormulario.PreDescricao = ideiaModel.PreDescricao;
                ucFormulario.Descricao = ideiaModel.Descricao;
                ucFormulario.Categoria =ideiaModel.CategoriaID;
                ucFormulario.Restrita = ideiaModel.Restrita;
            }
            else
                Server.Transfer("/erro/badRequest/badRequest.aspx");
        }


        private void Salvar()
        {
            Model.Ideia ideiaModel = new Model.Ideia();
            ideiaModel.IdeiaID = this.IdeiaID;
            ideiaModel.Titulo = ucFormulario.Titulo.Trim();
            ideiaModel.PreDescricao = ucFormulario.PreDescricao.Trim();
            ideiaModel.Descricao = ucFormulario.Descricao.Trim();
            ideiaModel.CategoriaID = ucFormulario.Categoria;
            ideiaModel.Restrita = ucFormulario.Restrita;
            ideiaBO.Alterar(ideiaModel);
        }

        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("ideiaEditar");
            l.Add("botao");
            return l;
        }

        private int IdeiaID
        {
            get { return (int)ViewState["ideiaID"]; }
            set { ViewState["ideiaID"] = value; }
        }
    }
}