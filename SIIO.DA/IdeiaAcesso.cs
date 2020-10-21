using System;
using Atomo.Data;
using System.Collections.Generic;

namespace SIIO.DA
{
    public class IdeiaAcesso : BaseDA 
    {
        public bool PossuiAcesso(Model.IdeiaAcesso parametros)
        {
            Model.Resultado r = rb.EncapsulatedRead<Model.Resultado>(parametros, "dbo.IdeiaAcesso_PossuiAcesso", 0, false);
            return (bool)r.Valor;
        }

        public object SelecionarPorIdeia(Model.IdeiaAcesso parametros)
        {
            return rb.EncapsulatedRead<Model.IdeiaAcesso>(parametros, "dbo.IdeiaAcesso_SelecionarPorIdeia");
        }

        public void ExecutarAtivacao(Model.IdeiaAcesso parametros)
        {
            rb.EncapsulatedInsert(parametros, "dbo.IdeiaAcesso_ExecutarAtivacao");
        }

        public void Criar(Model.IdeiaAcesso parametros)
        {
            rb.EncapsulatedInsert(parametros, "dbo.IdeiaAcesso_Criar");
        }
    }
}
