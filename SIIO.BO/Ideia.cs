using System;
using SIIO.DA;
using SIIO.Model;
using System.Web;
using System.Data;
using System.Web.Security;
using System.Collections.Generic;

namespace SIIO.BO
{
    public class Ideia
    {
        DA.Ideia ideiaDA = new DA.Ideia();

        public object  Recentes()
        {
            return ideiaDA.Recentes(); 
        }

        public object  MaisVistas()
        {
            return ideiaDA.MaisVistas(); 
        }

        public object Buscar(string texto)
        {
            Model.Ideia ideiaModel = new Model.Ideia();
            ideiaModel.Titulo = texto;
            return ideiaDA.Buscar(ideiaModel); 
        }

        public Model.Ideia SelecionarPorID(int ideiaID)
        {
            Model.Ideia ideiaModel = new Model.Ideia();
            ideiaModel.IdeiaID = ideiaID;

            List<Model.Ideia> ideiaList = ideiaDA.SelecionarPorID(ideiaModel);
            if (ideiaList.Count > 0)
                return ideiaList[0];
            else
                return null;
        }

        public object SelecionarPorUsuario()
        {
            Model.Ideia ideiaModel = new Model.Ideia();
            ideiaModel.Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey;
            return ideiaDA.SelecionarPorUsuario(ideiaModel);
        }

        public int Inserir(Model.Ideia ideiaModel)
        {
            ideiaModel.Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey;
            ideiaModel.DataCadastro = DateTime.Now;
            return ideiaDA.Inserir(ideiaModel);
        }

        public void Alterar(Model.Ideia ideiaModel)
        {
            ideiaModel.Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey;
            ideiaDA.Alterar(ideiaModel);
        }


        public bool NecessitaLogar(Model.Ideia ideiaModel)
        {
            return ideiaModel.Restrita && !HttpContext.Current.User.Identity.IsAuthenticated;
        }

        public bool PossuiAcesso(Model.Ideia ideiaModel)
        {
            if (ideiaModel.Restrita && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                BO.IdeiaAcesso ideiaAcessoBO = new BO.IdeiaAcesso();
                return ideiaAcessoBO.PossuiAcesso(ideiaModel.IdeiaID);
            }

            return true;
        }

        public bool UsuarioLogadoEhDono(int ideiaID)
        {
            return this.UsuarioLogadoEhDono(this.SelecionarPorID(ideiaID));
        }

        public bool UsuarioLogadoEhDono(Model.Ideia ideiaModel)
        {
            return (ideiaModel.Aspnet_UserID == (Guid)Membership.GetUser().ProviderUserKey);
        }
    }
}
