using System;


namespace SIIO.Model
{
    public class IdeiaArquivo
    {
        public int IdeiaArquivoID
        {
            get { return this.ideiaArquivoID; }
            set { this.ideiaArquivoID = value; }
        }
        private int ideiaArquivoID;

        public int IdeiaID
        {
            get { return this.ideiaID; }
            set { this.ideiaID = value; }
        }
        private int ideiaID;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        private string nome;

        public byte[] Binario
        {
            get { return this.binario; }
            set { this.binario = value; }
        }
        private byte[] binario;


        public DateTime  Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        private DateTime data;


    }
}
