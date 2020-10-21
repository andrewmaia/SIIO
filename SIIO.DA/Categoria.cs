using System;
using Atomo.Data;
using System.Collections.Generic;

namespace SIIO.DA
{
    public class Categoria : BaseDA 
    {
        public object Selecionar(Model.Categoria categoriaModel)
        {
            return rb.EncapsulatedRead<Model.Categoria>(categoriaModel, "dbo.Categoria_Selecionar", true);
        }

    }
}
