USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[Tbl_sodelavci]    Script Date: 1. 12. 2020 22:53:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_sodelavci](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[emso] [nchar](10) NULL,
	[Ime] [nvarchar](50) NULL,
	[Priimek] [nvarchar](50) NULL,
	[Ulica] [nvarchar](50) NULL,
	[hs] [nchar](10) NULL,
	[posta] [nchar](10) NULL,
	[posta_ime] [nvarchar](50) NULL,
	[ds] [nchar](10) NULL,
	[tel_privat] [nvarchar](50) NULL,
	[tel_sluzba_1] [nvarchar](50) NULL,
	[tel_sluzba_2] [nvarchar](50) NULL,
	[email_privat] [nvarchar](50) NULL,
	[email_sluzba] [nvarchar](50) NULL,
	[trr] [nchar](10) NULL,
	[banka] [nvarchar](50) NULL,
	[izobrazba] [nvarchar](50) NULL,
	[del_mesto] [nvarchar](50) NULL,
	[oddelek] [int] NULL,
	[sm] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Tbl_sodelavci] ON 

INSERT [dbo].[Tbl_sodelavci] ([Id], [emso], [Ime], [Priimek], [Ulica], [hs], [posta], [posta_ime], [ds], [tel_privat], [tel_sluzba_1], [tel_sluzba_2], [email_privat], [email_sluzba], [trr], [banka], [izobrazba], [del_mesto], [oddelek], [sm]) VALUES (1, N'28069     ', N'Andrej', N'Dimec', N'Kocljeva ulica', N'13        ', N'9250      ', N'Gornja Radgona', N'86526996  ', N'', N'031 773 860', N'5644 806', N'dimec.andrej@gmail.com', N'andrej.dimec@komunala-radgona.si', N'          ', N'          ', N'inž. metalurgije', N'Referent za kataster', 1, 1)
INSERT [dbo].[Tbl_sodelavci] ([Id], [emso], [Ime], [Priimek], [Ulica], [hs], [posta], [posta_ime], [ds], [tel_privat], [tel_sluzba_1], [tel_sluzba_2], [email_privat], [email_sluzba], [trr], [banka], [izobrazba], [del_mesto], [oddelek], [sm]) VALUES (2, N'          ', N'Simona', N'Skaza', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'Računovodkinja', 2, 2)
INSERT [dbo].[Tbl_sodelavci] ([Id], [emso], [Ime], [Priimek], [Ulica], [hs], [posta], [posta_ime], [ds], [tel_privat], [tel_sluzba_1], [tel_sluzba_2], [email_privat], [email_sluzba], [trr], [banka], [izobrazba], [del_mesto], [oddelek], [sm]) VALUES (3, N'          ', N'Boštjan', N'Vaupotič', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'          ', N'Direktor', 3, 2)
SET IDENTITY_INSERT [dbo].[Tbl_sodelavci] OFF
