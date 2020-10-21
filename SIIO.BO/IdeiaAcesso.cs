using System;
using SIIO.DA;
using SIIO.Model;
using System.Web;
using System.Data;
using System.Web.Security;

namespace SIIO.BO
{
    public class IdeiaAcesso
    {
        DA.IdeiaAcesso ideiaAcessoDA = new DA.IdeiaAcesso();

        public bool PossuiAcesso(int ideiaID)
        {
            Model.IdeiaAcesso ideiaAcessoModel = new Model.IdeiaAcesso();
            ideiaAcessoModel.IdeiaID = ideiaID;
            ideiaAcessoModel.Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey; 

            return ideiaAcessoDA.PossuiAcesso(ideiaAcessoModel);
        }

        public object SelecionarPorIdeia(int ideiaID)
        {
            Model.IdeiaAcesso ideiaAcessoModel = new Model.IdeiaAcesso();
            ideiaAcessoModel.IdeiaID = ideiaID;
            return ideiaAcessoDA.SelecionarPorIdeia(ideiaAcessoModel);
        }

        public void Ativar(int ideiaAcessoID)
        {
            Model.IdeiaAcesso ideiaAcessoModel = new Model.IdeiaAcesso();
            ideiaAcessoModel.IdeiaAcessoID = ideiaAcessoID;
            ideiaAcessoModel.Ativo = true;
            ideiaAcessoDA.ExecutarAtivacao(ideiaAcessoModel);
        }

        public void Desativar(int ideiaAcessoID)
        {
            Model.IdeiaAcesso ideiaAcessoModel = new Model.IdeiaAcesso();
            ideiaAcessoModel.IdeiaAcessoID = ideiaAcessoID;
            ideiaAcessoModel.Ativo = false;
            ideiaAcessoDA.ExecutarAtivacao(ideiaAcessoModel);
        }


        public void Criar(int ideiaSolicitacaoAcessoID)
        {
            Model.IdeiaAcesso ideiaAcessoModel = new Model.IdeiaAcesso();
            ideiaAcessoModel.IdeiaSolicitacaoAcessoID = ideiaSolicitacaoAcessoID;
            ideiaAcessoDA.Criar(ideiaAcessoModel);
        }
    }
}
