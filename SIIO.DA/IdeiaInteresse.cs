using System;
using Atomo.Data;
using System.Collections.Generic;

namespace SIIO.DA
{
    public class IdeiaInteresse: BaseDA
    {
        public object SelecionarPorUsuario(Model.IdeiaInteresse ideiaInteresseModel)
        {
            return rb.EncapsulatedRead<Model.Ideia>(ideiaInteresseModel, "dbo.IdeiaInteresse_SelecionarPorUsuario", false);
        }

        public void Inserir(Model.IdeiaInteresse parametros)
        {
            rb.EncapsulatedInsert(parametros, "dbo.IdeiaInteresse_Inserir");
        }

        public void Excluir(Model.IdeiaInteresse parametros)
        {
            rb.EncapsulatedInsert(parametros, "dbo.IdeiaInteresse_Excluir");
        }

        public bool MarcadoInteresse(Model.IdeiaInteresse parametros)
        {
            Model.Resultado r = rb.EncapsulatedRead<Model.Resultado>(parametros, "dbo.IdeiaInteresse_MarcadoInteresse", 0, false);
            return (bool)r.Valor;
        }

    }
}
