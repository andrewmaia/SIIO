using System;
using Atomo.Data;
using System.Collections.Generic;


namespace SIIO.DA
{
    public class IdeiaSolicitacaoAcesso: BaseDA 
    {
        public void Inserir(Model.IdeiaSolicitacaoAcesso parametros)
        {
            rb.EncapsulatedInsert(parametros, "dbo.IdeiaSolicitacaoAcesso_Inserir");
        }

        public object SelecionarPendenteAprovacao(Model.IdeiaSolicitacaoAcesso parametros)
        {
            return rb.EncapsulatedRead<Model.IdeiaSolicitacaoAcesso>(parametros, "dbo.IdeiaSolicitacaoAcesso_SelecionarPendenteAprovacao"); 
        }

        public void ExecutarAprovacao(Model.IdeiaSolicitacaoAcesso parametros)
        {
            rb.EncapsulatedInsert(parametros, "dbo.IdeiaSolicitacaoAcesso_ExecutarAprovacao");
        }

    }
}
