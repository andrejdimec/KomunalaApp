USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_na]    Script Date: 30. 12. 2020 13:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_na](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ob_uime] [nvarchar](50) NULL,
	[na_uime] [nvarchar](50) NULL,
	[povrsina] [float] NULL,
	[index_na] [nvarchar](50) NULL,
	[na_mid] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_na] ON 

INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (151, N'Gornja Radgona', N'Aženski Vrh', 640443.1875, NULL, N'10092639')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (152, N'Gornja Radgona', N'Črešnjevci', 4792764, NULL, N'10092698')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (153, N'Gornja Radgona', N'Gornja Radgona', 2977245, NULL, N'10092752')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (154, N'Gornja Radgona', N'Gornji Ivanjci', 2989937, NULL, N'10092779')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (155, N'Gornja Radgona', N'Hercegovščak', 1424007, NULL, N'10092817')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (156, N'Gornja Radgona', N'Ivanjski Vrh', 734321.375, NULL, N'10092841')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (157, N'Gornja Radgona', N'Ivanjševci ob Ščavnici', 1889935, NULL, N'10092850')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (158, N'Gornja Radgona', N'Ivanjševski Vrh', 2366310, NULL, N'10092868')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (159, N'Gornja Radgona', N'Kunova', 3106465, NULL, N'10092973')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (160, N'Gornja Radgona', N'Lastomerci', 2282941, NULL, N'10093007')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (161, N'Gornja Radgona', N'Lokavci', 2748898, NULL, N'10093023')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (162, N'Gornja Radgona', N'Lomanoše', 2593592, NULL, N'10093031')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (163, N'Gornja Radgona', N'Mele', 2305725, NULL, N'10093082')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (164, N'Gornja Radgona', N'Negova', 4711594, NULL, N'10093147')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (165, N'Gornja Radgona', N'Norički Vrh', 536830.375, NULL, N'10093155')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (166, N'Gornja Radgona', N'Očeslavci', 3122225, NULL, N'10093171')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (167, N'Gornja Radgona', N'Orehovci', 1356337, NULL, N'10093198')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (168, N'Gornja Radgona', N'Orehovski Vrh', 1772588, NULL, N'10093201')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (169, N'Gornja Radgona', N'Plitvički Vrh', 1701938, NULL, N'10093236')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (170, N'Gornja Radgona', N'Podgrad', 1522287, NULL, N'10093252')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (171, N'Gornja Radgona', N'Police', 3997987, NULL, N'10093287')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (172, N'Gornja Radgona', N'Ptujska Cesta', 1895176, NULL, N'10093295')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (173, N'Gornja Radgona', N'Radvenci', 2745147, NULL, N'10093333')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (174, N'Gornja Radgona', N'Rodmošci', 1296376, NULL, N'10093350')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (175, N'Gornja Radgona', N'Spodnja Ščavnica', 8035250, NULL, N'10093414')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (176, N'Gornja Radgona', N'Spodnji Ivanjci', 3162564, NULL, N'10093449')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (177, N'Gornja Radgona', N'Stavešinci', 1410712, NULL, N'10093481')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (178, N'Gornja Radgona', N'Stavešinski Vrh', 2035453, NULL, N'10093490')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (179, N'Gornja Radgona', N'Zagajski Vrh', 1697874, NULL, N'10093597')
INSERT [dbo].[tbl_na] ([Id], [ob_uime], [na_uime], [povrsina], [index_na], [na_mid]) VALUES (180, N'Gornja Radgona', N'Zbigovci', 2748987, NULL, N'10093619')
SET IDENTITY_INSERT [dbo].[tbl_na] OFF
