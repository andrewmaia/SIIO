using System;

namespace SIIO.Model
{
    public class Ideia
    {
        public int IdeiaID
        {
            get { return this.ideiaID; }
            set { this.ideiaID = value; }
        }
        private int ideiaID;

        public int CategoriaID
        {
            get { return this.categoriaID; }
            set { this.categoriaID = value; }
        }
        private int categoriaID;

        public string CategoriaDescricao
        {
            get { return this.categoriaDescricao; }
            set { this.categoriaDescricao = value; }
        }
        private string categoriaDescricao;

        public Guid Aspnet_UserID
        {
            get { return this.aspnet_UserID; }
            set { this.aspnet_UserID = value; }
        }
        private Guid aspnet_UserID;


        public string UsuarioNome
        {
            get { return this.usuarioNome; }
            set { this.usuarioNome = value; }
        }
        private string usuarioNome;

        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }
        private string titulo;

        public string PreDescricao
        {
            get { return this.preDescricao; }
            set { this.preDescricao = value; }
        }
        private string preDescricao;

        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        private string descricao;

        public bool Restrita
        {
            get { return this.restrita; }
            set { this.restrita = value; }
        }
        private bool restrita;

        public DateTime DataCadastro
        {
            get { return this.dataCadastro; }
            set { this.dataCadastro = value; }
        }
        private DateTime dataCadastro;
    }
}
