USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_Vreme]    Script Date: 9. 12. 2020 21:13:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Vreme](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[opis] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_Vreme] ON 

INSERT [dbo].[tbl_Vreme] ([Id], [opis]) VALUES (1, N'Jasno')
INSERT [dbo].[tbl_Vreme] ([Id], [opis]) VALUES (2, N'Delno jasno')
INSERT [dbo].[tbl_Vreme] ([Id], [opis]) VALUES (3, N'Sončno')
INSERT [dbo].[tbl_Vreme] ([Id], [opis]) VALUES (4, N'Delno oblačno')
INSERT [dbo].[tbl_Vreme] ([Id], [opis]) VALUES (5, N'Sneži')
INSERT [dbo].[tbl_Vreme] ([Id], [opis]) VALUES (6, N'Dežuje')
INSERT [dbo].[tbl_Vreme] ([Id], [opis]) VALUES (7, N'Poledica')
INSERT [dbo].[tbl_Vreme] ([Id], [opis]) VALUES (8, N'Oblačno')
SET IDENTITY_INSERT [dbo].[tbl_Vreme] OFF
