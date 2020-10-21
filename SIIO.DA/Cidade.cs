using System;
using Atomo.Data;
using System.Collections.Generic;


namespace SIIO.DA
{
    public class Cidade : BaseDA 
    {
        public object Selecionar(Model.Cidade cidadeModel)
        {
            return rb.EncapsulatedRead<Model.Cidade>(cidadeModel, "dbo.Cidade_SelecionarPorEstado", false);
        }
    }
}
