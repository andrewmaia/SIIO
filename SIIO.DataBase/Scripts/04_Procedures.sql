-- =============================================
-- Script Template para criar as Procedures
-- =============================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[P_ValidarUsuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[P_ValidarUsuario] 
(
	@Email	VARCHAR(50),
	@Senha	VARCHAR(10)
)
AS
BEGIN
	SELECT PrimeiroNome,SobreNome,idNivelUsuario,idStatusUsuario,Empresa
	 FROM TAB_USUARIO 
	WHERE Email = @Email
	AND PWDCOMPARE(@Senha,Senha) = 1
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[P_Ideias]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[P_Ideias] 
(
	@Opcao		TINYINT,
	@Quantidade	TINYINT
)
AS
BEGIN
--=================================
-- @Opcao:
-- 1 - Retorna ideias Recentes
-- 2 - Retorna ideias mais vistas
--=================================
	SET ROWCOUNT @Quantidade

	IF @Opcao = 1
	BEGIN
		SET ROWCOUNT @Quantidade  
		SELECT ''<b><a href="Usuario/DetalhesIdeia.aspx">''
		+ TITULO + ''</a></b><br><br>'' + PREDESCRICAO + 
		''<br>Postado Em:'' + CONVERT(VARCHAR(10),DATACADASTRO,103) AS [Postagens mais recentes]  
		FROM TAB_IDEIA ORDER BY DATACADASTRO  
	END
	ELSE IF @Opcao = 2
	BEGIN
		SELECT ''<b><asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#003399" 
                            NavigateUrl="~/Usuario/DetalhesIdeia.aspx">HyperLink</asp:HyperLink></b>'' as teste,''<b><asp:HyperLink ID="HyperLink''+ CAST(TI.idIdeia AS VARCHAR(4)) + ''" runat="server" ForeColor="#003399" NavigateUrl="~/Usuario/DetalhesIdeia.aspx">'' 
		 + TI.TITULO + ''</asp:HyperLink></b><br><br>'' + TI.PREDESCRICAO +
				''<br>Postado Em:'' + CONVERT(VARCHAR(10),DATACADASTRO,103) AS [Mais Vistos]
		FROM TAB_IDEIA TI 
			JOIN TAB_VISUALIZACOES TV ON TI.idIdeia = TV.idIdeia 
		ORDER BY VISUALIZACOES DESC
	END	

END

' 
END

