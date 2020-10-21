using System;

namespace SIIO.Model
{
    public class IdeiaAcesso
    {
        public int IdeiaAcessoID
        {
            get { return this.ideiaAcessoID; }
            set { this.ideiaAcessoID = value; }
        }
        private int ideiaAcessoID;

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

        public int IdeiaSolicitacaoAcessoID
        {
            get { return this.ideiaSolicitacaoAcessoID; }
            set { this.ideiaSolicitacaoAcessoID = value; }
        }
        private int ideiaSolicitacaoAcessoID;

        public bool Ativo
        {
            get { return this.ativo; }
            set { this.ativo = value; }
        }
        private bool ativo;

        public string IdeiaTitulo
        {
            get { return this.ideiaTitulo; }
            set { this.ideiaTitulo = value; }
        }
        private string ideiaTitulo;

        public string UsuarioNome
        {
            get { return this.usuarioNome; }
            set { this.usuarioNome = value; }
        }
        private string usuarioNome;


    }
}
