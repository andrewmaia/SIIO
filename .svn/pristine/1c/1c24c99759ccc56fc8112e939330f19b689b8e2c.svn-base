-- =============================================
-- Script Template para Inclusão de Dados
-- =============================================

USE SIIO

-- INSERINDO USUARIO
PRINT '- INSERINDO USUARIOS'
INSERT INTO TAB_USUARIO (PrimeiroNome,SobreNome,Senha,Email,idStatusUsuario,idNivelUsuario,Empresa,idCargo,DataCadastro)
 VALUES('ANGEL','CAVINA',PWDENCRYPT('123'),'angel.cavina@gmail.com',1,1,'Fujitsu',1,GETDATE())

-- INSERINDO O TIPO DE CATEGORIA
PRINT '- INSERINDO CATEGORIAS'
INSERT INTO TAB_CATEGORIA (Descricao,DataCadastro) VALUES ('Finanças',GETDATE())
INSERT INTO TAB_CATEGORIA (Descricao,DataCadastro) VALUES ('Economia',GETDATE())
INSERT INTO TAB_CATEGORIA (Descricao,DataCadastro) VALUES ('Direito',GETDATE())
INSERT INTO TAB_CATEGORIA (Descricao,DataCadastro) VALUES ('Artes',GETDATE())
INSERT INTO TAB_CATEGORIA (Descricao,DataCadastro) VALUES ('Esporte',GETDATE())
INSERT INTO TAB_CATEGORIA (Descricao,DataCadastro) VALUES ('Internet',GETDATE())
INSERT INTO TAB_CATEGORIA (Descricao,DataCadastro) VALUES ('Outros',GETDATE())

-- INSERINDO A IDEIA
PRINT '- INSERINDO IDEIAS'
INSERT INTO TAB_IDEIA (idCategoria,idUsuario,Titulo,PreDescricao,Descricao,flg_Restrito,DataCadastro) 
VALUES(1,1,'CARRO INTELIGENTE','ESTE CARRO TEM VARIAS FUNCIONALIDADES...','SERIA FEITO COM MATERIAL ULTRA-RESISTENTE E CAPTURA DE LUZ-SOLAR...',1,GETDATE())
INSERT INTO TAB_IDEIA (idCategoria,idUsuario,Titulo,PreDescricao,Descricao,flg_Restrito,DataCadastro) 
VALUES(2,1,'PANO RESISTENTE','ESTE TIPO DE PANO TEM VARIAS FUNCIONALIDADES...','SERIA FEITO COM MATERIAL ULTRA-RESISTENTE E CAPTURA DE LUZ-SOLAR...',1,GETDATE())
INSERT INTO TAB_IDEIA (idCategoria,idUsuario,Titulo,PreDescricao,Descricao,flg_Restrito,DataCadastro) 
VALUES(4,1,'TABUA RESISTENTE','ESTE TIPO DE TABUA TEM VARIAS FUNCIONALIDADES...','SERIA FEITO COM MATERIAL ULTRA-RESISTENTE E CAPTURA DE LUZ-SOLAR...',1,GETDATE())
INSERT INTO TAB_IDEIA (idCategoria,idUsuario,Titulo,PreDescricao,Descricao,flg_Restrito,DataCadastro) 
VALUES(3,1,'TITULO 4','PREDESCRICAO 4','DESCRICAO 4',1,GETDATE())
INSERT INTO TAB_IDEIA (idCategoria,idUsuario,Titulo,PreDescricao,Descricao,flg_Restrito,DataCadastro) 
VALUES(1,1,'TITULO 5','PREDESCRICAO 5','DESCRICAO 5',1,GETDATE())
INSERT INTO TAB_IDEIA (idCategoria,idUsuario,Titulo,PreDescricao,Descricao,flg_Restrito,DataCadastro)	
VALUES(5,1,'TITULO 6','PREDESCRICAO 6','DESCRICAO 6',1,GETDATE())
INSERT INTO TAB_IDEIA (idCategoria,idUsuario,Titulo,PreDescricao,Descricao,flg_Restrito,DataCadastro) 
VALUES(5,1,'TITULO 7','PREDESCRICAO 7','DESCRICAO 7',1,GETDATE())
INSERT INTO TAB_IDEIA (idCategoria,idUsuario,Titulo,PreDescricao,Descricao,flg_Restrito,DataCadastro) 
VALUES(2,1,'TITULO 8','PREDESCRICAO 8','DESCRICAO 8',1,GETDATE())

--INSERINDO QUANTIDADE VISUALICACOES
PRINT '- INSERINDO QUANTIDADE VISUALIZACOES'
INSERT INTO Tab_visualizacoes (idIdeia,Visualizacoes) VALUES(1,5)
INSERT INTO Tab_visualizacoes (idIdeia,Visualizacoes) VALUES(2,20)
INSERT INTO Tab_visualizacoes (idIdeia,Visualizacoes) VALUES(3,15)
INSERT INTO Tab_visualizacoes (idIdeia,Visualizacoes) VALUES(4,7)
INSERT INTO Tab_visualizacoes (idIdeia,Visualizacoes) VALUES(5,12)