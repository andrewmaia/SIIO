using System;
using SIIO.DA;
using SIIO.Model;
using System.Web;
using System.Data;

namespace SIIO.BO
{
    public class Cidade
    {
        DA.Cidade cidadeDA = new DA.Cidade();

        public object SelecionarPorEstado(int estadoID)
        {
            Model.Cidade cidadeModel = new Model.Cidade();
            cidadeModel.EstadoID = estadoID ;
            return cidadeDA.Selecionar(cidadeModel);
        }
    }
}
