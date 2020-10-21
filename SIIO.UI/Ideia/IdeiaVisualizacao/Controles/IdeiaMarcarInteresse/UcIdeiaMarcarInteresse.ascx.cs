using System;
using SIIO.Model;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Ideia.IdeiaVisualizacaoControles
{
    public partial class UcIdeiaMarcarInteresse : Atomo.Web.UserControl 
    {
        BO.IdeiaInteresse ideiaInteresseBO = new BO.IdeiaInteresse();

        private int ideiaID;

        public void Carregar(int ideiaID)
        {
            this.ideiaID = ideiaID;
            HabilitarMarcar(ideiaInteresseBO.MarcadoInteresse(ideiaID));
 
        }

        protected void lkMarcarInteresse_Click1(object sender, EventArgs e)
        {
            ideiaInteresseBO.MarcarInteresse(this.ideiaID);
            HabilitarMarcar(true);
        }

        protected void lkDesmarcarInteresse_Click1(object sender, EventArgs e)
        {
            ideiaInteresseBO.DesmarcarInteresse(this.ideiaID);
            HabilitarMarcar(false);
        }

        private void HabilitarMarcar(bool habilitar)
        {
            lkMarcarInteresse.Visible = !habilitar;
            lkDesmarcarInteresse.Visible = habilitar;
        }

    }
}