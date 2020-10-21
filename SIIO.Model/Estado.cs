using System;


namespace SIIO.Model
{
    public class Estado
    {
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

        public string UF
        {
            get { return this.uf; }
            set { this.uf = value; }
        }
        private string uf;
    }
}
