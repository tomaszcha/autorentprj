USE [master]
GO
/****** Object:  Database [autorent.llc]    Script Date: 03/26/2012 18:26:02 ******/
CREATE DATABASE [autorent.llc] ON  PRIMARY 
( NAME = N'autorent.llc', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\autorent.llc.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'autorent.llc_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\autorent.llc_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [autorent.llc] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [autorent.llc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [autorent.llc] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [autorent.llc] SET ANSI_NULLS OFF
GO
ALTER DATABASE [autorent.llc] SET ANSI_PADDING OFF
GO
ALTER DATABASE [autorent.llc] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [autorent.llc] SET ARITHABORT OFF
GO
ALTER DATABASE [autorent.llc] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [autorent.llc] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [autorent.llc] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [autorent.llc] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [autorent.llc] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [autorent.llc] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [autorent.llc] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [autorent.llc] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [autorent.llc] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [autorent.llc] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [autorent.llc] SET  DISABLE_BROKER
GO
ALTER DATABASE [autorent.llc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [autorent.llc] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [autorent.llc] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [autorent.llc] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [autorent.llc] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [autorent.llc] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [autorent.llc] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [autorent.llc] SET  READ_WRITE
GO
ALTER DATABASE [autorent.llc] SET RECOVERY SIMPLE
GO
ALTER DATABASE [autorent.llc] SET  MULTI_USER
GO
ALTER DATABASE [autorent.llc] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [autorent.llc] SET DB_CHAINING OFF
GO
USE [autorent.llc]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermissionRule]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissionRule](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[ObjectType] [nvarchar](50) NOT NULL,
	[ObjectSubType] [nvarchar](50) NULL,
 CONSTRAINT [PK_PrermissionRule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Auto]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auto](
	[Number] [nvarchar](10) NOT NULL,
	[ModelName] [nvarchar](75) NOT NULL,
	[BodyType] [int] NOT NULL,
	[InsuaranceNumber] [nvarchar](24) NOT NULL,
	[Class] [smallint] NOT NULL,
	[Year] [smallint] NOT NULL,
	[Mileage] [int] NOT NULL,
	[Engine] [int] NOT NULL,
	[ColorGroup] [nvarchar](50) NOT NULL,
	[DayRate] [money] NULL,
	[KmRate] [money] NULL,
	[Status] [smallint] NOT NULL,
	[Advance] [money] NULL,
 CONSTRAINT [PK_Auto] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [uniqueidentifier] NOT NULL,
	[CityCode] [int] NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Addresse] [nvarchar](150) NOT NULL,
	[Phone] [nvarchar](24) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DamageClass]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DamageClass](
	[Class] [int] NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Description] [ntext] NULL,
 CONSTRAINT [PK_DamageClass] PRIMARY KEY CLUSTERED 
