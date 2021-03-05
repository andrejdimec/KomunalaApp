USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[Tbl_TipPogodbe]    Script Date: 28. 02. 2021 21:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_TipPogodbe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TipPogodbe] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Tbl_TipPogodbe] ON 

INSERT [dbo].[Tbl_TipPogodbe] ([Id], [TipPogodbe]) VALUES (1, N'Pogodba o naročniškem razmerju za tel. številko')
INSERT [dbo].[Tbl_TipPogodbe] ([Id], [TipPogodbe]) VALUES (2, N'Pogodba o zaposlitvi')
INSERT [dbo].[Tbl_TipPogodbe] ([Id], [TipPogodbe]) VALUES (3, N'Pogodba z zunanjim izvajalcem')
INSERT [dbo].[Tbl_TipPogodbe] ([Id], [TipPogodbe]) VALUES (4, N'Pogodba z Občino Gornja Radgona')
INSERT [dbo].[Tbl_TipPogodbe] ([Id], [TipPogodbe]) VALUES (5, N'Aneks k pogodbi o naročniškem razmerju za tel. številko')
INSERT [dbo].[Tbl_TipPogodbe] ([Id], [TipPogodbe]) VALUES (6, N'Drugi dokumenti - telefoni')
SET IDENTITY_INSERT [dbo].[Tbl_TipPogodbe] OFF
