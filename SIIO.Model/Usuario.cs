using System;

namespace SIIO.Model
{
    public class Usuario
    {
        public Guid Aspnet_UserID
        {
            get { return this.aspnet_UserID; }
            set { this.aspnet_UserID = value; }
        }
        private Guid aspnet_UserID;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        private string nome;

        public int EstadoID
        {
            get { return this.estadoID; }
            set { this.estadoID = value; }
        }
        private int estadoID;

        public int CidadeID
        {
            get { return this.cidadeID; }
            set { this.cidadeID = value; }
        }
        private int cidadeID;

        public DateTime DataNascimento
        {
            get { return this.dataNascimento; }
            set { this.dataNascimento = value; }
        }
        private DateTime dataNascimento;


    }
}
