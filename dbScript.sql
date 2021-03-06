USE [master]
GO
/****** Object:  Database [Spargo.Maksim.Kulebyakin.Test.Task]    Script Date: 16.06.2022 18:32:24 ******/
CREATE DATABASE [Spargo.Maksim.Kulebyakin.Test.Task]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Spargo.Maksim.Kulebyakin.Test.Task', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Spargo.Maksim.Kulebyakin.Test.Task.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Spargo.Maksim.Kulebyakin.Test.Task_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Spargo.Maksim.Kulebyakin.Test.Task_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Spargo.Maksim.Kulebyakin.Test.Task].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET ARITHABORT OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET RECOVERY FULL 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET  MULTI_USER 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Spargo.Maksim.Kulebyakin.Test.Task', N'ON'
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET QUERY_STORE = OFF
GO
USE [Spargo.Maksim.Kulebyakin.Test.Task]
GO
/****** Object:  Table [dbo].[Consignments]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consignments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[StorageId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Сonsignments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pharmacys]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pharmacys](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Pharmacys] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Storages]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PharmacyId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Storages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Consignments]  WITH CHECK ADD  CONSTRAINT [FK_Сonsignments_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Consignments] CHECK CONSTRAINT [FK_Сonsignments_Products]
GO
ALTER TABLE [dbo].[Consignments]  WITH CHECK ADD  CONSTRAINT [FK_Сonsignments_Storages] FOREIGN KEY([StorageId])
REFERENCES [dbo].[Storages] ([Id])
GO
ALTER TABLE [dbo].[Consignments] CHECK CONSTRAINT [FK_Сonsignments_Storages]
GO
ALTER TABLE [dbo].[Storages]  WITH CHECK ADD  CONSTRAINT [FK_Storages_Pharmacys] FOREIGN KEY([PharmacyId])
REFERENCES [dbo].[Pharmacys] ([Id])
GO
ALTER TABLE [dbo].[Storages] CHECK CONSTRAINT [FK_Storages_Pharmacys]
GO
/****** Object:  StoredProcedure [dbo].[AddConsignment]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddConsignment] 
	@ProductId int,
	@StorageId int,
	@Quantity int
AS
BEGIN
	INSERT INTO [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Consignments (ProductId, StorageId, Quantity)
	VALUES (@ProductId, @StorageId, @Quantity)
END
GO
/****** Object:  StoredProcedure [dbo].[AddPharmacy]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddPharmacy] 
	@Name nvarchar(50),
	@Address nvarchar(200),
	@Phone nvarchar(50)
AS
BEGIN
	INSERT INTO [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Pharmacys ("Name", "Address", "Phone")
	VALUES (@Name, @Address, @Phone)
END
GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddProduct]
	@Name nvarchar(50)
AS
BEGIN
	INSERT INTO [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Products ("Name")
	VALUES (@Name)
END
GO
/****** Object:  StoredProcedure [dbo].[AddStorage]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddStorage]
	@Id int = NULL OUTPUT,
	@PharmacyId int,
	@Name nvarchar(50)
AS
BEGIN
	INSERT INTO [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Storages (PharmacyId, "Name")
	VALUES (@PharmacyId, @Name)

	SET @Id = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteConsignment]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteConsignment]
	@Id int
AS
BEGIN
	DELETE FROM [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Сonsignments 
	WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePharmacy]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePharmacy] 
	@Id int
AS
BEGIN
	DECLARE @StorageId int = (SELECT [Id]
							  FROM [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Storages
							  WHERE [PharmacyId] = @Id)

	DELETE FROM [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Consignments
	WHERE [StorageId] = @StorageId

	DELETE FROM [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Storages
	WHERE [PharmacyId] = @Id

	DELETE FROM [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Pharmacys
	WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteProduct] 
	@Id int
AS
BEGIN
	DELETE FROM [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Consignments 
	WHERE [ProductId] = @Id

	DELETE FROM [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Products
	WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteStorage]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteStorage] 
	@Id int
AS
BEGIN
	DELETE FROM [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Consignments 
	WHERE [StorageId] = @Id

	DELETE FROM [Spargo.Maksim.Kulebyakin.Test.Task].dbo.Storages
	WHERE [Id] = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetProductQuantityFromPharmacyByPharmacyId]    Script Date: 16.06.2022 18:32:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProductQuantityFromPharmacyByPharmacyId]
	@PharmacyId int
AS
BEGIN
	SELECT prod.[Name], SUM(cons.Quantity) Quantity
	FROM dbo.Pharmacys pharm
	INNER JOIN dbo.Storages stor on pharm.Id = stor.PharmacyId
	INNER JOIN dbo.Consignments cons on stor.Id = cons.StorageId
	INNER JOIN dbo.Products prod on cons.ProductId = prod.Id
	WHERE pharm.Id = @PharmacyId
	GROUP BY prod.[Name] 
END
GO
USE [master]
GO
ALTER DATABASE [Spargo.Maksim.Kulebyakin.Test.Task] SET  READ_WRITE 
GO
