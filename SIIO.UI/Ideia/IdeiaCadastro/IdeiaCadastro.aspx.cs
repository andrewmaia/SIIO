using System;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using SIIO.UI.Common.Controles;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Ideia
{
    public partial class IdeiaCadastro : Atomo.Web.Page
    {


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            Model.Ideia ideiaModel = new Model.Ideia();
            ideiaModel.Titulo = ucFormulario.Titulo.Trim();
            ideiaModel.PreDescricao = ucFormulario.PreDescricao.Trim();
            ideiaModel.Descricao = ucFormulario.Descricao.Trim();
            ideiaModel.CategoriaID = ucFormulario.Categoria;
            ideiaModel.Restrita = ucFormulario.Restrita;

            BO.Ideia ideiaBO = new BO.Ideia();
            int ideiaID = ideiaBO.Inserir(ideiaModel);

            SalvarArquivos(ideiaID); 
        }

        private void SalvarArquivos(int ideiaID)
        {
            if (ucFormulario.PossuiArquivo)
            {
                Model.IdeiaArquivo ideiaArquivoModel = new Model.IdeiaArquivo();
                ideiaArquivoModel.IdeiaID = ideiaID;
                ideiaArquivoModel.Nome = ucFormulario.NomeArquivo;
                ideiaArquivoModel.Binario = ucFormulario.BytesArquivo;

                BO.IdeiaArquivo ideiaArquivoBO = new BO.IdeiaArquivo();
                ideiaArquivoBO.Inserir(ideiaArquivoModel);

            }
        }



        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("ideiaCadastro");
            l.Add("botao");
            return l;
        }
    }
}
