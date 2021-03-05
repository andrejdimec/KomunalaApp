USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[Tbl_Objekti]    Script Date: 28. 02. 2021 21:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Objekti](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NULL,
	[Opis] [nvarchar](50) NULL,
	[Podrocje] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Tbl_Objekti] ON 

INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (1, N'Črešnjevci 1, Mencinger PČP', N'Prečrpališče Mencinger', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (2, N'Mulec, Zbigovci 1 VH in PČP', N'Prečrpališče Mulec', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (3, N'Prečrpališče Epas', N'Kanalizacijko prečrpališče', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (4, N'Grajski hrib VH', N'', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (5, N'Grajski hrib PČP', N'', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (6, N'Lomanoše PČP', N'', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (7, N'Plitvički Vrh VH', N'', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (8, N'Strah, Police VH in PČP', N'', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (9, N'Kodalič, Police VH in PČP', N'VH in PČP', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (10, N'Borko, Police VH in PČP', N'VH in PČP', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (11, N'Črešnjevci 2, uprava PČP', N'', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (12, N'Kurbus, Orehovci PČP', N'', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (13, N'Ptujska cesta VH', N'', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (14, N'Center SCADA', N'Vodovod', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (15, N'Center SCADA', N'Kanalizacija', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (16, N'Čistilna naprava Negova', N'Čistilna naprava', 3)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (17, N'Zbigovci 2 VH in PČP', N'', 1)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (18, N'Hamler, Črešnjevci PČP', N'', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (19, N'B3 PČP', N'Mariborska cesta', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (20, N'TŠC, stadion PČP', N'', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (21, N'Park 2 PČP', N'', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (22, N'Č1, Podgrad Levar PČP', N'', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (23, N'Č4, Črešnjevci CP PČP', N'', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (24, N'Č6, Črešnjevci 156a PČP', N'', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (25, N'Mele, Mele 16 PČP', N'', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (26, N'B1, Podgrad PČP', N'', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (27, N'B2, Apaška cesta PČP', N'', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (28, N'B4, Trate baza PČP', N'', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (29, N'Podgrad 2 PČP', N'', 2)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (30, N'Komunalana čistilna naprava', N'Mele 3a', 3)
INSERT [dbo].[Tbl_Objekti] ([Id], [Naziv], [Opis], [Podrocje]) VALUES (31, N'Norički Vrh VH in PČP', N'', 1)
SET IDENTITY_INSERT [dbo].[Tbl_Objekti] OFF
