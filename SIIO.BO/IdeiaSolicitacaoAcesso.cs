using System;
using SIIO.DA;
using SIIO.Model;
using System.Web;
using System.Data;
using System.Web.Security;

namespace SIIO.BO
{
    public class IdeiaSolicitacaoAcesso
    {
        DA.IdeiaSolicitacaoAcesso ideiaSolicitacaoAcessoDA = new DA.IdeiaSolicitacaoAcesso();

        public void SolicitarAcesso(Model.IdeiaSolicitacaoAcesso modelIdeiaSolicitacaoAcesso)
        {
            modelIdeiaSolicitacaoAcesso.Aspnet_UserID =  (Guid)Membership.GetUser().ProviderUserKey;
            modelIdeiaSolicitacaoAcesso.Data = DateTime.Now;
            ideiaSolicitacaoAcessoDA.Inserir(modelIdeiaSolicitacaoAcesso);
        }

        public object SelecionarPendenteAprovacao()
        {
            Model.IdeiaSolicitacaoAcesso modelIdeiaSolicitacaoAcesso = new Model.IdeiaSolicitacaoAcesso();
            modelIdeiaSolicitacaoAcesso.Aprovador_Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey;
            return ideiaSolicitacaoAcessoDA.SelecionarPendenteAprovacao(modelIdeiaSolicitacaoAcesso);
        }

        public void Aprovar(int ideiaSolicitacaoAcessoID)
        {
            Model.IdeiaSolicitacaoAcesso modelIdeiaSolicitacaoAcesso = new Model.IdeiaSolicitacaoAcesso();
            modelIdeiaSolicitacaoAcesso.IdeiaSolicitacaoAcessoID = ideiaSolicitacaoAcessoID;
            modelIdeiaSolicitacaoAcesso.Aprovado   = true;
            modelIdeiaSolicitacaoAcesso.DataAprovacao = DateTime.Now;
            ideiaSolicitacaoAcessoDA.ExecutarAprovacao(modelIdeiaSolicitacaoAcesso);

            BO.IdeiaAcesso ideiaAcessoBO = new BO.IdeiaAcesso();
            ideiaAcessoBO.Criar(ideiaSolicitacaoAcessoID);
        }

        public void Reprovar(int ideiaSolicitacaoAcessoID)
        {
            Model.IdeiaSolicitacaoAcesso modelIdeiaSolicitacaoAcesso = new Model.IdeiaSolicitacaoAcesso();
            modelIdeiaSolicitacaoAcesso.IdeiaSolicitacaoAcessoID = ideiaSolicitacaoAcessoID;
            modelIdeiaSolicitacaoAcesso.Aprovado = false;
            modelIdeiaSolicitacaoAcesso.DataAprovacao = DateTime.Now;
            ideiaSolicitacaoAcessoDA.ExecutarAprovacao(modelIdeiaSolicitacaoAcesso); 
        }
    }
}
