using System;


namespace SIIO.Model
{
    public class IdeiaSolicitacaoAcesso
    {

        public int IdeiaSolicitacaoAcessoID
        {
            get { return this.ideiaSolicitacaoAcessoID; }
            set { this.ideiaSolicitacaoAcessoID = value; }
        }
        private int ideiaSolicitacaoAcessoID;

        public int IdeiaID
        {
            get { return this.ideiaID; }
            set { this.ideiaID = value; }
        }
        private int ideiaID;

        public string IdeiaTitulo
        {
            get { return this.ideiaTitulo; }
            set { this.ideiaTitulo = value; }
        }
        private string ideiaTitulo;

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

        public Guid Aprovador_Aspnet_UserID
        {
            get { return this.aprovador_Aspnet_UserID; }
            set { this.aprovador_Aspnet_UserID = value; }
        }
        private Guid aprovador_Aspnet_UserID;

        public string Mensagem
        {
            get { return this.mensagem; }
            set { this.mensagem = value; }
        }
        private string mensagem;

        public DateTime  Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        private DateTime  data;

        public bool  Aprovado
        {
            get { return this.aprovado; }
            set { this.aprovado = value; }
        }
        private bool aprovado;

        public DateTime DataAprovacao
        {
            get { return this.dataAprovacao; }
            set { this.dataAprovacao = value; }
        }
        private DateTime dataAprovacao;
    }
}
