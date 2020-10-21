using System;
using Atomo.Data;
using System.Collections.Generic;

namespace SIIO.DA
{
    public class Usuario : BaseDA 
    {

        public Model.Usuario SelecionarPorID(Model.Usuario parametros)
        {
            return rb.EncapsulatedRead<Model.Usuario>(parametros, "dbo.Usuario_SelecionarPorID",0,false );
        }

        public void Inserir(Model.Usuario parametros)
        {
            rb.EncapsulatedInsert(parametros, "dbo.Usuario_Inserir");
        }

        public void Alterar(Model.Usuario parametros)
        {
            rb.EncapsulatedInsert(parametros, "dbo.Usuario_Alterar");
        }
    }
}