(
	[Class] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Type] [nvarchar](25) NOT NULL,
	[Address] [nvarchar](150) NULL,
	[Phone] [nvarchar](16) NOT NULL,
	[InsuranceNumber] [nvarchar](26) NULL,
	[LicenceNumber] [nvarchar](26) NULL,
	[Passport] [nvarchar](26) NULL,
	[BirthDay] [date] NULL,
	[Data] [xml] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AutoPhotos]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AutoPhotos](
	[AutoNumber] [nvarchar](10) NOT NULL,
	[DoDate] [datetime] NOT NULL,
	[PhotoFileName] [nvarchar](250) NOT NULL,
	[DmgClass] [int] NULL,
 CONSTRAINT [PK_AutoPhotos] PRIMARY KEY CLUSTERED 
(
	[AutoNumber] ASC,
	[DoDate] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Family] [nvarchar](50) NOT NULL,
	[BirthDay] [date] NULL,
	[Position] [nchar](10) NULL,
	[DepartmentId] [uniqueidentifier] NULL,
	[Address] [nvarchar](150) NULL,
	[Phone] [nvarchar](16) NOT NULL,
	[HireDate] [date] NOT NULL,
	[FireDate] [date] NULL,
	[InsuranceNumber] [nvarchar](26) NULL,
	[LicenceNumber] [nvarchar](24) NULL,
	[Data] [xml] NULL,
 CONSTRAINT [PK_Employe] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RulesInRole]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RulesInRole](
	[RoleId] [uniqueidentifier] NOT NULL,
	[PermId] [bigint] NOT NULL,
	[Read] [bit] NOT NULL,
	[Write] [bit] NOT NULL,
	[Delete] [bit] NOT NULL,
	[Execute] [bit] NOT NULL,
	[New] [bit] NOT NULL,
 CONSTRAINT [PK_RulesInRole] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC,
	[PermId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[OrderId] [int] NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[Type] [int] NOT NULL,
	[Amount] [money] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Destination] [nvarchar](250) NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Number] [int] IDENTITY(1,1) NOT NULL,
	[AutoNumber] [nvarchar](10) NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[ManagerId] [uniqueidentifier] NULL,
	[CreationDate] [datetime] NOT NULL,
	[ExpiredDate] [datetime] NULL,
	[DepartmentId] [uniqueidentifier] NOT NULL,
	[Type] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Description] [nvarchar](250) NULL,
	[Data] [xml] NULL,
	[Template] [nvarchar](150) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nchar](10) NULL,
	[Created] [datetime] NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
	[ERecord] [uniqueidentifier] NULL,
	[CRecord] [uniqueidentifier] NULL,
	[Lock] [bit] NOT NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[Id] [int] NOT NULL,
	[Created] [datetime] NOT NULL,
	[Closed] [datetime] NULL,
	[LifeCycle] [datetimeoffset](7) NULL,
	[Type] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[AutoNumber] [nvarchar](10) NOT NULL,
	[CustomerId] [uniqueidentifier] NULL,
	[EmployeeId] [uniqueidentifier] NULL,
	[DepartmentId] [uniqueidentifier] NOT NULL,
	[OrderNumber] [int] NULL,
	[Description] [nvarchar](200) NULL,
	[XmlData] [xml] NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInRoles]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInRoles](
	[Login] [nvarchar](50) NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_UserInRoles] PRIMARY KEY CLUSTERED 
(
	[Login] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketHistory]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketHistory](
	[TicketId] [int] NOT NULL,
	[DoDate] [datetime] NOT NULL,
	[Action] [int] NOT NULL,
	[Executor] [uniqueidentifier] NULL,
	[DepartmentId] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](150) NULL,
	[XmlData] [xml] NULL,
 CONSTRAINT [PK_TicketHistory] PRIMARY KEY CLUSTERED 
(
	[TicketId] ASC,
	[DoDate] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Revisions]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Revisions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[DoDate] [datetime] NOT NULL,
	[Type] [int] NULL,
	[AutoNumber] [nvarchar](10) NULL,
 CONSTRAINT [PK_Revisions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Damages]    Script Date: 03/26/2012 18:26:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Damages](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[RevisionId] [bigint] NOT NULL,
	[Class] [int] NOT NULL,
	[Rate] [tinyint] NOT NULL,
 CONSTRAINT [PK_Damages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_Payment_Date]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_Date]  DEFAULT (getdate()) FOR [Date]
