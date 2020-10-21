using System;
using Atomo.Data;
using System.Collections.Generic;


namespace SIIO.DA
{
    public class Estado : BaseDA 
    {
        public object Selecionar(Model.Estado estadoModel)
        {
            return rb.EncapsulatedRead<Model.Estado>(estadoModel, "dbo.Estado_Selecionar", false);
        }
    }
}
