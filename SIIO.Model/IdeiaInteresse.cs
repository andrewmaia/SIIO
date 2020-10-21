using System;


namespace SIIO.Model
{
    public class IdeiaInteresse
    {
        public int IdeiaInteresseID
        {
            get { return this.ideiaInteresseID; }
            set { this.ideiaInteresseID = value; }
        }
        private int ideiaInteresseID;

        public int IdeiaID
        {
            get { return this.ideiaID; }
            set { this.ideiaID = value; }
        }
        private int ideiaID;

        public Guid Aspnet_UserID
        {
            get { return this.aspnet_UserID; }
            set { this.aspnet_UserID = value; }
        }
        private Guid aspnet_UserID;

        public DateTime  Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        private DateTime data;
    }
}
