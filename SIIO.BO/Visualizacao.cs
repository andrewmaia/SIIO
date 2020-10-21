using System;
using SIIO.DA;
using SIIO.Model;
using System.Web;
using System.Data;
using System.Web.Security;

namespace SIIO.BO
{
    public class Visualizacao
    {
        DA.Visualizacao visualizacaoDA = new DA.Visualizacao();

        public void AdicionarVisualizacao(int ideiaID)
        {
            Model.Visualizacao visualizacaoModel = new Model.Visualizacao();
            visualizacaoModel.IdeiaID = ideiaID;
            visualizacaoModel.Data = DateTime.Now;
            if (HttpContext.Current.User.Identity.IsAuthenticated)
                visualizacaoModel.Aspnet_UserID = (Guid)Membership.GetUser().ProviderUserKey;

            visualizacaoDA.Inserir(visualizacaoModel);
            
        }
    }
}
