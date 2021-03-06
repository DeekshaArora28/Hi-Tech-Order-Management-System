USE [master]
GO
/****** Object:  Database [HiTechDB]    Script Date: 2020-12-15 5:55:56 PM ******/
CREATE DATABASE [HiTechDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HiTechDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\HiTechDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HiTechDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\HiTechDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HiTechDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HiTechDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HiTechDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HiTechDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HiTechDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HiTechDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HiTechDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HiTechDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HiTechDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HiTechDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HiTechDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HiTechDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HiTechDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HiTechDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HiTechDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HiTechDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HiTechDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HiTechDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HiTechDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HiTechDB] SET  MULTI_USER 
GO
ALTER DATABASE [HiTechDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HiTechDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HiTechDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HiTechDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HiTechDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HiTechDB] SET QUERY_STORE = OFF
GO
USE [HiTechDB]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 2020-12-15 5:55:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[AuthorId] [int] NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorBooks]    Script Date: 2020-12-15 5:55:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorBooks](
	[AuthorId] [int] NOT NULL,
	[ISBN] [nvarchar](max) NOT NULL,
	[YearPublished] [nvarchar](max) NOT NULL,
	[Edition] [nchar](10) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2020-12-15 5:55:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [int] IDENTITY(1111,1) NOT NULL,
	[BookTitle] [nchar](10) NOT NULL,
	[QOH] [int] NOT NULL,
	[UnitPrice] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[PublisherId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2020-12-15 5:55:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] NOT NULL,
	[CategoryName] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2020-12-15 5:55:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[StreetName] [nchar](50) NOT NULL,
	[Province] [nchar](50) NOT NULL,
	[City] [nchar](50) NOT NULL,
	[PostalCode] [nchar](50) NOT NULL,
	[ContactName] [nchar](50) NOT NULL,
	[ContactEmail] [nchar](50) NOT NULL,
	[CreditLimit] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2020-12-15 5:55:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] NOT NULL,
	[FirstName] [nchar](10) NOT NULL,
	[LastName] [nchar](10) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[JobId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 2020-12-15 5:55:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jobs](
	[JobId] [int] NOT NULL,
	[Jobtitle] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 2020-12-15 5:55:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[UserName] [nchar](10) NOT NULL,
	[Password] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderLines]    Script Date: 2020-12-15 5:55:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLines](
	[OrderId] [int] NOT NULL,
	[ISBN] [int] NOT NULL,
	[QuantityOrdered] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2020-12-15 5:55:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] NOT NULL,
	[OrderDate] [nchar](50) NOT NULL,
	[OrderType] [nchar](50) NOT NULL,
	[RequiredDate] [nchar](50) NOT NULL,
	[ShippingDate] [nchar](50) NOT NULL,
	[OrderStatus] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 2020-12-15 5:55:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccount](
	[UserName] [nchar](10) NULL,
	[Password] [nchar](10) NULL,
	[EmployeeId] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([ISBN], [BookTitle], [QOH], [UnitPrice], [CategoryId], [PublisherId]) VALUES (1111, N'PaniPat   ', 2, 23, 12, 21)
INSERT [dbo].[Books] ([ISBN], [BookTitle], [QOH], [UnitPrice], [CategoryId], [PublisherId]) VALUES (1212, N'Ishwae    ', 1221, 1212, 1212, 1212)
INSERT [dbo].[Books] ([ISBN], [BookTitle], [QOH], [UnitPrice], [CategoryId], [PublisherId]) VALUES (1213, N'jiming    ', 22, 2000, 2345, 2345)
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [StreetName], [Province], [City], [PostalCode], [ContactName], [ContactEmail], [CreditLimit]) VALUES (1111, N'Puran', N'Lincoln                                           ', N'Quebec                                            ', N'Montreal                                          ', N'H3H1H9                                            ', N'Ishu                                              ', N'Ishu@123                                          ', N'null                                              ')
GO
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [JobId]) VALUES (0, N'Puneet    ', N'Kaur      ', 222222, 1122)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [JobId]) VALUES (1111, N'Ishwarjot ', N'Singh     ', 2212121, 1212)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [JobId]) VALUES (1212, N'Ishwarjot ', N'Singh     ', 123456789, 1234)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [JobId]) VALUES (1234, N'Ishwae    ', N'Singh     ', 12333333, 1111)
GO
INSERT [dbo].[login] ([UserName], [Password]) VALUES (N'Ishwarjot ', N'singh     ')
GO
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [OrderType], [RequiredDate], [ShippingDate], [OrderStatus]) VALUES (1212, N'24/9/2020                                         ', N'Light                                             ', N'22/6/2020                                         ', N'12/6/2018                                         ', N'Delivering                                        ')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [OrderType], [RequiredDate], [ShippingDate], [OrderStatus]) VALUES (1234, N'23/nov/2020                                       ', N'Light                                             ', N'25/nov/2020                                       ', N'27/nov/2020                                       ', N'Pending                                           ')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [OrderType], [RequiredDate], [ShippingDate], [OrderStatus]) VALUES (2222, N'20/10/2020                                        ', N'ni                                                ', N'20/10/2020                                        ', N'20/10/2020                                        ', N'nu                                                ')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [OrderType], [RequiredDate], [ShippingDate], [OrderStatus]) VALUES (5555, N'30/6/2020                                         ', N'heavy                                             ', N'25/10/2020                                        ', N'28/10/2020                                        ', N'shipped                                           ')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [OrderType], [RequiredDate], [ShippingDate], [OrderStatus]) VALUES (6666, N'20/6/2020                                         ', N'light                                             ', N'22/10/2020                                        ', N'21/10/2020                                        ', N'packed                                            ')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [OrderType], [RequiredDate], [ShippingDate], [OrderStatus]) VALUES (7777, N'12/5/2020                                         ', N'medium                                            ', N'25/6/2020                                         ', N'26/6/2020                                         ', N'delivired                        delivered        ')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [OrderType], [RequiredDate], [ShippingDate], [OrderStatus]) VALUES (8888, N'23/1/2020                                         ', N'light                                             ', N'25/6/2020                                         ', N'27/6/2020                                         ', N'                              delivered           ')
GO
INSERT [dbo].[UserAccount] ([UserName], [Password], [EmployeeId]) VALUES (N'Ishwa     ', N'paoa      ', 1111)
INSERT [dbo].[UserAccount] ([UserName], [Password], [EmployeeId]) VALUES (N'Ishawww   ', N'ususu     ', 1111)
INSERT [dbo].[UserAccount] ([UserName], [Password], [EmployeeId]) VALUES (N'shsh      ', N'shsh      ', 2222)
GO
USE [master]
GO
ALTER DATABASE [HiTechDB] SET  READ_WRITE 
GO
