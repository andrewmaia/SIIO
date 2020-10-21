using System;
using SIIO.DA;
using SIIO.Model;
using System.Web;
using System.Data;

namespace SIIO.BO
{
    public class Estado
    {
        DA.Estado estadoDA = new DA.Estado();

        public object SelecionarTodos()
        {
            return estadoDA.Selecionar(null);
        }
    }
}
