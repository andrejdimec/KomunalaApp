USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_Enote]    Script Date: 29. 11. 2020 22:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Enote](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[em] [nvarchar](50) NULL,
	[opis] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_Enote] ON 

INSERT [dbo].[tbl_Enote] ([Id], [em], [opis]) VALUES (1, N'm', N'Meter')
INSERT [dbo].[tbl_Enote] ([Id], [em], [opis]) VALUES (2, N'km', N'Kilometer')
INSERT [dbo].[tbl_Enote] ([Id], [em], [opis]) VALUES (3, N'kos', N'Kos')
INSERT [dbo].[tbl_Enote] ([Id], [em], [opis]) VALUES (4, N'ura', N'Ura')
INSERT [dbo].[tbl_Enote] ([Id], [em], [opis]) VALUES (5, N't', N'Tona')
INSERT [dbo].[tbl_Enote] ([Id], [em], [opis]) VALUES (6, N'm3', N'Kubični meter')
INSERT [dbo].[tbl_Enote] ([Id], [em], [opis]) VALUES (7, N'm2', N'Kvadratni meter')
INSERT [dbo].[tbl_Enote] ([Id], [em], [opis]) VALUES (8, N'dan', N'Dan')
INSERT [dbo].[tbl_Enote] ([Id], [em], [opis]) VALUES (9, N'kg', N'kilogram')
SET IDENTITY_INSERT [dbo].[tbl_Enote] OFF
