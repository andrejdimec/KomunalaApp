USE [Komunala_DB_test]
GO
/****** Object:  Table [dbo].[tbl_aglo]    Script Date: 18.03.2021 14:41:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_aglo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[id_aglo] [nvarchar](10) NULL,
	[ime_aglo] [nvarchar](50) NULL,
	[id_aglo2] [nvarchar](10) NULL,
	[ime_aglo2] [nvarchar](50) NULL,
	[tip_aglo] [nchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_aglo] ON 

INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10759, N'3168', N'Negova 2019', N'', N'', N'kan')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10760, N'50158', N'Spodnja Ščavnica 2019', N'', N'', N'kan')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10761, N'3351', N'Lomanoše 2019', N'', N'', N'kan')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10762, N'3064', N'Gornja Radgona 2019', N'', N'', N'kan')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10763, N'3046', N'SPODNJI IVANJCI', N'3046', N'SPODNJI IVANJCI
', N'vod')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10764, N'3062', N'OČESLAVCI', N'3062', N'OČESLAVCI
', N'vod')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10765, N'3168', N'NEGOVA', N'3168', N'NEGOVA
', N'vod')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10766, N'3017', N'IVANJŠEVCI OB ŠČAVNICI', N'3017', N'IVANJŠEVCI OB ŠČAVNICI
', N'vod')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10767, N'3064', N'ČREŠNJEVCI', N'3064', N'ČREŠNJEVCI
', N'vod')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10768, N'3309', N'SPODNJA ŠČAVNICA', N'3309', N'SPODNJA ŠČAVNICA
', N'vod')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10769, N'3081', N'MELE', N'3081', N'MELE
', N'vod')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10770, N'3064', N'ČREŠNJEVCI', N'50122', N'Črešnjevci1
', N'vod')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10771, N'3064', N'ČREŠNJEVCI', N'50123', N'Črešnjevci2
', N'vod')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10772, N'3351', N'LOMANOŠE', N'3351', N'LOMANOŠE
', N'vod')
INSERT [dbo].[tbl_aglo] ([Id], [id_aglo], [ime_aglo], [id_aglo2], [ime_aglo2], [tip_aglo]) VALUES (10773, N'3028', N'PODGRAD', N'3028', N'PODGRAD
', N'vod')
SET IDENTITY_INSERT [dbo].[tbl_aglo] OFF
