USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tblSituacija_temp]    Script Date: 28. 02. 2021 21:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSituacija_temp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Zap] [int] NULL,
	[Skupina_id] [int] NULL,
	[Skupina_stor] [nvarchar](50) NULL,
	[Storitev] [nvarchar](150) NULL,
	[Em] [nchar](10) NULL,
	[Cena] [float] NULL,
	[ddv] [float] NULL,
	[k01] [float] NULL,
	[k02] [float] NULL,
	[k03] [float] NULL,
	[k04] [float] NULL,
	[k05] [float] NULL,
	[k06] [float] NULL,
	[k07] [float] NULL,
	[k08] [float] NULL,
	[k09] [float] NULL,
	[k010] [float] NULL,
	[k011] [float] NULL,
	[k012] [float] NULL,
	[k013] [float] NULL,
	[k014] [float] NULL,
	[k015] [float] NULL,
	[k016] [float] NULL,
	[k017] [float] NULL,
	[k018] [float] NULL,
	[k019] [float] NULL,
	[k020] [float] NULL,
	[k021] [float] NULL,
	[k022] [float] NULL,
	[k023] [float] NULL,
	[k024] [float] NULL,
	[k025] [float] NULL,
	[k026] [float] NULL,
	[k027] [float] NULL,
	[k028] [float] NULL,
	[k029] [float] NULL,
	[k030] [float] NULL,
	[k031] [float] NULL,
	[k_skupaj] [float] NULL,
	[Znesek] [float] NULL,
	[mesec] [nchar](10) NULL,
	[leto] [nchar](10) NULL,
	[sestavil] [nvarchar](50) NULL,
	[odgovorni] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblSituacija_temp] ON 

INSERT [dbo].[tblSituacija_temp] ([Id], [Zap], [Skupina_id], [Skupina_stor], [Storitev], [Em], [Cena], [ddv], [k01], [k02], [k03], [k04], [k05], [k06], [k07], [k08], [k09], [k010], [k011], [k012], [k013], [k014], [k015], [k016], [k017], [k018], [k019], [k020], [k021], [k022], [k023], [k024], [k025], [k026], [k027], [k028], [k029], [k030], [k031], [k_skupaj], [Znesek], [mesec], [leto], [sestavil], [odgovorni]) VALUES (3051, 0, 10, N'________________', N'', N'          ', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, N'december  ', N'2020      ', N'sestavil', N'odgovorni')
INSERT [dbo].[tblSituacija_temp] ([Id], [Zap], [Skupina_id], [Skupina_stor], [Storitev], [Em], [Cena], [ddv], [k01], [k02], [k03], [k04], [k05], [k06], [k07], [k08], [k09], [k010], [k011], [k012], [k013], [k014], [k015], [k016], [k017], [k018], [k019], [k020], [k021], [k022], [k023], [k024], [k025], [k026], [k027], [k028], [k029], [k030], [k031], [k_skupaj], [Znesek], [mesec], [leto], [sestavil], [odgovorni]) VALUES (3052, 0, 10, N'Nova skupina', N'Material ', N'          ', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, N'december  ', N'2020      ', N'sestavil', N'odgovorni')
INSERT [dbo].[tblSituacija_temp] ([Id], [Zap], [Skupina_id], [Skupina_stor], [Storitev], [Em], [Cena], [ddv], [k01], [k02], [k03], [k04], [k05], [k06], [k07], [k08], [k09], [k010], [k011], [k012], [k013], [k014], [k015], [k016], [k017], [k018], [k019], [k020], [k021], [k022], [k023], [k024], [k025], [k026], [k027], [k028], [k029], [k030], [k031], [k_skupaj], [Znesek], [mesec], [leto], [sestavil], [odgovorni]) VALUES (3053, 7, 10, N'Material ', N'Beton 2', N'kg        ', 20, 9.5, 0, 0, 0, 0, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 100, 2000, N'december  ', N'2020      ', N'sestavil', N'odgovorni')
SET IDENTITY_INSERT [dbo].[tblSituacija_temp] OFF
