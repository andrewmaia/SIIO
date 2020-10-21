using System;
using SIIO.DA;
using SIIO.Model;
using System.Web;
using System.Data;
using System.Web.Security;

namespace SIIO.BO
{
    public class Usuario
    {
        DA.Usuario usuarioDA = new DA.Usuario();

        public Model.Usuario  SelecionarLogado()
        {
            Model.Usuario usuarioModel= new Model.Usuario();
            usuarioModel.Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey;
            return usuarioDA.SelecionarPorID(usuarioModel);
        }

        public void Inserir(Model.Usuario usuarioModel)
        {
            usuarioDA.Inserir(usuarioModel);  
        }

        public void AlterarUsuarioLogado(Model.Usuario usuarioModel)
        {
            usuarioModel.Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey;
            usuarioDA.Alterar(usuarioModel);
        }

        
    }
}
