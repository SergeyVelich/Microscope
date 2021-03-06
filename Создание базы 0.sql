USE [master]
GO

/****** Object:  Database [SaveImage]    Script Date: 06.07.2018 9:21:55 ******/
CREATE DATABASE [SaveImage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SaveImage.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SaveImage.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [SaveImage] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SaveImage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [SaveImage] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [SaveImage] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [SaveImage] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [SaveImage] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [SaveImage] SET ARITHABORT OFF 
GO

ALTER DATABASE [SaveImage] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [SaveImage] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [SaveImage] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [SaveImage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [SaveImage] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [SaveImage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [SaveImage] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [SaveImage] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [SaveImage] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [SaveImage] SET  ENABLE_BROKER 
GO

ALTER DATABASE [SaveImage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [SaveImage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [SaveImage] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [SaveImage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [SaveImage] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [SaveImage] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [SaveImage] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [SaveImage] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [SaveImage] SET  MULTI_USER 
GO

ALTER DATABASE [SaveImage] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [SaveImage] SET DB_CHAINING OFF 
GO

ALTER DATABASE [SaveImage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [SaveImage] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [SaveImage] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [SaveImage] SET  READ_WRITE 
GO


