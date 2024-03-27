USE [master]
GO
/****** Object:  Database [App]    Script Date: 27/03/2024 02:01:29 p. m. ******/
CREATE DATABASE [App]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'App', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\App.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'App_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\App_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [App] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [App].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [App] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [App] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [App] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [App] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [App] SET ARITHABORT OFF 
GO
ALTER DATABASE [App] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [App] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [App] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [App] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [App] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [App] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [App] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [App] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [App] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [App] SET  DISABLE_BROKER 
GO
ALTER DATABASE [App] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [App] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [App] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [App] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [App] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [App] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [App] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [App] SET RECOVERY FULL 
GO
ALTER DATABASE [App] SET  MULTI_USER 
GO
ALTER DATABASE [App] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [App] SET DB_CHAINING OFF 
GO
ALTER DATABASE [App] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [App] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [App] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [App] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'App', N'ON'
GO
ALTER DATABASE [App] SET QUERY_STORE = ON
GO
ALTER DATABASE [App] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [App]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 27/03/2024 02:01:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[Id] [int] NOT NULL,
	[Razon_Social] [varchar](40) NULL,
	[Direccion] [varchar](49) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operadores]    Script Date: 27/03/2024 02:01:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operadores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL,
	[Edad] [int] NULL,
	[Salario] [int] NULL,
	[Fecha_Nacimiento] [date] NULL,
	[Rowcreated_A] [date] NULL,
	[IdEmpresa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Empresa] ([Id], [Razon_Social], [Direccion]) VALUES (1, N'Arcos Dorados, C.A.', N'Atizapana')
