using System;
using Atomo.Data;
using System.Collections.Generic;

namespace SIIO.DA
{
    public class Visualizacao: BaseDA
    {
        public void Inserir(Model.Visualizacao parametros)
        {
            rb.EncapsulatedInsert<Model.Visualizacao>(parametros, "dbo.Visualizacao_Inserir");
        }

    }
}
