using System;
using SIIO.DA;
using SIIO.Model;
using System.Web;
using System.Data;
using System.Web.Security;

namespace SIIO.BO
{
    public class IdeiaInteresse
    {
        DA.IdeiaInteresse ideiaInteresseDA = new DA.IdeiaInteresse();

        public object SelecionarPorUsuario()
        {
            Model.IdeiaInteresse ideiaInteresseModel = new Model.IdeiaInteresse();
            ideiaInteresseModel.Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey;
            return ideiaInteresseDA.SelecionarPorUsuario(ideiaInteresseModel);
        }

        public void MarcarInteresse(int ideiaID)
        {
            Model.IdeiaInteresse ideiaInteresseModel = new Model.IdeiaInteresse();
            ideiaInteresseModel.Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey;
            ideiaInteresseModel.IdeiaID = ideiaID;
            ideiaInteresseModel.Data = DateTime.Now; 
            ideiaInteresseDA.Inserir(ideiaInteresseModel);
        }

        public void DesmarcarInteresse(int ideiaID)
        {
            Model.IdeiaInteresse ideiaInteresseModel = new Model.IdeiaInteresse();
            ideiaInteresseModel.Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey;
            ideiaInteresseModel.IdeiaID = ideiaID;
            ideiaInteresseDA.Excluir(ideiaInteresseModel);
        }

        public bool  MarcadoInteresse(int ideiaID)
        {
            Model.IdeiaInteresse ideiaInteresseModel = new Model.IdeiaInteresse();
            ideiaInteresseModel.Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey;
            ideiaInteresseModel.IdeiaID = ideiaID;
            return ideiaInteresseDA.MarcadoInteresse(ideiaInteresseModel);
        }
    }
}
