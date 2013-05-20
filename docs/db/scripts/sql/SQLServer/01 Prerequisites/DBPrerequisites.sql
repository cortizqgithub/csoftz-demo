/*----------------------------------------------------------------------------*/
/* File:           DBPREREQUISITES.SQL                                        */
/* Description:    Rules, user defined types, etc.                            */
/* Author:         Carlos Adolfo Ortiz Quirós (COQ)                           */
/* Date:           Dec.01/2010                                                */
/* Last Modified:  Dec.01/2010                                                */
/* Version:        1.1                                                        */
/* Copyright (c), 2010 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
 History
 Dec.01/2010 COQ  File created.
------------------------------------------------------------------------------*/
USE [master]
GO

CREATE DATABASE [Demo] ON  PRIMARY 
( NAME = N'Demo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Demo.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Demo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Demo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Demo] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Demo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Demo] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Demo] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Demo] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Demo] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Demo] SET ARITHABORT OFF 
GO

ALTER DATABASE [Demo] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Demo] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [Demo] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Demo] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Demo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Demo] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Demo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Demo] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Demo] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Demo] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Demo] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Demo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Demo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Demo] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Demo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Demo] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Demo] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Demo] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Demo] SET  READ_WRITE 
GO

ALTER DATABASE [Demo] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Demo] SET  MULTI_USER 
GO

ALTER DATABASE [Demo] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Demo] SET DB_CHAINING OFF 
GO



/* END DBPREREQUISITES.SQL */