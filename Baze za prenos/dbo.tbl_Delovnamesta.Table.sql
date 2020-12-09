USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_Delovnamesta]    Script Date: 9. 12. 2020 21:13:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Delovnamesta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NULL,
	[Opomba] [nvarchar](50) NULL,
	[Enota] [int] NULL,
	[Ura] [float] NULL,
	[DDV] [int] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_Delovnamesta] ON 

INSERT [dbo].[tbl_Delovnamesta] ([Id], [Naziv], [Opomba], [Enota], [Ura], [DDV]) VALUES (5, N'Delovno mesto 11', N'Opomba 1', 2, 10, 14)
INSERT [dbo].[tbl_Delovnamesta] ([Id], [Naziv], [Opomba], [Enota], [Ura], [DDV]) VALUES (9, N'Delovno mesto 2', N'Opomba 2', 5, 13.5, 27)
INSERT [dbo].[tbl_Delovnamesta] ([Id], [Naziv], [Opomba], [Enota], [Ura], [DDV]) VALUES (10, N'Delovno mesto 3', N'', 3, 11.1, 14)
INSERT [dbo].[tbl_Delovnamesta] ([Id], [Naziv], [Opomba], [Enota], [Ura], [DDV]) VALUES (11, N'Delovno mesto 4', N'op 4', 4, 33.66, 14)
SET IDENTITY_INSERT [dbo].[tbl_Delovnamesta] OFF
