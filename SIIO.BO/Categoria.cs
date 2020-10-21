using System;
using SIIO.DA;
using SIIO.Model;
using System.Web;
using System.Data;

namespace SIIO.BO
{
    public class Categoria
    {
        DA.Categoria categoriaDA = new DA.Categoria();

        public object SelecionarTodos()
        {
            return categoriaDA.Selecionar(new Model.Categoria());
        }
    }
}
