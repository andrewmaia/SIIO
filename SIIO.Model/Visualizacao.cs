using System;

namespace SIIO.Model
{
    public class Visualizacao
    {
        public int VisualizacaoID
        {
            get { return this.visualizacaoID; }
            set { this.visualizacaoID = value; }
        }
        private int visualizacaoID;

        public Guid? Aspnet_UserID
        {
            get { return this.aspnet_UserID; }
            set { this.aspnet_UserID = value; }
        }
        private Guid? aspnet_UserID;

        public int IdeiaID
        {
            get { return this.ideiaID; }
            set { this.ideiaID = value; }
        }
        private int ideiaID;

        public DateTime Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        private DateTime data;
    }
}
