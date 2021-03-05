USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tblSkupinestoritev]    Script Date: 28. 02. 2021 21:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSkupinestoritev](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Skupina] [nvarchar](50) NULL,
	[indeks] [int] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblSkupinestoritev] ON 

INSERT [dbo].[tblSkupinestoritev] ([Id], [Skupina], [indeks]) VALUES (2, N'Delovna sila', 1)
INSERT [dbo].[tblSkupinestoritev] ([Id], [Skupina], [indeks]) VALUES (4, N'Storitve z ročnimi orodji', 2)
INSERT [dbo].[tblSkupinestoritev] ([Id], [Skupina], [indeks]) VALUES (5, N'Druge komunalne storitve', 3)
INSERT [dbo].[tblSkupinestoritev] ([Id], [Skupina], [indeks]) VALUES (6, N'Izdaja dokumentacije, izrisi', 5)
INSERT [dbo].[tblSkupinestoritev] ([Id], [Skupina], [indeks]) VALUES (7, N'Vozila in stroji', 4)
INSERT [dbo].[tblSkupinestoritev] ([Id], [Skupina], [indeks]) VALUES (8, N'Zimska služba', 7)
INSERT [dbo].[tblSkupinestoritev] ([Id], [Skupina], [indeks]) VALUES (9, N'Košnja', 6)
INSERT [dbo].[tblSkupinestoritev] ([Id], [Skupina], [indeks]) VALUES (10, N'Material ', 0)
SET IDENTITY_INSERT [dbo].[tblSkupinestoritev] OFF
