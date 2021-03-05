USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_osebe]    Script Date: 28. 02. 2021 21:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_osebe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Oseba] [nvarchar](50) NULL,
	[Funkcija] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_osebe] ON 

INSERT [dbo].[tbl_osebe] ([Id], [Oseba], [Funkcija]) VALUES (1, N'Franc Kovačič', N'Delovodja')
INSERT [dbo].[tbl_osebe] ([Id], [Oseba], [Funkcija]) VALUES (2, N'Andrej Subašič', N'Nadzornik')
INSERT [dbo].[tbl_osebe] ([Id], [Oseba], [Funkcija]) VALUES (4, N'dr. Boštjan Vaupotič', N'Direktor')
SET IDENTITY_INSERT [dbo].[tbl_osebe] OFF
