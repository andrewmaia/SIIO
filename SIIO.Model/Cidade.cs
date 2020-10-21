using System;


namespace SIIO.Model
{
    public class Cidade
    {
        public int CidadeID
        {
            get { return this.cidadeID; }
            set { this.cidadeID = value; }
        }
        private int cidadeID;

        public int EstadoID
        {
            get { return this.estadoID; }
            set { this.estadoID = value; }
        }
        private int estadoID;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        private string nome;
    }
}
