using System;
using Atomo.Data;
using System.Collections.Generic;


namespace SIIO.DA
{
    public class Ideia : BaseDA 
    {
        public object MaisVistas()
        {
            return rb.EncapsulatedRead<Model.Ideia>(null, "dbo.Ideia_MaisVistas", false); 
        }

        public object Recentes()
        {
            return rb.EncapsulatedRead<Model.Ideia>(null, "dbo.Ideia_Recentes", false);
        }

        public object Buscar(Model.Ideia ideiaModel)
        {
            return rb.EncapsulatedRead<Model.Ideia>(ideiaModel, "dbo.Ideia_Buscar", false);
        }

        public List<Model.Ideia> SelecionarPorID(Model.Ideia ideiaModel)
        {
            return (List<Model.Ideia>)rb.EncapsulatedRead<Model.Ideia>(ideiaModel, "dbo.Ideia_SelecionarPorID", false);
        }

        public object SelecionarPorUsuario(Model.Ideia ideiaModel)
        {
            return rb.EncapsulatedRead<Model.Ideia>(ideiaModel, "dbo.Ideia_SelecionarPorUsuario", false);
        }

        public int Inserir(Model.Ideia parametros)
        {
            Model.Resultado r = rb.EncapsulatedRead<Model.Resultado>(parametros, "dbo.Ideia_Inserir", 0, false);
            return (int)r.Valor;
        }

        public void Alterar(Model.Ideia parametros)
        {
            rb.EncapsulatedInsert(parametros, "dbo.Ideia_Alterar");
        }

    }

}
