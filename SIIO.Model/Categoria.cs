using System;

namespace SIIO.Model
{
    public class Categoria
    {
        public int CategoriaID
        {
            get { return this.categoriaID; }
            set { this.categoriaID = value; }
        }
        private int categoriaID;

        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        private string descricao;
    }
}





