USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[Tbl_delovisca]    Script Date: 28. 02. 2021 21:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_delovisca](
	[Id_delovisca] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Tbl_delovisca] ON 

INSERT [dbo].[Tbl_delovisca] ([Id_delovisca], [Naziv]) VALUES (1, N'Mestne ulice')
INSERT [dbo].[Tbl_delovisca] ([Id_delovisca], [Naziv]) VALUES (2, N'Javne poti')
INSERT [dbo].[Tbl_delovisca] ([Id_delovisca], [Naziv]) VALUES (3, N'Lokalne ceste')
INSERT [dbo].[Tbl_delovisca] ([Id_delovisca], [Naziv]) VALUES (4, N'Neurje')
INSERT [dbo].[Tbl_delovisca] ([Id_delovisca], [Naziv]) VALUES (5, N'Zimska služba')
SET IDENTITY_INSERT [dbo].[Tbl_delovisca] OFF
