USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tblNastavitve]    Script Date: 9. 12. 2020 21:13:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNastavitve](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Imenik] [nvarchar](50) NULL,
	[Direktor] [nvarchar](50) NULL,
	[datum_o_1] [nvarchar](50) NULL,
	[datum_o_2] [nvarchar](50) NULL,
	[tekst_o_1] [nvarchar](150) NULL,
	[tekst_o_2] [nvarchar](150) NULL,
	[datum_t_1] [nvarchar](50) NULL,
	[datum_t_2] [nvarchar](50) NULL,
	[tekst_t_1] [nvarchar](150) NULL,
	[tekst_t_2] [nvarchar](150) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblNastavitve] ON 

INSERT [dbo].[tblNastavitve] ([Id], [Imenik], [Direktor], [datum_o_1], [datum_o_2], [tekst_o_1], [tekst_o_2], [datum_t_1], [datum_t_2], [tekst_t_1], [tekst_t_2]) VALUES (1, N'C:\KomunalaApp\Komunala\bin\Debug', N'ss', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[tblNastavitve] ([Id], [Imenik], [Direktor], [datum_o_1], [datum_o_2], [tekst_o_1], [tekst_o_2], [datum_t_1], [datum_t_2], [tekst_t_1], [tekst_t_2]) VALUES (2, N'C:\KomunalaApp\Komunala\bin\Debug', N'ss', N'qwdqwd', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[tblNastavitve] ([Id], [Imenik], [Direktor], [datum_o_1], [datum_o_2], [tekst_o_1], [tekst_o_2], [datum_t_1], [datum_t_2], [tekst_t_1], [tekst_t_2]) VALUES (3, N'C:\KomunalaApp\Komunala\bin\Debug', N'ss', N'qwdqwd', N'', N'', N'to je tekst
vrsta dva', N'', N'', N'', N'')
INSERT [dbo].[tblNastavitve] ([Id], [Imenik], [Direktor], [datum_o_1], [datum_o_2], [tekst_o_1], [tekst_o_2], [datum_t_1], [datum_t_2], [tekst_t_1], [tekst_t_2]) VALUES (4, N'C:\KomunalaApp\Komunala\bin\Debug', N'ss', N'qwdqwd', N'', N'', N'to je tekst
vrsta dva
tri', N'', N'', N'', N'')
INSERT [dbo].[tblNastavitve] ([Id], [Imenik], [Direktor], [datum_o_1], [datum_o_2], [tekst_o_1], [tekst_o_2], [datum_t_1], [datum_t_2], [tekst_t_1], [tekst_t_2]) VALUES (5, N'C:\KomunalaApp\Komunala\bin\Debug', N'dr. Boštjan Vaupotič', N'qwdqwd', N'', N'', N'to je tekst
vrsta dva
tri', N'', N'', N'', N'')
INSERT [dbo].[tblNastavitve] ([Id], [Imenik], [Direktor], [datum_o_1], [datum_o_2], [tekst_o_1], [tekst_o_2], [datum_t_1], [datum_t_2], [tekst_t_1], [tekst_t_2]) VALUES (6, N'C:\KomunalaApp\Komunala\bin\Debug', N'dr. Boštjan Vaupotič', N'junij 2013', N'1. 7. 2013', N'(korekcije cen zaradi sprememb DDV)', N'Cene storitev podjetja Komunala Radgona d.o.o. je obravnaval in potrdil Nadzorni svet družbe na svoji 4. redni seji dne 20. 6. 2013 ', N'', N'', N'', N'')
INSERT [dbo].[tblNastavitve] ([Id], [Imenik], [Direktor], [datum_o_1], [datum_o_2], [tekst_o_1], [tekst_o_2], [datum_t_1], [datum_t_2], [tekst_t_1], [tekst_t_2]) VALUES (7, N'C:\KomunalaApp\Komunala\bin\Debug', N'dr. Boštjan Vaupotič', N'junij 2013', N'1. 7. 2013', N'(korekcije cen zaradi sprememb DDV)', N'Cene storitev podjetja Komunala Radgona d.o.o. je obravnaval in potrdil Nadzorni svet družbe na svoji 4. redni seji dne 20. 6. 2013 ', N'februar 2014', N'1. 1. 2014', N'v letu 2014', N'')
INSERT [dbo].[tblNastavitve] ([Id], [Imenik], [Direktor], [datum_o_1], [datum_o_2], [tekst_o_1], [tekst_o_2], [datum_t_1], [datum_t_2], [tekst_t_1], [tekst_t_2]) VALUES (8, N'g:\KomunalaApp\Komunala\', N'dr. Boštjan Vaupotič', N'junij 2013', N'1. 7. 2013', N'(korekcije cen zaradi sprememb DDV)', N'Cene storitev podjetja Komunala Radgona d.o.o. je obravnaval in potrdil Nadzorni svet družbe na svoji 4. redni seji dne 20. 6. 2013 ', N'februar 2014', N'1. 1. 2014', N'v letu 2014', N'')
SET IDENTITY_INSERT [dbo].[tblNastavitve] OFF
