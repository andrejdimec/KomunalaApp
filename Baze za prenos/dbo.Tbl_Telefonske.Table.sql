USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[Tbl_Telefonske]    Script Date: 9. 12. 2020 21:13:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Telefonske](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Skupina] [int] NULL,
	[rb_mobilna] [int] NULL,
	[Stevilka] [nvarchar](50) NULL,
	[Mpo] [nchar](10) NULL,
	[Aktivna] [bit] NULL,
	[Opis] [nvarchar](250) NULL,
	[rb_oseba] [int] NULL,
	[Oseba] [int] NULL,
	[Objekt] [int] NULL,
	[Opomba] [nvarchar](max) NULL,
	[Imenik] [bit] NULL,
	[sm] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Tbl_Telefonske] ON 

INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (1, 0, 1, N'031 773 860', N'222       ', 1, N'Dimec Andrej, mobilna številka', 1, 1, -99, N'', 1, 2)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (2, 0, 2, N'02 5644 802', N'          ', 1, N'Skaza Simona, stacionarna številka', 1, 2, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (5, 0, 1, N'051 610 213', N'  213     ', 1, N'Cipot Bojan, mobilna številka', 1, 7, -99, N'', 1, 3)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (6, 0, 1, N'051 657 168', N'          ', 1, N'Popis vodomerov 1 ', 4, -99, -99, N'Terminal M3', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (9, 0, 1, N'051 654 812', N' 216      ', 1, N'Felbar Bernard, mobilna številka', 1, 9, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (10, 0, 1, N'031 550 444', N'201       ', 1, N'Ficko Mitja, mobilna številka', 1, 10, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (11, 0, 1, N'051 654 810', N'215       ', 1, N'Gorički Milan, mobilna številka', 1, 11, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (12, 0, 1, N'051 682 353', N'209       ', 1, N'Karba Drago, mobilna številka', 1, 12, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (13, 0, 1, N'031 747 012', N'225       ', 1, N'Katan Primož, mobilna številka', 1, 13, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (14, 0, 1, N'031 704 651', N'205       ', 1, N'Kluban Stanko, mobilna številka', 1, 14, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (15, 0, 1, N'031 819 773', N'          ', 0, N'Kolbl Miran
', 1, -99, -99, N'Odpoved poleti 2020', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (16, 0, 1, N'031 696 074', N'252       ', 1, N'Kovačič Branko, mobilna številka', 1, 16, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (17, 0, 1, N'051 325 212', N'212       ', 1, N'Kovačič Franc, mobilna številka', 1, 17, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (18, 0, 1, N'051 680 632', N'    207   ', 1, N'Oršoš Jože, mobilna številka', 1, 18, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (19, 0, 1, N'031 747 042', N'226       ', 1, N'Hamler Luka, mobilna številka', 1, 19, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (20, 0, 1, N'041 534 922', N'206       ', 1, N'Rožman Anton, mobilna številka', 1, 20, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (21, 0, 1, N'031 399 012', N'223       ', 1, N'Šerber Jože, mobilna številka', 1, 21, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (22, 0, 1, N'051 657 169', N'220       ', 1, N'Šoštarič Tomi, mobilna številka', 1, 22, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (23, 0, 1, N'031 378 111', N'250       ', 1, N'Rajtar Andrejka, mobilna številka', 1, 23, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (24, 0, 1, N'051 610 214', N'214       ', 1, N'Vebarič Igor, mobilna številka', 1, 24, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (25, 0, 1, N'040 205 811', N'200       ', 0, N'Erlih Zlatko
', 1, 8, -99, N'V penzijo maja 2020', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (26, 0, 1, N'041 604 943', N'218       ', 1, N'Volf Dani, mobilna številka', 1, 26, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (27, 0, 1, N'051 246 287', N'251       ', 1, N'Zupančič Tadeja, mobilna številka', 1, 27, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (28, 0, 1, N'041 364 670', N'          ', 1, N'Leica – GPS (SM 121)             
', 3, -99, -99, N'GNSS Leica GPS inštrument', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (29, 0, 1, N'031 780 638', N'          ', 1, N'Skaza Simona, internet', 3, 2, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (30, 0, 1, N'031 600 955', N'          ', 1, N'Tablica Lenovo S6000 (SM 159)
', 3, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (31, 0, 1, N'051 330 241', N'          ', 1, N'Tablica Lenovo TAB 2 A8 (SM 12)
', 3, -99, -99, N'Vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (32, 0, 1, N'041 696 324', N'          ', 1, N'VH Grajski hrib  (SM 12)
', 2, -99, 4, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (33, 0, 1, N'041 696 461', N'          ', 1, N'PČP Grajski hrib (SM 12)
', 2, -99, 5, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (34, 0, 1, N'051 680 936', N'          ', 1, N'PČP Lomanoše (SM 12)
', 2, -99, 6, N'Prečrpališče vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (35, 0, 1, N'031 383 565', N'          ', 1, N'PČP Lomanoše (SM 12', 2, -99, 6, N'Prečrpališče vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (36, 0, 1, N'051 680 938', N'          ', 1, N'VH, PČP Plitvički Vrh (SM 12)
', 2, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (37, 0, 1, N'031 383 570', N'          ', 1, N'VH, PČP Plitvički Vrh (SM 12', 2, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (38, 0, 1, N'051 680 785', N'          ', 1, N'VH, PČP Strah, Police (SM 12)
', 2, -99, 8, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (39, 0, 1, N'051 680 795', N'          ', 1, N'VH, PČP Kodalič, Police (SM 12)
', 2, -99, 9, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (40, 0, 1, N'051 680 923', N'          ', 1, N'VH, PČP Borko, Police (SM 12)
', 2, -99, 10, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (41, 0, 1, N'031 383 568', N'          ', 1, N'VH, PČP Zbigovci (SM 12)
', 2, -99, 17, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (42, 0, 1, N'031 383 561', N'          ', 1, N'PČP Črešnjevci 2 – Uprava (SM 12)
', 2, -99, 11, N'Prečrpališče vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (43, 0, 1, N'041 697 304', N'          ', 1, N'ČP Črešnjevci 1   Mencinger (SM 12)
', 2, -99, 1, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (44, 0, 1, N'031 704 647', N'          ', 1, N'PČP Kurbus, Orehovci (SM 12)
', 2, -99, 12, N'Prečrpališče vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (45, 0, 1, N'031 704 648', N'          ', 1, N'VH Ptujska cesta (SM 12)
', 2, -99, 13, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (46, 0, 1, N'051 681 044', N'          ', 1, N'PČP Simoničev breg (SM 12)
', 2, -99, -99, N'Prečrpališče vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (47, 0, 1, N'051 681 041', N'          ', 1, N'PČP Hercegovščak (SM 12)
', 2, -99, -99, N'Prečrpališče vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (48, 0, 1, N'051 327 429', N'          ', 1, N'PČP Očeslavci (SM 12)
', 2, -99, -99, N'Prečrpališče vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (49, 0, 1, N'041 329 351', N'          ', 1, N'Center SCADA (SM 12, SM 7)
', 2, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (50, 0, 1, N'041 337 841', N'          ', 1, N'Center SCADA (SM 12, SM 7)
', 2, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (51, 0, 1, N'051 367 106', N'          ', 1, N'Čistilna naprava Negova (SM 151)
', 2, -99, 16, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (52, 0, 1, N'051 622 242', N'          ', 1, N'VH PČP Zbigovci (SM 12)
', 2, -99, 17, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (53, 0, 1, N'051 622 278', N'          ', 1, N'VH PČP Zbigovci (SM 12)
', 2, -99, 17, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (54, 0, 1, N'031 669 258', N'          ', 1, N'PČP Hamler, Črešnjevci  (SM 7)
', 2, -99, 18, N'Kanalizacijsko črpališče', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (55, 0, 1, N'031 669 174', N'          ', 1, N'PČP Epas, Ind. cona (SM 7)
', 2, -99, 3, N'Kanalizacijsko črpališče', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (56, 0, 1, N'031 669 189', N'          ', 1, N'PČP B3, Mariborska cesta (SM 7)
', 2, -99, 19, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (57, 0, 1, N'031 670 273', N'          ', 1, N'PČP TŠC 1, Stadion (SM 7)
', 2, -99, 20, N'Kanalizacijsko črpališče', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (58, 0, 1, N'031 670 283', N'          ', 1, N'PČP Park 2, Mestni park (SM 7)
', 2, -99, 21, N'Kanalizacijsko črpališče', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (59, 0, 1, N'031 670 487', N'          ', 1, N'PČP Č1, Podgrad   Lebar (SM 7)
', 2, -99, 22, N'Kanalizacijsko črpališče', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (60, 0, 1, N'031 670 463', N'          ', 1, N'PČP Č4, Črešnjevci   CP (SM 7)
', 2, -99, 23, N'Kanalizacijsko črpališče', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (61, 0, 1, N'031 670 272', N'          ', 1, N'PČP Č6, Črešnjevci 156a (SM 7)
', 2, -99, 24, N'Kanalizacijsko črpališče', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (62, 0, 1, N'031 746 987', N'          ', 1, N'PČP Mele, Mele 16  (SM 7)
', 2, -99, 25, N'Kanalizacijsko črpališče', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (63, 0, 1, N'031 746 815', N'          ', 1, N'PČP B1, Podgrad (SM 7)
', 2, -99, 26, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (64, 0, 1, N'031 746 984', N'          ', 1, N'PČP B2, Apaška cesta (SM 7)
', 2, -99, 27, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (65, 0, 1, N'051 681 289', N'          ', 1, N'PČP B4, Trate baza (SM 7)
', 2, -99, 28, N'Kanalizacijsko prečrpališče baza Trate', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (66, 0, 1, N'051 305 226', N'          ', 1, N'PČP B4, varovanje modem (SM 7)
', 2, -99, 28, N'Kanalizacijsko prečrpališče baza Trate - varovanje', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (67, 0, 1, N'031 746 989', N'          ', 1, N'PČP B4 (SM 7)
', 2, -99, 28, N'Kanalizacijsko prečrpališče baza Trate', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (68, 0, 1, N'051 327 226', N'          ', 1, N'PČP Podgrad 2 (SM 7)
', 2, -99, 29, N'Kanalizacijsko črpališče', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (69, 0, 1, N'031 670 423', N'          ', 1, N'CČN Sintal (SM 159)
', 4, -99, -99, N'Varovanje na CČN', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (70, 0, 1, N'031 747 378', N'          ', 1, N'CČN alarmiranje (SM 159)
', 4, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (71, 0, 2, N'02 5643 828', N'          ', 1, N'Komunalna čistilna naprava', 4, -99, 30, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (72, 0, 1, N'02 5643 829', N'          ', 1, N'CČN centreks (SM 159)
', 4, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (73, 0, 1, N'02 6405 217', N'          ', 1, N'CČN povezljivost IP (SM 159)
', 4, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (74, 0, 1, N'031 704 649', N'          ', 1, N'Ne uporablja se', 4, -99, -99, N'Ugotoviti kaj je ta številka', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (75, 0, 1, N'041 663 420', N'          ', 1, N'police', 2, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (76, 0, 1, N'041 663 421', N'          ', 1, N'police', 2, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (77, 0, 1, N'051 680 793', N'          ', 1, N'telemetrija', 2, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (78, 0, 1, N'051 680 933', N'          ', 1, N'telemetrija', 2, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (79, 0, 2, N'02 5644 807', N'          ', 1, N'Obračun storitev', 4, -99, -99, N'Marija in Cvetka', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (80, 0, 2, N'02 5644 808', N'          ', 1, N'Telefaks', 4, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (81, 0, 2, N'02 5644 809', N'          ', 1, N'Stacionarna, prosta številka', 4, -99, -99, N'Prej Andrej Dimec', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (82, 0, 2, N'02 5644 810', N'          ', 1, N'Šenekar Nina, stacionarna številka', 1, 33, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (83, 0, 2, N'02 5644 806', N'          ', 1, N'Rožman Anton, stacionarna številka', 1, 20, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (84, 0, 2, N'02 5644 805', N'          ', 1, N'Dimec Andrej, stacionarna številka', 1, 1, -99, N'', 1, 2)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (85, 0, 2, N'02 5644 804', N'          ', 1, N'Šoštarič Tomi, stacionarna številka', 1, 22, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (86, 0, 2, N'02 5644 803', N'          ', 1, N'Vaupotič Boštjan, stacionarna številka', 1, 3, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (89, 0, 1, N'051 327 485', N'          ', 1, N'PČP Podgrad (SM 7)
', 2, -99, 29, N'Kanalizacijsko črpališče', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (90, 0, 1, N'031 669 272', N'          ', 1, N'PČP Kanalizacija (SM 7)
', 2, -99, -99, N'Kanalizacijsko črpališče', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (91, 0, 1, N'031 603 612', N'227       ', 1, N'Ratoša Renato, mobilna številka', 1, 36, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (92, 0, 1, N'031 694 419', N'          ', 1, N'Tablica Lenovo TAB 2 A8 (SM 12)
', 3, -99, -99, N'Vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (93, 0, 1, N'031 694 473', N'          ', 1, N'Tablica Lenovo TAB 2 A8 (SM 12)
', 3, -99, -99, N'Vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (94, 0, 1, N'041 643 307', N'253       ', 1, N'Tajništvo
, mobilna številka', 4, -99, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (95, 0, 1, N'040 786 742', N'228       ', 1, N'Dokl Miran, mobilna številka', 1, 28, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (96, 0, 1, N'041 681 407', N'          ', 1, N'PČP Orehovci (SM 12)
', 2, -99, 12, N'Prečrpališče vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (97, 0, 1, N'041 681 586', N'          ', 1, N'VH Ptujska Cesta (SM 12)
', 2, -99, 13, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (98, 0, 1, N'051 421 151', N'          ', 1, N'PČP Črešnjevci, Mencinger (SM 12)
', 2, -99, 1, N'Prečrpališče vodovod', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (99, 0, 1, N'051 421 139', N'          ', 1, N'PČP, VH Nor. Vrh, Police (SM 12)
', 2, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (100, 0, 1, N'041 645 834', N'          ', 1, N'Internet na bazi
', 3, -99, -99, N'Mobilni internet baza - odjaviti z 12/2020', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (101, 0, 1, N'051 352 024', N'255       ', 1, N'Kujundžič Vasja, mobilna številka', 1, 29, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (103, 0, 1, N'041 447 394', N'          ', 1, N'Dimec Andrej, tablica Samsung', 3, 1, -99, N'', 0, 2)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (104, 0, 1, N'051 694 489', N'256       ', 1, N'Hojs Matejko, mobilna številka', 1, 30, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (105, 0, 1, N'051 694 905', N'258       ', 1, N'Bračič Janez, mobilna številka', 1, 31, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (106, 0, 1, N'051 694 901', N'          ', 1, N'Potisk Dani, mobilna številka', 1, 32, -99, N'', 1, -99)
GO
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (107, 0, 1, N'031 384 286', N'259       ', 1, N'Šenekar Nina, mobilna številka', 1, 33, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (108, 0, 1, N'031 711 792', N'260       ', 1, N'Vaupotič Boštjan, mobilna številka', 1, 3, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (109, 0, 1, N'051 241 695', N'          ', 1, N'Popis vodomerov 2 (SM 12)
', 4, -99, -99, N'', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (110, 0, 1, N'051 241 575', N'          ', 1, N'Dežurna številka za prevezave
', 4, -99, -99, N'Sem se prevezujejo izbire z avtomatskega odzivnika 070 17 27', 0, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (111, 0, 1, N'041 479 448', N'261       ', 1, N'Šoštarič Matjaž, mobilna številka', 1, 34, -99, N'', 1, -99)
INSERT [dbo].[Tbl_Telefonske] ([Id], [Skupina], [rb_mobilna], [Stevilka], [Mpo], [Aktivna], [Opis], [rb_oseba], [Oseba], [Objekt], [Opomba], [Imenik], [sm]) VALUES (114, 0, 2, N'02 5644 800', N'          ', 1, N'Centrala', 4, -99, -99, N'', 1, -99)
SET IDENTITY_INSERT [dbo].[Tbl_Telefonske] OFF