GO
INSERT [dbo].[Empresa] ([Id], [Razon_Social], [Direccion]) VALUES (2, N'The Coca-Cola Company', N'Naucalpan')
GO
SET IDENTITY_INSERT [dbo].[Operadores] ON 
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (15, N'Adrian', 23, 12300, CAST(N'2000-07-12' AS Date), CAST(N'2024-03-19' AS Date), 2)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (16, N'Fabian', 35, 1200, CAST(N'1993-07-12' AS Date), CAST(N'2024-03-19' AS Date), 1)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (17, N'Carlo Alfredo', 19, 12323, CAST(N'2000-07-12' AS Date), CAST(N'2024-03-20' AS Date), 1)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (18, N'Sergio', 33, 12323, CAST(N'1996-07-16' AS Date), CAST(N'2024-03-20' AS Date), 2)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (19, N'Mimi', 14, 2222, CAST(N'2010-07-12' AS Date), CAST(N'2024-03-20' AS Date), 2)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (20, N'Esteban', 44, 4000, CAST(N'2008-07-12' AS Date), CAST(N'2024-03-20' AS Date), 1)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (21, N'Alan', 12, 12300, CAST(N'1990-07-12' AS Date), CAST(N'2024-03-20' AS Date), 2)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (22, N'Fernando', 23, 12000, CAST(N'2000-07-12' AS Date), CAST(N'2024-03-20' AS Date), 1)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (23, N'Sandra', 23, 1222, CAST(N'1997-07-12' AS Date), CAST(N'2024-03-20' AS Date), 2)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (26, N'Alejandr', 12, 12000, CAST(N'1990-07-12' AS Date), CAST(N'2024-03-20' AS Date), 2)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (27, N'Leonardo', 33, 1233, CAST(N'2009-07-12' AS Date), CAST(N'2024-03-20' AS Date), 1)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (28, N'Luis', 50, 1900, CAST(N'1994-07-12' AS Date), CAST(N'2024-03-20' AS Date), 2)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (30, N'Alejandro Salgado', 23, 12300, CAST(N'2000-07-12' AS Date), CAST(N'2024-03-22' AS Date), 2)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (31, N'Coco Alex', 12, 1223, CAST(N'1990-07-12' AS Date), CAST(N'2024-03-22' AS Date), 2)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (32, N'Coco', 12, 1223, CAST(N'1990-07-12' AS Date), CAST(N'2024-03-22' AS Date), 2)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (33, N'Jose', 1244, 122200, CAST(N'1990-07-12' AS Date), CAST(N'2024-03-22' AS Date), 1)
GO
INSERT [dbo].[Operadores] ([Id], [Nombre], [Edad], [Salario], [Fecha_Nacimiento], [Rowcreated_A], [IdEmpresa]) VALUES (2037, N'Capi', 34, 89000, CAST(N'2000-12-07' AS Date), CAST(N'2024-03-27' AS Date), 1)
GO
SET IDENTITY_INSERT [dbo].[Operadores] OFF
GO
ALTER TABLE [dbo].[Operadores] ADD  DEFAULT (getdate()) FOR [Rowcreated_A]
GO
ALTER TABLE [dbo].[Operadores]  WITH CHECK ADD  CONSTRAINT [fk_Id] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([Id])
GO
ALTER TABLE [dbo].[Operadores] CHECK CONSTRAINT [fk_Id]
GO
/****** Object:  StoredProcedure [dbo].[Createoperadores]    Script Date: 27/03/2024 02:01:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Javier Paulino
-- Create date: 2024-03-15
-- Description:	CRETE OPERADOR
-- =============================================

CREATE PROC [dbo].[Createoperadores]
@Nombre varchar(30),
@Edad   int,
@Salario int,
@Fecha_Nacimiento date=null,
@IdEmpresa int
AS

INSERT INTO [dbo].[Operadores]
([Nombre],
[Edad],
[Salario],
[Fecha_Nacimiento],
[IdEmpresa])
VALUES(
@Nombre,
@Edad,
@Salario,
@Fecha_Nacimiento, 
@IdEmpresa
);
GO
/****** Object:  StoredProcedure [dbo].[CrudOperadores]    Script Date: 27/03/2024 02:01:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CrudOperadores]
 @Action varchar(max) = null,
 @Nombre varchar(max) = null,
 @Id int,
 @Edad int,
 @Salario int,
 @Fecha_Nacimiento date,
 @IdEmpresa int

 AS
BEGIN
 IF @Action = 'Insert'
  BEGIN
   INSERT INTO [dbo].[Operadores]
   ( [Nombre],
     [Edad],
     [Salario],
     [Fecha_Nacimiento],
     [IdEmpresa])
   VALUES
     (@Nombre,
	  @Edad,
	  @Salario,
	  @Fecha_Nacimiento,
	  @IdEmpresa);
 END
 ELSE IF @Action ='Select'
  BEGIN
  SELECT
       [Nombre]
      ,[Edad]
      ,[Salario]
      ,[Fecha_Nacimiento]
      ,[IdEmpresa]
  FROM [App].[dbo].[Operadores] Opera
  JOIN [dbo].[Empresa] Empresa On Empresa.Id = Opera.IdEmpresa 
 END
 ELSE IF @Action ='Update'
  BEGIN
  UPDATE [dbo].[Operadores]
   SET [Nombre] = @Nombre
      ,[Edad] = @Edad
      ,[Salario] = @Salario
      ,[Fecha_Nacimiento] = @Fecha_Nacimiento
      ,[IdEmpresa] = @IdEmpresa
 END
  ELSE IF @Action ='Delete'
  BEGIN
  DELETE FROM [dbo].[Operadores]
      WHERE [Id]=@Id
 END
 END
GO
/****** Object:  StoredProcedure [dbo].[DeleteOperador]    Script Date: 27/03/2024 02:01:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteOperador]
@Id int 

AS

DELETE FROM [dbo].[Operadores]
      WHERE [Id]= @Id
GO
/****** Object:  StoredProcedure [dbo].[EditOperador]    Script Date: 27/03/2024 02:01:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EditOperador]
@Id int=0,
@Nombre varchar(30) = null,
@Edad Int,
@Salario Int,
@Fecha_Nacimiento date=null,
@IdEmpresa  int

AS

UPDATE [dbo].[Operadores]
   SET [Nombre] = @Nombre
      ,[Edad] = @Edad
      ,[Salario] = @Salario
      ,[Fecha_Nacimiento] = @Fecha_Nacimiento
      ,[IdEmpresa] = @IdEmpresa
 WHERE [Id] = @Id;
GO
/****** Object:  StoredProcedure [dbo].[GetEmpresa]    Script Date: 27/03/2024 02:01:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[GetEmpresa]
AS


      SELECT [Id]
      ,[Razon_Social]
      ,[Direccion]
  FROM [dbo].[Empresa]
GO
/****** Object:  StoredProcedure [dbo].[GetOperador]    Script Date: 27/03/2024 02:01:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC[dbo].[GetOperador]
@Id int = null

AS
SELECT [Id]
      ,[Nombre]
      ,[Edad]
      ,[Salario]
      ,[Fecha_Nacimiento]
      ,[Rowcreated_A]
      ,[IdEmpresa]
  FROM [dbo].[Operadores]
  Where [Id]=@Id
GO
/****** Object:  StoredProcedure [dbo].[SelectOperador]    Script Date: 27/03/2024 02:01:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectOperador]
AS

SELECT
		opera.Id
       ,[Nombre]
      ,[Edad]
      ,[Salario]
      ,[Fecha_Nacimiento]
      ,[IdEmpresa]
      ,[Razon_Social]
      ,[Direccion]
  FROM [App].[dbo].[Operadores] Opera
  JOIN [dbo].[Empresa] Empresa On Empresa.Id = Opera.IdEmpresa

GO
/****** Object:  StoredProcedure [dbo].[SelectOperadores]    Script Date: 27/03/2024 02:01:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SelectOperadores]
@Id int,
@Nombre varchar(30),
@Edad Int,
@Salario Int,
@Fecha_Nacimiento date,
@IdEmpresa  int

AS

SELECT
CONVERT(varchar, Opera.Fecha_Nacimiento, 23) as FechaNacimientoVarchar,
       [Nombre]
      ,[Edad]
      ,[Salario]
      ,[Fecha_Nacimiento]
      ,[IdEmpresa]
      ,[Razon_Social]
      ,[Direccion]
  FROM [App].[dbo].[Operadores] Opera
  JOIN [dbo].[Empresa] Empresa On Empresa.Id = Opera.IdEmpresa
where
	1 = 1
GO
USE [master]
GO
ALTER DATABASE [App] SET  READ_WRITE 
GO
