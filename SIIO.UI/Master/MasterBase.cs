using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Master
{
    public class MasterBase : Atomo.Web.MasterPage
    {
        public override void RegisterLinks()
        {
            //CSS
            this.CssContainer.CssLinkedInfo.Add("site", new CssInfo("/Common/Css/Site_20131102.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("formulario", new Atomo.Web.CssInfo("/Common/Css/formulario_20131102.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("tabela", new Atomo.Web.CssInfo("/Common/Css/tabela_20131102.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("botao", new Atomo.Web.CssInfo("/Common/Css/botao_20131102.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("validator", new Atomo.Web.CssInfo("/Common/Css/Validator_20131102.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("principalMaster", new CssInfo("/Master/PrincipalMaster/Css/PrincipalMaster_20131102.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("logoMaster", new Atomo.Web.CssInfo("/Master/LogoMaster/Css/LogoMaster_20131102.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("default", new CssInfo("/Default/Css/Default_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ideiaSolicitarAcesso", new CssInfo("/Ideia/IdeiaSolicitarAcesso/css/IdeiaSolicitarAcesso_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ideiaAcessoGerenciar", new CssInfo("/Ideia/IdeiaAcessoGerenciar/css/IdeiaAcessoGerenciar_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ideiaResultadoBusca", new CssInfo("/Ideia/IdeiaResultadoBusca/css/IdeiaResultadoBusca_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ideiaCadastro", new CssInfo("/Ideia/IdeiaCadastro/css/IdeiaCadastro_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ideiaEditar", new CssInfo("/Ideia/IdeiaEditar/css/IdeiaEditar_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ideiaMinhas", new CssInfo("/Ideia/IdeiaMinhas/css/IdeiaMinhas_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ideiaInteresse", new CssInfo("/Ideia/IdeiaInteresse/css/IdeiaInteresse_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ideiaVisualizacao", new CssInfo("/Ideia/IdeiaVisualizacao/css/IdeiaVisualizacao_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ucGridVazio", new CssInfo("/Common/Controles/UcGridVazio/Css/UcGridVazio_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ucAprovar", new CssInfo("/Common/Controles/UcAprovar/Css/UcAprovar_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("usuarioEditar", new Atomo.Web.CssInfo("/Usuario/UsuarioEditar/Css/UsuarioEditar_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ideiaAcessoAprovar", new Atomo.Web.CssInfo("/Ideia/IdeiaAcessoAprovar/Css/IdeiaAcessoAprovar_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("usuarioAlterarSenha", new Atomo.Web.CssInfo("/Usuario/usuarioAlterarSenha/Css/usuarioAlterarSenha_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("usuarioMaster", new Atomo.Web.CssInfo("/Master/UsuarioMaster/Css/UsuarioMaster_20131102.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("usuarioCadastro", new Atomo.Web.CssInfo("/Usuario/UsuarioCadastro/Css/UsuarioCadastro_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("login", new Atomo.Web.CssInfo("/Usuario/UsuarioLogin/Css/UsuarioLogin_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("ocorreuErro", new Atomo.Web.CssInfo("/Erro/OcorreuErro/Css/OcorreuErro_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("badRequest", new Atomo.Web.CssInfo("/Erro/BadRequest/Css/BadRequest_20131103.css", "all"));
            this.CssContainer.CssLinkedInfo.Add("logoMasterSemLogin", new Atomo.Web.CssInfo("/Master/LogoMaster/Css/LogoMasterSemLogin_20131102.css", "all"));
        }
    }
}