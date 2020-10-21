-- =============================================
-- Script Template para criação das Tabelas
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tab_Usuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tab_Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[PrimeiroNome] [varchar](20) NOT NULL,
	[SobreNome] [varchar](50) NOT NULL,
	[Senha] [varbinary](128) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[idStatusUsuario] [tinyint] NOT NULL DEFAULT ((1)),
	[idNivelUsuario] [tinyint] NOT NULL DEFAULT ((1)),
	[Empresa] [varchar](100) NOT NULL,
	[idCargo] [tinyint] NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK_IdUsuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_IdUsuario] UNIQUE NONCLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tab_Ideia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tab_Ideia](
	[idIdeia] [int] IDENTITY(1,1) NOT NULL,
	[idCategoria] [tinyint] NOT NULL,
	[idUsuario] [int] NULL,
	[Titulo] [varchar](50) NOT NULL,
	[PreDescricao] [varchar](300) NULL,
	[Descricao] [varchar](300) NULL,
	[flg_Restrito] [tinyint] NULL,
	[DataCadastro] [datetime] NULL,
 CONSTRAINT [PK_Tab_Ideia] PRIMARY KEY CLUSTERED 
(
	[idIdeia] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tab_Categoria]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tab_Categoria](
	[idCategoria] [tinyint] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[DataCadastro] [datetime] NULL,
 CONSTRAINT [PK_Tab_Categoria] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tab_Visualizacoes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tab_Visualizacoes](
	[idIdeia] [int] NOT NULL,
	[Visualizacoes] [int] NOT NULL
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tab_Visualizacoes_Tab_Ideia]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tab_Visualizacoes]'))
ALTER TABLE [dbo].[Tab_Visualizacoes]  WITH CHECK ADD  CONSTRAINT [FK_Tab_Visualizacoes_Tab_Ideia] FOREIGN KEY([idIdeia])
REFERENCES [dbo].[Tab_Ideia] ([idIdeia])
GO
ALTER TABLE [dbo].[Tab_Visualizacoes] CHECK CONSTRAINT [FK_Tab_Visualizacoes_Tab_Ideia]


