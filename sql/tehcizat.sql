USE [master]
GO
/****** Object:  Database [tehcizat]    Script Date: 08.04.2015 16:27:15 ******/
CREATE DATABASE [tehcizat]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tehcizat', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\tehcizat.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'tehcizat_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\tehcizat_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [tehcizat] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tehcizat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tehcizat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tehcizat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tehcizat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tehcizat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tehcizat] SET ARITHABORT OFF 
GO
ALTER DATABASE [tehcizat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tehcizat] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [tehcizat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tehcizat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tehcizat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tehcizat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tehcizat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tehcizat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tehcizat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tehcizat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tehcizat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [tehcizat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tehcizat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tehcizat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tehcizat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tehcizat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tehcizat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tehcizat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tehcizat] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [tehcizat] SET  MULTI_USER 
GO
ALTER DATABASE [tehcizat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tehcizat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tehcizat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tehcizat] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [tehcizat]
GO
/****** Object:  Table [dbo].[company]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[company](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_company] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[currency]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[currency](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_currency] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[history]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[history](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[source_id] [int] NULL,
	[type_id] [int] NULL,
	[company_suplier_id] [int] NULL,
	[company_orderer_id] [int] NULL,
	[product_id] [int] NULL,
	[price] [float] NULL,
	[currency_id] [int] NULL,
	[amount] [float] NULL,
	[unit_id] [int] NULL,
	[orderer_id] [int] NULL,
	[date] [text] NULL,
 CONSTRAINT [PK_history] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[item_prices]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_prices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[price] [float] NULL,
	[currency_id] [int] NULL,
	[company_id] [int] NULL,
	[date] [text] NULL,
 CONSTRAINT [PK_item_prices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[orderer]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[company_id] [int] NOT NULL,
 CONSTRAINT [PK_orderer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[price_list]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[price_list](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[request_id] [int] NULL,
	[new_or_old] [nvarchar](50) NULL,
	[company_id] [int] NULL,
	[price] [int] NULL,
	[currency_id] [int] NULL,
 CONSTRAINT [PK_price_list] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[request]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[request](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[amount] [float] NULL,
	[product_id] [int] NULL,
	[unit_id] [int] NULL,
	[source_id] [int] NULL,
	[type_id] [int] NULL,
	[location] [nvarchar](50) NULL,
	[company_id] [int] NULL,
	[status] [int] NULL,
	[orderer_id] [int] NOT NULL,
	[user_id] [int] NULL,
 CONSTRAINT [PK_request] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[source]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[source](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_source] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[type]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[unit]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_unit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user]    Script Date: 08.04.2015 16:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[role] [int] NOT NULL,
	[count] [int] NOT NULL,
	[phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[company] ON 

INSERT [dbo].[company] ([id], [name], [address]) VALUES (1, N'Azercell', N'Tbilisi pr 71A, Azercell Plaza')
INSERT [dbo].[company] ([id], [name], [address]) VALUES (2, N'QüdrətSoft LLC', N'Heydər Əliyev pr 76')
INSERT [dbo].[company] ([id], [name], [address]) VALUES (3, N'BakuParking', N'Nizami küç 32, AF Business House')
SET IDENTITY_INSERT [dbo].[company] OFF
SET IDENTITY_INSERT [dbo].[orderer] ON 

INSERT [dbo].[orderer] ([id], [name], [surname], [company_id]) VALUES (1, N'Qüdrət', N'Həsənli', 3)
INSERT [dbo].[orderer] ([id], [name], [surname], [company_id]) VALUES (2, N'Hikmət', N'Qurbanlı', 1)
SET IDENTITY_INSERT [dbo].[orderer] OFF
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([id], [name]) VALUES (1, N'Qələm')
INSERT [dbo].[product] ([id], [name]) VALUES (2, N'Coca Cola Lite')
INSERT [dbo].[product] ([id], [name]) VALUES (3, N'Çörək')
INSERT [dbo].[product] ([id], [name]) VALUES (4, N'Eynək')
SET IDENTITY_INSERT [dbo].[product] OFF
SET IDENTITY_INSERT [dbo].[request] ON 

INSERT [dbo].[request] ([id], [name], [amount], [product_id], [unit_id], [source_id], [type_id], [location], [company_id], [status], [orderer_id], [user_id]) VALUES (1, N'Göy rəngdə şarik tipli nazik mütləq lazımdır', 26, 1, 5, 1, 1, N'd', 1, 3, 1, 3)
INSERT [dbo].[request] ([id], [name], [amount], [product_id], [unit_id], [source_id], [type_id], [location], [company_id], [status], [orderer_id], [user_id]) VALUES (2, N'Coca-Cola', 10, 2, 2, 2, 2, N'x', 1, 3, 2, 3)
SET IDENTITY_INSERT [dbo].[request] OFF
SET IDENTITY_INSERT [dbo].[source] ON 

INSERT [dbo].[source] ([id], [name]) VALUES (1, N'E-poçt')
INSERT [dbo].[source] ([id], [name]) VALUES (2, N'
Excel
')
INSERT [dbo].[source] ([id], [name]) VALUES (3, N'Telefon')
INSERT [dbo].[source] ([id], [name]) VALUES (4, N'
Kağız
')
INSERT [dbo].[source] ([id], [name]) VALUES (5, N'Sosial şəbəkə')
INSERT [dbo].[source] ([id], [name]) VALUES (6, N'
Votçap')
INSERT [dbo].[source] ([id], [name]) VALUES (7, N'
Vapçat')
SET IDENTITY_INSERT [dbo].[source] OFF
SET IDENTITY_INSERT [dbo].[type] ON 

INSERT [dbo].[type] ([id], [name]) VALUES (1, N'Yeyinti')
INSERT [dbo].[type] ([id], [name]) VALUES (2, N'Tikinti')
INSERT [dbo].[type] ([id], [name]) VALUES (3, N'Ofis malları')
INSERT [dbo].[type] ([id], [name]) VALUES (4, N'Məişət')
INSERT [dbo].[type] ([id], [name]) VALUES (5, N'Santexnika')
INSERT [dbo].[type] ([id], [name]) VALUES (6, N'1001 xırdavat')
INSERT [dbo].[type] ([id], [name]) VALUES (7, N'Elektronika')
INSERT [dbo].[type] ([id], [name]) VALUES (8, N'Səhiyyə')
INSERT [dbo].[type] ([id], [name]) VALUES (9, N'Təhsil')
INSERT [dbo].[type] ([id], [name]) VALUES (10, N'İdman')
INSERT [dbo].[type] ([id], [name]) VALUES (11, N'İnternet')
INSERT [dbo].[type] ([id], [name]) VALUES (12, N'Tekstil')
INSERT [dbo].[type] ([id], [name]) VALUES (13, N'Geyim')
SET IDENTITY_INSERT [dbo].[type] OFF
SET IDENTITY_INSERT [dbo].[unit] ON 

INSERT [dbo].[unit] ([id], [name]) VALUES (1, N'kg')
INSERT [dbo].[unit] ([id], [name]) VALUES (2, N'm')
INSERT [dbo].[unit] ([id], [name]) VALUES (3, N'm2')
INSERT [dbo].[unit] ([id], [name]) VALUES (4, N'litr')
INSERT [dbo].[unit] ([id], [name]) VALUES (5, N'ədəd')
SET IDENTITY_INSERT [dbo].[unit] OFF
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [username], [password], [email], [name], [surname], [role], [count], [phone]) VALUES (3, N'gudrat', N'5d319606eee9d1a7775ced6a252f8df997391136082c322bfc733f0b92c8eb0b', N'gudrat94@gmail.com', NULL, NULL, 1, 0, N'0505545453')
INSERT [dbo].[user] ([id], [username], [password], [email], [name], [surname], [role], [count], [phone]) VALUES (6, N'alvinazer', N'fe74cd8bcfb41c374b15bb35ce501bbad5fff6f42c70a8ca2be3392faa466e8c', N'elvin.akhindzadeh@gmail.com', NULL, NULL, 2, 0, N'0517504043')
INSERT [dbo].[user] ([id], [username], [password], [email], [name], [surname], [role], [count], [phone]) VALUES (7, N'fariz', N'1868c8781cff36b98cd3fa4ac5327083b69a64f0adff0728906bb7ac8cd3b49a', N'fhuseynli@yahoo.com', NULL, NULL, 3, 0, N'0517788594')
INSERT [dbo].[user] ([id], [username], [password], [email], [name], [surname], [role], [count], [phone]) VALUES (8, N'huseyn', N'2057d586dfce915bd795941c41b1e1f3bfe40f915cea059ab5f56f82b75bb66a', N'huseyn.garnett@gmail.com', NULL, NULL, 4, 0, N'0505698877')
INSERT [dbo].[user] ([id], [username], [password], [email], [name], [surname], [role], [count], [phone]) VALUES (9, N'memmed', N'e728a8de8970efedbe4eea7c77a7028962ee5e83f15d0239b3780d7926b22d4e', N'memmed.imanli@gmail.com', NULL, NULL, 5, 0, N'0554644293')
SET IDENTITY_INSERT [dbo].[user] OFF
USE [master]
GO
ALTER DATABASE [tehcizat] SET  READ_WRITE 
GO
