USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tblSituacije]    Script Date: 30. 12. 2020 13:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSituacije](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[id_objekta] [int] NULL,
	[Objekt] [nvarchar](50) NULL,
	[Mesec] [nchar](10) NULL,
	[Leto] [nchar](10) NULL,
	[Datum] [datetime] NULL,
	[id_situacije] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblSituacije] ON 

INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (28, 2, N'Javne poti', N'september ', N'2020      ', CAST(0x0000AC2E0122CCA4 AS DateTime), N'2020september2')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (29, 2, N'Javne poti', N'avgust    ', N'2020      ', CAST(0x0000AC0F01246200 AS DateTime), N'2020avgust2')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (30, 1, N'Mestne ulice', N'oktober   ', N'2020      ', CAST(0x0000AC5C00A838A5 AS DateTime), N'2020oktober1')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (31, 2, N'Javne poti', N'oktober   ', N'2020      ', CAST(0x0000AC4C00AA7FA8 AS DateTime), N'2020oktober2')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (32, 3, N'Lokalne ceste', N'oktober   ', N'2020      ', CAST(0x0000AC47009EA804 AS DateTime), N'2020oktober3')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (33, 4, N'Neurje', N'oktober   ', N'2020      ', CAST(0x0000AC4A009790C8 AS DateTime), N'2020oktober4')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (34, 3, N'Lokalne ceste', N'november  ', N'2020      ', CAST(0x0000AC67008C5E60 AS DateTime), N'2020november3')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (35, 2, N'Javne poti', N'november  ', N'2020      ', CAST(0x0000AC6700906F00 AS DateTime), N'2020november2')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (36, 1, N'Mestne ulice', N'november  ', N'2020      ', CAST(0x0000AC6F00997014 AS DateTime), N'2020november1')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (37, 5, N'Zimska služba', N'november  ', N'2020      ', CAST(0x0000AC67009C5CE8 AS DateTime), N'2020november5')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (38, 0, N'Lokalne ceste', N'december  ', N'2020      ', CAST(0x0000AC8800C745F8 AS DateTime), N'2020december0')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (39, 4, N'Neurje', N'december  ', N'2020      ', CAST(0x0000AC8800CE828E AS DateTime), N'2020december4')
INSERT [dbo].[tblSituacije] ([Id], [id_objekta], [Objekt], [Mesec], [Leto], [Datum], [id_situacije]) VALUES (40, 2, N'Javne poti', N'december  ', N'2020      ', CAST(0x0000AC8800D3F370 AS DateTime), N'2020december2')
SET IDENTITY_INSERT [dbo].[tblSituacije] OFF
