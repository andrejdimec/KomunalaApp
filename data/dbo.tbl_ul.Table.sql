USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_ul]    Script Date: 28. 02. 2021 21:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ul](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ul_mid] [nvarchar](50) NULL,
	[ob_uime] [nvarchar](50) NULL,
	[na_uime] [nvarchar](50) NULL,
	[ul_uime] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_ul] ON 

INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2754, N'16184748', N'Gornja Radgona', N'Gornja Radgona', N'Delavska pot')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2755, N'16184799', N'Gornja Radgona', N'Gornja Radgona', N'Kerenčičeva ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2756, N'16184845', N'Gornja Radgona', N'Gornja Radgona', N'Mariborska cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2757, N'16184888', N'Gornja Radgona', N'Gornja Radgona', N'Pokopališka cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2758, N'16184926', N'Gornja Radgona', N'Gornja Radgona', N'Trate')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2759, N'16184977', N'Gornja Radgona', N'Gornja Radgona', N'Vrtna ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2760, N'16185027', N'Gornja Radgona', N'Gornja Radgona', N'Dajnkova ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2761, N'16185060', N'Gornja Radgona', N'Gornja Radgona', N'Ilirska ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2762, N'16185108', N'Gornja Radgona', N'Gornja Radgona', N'Mala ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2763, N'16185159', N'Gornja Radgona', N'Gornja Radgona', N'Ob progi')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2764, N'16185191', N'Gornja Radgona', N'Gornja Radgona', N'Prečna ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2765, N'16185230', N'Gornja Radgona', N'Gornja Radgona', N'Strma ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2766, N'16185272', N'Gornja Radgona', N'Gornja Radgona', N'Ulica Moše Pijade')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2767, N'16184721', N'Gornja Radgona', N'Gornja Radgona', N'Cankarjeva cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2768, N'16184764', N'Gornja Radgona', N'Gornja Radgona', N'Gubčeva cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2769, N'16184829', N'Gornja Radgona', N'Gornja Radgona', N'Ljutomerska cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2770, N'16184861', N'Gornja Radgona', N'Gornja Radgona', N'Partizanska cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2771, N'16184900', N'Gornja Radgona', N'Gornja Radgona', N'Simoničev breg')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2772, N'16184942', N'Gornja Radgona', N'Gornja Radgona', N'Ulica Silvire Tomassini')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2773, N'16184993', N'Gornja Radgona', N'Gornja Radgona', N'Cesta na Stadion')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2774, N'16185043', N'Gornja Radgona', N'Gornja Radgona', N'Gorkega ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2775, N'16185086', N'Gornja Radgona', N'Gornja Radgona', N'Kocljeva ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2776, N'16185124', N'Gornja Radgona', N'Gornja Radgona', N'Mladinska ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2777, N'16185175', N'Gornja Radgona', N'Gornja Radgona', N'Polička cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2778, N'16185213', N'Gornja Radgona', N'Gornja Radgona', N'Prvomajska ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2779, N'16185256', N'Gornja Radgona', N'Gornja Radgona', N'Trubarjeva ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2780, N'16185302', N'Gornja Radgona', N'Gornja Radgona', N'Vodnikova ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2781, N'16184837', N'Gornja Radgona', N'Gornja Radgona', N'Maistrov trg')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2782, N'16184870', N'Gornja Radgona', N'Gornja Radgona', N'Pintaričeva cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2783, N'16184918', N'Gornja Radgona', N'Gornja Radgona', N'Šlebingerjev breg')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2784, N'16184969', N'Gornja Radgona', N'Gornja Radgona', N'Vrečova cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2785, N'16185019', N'Gornja Radgona', N'Gornja Radgona', N'Čremošnikova ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2786, N'16185051', N'Gornja Radgona', N'Gornja Radgona', N'Horvatova ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2787, N'16185094', N'Gornja Radgona', N'Gornja Radgona', N'Leninova ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2788, N'16185132', N'Gornja Radgona', N'Gornja Radgona', N'Ob potoku')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2789, N'16185183', N'Gornja Radgona', N'Gornja Radgona', N'Porabska ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2790, N'16185221', N'Gornja Radgona', N'Gornja Radgona', N'Rozmanova ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2791, N'16185264', N'Gornja Radgona', N'Gornja Radgona', N'Ulica Marije Rožman')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2792, N'16185329', N'Gornja Radgona', N'Gornja Radgona', N'Vrazova ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2793, N'16184713', N'Gornja Radgona', N'Gornja Radgona', N'Apaška cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2794, N'16184756', N'Gornja Radgona', N'Gornja Radgona', N'Grajska cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2795, N'16184802', N'Gornja Radgona', N'Gornja Radgona', N'Lackova ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2796, N'16184853', N'Gornja Radgona', N'Gornja Radgona', N'Panonska ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2797, N'16184896', N'Gornja Radgona', N'Gornja Radgona', N'Prešernova cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2798, N'16184934', N'Gornja Radgona', N'Gornja Radgona', N'Trg svobode')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2799, N'16184985', N'Gornja Radgona', N'Gornja Radgona', N'Vodovodna ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2800, N'16185035', N'Gornja Radgona', N'Gornja Radgona', N'Gasilska cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2801, N'16185078', N'Gornja Radgona', N'Gornja Radgona', N'Kajuhova ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2802, N'16185116', N'Gornja Radgona', N'Gornja Radgona', N'Miklošičeva ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2803, N'16185167', N'Gornja Radgona', N'Gornja Radgona', N'Pod gozdom')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2804, N'16185205', N'Gornja Radgona', N'Gornja Radgona', N'Prežihova ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2805, N'16185248', N'Gornja Radgona', N'Gornja Radgona', N'Trstenjakova ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2806, N'16185299', N'Gornja Radgona', N'Gornja Radgona', N'Vaupotičeva ulica')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2807, N'16184730', N'Gornja Radgona', N'Gornja Radgona', N'Ciril-Metodova cesta')
INSERT [dbo].[tbl_ul] ([Id], [ul_mid], [ob_uime], [na_uime], [ul_uime]) VALUES (2808, N'16184772', N'Gornja Radgona', N'Gornja Radgona', N'Jurkovičeva ulica')
SET IDENTITY_INSERT [dbo].[tbl_ul] OFF
