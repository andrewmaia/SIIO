using System;
using Atomo.Data;
using System.Collections.Generic;

namespace SIIO.DA
{
    public class IdeiaArquivo : BaseDA 
    {

        public void Inserir(Model.IdeiaArquivo parametros)
        {
            rb.EncapsulatedInsert(parametros, "dbo.IdeiaArquivo_Inserir");
        }

        public object SelecionarPorIdeia(Model.IdeiaArquivo parametros)
        {
            return rb.EncapsulatedRead<Model.IdeiaArquivo>(parametros, "dbo.IdeiaArquivo_SelecionarPorIdeia", false);
        }
    }
}
