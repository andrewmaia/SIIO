-- =============================================
-- Script Template para Criação do Database
-- =============================================
CREATE DATABASE SIIO
ON
(
	name		=	'SIIO' ,
	filename	=	'E:\Bancos_SQL\SIIO.mdf' ,
	size		=	10MB,
	filegrowth	=	10MB
)
LOG ON 
(
	name		=	'SIIO_LOG' ,
	filename	=	'E:\Bancos_SQL\SIIO.ldf' ,
	size		=	1MB,
	filegrowth	=	1MB
)