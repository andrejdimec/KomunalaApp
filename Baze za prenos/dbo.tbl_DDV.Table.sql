USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_DDV]    Script Date: 29. 11. 2020 22:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DDV](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Opis] [nvarchar](50) NULL,
	[Stopnja] [float] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_DDV] ON 

INSERT [dbo].[tbl_DDV] ([Id], [Opis], [Stopnja]) VALUES (14, N'DDV 22 %', 22)
INSERT [dbo].[tbl_DDV] ([Id], [Opis], [Stopnja]) VALUES (27, N'DDV 9,5%', 9.5)
SET IDENTITY_INSERT [dbo].[tbl_DDV] OFF
