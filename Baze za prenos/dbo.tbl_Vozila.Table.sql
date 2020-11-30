USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_Vozila]    Script Date: 29. 11. 2020 22:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Vozila](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NULL,
	[Opomba] [nvarchar](50) NULL,
	[Ura] [float] NULL,
	[DDV] [int] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_Vozila] ON 

INSERT [dbo].[tbl_Vozila] ([Id], [Naziv], [Opomba], [Ura], [DDV]) VALUES (1, N'Valjar', N'', NULL, NULL)
INSERT [dbo].[tbl_Vozila] ([Id], [Naziv], [Opomba], [Ura], [DDV]) VALUES (2, N'JCB', N'', NULL, NULL)
INSERT [dbo].[tbl_Vozila] ([Id], [Naziv], [Opomba], [Ura], [DDV]) VALUES (3, N'Kanaljet', N'', NULL, NULL)
INSERT [dbo].[tbl_Vozila] ([Id], [Naziv], [Opomba], [Ura], [DDV]) VALUES (4, N'Agregat, prenosni, električni', N'', NULL, NULL)
INSERT [dbo].[tbl_Vozila] ([Id], [Naziv], [Opomba], [Ura], [DDV]) VALUES (5, N'Kompresor, prenosni', N'', NULL, NULL)
INSERT [dbo].[tbl_Vozila] ([Id], [Naziv], [Opomba], [Ura], [DDV]) VALUES (7, N'ena', N'', NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_Vozila] OFF
