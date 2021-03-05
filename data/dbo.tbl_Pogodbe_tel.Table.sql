USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_Pogodbe_tel]    Script Date: 28. 02. 2021 21:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Pogodbe_tel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Zaporedna] [int] NULL,
	[Datum] [date] NULL,
	[TipDokumenta] [int] NULL,
	[Opis] [nvarchar](250) NULL,
	[Fname] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_Pogodbe_tel] ON 

INSERT [dbo].[tbl_Pogodbe_tel] ([Id], [Zaporedna], [Datum], [TipDokumenta], [Opis], [Fname]) VALUES (1, 1, CAST(0xCC410B00 AS Date), 1, N'p', N'Ime datoteke')
INSERT [dbo].[tbl_Pogodbe_tel] ([Id], [Zaporedna], [Datum], [TipDokumenta], [Opis], [Fname]) VALUES (2, 1, CAST(0xED410B00 AS Date), 1, N'p', N'Ime datoteke')
SET IDENTITY_INSERT [dbo].[tbl_Pogodbe_tel] OFF
