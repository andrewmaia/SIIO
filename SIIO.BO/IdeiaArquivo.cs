using System;
using SIIO.DA;
using SIIO.Model;
using System.Web;
using System.Data;
using System.Collections.Generic; 


namespace SIIO.BO
{
    public class IdeiaArquivo
    {
        DA.IdeiaArquivo ideiaArquivoDA = new DA.IdeiaArquivo();

        public void Inserir(Model.IdeiaArquivo  ideiaArquivoModel)
        {
            ideiaArquivoModel.Data = DateTime.Now;
            ideiaArquivoDA.Inserir(ideiaArquivoModel);
        }

        public Model.IdeiaArquivo SelecionarPorIdeia(int ideiaID)
        {
            Model.IdeiaArquivo ideaArquivoModel = new Model.IdeiaArquivo();
            ideaArquivoModel.IdeiaID = ideiaID;

            List<Model.IdeiaArquivo> ideiaArquivoLista = (List<Model.IdeiaArquivo>)ideiaArquivoDA.SelecionarPorIdeia(ideaArquivoModel);
            if (ideiaArquivoLista.Count > 0)
                return ideiaArquivoLista[0];
            else
                return null;
            
        }
    }
}
