USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tblNastavitve]    Script Date: 28. 02. 2021 21:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNastavitve](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[imenik] [nvarchar](150) NULL,
	[mapa_pogodbe_tel] [nvarchar](150) NULL,
	[disk] [nvarchar](50) NULL,
	[direktor] [nvarchar](50) NULL,
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

INSERT [dbo].[tblNastavitve] ([id], [imenik], [mapa_pogodbe_tel], [disk], [direktor], [datum_o_1], [datum_o_2], [tekst_o_1], [tekst_o_2], [datum_t_1], [datum_t_2], [tekst_t_1], [tekst_t_2]) VALUES (8, N'c:\Users\Andrej\source\repos\andrejdimec\KomunalaApp\', N'Dokumenti\Pogodbe\Telefonija\', N'c:', N'dr. Boštjan Vaupotič', N'junij 2013', N'1. 7. 2013', N'(korekcije cen zaradi sprememb DDV)', N'Cene storitev podjetja Komunala Radgona d.o.o. je obravnaval in potrdil Nadzorni svet družbe na svoji 4. redni seji dne 20. 6. 2013 ', N'februar 2014', N'1. 1. 2014', N'v letu 2014', N'')
SET IDENTITY_INSERT [dbo].[tblNastavitve] OFF