GO
/****** Object:  Default [DF_Order_CreationDate]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
/****** Object:  Default [DF_Members_Created]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Members] ADD  CONSTRAINT [DF_Members_Created]  DEFAULT (getdate()) FOR [Created]
GO
/****** Object:  Default [DF_Members_Lock]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Members] ADD  CONSTRAINT [DF_Members_Lock]  DEFAULT ((0)) FOR [Lock]
GO
/****** Object:  ForeignKey [FK_AutoPhotos_Auto]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[AutoPhotos]  WITH CHECK ADD  CONSTRAINT [FK_AutoPhotos_Auto] FOREIGN KEY([AutoNumber])
REFERENCES [dbo].[Auto] ([Number])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AutoPhotos] CHECK CONSTRAINT [FK_AutoPhotos_Auto]
GO
/****** Object:  ForeignKey [FK_AutoPhotos_DamageClass]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[AutoPhotos]  WITH CHECK ADD  CONSTRAINT [FK_AutoPhotos_DamageClass] FOREIGN KEY([DmgClass])
REFERENCES [dbo].[DamageClass] ([Class])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[AutoPhotos] CHECK CONSTRAINT [FK_AutoPhotos_DamageClass]
GO
/****** Object:  ForeignKey [FK_Employe_Department]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employe_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employe_Department]
GO
/****** Object:  ForeignKey [FK_RulesInRole_PrermissionRule]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[RulesInRole]  WITH CHECK ADD  CONSTRAINT [FK_RulesInRole_PrermissionRule] FOREIGN KEY([PermId])
REFERENCES [dbo].[PermissionRule] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RulesInRole] CHECK CONSTRAINT [FK_RulesInRole_PrermissionRule]
GO
/****** Object:  ForeignKey [FK_RulesInRole_Roles]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[RulesInRole]  WITH CHECK ADD  CONSTRAINT [FK_RulesInRole_Roles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RulesInRole] CHECK CONSTRAINT [FK_RulesInRole_Roles]
GO
/****** Object:  ForeignKey [FK_Payment_Customer]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Customer]
GO
/****** Object:  ForeignKey [FK_Order_Customer]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
/****** Object:  ForeignKey [FK_Order_Department]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Department] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[Department] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Department]
GO
/****** Object:  ForeignKey [FK_Order_Employe]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Employe] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[Employee] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Employe]
GO
/****** Object:  ForeignKey [FK_Members_Customer]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Members]  WITH CHECK ADD  CONSTRAINT [FK_Members_Customer] FOREIGN KEY([CRecord])
REFERENCES [dbo].[Customer] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Members] CHECK CONSTRAINT [FK_Members_Customer]
GO
/****** Object:  ForeignKey [FK_Members_Employe]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Members]  WITH CHECK ADD  CONSTRAINT [FK_Members_Employe] FOREIGN KEY([ERecord])
REFERENCES [dbo].[Employee] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Members] CHECK CONSTRAINT [FK_Members_Employe]
GO
/****** Object:  ForeignKey [FK_Ticket_Auto]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Auto] FOREIGN KEY([AutoNumber])
REFERENCES [dbo].[Auto] ([Number])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Auto]
GO
/****** Object:  ForeignKey [FK_Ticket_Customer]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Customer]
GO
/****** Object:  ForeignKey [FK_Ticket_Department]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Department]
GO
/****** Object:  ForeignKey [FK_Ticket_Employe]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Employe] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Employe]
GO
/****** Object:  ForeignKey [FK_UserInRoles_Members]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[UserInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserInRoles_Members] FOREIGN KEY([Login])
REFERENCES [dbo].[Members] ([Login])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserInRoles] CHECK CONSTRAINT [FK_UserInRoles_Members]
GO
/****** Object:  ForeignKey [FK_UserInRoles_Roles]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[UserInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserInRoles_Roles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserInRoles] CHECK CONSTRAINT [FK_UserInRoles_Roles]
GO
/****** Object:  ForeignKey [FK_TicketHistory_Ticket]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[TicketHistory]  WITH CHECK ADD  CONSTRAINT [FK_TicketHistory_Ticket] FOREIGN KEY([TicketId])
REFERENCES [dbo].[Ticket] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TicketHistory] CHECK CONSTRAINT [FK_TicketHistory_Ticket]
GO
/****** Object:  ForeignKey [FK_Revisions_TicketHistory]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Revisions]  WITH CHECK ADD  CONSTRAINT [FK_Revisions_TicketHistory] FOREIGN KEY([TicketId], [DoDate])
REFERENCES [dbo].[TicketHistory] ([TicketId], [DoDate])
GO
ALTER TABLE [dbo].[Revisions] CHECK CONSTRAINT [FK_Revisions_TicketHistory]
GO
/****** Object:  ForeignKey [FK_Damages_DamageClass]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Damages]  WITH CHECK ADD  CONSTRAINT [FK_Damages_DamageClass] FOREIGN KEY([Class])
REFERENCES [dbo].[DamageClass] ([Class])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Damages] CHECK CONSTRAINT [FK_Damages_DamageClass]
GO
/****** Object:  ForeignKey [FK_Damages_Revisions]    Script Date: 03/26/2012 18:26:03 ******/
ALTER TABLE [dbo].[Damages]  WITH CHECK ADD  CONSTRAINT [FK_Damages_Revisions] FOREIGN KEY([RevisionId])
REFERENCES [dbo].[Revisions] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Damages] CHECK CONSTRAINT [FK_Damages_Revisions]
GO
