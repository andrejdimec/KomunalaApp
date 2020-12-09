USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_hs]    Script Date: 9. 12. 2020 21:13:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_hs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ENOTA] [nvarchar](50) NULL,
	[HS_MID] [nvarchar](50) NULL,
	[HS] [nvarchar](50) NULL,
	[HD] [nvarchar](50) NULL,
	[LABELA] [nvarchar](50) NULL,
	[ULMID] [nvarchar](50) NULL,
	[NA_MID] [nvarchar](50) NULL,
	[OB_MID] [nvarchar](50) NULL,
	[PT_MID] [nvarchar](50) NULL,
	[PO_MID] [nvarchar](50) NULL,
	[X] [nvarchar](50) NULL,
	[Y] [nvarchar](50) NULL,
	[index_hs] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_hs] ON 

INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139201, N'HS', N'19138828', N'21', N'E', N'21E', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167892
', N'570983', N'spodnjaščavnica21e')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139202, N'HS', N'19129730', N'41', N' ', N'41', N'16184829', N'10092752', N'11026826', N'21429392', N'19129241', N'169556
', N'576954', N'ljutomerskacesta41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139203, N'HS', N'11612261', N'27', N' ', N'27', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163072
', N'572141', N'negova27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139204, N'HS', N'11606172', N'9', N'B', N'9B', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164324
', N'572305', N'lokavci9b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139205, N'HS', N'19134636', N'17', N'A', N'17A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165426
', N'572042', N'radvenci17a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139206, N'HS', N'19131823', N'22', N'A', N'22A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167844
', N'574917', N'zbigovci22a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139207, N'HS', N'19133265', N'18', N'A', N'18A', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171201
', N'576262', N'vrtnaulica18a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139208, N'HS', N'11620400', N'52', N' ', N'52', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169943
', N'573966', N'police52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139209, N'HS', N'19131769', N'25', N' ', N'25', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'169657
', N'576384', N'mariborskacesta25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139210, N'HS', N'19131742', N'29', N' ', N'29', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171010
', N'574276', N'podgrad29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139211, N'HS', N'11609481', N'18', N' ', N'18', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168778
', N'578492', N'mele18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139212, N'HS', N'11620191', N'32', N' ', N'32', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170153
', N'574444', N'police32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139213, N'HS', N'19131530', N'10', N' ', N'10', N'16184829', N'10092752', N'11026826', N'21429392', N'10253098', N'169999
', N'576532', N'ljutomerskacesta10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139214, N'HS', N'11621830', N'32', N'A', N'32A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165552
', N'576159', N'ptujskacesta32a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139215, N'HS', N'19129551', N'7', N'A', N'7A', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166497
', N'574533', N'rodmošci7a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139216, N'HS', N'19129748', N'47', N'A', N'47A', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171223
', N'573685', N'podgrad47a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139217, N'HS', N'19129870', N'227', N'C', N'227C', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169294
', N'575740', N'črešnjevci227c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139218, N'HS', N'19129489', N'45', N' ', N'45', N'16184829', N'10092752', N'11026826', N'21429392', N'19129241', N'169528
', N'576889', N'ljutomerskacesta45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139219, N'HS', N'11596363', N'42', N' ', N'42', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170390
', N'573817', N'hercegovščak42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139220, N'HS', N'11599168', N'40', N' ', N'40', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165312
', N'574437', N'ivanjševskivrh40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139221, N'HS', N'11599176', N'41', N'A', N'41A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165405
', N'574505', N'ivanjševskivrh41a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139222, N'HS', N'11599184', N'41', N' ', N'41', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165418
', N'574510', N'ivanjševskivrh41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139223, N'HS', N'11599192', N'42', N'A', N'42A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165475
', N'574597', N'ivanjševskivrh42a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139224, N'HS', N'11598374', N'14', N'A', N'14A', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161614
', N'574308', N'ivanjskivrh14a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139225, N'HS', N'11598471', N'22', N' ', N'22', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161003
', N'573967', N'ivanjskivrh22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139226, N'HS', N'11598528', N'1', N'A', N'1A', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'165100
', N'573714', N'ivanjševciobščavnici1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139227, N'HS', N'11598609', N'7', N' ', N'7', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164539
', N'574136', N'ivanjševciobščavnici7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139228, N'HS', N'11598617', N'8', N' ', N'8', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164548
', N'574187', N'ivanjševciobščavnici8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139229, N'HS', N'11598714', N'17', N' ', N'17', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164443
', N'574534', N'ivanjševciobščavnici17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139230, N'HS', N'11598811', N'9', N' ', N'9', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164769
', N'574394', N'ivanjševskivrh9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139231, N'HS', N'11598951', N'22', N' ', N'22', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165133
', N'574344', N'ivanjševskivrh22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139232, N'HS', N'11598986', N'25', N'A', N'25A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165226
', N'574342', N'ivanjševskivrh25a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139233, N'HS', N'11599087', N'32', N' ', N'32', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165232
', N'573898', N'ivanjševskivrh32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139234, N'HS', N'11599125', N'35', N' ', N'35', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165389
', N'574285', N'ivanjševskivrh35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139235, N'HS', N'11599133', N'36', N' ', N'36', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165393
', N'574289', N'ivanjševskivrh36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139236, N'HS', N'11599249', N'44', N'A', N'44A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165435
', N'574781', N'ivanjševskivrh44a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139237, N'HS', N'11599281', N'45', N'A', N'45A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165350
', N'574784', N'ivanjševskivrh45a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139238, N'HS', N'11599389', N'54', N' ', N'54', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164612
', N'575058', N'ivanjševskivrh54')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139239, N'HS', N'11599451', N'60', N' ', N'60', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165475
', N'574990', N'ivanjševskivrh60')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139240, N'HS', N'11599591', N'68', N' ', N'68', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'166166
', N'575072', N'ivanjševskivrh68')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139241, N'HS', N'19137031', N'1', N'Z', N'1Z', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170777
', N'576165', N'prešernovacesta1z')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139242, N'HS', N'19136078', N'10', N'C', N'10C', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'165940
', N'573251', N'lastomerci10c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139243, N'HS', N'11587968', N'4', N' ', N'4', N'16184799', N'10092752', N'11026826', N'21429392', N'10253284', N'171366
', N'576001', N'kerenčičevaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139244, N'HS', N'11587534', N'18', N' ', N'18', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171345
', N'575755', N'grajskacesta18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139245, N'HS', N'11587640', N'28', N' ', N'28', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171447
', N'575503', N'grajskacesta28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139246, N'HS', N'11588395', N'21', N' ', N'21', N'16184802', N'10092752', N'11026826', N'21429392', N'10253276', N'171370
', N'576083', N'lackovaulica21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139247, N'HS', N'11588867', N'7', N' ', N'7', N'16184837', N'10092752', N'11026826', N'21429392', N'10253268', N'171203
', N'576065', N'maistrovtrg7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139248, N'HS', N'11588948', N'12', N' ', N'12', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'170017
', N'576359', N'mariborskacesta12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139249, N'HS', N'11590055', N'2', N' ', N'2', N'16184888', N'10092752', N'11026826', N'21429392', N'10252679', N'170924
', N'576050', N'pokopališkacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139250, N'HS', N'11590110', N'12', N' ', N'12', N'16184888', N'10092752', N'11026826', N'21429392', N'10252679', N'170708
', N'575916', N'pokopališkacesta12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139251, N'HS', N'11590152', N'4', N' ', N'4', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170741
', N'576174', N'prešernovacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139252, N'HS', N'11592686', N'2', N' ', N'2', N'16185124', N'10092752', N'11026826', N'21429392', N'10253055', N'170889
', N'576335', N'mladinskaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139253, N'HS', N'11592902', N'6', N' ', N'6', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169835
', N'576813', N'obprogi6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139254, N'HS', N'11593224', N'2', N'A', N'2A', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170550
', N'576013', N'prežihovaulica2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139255, N'HS', N'11593445', N'2', N' ', N'2', N'16185221', N'10092752', N'11026826', N'21429392', N'10252628', N'171034
', N'575768', N'rozmanovaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139256, N'HS', N'11593526', N'7', N' ', N'7', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171140
', N'575433', N'strmaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139257, N'HS', N'11593534', N'8', N' ', N'8', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171168
', N'575405', N'strmaulica8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139258, N'HS', N'11593984', N'4', N' ', N'4', N'16185302', N'10092752', N'11026826', N'21429392', N'10257212', N'170279
', N'576561', N'vodnikovaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139259, N'HS', N'11594204', N'12', N' ', N'12', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163202
', N'574088', N'gornjiivanjci12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139260, N'HS', N'11594212', N'13', N' ', N'13', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163355
', N'574135', N'gornjiivanjci13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139261, N'HS', N'11594301', N'21', N' ', N'21', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'162756
', N'574677', N'gornjiivanjci21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139262, N'HS', N'11594336', N'24', N' ', N'24', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'161724
', N'574426', N'gornjiivanjci24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139263, N'HS', N'11634788', N'7', N' ', N'7', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'169054
', N'569948', N'spodnjaščavnica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139264, N'HS', N'11634818', N'10', N'A', N'10A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168708
', N'569992', N'spodnjaščavnica10a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139265, N'HS', N'11634893', N'15', N'A', N'15A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168920
', N'571531', N'spodnjaščavnica15a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139266, N'HS', N'11634915', N'16', N' ', N'16', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168880
', N'571515', N'spodnjaščavnica16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139267, N'HS', N'11634974', N'19', N'B', N'19B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167927
', N'571251', N'spodnjaščavnica19b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139268, N'HS', N'11635016', N'21', N'A', N'21A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167914
', N'571051', N'spodnjaščavnica21a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139269, N'HS', N'11635059', N'22', N' ', N'22', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167854
', N'571290', N'spodnjaščavnica22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139270, N'HS', N'11635164', N'33', N' ', N'33', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168209
', N'571896', N'spodnjaščavnica33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139271, N'HS', N'11635288', N'40', N' ', N'40', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167685
', N'571976', N'spodnjaščavnica40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139272, N'HS', N'11635300', N'42', N'A', N'42A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167901
', N'572011', N'spodnjaščavnica42a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139273, N'HS', N'11635377', N'44', N'B', N'44B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167654
', N'572334', N'spodnjaščavnica44b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139274, N'HS', N'11635415', N'45', N'A', N'45A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167856
', N'572215', N'spodnjaščavnica45a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139275, N'HS', N'11635512', N'50', N' ', N'50', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167819
', N'572664', N'spodnjaščavnica50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139276, N'HS', N'11635601', N'57', N'B', N'57B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167117
', N'572313', N'spodnjaščavnica57b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139277, N'HS', N'11635865', N'77', N' ', N'77', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167629
', N'570727', N'spodnjaščavnica77')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139278, N'HS', N'11635873', N'78', N' ', N'78', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167375
', N'570456', N'spodnjaščavnica78')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139279, N'HS', N'11635903', N'81', N'B', N'81B', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167911
', N'570560', N'spodnjaščavnica81b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139280, N'HS', N'11635954', N'85', N' ', N'85', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168001
', N'569508', N'spodnjaščavnica85')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139281, N'HS', N'19131386', N'10', N'A', N'10A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162637
', N'576979', N'očeslavci10a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139282, N'HS', N'19130398', N'7', N'A', N'7A', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169250
', N'572038', N'plitvičkivrh7a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139283, N'HS', N'11588352', N'18', N' ', N'18', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171400
', N'576187', N'lackovaulica18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139284, N'HS', N'19129942', N'11', N' ', N'11', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165100
', N'571731', N'radvenci11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139285, N'HS', N'11620094', N'23', N' ', N'23', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170014
', N'574869', N'police23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139286, N'HS', N'11636632', N'19', N' ', N'19', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161104
', N'575525', N'spodnjiivanjci19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139287, N'HS', N'11636659', N'20', N' ', N'20', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161190
', N'575398', N'spodnjiivanjci20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139288, N'HS', N'11636683', N'23', N' ', N'23', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'160894
', N'575076', N'spodnjiivanjci23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139289, N'HS', N'11636713', N'25', N' ', N'25', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161029
', N'576327', N'spodnjiivanjci25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139290, N'HS', N'11638112', N'7', N' ', N'7', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163145
', N'575399', N'stavešinci7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139291, N'HS', N'11638287', N'4', N' ', N'4', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'165067
', N'576158', N'stavešinskivrh4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139292, N'HS', N'11638295', N'5', N' ', N'5', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164998
', N'576164', N'stavešinskivrh5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139293, N'HS', N'11638317', N'7', N' ', N'7', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164976
', N'576048', N'stavešinskivrh7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139294, N'HS', N'11638325', N'8', N' ', N'8', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164931
', N'576139', N'stavešinskivrh8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139295, N'HS', N'11638465', N'20', N'A', N'20A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164509
', N'575782', N'stavešinskivrh20a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139296, N'HS', N'11638473', N'20', N'B', N'20B', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164487
', N'575780', N'stavešinskivrh20b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139297, N'HS', N'11638546', N'26', N' ', N'26', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164462
', N'576059', N'stavešinskivrh26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139298, N'HS', N'11638597', N'30', N'A', N'30A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164091
', N'576121', N'stavešinskivrh30a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139299, N'HS', N'11638627', N'31', N'A', N'31A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164183
', N'576151', N'stavešinskivrh31a')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139300, N'HS', N'11638643', N'32', N' ', N'32', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164317
', N'575958', N'stavešinskivrh32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139301, N'HS', N'11638686', N'36', N' ', N'36', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164149
', N'575980', N'stavešinskivrh36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139302, N'HS', N'11638694', N'37', N' ', N'37', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164143
', N'575956', N'stavešinskivrh37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139303, N'HS', N'11638716', N'39', N'A', N'39A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164043
', N'576069', N'stavešinskivrh39a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139304, N'HS', N'11642802', N'2', N' ', N'2', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166926
', N'570221', N'zagajskivrh2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139305, N'HS', N'11642870', N'8', N'A', N'8A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166777
', N'569770', N'zagajskivrh8a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139306, N'HS', N'11642900', N'10', N' ', N'10', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166806
', N'569754', N'zagajskivrh10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139307, N'HS', N'11642926', N'12', N'A', N'12A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166881
', N'569707', N'zagajskivrh12a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139308, N'HS', N'11642942', N'13', N'A', N'13A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166995
', N'569589', N'zagajskivrh13a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139309, N'HS', N'11643230', N'37', N' ', N'37', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166935
', N'569253', N'zagajskivrh37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139310, N'HS', N'11643329', N'42', N' ', N'42', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166812
', N'569076', N'zagajskivrh42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139311, N'HS', N'11643574', N'18', N' ', N'18', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167397
', N'574941', N'zbigovci18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139312, N'HS', N'11643779', N'32', N' ', N'32', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167182
', N'574324', N'zbigovci32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139313, N'HS', N'11643795', N'34', N' ', N'34', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167073
', N'574241', N'zbigovci34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139314, N'HS', N'11643868', N'40', N'A', N'40A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166940
', N'574131', N'zbigovci40a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139315, N'HS', N'11643949', N'48', N' ', N'48', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166745
', N'573960', N'zbigovci48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139316, N'HS', N'11643213', N'36', N'A', N'36A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166992
', N'569235', N'zagajskivrh36a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139317, N'HS', N'11588328', N'15', N' ', N'15', N'16184802', N'10092752', N'11026826', N'21429392', N'10253225', N'171291
', N'576237', N'lackovaulica15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139318, N'HS', N'11606601', N'43', N'A', N'43A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'163833
', N'571042', N'lokavci43a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139319, N'HS', N'11606709', N'5', N'C', N'5C', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170667
', N'573592', N'lomanoše5c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139320, N'HS', N'11606717', N'5', N' ', N'5', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170704
', N'573653', N'lomanoše5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139321, N'HS', N'11606903', N'12', N'B', N'12B', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170316
', N'573257', N'lomanoše12b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139322, N'HS', N'11607284', N'40', N'B', N'40B', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169979
', N'572577', N'lomanoše40b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139323, N'HS', N'11607411', N'47', N'A', N'47A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169020
', N'572068', N'lomanoše47a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139324, N'HS', N'11607462', N'50', N' ', N'50', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169027
', N'572606', N'lomanoše50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139325, N'HS', N'11643566', N'17', N' ', N'17', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167340
', N'574982', N'zbigovci17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139326, N'HS', N'11604099', N'4', N' ', N'4', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161887
', N'572198', N'kunova4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139327, N'HS', N'11604102', N'5', N' ', N'5', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161715
', N'572649', N'kunova5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139328, N'HS', N'11604200', N'14', N' ', N'14', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161330
', N'572796', N'kunova14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139329, N'HS', N'11604463', N'35', N'A', N'35A', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162521
', N'573273', N'kunova35a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139330, N'HS', N'11604480', N'36', N'A', N'36A', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162486
', N'573428', N'kunova36a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139331, N'HS', N'11605133', N'5', N' ', N'5', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166392
', N'573669', N'lastomerci5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139332, N'HS', N'11605184', N'11', N'A', N'11A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166324
', N'573311', N'lastomerci11a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139333, N'HS', N'11605249', N'14', N' ', N'14', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'165887
', N'572966', N'lastomerci14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139334, N'HS', N'11605478', N'29', N' ', N'29', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166739
', N'573386', N'lastomerci29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139335, N'HS', N'11635989', N'87', N' ', N'87', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168009
', N'569257', N'spodnjaščavnica87')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139336, N'HS', N'11636055', N'93', N' ', N'93', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167580
', N'568303', N'spodnjaščavnica93')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139337, N'HS', N'11636080', N'96', N'A', N'96A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167717
', N'568950', N'spodnjaščavnica96a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139338, N'HS', N'11636136', N'99', N' ', N'99', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'166971
', N'568839', N'spodnjaščavnica99')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139339, N'HS', N'11636527', N'10', N' ', N'10', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161711
', N'575568', N'spodnjiivanjci10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139340, N'HS', N'11636560', N'14', N'A', N'14A', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161524
', N'575560', N'spodnjiivanjci14a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139341, N'HS', N'11606083', N'2', N' ', N'2', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'163808
', N'572297', N'lokavci2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139342, N'HS', N'11606113', N'4', N' ', N'4', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164098
', N'572176', N'lokavci4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139343, N'HS', N'11606318', N'18', N'A', N'18A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164350
', N'570859', N'lokavci18a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139344, N'HS', N'11609724', N'30', N' ', N'30', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168774
', N'578285', N'mele30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139345, N'HS', N'11609732', N'31', N'A', N'31A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168810
', N'578273', N'mele31a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139346, N'HS', N'11609759', N'31', N' ', N'31', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168822
', N'578253', N'mele31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139347, N'HS', N'11609783', N'37', N' ', N'37', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168726
', N'578236', N'mele37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139348, N'HS', N'11609791', N'38', N' ', N'38', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168749
', N'578231', N'mele38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139349, N'HS', N'11609805', N'39', N' ', N'39', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168850
', N'578201', N'mele39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139350, N'HS', N'11609821', N'41', N' ', N'41', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168900
', N'578195', N'mele41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139351, N'HS', N'11609848', N'43', N' ', N'43', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168920
', N'578180', N'mele43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139352, N'HS', N'16551279', N'23', N'A', N'23A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168788
', N'578418', N'mele23a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139353, N'HS', N'11609309', N'1', N'A', N'1A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'169119
', N'577550', N'mele1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139354, N'HS', N'11609317', N'1', N' ', N'1', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'169126
', N'577514', N'mele1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139355, N'HS', N'11609333', N'4', N' ', N'4', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168950
', N'578247', N'mele4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139356, N'HS', N'11609368', N'7', N' ', N'7', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'169003
', N'578446', N'mele7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139357, N'HS', N'11609384', N'10', N' ', N'10', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168863
', N'578398', N'mele10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139358, N'HS', N'11609406', N'13', N' ', N'13', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168849
', N'578440', N'mele13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139359, N'HS', N'11609414', N'14', N' ', N'14', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168834
', N'578470', N'mele14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139360, N'HS', N'11609422', N'15', N' ', N'15', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168822
', N'578488', N'mele15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139361, N'HS', N'11609473', N'18', N'A', N'18A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168757
', N'578484', N'mele18a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139362, N'HS', N'11609490', N'19', N'A', N'19A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168661
', N'578527', N'mele19a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139363, N'HS', N'11609503', N'19', N' ', N'19', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168693
', N'578559', N'mele19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139364, N'HS', N'11609511', N'20', N'A', N'20A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168666
', N'578418', N'mele20a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139365, N'HS', N'11609520', N'20', N'B', N'20B', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168640
', N'578398', N'mele20b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139366, N'HS', N'11609538', N'20', N'C', N'20C', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168620
', N'578412', N'mele20c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139367, N'HS', N'11609546', N'20', N'D', N'20D', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168609
', N'578431', N'mele20d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139368, N'HS', N'11609554', N'20', N' ', N'20', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168697
', N'578451', N'mele20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139369, N'HS', N'11609562', N'21', N'A', N'21A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168694
', N'578323', N'mele21a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139370, N'HS', N'11609589', N'21', N'B', N'21B', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168715
', N'578407', N'mele21b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139371, N'HS', N'11609597', N'21', N'C', N'21C', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168749
', N'578443', N'mele21c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139372, N'HS', N'11609619', N'21', N' ', N'21', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168659
', N'578329', N'mele21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139373, N'HS', N'19130240', N'19', N'A', N'19A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170128
', N'573056', N'lomanoše19a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139374, N'HS', N'19130193', N'45', N'B', N'45B', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162654
', N'571685', N'negova45b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139375, N'HS', N'19130304', N'47', N' ', N'47', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166819
', N'574001', N'zbigovci47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139376, N'HS', N'19130266', N'47', N' ', N'47', N'16184829', N'10092752', N'11026826', N'21429392', N'19129241', N'169437
', N'576976', N'ljutomerskacesta47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139377, N'HS', N'11636446', N'5', N' ', N'5', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161680
', N'575392', N'spodnjiivanjci5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139378, N'HS', N'19131122', N'2', N'B', N'2B', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170542
', N'575975', N'prežihovaulica2b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139379, N'HS', N'19130614', N'44', N'C', N'44C', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170525
', N'574296', N'hercegovščak44c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139380, N'HS', N'11638929', N'51', N'B', N'51B', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163689
', N'576072', N'stavešinskivrh51b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139381, N'HS', N'11638864', N'50', N'A', N'50A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163709
', N'576059', N'stavešinskivrh50a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139382, N'HS', N'11614710', N'51', N' ', N'51', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163738
', N'577739', N'očeslavci51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139383, N'HS', N'11599516', N'64', N'C', N'64C', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165600
', N'575026', N'ivanjševskivrh64c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139384, N'HS', N'11620272', N'40', N' ', N'40', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169912
', N'574216', N'police40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139385, N'HS', N'11599559', N'65', N'B', N'65B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165877
', N'575064', N'ivanjševskivrh65b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139386, N'HS', N'11620507', N'61', N' ', N'61', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169976
', N'573754', N'police61')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139387, N'HS', N'19129110', N'8', N'A', N'8A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164744
', N'574404', N'ivanjševskivrh8a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139388, N'HS', N'11583644', N'164', N' ', N'164', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168439
', N'575767', N'črešnjevci164')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139389, N'HS', N'19132358', N'29', N' ', N'29', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170323
', N'574474', N'police29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139390, N'HS', N'19132315', N'28', N'C', N'28C', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169430
', N'577072', N'ljutomerskacesta28c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139391, N'HS', N'11599494', N'64', N'A', N'64A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165702
', N'575002', N'ivanjševskivrh64a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139392, N'HS', N'11599532', N'65', N'A', N'65A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165837
', N'575041', N'ivanjševskivrh65a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139393, N'HS', N'11583555', N'155', N' ', N'155', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168345
', N'575923', N'črešnjevci155')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139394, N'HS', N'11620558', N'66', N' ', N'66', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169833
', N'573480', N'police66')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139395, N'HS', N'11614680', N'48', N' ', N'48', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163655
', N'577725', N'očeslavci48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139396, N'HS', N'11583512', N'153', N'A', N'153A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168363
', N'575928', N'črešnjevci153a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139397, N'HS', N'11583652', N'165', N' ', N'165', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168447
', N'575782', N'črešnjevci165')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139398, N'HS', N'11614540', N'40', N'A', N'40A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163267
', N'577677', N'očeslavci40a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139399, N'HS', N'11614531', N'39', N' ', N'39', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163268
', N'577724', N'očeslavci39')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139400, N'HS', N'11599010', N'29', N'A', N'29A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165230
', N'574029', N'ivanjševskivrh29a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139401, N'HS', N'11599028', N'29', N' ', N'29', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165253
', N'574083', N'ivanjševskivrh29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139402, N'HS', N'11583636', N'163', N' ', N'163', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168387
', N'575810', N'črešnjevci163')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139403, N'HS', N'11614701', N'50', N' ', N'50', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163706
', N'577732', N'očeslavci50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139404, N'HS', N'11583628', N'162', N' ', N'162', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168399
', N'575826', N'črešnjevci162')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139405, N'HS', N'19132056', N'12', N' ', N'12', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164454
', N'571983', N'lokavci12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139406, N'HS', N'11638902', N'51', N'A', N'51A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163682
', N'576084', N'stavešinskivrh51a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139407, N'HS', N'19132102', N'39', N'B', N'39B', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163296
', N'577719', N'očeslavci39b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139408, N'HS', N'19132170', N'32', N'A', N'32A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165204
', N'573926', N'ivanjševskivrh32a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139409, N'HS', N'16394998', N'11', N'B', N'11B', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166146
', N'574278', N'rodmošci11b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139410, N'HS', N'11638872', N'50', N'B', N'50B', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163701
', N'576067', N'stavešinskivrh50b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139411, N'HS', N'11629849', N'2', N' ', N'2', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166975
', N'574993', N'rodmošci2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139412, N'HS', N'19133028', N'21', N' ', N'21', N'16185086', N'10092752', N'11026826', N'21429392', N'10253047', N'170998
', N'576430', N'kocljevaulica21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139413, N'HS', N'19132366', N'29', N' ', N'29', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169872
', N'575742', N'noričkivrh29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139414, N'HS', N'11644147', N'65', N' ', N'65', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167364
', N'573713', N'zbigovci65')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139415, N'HS', N'11629334', N'35', N' ', N'35', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164319
', N'573046', N'radvenci35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139416, N'HS', N'19128334', N'45', N'A', N'45A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166465
', N'576872', N'ptujskacesta45a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139417, N'HS', N'11620892', N'96', N' ', N'96', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169311
', N'573942', N'police96')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139418, N'HS', N'19119777', N'33', N' ', N'33', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164257
', N'575972', N'stavešinskivrh33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139419, N'HS', N'19119807', N'34', N'A', N'34A', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169300
', N'577568', N'ljutomerskacesta34a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139420, N'HS', N'19119858', N'4', N'A', N'4A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166428
', N'573700', N'lastomerci4a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139421, N'HS', N'19120112', N'152', N'A', N'152A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168476
', N'575930', N'črešnjevci152a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139422, N'HS', N'19120970', N'20', N'A', N'20A', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168843
', N'572090', N'plitvičkivrh20a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139423, N'HS', N'19120988', N'12', N'A', N'12A', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'166897
', N'576529', N'orehovci12a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139424, N'HS', N'19122123', N'232', N'A', N'232A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169220
', N'575843', N'črešnjevci232a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139425, N'HS', N'19122247', N'69', N' ', N'69', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168712
', N'576323', N'črešnjevci69')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139426, N'HS', N'19124649', N'5', N'A', N'5A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166355
', N'573630', N'lastomerci5a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139427, N'HS', N'19124690', N'94', N'A', N'94A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169294
', N'574045', N'police94a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139428, N'HS', N'19124860', N'25', N' ', N'25', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'161738
', N'574398', N'gornjiivanjci25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139429, N'HS', N'19125017', N'32', N'B', N'32B', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169157
', N'576245', N'črešnjevci32b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139430, N'HS', N'19125220', N'43', N'A', N'43A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163807
', N'575807', N'stavešinskivrh43a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139431, N'HS', N'19125700', N'30', N'A', N'30A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170317
', N'574854', N'hercegovščak30a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139432, N'HS', N'19127249', N'24', N'B', N'24B', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168703
', N'572035', N'plitvičkivrh24b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139433, N'HS', N'19127931', N'91', N'A', N'91A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163330
', N'570223', N'negova91a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139434, N'HS', N'11607454', N'49', N' ', N'49', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169433
', N'572800', N'lomanoše49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139435, N'HS', N'19132072', N'1', N'B', N'1B', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169599
', N'571810', N'plitvičkivrh1b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139436, N'HS', N'11615848', N'2', N' ', N'2', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167232
', N'577174', N'orehovci2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139437, N'HS', N'19133206', N'126', N'A', N'126A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164308
', N'570050', N'negova126a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139438, N'HS', N'11582052', N'9', N' ', N'9', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169439
', N'576210', N'črešnjevci9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139439, N'HS', N'19128407', N'70', N' ', N'70', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168697
', N'576287', N'črešnjevci70')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139440, N'HS', N'19128393', N'96', N'C', N'96C', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167689
', N'568954', N'spodnjaščavnica96c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139441, N'HS', N'11636098', N'96', N'B', N'96B', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167742
', N'568963', N'spodnjaščavnica96b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139442, N'HS', N'19128369', N'38', N'B', N'38B', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163232
', N'577758', N'očeslavci38b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139443, N'HS', N'19128547', N'66', N' ', N'66', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168773
', N'576359', N'črešnjevci66')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139444, N'HS', N'19117928', N'36', N' ', N'36', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169188
', N'577944', N'ljutomerskacesta36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139445, N'HS', N'19118045', N'40', N'A', N'40A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164480
', N'572502', N'radvenci40a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139446, N'HS', N'19118053', N'32', N'B', N'32B', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170473
', N'574781', N'hercegovščak32b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139447, N'HS', N'19118088', N'8', N'A', N'8A', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164515
', N'574161', N'ivanjševciobščavnici8a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139448, N'HS', N'19118134', N'65', N'C', N'65C', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167168
', N'573622', N'zbigovci65c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139449, N'HS', N'19118266', N'14', N'A', N'14A', N'16276049', N'10093171', N'11026826', N'21431745', N'19127222', N'163971
', N'576917', N'očeslavci14a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139450, N'HS', N'19118274', N'5', N'B', N'5B', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170682
', N'573608', N'lomanoše5b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139451, N'HS', N'19118347', N'7', N' ', N'7', N'16185043', N'10092752', N'11026826', N'21429392', N'10252628', N'171035
', N'575524', N'gorkegaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139452, N'HS', N'16354856', N'40', N'A', N'40A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164529
', N'570515', N'lokavci40a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139453, N'HS', N'16354953', N'12', N'A', N'12A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167032
', N'575340', N'zbigovci12a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139454, N'HS', N'11592732', N'9', N' ', N'9', N'16185124', N'10092752', N'11026826', N'21429392', N'19132820', N'170922
', N'576444', N'mladinskaulica9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139455, N'HS', N'11593135', N'8', N' ', N'8', N'16185183', N'10092752', N'11026826', N'21429392', N'19132820', N'170914
', N'576474', N'porabskaulica8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139456, N'HS', N'19124924', N'18', N'A', N'18A', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169792
', N'575844', N'noričkivrh18a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139457, N'HS', N'19125343', N'19', N'A', N'19A', N'16184829', N'10092752', N'11026826', N'21429392', N'19132897', N'169900
', N'576950', N'ljutomerskacesta19a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139458, N'HS', N'19130207', N'22', N' ', N'22', N'16184900', N'10092752', N'11026826', N'21429392', N'19132463', N'170969
', N'575820', N'simoničevbreg22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139459, N'HS', N'11591973', N'1', N'A', N'1A', N'16184993', N'10092752', N'11026826', N'21429392', N'19132528', N'170502
', N'576390', N'cestanastadion1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139460, N'HS', N'11586953', N'1', N' ', N'1', N'16184721', N'10092752', N'11026826', N'21429392', N'19132587', N'170349
', N'576336', N'cankarjevacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139461, N'HS', N'11586961', N'2', N' ', N'2', N'16184721', N'10092752', N'11026826', N'21429392', N'19132587', N'170368
', N'576343', N'cankarjevacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139462, N'HS', N'11587003', N'6', N' ', N'6', N'16184721', N'10092752', N'11026826', N'21429392', N'19132587', N'170346
', N'576280', N'cankarjevacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139463, N'HS', N'11589804', N'42', N' ', N'42', N'16184861', N'10092752', N'11026826', N'21429392', N'19132641', N'170357
', N'576399', N'partizanskacesta42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139464, N'HS', N'11589847', N'44', N' ', N'44', N'16184861', N'10092752', N'11026826', N'21429392', N'19132641', N'170342
', N'576409', N'partizanskacesta44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139465, N'HS', N'11589863', N'46', N' ', N'46', N'16184861', N'10092752', N'11026826', N'21429392', N'19132641', N'170311
', N'576422', N'partizanskacesta46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139466, N'HS', N'11592813', N'4', N' ', N'4', N'16185132', N'10092752', N'11026826', N'21429392', N'19132706', N'169564
', N'576456', N'obpotoku4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139467, N'HS', N'11592821', N'6', N' ', N'6', N'16185132', N'10092752', N'11026826', N'21429392', N'19132706', N'169596
', N'576517', N'obpotoku6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139468, N'HS', N'11592830', N'8', N' ', N'8', N'16185132', N'10092752', N'11026826', N'21429392', N'19132706', N'169609
', N'576545', N'obpotoku8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139469, N'HS', N'19129837', N'2', N'A', N'2A', N'16185132', N'10092752', N'11026826', N'21429392', N'19132706', N'169524
', N'576437', N'obpotoku2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139470, N'HS', N'19131238', N'12', N' ', N'12', N'16185132', N'10092752', N'11026826', N'21429392', N'19132706', N'169552
', N'576590', N'obpotoku12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139471, N'HS', N'11592449', N'4', N' ', N'4', N'16185086', N'10092752', N'11026826', N'21429392', N'19132765', N'170920
', N'576578', N'kocljevaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139472, N'HS', N'11592708', N'5', N' ', N'5', N'16185124', N'10092752', N'11026826', N'21429392', N'19132820', N'170886
', N'576419', N'mladinskaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139473, N'HS', N'11592716', N'7', N' ', N'7', N'16185124', N'10092752', N'11026826', N'21429392', N'19132820', N'170901
', N'576430', N'mladinskaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139474, N'HS', N'11593143', N'10', N' ', N'10', N'16185183', N'10092752', N'11026826', N'21429392', N'19132820', N'170906
', N'576488', N'porabskaulica10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139475, N'HS', N'11593151', N'12', N' ', N'12', N'16185183', N'10092752', N'11026826', N'21429392', N'19132820', N'170902
', N'576502', N'porabskaulica12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139476, N'HS', N'11588638', N'15', N' ', N'15', N'16184829', N'10092752', N'11026826', N'21429392', N'19132897', N'169914
', N'576893', N'ljutomerskacesta15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139477, N'HS', N'11588662', N'21', N' ', N'21', N'16184829', N'10092752', N'11026826', N'21429392', N'19132897', N'169885
', N'576964', N'ljutomerskacesta21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139478, N'HS', N'11588689', N'23', N' ', N'23', N'16184829', N'10092752', N'11026826', N'21429392', N'19132897', N'169842
', N'576972', N'ljutomerskacesta23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139479, N'HS', N'19131009', N'10', N'A', N'10A', N'16184969', N'10092752', N'11026826', N'21429392', N'19132595', N'170303
', N'576470', N'vrečovacesta10a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139480, N'HS', N'19138615', N'15', N' ', N'15', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169811
', N'576757', N'obprogi15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139481, N'HS', N'19138402', N'33', N'A', N'33A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165535
', N'576083', N'ptujskacesta33a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139482, N'HS', N'19138453', N'81', N'B', N'81B', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168582
', N'575939', N'črešnjevci81b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139483, N'HS', N'11584241', N'219', N' ', N'219', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169552
', N'575510', N'črešnjevci219')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139484, N'HS', N'19138488', N'99', N' ', N'99', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168765
', N'576445', N'črešnjevci99')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139485, N'HS', N'19137988', N'83', N'A', N'83A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163168
', N'570888', N'negova83a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139486, N'HS', N'11629270', N'29', N' ', N'29', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164996
', N'572599', N'radvenci29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139487, N'HS', N'19137490', N'18', N' ', N'18', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169582
', N'576110', N'kajuhovaulica18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139488, N'HS', N'19138267', N'23', N' ', N'23', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160988
', N'573944', N'ivanjskivrh23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139489, N'HS', N'19137970', N'61', N'C', N'61C', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168925
', N'576354', N'črešnjevci61c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139490, N'HS', N'19138089', N'9', N' ', N'9', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169610
', N'576149', N'kajuhovaulica9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139491, N'HS', N'19137643', N'148', N'A', N'148A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168172
', N'576029', N'črešnjevci148a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139492, N'HS', N'19138216', N'6', N'C', N'6C', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161775
', N'575420', N'spodnjiivanjci6c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139493, N'HS', N'19137864', N'5', N'B', N'5B', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171069
', N'575458', N'strmaulica5b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139494, N'HS', N'19137651', N'24', N'C', N'24C', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167633
', N'574824', N'zbigovci24c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139495, N'HS', N'11636764', N'30', N' ', N'30', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161696
', N'576125', N'spodnjiivanjci30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139496, N'HS', N'19137716', N'168', N' ', N'168', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168494
', N'575581', N'črešnjevci168')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139497, N'HS', N'19138739', N'12', N' ', N'12', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169667
', N'576178', N'ulicamarijerožman12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139498, N'HS', N'11635245', N'37', N'A', N'37A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167839
', N'571706', N'spodnjaščavnica37a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139499, N'HS', N'11620698', N'77', N' ', N'77', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169279
', N'573402', N'police77')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139500, N'HS', N'19136256', N'14', N'A', N'14A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164814
', N'571835', N'radvenci14a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139501, N'HS', N'11609376', N'8', N' ', N'8', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168888
', N'578365', N'mele8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139502, N'HS', N'11606750', N'6', N' ', N'6', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170605
', N'573648', N'lomanoše6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139503, N'HS', N'11638775', N'42', N' ', N'42', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163875
', N'575902', N'stavešinskivrh42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139504, N'HS', N'19135438', N'124', N'A', N'124A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164288
', N'569964', N'negova124a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139505, N'HS', N'11638155', N'10', N' ', N'10', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163632
', N'575369', N'stavešinci10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139506, N'HS', N'19135110', N'10', N'A', N'10A', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166263
', N'574348', N'rodmošci10a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139507, N'HS', N'19138208', N'37', N'B', N'37B', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170375
', N'574261', N'hercegovščak37b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139508, N'HS', N'19135284', N'2', N'A', N'2A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'163812
', N'572235', N'lokavci2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139509, N'HS', N'11644066', N'61', N' ', N'61', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167065
', N'573799', N'zbigovci61')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139510, N'HS', N'19135837', N'17', N'A', N'17A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166142
', N'572745', N'lastomerci17a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139511, N'HS', N'19131980', N'17', N'B', N'17B', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161668
', N'572871', N'kunova17b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139512, N'HS', N'19133010', N'135', N'A', N'135A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167719
', N'575961', N'črešnjevci135a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139513, N'HS', N'19135420', N'24', N' ', N'24', N'16184721', N'10092752', N'11026826', N'21429392', N'10253110', N'170303
', N'576177', N'cankarjevacesta24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139514, N'HS', N'19119513', N'5', N'A', N'5A', N'16185230', N'10092752', N'11026826', N'21429392', N'10252628', N'171013
', N'575372', N'strmaulica5a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139515, N'HS', N'19136264', N'7', N' ', N'7', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166561
', N'574573', N'rodmošci7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139516, N'HS', N'11612318', N'34', N' ', N'34', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163003
', N'572089', N'negova34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139517, N'HS', N'11593917', N'2', N' ', N'2', N'16185299', N'10092752', N'11026826', N'21429392', N'10253233', N'171322
', N'575544', N'vaupotičevaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139518, N'HS', N'19119904', N'2', N'C', N'2C', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167761
', N'575579', N'zbigovci2c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139519, N'HS', N'11621805', N'31', N'A', N'31A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165618
', N'576219', N'ptujskacesta31a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139520, N'HS', N'11643671', N'23', N'A', N'23A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167821
', N'574879', N'zbigovci23a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139521, N'HS', N'19134849', N'3', N'C', N'3C', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160993
', N'574602', N'ivanjskivrh3c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139522, N'HS', N'11583741', N'174', N' ', N'174', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168372
', N'575375', N'črešnjevci174')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139523, N'HS', N'19120040', N'30', N'A', N'30A', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167358
', N'576026', N'orehovskivrh30a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139524, N'HS', N'19134628', N'3', N'B', N'3B', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163046
', N'575953', N'stavešinci3b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139525, N'HS', N'11612644', N'65', N' ', N'65', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162206
', N'570926', N'negova65')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139526, N'HS', N'11612733', N'73', N' ', N'73', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162686
', N'570473', N'negova73')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139527, N'HS', N'11612822', N'82', N' ', N'82', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163184
', N'570938', N'negova82')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139528, N'HS', N'11612890', N'88', N' ', N'88', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163012
', N'570235', N'negova88')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139529, N'HS', N'11612911', N'90', N' ', N'90', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163225
', N'570221', N'negova90')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139530, N'HS', N'11609449', N'16', N' ', N'16', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168884
', N'578631', N'mele16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139531, N'HS', N'11609830', N'42', N' ', N'42', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168884
', N'578178', N'mele42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139532, N'HS', N'11612164', N'19', N' ', N'19', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163237
', N'572110', N'negova19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139533, N'HS', N'11612415', N'43', N' ', N'43', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163115
', N'571860', N'negova43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139534, N'HS', N'11612431', N'45', N' ', N'45', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162715
', N'571601', N'negova45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139535, N'HS', N'11612539', N'53', N' ', N'53', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162706
', N'571278', N'negova53')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139536, N'HS', N'19131840', N'12', N'C', N'12C', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'165505
', N'573210', N'lastomerci12c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139537, N'HS', N'11592180', N'8', N' ', N'8', N'16185035', N'10092752', N'11026826', N'21429392', N'10252628', N'171044
', N'575118', N'gasilskacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139538, N'HS', N'11598854', N'14', N' ', N'14', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164911
', N'574257', N'ivanjševskivrh14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139539, N'HS', N'11612296', N'32', N' ', N'32', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'162998
', N'572141', N'negova32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139540, N'HS', N'11612288', N'31', N' ', N'31', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163024
', N'572138', N'negova31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139541, N'HS', N'11612270', N'28', N' ', N'28', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163050
', N'572139', N'negova28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139542, N'HS', N'11621813', N'31', N'B', N'31B', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165597
', N'576202', N'ptujskacesta31b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139543, N'HS', N'11612245', N'25', N' ', N'25', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163095
', N'572183', N'negova25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139544, N'HS', N'11583377', N'139', N' ', N'139', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167887
', N'575952', N'črešnjevci139')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139545, N'HS', N'11583440', N'146', N' ', N'146', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167945
', N'575980', N'črešnjevci146')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139546, N'HS', N'16394980', N'16', N'A', N'16A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163252
', N'572182', N'negova16a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139547, N'HS', N'11643370', N'2', N'A', N'2A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167646
', N'575515', N'zbigovci2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139548, N'HS', N'19131483', N'18', N'A', N'18A', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168882
', N'572095', N'plitvičkivrh18a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139549, N'HS', N'19131491', N'22', N' ', N'22', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171401
', N'576111', N'lackovaulica22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139550, N'HS', N'11612253', N'26', N' ', N'26', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163068
', N'572180', N'negova26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139551, N'HS', N'19135101', N'61', N'B', N'61B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165466
', N'575140', N'ivanjševskivrh61b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139552, N'HS', N'11615961', N'10', N' ', N'10', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167079
', N'576387', N'orehovci10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139553, N'HS', N'11607314', N'42', N'A', N'42A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169872
', N'572734', N'lomanoše42a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139554, N'HS', N'11607179', N'32', N'A', N'32A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169967
', N'572876', N'lomanoše32a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139555, N'HS', N'19135411', N'13', N'B', N'13B', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167145
', N'575128', N'zbigovci13b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139556, N'HS', N'19135080', N'27', N'B', N'27B', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167587
', N'575795', N'orehovskivrh27b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139557, N'HS', N'11606989', N'16', N' ', N'16', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170200
', N'573125', N'lomanoše16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139558, N'HS', N'11605460', N'29', N'B', N'29B', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166929
', N'573477', N'lastomerci29b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139559, N'HS', N'19135276', N'21', N'A', N'21A', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170033
', N'575021', N'police21a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139560, N'HS', N'19135667', N'200', N'A', N'200A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168539
', N'575106', N'črešnjevci200a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139561, N'HS', N'19135969', N'47', N'A', N'47A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252717', N'170733
', N'574414', N'hercegovščak47a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139562, N'HS', N'19135993', N'95', N'A', N'95A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169356
', N'573985', N'police95a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139563, N'HS', N'11643396', N'3', N'A', N'3A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'168006
', N'575392', N'zbigovci3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139564, N'HS', N'19135748', N'36', N'B', N'36B', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170393
', N'574411', N'hercegovščak36b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139565, N'HS', N'19136906', N'1', N'A', N'1A', N'16276286', N'10093414', N'11026826', N'21428353', N'19127419', N'169017
', N'568558', N'spodnjaščavnica1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139566, N'HS', N'19135802', N'104', N'A', N'104A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169023
', N'573351', N'police104a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139567, N'HS', N'11613063', N'103', N' ', N'103', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163789
', N'570402', N'negova103')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139568, N'HS', N'11613195', N'115', N' ', N'115', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163844
', N'570712', N'negova115')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139569, N'HS', N'11613225', N'118', N' ', N'118', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164069
', N'570232', N'negova118')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139570, N'HS', N'11613268', N'122', N' ', N'122', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164053
', N'570022', N'negova122')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139571, N'HS', N'11613276', N'123', N' ', N'123', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164063
', N'570038', N'negova123')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139572, N'HS', N'11613306', N'126', N' ', N'126', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164331
', N'570032', N'negova126')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139573, N'HS', N'11613373', N'6', N' ', N'6', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169731
', N'576020', N'noričkivrh6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139574, N'HS', N'11614159', N'9', N'A', N'9A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162519
', N'576919', N'očeslavci9a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139575, N'HS', N'11614183', N'10', N' ', N'10', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162609
', N'577074', N'očeslavci10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139576, N'HS', N'11614272', N'17', N' ', N'17', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162839
', N'577484', N'očeslavci17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139577, N'HS', N'11614299', N'18', N' ', N'18', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162757
', N'577474', N'očeslavci18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139578, N'HS', N'11614361', N'24', N' ', N'24', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162468
', N'577779', N'očeslavci24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139579, N'HS', N'11614434', N'31', N' ', N'31', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162869
', N'577612', N'očeslavci31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139580, N'HS', N'11598927', N'19', N' ', N'19', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164883
', N'574431', N'ivanjševskivrh19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139581, N'HS', N'11598919', N'18', N' ', N'18', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164919
', N'574446', N'ivanjševskivrh18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139582, N'HS', N'11614507', N'37', N' ', N'37', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163193
', N'577729', N'očeslavci37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139583, N'HS', N'11614698', N'49', N' ', N'49', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163680
', N'577729', N'očeslavci49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139584, N'HS', N'11616054', N'2', N' ', N'2', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166786
', N'575985', N'orehovskivrh2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139585, N'HS', N'11616127', N'7', N' ', N'7', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166633
', N'575456', N'orehovskivrh7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139586, N'HS', N'11616143', N'9', N'A', N'9A', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166357
', N'575297', N'orehovskivrh9a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139587, N'HS', N'11616321', N'25', N' ', N'25', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167561
', N'575729', N'orehovskivrh25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139588, N'HS', N'11616542', N'46', N' ', N'46', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167629
', N'576469', N'orehovskivrh46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139589, N'HS', N'19128946', N'61', N'A', N'61A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165470
', N'575103', N'ivanjševskivrh61a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139590, N'HS', N'19128849', N'27', N'A', N'27A', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167641
', N'575814', N'orehovskivrh27a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139591, N'HS', N'19128717', N'88', N'A', N'88A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168017
', N'569156', N'spodnjaščavnica88a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139592, N'HS', N'19128725', N'15', N' ', N'15', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169586
', N'576220', N'kajuhovaulica15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139593, N'HS', N'19128911', N'48', N'B', N'48B', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166676
', N'573968', N'zbigovci48b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139594, N'HS', N'19128873', N'33', N'A', N'33A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170409
', N'574706', N'hercegovščak33a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139595, N'HS', N'19128679', N'117', N'A', N'117A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163991
', N'570602', N'negova117a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139596, N'HS', N'19128857', N'5', N'A', N'5A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165172
', N'571790', N'radvenci5a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139597, N'HS', N'19131645', N'9', N' ', N'9', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163195
', N'572259', N'negova9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139598, N'HS', N'19138844', N'24', N'A', N'24A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164879
', N'572196', N'radvenci24a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139599, N'HS', N'19119505', N'28', N'A', N'28A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162762
', N'577604', N'očeslavci28a')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139600, N'HS', N'16563030', N'15', N'C', N'15C', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170924
', N'576121', N'trgsvobode15c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139601, N'HS', N'16563048', N'15', N'B', N'15B', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170916
', N'576126', N'trgsvobode15b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139602, N'HS', N'11589596', N'23', N' ', N'23', N'16184861', N'10092752', N'11026826', N'21429392', N'16398071', N'170720
', N'576257', N'partizanskacesta23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139603, N'HS', N'11589618', N'25', N' ', N'25', N'16184861', N'10092752', N'11026826', N'21429392', N'16398071', N'170690
', N'576274', N'partizanskacesta25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139604, N'HS', N'11589626', N'26', N' ', N'26', N'16184861', N'10092752', N'11026826', N'21429392', N'16398071', N'170693
', N'576236', N'partizanskacesta26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139605, N'HS', N'11586899', N'6', N' ', N'6', N'16184713', N'10092752', N'11026826', N'21429392', N'10253233', N'171190
', N'575717', N'apaškacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139606, N'HS', N'19131408', N'46', N'D', N'46D', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166497
', N'576960', N'ptujskacesta46d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139607, N'HS', N'19133494', N'23', N'A', N'23A', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169905
', N'575769', N'noričkivrh23a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139608, N'HS', N'11643612', N'20', N'B', N'20B', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167562
', N'574867', N'zbigovci20b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139609, N'HS', N'19131424', N'62', N'B', N'62B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'166873
', N'572818', N'spodnjaščavnica62b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139610, N'HS', N'11617905', N'23', N' ', N'23', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168779
', N'572034', N'plitvičkivrh23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139611, N'HS', N'11636390', N'3', N'E', N'3E', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161564
', N'574604', N'spodnjiivanjci3e')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139612, N'HS', N'19131874', N'31', N'A', N'31A', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170159
', N'574320', N'police31a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139613, N'HS', N'19131807', N'33', N'A', N'33A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'162930
', N'572153', N'negova33a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139614, N'HS', N'19131475', N'12', N'E', N'12E', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170180
', N'573331', N'lomanoše12e')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139615, N'HS', N'11643604', N'20', N'A', N'20A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167535
', N'574860', N'zbigovci20a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139616, N'HS', N'16354805', N'21', N'A', N'21A', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168828
', N'572077', N'plitvičkivrh21a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139617, N'HS', N'19132218', N'32', N' ', N'32', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168420
', N'571948', N'spodnjaščavnica32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139618, N'HS', N'19131882', N'12', N'A', N'12A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164855
', N'574184', N'ivanjševskivrh12a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139619, N'HS', N'11635792', N'72', N' ', N'72', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167590
', N'571270', N'spodnjaščavnica72')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139620, N'HS', N'16394963', N'226', N'A', N'226A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169348
', N'575648', N'črešnjevci226a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139621, N'HS', N'16394971', N'9', N'C', N'9C', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170350
', N'573600', N'lomanoše9c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139622, N'HS', N'11643639', N'20', N'C', N'20C', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167593
', N'574873', N'zbigovci20c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139623, N'HS', N'11643647', N'20', N' ', N'20', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167499
', N'574862', N'zbigovci20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139624, N'HS', N'16400645', N'16', N'A', N'16A', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169670
', N'574424', N'police16a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139625, N'HS', N'11617891', N'22', N' ', N'22', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168822
', N'572037', N'plitvičkivrh22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139626, N'HS', N'19132269', N'16', N' ', N'16', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169587
', N'576187', N'kajuhovaulica16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139627, N'HS', N'19120244', N'36', N'A', N'36A', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170534
', N'576328', N'partizanskacesta36a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139628, N'HS', N'16551252', N'113', N'A', N'113A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163550
', N'570944', N'negova113a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139629, N'HS', N'11605346', N'23', N' ', N'23', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166952
', N'572934', N'lastomerci23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139630, N'HS', N'19138887', N'25', N'B', N'25B', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'167257
', N'573039', N'lastomerci25b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139631, N'HS', N'11589537', N'17', N' ', N'17', N'16184861', N'10092752', N'11026826', N'21429392', N'16398071', N'170775
', N'576212', N'partizanskacesta17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139632, N'HS', N'11589553', N'19', N' ', N'19', N'16184861', N'10092752', N'11026826', N'21429392', N'16398071', N'170768
', N'576221', N'partizanskacesta19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139633, N'HS', N'11636357', N'3', N'A', N'3A', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161560
', N'574520', N'spodnjiivanjci3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139634, N'HS', N'19135195', N'33', N'A', N'33A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167120
', N'569226', N'zagajskivrh33a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139635, N'HS', N'19136027', N'39', N'A', N'39A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167312
', N'572071', N'spodnjaščavnica39a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139636, N'HS', N'11643086', N'24', N' ', N'24', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167056
', N'569369', N'zagajskivrh24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139637, N'HS', N'11582966', N'102', N' ', N'102', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168533
', N'576477', N'črešnjevci102')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139638, N'HS', N'19135888', N'38', N'A', N'38A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164727
', N'570360', N'lokavci38a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139639, N'HS', N'11638821', N'46', N' ', N'46', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163659
', N'575639', N'stavešinskivrh46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139640, N'HS', N'19137287', N'14', N'B', N'14B', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161320
', N'572743', N'kunova14b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139641, N'HS', N'19124843', N'14', N'B', N'14B', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170183
', N'573259', N'lomanoše14b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139642, N'HS', N'19122271', N'18', N'C', N'18C', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168569
', N'571565', N'spodnjaščavnica18c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139643, N'HS', N'19124932', N'75', N'A', N'75A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167673
', N'570992', N'spodnjaščavnica75a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139644, N'HS', N'19137767', N'2', N'C', N'2C', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163463
', N'575940', N'stavešinci2c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139645, N'HS', N'11629016', N'5', N' ', N'5', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165196
', N'571834', N'radvenci5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139646, N'HS', N'11616330', N'26', N' ', N'26', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167577
', N'575622', N'orehovskivrh26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139647, N'HS', N'19126498', N'216', N'A', N'216A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'169170
', N'575079', N'črešnjevci216a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139648, N'HS', N'19136922', N'97', N' ', N'97', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168734
', N'576382', N'črešnjevci97')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139649, N'HS', N'19137899', N'10', N'A', N'10A', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161693
', N'575533', N'spodnjiivanjci10a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139650, N'HS', N'11598897', N'17', N' ', N'17', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165030
', N'574344', N'ivanjševskivrh17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139651, N'HS', N'11614639', N'45', N'A', N'45A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163585
', N'577699', N'očeslavci45a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139652, N'HS', N'19137937', N'6', N'A', N'6A', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171113
', N'576501', N'trate6a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139653, N'HS', N'16391077', N'8', N'A', N'8A', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166390
', N'574531', N'rodmošci8a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139654, N'HS', N'19137694', N'1', N'D', N'1D', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166620
', N'570328', N'zagajskivrh1d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139655, N'HS', N'11638015', N'2', N'B', N'2B', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163394
', N'576189', N'stavešinci2b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139656, N'HS', N'11583733', N'173', N' ', N'173', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168371
', N'575355', N'črešnjevci173')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139657, N'HS', N'19136884', N'24', N'A', N'24A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167689
', N'574829', N'zbigovci24a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139658, N'HS', N'19135241', N'81', N'A', N'81A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'162993
', N'571264', N'negova81a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139659, N'HS', N'16400637', N'133', N'A', N'133A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167625
', N'576313', N'črešnjevci133a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139660, N'HS', N'11635814', N'74', N'A', N'74A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167694
', N'571028', N'spodnjaščavnica74a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139661, N'HS', N'19136043', N'27', N' ', N'27', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'169655
', N'576407', N'mariborskacesta27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139662, N'HS', N'19125335', N'17', N'A', N'17A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170108
', N'573141', N'lomanoše17a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139663, N'HS', N'11629962', N'13', N' ', N'13', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166058
', N'574166', N'rodmošci13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139664, N'HS', N'11618235', N'54', N' ', N'54', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169027
', N'570783', N'plitvičkivrh54')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139665, N'HS', N'16354872', N'67', N'A', N'67A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167682
', N'573873', N'zbigovci67a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139666, N'HS', N'19136817', N'7', N'B', N'7B', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166459
', N'574507', N'rodmošci7b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139667, N'HS', N'11638180', N'13', N' ', N'13', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'162968
', N'575256', N'stavešinci13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139668, N'HS', N'11584349', N'227', N' ', N'227', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169349
', N'575736', N'črešnjevci227')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139669, N'HS', N'19135217', N'11', N'A', N'11A', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163110
', N'573981', N'gornjiivanjci11a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139670, N'HS', N'19135128', N'33', N'A', N'33A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165031
', N'574075', N'ivanjševskivrh33a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139671, N'HS', N'19124754', N'16', N'A', N'16A', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167044
', N'575448', N'orehovskivrh16a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139672, N'HS', N'19124878', N'30', N'A', N'30A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165275
', N'574081', N'ivanjševskivrh30a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139673, N'HS', N'11586830', N'1', N' ', N'1', N'16184713', N'10092752', N'11026826', N'21429392', N'10252687', N'171163
', N'575579', N'apaškacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139674, N'HS', N'11586864', N'4', N' ', N'4', N'16184713', N'10092752', N'11026826', N'21429392', N'10253233', N'171175
', N'575810', N'apaškacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139675, N'HS', N'11586902', N'7', N' ', N'7', N'16184713', N'10092752', N'11026826', N'21429392', N'10252687', N'171181
', N'575456', N'apaškacesta7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139676, N'HS', N'11586937', N'9', N' ', N'9', N'16184713', N'10092752', N'11026826', N'21429392', N'10252687', N'171183
', N'575242', N'apaškacesta9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139677, N'HS', N'11586945', N'11', N' ', N'11', N'16184713', N'10092752', N'11026826', N'21429392', N'10252628', N'171211
', N'575211', N'apaškacesta11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139678, N'HS', N'11582869', N'88', N' ', N'88', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168633
', N'576310', N'črešnjevci88')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139679, N'HS', N'19138313', N'10', N'A', N'10A', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167086
', N'576369', N'orehovci10a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139680, N'HS', N'19138151', N'35', N' ', N'35', N'16184926', N'10092752', N'11026826', N'21429392', N'10257182', N'171004
', N'576722', N'trate35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139681, N'HS', N'19137961', N'6', N'D', N'6D', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171089
', N'576482', N'trate6d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139682, N'HS', N'19138054', N'35', N'A', N'35A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164657
', N'569768', N'lokavci35a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139683, N'HS', N'19137619', N'27', N'A', N'27A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162678
', N'577638', N'očeslavci27a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139684, N'HS', N'11636101', N'96', N' ', N'96', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167725
', N'568945', N'spodnjaščavnica96')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139685, N'HS', N'11592201', N'2', N' ', N'2', N'16185043', N'10092752', N'11026826', N'21429392', N'10252687', N'171116
', N'575563', N'gorkegaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139686, N'HS', N'11594115', N'5', N' ', N'5', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163369
', N'573143', N'gornjiivanjci5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139687, N'HS', N'19138500', N'31', N'B', N'31B', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164952
', N'570081', N'lokavci31b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139688, N'HS', N'11591027', N'6', N' ', N'6', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171119
', N'576505', N'trate6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139689, N'HS', N'16343854', N'46', N'A', N'46A', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171306
', N'573691', N'podgrad46a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139690, N'HS', N'19138275', N'28', N' ', N'28', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165063
', N'572525', N'radvenci28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139691, N'HS', N'19124827', N'29', N'A', N'29A', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'170976
', N'574228', N'podgrad29a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139692, N'HS', N'19137732', N'14', N'A', N'14A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167215
', N'575087', N'zbigovci14a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139693, N'HS', N'19138194', N'13', N' ', N'13', N'16185132', N'10092752', N'11026826', N'21429392', N'10253098', N'169666
', N'576491', N'obpotoku13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139694, N'HS', N'11606288', N'15', N' ', N'15', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164786
', N'571630', N'lokavci15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139695, N'HS', N'11636420', N'5', N'A', N'5A', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161634
', N'575421', N'spodnjiivanjci5a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139696, N'HS', N'16343919', N'45', N'B', N'45B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165320
', N'574795', N'ivanjševskivrh45b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139697, N'HS', N'19118118', N'39', N'A', N'39A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164663
', N'570280', N'lokavci39a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139698, N'HS', N'11636837', N'35', N' ', N'35', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161491
', N'575581', N'spodnjiivanjci35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139699, N'HS', N'19137945', N'6', N'B', N'6B', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171109
', N'576497', N'trate6b')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139700, N'HS', N'19138542', N'53', N'B', N'53B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164518
', N'575072', N'ivanjševskivrh53b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139701, N'HS', N'19138445', N'20', N' ', N'20', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168278
', N'572671', N'aženskivrh20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139702, N'HS', N'19131327', N'1', N'A', N'1A', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171299
', N'575259', N'podgrad1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139703, N'HS', N'19137856', N'19', N'F', N'19F', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170349
', N'575536', N'hercegovščak19f')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139704, N'HS', N'19135675', N'34', N'A', N'34A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164791
', N'569883', N'lokavci34a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139705, N'HS', N'19138399', N'12', N' ', N'12', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164451
', N'574354', N'ivanjševciobščavnici12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139706, N'HS', N'11588620', N'14', N' ', N'14', N'16184829', N'10092752', N'11026826', N'21429392', N'10257204', N'170000
', N'576634', N'ljutomerskacesta14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139707, N'HS', N'19138038', N'74', N'B', N'74B', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167725
', N'570946', N'spodnjaščavnica74b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139708, N'HS', N'19137759', N'14', N'B', N'14B', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167230
', N'575113', N'zbigovci14b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139709, N'HS', N'11622127', N'50', N' ', N'50', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166586
', N'577290', N'ptujskacesta50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139710, N'HS', N'11588565', N'8', N' ', N'8', N'16184829', N'10092752', N'11026826', N'21429392', N'10253098', N'170125
', N'576509', N'ljutomerskacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139711, N'HS', N'11619894', N'5', N' ', N'5', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169775
', N'574762', N'police5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139712, N'HS', N'19138712', N'60', N' ', N'60', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171335
', N'573437', N'podgrad60')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139713, N'HS', N'19138020', N'11', N'B', N'11B', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164429
', N'572093', N'lokavci11b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139714, N'HS', N'19137597', N'27', N'B', N'27B', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162697
', N'577631', N'očeslavci27b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139715, N'HS', N'19138607', N'14', N' ', N'14', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169663
', N'576146', N'ulicamarijerožman14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139716, N'HS', N'11614515', N'38', N' ', N'38', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163199
', N'577813', N'očeslavci38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139717, N'HS', N'19138798', N'12', N'C', N'12C', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162613
', N'577285', N'očeslavci12c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139718, N'HS', N'19137554', N'44', N'C', N'44C', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169753
', N'572436', N'lomanoše44c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139719, N'HS', N'19137708', N'5', N'A', N'5A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162608
', N'576818', N'očeslavci5a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139720, N'HS', N'19128431', N'29', N'C', N'29C', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165217
', N'574018', N'ivanjševskivrh29c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139721, N'HS', N'19128415', N'1', N' ', N'1', N'16184993', N'10092752', N'11026826', N'21429392', N'10253055', N'170615
', N'576432', N'cestanastadion1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139722, N'HS', N'19128423', N'12', N'R', N'12R', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170927
', N'576189', N'trgsvobode12r')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139723, N'HS', N'19128601', N'16', N'B', N'16B', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169670
', N'574470', N'police16b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139724, N'HS', N'19120074', N'68', N'A', N'68A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168724
', N'576334', N'črešnjevci68a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139725, N'HS', N'11629865', N'4', N' ', N'4', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166888
', N'574931', N'rodmošci4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139726, N'HS', N'11582613', N'63', N' ', N'63', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168879
', N'576353', N'črešnjevci63')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139727, N'HS', N'19133702', N'32', N'A', N'32A', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169224
', N'577789', N'ljutomerskacesta32a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139728, N'HS', N'19132226', N'74', N'F', N'74F', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167745
', N'570890', N'spodnjaščavnica74f')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139729, N'HS', N'19132307', N'103', N'A', N'103A', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168483
', N'576433', N'črešnjevci103a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139730, N'HS', N'19119408', N'41', N'A', N'41A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169045
', N'576320', N'črešnjevci41a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139731, N'HS', N'11582605', N'63', N'A', N'63A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168884
', N'576332', N'črešnjevci63a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139732, N'HS', N'11582885', N'90', N' ', N'90', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168593
', N'576374', N'črešnjevci90')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139733, N'HS', N'11599257', N'44', N'B', N'44B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165453
', N'574770', N'ivanjševskivrh44b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139734, N'HS', N'11606849', N'9', N'D', N'9D', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170316
', N'573609', N'lomanoše9d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139735, N'HS', N'19134156', N'4', N' ', N'4', N'16185221', N'10092752', N'11026826', N'21429392', N'10252628', N'171038
', N'575741', N'rozmanovaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139736, N'HS', N'19134016', N'153', N'B', N'153B', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168370
', N'575943', N'črešnjevci153b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139737, N'HS', N'11629342', N'36', N' ', N'36', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164000
', N'573557', N'radvenci36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139738, N'HS', N'11582133', N'16', N' ', N'16', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169315
', N'576369', N'črešnjevci16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139739, N'HS', N'19129926', N'16', N'C', N'16C', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170965
', N'576132', N'trgsvobode16c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139740, N'HS', N'19130509', N'45', N'D', N'45D', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167483
', N'576630', N'orehovskivrh45d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139741, N'HS', N'19131092', N'50', N'A', N'50A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164517
', N'574988', N'ivanjševskivrh50a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139742, N'HS', N'19131319', N'9', N'C', N'9C', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164293
', N'572332', N'lokavci9c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139743, N'HS', N'19131904', N'38', N'A', N'38A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168772
', N'578222', N'mele38a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139744, N'HS', N'19132005', N'8', N'A', N'8A', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169401
', N'576409', N'črešnjevci8a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139745, N'HS', N'19133192', N'12', N'B', N'12B', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169148
', N'572156', N'plitvičkivrh12b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139746, N'HS', N'19133958', N'43', N'C', N'43C', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167723
', N'572297', N'spodnjaščavnica43c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139747, N'HS', N'19134466', N'42', N'A', N'42A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163824
', N'575811', N'stavešinskivrh42a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139748, N'HS', N'19135136', N'229', N'A', N'229A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169264
', N'575712', N'črešnjevci229a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139749, N'HS', N'19135497', N'55', N' ', N'55', N'16184829', N'10092752', N'11026826', N'21429392', N'19129241', N'169312
', N'576588', N'ljutomerskacesta55')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139750, N'HS', N'19128300', N'10', N'B', N'10B', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166214
', N'573407', N'lastomerci10b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139751, N'HS', N'19128687', N'66', N'B', N'66B', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169861
', N'573386', N'police66b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139752, N'HS', N'11584357', N'228', N' ', N'228', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169303
', N'575714', N'črešnjevci228')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139753, N'HS', N'11584381', N'231', N' ', N'231', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169100
', N'575819', N'črešnjevci231')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139754, N'HS', N'16390950', N'19', N'D', N'19D', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170348
', N'575517', N'hercegovščak19d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139755, N'HS', N'16391204', N'4', N' ', N'4', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163025
', N'572633', N'negova4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139756, N'HS', N'19135721', N'10', N'A', N'10A', N'16184730', N'10092752', N'11026826', N'21429392', N'10253284', N'171196
', N'576325', N'ciril-metodovacesta10a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139757, N'HS', N'11607420', N'47', N' ', N'47', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169120
', N'572074', N'lomanoše47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139758, N'HS', N'19137422', N'21', N'A', N'21A', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161032
', N'573961', N'ivanjskivrh21a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139759, N'HS', N'19125831', N'11', N' ', N'11', N'16185124', N'10092752', N'11026826', N'21429392', N'10252768', N'171028
', N'576414', N'mladinskaulica11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139760, N'HS', N'19125840', N'13', N' ', N'13', N'16185124', N'10092752', N'11026826', N'21429392', N'10252768', N'171043
', N'576424', N'mladinskaulica13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139761, N'HS', N'19125858', N'15', N' ', N'15', N'16185124', N'10092752', N'11026826', N'21429392', N'10252768', N'171056
', N'576433', N'mladinskaulica15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139762, N'HS', N'19125939', N'4', N' ', N'4', N'16185124', N'10092752', N'11026826', N'21429392', N'10252768', N'170993
', N'576334', N'mladinskaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139763, N'HS', N'19125947', N'15', N'A', N'15A', N'16184802', N'10092752', N'11026826', N'21429392', N'10253225', N'171291
', N'576204', N'lackovaulica15a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139764, N'HS', N'19131866', N'11', N'B', N'11B', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162639
', N'577036', N'očeslavci11b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139765, N'HS', N'11643663', N'22', N' ', N'22', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167862
', N'574922', N'zbigovci22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139766, N'HS', N'11635326', N'43', N'A', N'43A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167702
', N'572299', N'spodnjaščavnica43a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139767, N'HS', N'19125602', N'54', N'A', N'54A', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168665
', N'570658', N'plitvičkivrh54a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139768, N'HS', N'11612237', N'24', N' ', N'24', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163096
', N'572143', N'negova24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139769, N'HS', N'19125688', N'13', N'A', N'13A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170228
', N'573188', N'lomanoše13a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139770, N'HS', N'19125734', N'33', N'A', N'33A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164592
', N'573198', N'radvenci33a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139771, N'HS', N'19137953', N'6', N'C', N'6C', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171097
', N'576487', N'trate6c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139772, N'HS', N'11614493', N'36', N' ', N'36', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163123
', N'577740', N'očeslavci36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139773, N'HS', N'19138704', N'14', N' ', N'14', N'16185132', N'10092752', N'11026826', N'21429392', N'10253098', N'169622
', N'576625', N'obpotoku14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139774, N'HS', N'19125661', N'93', N'A', N'93A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169288
', N'574124', N'police93a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139775, N'HS', N'19138046', N'60', N'B', N'60B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165529
', N'575072', N'ivanjševskivrh60b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139776, N'HS', N'19138771', N'10', N' ', N'10', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166159
', N'573407', N'lastomerci10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139777, N'HS', N'19137660', N'4', N'A', N'4A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170695
', N'573145', N'lomanoše4a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139778, N'HS', N'11606822', N'9', N'B', N'9B', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170392
', N'573598', N'lomanoše9b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139779, N'HS', N'11606814', N'9', N'A', N'9A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170451
', N'573587', N'lomanoše9a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139780, N'HS', N'16343820', N'1', N'B', N'1B', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166810
', N'570220', N'zagajskivrh1b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139781, N'HS', N'16343897', N'6', N' ', N'6', N'16185086', N'10092752', N'11026826', N'21429392', N'19132765', N'170995
', N'576609', N'kocljevaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139782, N'HS', N'19134601', N'7', N' ', N'7', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169611
', N'576184', N'kajuhovaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139783, N'HS', N'19138747', N'20', N'B', N'20B', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166575
', N'572926', N'lastomerci20b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139784, N'HS', N'19134784', N'2', N'C', N'2C', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169411
', N'576612', N'črešnjevci2c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139785, N'HS', N'19134334', N'41', N'D', N'41D', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163482
', N'577650', N'očeslavci41d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139786, N'HS', N'19134644', N'61', N'A', N'61A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'166836
', N'572718', N'spodnjaščavnica61a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139787, N'HS', N'19138801', N'129', N'A', N'129A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168347
', N'573556', N'police129a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139788, N'HS', N'11583687', N'167', N' ', N'167', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168443
', N'575679', N'črešnjevci167')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139789, N'HS', N'19130258', N'24', N'A', N'24A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'165062
', N'570909', N'lokavci24a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139790, N'HS', N'19138755', N'3', N' ', N'3', N'16185132', N'10092752', N'11026826', N'21429392', N'19132706', N'169618
', N'576452', N'obpotoku3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139791, N'HS', N'19128806', N'14', N'A', N'14A', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161314
', N'572778', N'kunova14a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139792, N'HS', N'19128890', N'20', N'B', N'20B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167865
', N'571178', N'spodnjaščavnica20b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139793, N'HS', N'19128733', N'81', N'A', N'81A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169376
', N'573548', N'police81a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139794, N'HS', N'19128768', N'44', N'B', N'44B', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170491
', N'574414', N'hercegovščak44b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139795, N'HS', N'19128750', N'29', N'C', N'29C', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169352
', N'577689', N'ljutomerskacesta29c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139796, N'HS', N'16171450', N'11', N'B', N'11B', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170296
', N'573324', N'lomanoše11b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139797, N'HS', N'16171476', N'16', N' ', N'16', N'16184721', N'10092752', N'11026826', N'21429392', N'10253080', N'170315
', N'576202', N'cankarjevacesta16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139798, N'HS', N'16171492', N'48', N' ', N'48', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167604
', N'576381', N'orehovskivrh48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139799, N'HS', N'19130134', N'34', N'E', N'34E', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169093
', N'577810', N'ljutomerskacesta34e')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139800, N'HS', N'19130649', N'25', N' ', N'25', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164923
', N'572306', N'radvenci25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139801, N'HS', N'19127770', N'20', N' ', N'20', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171187
', N'576564', N'trate20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139802, N'HS', N'11590683', N'30', N' ', N'30', N'16184900', N'10092752', N'11026826', N'21429392', N'10252610', N'170863
', N'575720', N'simoničevbreg30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139803, N'HS', N'19122280', N'21', N'A', N'21A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170738
', N'575436', N'hercegovščak21a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139804, N'HS', N'19126099', N'20', N'A', N'20A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167897
', N'571109', N'spodnjaščavnica20a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139805, N'HS', N'19137376', N'2', N'A', N'2A', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168432
', N'573223', N'aženskivrh2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139806, N'HS', N'19127966', N'28', N'B', N'28B', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169474
', N'577152', N'ljutomerskacesta28b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139807, N'HS', N'19137481', N'37', N' ', N'37', N'16184926', N'10092752', N'11026826', N'21429392', N'10257182', N'170960
', N'576736', N'trate37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139808, N'HS', N'19122301', N'136', N' ', N'136', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167751
', N'575954', N'črešnjevci136')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139809, N'HS', N'19122255', N'21', N'C', N'21C', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167940
', N'571068', N'spodnjaščavnica21c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139810, N'HS', N'19130983', N'26', N' ', N'26', N'16184721', N'10092752', N'11026826', N'21429392', N'10253110', N'170263
', N'576150', N'cankarjevacesta26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139811, N'HS', N'19119947', N'78', N'A', N'78A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167442
', N'570494', N'spodnjaščavnica78a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139812, N'HS', N'19119823', N'1', N'A', N'1A', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167154
', N'577200', N'orehovci1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139813, N'HS', N'11588077', N'12', N' ', N'12', N'16184799', N'10092752', N'11026826', N'21429392', N'10253284', N'171413
', N'575975', N'kerenčičevaulica12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139814, N'HS', N'19131254', N'20', N'E', N'20E', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168646
', N'578449', N'mele20e')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139815, N'HS', N'19131289', N'19', N'E', N'19E', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170359
', N'575555', N'hercegovščak19e')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139816, N'HS', N'11588093', N'14', N' ', N'14', N'16184799', N'10092752', N'11026826', N'21429392', N'10253284', N'171423
', N'575965', N'kerenčičevaulica14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139817, N'HS', N'19131262', N'22', N'A', N'22A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164861
', N'570877', N'lokavci22a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139818, N'HS', N'11588000', N'6', N' ', N'6', N'16184799', N'10092752', N'11026826', N'21429392', N'10253284', N'171377
', N'575995', N'kerenčičevaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139819, N'HS', N'11588042', N'10', N' ', N'10', N'16184799', N'10092752', N'11026826', N'21429392', N'10253284', N'171401
', N'575979', N'kerenčičevaulica10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139820, N'HS', N'11588115', N'16', N' ', N'16', N'16184799', N'10092752', N'11026826', N'21429392', N'10253284', N'171433
', N'575961', N'kerenčičevaulica16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139821, N'HS', N'19130355', N'28', N'A', N'28A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165243
', N'574163', N'ivanjševskivrh28a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139822, N'HS', N'19130797', N'1', N'C', N'1C', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166599
', N'570365', N'zagajskivrh1c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139823, N'HS', N'19130533', N'7', N'A', N'7A', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169683
', N'575952', N'noričkivrh7a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139824, N'HS', N'19130851', N'4', N'A', N'4A', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166993
', N'575667', N'orehovskivrh4a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139825, N'HS', N'19130886', N'21', N'D', N'21D', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167893
', N'571012', N'spodnjaščavnica21d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139826, N'HS', N'19131173', N'2', N'A', N'2A', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169457
', N'576627', N'črešnjevci2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139827, N'HS', N'19131599', N'7', N'B', N'7B', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163062
', N'572210', N'negova7b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139828, N'HS', N'11618375', N'68', N' ', N'68', N'16276103', N'10093236', N'11026826', N'21428353', N'19127451', N'169123
', N'569434', N'plitvičkivrh68')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139829, N'HS', N'11638198', N'14', N' ', N'14', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'162939
', N'575255', N'stavešinci14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139830, N'HS', N'19135977', N'18', N'B', N'18B', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168723
', N'578511', N'mele18b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139831, N'HS', N'11596207', N'29', N' ', N'29', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170514
', N'575144', N'hercegovščak29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139832, N'HS', N'11604455', N'34', N' ', N'34', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162155
', N'573232', N'kunova34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139833, N'HS', N'19131521', N'123', N'A', N'123A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'168723
', N'573468', N'police123a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139834, N'HS', N'11635369', N'44', N'A', N'44A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167629
', N'572338', N'spodnjaščavnica44a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139835, N'HS', N'11598862', N'15', N' ', N'15', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164929
', N'574255', N'ivanjševskivrh15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139836, N'HS', N'19133982', N'2', N'B', N'2B', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169489
', N'576685', N'črešnjevci2b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139837, N'HS', N'19129519', N'29', N' ', N'29', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163037
', N'572172', N'negova29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139838, N'HS', N'19129969', N'16', N' ', N'16', N'16184829', N'10092752', N'11026826', N'21429392', N'10257204', N'169941
', N'576661', N'ljutomerskacesta16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139839, N'HS', N'11609627', N'22', N' ', N'22', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168795
', N'578459', N'mele22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139840, N'HS', N'11609635', N'23', N' ', N'23', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168811
', N'578433', N'mele23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139841, N'HS', N'11609643', N'24', N' ', N'24', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168828
', N'578407', N'mele24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139842, N'HS', N'11609651', N'25', N' ', N'25', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168855
', N'578365', N'mele25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139843, N'HS', N'11609660', N'26', N' ', N'26', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168870
', N'578340', N'mele26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139844, N'HS', N'11609678', N'27', N'A', N'27A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168868
', N'578259', N'mele27a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139845, N'HS', N'11609694', N'28', N' ', N'28', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168906
', N'578241', N'mele28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139846, N'HS', N'11609716', N'30', N'A', N'30A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168717
', N'578308', N'mele30a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139847, N'HS', N'19122166', N'35', N'A', N'35A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168592
', N'578396', N'mele35a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139848, N'HS', N'19129624', N'13', N'A', N'13A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167124
', N'575137', N'zbigovci13a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139849, N'HS', N'19129136', N'6', N'A', N'6A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165125
', N'571763', N'radvenci6a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139850, N'HS', N'19129675', N'38', N'A', N'38A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163052
', N'572047', N'negova38a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139851, N'HS', N'19117952', N'11', N' ', N'11', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171140
', N'575374', N'strmaulica11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139852, N'HS', N'19118282', N'37', N'A', N'37A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170408
', N'574258', N'hercegovščak37a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139853, N'HS', N'19129705', N'11', N'A', N'11A', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171029
', N'575899', N'šlebingerjevbreg11a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139854, N'HS', N'19129985', N'41', N'B', N'41B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165421
', N'574472', N'ivanjševskivrh41b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139855, N'HS', N'16390976', N'16', N' ', N'16', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170949
', N'576115', N'trgsvobode16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139856, N'HS', N'19130029', N'19', N'C', N'19C', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167921
', N'571296', N'spodnjaščavnica19c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139857, N'HS', N'19129918', N'16', N'A', N'16A', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170951
', N'576118', N'trgsvobode16a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139858, N'HS', N'16403806', N'16', N'B', N'16B', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170955
', N'576123', N'trgsvobode16b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139859, N'HS', N'19129659', N'11', N'A', N'11A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162744
', N'577132', N'očeslavci11a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139860, N'HS', N'11598447', N'19', N' ', N'19', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161089
', N'573979', N'ivanjskivrh19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139861, N'HS', N'19129900', N'6', N'A', N'6A', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161910
', N'575669', N'spodnjiivanjci6a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139862, N'HS', N'19137414', N'3', N'A', N'3A', N'16275956', N'10093082', N'11026826', N'21429392', N'10257247', N'169735
', N'577333', N'mele3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139863, N'HS', N'19129071', N'18', N'B', N'18B', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169813
', N'575823', N'noričkivrh18b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139864, N'HS', N'19136949', N'6', N'B', N'6B', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161766
', N'575457', N'spodnjiivanjci6b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139865, N'HS', N'11635261', N'38', N' ', N'38', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167772
', N'571774', N'spodnjaščavnica38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139866, N'HS', N'11636373', N'3', N'C', N'3C', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161564
', N'574551', N'spodnjiivanjci3c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139867, N'HS', N'19135519', N'48', N'A', N'48A', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170027
', N'574084', N'police48a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139868, N'HS', N'19135004', N'17', N'A', N'17A', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168945
', N'572046', N'plitvičkivrh17a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139869, N'HS', N'11605362', N'24', N' ', N'24', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'167078
', N'572976', N'lastomerci24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139870, N'HS', N'11583784', N'178', N' ', N'178', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168122
', N'575288', N'črešnjevci178')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139871, N'HS', N'11609350', N'6', N' ', N'6', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168920
', N'578325', N'mele6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139872, N'HS', N'11642977', N'16', N' ', N'16', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166991
', N'569695', N'zagajskivrh16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139873, N'HS', N'11629105', N'14', N' ', N'14', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164851
', N'571838', N'radvenci14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139874, N'HS', N'11584144', N'210', N' ', N'210', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168831
', N'575244', N'črešnjevci210')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139875, N'HS', N'19129128', N'11', N'A', N'11A', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166159
', N'574300', N'rodmošci11a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139876, N'HS', N'19128652', N'7', N' ', N'7', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165117
', N'571723', N'radvenci7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139877, N'HS', N'11596339', N'39', N' ', N'39', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170399
', N'574143', N'hercegovščak39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139878, N'HS', N'19136337', N'6', N' ', N'6', N'16184993', N'10092752', N'11026826', N'21429392', N'19132765', N'170665
', N'576705', N'cestanastadion6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139879, N'HS', N'19125068', N'6', N'A', N'6A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163099
', N'572403', N'negova6a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139880, N'HS', N'19125181', N'156', N'A', N'156A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168324
', N'575889', N'črešnjevci156a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139881, N'HS', N'19125203', N'34', N'A', N'34A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167950
', N'571981', N'spodnjaščavnica34a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139882, N'HS', N'19124746', N'19', N' ', N'19', N'16184934', N'10092752', N'11026826', N'21429392', N'10253268', N'170972
', N'576085', N'trgsvobode19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139883, N'HS', N'19124738', N'18', N' ', N'18', N'16184934', N'10092752', N'11026826', N'21429392', N'10253268', N'170961
', N'576076', N'trgsvobode18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139884, N'HS', N'19125386', N'28', N'A', N'28A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169133
', N'576321', N'črešnjevci28a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139885, N'HS', N'11605451', N'29', N'A', N'29A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166798
', N'573426', N'lastomerci29a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139886, N'HS', N'19119882', N'60', N' ', N'60', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167069
', N'573821', N'zbigovci60')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139887, N'HS', N'19122140', N'27', N'A', N'27A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169961
', N'572991', N'lomanoše27a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139888, N'HS', N'19135616', N'36', N'A', N'36A', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167585
', N'576058', N'orehovskivrh36a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139889, N'HS', N'19125866', N'15', N' ', N'15', N'16185086', N'10092752', N'11026826', N'21429392', N'10253047', N'171032
', N'576479', N'kocljevaulica15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139890, N'HS', N'19125882', N'19', N' ', N'19', N'16185086', N'10092752', N'11026826', N'21429392', N'10253047', N'171041
', N'576468', N'kocljevaulica19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139891, N'HS', N'19126277', N'32', N' ', N'32', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166612
', N'573322', N'lastomerci32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139892, N'HS', N'16551287', N'20', N' ', N'20', N'16184934', N'10092752', N'11026826', N'21429392', N'10253268', N'170976
', N'576091', N'trgsvobode20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139893, N'HS', N'19126056', N'126', N'A', N'126A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168513
', N'573427', N'police126a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139894, N'HS', N'11605281', N'18', N'A', N'18A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166147
', N'572589', N'lastomerci18a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139895, N'HS', N'11605206', N'12', N' ', N'12', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'165592
', N'573183', N'lastomerci12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139896, N'HS', N'19135691', N'8', N'B', N'8B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164720
', N'574405', N'ivanjševskivrh8b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139897, N'HS', N'19135705', N'19', N'A', N'19A', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169836
', N'575880', N'noričkivrh19a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139898, N'HS', N'11594255', N'16', N' ', N'16', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163406
', N'574305', N'gornjiivanjci16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139899, N'HS', N'11635229', N'36', N'A', N'36A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167905
', N'571737', N'spodnjaščavnica36a')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139900, N'HS', N'19125076', N'1', N'A', N'1A', N'16184713', N'10092752', N'11026826', N'21429392', N'10252687', N'171138
', N'575600', N'apaškacesta1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139901, N'HS', N'19133966', N'44', N'A', N'44A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166928
', N'568658', N'zagajskivrh44a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139902, N'HS', N'11590314', N'19', N' ', N'19', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170556
', N'576287', N'prešernovacesta19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139903, N'HS', N'11628958', N'2', N'A', N'2A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165413
', N'571273', N'radvenci2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139904, N'HS', N'11620825', N'89', N' ', N'89', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169419
', N'573936', N'police89')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139905, N'HS', N'19135594', N'93', N'B', N'93B', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169303
', N'574135', N'police93b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139906, N'HS', N'11616534', N'45', N' ', N'45', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167505
', N'576500', N'orehovskivrh45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139907, N'HS', N'19136825', N'42', N'C', N'42C', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163526
', N'577698', N'očeslavci42c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139908, N'HS', N'19136493', N'150', N'A', N'150A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168548
', N'575997', N'črešnjevci150a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139909, N'HS', N'11629229', N'23', N' ', N'23', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164956
', N'572239', N'radvenci23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139910, N'HS', N'19127877', N'215', N'A', N'215A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'169362
', N'574863', N'črešnjevci215a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139911, N'HS', N'19128245', N'10', N'A', N'10A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'165989
', N'573276', N'lastomerci10a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139912, N'HS', N'19128253', N'44', N'A', N'44A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166846
', N'574065', N'zbigovci44a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139913, N'HS', N'19120139', N'45', N'B', N'45B', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169744
', N'572386', N'lomanoše45b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139914, N'HS', N'19120147', N'76', N'A', N'76A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167694
', N'570924', N'spodnjaščavnica76a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139915, N'HS', N'19135900', N'40', N'A', N'40A', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167489
', N'576307', N'orehovskivrh40a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139916, N'HS', N'11583601', N'160', N' ', N'160', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168441
', N'575846', N'črešnjevci160')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139917, N'HS', N'19129845', N'50', N'A', N'50A', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170255
', N'575625', N'noričkivrh50a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139918, N'HS', N'19130592', N'42', N'B', N'42B', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163549
', N'577664', N'očeslavci42b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139919, N'HS', N'19130746', N'1', N'A', N'1A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'163880
', N'572032', N'lokavci1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139920, N'HS', N'19130622', N'40', N' ', N'40', N'16184926', N'10092752', N'11026826', N'21429392', N'10257182', N'170922
', N'576826', N'trate40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139921, N'HS', N'19129446', N'38', N' ', N'38', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169082
', N'578047', N'ljutomerskacesta38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139922, N'HS', N'19129497', N'17', N'C', N'17C', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161672
', N'572894', N'kunova17c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139923, N'HS', N'11629237', N'24', N' ', N'24', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164889
', N'572229', N'radvenci24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139924, N'HS', N'19130436', N'59', N'A', N'59A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167092
', N'572571', N'spodnjaščavnica59a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139925, N'HS', N'11604064', N'2', N' ', N'2', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161662
', N'572041', N'kunova2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139926, N'HS', N'11613144', N'111', N' ', N'111', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163565
', N'570686', N'negova111')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139927, N'HS', N'11604145', N'8', N' ', N'8', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161447
', N'572565', N'kunova8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139928, N'HS', N'11614337', N'21', N' ', N'21', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162421
', N'577452', N'očeslavci21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139929, N'HS', N'11643523', N'14', N' ', N'14', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167177
', N'575121', N'zbigovci14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139930, N'HS', N'19135934', N'43', N'A', N'43A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169149
', N'576414', N'črešnjevci43a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139931, N'HS', N'11635202', N'35', N' ', N'35', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167834
', N'571845', N'spodnjaščavnica35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139932, N'HS', N'11615902', N'6', N'B', N'6B', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167283
', N'576946', N'orehovci6b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139933, N'HS', N'11588697', N'3', N' ', N'3', N'16275956', N'10093082', N'11026826', N'21429392', N'19133648', N'169857
', N'577084', N'mele3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139934, N'HS', N'11629296', N'31', N' ', N'31', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164841
', N'572780', N'radvenci31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139935, N'HS', N'11636594', N'16', N'A', N'16A', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161323
', N'575512', N'spodnjiivanjci16a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139936, N'HS', N'11592112', N'2', N' ', N'2', N'16185035', N'10092752', N'11026826', N'21429392', N'10252687', N'171189
', N'575289', N'gasilskacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139937, N'HS', N'11592139', N'3', N' ', N'3', N'16185035', N'10092752', N'11026826', N'21429392', N'10252687', N'171163
', N'575330', N'gasilskacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139938, N'HS', N'11592155', N'5', N' ', N'5', N'16185035', N'10092752', N'11026826', N'21429392', N'10252687', N'171115
', N'575289', N'gasilskacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139939, N'HS', N'11592163', N'6', N' ', N'6', N'16185035', N'10092752', N'11026826', N'21429392', N'10252628', N'171082
', N'575174', N'gasilskacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139940, N'HS', N'11638988', N'56', N' ', N'56', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163489
', N'576258', N'stavešinskivrh56')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139941, N'HS', N'19136914', N'5', N'A', N'5A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166893
', N'570143', N'zagajskivrh5a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139942, N'HS', N'19120082', N'6', N'E', N'6E', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170548
', N'573576', N'lomanoše6e')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139943, N'HS', N'19130525', N'2', N' ', N'2', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169431
', N'576640', N'črešnjevci2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139944, N'HS', N'19130789', N'112', N'A', N'112A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163627
', N'570642', N'negova112a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139945, N'HS', N'19130690', N'41', N'B', N'41B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167821
', N'572051', N'spodnjaščavnica41b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139946, N'HS', N'11617662', N'2', N' ', N'2', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169596
', N'571838', N'plitvičkivrh2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139947, N'HS', N'11617719', N'5', N' ', N'5', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169355
', N'572016', N'plitvičkivrh5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139948, N'HS', N'11617735', N'7', N' ', N'7', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169329
', N'572006', N'plitvičkivrh7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139949, N'HS', N'11617743', N'8', N' ', N'8', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169282
', N'572041', N'plitvičkivrh8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139950, N'HS', N'11617778', N'11', N' ', N'11', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169188
', N'572051', N'plitvičkivrh11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139951, N'HS', N'11617808', N'14', N' ', N'14', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169033
', N'572051', N'plitvičkivrh14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139952, N'HS', N'11617816', N'15', N' ', N'15', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169022
', N'572046', N'plitvičkivrh15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139953, N'HS', N'11617930', N'27', N' ', N'27', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168492
', N'571921', N'plitvičkivrh27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139954, N'HS', N'11617972', N'31', N' ', N'31', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168824
', N'571764', N'plitvičkivrh31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139955, N'HS', N'11618022', N'35', N' ', N'35', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169006
', N'571902', N'plitvičkivrh35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139956, N'HS', N'11618057', N'37', N' ', N'37', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168948
', N'571839', N'plitvičkivrh37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139957, N'HS', N'11618073', N'39', N' ', N'39', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168944
', N'571782', N'plitvičkivrh39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139958, N'HS', N'11618103', N'43', N' ', N'43', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169082
', N'571647', N'plitvičkivrh43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139959, N'HS', N'11618111', N'44', N' ', N'44', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169063
', N'571742', N'plitvičkivrh44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139960, N'HS', N'11618162', N'49', N' ', N'49', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169174
', N'571597', N'plitvičkivrh49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139961, N'HS', N'11618286', N'59', N' ', N'59', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169165
', N'570360', N'plitvičkivrh59')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139962, N'HS', N'11618332', N'64', N' ', N'64', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169206
', N'570110', N'plitvičkivrh64')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139963, N'HS', N'11619045', N'4', N' ', N'4', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171269
', N'574881', N'podgrad4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139964, N'HS', N'11619487', N'47', N' ', N'47', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171211
', N'573670', N'podgrad47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139965, N'HS', N'11619509', N'49', N' ', N'49', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171194
', N'573648', N'podgrad49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139966, N'HS', N'11619517', N'50', N' ', N'50', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171233
', N'573617', N'podgrad50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139967, N'HS', N'11619576', N'56', N' ', N'56', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171288
', N'573411', N'podgrad56')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139968, N'HS', N'11620868', N'93', N' ', N'93', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169330
', N'574094', N'police93')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139969, N'HS', N'11620876', N'94', N' ', N'94', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169330
', N'574068', N'police94')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139970, N'HS', N'11621040', N'110', N' ', N'110', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168903
', N'574272', N'police110')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139971, N'HS', N'11621104', N'115', N' ', N'115', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168752
', N'573914', N'police115')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139972, N'HS', N'11621180', N'122', N' ', N'122', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168737
', N'573582', N'police122')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139973, N'HS', N'11621252', N'129', N' ', N'129', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168360
', N'573563', N'police129')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139974, N'HS', N'11621627', N'16', N' ', N'16', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166297
', N'576435', N'ptujskacesta16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139975, N'HS', N'11621635', N'17', N' ', N'17', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166278
', N'576394', N'ptujskacesta17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139976, N'HS', N'11621732', N'27', N' ', N'27', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166023
', N'576177', N'ptujskacesta27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139977, N'HS', N'11628982', N'3', N' ', N'3', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165631
', N'571687', N'radvenci3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139978, N'HS', N'11629032', N'8', N' ', N'8', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165138
', N'571681', N'radvenci8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139979, N'HS', N'11629091', N'13', N' ', N'13', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164875
', N'571740', N'radvenci13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139980, N'HS', N'11629113', N'15', N' ', N'15', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164915
', N'571917', N'radvenci15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139981, N'HS', N'11629172', N'20', N' ', N'20', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165269
', N'572218', N'radvenci20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139982, N'HS', N'11629300', N'32', N' ', N'32', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164818
', N'572890', N'radvenci32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139983, N'HS', N'11630014', N'18', N' ', N'18', N'16276227', N'10093350', N'11026826', N'21432237', N'19127338', N'165670
', N'573785', N'rodmošci18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139984, N'HS', N'11614370', N'25', N' ', N'25', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162542
', N'577754', N'očeslavci25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139985, N'HS', N'19136086', N'216', N'B', N'216B', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'169183
', N'575093', N'črešnjevci216b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139986, N'HS', N'19133273', N'52', N'A', N'52A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166549
', N'577448', N'ptujskacesta52a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139987, N'HS', N'11621821', N'31', N' ', N'31', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165658
', N'576272', N'ptujskacesta31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139988, N'HS', N'11621937', N'37', N' ', N'37', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165221
', N'576189', N'ptujskacesta37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139989, N'HS', N'11621945', N'38', N' ', N'38', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165367
', N'576543', N'ptujskacesta38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139990, N'HS', N'11621988', N'42', N' ', N'42', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165730
', N'576457', N'ptujskacesta42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139991, N'HS', N'11622178', N'54', N' ', N'54', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166659
', N'577643', N'ptujskacesta54')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139992, N'HS', N'19123626', N'17', N'A', N'17A', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170604
', N'576272', N'prešernovacesta17a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139993, N'HS', N'11620159', N'28', N' ', N'28', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170098
', N'574594', N'police28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139994, N'HS', N'11620175', N'30', N' ', N'30', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170261
', N'574451', N'police30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139995, N'HS', N'11620337', N'44', N' ', N'44', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169681
', N'574062', N'police44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139996, N'HS', N'11620574', N'68', N'A', N'68A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169497
', N'572972', N'police68a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139997, N'HS', N'11620736', N'81', N' ', N'81', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169349
', N'573534', N'police81')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139998, N'HS', N'11620809', N'87', N' ', N'87', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169473
', N'573812', N'police87')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (139999, N'HS', N'11617654', N'1', N' ', N'1', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169597
', N'571804', N'plitvičkivrh1')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140000, N'HS', N'11617689', N'3', N' ', N'3', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169404
', N'572103', N'plitvičkivrh3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140001, N'HS', N'11617697', N'4', N' ', N'4', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169420
', N'572058', N'plitvičkivrh4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140002, N'HS', N'11617727', N'6', N' ', N'6', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169352
', N'571950', N'plitvičkivrh6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140003, N'HS', N'11617786', N'12', N' ', N'12', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169149
', N'572060', N'plitvičkivrh12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140004, N'HS', N'11617794', N'13', N' ', N'13', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169098
', N'572055', N'plitvičkivrh13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140005, N'HS', N'11617832', N'17', N' ', N'17', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168961
', N'572052', N'plitvičkivrh17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140006, N'HS', N'11617859', N'18', N' ', N'18', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168898
', N'572044', N'plitvičkivrh18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140007, N'HS', N'11617867', N'19', N' ', N'19', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168842
', N'572212', N'plitvičkivrh19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140008, N'HS', N'11617875', N'20', N' ', N'20', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168843
', N'572064', N'plitvičkivrh20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140009, N'HS', N'11617883', N'21', N' ', N'21', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168834
', N'572060', N'plitvičkivrh21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140010, N'HS', N'11617913', N'24', N' ', N'24', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168634
', N'572267', N'plitvičkivrh24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140011, N'HS', N'11617921', N'25', N' ', N'25', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168648
', N'572067', N'plitvičkivrh25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140012, N'HS', N'11617948', N'28', N' ', N'28', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168667
', N'571657', N'plitvičkivrh28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140013, N'HS', N'11617956', N'29', N' ', N'29', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168681
', N'571695', N'plitvičkivrh29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140014, N'HS', N'11617964', N'30', N' ', N'30', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168737
', N'571733', N'plitvičkivrh30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140015, N'HS', N'11583318', N'133', N' ', N'133', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167617
', N'576393', N'črešnjevci133')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140016, N'HS', N'11583326', N'134', N' ', N'134', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167671
', N'575936', N'črešnjevci134')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140017, N'HS', N'11583342', N'137', N' ', N'137', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167807
', N'575926', N'črešnjevci137')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140018, N'HS', N'11583385', N'140', N' ', N'140', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167917
', N'575923', N'črešnjevci140')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140019, N'HS', N'11583393', N'141', N' ', N'141', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167941
', N'575921', N'črešnjevci141')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140020, N'HS', N'11583407', N'142', N' ', N'142', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167961
', N'575922', N'črešnjevci142')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140021, N'HS', N'11583431', N'145', N' ', N'145', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167967
', N'576018', N'črešnjevci145')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140022, N'HS', N'11583458', N'147', N' ', N'147', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167893
', N'576003', N'črešnjevci147')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140023, N'HS', N'11583539', N'153', N' ', N'153', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168391
', N'575932', N'črešnjevci153')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140024, N'HS', N'11583563', N'156', N' ', N'156', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168366
', N'575875', N'črešnjevci156')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140025, N'HS', N'11583571', N'157', N' ', N'157', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168350
', N'575855', N'črešnjevci157')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140026, N'HS', N'11583580', N'158', N' ', N'158', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168333
', N'575833', N'črešnjevci158')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140027, N'HS', N'11583598', N'159', N' ', N'159', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168318
', N'575816', N'črešnjevci159')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140028, N'HS', N'11583610', N'161', N' ', N'161', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168386
', N'575841', N'črešnjevci161')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140029, N'HS', N'11583709', N'170', N' ', N'170', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168529
', N'575660', N'črešnjevci170')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140030, N'HS', N'11583717', N'171', N' ', N'171', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168450
', N'575579', N'črešnjevci171')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140031, N'HS', N'11583725', N'172', N' ', N'172', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168461
', N'575557', N'črešnjevci172')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140032, N'HS', N'11583750', N'175', N' ', N'175', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168233
', N'575342', N'črešnjevci175')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140033, N'HS', N'11590349', N'21', N' ', N'21', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170538
', N'576280', N'prešernovacesta21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140034, N'HS', N'11590357', N'22', N' ', N'22', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170509
', N'576247', N'prešernovacesta22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140035, N'HS', N'11590365', N'23', N' ', N'23', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170515
', N'576281', N'prešernovacesta23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140036, N'HS', N'11590373', N'24', N' ', N'24', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170489
', N'576245', N'prešernovacesta24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140037, N'HS', N'11590381', N'25', N' ', N'25', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170523
', N'576296', N'prešernovacesta25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140038, N'HS', N'11590403', N'27', N' ', N'27', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170499
', N'576298', N'prešernovacesta27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140039, N'HS', N'11590411', N'28', N' ', N'28', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170449
', N'576245', N'prešernovacesta28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140040, N'HS', N'11590420', N'29', N' ', N'29', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170491
', N'576282', N'prešernovacesta29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140041, N'HS', N'11590446', N'32', N' ', N'32', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170427
', N'576213', N'prešernovacesta32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140042, N'HS', N'11590454', N'34', N' ', N'34', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170426
', N'576244', N'prešernovacesta34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140043, N'HS', N'11590462', N'36', N' ', N'36', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170405
', N'576244', N'prešernovacesta36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140044, N'HS', N'11590489', N'38', N' ', N'38', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170408
', N'576213', N'prešernovacesta38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140045, N'HS', N'11590519', N'42', N' ', N'42', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170385
', N'576246', N'prešernovacesta42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140046, N'HS', N'11593216', N'1', N' ', N'1', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170485
', N'576152', N'prežihovaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140047, N'HS', N'11593232', N'2', N' ', N'2', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170516
', N'575997', N'prežihovaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140048, N'HS', N'11593267', N'4', N' ', N'4', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170497
', N'575975', N'prežihovaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140049, N'HS', N'11593275', N'5', N' ', N'5', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170479
', N'576006', N'prežihovaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140050, N'HS', N'11593283', N'6', N' ', N'6', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170524
', N'575945', N'prežihovaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140051, N'HS', N'11593291', N'7', N' ', N'7', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170454
', N'575988', N'prežihovaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140052, N'HS', N'11593305', N'8', N' ', N'8', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170469
', N'575928', N'prežihovaulica8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140053, N'HS', N'11593321', N'10', N' ', N'10', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170452
', N'575892', N'prežihovaulica10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140054, N'HS', N'11593330', N'11', N' ', N'11', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170425
', N'575949', N'prežihovaulica11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140055, N'HS', N'11593348', N'12', N' ', N'12', N'16185205', N'10092752', N'11026826', N'21429392', N'10252601', N'170426
', N'575825', N'prežihovaulica12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140056, N'HS', N'11593356', N'13', N' ', N'13', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170410
', N'575925', N'prežihovaulica13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140057, N'HS', N'11593364', N'15', N' ', N'15', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170385
', N'575902', N'prežihovaulica15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140058, N'HS', N'11593372', N'2', N' ', N'2', N'16185213', N'10092752', N'11026826', N'21429392', N'10253080', N'170067
', N'576304', N'prvomajskaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140059, N'HS', N'11593399', N'3', N' ', N'3', N'16185213', N'10092752', N'11026826', N'21429392', N'10253071', N'170028
', N'576258', N'prvomajskaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140060, N'HS', N'11593402', N'4', N' ', N'4', N'16185213', N'10092752', N'11026826', N'21429392', N'10253080', N'170058
', N'576231', N'prvomajskaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140061, N'HS', N'11593429', N'5', N' ', N'5', N'16185213', N'10092752', N'11026826', N'21429392', N'10253071', N'170028
', N'576224', N'prvomajskaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140062, N'HS', N'11593437', N'1', N' ', N'1', N'16185221', N'10092752', N'11026826', N'21429392', N'10253250', N'171030
', N'575804', N'rozmanovaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140063, N'HS', N'11593453', N'3', N' ', N'3', N'16185221', N'10092752', N'11026826', N'21429392', N'10253250', N'170993
', N'575762', N'rozmanovaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140064, N'HS', N'11590527', N'1', N' ', N'1', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170954
', N'576041', N'simoničevbreg1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140065, N'HS', N'11590535', N'2', N' ', N'2', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170992
', N'575991', N'simoničevbreg2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140066, N'HS', N'11590543', N'3', N' ', N'3', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170901
', N'575984', N'simoničevbreg3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140067, N'HS', N'11590551', N'4', N' ', N'4', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170961
', N'575962', N'simoničevbreg4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140068, N'HS', N'11606695', N'5', N'A', N'5A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170688
', N'573632', N'lomanoše5a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140069, N'HS', N'11606725', N'6', N'A', N'6A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170587
', N'573601', N'lomanoše6a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140070, N'HS', N'11606733', N'6', N'B', N'6B', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170563
', N'573569', N'lomanoše6b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140071, N'HS', N'11606741', N'6', N'C', N'6C', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170544
', N'573555', N'lomanoše6c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140072, N'HS', N'16354830', N'6', N'D', N'6D', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170610
', N'573616', N'lomanoše6d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140073, N'HS', N'11606806', N'8', N' ', N'8', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170505
', N'573552', N'lomanoše8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140074, N'HS', N'11606784', N'8', N'A', N'8A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170543
', N'573531', N'lomanoše8a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140075, N'HS', N'11606792', N'8', N'B', N'8B', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170504
', N'573579', N'lomanoše8b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140076, N'HS', N'11606865', N'10', N' ', N'10', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170314
', N'573576', N'lomanoše10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140077, N'HS', N'11606873', N'11', N'A', N'11A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170428
', N'573357', N'lomanoše11a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140078, N'HS', N'11606911', N'12', N' ', N'12', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170262
', N'573276', N'lomanoše12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140079, N'HS', N'11606890', N'12', N'A', N'12A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170328
', N'573283', N'lomanoše12a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140080, N'HS', N'11606920', N'13', N' ', N'13', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170258
', N'573236', N'lomanoše13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140081, N'HS', N'11606946', N'14', N' ', N'14', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170228
', N'573255', N'lomanoše14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140082, N'HS', N'11606938', N'14', N'A', N'14A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170214
', N'573243', N'lomanoše14a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140083, N'HS', N'11606954', N'15', N'A', N'15A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170172
', N'573197', N'lomanoše15a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140084, N'HS', N'11606997', N'17', N' ', N'17', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170124
', N'573176', N'lomanoše17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140085, N'HS', N'11607004', N'18', N' ', N'18', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170156
', N'573119', N'lomanoše18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140086, N'HS', N'11607039', N'20', N' ', N'20', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170080
', N'573115', N'lomanoše20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140087, N'HS', N'11614396', N'27', N' ', N'27', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162614
', N'577687', N'očeslavci27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140088, N'HS', N'11614400', N'28', N' ', N'28', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162720
', N'577644', N'očeslavci28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140089, N'HS', N'11614418', N'29', N' ', N'29', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162815
', N'577626', N'očeslavci29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140090, N'HS', N'11614426', N'30', N' ', N'30', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162846
', N'577608', N'očeslavci30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140091, N'HS', N'11614442', N'32', N' ', N'32', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162954
', N'577663', N'očeslavci32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140092, N'HS', N'11614469', N'33', N' ', N'33', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162981
', N'577650', N'očeslavci33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140093, N'HS', N'11614477', N'34', N' ', N'34', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163016
', N'577697', N'očeslavci34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140094, N'HS', N'11614485', N'35', N' ', N'35', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163058
', N'577687', N'očeslavci35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140095, N'HS', N'11614523', N'39', N'A', N'39A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163272
', N'577739', N'očeslavci39a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140096, N'HS', N'11614558', N'40', N' ', N'40', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163317
', N'577662', N'očeslavci40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140097, N'HS', N'11614574', N'41', N' ', N'41', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163394
', N'577620', N'očeslavci41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140098, N'HS', N'11614566', N'41', N'A', N'41A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163447
', N'577668', N'očeslavci41a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140099, N'HS', N'11614582', N'42', N' ', N'42', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163527
', N'577669', N'očeslavci42')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140100, N'HS', N'11614604', N'43', N' ', N'43', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163589
', N'577664', N'očeslavci43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140101, N'HS', N'11614612', N'44', N' ', N'44', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163568
', N'577706', N'očeslavci44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140102, N'HS', N'11614647', N'45', N' ', N'45', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163516
', N'577790', N'očeslavci45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140103, N'HS', N'11614655', N'46', N' ', N'46', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163611
', N'577706', N'očeslavci46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140104, N'HS', N'11614671', N'47', N' ', N'47', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163668
', N'577638', N'očeslavci47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140105, N'HS', N'11614663', N'47', N'A', N'47A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163621
', N'577677', N'očeslavci47a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140106, N'HS', N'11607055', N'22', N' ', N'22', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170074
', N'573036', N'lomanoše22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140107, N'HS', N'11607063', N'23', N'A', N'23A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170108
', N'573010', N'lomanoše23a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140108, N'HS', N'11607080', N'24', N' ', N'24', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170072
', N'572980', N'lomanoše24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140109, N'HS', N'11607098', N'25', N' ', N'25', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170028
', N'573012', N'lomanoše25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140110, N'HS', N'11607101', N'26', N' ', N'26', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170076
', N'572958', N'lomanoše26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140111, N'HS', N'11607110', N'27', N' ', N'27', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170029
', N'572954', N'lomanoše27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140112, N'HS', N'11619029', N'2', N' ', N'2', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171266
', N'574959', N'podgrad2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140113, N'HS', N'11619037', N'3', N' ', N'3', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171325
', N'574877', N'podgrad3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140114, N'HS', N'11619053', N'5', N' ', N'5', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171321
', N'574822', N'podgrad5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140115, N'HS', N'11619061', N'6', N' ', N'6', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171295
', N'574826', N'podgrad6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140116, N'HS', N'11619070', N'7', N' ', N'7', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171294
', N'574818', N'podgrad7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140117, N'HS', N'11619088', N'8', N' ', N'8', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171318
', N'574782', N'podgrad8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140118, N'HS', N'11619096', N'9', N' ', N'9', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171290
', N'574794', N'podgrad9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140119, N'HS', N'11615856', N'3', N' ', N'3', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167240
', N'577065', N'orehovci3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140120, N'HS', N'11615899', N'6', N'A', N'6A', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167285
', N'577015', N'orehovci6a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140121, N'HS', N'11615937', N'7', N' ', N'7', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167120
', N'576650', N'orehovci7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140122, N'HS', N'11615945', N'8', N' ', N'8', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167023
', N'576580', N'orehovci8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140123, N'HS', N'11579604', N'22', N' ', N'22', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168352
', N'572719', N'aženskivrh22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140124, N'HS', N'11579582', N'22', N'A', N'22A', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168344
', N'572689', N'aženskivrh22a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140125, N'HS', N'11582001', N'4', N' ', N'4', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169284
', N'576575', N'črešnjevci4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140126, N'HS', N'11582010', N'5', N' ', N'5', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169191
', N'576494', N'črešnjevci5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140127, N'HS', N'11582028', N'6', N' ', N'6', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169295
', N'576482', N'črešnjevci6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140128, N'HS', N'11582036', N'7', N' ', N'7', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169240
', N'576422', N'črešnjevci7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140129, N'HS', N'11582044', N'8', N' ', N'8', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169375
', N'576426', N'črešnjevci8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140130, N'HS', N'11582079', N'11', N' ', N'11', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169351
', N'576333', N'črešnjevci11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140131, N'HS', N'11582087', N'12', N' ', N'12', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169325
', N'576310', N'črešnjevci12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140132, N'HS', N'11582095', N'13', N' ', N'13', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169306
', N'576285', N'črešnjevci13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140133, N'HS', N'11582117', N'14', N' ', N'14', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169363
', N'576371', N'črešnjevci14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140134, N'HS', N'11582109', N'14', N'A', N'14A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169401
', N'576378', N'črešnjevci14a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140135, N'HS', N'11582125', N'15', N' ', N'15', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169335
', N'576366', N'črešnjevci15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140136, N'HS', N'11582141', N'17', N' ', N'17', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169308
', N'576335', N'črešnjevci17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140137, N'HS', N'11582150', N'18', N' ', N'18', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169287
', N'576336', N'črešnjevci18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140138, N'HS', N'11582168', N'19', N' ', N'19', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169292
', N'576361', N'črešnjevci19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140139, N'HS', N'11582176', N'20', N' ', N'20', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169270
', N'576363', N'črešnjevci20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140140, N'HS', N'11582184', N'21', N' ', N'21', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169265
', N'576336', N'črešnjevci21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140141, N'HS', N'11582192', N'23', N' ', N'23', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169248
', N'576365', N'črešnjevci23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140142, N'HS', N'11582206', N'24', N' ', N'24', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169218
', N'576371', N'črešnjevci24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140143, N'HS', N'19119769', N'75', N'A', N'75A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167988
', N'574140', N'zbigovci75a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140144, N'HS', N'19135179', N'20', N' ', N'20', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164534
', N'574591', N'ivanjševciobščavnici20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140145, N'HS', N'11582214', N'25', N' ', N'25', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169199
', N'576339', N'črešnjevci25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140146, N'HS', N'11582222', N'26', N' ', N'26', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169176
', N'576329', N'črešnjevci26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140147, N'HS', N'11582249', N'27', N' ', N'27', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169158
', N'576369', N'črešnjevci27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140148, N'HS', N'11582257', N'28', N' ', N'28', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169135
', N'576350', N'črešnjevci28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140149, N'HS', N'11582265', N'29', N' ', N'29', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169122
', N'576361', N'črešnjevci29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140150, N'HS', N'11582273', N'30', N' ', N'30', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169172
', N'576303', N'črešnjevci30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140151, N'HS', N'11582281', N'31', N' ', N'31', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169214
', N'576308', N'črešnjevci31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140152, N'HS', N'11582290', N'32', N' ', N'32', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169194
', N'576286', N'črešnjevci32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140153, N'HS', N'11582303', N'33', N' ', N'33', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169138
', N'576120', N'črešnjevci33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140154, N'HS', N'11582311', N'34', N' ', N'34', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169139
', N'576151', N'črešnjevci34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140155, N'HS', N'11582338', N'36', N' ', N'36', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169035
', N'576245', N'črešnjevci36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140156, N'HS', N'11582346', N'37', N' ', N'37', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169019
', N'576219', N'črešnjevci37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140157, N'HS', N'11582354', N'38', N' ', N'38', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168971
', N'576261', N'črešnjevci38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140158, N'HS', N'11582389', N'40', N' ', N'40', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168894
', N'576291', N'črešnjevci40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140159, N'HS', N'11582397', N'41', N' ', N'41', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169002
', N'576301', N'črešnjevci41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140160, N'HS', N'11589197', N'23', N' ', N'23', N'16184853', N'10092752', N'11026826', N'21429392', N'10253268', N'171105
', N'576134', N'panonskaulica23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140161, N'HS', N'11589219', N'24', N' ', N'24', N'16184853', N'10092752', N'11026826', N'21429392', N'10253225', N'171202
', N'576149', N'panonskaulica24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140162, N'HS', N'11589235', N'26', N' ', N'26', N'16184853', N'10092752', N'11026826', N'21429392', N'10253225', N'171220
', N'576129', N'panonskaulica26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140163, N'HS', N'11589243', N'27', N' ', N'27', N'16184853', N'10092752', N'11026826', N'21429392', N'10253268', N'171198
', N'576107', N'panonskaulica27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140164, N'HS', N'11589251', N'28', N' ', N'28', N'16184853', N'10092752', N'11026826', N'21429392', N'10253276', N'171248
', N'576117', N'panonskaulica28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140165, N'HS', N'11589278', N'30', N' ', N'30', N'16184853', N'10092752', N'11026826', N'21429392', N'10253276', N'171263
', N'576105', N'panonskaulica30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140166, N'HS', N'11589286', N'31', N' ', N'31', N'16184853', N'10092752', N'11026826', N'21429392', N'10253268', N'171270
', N'576034', N'panonskaulica31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140167, N'HS', N'11589294', N'32', N' ', N'32', N'16184853', N'10092752', N'11026826', N'21429392', N'10253276', N'171277
', N'576096', N'panonskaulica32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140168, N'HS', N'11589324', N'36', N' ', N'36', N'16184853', N'10092752', N'11026826', N'21429392', N'10253276', N'171324
', N'576055', N'panonskaulica36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140169, N'HS', N'11589332', N'38', N' ', N'38', N'16184853', N'10092752', N'11026826', N'21429392', N'10253276', N'171338
', N'576045', N'panonskaulica38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140170, N'HS', N'11589359', N'1', N' ', N'1', N'16184861', N'10092752', N'11026826', N'21429392', N'10253268', N'171025
', N'576037', N'partizanskacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140171, N'HS', N'11589375', N'3', N' ', N'3', N'16184861', N'10092752', N'11026826', N'21429392', N'10253268', N'170965
', N'576071', N'partizanskacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140172, N'HS', N'11589383', N'4', N' ', N'4', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170907
', N'576078', N'partizanskacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140173, N'HS', N'11589405', N'6', N' ', N'6', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170887
', N'576090', N'partizanskacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140174, N'HS', N'11589421', N'8', N' ', N'8', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170868
', N'576101', N'partizanskacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140175, N'HS', N'11589430', N'9', N' ', N'9', N'16184861', N'10092752', N'11026826', N'21429392', N'10253268', N'170933
', N'576089', N'partizanskacesta9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140176, N'HS', N'11589448', N'10', N' ', N'10', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170847
', N'576095', N'partizanskacesta10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140177, N'HS', N'11589456', N'11', N' ', N'11', N'16184861', N'10092752', N'11026826', N'21429392', N'10253217', N'170911
', N'576116', N'partizanskacesta11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140178, N'HS', N'11589464', N'12', N' ', N'12', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170851
', N'576116', N'partizanskacesta12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140179, N'HS', N'11589472', N'13', N' ', N'13', N'16184861', N'10092752', N'11026826', N'21429392', N'10253217', N'170872
', N'576133', N'partizanskacesta13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140180, N'HS', N'11589499', N'14', N' ', N'14', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170834
', N'576126', N'partizanskacesta14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140181, N'HS', N'11589502', N'15', N' ', N'15', N'16184861', N'10092752', N'11026826', N'21429392', N'10253217', N'170832
', N'576176', N'partizanskacesta15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140182, N'HS', N'19135454', N'12', N'D', N'12D', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'165455
', N'573210', N'lastomerci12d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140183, N'HS', N'11589529', N'16', N' ', N'16', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170826
', N'576096', N'partizanskacesta16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140184, N'HS', N'11589545', N'18', N' ', N'18', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170770
', N'576115', N'partizanskacesta18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140185, N'HS', N'11589561', N'20', N' ', N'20', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170812
', N'576142', N'partizanskacesta20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140186, N'HS', N'11589588', N'22', N' ', N'22', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170799
', N'576151', N'partizanskacesta22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140187, N'HS', N'11589600', N'24', N' ', N'24', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170790
', N'576159', N'partizanskacesta24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140188, N'HS', N'11589634', N'27', N' ', N'27', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170673
', N'576291', N'partizanskacesta27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140189, N'HS', N'11605354', N'24', N'A', N'24A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'167149
', N'572998', N'lastomerci24a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140190, N'HS', N'11605397', N'25', N' ', N'25', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'167198
', N'573075', N'lastomerci25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140191, N'HS', N'11605389', N'25', N'A', N'25A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'167233
', N'573041', N'lastomerci25a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140192, N'HS', N'11605419', N'26', N' ', N'26', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'167342
', N'573030', N'lastomerci26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140193, N'HS', N'11605427', N'27', N' ', N'27', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166997
', N'573218', N'lastomerci27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140194, N'HS', N'11605443', N'28', N' ', N'28', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166684
', N'573362', N'lastomerci28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140195, N'HS', N'11605486', N'30', N' ', N'30', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166956
', N'573486', N'lastomerci30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140196, N'HS', N'11605494', N'31', N' ', N'31', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166615
', N'573356', N'lastomerci31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140197, N'HS', N'11643680', N'23', N' ', N'23', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167834
', N'574896', N'zbigovci23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140198, N'HS', N'11615988', N'11', N' ', N'11', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'166990
', N'576553', N'orehovci11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140199, N'HS', N'11615970', N'11', N'A', N'11A', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'166985
', N'576496', N'orehovci11a')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140200, N'HS', N'11615996', N'12', N' ', N'12', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'166944
', N'576533', N'orehovci12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140201, N'HS', N'11616003', N'13', N' ', N'13', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'166932
', N'576422', N'orehovci13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140202, N'HS', N'11616011', N'14', N' ', N'14', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'166752
', N'576505', N'orehovci14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140203, N'HS', N'11616020', N'15', N' ', N'15', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'166764
', N'576474', N'orehovci15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140204, N'HS', N'11616038', N'1', N' ', N'1', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166897
', N'576017', N'orehovskivrh1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140205, N'HS', N'11616046', N'2', N'A', N'2A', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166823
', N'576016', N'orehovskivrh2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140206, N'HS', N'11616062', N'3', N' ', N'3', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166858
', N'575933', N'orehovskivrh3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140207, N'HS', N'11616097', N'5', N' ', N'5', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166993
', N'575625', N'orehovskivrh5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140208, N'HS', N'11616119', N'6', N' ', N'6', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166987
', N'575558', N'orehovskivrh6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140209, N'HS', N'11616160', N'10', N' ', N'10', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166493
', N'575315', N'orehovskivrh10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140210, N'HS', N'11616178', N'11', N' ', N'11', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166485
', N'575345', N'orehovskivrh11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140211, N'HS', N'11616186', N'12', N' ', N'12', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166551
', N'575332', N'orehovskivrh12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140212, N'HS', N'11616208', N'14', N' ', N'14', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166886
', N'575394', N'orehovskivrh14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140213, N'HS', N'11616216', N'15', N' ', N'15', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166982
', N'575368', N'orehovskivrh15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140214, N'HS', N'11616224', N'16', N' ', N'16', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166999
', N'575405', N'orehovskivrh16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140215, N'HS', N'11616259', N'18', N' ', N'18', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167046
', N'575492', N'orehovskivrh18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140216, N'HS', N'11616267', N'19', N' ', N'19', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167043
', N'575547', N'orehovskivrh19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140217, N'HS', N'11616275', N'20', N' ', N'20', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167077
', N'575519', N'orehovskivrh20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140218, N'HS', N'11616283', N'21', N' ', N'21', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167295
', N'575587', N'orehovskivrh21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140219, N'HS', N'11616305', N'23', N' ', N'23', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167484
', N'575669', N'orehovskivrh23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140220, N'HS', N'11616313', N'24', N' ', N'24', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167505
', N'575679', N'orehovskivrh24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140221, N'HS', N'11616364', N'29', N' ', N'29', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167296
', N'575894', N'orehovskivrh29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140222, N'HS', N'11616399', N'31', N' ', N'31', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167583
', N'575854', N'orehovskivrh31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140223, N'HS', N'11616402', N'32', N' ', N'32', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167602
', N'575891', N'orehovskivrh32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140224, N'HS', N'11582419', N'42', N' ', N'42', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169097
', N'576352', N'črešnjevci42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140225, N'HS', N'11582427', N'43', N' ', N'43', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169166
', N'576413', N'črešnjevci43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140226, N'HS', N'11582443', N'45', N' ', N'45', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169126
', N'576467', N'črešnjevci45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140227, N'HS', N'11582451', N'46', N' ', N'46', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169080
', N'576484', N'črešnjevci46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140228, N'HS', N'11582460', N'47', N' ', N'47', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169062
', N'576495', N'črešnjevci47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140229, N'HS', N'11582478', N'48', N' ', N'48', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169046
', N'576496', N'črešnjevci48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140230, N'HS', N'11582486', N'49', N' ', N'49', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169034
', N'576414', N'črešnjevci49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140231, N'HS', N'11582508', N'51', N' ', N'51', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168987
', N'576425', N'črešnjevci51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140232, N'HS', N'11582516', N'52', N' ', N'52', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168965
', N'576426', N'črešnjevci52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140233, N'HS', N'11582524', N'55', N' ', N'55', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168873
', N'576424', N'črešnjevci55')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140234, N'HS', N'11582559', N'56', N' ', N'56', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168844
', N'576429', N'črešnjevci56')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140235, N'HS', N'11582575', N'58', N' ', N'58', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168810
', N'576437', N'črešnjevci58')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140236, N'HS', N'11582591', N'60', N' ', N'60', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168938
', N'576385', N'črešnjevci60')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140237, N'HS', N'11582630', N'64', N' ', N'64', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168822
', N'576378', N'črešnjevci64')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140238, N'HS', N'11582621', N'64', N'A', N'64A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168854
', N'576388', N'črešnjevci64a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140239, N'HS', N'11582648', N'65', N' ', N'65', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168799
', N'576368', N'črešnjevci65')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140240, N'HS', N'11582656', N'67', N' ', N'67', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168748
', N'576282', N'črešnjevci67')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140241, N'HS', N'11582699', N'74', N' ', N'74', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168621
', N'576280', N'črešnjevci74')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140242, N'HS', N'11582702', N'75', N' ', N'75', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168590
', N'576268', N'črešnjevci75')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140243, N'HS', N'11582729', N'76', N' ', N'76', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168606
', N'576250', N'črešnjevci76')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140244, N'HS', N'11582788', N'81', N' ', N'81', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168700
', N'575933', N'črešnjevci81')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140245, N'HS', N'11582770', N'81', N'A', N'81A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168654
', N'575942', N'črešnjevci81a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140246, N'HS', N'11582796', N'82', N' ', N'82', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168600
', N'576024', N'črešnjevci82')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140247, N'HS', N'11582826', N'85', N' ', N'85', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168570
', N'576293', N'črešnjevci85')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140248, N'HS', N'11589642', N'28', N' ', N'28', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170666
', N'576254', N'partizanskacesta28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140249, N'HS', N'11589669', N'29', N' ', N'29', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170659
', N'576302', N'partizanskacesta29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140250, N'HS', N'11589677', N'30', N' ', N'30', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170640
', N'576272', N'partizanskacesta30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140251, N'HS', N'11589693', N'32', N' ', N'32', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170613
', N'576292', N'partizanskacesta32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140252, N'HS', N'11589707', N'33', N' ', N'33', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170612
', N'576321', N'partizanskacesta33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140253, N'HS', N'11589715', N'34', N' ', N'34', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170595
', N'576299', N'partizanskacesta34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140254, N'HS', N'11589723', N'35', N' ', N'35', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170591
', N'576331', N'partizanskacesta35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140255, N'HS', N'11589731', N'36', N' ', N'36', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170549
', N'576318', N'partizanskacesta36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140256, N'HS', N'11589740', N'37', N' ', N'37', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170567
', N'576342', N'partizanskacesta37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140257, N'HS', N'11589758', N'38', N' ', N'38', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170518
', N'576339', N'partizanskacesta38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140258, N'HS', N'11589766', N'39', N' ', N'39', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170548
', N'576353', N'partizanskacesta39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140259, N'HS', N'11589782', N'41', N' ', N'41', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170528
', N'576364', N'partizanskacesta41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140260, N'HS', N'11589812', N'43', N'A', N'43A', N'16184861', N'10092752', N'11026826', N'21429392', N'10253063', N'170492
', N'576380', N'partizanskacesta43a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140261, N'HS', N'11589839', N'43', N'B', N'43B', N'16184861', N'10092752', N'11026826', N'21429392', N'10253063', N'170510
', N'576408', N'partizanskacesta43b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140262, N'HS', N'11589855', N'45', N' ', N'45', N'16184861', N'10092752', N'11026826', N'21429392', N'10253063', N'170473
', N'576388', N'partizanskacesta45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140263, N'HS', N'11589871', N'47', N' ', N'47', N'16184861', N'10092752', N'11026826', N'21429392', N'10253063', N'170383
', N'576421', N'partizanskacesta47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140264, N'HS', N'11589901', N'51', N' ', N'51', N'16184861', N'10092752', N'11026826', N'21429392', N'10253063', N'170325
', N'576451', N'partizanskacesta51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140265, N'HS', N'11589910', N'53', N' ', N'53', N'16184861', N'10092752', N'11026826', N'21429392', N'10253063', N'170315
', N'576459', N'partizanskacesta53')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140266, N'HS', N'11589928', N'55', N' ', N'55', N'16184861', N'10092752', N'11026826', N'21429392', N'10253063', N'170297
', N'576470', N'partizanskacesta55')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140267, N'HS', N'11589936', N'57', N' ', N'57', N'16184861', N'10092752', N'11026826', N'21429392', N'10253063', N'170270
', N'576470', N'partizanskacesta57')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140268, N'HS', N'11589944', N'1', N' ', N'1', N'16184870', N'10092752', N'11026826', N'21429392', N'10253101', N'169795
', N'576283', N'pintaričevacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140269, N'HS', N'11589952', N'2', N' ', N'2', N'16184870', N'10092752', N'11026826', N'21429392', N'10253071', N'169858
', N'576293', N'pintaričevacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140270, N'HS', N'11589979', N'3', N' ', N'3', N'16184870', N'10092752', N'11026826', N'21429392', N'10253101', N'169767
', N'576279', N'pintaričevacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140271, N'HS', N'11589987', N'4', N' ', N'4', N'16184870', N'10092752', N'11026826', N'21429392', N'10253071', N'169855
', N'576272', N'pintaričevacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140272, N'HS', N'11589995', N'5', N' ', N'5', N'16184870', N'10092752', N'11026826', N'21429392', N'10253101', N'169819
', N'576265', N'pintaričevacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140273, N'HS', N'11590004', N'6', N' ', N'6', N'16184870', N'10092752', N'11026826', N'21429392', N'10253071', N'169892
', N'576220', N'pintaričevacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140274, N'HS', N'11590012', N'8', N' ', N'8', N'16184870', N'10092752', N'11026826', N'21429392', N'10253071', N'169899
', N'576202', N'pintaričevacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140275, N'HS', N'11590039', N'10', N' ', N'10', N'16184870', N'10092752', N'11026826', N'21429392', N'10253071', N'169859
', N'576191', N'pintaričevacesta10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140276, N'HS', N'11592988', N'1', N' ', N'1', N'16185167', N'10092752', N'11026826', N'21429392', N'10252652', N'170366
', N'575907', N'podgozdom1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140277, N'HS', N'11593003', N'3', N' ', N'3', N'16185167', N'10092752', N'11026826', N'21429392', N'10252652', N'170402
', N'575958', N'podgozdom3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140278, N'HS', N'11590047', N'1', N' ', N'1', N'16184888', N'10092752', N'11026826', N'21429392', N'10252679', N'170882
', N'576067', N'pokopališkacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140279, N'HS', N'11590063', N'3', N' ', N'3', N'16184888', N'10092752', N'11026826', N'21429392', N'10252679', N'170789
', N'576088', N'pokopališkacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140280, N'HS', N'11606075', N'1', N' ', N'1', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'163967
', N'571968', N'lokavci1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140281, N'HS', N'11606091', N'3', N' ', N'3', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'163783
', N'572664', N'lokavci3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140282, N'HS', N'11606105', N'4', N'A', N'4A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164116
', N'572155', N'lokavci4a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140283, N'HS', N'11606121', N'5', N' ', N'5', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164176
', N'572197', N'lokavci5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140284, N'HS', N'11606130', N'6', N' ', N'6', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164195
', N'572183', N'lokavci6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140285, N'HS', N'11606148', N'7', N' ', N'7', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164246
', N'572166', N'lokavci7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140286, N'HS', N'11606156', N'8', N' ', N'8', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164291
', N'572183', N'lokavci8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140287, N'HS', N'11606199', N'9', N' ', N'9', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164379
', N'572186', N'lokavci9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140288, N'HS', N'11606202', N'10', N' ', N'10', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164454
', N'572087', N'lokavci10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140289, N'HS', N'11606237', N'11', N' ', N'11', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164456
', N'572051', N'lokavci11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140290, N'HS', N'11606229', N'11', N'A', N'11A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164413
', N'572036', N'lokavci11a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140291, N'HS', N'11606261', N'13', N' ', N'13', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164312
', N'571893', N'lokavci13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140292, N'HS', N'11616437', N'35', N' ', N'35', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167579
', N'576014', N'orehovskivrh35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140293, N'HS', N'11616445', N'36', N' ', N'36', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167582
', N'576035', N'orehovskivrh36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140294, N'HS', N'11616470', N'39', N' ', N'39', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167464
', N'576251', N'orehovskivrh39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140295, N'HS', N'11616488', N'40', N' ', N'40', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167473
', N'576306', N'orehovskivrh40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140296, N'HS', N'11616500', N'42', N' ', N'42', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167399
', N'576345', N'orehovskivrh42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140297, N'HS', N'11616518', N'43', N' ', N'43', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167394
', N'576385', N'orehovskivrh43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140298, N'HS', N'16171506', N'45', N'A', N'45A', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167499
', N'576520', N'orehovskivrh45a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140299, N'HS', N'11616569', N'47', N' ', N'47', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167587
', N'576367', N'orehovskivrh47')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140300, N'HS', N'11582907', N'92', N' ', N'92', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168636
', N'576402', N'črešnjevci92')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140301, N'HS', N'11582915', N'93', N' ', N'93', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168680
', N'576376', N'črešnjevci93')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140302, N'HS', N'11582923', N'96', N' ', N'96', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168728
', N'576468', N'črešnjevci96')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140303, N'HS', N'11582931', N'98', N' ', N'98', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168767
', N'576405', N'črešnjevci98')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140304, N'HS', N'11582940', N'100', N' ', N'100', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168800
', N'576505', N'črešnjevci100')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140305, N'HS', N'11582958', N'101', N' ', N'101', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168563
', N'576509', N'črešnjevci101')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140306, N'HS', N'11583008', N'105', N' ', N'105', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168506
', N'576511', N'črešnjevci105')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140307, N'HS', N'11583016', N'106', N' ', N'106', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168530
', N'576514', N'črešnjevci106')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140308, N'HS', N'11583032', N'108', N' ', N'108', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168481
', N'576539', N'črešnjevci108')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140309, N'HS', N'11583059', N'109', N' ', N'109', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168458
', N'576545', N'črešnjevci109')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140310, N'HS', N'11583067', N'110', N' ', N'110', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168435
', N'576556', N'črešnjevci110')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140311, N'HS', N'11583091', N'113', N' ', N'113', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168399
', N'576611', N'črešnjevci113')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140312, N'HS', N'11583113', N'115', N' ', N'115', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168361
', N'576623', N'črešnjevci115')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140313, N'HS', N'11583121', N'116', N' ', N'116', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168345
', N'576593', N'črešnjevci116')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140314, N'HS', N'11583130', N'117', N' ', N'117', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168317
', N'576661', N'črešnjevci117')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140315, N'HS', N'11583148', N'118', N' ', N'118', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168274
', N'576627', N'črešnjevci118')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140316, N'HS', N'11583156', N'119', N' ', N'119', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168300
', N'576665', N'črešnjevci119')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140317, N'HS', N'11583164', N'120', N' ', N'120', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168220
', N'576627', N'črešnjevci120')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140318, N'HS', N'11583172', N'121', N' ', N'121', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168250
', N'576667', N'črešnjevci121')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140319, N'HS', N'11583199', N'122', N' ', N'122', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168174
', N'576657', N'črešnjevci122')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140320, N'HS', N'11583202', N'123', N' ', N'123', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168208
', N'576708', N'črešnjevci123')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140321, N'HS', N'11583229', N'124', N' ', N'124', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168139
', N'576680', N'črešnjevci124')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140322, N'HS', N'11583237', N'125', N' ', N'125', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168180
', N'576699', N'črešnjevci125')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140323, N'HS', N'11583245', N'126', N' ', N'126', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168110
', N'576693', N'črešnjevci126')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140324, N'HS', N'11583253', N'127', N' ', N'127', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168147
', N'576722', N'črešnjevci127')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140325, N'HS', N'11583261', N'128', N' ', N'128', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168080
', N'576165', N'črešnjevci128')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140326, N'HS', N'11583288', N'130', N' ', N'130', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167870
', N'576330', N'črešnjevci130')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140327, N'HS', N'11583296', N'131', N' ', N'131', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167714
', N'576266', N'črešnjevci131')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140328, N'HS', N'11583300', N'132', N' ', N'132', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167624
', N'576409', N'črešnjevci132')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140329, N'HS', N'11590080', N'5', N' ', N'5', N'16184888', N'10092752', N'11026826', N'21429392', N'10252679', N'170663
', N'575935', N'pokopališkacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140330, N'HS', N'11590098', N'8', N' ', N'8', N'16184888', N'10092752', N'11026826', N'21429392', N'10252679', N'170837
', N'576056', N'pokopališkacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140331, N'HS', N'11590101', N'10', N' ', N'10', N'16184888', N'10092752', N'11026826', N'21429392', N'10252679', N'170782
', N'576044', N'pokopališkacesta10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140332, N'HS', N'11593011', N'2', N' ', N'2', N'16185175', N'10092752', N'11026826', N'21429392', N'10253101', N'169711
', N'576266', N'poličkacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140333, N'HS', N'11593020', N'3', N' ', N'3', N'16185175', N'10092752', N'11026826', N'21429392', N'10253101', N'169717
', N'576235', N'poličkacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140334, N'HS', N'11593038', N'4', N' ', N'4', N'16185175', N'10092752', N'11026826', N'21429392', N'10253101', N'169715
', N'576214', N'poličkacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140335, N'HS', N'11593046', N'5', N' ', N'5', N'16185175', N'10092752', N'11026826', N'21429392', N'10253101', N'169711
', N'576192', N'poličkacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140336, N'HS', N'11593062', N'7', N' ', N'7', N'16185175', N'10092752', N'11026826', N'21429392', N'10253101', N'169701
', N'576150', N'poličkacesta7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140337, N'HS', N'11593089', N'2', N' ', N'2', N'16185183', N'10092752', N'11026826', N'21429392', N'10252768', N'170975
', N'576379', N'porabskaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140338, N'HS', N'11593119', N'4', N' ', N'4', N'16185183', N'10092752', N'11026826', N'21429392', N'10252768', N'170964
', N'576395', N'porabskaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140339, N'HS', N'11593160', N'1', N' ', N'1', N'16185191', N'10092752', N'11026826', N'21429392', N'10253071', N'169906
', N'576326', N'prečnaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140340, N'HS', N'11593178', N'2', N' ', N'2', N'16185191', N'10092752', N'11026826', N'21429392', N'10253071', N'169901
', N'576301', N'prečnaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140341, N'HS', N'11593194', N'4', N' ', N'4', N'16185191', N'10092752', N'11026826', N'21429392', N'10253071', N'169878
', N'576293', N'prečnaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140342, N'HS', N'11593208', N'5', N' ', N'5', N'16185191', N'10092752', N'11026826', N'21429392', N'10253071', N'169847
', N'576314', N'prečnaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140343, N'HS', N'11590128', N'1', N' ', N'1', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170762
', N'576160', N'prešernovacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140344, N'HS', N'11590144', N'3', N' ', N'3', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170745
', N'576172', N'prešernovacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140345, N'HS', N'11590179', N'5', N' ', N'5', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170729
', N'576186', N'prešernovacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140346, N'HS', N'11590187', N'6', N' ', N'6', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170724
', N'576189', N'prešernovacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140347, N'HS', N'11590209', N'8', N' ', N'8', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170704
', N'576201', N'prešernovacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140348, N'HS', N'11590217', N'9', N' ', N'9', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170695
', N'576206', N'prešernovacesta9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140349, N'HS', N'11590225', N'10', N' ', N'10', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170733
', N'576134', N'prešernovacesta10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140350, N'HS', N'11590241', N'12', N' ', N'12', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170625
', N'576173', N'prešernovacesta12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140351, N'HS', N'11590250', N'13', N' ', N'13', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170602
', N'576196', N'prešernovacesta13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140352, N'HS', N'11590268', N'14', N' ', N'14', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170640
', N'576220', N'prešernovacesta14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140353, N'HS', N'11590276', N'15', N' ', N'15', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170614
', N'576233', N'prešernovacesta15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140354, N'HS', N'11590292', N'17', N' ', N'17', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170587
', N'576286', N'prešernovacesta17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140355, N'HS', N'11590306', N'18', N' ', N'18', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170585
', N'576252', N'prešernovacesta18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140356, N'HS', N'11590322', N'20', N' ', N'20', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170536
', N'576242', N'prešernovacesta20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140357, N'HS', N'11606253', N'13', N'A', N'13A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164311
', N'571909', N'lokavci13a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140358, N'HS', N'11606270', N'14', N' ', N'14', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164399
', N'571506', N'lokavci14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140359, N'HS', N'19133940', N'18', N'A', N'18A', N'16276227', N'10093350', N'11026826', N'21429392', N'19128130', N'165778
', N'573875', N'rodmošci18a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140360, N'HS', N'11606296', N'16', N' ', N'16', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164465
', N'571181', N'lokavci16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140361, N'HS', N'11606300', N'17', N' ', N'17', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164167
', N'571178', N'lokavci17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140362, N'HS', N'11606326', N'18', N' ', N'18', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164391
', N'570882', N'lokavci18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140363, N'HS', N'11606334', N'19', N' ', N'19', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164511
', N'570986', N'lokavci19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140364, N'HS', N'11606369', N'21', N' ', N'21', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164753
', N'570899', N'lokavci21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140365, N'HS', N'11606377', N'22', N' ', N'22', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164793
', N'570870', N'lokavci22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140366, N'HS', N'11606385', N'23', N' ', N'23', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164906
', N'570817', N'lokavci23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140367, N'HS', N'11606393', N'24', N' ', N'24', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'165035
', N'570869', N'lokavci24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140368, N'HS', N'11606407', N'25', N' ', N'25', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'165138
', N'570970', N'lokavci25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140369, N'HS', N'11606415', N'26', N' ', N'26', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'165155
', N'570986', N'lokavci26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140370, N'HS', N'11606423', N'27', N' ', N'27', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164908
', N'570719', N'lokavci27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140371, N'HS', N'11606431', N'28', N' ', N'28', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164881
', N'570604', N'lokavci28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140372, N'HS', N'11606440', N'29', N' ', N'29', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164835
', N'570514', N'lokavci29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140373, N'HS', N'11606466', N'31', N' ', N'31', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164911
', N'570154', N'lokavci31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140374, N'HS', N'11606482', N'33', N' ', N'33', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164852
', N'569906', N'lokavci33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140375, N'HS', N'11606504', N'34', N' ', N'34', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164820
', N'569889', N'lokavci34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140376, N'HS', N'11606539', N'36', N' ', N'36', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164681
', N'569793', N'lokavci36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140377, N'HS', N'11606547', N'37', N' ', N'37', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164418
', N'570269', N'lokavci37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140378, N'HS', N'11606555', N'38', N' ', N'38', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164694
', N'570411', N'lokavci38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140379, N'HS', N'11606571', N'40', N' ', N'40', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164476
', N'570544', N'lokavci40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140380, N'HS', N'11606580', N'41', N' ', N'41', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164126
', N'570891', N'lokavci41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140381, N'HS', N'11606598', N'42', N' ', N'42', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'163871
', N'571003', N'lokavci42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140382, N'HS', N'11606628', N'44', N' ', N'44', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'163636
', N'571324', N'lokavci44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140383, N'HS', N'16171298', N'44', N'A', N'44A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'163607
', N'571318', N'lokavci44a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140384, N'HS', N'11606636', N'45', N' ', N'45', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'163659
', N'571485', N'lokavci45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140385, N'HS', N'11606652', N'2', N' ', N'2', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'171001
', N'573274', N'lomanoše2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140386, N'HS', N'11606679', N'3', N' ', N'3', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170986
', N'573198', N'lomanoše3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140387, N'HS', N'11606687', N'4', N' ', N'4', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170663
', N'573154', N'lomanoše4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140388, N'HS', N'11636365', N'3', N'B', N'3B', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161550
', N'574535', N'spodnjiivanjci3b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140389, N'HS', N'11636381', N'3', N'D', N'3D', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161557
', N'574577', N'spodnjiivanjci3d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140390, N'HS', N'11614078', N'4', N'A', N'4A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162662
', N'576756', N'očeslavci4a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140391, N'HS', N'11579418', N'7', N' ', N'7', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168341
', N'573026', N'aženskivrh7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140392, N'HS', N'11579515', N'15', N' ', N'15', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168030
', N'572756', N'aženskivrh15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140393, N'HS', N'11581978', N'1', N' ', N'1', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169568
', N'576655', N'črešnjevci1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140394, N'HS', N'11582494', N'50', N' ', N'50', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169019
', N'576422', N'črešnjevci50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140395, N'HS', N'11582532', N'56', N'A', N'56A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168855
', N'576448', N'črešnjevci56a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140396, N'HS', N'11582583', N'59', N' ', N'59', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168814
', N'576417', N'črešnjevci59')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140397, N'HS', N'11582664', N'68', N' ', N'68', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168748
', N'576351', N'črešnjevci68')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140398, N'HS', N'11582753', N'79', N' ', N'79', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168805
', N'575915', N'črešnjevci79')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140399, N'HS', N'11582761', N'80', N' ', N'80', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168746
', N'575920', N'črešnjevci80')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140400, N'HS', N'11582818', N'84', N' ', N'84', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168537
', N'576282', N'črešnjevci84')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140401, N'HS', N'11582842', N'87', N' ', N'87', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168571
', N'576349', N'črešnjevci87')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140402, N'HS', N'11582877', N'89', N' ', N'89', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168638
', N'576350', N'črešnjevci89')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140403, N'HS', N'11582893', N'91', N' ', N'91', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168628
', N'576389', N'črešnjevci91')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140404, N'HS', N'11583083', N'112', N' ', N'112', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168419
', N'576561', N'črešnjevci112')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140405, N'HS', N'11583105', N'114', N' ', N'114', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168398
', N'576573', N'črešnjevci114')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140406, N'HS', N'11583270', N'129', N' ', N'129', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167934
', N'576320', N'črešnjevci129')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140407, N'HS', N'11583334', N'135', N' ', N'135', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167739
', N'575984', N'črešnjevci135')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140408, N'HS', N'11583423', N'144', N' ', N'144', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168005
', N'576001', N'črešnjevci144')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140409, N'HS', N'11583466', N'148', N' ', N'148', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168093
', N'576001', N'črešnjevci148')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140410, N'HS', N'11583482', N'150', N' ', N'150', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168541
', N'576047', N'črešnjevci150')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140411, N'HS', N'11583547', N'154', N' ', N'154', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168381
', N'575905', N'črešnjevci154')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140412, N'HS', N'11583695', N'169', N' ', N'169', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168517
', N'575621', N'črešnjevci169')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140413, N'HS', N'11583849', N'183', N' ', N'183', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168132
', N'574700', N'črešnjevci183')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140414, N'HS', N'11583920', N'191', N' ', N'191', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168960
', N'574781', N'črešnjevci191')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140415, N'HS', N'11584080', N'205', N' ', N'205', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168712
', N'575396', N'črešnjevci205')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140416, N'HS', N'11584276', N'222', N' ', N'222', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169356
', N'575550', N'črešnjevci222')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140417, N'HS', N'19125327', N'20', N'A', N'20A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164959
', N'574352', N'ivanjševskivrh20a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140418, N'HS', N'11620973', N'103', N' ', N'103', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169031
', N'573376', N'police103')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140419, N'HS', N'19125114', N'227', N'A', N'227A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169362
', N'575722', N'črešnjevci227a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140420, N'HS', N'19125149', N'34', N'A', N'34A', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168912
', N'571750', N'plitvičkivrh34a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140421, N'HS', N'19125238', N'45', N'A', N'45A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163627
', N'575840', N'stavešinskivrh45a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140422, N'HS', N'19124967', N'8', N'A', N'8A', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163175
', N'573441', N'gornjiivanjci8a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140423, N'HS', N'16391018', N'62', N' ', N'62', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168897
', N'576388', N'črešnjevci62')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140424, N'HS', N'11636705', N'24', N' ', N'24', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'160958
', N'576304', N'spodnjiivanjci24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140425, N'HS', N'11636691', N'24', N'A', N'24A', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'160950
', N'576284', N'spodnjiivanjci24a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140426, N'HS', N'19118207', N'13', N'A', N'13A', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'169880
', N'576377', N'mariborskacesta13a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140427, N'HS', N'11588956', N'13', N' ', N'13', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'169891
', N'576374', N'mariborskacesta13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140428, N'HS', N'19123227', N'7', N'A', N'7A', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170704
', N'576198', N'prešernovacesta7a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140429, N'HS', N'19123235', N'28', N'B', N'28B', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'169110
', N'576296', N'črešnjevci28b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140430, N'HS', N'19124703', N'16', N'B', N'16B', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167069
', N'575467', N'orehovskivrh16b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140431, N'HS', N'11588336', N'16', N' ', N'16', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171392
', N'576208', N'lackovaulica16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140432, N'HS', N'19125289', N'22', N'C', N'22C', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161009
', N'574766', N'spodnjiivanjci22c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140433, N'HS', N'19124975', N'41', N'A', N'41A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165574
', N'576582', N'ptujskacesta41a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140434, N'HS', N'19125165', N'30', N'A', N'30A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164884
', N'570188', N'lokavci30a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140435, N'HS', N'19125572', N'2', N'A', N'2A', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167289
', N'577163', N'orehovci2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140436, N'HS', N'19126030', N'20', N' ', N'20', N'16184985', N'10092752', N'11026826', N'21429392', N'10253110', N'169880
', N'576159', N'vodovodnaulica20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140437, N'HS', N'19134989', N'19', N' ', N'19', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'169780
', N'576379', N'mariborskacesta19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140438, N'HS', N'11592058', N'3', N' ', N'3', N'16185027', N'10092752', N'11026826', N'21429392', N'10253098', N'170229
', N'576385', N'dajnkovaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140439, N'HS', N'19132404', N'34', N'B', N'34B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167914
', N'571893', N'spodnjaščavnica34b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140440, N'HS', N'19133150', N'60', N'A', N'60A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165503
', N'575052', N'ivanjševskivrh60a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140441, N'HS', N'19119424', N'22', N'A', N'22A', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'160990
', N'574732', N'spodnjiivanjci22a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140442, N'HS', N'11616151', N'9', N' ', N'9', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166216
', N'575239', N'orehovskivrh9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140443, N'HS', N'11582974', N'103', N' ', N'103', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168516
', N'576464', N'črešnjevci103')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140444, N'HS', N'19137350', N'46', N'B', N'46B', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163673
', N'575711', N'stavešinskivrh46b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140445, N'HS', N'19136361', N'7', N' ', N'7', N'16185132', N'10092752', N'11026826', N'21429392', N'10253098', N'169665
', N'576468', N'obpotoku7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140446, N'HS', N'11584039', N'200', N' ', N'200', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168573
', N'575106', N'črešnjevci200')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140447, N'HS', N'19134857', N'15', N'A', N'15A', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163718
', N'573980', N'gornjiivanjci15a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140448, N'HS', N'19126692', N'39', N'B', N'39B', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164001
', N'576021', N'stavešinskivrh39b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140449, N'HS', N'19137023', N'22', N'A', N'22A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165161
', N'572364', N'radvenci22a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140450, N'HS', N'11636128', N'98', N' ', N'98', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167276
', N'568974', N'spodnjaščavnica98')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140451, N'HS', N'11591191', N'6', N' ', N'6', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170887
', N'576216', N'trgsvobode6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140452, N'HS', N'19126358', N'3', N'B', N'3B', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160989
', N'574626', N'ivanjskivrh3b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140453, N'HS', N'19134598', N'38', N'A', N'38A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170405
', N'574193', N'hercegovščak38a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140454, N'HS', N'11592074', N'5', N' ', N'5', N'16185027', N'10092752', N'11026826', N'21429392', N'10253098', N'170253
', N'576379', N'dajnkovaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140455, N'HS', N'19126536', N'12', N'Z', N'12Z', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170965
', N'576161', N'trgsvobode12z')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140456, N'HS', N'19126544', N'12', N'A', N'12A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164702
', N'575922', N'stavešinskivrh12a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140457, N'HS', N'19122042', N'13', N' ', N'13', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169590
', N'576294', N'kajuhovaulica13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140458, N'HS', N'19122093', N'61', N'B', N'61B', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168944
', N'576354', N'črešnjevci61b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140459, N'HS', N'11583822', N'182', N' ', N'182', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168142
', N'574849', N'črešnjevci182')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140460, N'HS', N'11583865', N'185', N' ', N'185', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168097
', N'574531', N'črešnjevci185')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140461, N'HS', N'11583873', N'186', N' ', N'186', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168614
', N'574450', N'črešnjevci186')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140462, N'HS', N'11583881', N'187', N' ', N'187', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168649
', N'574424', N'črešnjevci187')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140463, N'HS', N'11583890', N'188', N' ', N'188', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168790
', N'574473', N'črešnjevci188')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140464, N'HS', N'11583903', N'189', N' ', N'189', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168888
', N'574683', N'črešnjevci189')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140465, N'HS', N'11583938', N'192', N' ', N'192', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168686
', N'574749', N'črešnjevci192')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140466, N'HS', N'11583946', N'193', N' ', N'193', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168612
', N'574818', N'črešnjevci193')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140467, N'HS', N'11583954', N'194', N' ', N'194', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168557
', N'574715', N'črešnjevci194')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140468, N'HS', N'11583962', N'195', N' ', N'195', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168429
', N'574540', N'črešnjevci195')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140469, N'HS', N'11583989', N'196', N' ', N'196', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168514
', N'574919', N'črešnjevci196')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140470, N'HS', N'11583997', N'197', N' ', N'197', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168505
', N'574954', N'črešnjevci197')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140471, N'HS', N'11584004', N'198', N' ', N'198', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168763
', N'574949', N'črešnjevci198')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140472, N'HS', N'11584012', N'199', N' ', N'199', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168634
', N'575008', N'črešnjevci199')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140473, N'HS', N'11584063', N'203', N' ', N'203', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168583
', N'575342', N'črešnjevci203')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140474, N'HS', N'11584071', N'204', N' ', N'204', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168566
', N'575441', N'črešnjevci204')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140475, N'HS', N'11584098', N'206', N' ', N'206', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168727
', N'575387', N'črešnjevci206')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140476, N'HS', N'11584110', N'207', N' ', N'207', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168848
', N'575340', N'črešnjevci207')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140477, N'HS', N'11584101', N'207', N'A', N'207A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168851
', N'575328', N'črešnjevci207a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140478, N'HS', N'11584128', N'208', N' ', N'208', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168893
', N'575337', N'črešnjevci208')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140479, N'HS', N'11584152', N'211', N' ', N'211', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168938
', N'575243', N'črešnjevci211')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140480, N'HS', N'11584179', N'212', N' ', N'212', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168940
', N'575214', N'črešnjevci212')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140481, N'HS', N'11584187', N'213', N' ', N'213', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168984
', N'575063', N'črešnjevci213')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140482, N'HS', N'11584195', N'214', N' ', N'214', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'169114
', N'574837', N'črešnjevci214')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140483, N'HS', N'11584209', N'215', N' ', N'215', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'169329
', N'574995', N'črešnjevci215')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140484, N'HS', N'11584217', N'216', N' ', N'216', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'169228
', N'575056', N'črešnjevci216')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140485, N'HS', N'11590560', N'5', N' ', N'5', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170894
', N'575963', N'simoničevbreg5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140486, N'HS', N'11590578', N'6', N' ', N'6', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170950
', N'576006', N'simoničevbreg6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140487, N'HS', N'11620299', N'41', N' ', N'41', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169857
', N'574224', N'police41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140488, N'HS', N'11620302', N'42', N' ', N'42', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169823
', N'574188', N'police42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140489, N'HS', N'11620345', N'46', N' ', N'46', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169621
', N'574240', N'police46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140490, N'HS', N'11620353', N'47', N' ', N'47', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170097
', N'574135', N'police47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140491, N'HS', N'11620361', N'48', N' ', N'48', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170053
', N'574115', N'police48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140492, N'HS', N'11620370', N'49', N' ', N'49', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169997
', N'574071', N'police49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140493, N'HS', N'11620388', N'50', N' ', N'50', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170000
', N'574032', N'police50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140494, N'HS', N'11620418', N'53', N' ', N'53', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169938
', N'573952', N'police53')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140495, N'HS', N'11620426', N'54', N' ', N'54', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169933
', N'573916', N'police54')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140496, N'HS', N'11620434', N'55', N' ', N'55', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169922
', N'573936', N'police55')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140497, N'HS', N'11620469', N'57', N' ', N'57', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169772
', N'573747', N'police57')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140498, N'HS', N'11620477', N'58', N' ', N'58', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169845
', N'573736', N'police58')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140499, N'HS', N'11620493', N'60', N' ', N'60', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170013
', N'573800', N'police60')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140500, N'HS', N'11598323', N'12', N' ', N'12', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161156
', N'574216', N'ivanjskivrh12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140501, N'HS', N'11598366', N'13', N' ', N'13', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161478
', N'574345', N'ivanjskivrh13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140502, N'HS', N'11598340', N'13', N'B', N'13B', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161557
', N'574317', N'ivanjskivrh13b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140503, N'HS', N'11598358', N'13', N'C', N'13C', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161543
', N'574297', N'ivanjskivrh13c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140504, N'HS', N'11598382', N'14', N' ', N'14', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161627
', N'574306', N'ivanjskivrh14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140505, N'HS', N'11598412', N'16', N' ', N'16', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161198
', N'574039', N'ivanjskivrh16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140506, N'HS', N'11598463', N'21', N' ', N'21', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161062
', N'573980', N'ivanjskivrh21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140507, N'HS', N'11598498', N'24', N' ', N'24', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160939
', N'573870', N'ivanjskivrh24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140508, N'HS', N'11598510', N'26', N' ', N'26', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160920
', N'573687', N'ivanjskivrh26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140509, N'HS', N'11598536', N'1', N' ', N'1', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'165119
', N'573710', N'ivanjševciobščavnici1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140510, N'HS', N'11598544', N'2', N' ', N'2', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164778
', N'574099', N'ivanjševciobščavnici2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140511, N'HS', N'11598552', N'3', N' ', N'3', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164509
', N'574071', N'ivanjševciobščavnici3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140512, N'HS', N'11598579', N'4', N' ', N'4', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164173
', N'573996', N'ivanjševciobščavnici4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140513, N'HS', N'11598587', N'5', N' ', N'5', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164444
', N'574054', N'ivanjševciobščavnici5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140514, N'HS', N'11598633', N'9', N' ', N'9', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164461
', N'574212', N'ivanjševciobščavnici9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140515, N'HS', N'11598625', N'9', N'A', N'9A', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164406
', N'574309', N'ivanjševciobščavnici9a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140516, N'HS', N'11598641', N'10', N' ', N'10', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164493
', N'574230', N'ivanjševciobščavnici10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140517, N'HS', N'11598650', N'11', N' ', N'11', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164444
', N'574324', N'ivanjševciobščavnici11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140518, N'HS', N'11598676', N'13', N' ', N'13', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164397
', N'574425', N'ivanjševciobščavnici13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140519, N'HS', N'11598684', N'14', N' ', N'14', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164343
', N'574438', N'ivanjševciobščavnici14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140520, N'HS', N'11598692', N'15', N' ', N'15', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164408
', N'574484', N'ivanjševciobščavnici15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140521, N'HS', N'11598706', N'16', N' ', N'16', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164315
', N'574483', N'ivanjševciobščavnici16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140522, N'HS', N'11598722', N'18', N' ', N'18', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164476
', N'574587', N'ivanjševciobščavnici18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140523, N'HS', N'11598749', N'19', N' ', N'19', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164479
', N'574551', N'ivanjševciobščavnici19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140524, N'HS', N'11612091', N'12', N' ', N'12', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163325
', N'572250', N'negova12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140525, N'HS', N'11612105', N'13', N' ', N'13', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163437
', N'572113', N'negova13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140526, N'HS', N'11590586', N'7', N' ', N'7', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170885
', N'575944', N'simoničevbreg7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140527, N'HS', N'11590608', N'9', N' ', N'9', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170874
', N'575923', N'simoničevbreg9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140528, N'HS', N'11590616', N'10', N' ', N'10', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170912
', N'575943', N'simoničevbreg10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140529, N'HS', N'11590624', N'12', N' ', N'12', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170904
', N'575920', N'simoničevbreg12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140530, N'HS', N'11590632', N'14', N' ', N'14', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170894
', N'575900', N'simoničevbreg14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140531, N'HS', N'11590675', N'28', N' ', N'28', N'16184900', N'10092752', N'11026826', N'21429392', N'10252610', N'170839
', N'575725', N'simoničevbreg28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140532, N'HS', N'11593461', N'1', N' ', N'1', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171144
', N'575507', N'strmaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140533, N'HS', N'11593488', N'3', N' ', N'3', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171106
', N'575514', N'strmaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140534, N'HS', N'11593496', N'4', N' ', N'4', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171166
', N'575474', N'strmaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140535, N'HS', N'11593500', N'5', N' ', N'5', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171105
', N'575466', N'strmaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140536, N'HS', N'11593542', N'9', N' ', N'9', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171136
', N'575416', N'strmaulica9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140537, N'HS', N'11593569', N'10', N' ', N'10', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171176
', N'575382', N'strmaulica10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140538, N'HS', N'11593577', N'12', N' ', N'12', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171152
', N'575368', N'strmaulica12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140539, N'HS', N'11590705', N'2', N' ', N'2', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171060
', N'575954', N'šlebingerjevbreg2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140540, N'HS', N'11590713', N'3', N' ', N'3', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171045
', N'575972', N'šlebingerjevbreg3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140541, N'HS', N'11590721', N'4', N' ', N'4', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171039
', N'575929', N'šlebingerjevbreg4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140542, N'HS', N'11590748', N'6', N' ', N'6', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171052
', N'575917', N'šlebingerjevbreg6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140543, N'HS', N'11590756', N'7', N' ', N'7', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171005
', N'575947', N'šlebingerjevbreg7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140544, N'HS', N'11590764', N'8', N' ', N'8', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171064
', N'575900', N'šlebingerjevbreg8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140545, N'HS', N'11590772', N'9', N' ', N'9', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'170985
', N'575926', N'šlebingerjevbreg9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140546, N'HS', N'11590799', N'11', N' ', N'11', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171006
', N'575914', N'šlebingerjevbreg11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140547, N'HS', N'11590829', N'15', N' ', N'15', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171045
', N'575880', N'šlebingerjevbreg15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140548, N'HS', N'11590837', N'16', N' ', N'16', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171059
', N'575813', N'šlebingerjevbreg16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140549, N'HS', N'11590845', N'17', N' ', N'17', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171060
', N'575847', N'šlebingerjevbreg17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140550, N'HS', N'11590853', N'18', N' ', N'18', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171032
', N'575834', N'šlebingerjevbreg18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140551, N'HS', N'11590861', N'19', N' ', N'19', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171073
', N'575832', N'šlebingerjevbreg19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140552, N'HS', N'11590870', N'20', N' ', N'20', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171000
', N'575846', N'šlebingerjevbreg20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140553, N'HS', N'11590888', N'21', N' ', N'21', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171035
', N'575861', N'šlebingerjevbreg21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140554, N'HS', N'11590896', N'22', N' ', N'22', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'170994
', N'575821', N'šlebingerjevbreg22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140555, N'HS', N'11607128', N'28', N' ', N'28', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169903
', N'573014', N'lomanoše28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140556, N'HS', N'11607136', N'29', N' ', N'29', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169910
', N'572986', N'lomanoše29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140557, N'HS', N'11607144', N'30', N' ', N'30', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170054
', N'572945', N'lomanoše30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140558, N'HS', N'11620515', N'62', N' ', N'62', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169989
', N'573568', N'police62')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140559, N'HS', N'11620531', N'64', N' ', N'64', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169848
', N'573556', N'police64')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140560, N'HS', N'11620540', N'65', N' ', N'65', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169838
', N'573500', N'police65')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140561, N'HS', N'11620566', N'67', N' ', N'67', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169673
', N'573138', N'police67')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140562, N'HS', N'11620582', N'68', N' ', N'68', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169540
', N'573008', N'police68')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140563, N'HS', N'11620604', N'69', N' ', N'69', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169321
', N'572913', N'police69')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140564, N'HS', N'11620612', N'70', N' ', N'70', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169080
', N'573125', N'police70')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140565, N'HS', N'11620639', N'71', N' ', N'71', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169094
', N'573146', N'police71')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140566, N'HS', N'11620655', N'73', N' ', N'73', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169265
', N'573328', N'police73')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140567, N'HS', N'11620728', N'80', N' ', N'80', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169347
', N'573499', N'police80')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140568, N'HS', N'11620744', N'82', N' ', N'82', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169395
', N'573587', N'police82')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140569, N'HS', N'11612113', N'14', N' ', N'14', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163310
', N'572107', N'negova14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140570, N'HS', N'11612121', N'15', N' ', N'15', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163268
', N'572126', N'negova15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140571, N'HS', N'11612130', N'16', N' ', N'16', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163271
', N'572168', N'negova16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140572, N'HS', N'11612148', N'17', N' ', N'17', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163235
', N'572179', N'negova17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140573, N'HS', N'11612172', N'20', N' ', N'20', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163180
', N'572139', N'negova20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140574, N'HS', N'11612202', N'22', N' ', N'22', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163141
', N'572110', N'negova22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140575, N'HS', N'11612229', N'23', N' ', N'23', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163136
', N'572122', N'negova23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140576, N'HS', N'11612300', N'33', N' ', N'33', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'162705
', N'572289', N'negova33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140577, N'HS', N'11612326', N'35', N' ', N'35', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163044
', N'572091', N'negova35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140578, N'HS', N'11612342', N'37', N' ', N'37', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163099
', N'572095', N'negova37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140579, N'HS', N'11612369', N'38', N' ', N'38', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163073
', N'572069', N'negova38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140580, N'HS', N'11612377', N'39', N' ', N'39', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163041
', N'571996', N'negova39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140581, N'HS', N'11612393', N'41', N' ', N'41', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163049
', N'571943', N'negova41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140582, N'HS', N'11612423', N'44', N' ', N'44', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'162747
', N'571683', N'negova44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140583, N'HS', N'11612458', N'47', N' ', N'47', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162753
', N'571480', N'negova47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140584, N'HS', N'11612474', N'49', N' ', N'49', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162752
', N'571460', N'negova49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140585, N'HS', N'11612482', N'50', N' ', N'50', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163164
', N'571393', N'negova50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140586, N'HS', N'11612512', N'52', N' ', N'52', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162737
', N'571311', N'negova52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140587, N'HS', N'11612547', N'55', N' ', N'55', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162664
', N'571228', N'negova55')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140588, N'HS', N'11612555', N'56', N' ', N'56', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162640
', N'571187', N'negova56')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140589, N'HS', N'11607152', N'31', N' ', N'31', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170045
', N'572932', N'lomanoše31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140590, N'HS', N'11607187', N'32', N' ', N'32', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169985
', N'572919', N'lomanoše32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140591, N'HS', N'11607195', N'33', N' ', N'33', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169913
', N'572880', N'lomanoše33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140592, N'HS', N'11607217', N'34', N' ', N'34', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169934
', N'572846', N'lomanoše34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140593, N'HS', N'11607209', N'34', N'A', N'34A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169936
', N'572827', N'lomanoše34a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140594, N'HS', N'11607233', N'36', N' ', N'36', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169987
', N'572796', N'lomanoše36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140595, N'HS', N'11607241', N'37', N' ', N'37', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169982
', N'572760', N'lomanoše37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140596, N'HS', N'11607250', N'38', N' ', N'38', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169954
', N'572751', N'lomanoše38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140597, N'HS', N'11607268', N'39', N' ', N'39', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169927
', N'572756', N'lomanoše39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140598, N'HS', N'11607276', N'40', N'A', N'40A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169920
', N'572588', N'lomanoše40a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140599, N'HS', N'11607306', N'41', N' ', N'41', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169901
', N'572692', N'lomanoše41')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140600, N'HS', N'11607349', N'43', N' ', N'43', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169860
', N'572670', N'lomanoše43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140601, N'HS', N'11607373', N'44', N' ', N'44', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169840
', N'572475', N'lomanoše44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140602, N'HS', N'11607357', N'44', N'A', N'44A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169819
', N'572486', N'lomanoše44a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140603, N'HS', N'11607365', N'44', N'B', N'44B', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169816
', N'572457', N'lomanoše44b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140604, N'HS', N'11607390', N'45', N' ', N'45', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169803
', N'572409', N'lomanoše45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140605, N'HS', N'11607403', N'46', N' ', N'46', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169763
', N'572353', N'lomanoše46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140606, N'HS', N'11607489', N'51', N' ', N'51', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'168974
', N'572613', N'lomanoše51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140607, N'HS', N'11607497', N'52', N' ', N'52', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169512
', N'572876', N'lomanoše52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140608, N'HS', N'11607527', N'55', N' ', N'55', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169887
', N'573299', N'lomanoše55')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140609, N'HS', N'11607535', N'56', N' ', N'56', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170028
', N'573593', N'lomanoše56')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140610, N'HS', N'11619851', N'1', N' ', N'1', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169629
', N'575372', N'police1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140611, N'HS', N'11586970', N'3', N' ', N'3', N'16184721', N'10092752', N'11026826', N'21429392', N'10253080', N'170308
', N'576278', N'cankarjevacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140612, N'HS', N'11587011', N'8', N' ', N'8', N'16184721', N'10092752', N'11026826', N'21429392', N'10253080', N'170333
', N'576260', N'cankarjevacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140613, N'HS', N'11587020', N'10', N' ', N'10', N'16184721', N'10092752', N'11026826', N'21429392', N'10253080', N'170328
', N'576237', N'cankarjevacesta10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140614, N'HS', N'11587038', N'12', N' ', N'12', N'16184721', N'10092752', N'11026826', N'21429392', N'10253080', N'170339
', N'576210', N'cankarjevacesta12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140615, N'HS', N'11587046', N'14', N' ', N'14', N'16184721', N'10092752', N'11026826', N'21429392', N'10253080', N'170336
', N'576189', N'cankarjevacesta14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140616, N'HS', N'11587054', N'18', N' ', N'18', N'16184721', N'10092752', N'11026826', N'21429392', N'10253110', N'170203
', N'576142', N'cankarjevacesta18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140617, N'HS', N'11587062', N'20', N' ', N'20', N'16184721', N'10092752', N'11026826', N'21429392', N'10253110', N'170310
', N'576082', N'cankarjevacesta20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140618, N'HS', N'11591612', N'4', N' ', N'4', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171183
', N'576220', N'vrtnaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140619, N'HS', N'11591639', N'5', N' ', N'5', N'16184977', N'10092752', N'11026826', N'21429392', N'10253225', N'171207
', N'576201', N'vrtnaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140620, N'HS', N'11591647', N'6', N' ', N'6', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171165
', N'576235', N'vrtnaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140621, N'HS', N'11591655', N'7', N' ', N'7', N'16184977', N'10092752', N'11026826', N'21429392', N'10253225', N'171218
', N'576218', N'vrtnaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140622, N'HS', N'11591663', N'9', N' ', N'9', N'16184977', N'10092752', N'11026826', N'21429392', N'10253225', N'171243
', N'576257', N'vrtnaulica9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140623, N'HS', N'11591671', N'10', N' ', N'10', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171144
', N'576249', N'vrtnaulica10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140624, N'HS', N'11591680', N'12', N' ', N'12', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171124
', N'576236', N'vrtnaulica12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140625, N'HS', N'11591698', N'14', N' ', N'14', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171162
', N'576272', N'vrtnaulica14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140626, N'HS', N'11591701', N'16', N' ', N'16', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171180
', N'576257', N'vrtnaulica16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140627, N'HS', N'11591710', N'18', N' ', N'18', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171200
', N'576242', N'vrtnaulica18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140628, N'HS', N'11619860', N'2', N' ', N'2', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169584
', N'575120', N'police2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140629, N'HS', N'11619878', N'3', N' ', N'3', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169583
', N'575096', N'police3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140630, N'HS', N'11619886', N'4', N' ', N'4', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169752
', N'574909', N'police4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140631, N'HS', N'11619908', N'6', N' ', N'6', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169728
', N'574719', N'police6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140632, N'HS', N'11619916', N'7', N' ', N'7', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169669
', N'574713', N'police7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140633, N'HS', N'11619924', N'8', N' ', N'8', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169528
', N'574988', N'police8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140634, N'HS', N'11619932', N'9', N' ', N'9', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169339
', N'574780', N'police9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140635, N'HS', N'11619959', N'10', N' ', N'10', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169407
', N'574768', N'police10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140636, N'HS', N'11619967', N'11', N' ', N'11', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169522
', N'574686', N'police11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140637, N'HS', N'11619975', N'12', N' ', N'12', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169545
', N'574617', N'police12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140638, N'HS', N'11619983', N'13', N' ', N'13', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169584
', N'574573', N'police13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140639, N'HS', N'11619991', N'14', N' ', N'14', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169613
', N'574571', N'police14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140640, N'HS', N'11620019', N'15', N' ', N'15', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169660
', N'574572', N'police15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140641, N'HS', N'11620027', N'16', N' ', N'16', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169679
', N'574455', N'police16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140642, N'HS', N'11620035', N'17', N' ', N'17', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169610
', N'574463', N'police17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140643, N'HS', N'11620043', N'18', N' ', N'18', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169523
', N'574459', N'police18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140644, N'HS', N'11620051', N'19', N' ', N'19', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170089
', N'575141', N'police19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140645, N'HS', N'11620060', N'20', N' ', N'20', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169918
', N'575160', N'police20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140646, N'HS', N'11620078', N'21', N' ', N'21', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170034
', N'575054', N'police21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140647, N'HS', N'11620086', N'22', N' ', N'22', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170017
', N'575000', N'police22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140648, N'HS', N'11620108', N'24', N' ', N'24', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170223
', N'574663', N'police24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140649, N'HS', N'11620116', N'25', N' ', N'25', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169995
', N'574684', N'police25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140650, N'HS', N'11620124', N'26', N' ', N'26', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170021
', N'574626', N'police26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140651, N'HS', N'11620132', N'27', N' ', N'27', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170038
', N'574612', N'police27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140652, N'HS', N'11620183', N'31', N' ', N'31', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170218
', N'574347', N'police31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140653, N'HS', N'11620205', N'33', N' ', N'33', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169991
', N'574581', N'police33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140654, N'HS', N'11620213', N'34', N' ', N'34', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169870
', N'574615', N'police34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140655, N'HS', N'11620221', N'35', N' ', N'35', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169964
', N'574408', N'police35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140656, N'HS', N'11620248', N'37', N' ', N'37', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169953
', N'574299', N'police37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140657, N'HS', N'11620256', N'38', N' ', N'38', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169904
', N'574246', N'police38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140658, N'HS', N'11620264', N'39', N' ', N'39', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169915
', N'574276', N'police39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140659, N'HS', N'11584250', N'220', N' ', N'220', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169411
', N'575595', N'črešnjevci220')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140660, N'HS', N'11591736', N'22', N' ', N'22', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171213
', N'576306', N'vrtnaulica22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140661, N'HS', N'11591744', N'24', N' ', N'24', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171241
', N'576297', N'vrtnaulica24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140662, N'HS', N'11594077', N'1', N' ', N'1', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163491
', N'572798', N'gornjiivanjci1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140663, N'HS', N'11594093', N'3', N' ', N'3', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163432
', N'573047', N'gornjiivanjci3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140664, N'HS', N'11594107', N'4', N' ', N'4', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163412
', N'573092', N'gornjiivanjci4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140665, N'HS', N'11594123', N'6', N' ', N'6', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163313
', N'573273', N'gornjiivanjci6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140666, N'HS', N'11594140', N'8', N' ', N'8', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163190
', N'573458', N'gornjiivanjci8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140667, N'HS', N'11594166', N'9', N' ', N'9', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163100
', N'573588', N'gornjiivanjci9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140668, N'HS', N'11594158', N'9', N'A', N'9A', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163122
', N'573646', N'gornjiivanjci9a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140669, N'HS', N'11594174', N'10', N' ', N'10', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163107
', N'573743', N'gornjiivanjci10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140670, N'HS', N'11594239', N'14', N' ', N'14', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163581
', N'574135', N'gornjiivanjci14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140671, N'HS', N'11594247', N'15', N' ', N'15', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163715
', N'574007', N'gornjiivanjci15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140672, N'HS', N'11594263', N'17', N' ', N'17', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163426
', N'574568', N'gornjiivanjci17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140673, N'HS', N'11594271', N'18', N' ', N'18', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163199
', N'574630', N'gornjiivanjci18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140674, N'HS', N'11594280', N'19', N' ', N'19', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'162887
', N'574524', N'gornjiivanjci19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140675, N'HS', N'11594310', N'22', N' ', N'22', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'162620
', N'574390', N'gornjiivanjci22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140676, N'HS', N'11594328', N'23', N' ', N'23', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'161721
', N'574428', N'gornjiivanjci23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140677, N'HS', N'11587992', N'5', N' ', N'5', N'16184799', N'10092752', N'11026826', N'21429392', N'10253128', N'171360
', N'575971', N'kerenčičevaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140678, N'HS', N'11587976', N'5', N'A', N'5A', N'16184799', N'10092752', N'11026826', N'21429392', N'10253128', N'171370
', N'575965', N'kerenčičevaulica5a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140679, N'HS', N'11588018', N'7', N' ', N'7', N'16184799', N'10092752', N'11026826', N'21429392', N'10253128', N'171400
', N'575949', N'kerenčičevaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140680, N'HS', N'11588034', N'9', N' ', N'9', N'16184799', N'10092752', N'11026826', N'21429392', N'10253128', N'171425
', N'575936', N'kerenčičevaulica9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140681, N'HS', N'11588069', N'11', N' ', N'11', N'16184799', N'10092752', N'11026826', N'21429392', N'10253128', N'171450
', N'575920', N'kerenčičevaulica11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140682, N'HS', N'11588107', N'15', N' ', N'15', N'16184799', N'10092752', N'11026826', N'21429392', N'10253128', N'171482
', N'575879', N'kerenčičevaulica15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140683, N'HS', N'11588123', N'17', N' ', N'17', N'16184799', N'10092752', N'11026826', N'21429392', N'10253128', N'171492
', N'575865', N'kerenčičevaulica17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140684, N'HS', N'11584268', N'221', N' ', N'221', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169387
', N'575557', N'črešnjevci221')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140685, N'HS', N'11584306', N'224', N' ', N'224', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169217
', N'575422', N'črešnjevci224')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140686, N'HS', N'11584322', N'226', N' ', N'226', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169344
', N'575672', N'črešnjevci226')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140687, N'HS', N'11584390', N'232', N' ', N'232', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169168
', N'575882', N'črešnjevci232')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140688, N'HS', N'11584403', N'233', N' ', N'233', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169274
', N'575865', N'črešnjevci233')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140689, N'HS', N'11584411', N'234', N' ', N'234', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169347
', N'575936', N'črešnjevci234')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140690, N'HS', N'11584420', N'235', N' ', N'235', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169328
', N'575824', N'črešnjevci235')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140691, N'HS', N'11584438', N'236', N' ', N'236', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169523
', N'575747', N'črešnjevci236')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140692, N'HS', N'11588158', N'2', N' ', N'2', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171270
', N'576350', N'lackovaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140693, N'HS', N'11588166', N'3', N' ', N'3', N'16184802', N'10092752', N'11026826', N'21429392', N'10253225', N'171261
', N'576277', N'lackovaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140694, N'HS', N'11588182', N'5', N' ', N'5', N'16184802', N'10092752', N'11026826', N'21429392', N'10253225', N'171273
', N'576255', N'lackovaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140695, N'HS', N'11588212', N'7', N' ', N'7', N'16184802', N'10092752', N'11026826', N'21429392', N'10253225', N'171245
', N'576222', N'lackovaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140696, N'HS', N'11588247', N'8', N' ', N'8', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171327
', N'576239', N'lackovaulica8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140697, N'HS', N'11588239', N'8', N'A', N'8A', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171357
', N'576258', N'lackovaulica8a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140698, N'HS', N'11588255', N'9', N' ', N'9', N'16184802', N'10092752', N'11026826', N'21429392', N'10253225', N'171247
', N'576208', N'lackovaulica9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140699, N'HS', N'11588263', N'10', N'A', N'10A', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171357
', N'576214', N'lackovaulica10a')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140700, N'HS', N'11588280', N'11', N' ', N'11', N'16184802', N'10092752', N'11026826', N'21429392', N'10253225', N'171271
', N'576230', N'lackovaulica11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140701, N'HS', N'11598757', N'2', N' ', N'2', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164641
', N'574572', N'ivanjševskivrh2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140702, N'HS', N'11598765', N'3', N' ', N'3', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164643
', N'574509', N'ivanjševskivrh3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140703, N'HS', N'11598773', N'4', N' ', N'4', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164648
', N'574445', N'ivanjševskivrh4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140704, N'HS', N'11598781', N'5', N' ', N'5', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164788
', N'574582', N'ivanjševskivrh5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140705, N'HS', N'11598790', N'6', N' ', N'6', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164807
', N'574540', N'ivanjševskivrh6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140706, N'HS', N'11598803', N'7', N' ', N'7', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164776
', N'574508', N'ivanjševskivrh7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140707, N'HS', N'11598820', N'11', N' ', N'11', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164928
', N'574342', N'ivanjševskivrh11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140708, N'HS', N'11598838', N'12', N' ', N'12', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164800
', N'574184', N'ivanjševskivrh12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140709, N'HS', N'11598846', N'13', N' ', N'13', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164914
', N'574214', N'ivanjševskivrh13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140710, N'HS', N'11598889', N'16', N' ', N'16', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164946
', N'574275', N'ivanjševskivrh16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140711, N'HS', N'11598935', N'20', N' ', N'20', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164959
', N'574425', N'ivanjševskivrh20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140712, N'HS', N'11598943', N'21', N' ', N'21', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165085
', N'574414', N'ivanjševskivrh21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140713, N'HS', N'11598960', N'23', N' ', N'23', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165114
', N'574323', N'ivanjševskivrh23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140714, N'HS', N'11598978', N'24', N' ', N'24', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165159
', N'574321', N'ivanjševskivrh24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140715, N'HS', N'11598994', N'25', N' ', N'25', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165238
', N'574352', N'ivanjševskivrh25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140716, N'HS', N'11599001', N'28', N' ', N'28', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165218
', N'574223', N'ivanjševskivrh28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140717, N'HS', N'11590918', N'24', N' ', N'24', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'170955
', N'575852', N'šlebingerjevbreg24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140718, N'HS', N'11590926', N'25', N' ', N'25', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'170994
', N'575885', N'šlebingerjevbreg25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140719, N'HS', N'11590934', N'26', N' ', N'26', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'170972
', N'575864', N'šlebingerjevbreg26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140720, N'HS', N'11590942', N'27', N' ', N'27', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'170968
', N'575894', N'šlebingerjevbreg27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140721, N'HS', N'11590977', N'2', N' ', N'2', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171180
', N'576415', N'trate2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140722, N'HS', N'11590985', N'3', N' ', N'3', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171250
', N'576436', N'trate3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140723, N'HS', N'11590993', N'4', N' ', N'4', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171123
', N'576445', N'trate4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140724, N'HS', N'11591035', N'7', N' ', N'7', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171197
', N'576462', N'trate7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140725, N'HS', N'11591043', N'8', N' ', N'8', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171081
', N'576466', N'trate8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140726, N'HS', N'11591051', N'9', N' ', N'9', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171226
', N'576444', N'trate9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140727, N'HS', N'11591078', N'13', N' ', N'13', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171211
', N'576498', N'trate13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140728, N'HS', N'11591086', N'15', N' ', N'15', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171233
', N'576508', N'trate15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140729, N'HS', N'11591094', N'17', N' ', N'17', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171265
', N'576522', N'trate17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140730, N'HS', N'11591108', N'19', N' ', N'19', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171225
', N'576572', N'trate19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140731, N'HS', N'11591116', N'21', N' ', N'21', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171167
', N'576519', N'trate21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140732, N'HS', N'11591124', N'23', N' ', N'23', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171089
', N'576581', N'trate23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140733, N'HS', N'11591132', N'1', N' ', N'1', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170868
', N'576153', N'trgsvobode1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140734, N'HS', N'11591159', N'2', N' ', N'2', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170878
', N'576164', N'trgsvobode2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140735, N'HS', N'11591167', N'3', N' ', N'3', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170845
', N'576172', N'trgsvobode3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140736, N'HS', N'11591175', N'4', N' ', N'4', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170851
', N'576182', N'trgsvobode4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140737, N'HS', N'11591183', N'5', N' ', N'5', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170864
', N'576197', N'trgsvobode5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140738, N'HS', N'11591205', N'7', N' ', N'7', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170901
', N'576203', N'trgsvobode7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140739, N'HS', N'11591213', N'8', N' ', N'8', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170907
', N'576209', N'trgsvobode8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140740, N'HS', N'11591221', N'9', N' ', N'9', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170888
', N'576221', N'trgsvobode9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140741, N'HS', N'11591230', N'10', N' ', N'10', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170928
', N'576235', N'trgsvobode10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140742, N'HS', N'11591248', N'11', N' ', N'11', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170945
', N'576222', N'trgsvobode11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140743, N'HS', N'11591256', N'12', N' ', N'12', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170965
', N'576193', N'trgsvobode12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140744, N'HS', N'11593585', N'2', N' ', N'2', N'16185248', N'10092752', N'11026826', N'21429392', N'10257204', N'170185
', N'576538', N'trstenjakovaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140745, N'HS', N'11593593', N'3', N' ', N'3', N'16185248', N'10092752', N'11026826', N'21429392', N'10257212', N'170239
', N'576564', N'trstenjakovaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140746, N'HS', N'11593607', N'4', N' ', N'4', N'16185248', N'10092752', N'11026826', N'21429392', N'10257204', N'170174
', N'576546', N'trstenjakovaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140747, N'HS', N'11593623', N'6', N' ', N'6', N'16185248', N'10092752', N'11026826', N'21429392', N'10257204', N'170213
', N'576578', N'trstenjakovaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140748, N'HS', N'11599036', N'30', N' ', N'30', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165272
', N'574159', N'ivanjševskivrh30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140749, N'HS', N'11599079', N'31', N' ', N'31', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165206
', N'573970', N'ivanjševskivrh31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140750, N'HS', N'11599044', N'31', N'A', N'31A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165184
', N'573951', N'ivanjševskivrh31a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140751, N'HS', N'11599052', N'31', N'B', N'31B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165147
', N'573929', N'ivanjševskivrh31b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140752, N'HS', N'11599141', N'37', N' ', N'37', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165458
', N'574289', N'ivanjševskivrh37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140753, N'HS', N'11599214', N'42', N' ', N'42', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165451
', N'574620', N'ivanjševskivrh42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140754, N'HS', N'11612563', N'57', N' ', N'57', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162566
', N'571178', N'negova57')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140755, N'HS', N'11612580', N'59', N' ', N'59', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162499
', N'571342', N'negova59')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140756, N'HS', N'11612598', N'60', N' ', N'60', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162574
', N'571059', N'negova60')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140757, N'HS', N'11612601', N'61', N' ', N'61', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162439
', N'571146', N'negova61')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140758, N'HS', N'11612628', N'63', N' ', N'63', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162234
', N'570956', N'negova63')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140759, N'HS', N'11612636', N'64', N' ', N'64', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162220
', N'570936', N'negova64')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140760, N'HS', N'11612652', N'66', N' ', N'66', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162205
', N'570907', N'negova66')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140761, N'HS', N'11612679', N'67', N' ', N'67', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162005
', N'570878', N'negova67')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140762, N'HS', N'11612687', N'68', N' ', N'68', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162265
', N'570744', N'negova68')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140763, N'HS', N'11612695', N'69', N' ', N'69', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162499
', N'570771', N'negova69')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140764, N'HS', N'11612709', N'70', N' ', N'70', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162331
', N'570681', N'negova70')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140765, N'HS', N'11612717', N'71', N' ', N'71', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162386
', N'570644', N'negova71')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140766, N'HS', N'11612725', N'72', N' ', N'72', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162646
', N'570503', N'negova72')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140767, N'HS', N'11612741', N'74', N' ', N'74', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162654
', N'570534', N'negova74')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140768, N'HS', N'11612768', N'76', N' ', N'76', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162718
', N'570652', N'negova76')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140769, N'HS', N'11612776', N'77', N' ', N'77', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163461
', N'571725', N'negova77')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140770, N'HS', N'11612784', N'78', N' ', N'78', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163258
', N'571067', N'negova78')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140771, N'HS', N'11612792', N'79', N' ', N'79', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163228
', N'571005', N'negova79')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140772, N'HS', N'11612814', N'81', N' ', N'81', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'163076
', N'571051', N'negova81')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140773, N'HS', N'11593631', N'8', N' ', N'8', N'16185248', N'10092752', N'11026826', N'21429392', N'10257204', N'170232
', N'576606', N'trstenjakovaulica8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140774, N'HS', N'11593640', N'1', N' ', N'1', N'16185256', N'10092752', N'11026826', N'21429392', N'10253101', N'169805
', N'576241', N'trubarjevaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140775, N'HS', N'11593658', N'2', N' ', N'2', N'16185256', N'10092752', N'11026826', N'21429392', N'10253101', N'169828
', N'576218', N'trubarjevaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140776, N'HS', N'11591957', N'2', N' ', N'2', N'16184993', N'10092752', N'11026826', N'21429392', N'10253055', N'170557
', N'576480', N'cestanastadion2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140777, N'HS', N'11591965', N'4', N' ', N'4', N'16184993', N'10092752', N'11026826', N'21429392', N'10253055', N'170426
', N'576601', N'cestanastadion4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140778, N'HS', N'11587089', N'1', N' ', N'1', N'16184730', N'10092752', N'11026826', N'21429392', N'10253284', N'171049
', N'576265', N'ciril-metodovacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140779, N'HS', N'11587097', N'2', N' ', N'2', N'16184730', N'10092752', N'11026826', N'21429392', N'10253284', N'171035
', N'576289', N'ciril-metodovacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140780, N'HS', N'11587119', N'3', N' ', N'3', N'16184730', N'10092752', N'11026826', N'21429392', N'10253284', N'171082
', N'576276', N'ciril-metodovacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140781, N'HS', N'11587135', N'6', N' ', N'6', N'16184730', N'10092752', N'11026826', N'21429392', N'10253284', N'171121
', N'576300', N'ciril-metodovacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140782, N'HS', N'11587143', N'7', N' ', N'7', N'16184730', N'10092752', N'11026826', N'21429392', N'10253284', N'171140
', N'576312', N'ciril-metodovacesta7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140783, N'HS', N'11587151', N'8', N' ', N'8', N'16184730', N'10092752', N'11026826', N'21429392', N'10253284', N'171161
', N'576321', N'ciril-metodovacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140784, N'HS', N'11587160', N'9', N' ', N'9', N'16184730', N'10092752', N'11026826', N'21429392', N'10253284', N'171182
', N'576302', N'ciril-metodovacesta9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140785, N'HS', N'11587178', N'10', N' ', N'10', N'16184730', N'10092752', N'11026826', N'21429392', N'10253284', N'171188
', N'576333', N'ciril-metodovacesta10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140786, N'HS', N'11591981', N'1', N' ', N'1', N'16185019', N'10092752', N'11026826', N'21429392', N'10253233', N'171263
', N'575670', N'čremošnikovaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140787, N'HS', N'11591990', N'2', N' ', N'2', N'16185019', N'10092752', N'11026826', N'21429392', N'10253233', N'171255
', N'575629', N'čremošnikovaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140788, N'HS', N'11592007', N'4', N' ', N'4', N'16185019', N'10092752', N'11026826', N'21429392', N'10253233', N'171231
', N'575634', N'čremošnikovaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140789, N'HS', N'11592015', N'6', N' ', N'6', N'16185019', N'10092752', N'11026826', N'21429392', N'10253233', N'171226
', N'575655', N'čremošnikovaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140790, N'HS', N'11592023', N'8', N' ', N'8', N'16185019', N'10092752', N'11026826', N'21429392', N'10253233', N'171220
', N'575672', N'čremošnikovaulica8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140791, N'HS', N'11592031', N'1', N' ', N'1', N'16185027', N'10092752', N'11026826', N'21429392', N'10253098', N'170256
', N'576425', N'dajnkovaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140792, N'HS', N'11592040', N'2', N' ', N'2', N'16185027', N'10092752', N'11026826', N'21429392', N'10253098', N'170283
', N'576397', N'dajnkovaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140793, N'HS', N'11592066', N'4', N' ', N'4', N'16185027', N'10092752', N'11026826', N'21429392', N'10253098', N'170306
', N'576381', N'dajnkovaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140794, N'HS', N'11592082', N'6', N' ', N'6', N'16185027', N'10092752', N'11026826', N'21429392', N'10253098', N'170298
', N'576357', N'dajnkovaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140795, N'HS', N'11592104', N'8', N' ', N'8', N'16185027', N'10092752', N'11026826', N'21429392', N'10253098', N'170275
', N'576365', N'dajnkovaulica8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140796, N'HS', N'11587186', N'2', N' ', N'2', N'16184748', N'10092752', N'11026826', N'21429392', N'10253080', N'170279
', N'576294', N'delavskapot2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140797, N'HS', N'11587194', N'4', N' ', N'4', N'16184748', N'10092752', N'11026826', N'21429392', N'10253080', N'170255
', N'576305', N'delavskapot4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140798, N'HS', N'11587216', N'6', N' ', N'6', N'16184748', N'10092752', N'11026826', N'21429392', N'10253080', N'170206
', N'576325', N'delavskapot6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140799, N'HS', N'11587224', N'7', N' ', N'7', N'16184748', N'10092752', N'11026826', N'21429392', N'10253098', N'170193
', N'576348', N'delavskapot7')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140800, N'HS', N'11612849', N'83', N' ', N'83', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163180
', N'570901', N'negova83')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140801, N'HS', N'11612857', N'84', N' ', N'84', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163214
', N'570738', N'negova84')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140802, N'HS', N'11612865', N'85', N' ', N'85', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163161
', N'570683', N'negova85')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140803, N'HS', N'11612873', N'86', N' ', N'86', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'163059
', N'570637', N'negova86')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140804, N'HS', N'11612903', N'89', N' ', N'89', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163048
', N'570235', N'negova89')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140805, N'HS', N'11612920', N'91', N' ', N'91', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163291
', N'570225', N'negova91')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140806, N'HS', N'11612954', N'94', N' ', N'94', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163561
', N'570314', N'negova94')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140807, N'HS', N'11612962', N'95', N' ', N'95', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163499
', N'570123', N'negova95')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140808, N'HS', N'11612989', N'96', N' ', N'96', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163631
', N'570200', N'negova96')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140809, N'HS', N'11613004', N'98', N' ', N'98', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163836
', N'570279', N'negova98')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140810, N'HS', N'11618006', N'33', N' ', N'33', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168842
', N'571729', N'plitvičkivrh33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140811, N'HS', N'11618014', N'34', N' ', N'34', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168876
', N'571740', N'plitvičkivrh34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140812, N'HS', N'11618049', N'36', N' ', N'36', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168975
', N'571885', N'plitvičkivrh36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140813, N'HS', N'11618081', N'41', N' ', N'41', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169019
', N'571737', N'plitvičkivrh41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140814, N'HS', N'11618090', N'42', N' ', N'42', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169031
', N'571645', N'plitvičkivrh42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140815, N'HS', N'11618120', N'45', N' ', N'45', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169082
', N'571745', N'plitvičkivrh45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140816, N'HS', N'11618154', N'48', N' ', N'48', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169227
', N'571764', N'plitvičkivrh48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140817, N'HS', N'11618197', N'51', N' ', N'51', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169047
', N'571193', N'plitvičkivrh51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140818, N'HS', N'11618227', N'53', N' ', N'53', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168979
', N'570997', N'plitvičkivrh53')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140819, N'HS', N'11618251', N'56', N' ', N'56', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168945
', N'570486', N'plitvičkivrh56')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140820, N'HS', N'11618260', N'57', N' ', N'57', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169090
', N'570437', N'plitvičkivrh57')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140821, N'HS', N'11618278', N'58', N' ', N'58', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169120
', N'570404', N'plitvičkivrh58')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140822, N'HS', N'11618294', N'60', N' ', N'60', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169164
', N'570317', N'plitvičkivrh60')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140823, N'HS', N'11587232', N'8', N' ', N'8', N'16184748', N'10092752', N'11026826', N'21429392', N'10253080', N'170176
', N'576317', N'delavskapot8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140824, N'HS', N'11587267', N'10', N' ', N'10', N'16184748', N'10092752', N'11026826', N'21429392', N'10253080', N'170152
', N'576320', N'delavskapot10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140825, N'HS', N'11587275', N'12', N' ', N'12', N'16184748', N'10092752', N'11026826', N'21429392', N'10253080', N'170127
', N'576326', N'delavskapot12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140826, N'HS', N'11587283', N'14', N' ', N'14', N'16184748', N'10092752', N'11026826', N'21429392', N'10253080', N'170106
', N'576320', N'delavskapot14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140827, N'HS', N'11587313', N'18', N' ', N'18', N'16184748', N'10092752', N'11026826', N'21429392', N'10253080', N'170059
', N'576330', N'delavskapot18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140828, N'HS', N'11587321', N'19', N' ', N'19', N'16184748', N'10092752', N'11026826', N'21429392', N'10253098', N'169969
', N'576360', N'delavskapot19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140829, N'HS', N'11587330', N'20', N' ', N'20', N'16184748', N'10092752', N'11026826', N'21429392', N'10253071', N'170025
', N'576332', N'delavskapot20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140830, N'HS', N'11587348', N'22', N' ', N'22', N'16184748', N'10092752', N'11026826', N'21429392', N'10253071', N'169991
', N'576332', N'delavskapot22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140831, N'HS', N'11588310', N'14', N' ', N'14', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171359
', N'576185', N'lackovaulica14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140832, N'HS', N'11588344', N'17', N' ', N'17', N'16184802', N'10092752', N'11026826', N'21429392', N'10253276', N'171354
', N'576104', N'lackovaulica17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140833, N'HS', N'11588379', N'19', N' ', N'19', N'16184802', N'10092752', N'11026826', N'21429392', N'10253276', N'171330
', N'576098', N'lackovaulica19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140834, N'HS', N'11588417', N'23', N' ', N'23', N'16184802', N'10092752', N'11026826', N'21429392', N'10253276', N'171367
', N'576069', N'lackovaulica23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140835, N'HS', N'11618316', N'62', N' ', N'62', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169194
', N'570155', N'plitvičkivrh62')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140836, N'HS', N'11618324', N'63', N' ', N'63', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169187
', N'570140', N'plitvičkivrh63')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140837, N'HS', N'11596061', N'16', N' ', N'16', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170374
', N'575878', N'hercegovščak16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140838, N'HS', N'11596053', N'16', N'A', N'16A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170343
', N'575834', N'hercegovščak16a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140839, N'HS', N'11596070', N'17', N' ', N'17', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170339
', N'575738', N'hercegovščak17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140840, N'HS', N'11596088', N'18', N' ', N'18', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170383
', N'575703', N'hercegovščak18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140841, N'HS', N'11596126', N'19', N' ', N'19', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170394
', N'575668', N'hercegovščak19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140842, N'HS', N'11596096', N'19', N'A', N'19A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170330
', N'575612', N'hercegovščak19a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140843, N'HS', N'11596100', N'19', N'B', N'19B', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170336
', N'575501', N'hercegovščak19b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140844, N'HS', N'11588441', N'26', N' ', N'26', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171449
', N'576058', N'lackovaulica26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140845, N'HS', N'11588468', N'28', N' ', N'28', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171469
', N'575984', N'lackovaulica28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140846, N'HS', N'11592503', N'1', N' ', N'1', N'16185094', N'10092752', N'11026826', N'21429392', N'10253098', N'170339
', N'576384', N'leninovaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140847, N'HS', N'11592511', N'2', N' ', N'2', N'16185094', N'10092752', N'11026826', N'21429392', N'10253098', N'170328
', N'576366', N'leninovaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140848, N'HS', N'11592520', N'3', N' ', N'3', N'16185094', N'10092752', N'11026826', N'21429392', N'10253098', N'170319
', N'576342', N'leninovaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140849, N'HS', N'11592538', N'4', N' ', N'4', N'16185094', N'10092752', N'11026826', N'21429392', N'10253098', N'170316
', N'576316', N'leninovaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140850, N'HS', N'11592546', N'5', N' ', N'5', N'16185094', N'10092752', N'11026826', N'21429392', N'10253098', N'170342
', N'576310', N'leninovaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140851, N'HS', N'11588484', N'1', N' ', N'1', N'16184829', N'10092752', N'11026826', N'21429392', N'10257212', N'170240
', N'576484', N'ljutomerskacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140852, N'HS', N'11588506', N'3', N' ', N'3', N'16184829', N'10092752', N'11026826', N'21429392', N'10257212', N'170216
', N'576498', N'ljutomerskacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140853, N'HS', N'11588514', N'4', N' ', N'4', N'16184829', N'10092752', N'11026826', N'21429392', N'10253098', N'170154
', N'576479', N'ljutomerskacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140854, N'HS', N'11588522', N'5', N' ', N'5', N'16184829', N'10092752', N'11026826', N'21429392', N'10257204', N'170161
', N'576554', N'ljutomerskacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140855, N'HS', N'11588549', N'6', N' ', N'6', N'16184829', N'10092752', N'11026826', N'21429392', N'10253098', N'170158
', N'576467', N'ljutomerskacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140856, N'HS', N'11588557', N'7', N' ', N'7', N'16184829', N'10092752', N'11026826', N'21429392', N'10257204', N'170151
', N'576574', N'ljutomerskacesta7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140857, N'HS', N'11588573', N'9', N' ', N'9', N'16184829', N'10092752', N'11026826', N'21429392', N'10257204', N'170087
', N'576626', N'ljutomerskacesta9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140858, N'HS', N'11588590', N'11', N' ', N'11', N'16184829', N'10092752', N'11026826', N'21429392', N'10257204', N'170064
', N'576639', N'ljutomerskacesta11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140859, N'HS', N'11588611', N'13', N' ', N'13', N'16184829', N'10092752', N'11026826', N'21429392', N'10257204', N'170048
', N'576657', N'ljutomerskacesta13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140860, N'HS', N'11599222', N'43', N' ', N'43', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165494
', N'574779', N'ivanjševskivrh43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140861, N'HS', N'11599273', N'44', N' ', N'44', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165380
', N'574779', N'ivanjševskivrh44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140862, N'HS', N'11599265', N'44', N'C', N'44C', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165478
', N'574760', N'ivanjševskivrh44c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140863, N'HS', N'11599290', N'45', N' ', N'45', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165310
', N'574778', N'ivanjševskivrh45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140864, N'HS', N'11593674', N'4', N' ', N'4', N'16185256', N'10092752', N'11026826', N'21429392', N'10253101', N'169806
', N'576204', N'trubarjevaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140865, N'HS', N'11593682', N'5', N' ', N'5', N'16185256', N'10092752', N'11026826', N'21429392', N'10253101', N'169756
', N'576221', N'trubarjevaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140866, N'HS', N'11593704', N'6', N' ', N'6', N'16185256', N'10092752', N'11026826', N'21429392', N'10253101', N'169789
', N'576183', N'trubarjevaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140867, N'HS', N'11593712', N'7', N' ', N'7', N'16185256', N'10092752', N'11026826', N'21429392', N'10253101', N'169760
', N'576199', N'trubarjevaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140868, N'HS', N'11593739', N'1', N' ', N'1', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169652
', N'576331', N'ulicamarijerožman1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140869, N'HS', N'11593747', N'2', N' ', N'2', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169686
', N'576325', N'ulicamarijerožman2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140870, N'HS', N'11593755', N'3', N' ', N'3', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169652
', N'576291', N'ulicamarijerožman3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140871, N'HS', N'11593763', N'4', N' ', N'4', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169683
', N'576296', N'ulicamarijerožman4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140872, N'HS', N'11593771', N'5', N' ', N'5', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169648
', N'576267', N'ulicamarijerožman5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140873, N'HS', N'11593780', N'6', N' ', N'6', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169684
', N'576270', N'ulicamarijerožman6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140874, N'HS', N'11593798', N'7', N' ', N'7', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169643
', N'576237', N'ulicamarijerožman7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140875, N'HS', N'11593801', N'8', N' ', N'8', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169677
', N'576241', N'ulicamarijerožman8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140876, N'HS', N'11593810', N'9', N' ', N'9', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169640
', N'576217', N'ulicamarijerožman9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140877, N'HS', N'11599303', N'46', N' ', N'46', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165227
', N'574812', N'ivanjševskivrh46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140878, N'HS', N'11599311', N'48', N' ', N'48', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164770
', N'574749', N'ivanjševskivrh48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140879, N'HS', N'11599338', N'50', N' ', N'50', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164392
', N'574981', N'ivanjševskivrh50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140880, N'HS', N'11599346', N'51', N' ', N'51', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164254
', N'575117', N'ivanjševskivrh51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140881, N'HS', N'11599354', N'52', N' ', N'52', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164326
', N'575034', N'ivanjševskivrh52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140882, N'HS', N'11599397', N'55', N' ', N'55', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164650
', N'575004', N'ivanjševskivrh55')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140883, N'HS', N'11599419', N'56', N' ', N'56', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164694
', N'575037', N'ivanjševskivrh56')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140884, N'HS', N'11599427', N'57', N' ', N'57', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164953
', N'574997', N'ivanjševskivrh57')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140885, N'HS', N'11599460', N'61', N' ', N'61', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165470
', N'575087', N'ivanjševskivrh61')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140886, N'HS', N'11599478', N'62', N' ', N'62', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165615
', N'575251', N'ivanjševskivrh62')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140887, N'HS', N'11599524', N'64', N' ', N'64', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165638
', N'575058', N'ivanjševskivrh64')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140888, N'HS', N'11599575', N'66', N' ', N'66', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165913
', N'575046', N'ivanjševskivrh66')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140889, N'HS', N'11599583', N'67', N' ', N'67', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165992
', N'575080', N'ivanjševskivrh67')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140890, N'HS', N'11599605', N'69', N' ', N'69', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'166163
', N'575132', N'ivanjševskivrh69')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140891, N'HS', N'11613012', N'99', N' ', N'99', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163819
', N'570308', N'negova99')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140892, N'HS', N'11613039', N'100', N' ', N'100', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163800
', N'570324', N'negova100')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140893, N'HS', N'11613055', N'102', N' ', N'102', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163763
', N'570394', N'negova102')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140894, N'HS', N'11613071', N'104', N' ', N'104', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163732
', N'570438', N'negova104')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140895, N'HS', N'11593828', N'10', N' ', N'10', N'16185264', N'10092752', N'11026826', N'21429392', N'10253101', N'169675
', N'576213', N'ulicamarijerožman10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140896, N'HS', N'11593836', N'1', N' ', N'1', N'16185272', N'10092752', N'11026826', N'21429392', N'10253071', N'170015
', N'576287', N'ulicamošepijade1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140897, N'HS', N'11593844', N'2', N' ', N'2', N'16185272', N'10092752', N'11026826', N'21429392', N'10253071', N'170004
', N'576253', N'ulicamošepijade2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140898, N'HS', N'11593852', N'3', N' ', N'3', N'16185272', N'10092752', N'11026826', N'21429392', N'10253071', N'169981
', N'576284', N'ulicamošepijade3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140899, N'HS', N'11593879', N'4', N' ', N'4', N'16185272', N'10092752', N'11026826', N'21429392', N'10253071', N'169978
', N'576249', N'ulicamošepijade4')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140900, N'HS', N'11593887', N'6', N' ', N'6', N'16185272', N'10092752', N'11026826', N'21429392', N'10253071', N'169952
', N'576242', N'ulicamošepijade6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140901, N'HS', N'11591272', N'4', N' ', N'4', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170216
', N'576274', N'ulicasilviretomassini4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140902, N'HS', N'11591299', N'6', N' ', N'6', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170247
', N'576269', N'ulicasilviretomassini6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140903, N'HS', N'11591302', N'8', N' ', N'8', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170280
', N'576260', N'ulicasilviretomassini8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140904, N'HS', N'11591329', N'10', N' ', N'10', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170263
', N'576233', N'ulicasilviretomassini10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140905, N'HS', N'11591345', N'14', N' ', N'14', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170187
', N'576224', N'ulicasilviretomassini14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140906, N'HS', N'11591353', N'15', N' ', N'15', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170187
', N'576281', N'ulicasilviretomassini15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140907, N'HS', N'11591361', N'16', N' ', N'16', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170170
', N'576256', N'ulicasilviretomassini16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140908, N'HS', N'11591388', N'18', N' ', N'18', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170146
', N'576258', N'ulicasilviretomassini18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140909, N'HS', N'11591396', N'19', N' ', N'19', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170127
', N'576300', N'ulicasilviretomassini19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140910, N'HS', N'11591400', N'20', N' ', N'20', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170122
', N'576263', N'ulicasilviretomassini20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140911, N'HS', N'11591418', N'21', N' ', N'21', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170100
', N'576288', N'ulicasilviretomassini21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140912, N'HS', N'11591434', N'24', N' ', N'24', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170083
', N'576262', N'ulicasilviretomassini24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140913, N'HS', N'11591442', N'26', N' ', N'26', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170055
', N'576263', N'ulicasilviretomassini26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140914, N'HS', N'11593895', N'1', N' ', N'1', N'16185299', N'10092752', N'11026826', N'21429392', N'10253233', N'171277
', N'575536', N'vaupotičevaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140915, N'HS', N'11593925', N'3', N' ', N'3', N'16185299', N'10092752', N'11026826', N'21429392', N'10253233', N'171258
', N'575521', N'vaupotičevaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140916, N'HS', N'11593933', N'4', N' ', N'4', N'16185299', N'10092752', N'11026826', N'21429392', N'10253233', N'171318
', N'575517', N'vaupotičevaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140917, N'HS', N'11593941', N'5', N' ', N'5', N'16185299', N'10092752', N'11026826', N'21429392', N'10253233', N'171289
', N'575507', N'vaupotičevaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140918, N'HS', N'11592198', N'1', N' ', N'1', N'16185043', N'10092752', N'11026826', N'21429392', N'10252628', N'171075
', N'575599', N'gorkegaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140919, N'HS', N'11592210', N'3', N' ', N'3', N'16185043', N'10092752', N'11026826', N'21429392', N'10252628', N'171058
', N'575530', N'gorkegaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140920, N'HS', N'11613080', N'105', N' ', N'105', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163712
', N'570465', N'negova105')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140921, N'HS', N'11613098', N'106', N' ', N'106', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163752
', N'570509', N'negova106')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140922, N'HS', N'11613101', N'107', N' ', N'107', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163672
', N'570516', N'negova107')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140923, N'HS', N'11613110', N'108', N' ', N'108', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163668
', N'570537', N'negova108')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140924, N'HS', N'11613128', N'109', N' ', N'109', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163626
', N'570564', N'negova109')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140925, N'HS', N'11613136', N'110', N' ', N'110', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163608
', N'570631', N'negova110')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140926, N'HS', N'11613152', N'112', N' ', N'112', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163555
', N'570750', N'negova112')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140927, N'HS', N'11613179', N'113', N' ', N'113', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163560
', N'570912', N'negova113')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140928, N'HS', N'11613187', N'114', N' ', N'114', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163710
', N'570618', N'negova114')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140929, N'HS', N'11613209', N'116', N' ', N'116', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163864
', N'570541', N'negova116')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140930, N'HS', N'11613233', N'119', N' ', N'119', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164066
', N'570207', N'negova119')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140931, N'HS', N'11613241', N'120', N' ', N'120', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164038
', N'570144', N'negova120')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140932, N'HS', N'11613250', N'121', N' ', N'121', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163999
', N'570175', N'negova121')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140933, N'HS', N'11613284', N'124', N' ', N'124', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164213
', N'569957', N'negova124')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140934, N'HS', N'11613292', N'125', N' ', N'125', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164312
', N'569991', N'negova125')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140935, N'HS', N'11613314', N'127', N' ', N'127', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164341
', N'570087', N'negova127')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140936, N'HS', N'11613349', N'3', N' ', N'3', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169719
', N'576088', N'noričkivrh3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140937, N'HS', N'11613357', N'4', N' ', N'4', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169695
', N'576058', N'noričkivrh4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140938, N'HS', N'11613365', N'5', N' ', N'5', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169685
', N'576030', N'noričkivrh5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140939, N'HS', N'11613390', N'8', N' ', N'8', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169668
', N'575934', N'noričkivrh8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140940, N'HS', N'11613403', N'9', N' ', N'9', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169656
', N'575904', N'noričkivrh9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140941, N'HS', N'11613411', N'10', N' ', N'10', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169686
', N'575898', N'noričkivrh10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140942, N'HS', N'11613420', N'11', N' ', N'11', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169695
', N'575925', N'noričkivrh11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140943, N'HS', N'11613438', N'12', N' ', N'12', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169728
', N'575904', N'noričkivrh12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140944, N'HS', N'11613446', N'13', N' ', N'13', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169707
', N'575865', N'noričkivrh13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140945, N'HS', N'11613454', N'14', N' ', N'14', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169694
', N'575842', N'noričkivrh14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140946, N'HS', N'19134563', N'43', N'D', N'43D', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167592
', N'572235', N'spodnjaščavnica43d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140947, N'HS', N'11619398', N'39', N' ', N'39', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171360
', N'574210', N'podgrad39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140948, N'HS', N'11619401', N'40', N' ', N'40', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171356
', N'574185', N'podgrad40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140949, N'HS', N'11619410', N'41', N' ', N'41', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171392
', N'574158', N'podgrad41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140950, N'HS', N'11592228', N'4', N' ', N'4', N'16185043', N'10092752', N'11026826', N'21429392', N'10252687', N'171086
', N'575559', N'gorkegaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140951, N'HS', N'11592236', N'5', N' ', N'5', N'16185043', N'10092752', N'11026826', N'21429392', N'10252628', N'171033
', N'575518', N'gorkegaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140952, N'HS', N'11592244', N'6', N' ', N'6', N'16185043', N'10092752', N'11026826', N'21429392', N'10252687', N'171087
', N'575529', N'gorkegaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140953, N'HS', N'11587364', N'1', N' ', N'1', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171211
', N'575539', N'grajskacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140954, N'HS', N'11587402', N'5', N' ', N'5', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171277
', N'575561', N'grajskacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140955, N'HS', N'11587429', N'7', N' ', N'7', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171313
', N'575613', N'grajskacesta7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140956, N'HS', N'11587445', N'9', N' ', N'9', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171340
', N'575634', N'grajskacesta9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140957, N'HS', N'11587453', N'10', N' ', N'10', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171264
', N'575702', N'grajskacesta10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140958, N'HS', N'11587461', N'11', N' ', N'11', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171317
', N'575648', N'grajskacesta11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140959, N'HS', N'11587470', N'12', N' ', N'12', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171265
', N'575725', N'grajskacesta12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140960, N'HS', N'11587488', N'13', N' ', N'13', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171296
', N'575660', N'grajskacesta13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140961, N'HS', N'11587496', N'14', N' ', N'14', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171280
', N'575747', N'grajskacesta14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140962, N'HS', N'11587500', N'15', N' ', N'15', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171295
', N'575698', N'grajskacesta15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140963, N'HS', N'11587518', N'16', N' ', N'16', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171307
', N'575759', N'grajskacesta16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140964, N'HS', N'11587526', N'17', N' ', N'17', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171310
', N'575722', N'grajskacesta17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140965, N'HS', N'11587542', N'19', N' ', N'19', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171336
', N'575726', N'grajskacesta19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140966, N'HS', N'11587569', N'20', N' ', N'20', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171362
', N'575750', N'grajskacesta20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140967, N'HS', N'11587577', N'21', N' ', N'21', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171329
', N'575700', N'grajskacesta21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140968, N'HS', N'11587585', N'22', N' ', N'22', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171391
', N'575734', N'grajskacesta22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140969, N'HS', N'11587593', N'23', N' ', N'23', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171363
', N'575722', N'grajskacesta23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140970, N'HS', N'11587607', N'24', N' ', N'24', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171439
', N'575688', N'grajskacesta24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140971, N'HS', N'11587615', N'25', N' ', N'25', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171380
', N'575709', N'grajskacesta25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140972, N'HS', N'11587623', N'26', N' ', N'26', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171481
', N'575558', N'grajskacesta26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140973, N'HS', N'11587631', N'27', N' ', N'27', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171408
', N'575679', N'grajskacesta27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140974, N'HS', N'11587658', N'29', N' ', N'29', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171426
', N'575636', N'grajskacesta29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140975, N'HS', N'11596118', N'19', N'C', N'19C', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170338
', N'575484', N'hercegovščak19c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140976, N'HS', N'11596134', N'20', N' ', N'20', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170556
', N'575567', N'hercegovščak20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140977, N'HS', N'11596142', N'21', N' ', N'21', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170726
', N'575462', N'hercegovščak21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140978, N'HS', N'11596169', N'22', N' ', N'22', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170528
', N'575486', N'hercegovščak22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140979, N'HS', N'11596177', N'23', N' ', N'23', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170532
', N'575439', N'hercegovščak23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140980, N'HS', N'11596185', N'24', N' ', N'24', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170515
', N'575392', N'hercegovščak24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140981, N'HS', N'11596193', N'25', N' ', N'25', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170584
', N'575163', N'hercegovščak25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140982, N'HS', N'11596215', N'30', N' ', N'30', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170381
', N'575095', N'hercegovščak30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140983, N'HS', N'11596240', N'32', N' ', N'32', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170427
', N'574806', N'hercegovščak32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140984, N'HS', N'11619428', N'42', N' ', N'42', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171255
', N'573980', N'podgrad42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140985, N'HS', N'11619436', N'43', N' ', N'43', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171292
', N'573933', N'podgrad43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140986, N'HS', N'11619444', N'44', N' ', N'44', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171248
', N'573890', N'podgrad44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140987, N'HS', N'11619452', N'45', N' ', N'45', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171223
', N'573729', N'podgrad45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140988, N'HS', N'11619479', N'46', N' ', N'46', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171294
', N'573711', N'podgrad46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140989, N'HS', N'11619495', N'48', N' ', N'48', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171214
', N'573654', N'podgrad48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140990, N'HS', N'11619525', N'51', N' ', N'51', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171261
', N'573646', N'podgrad51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140991, N'HS', N'11619533', N'52', N' ', N'52', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171255
', N'573582', N'podgrad52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140992, N'HS', N'11619541', N'53', N' ', N'53', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171258
', N'573573', N'podgrad53')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140993, N'HS', N'11619568', N'55', N' ', N'55', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171399
', N'573465', N'podgrad55')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140994, N'HS', N'11619584', N'57', N' ', N'57', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171273
', N'573394', N'podgrad57')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140995, N'HS', N'11619592', N'58', N' ', N'58', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171253
', N'573367', N'podgrad58')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140996, N'HS', N'11619606', N'59', N' ', N'59', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171145
', N'573205', N'podgrad59')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140997, N'HS', N'11596231', N'32', N'A', N'32A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170421
', N'574733', N'hercegovščak32a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140998, N'HS', N'11596258', N'33', N' ', N'33', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170444
', N'574699', N'hercegovščak33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (140999, N'HS', N'11596266', N'34', N' ', N'34', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170452
', N'574632', N'hercegovščak34')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141000, N'HS', N'11596304', N'37', N' ', N'37', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170399
', N'574291', N'hercegovščak37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141001, N'HS', N'11596312', N'38', N' ', N'38', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170411
', N'574213', N'hercegovščak38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141002, N'HS', N'11596371', N'43', N' ', N'43', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170477
', N'573947', N'hercegovščak43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141003, N'HS', N'11596401', N'45', N' ', N'45', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170542
', N'574392', N'hercegovščak45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141004, N'HS', N'11596428', N'47', N' ', N'47', N'16275662', N'10092817', N'11026826', N'21429392', N'10252717', N'170763
', N'574376', N'hercegovščak47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141005, N'HS', N'11596444', N'48', N' ', N'48', N'16275662', N'10092817', N'11026826', N'21429392', N'10252717', N'170755
', N'574437', N'hercegovščak48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141006, N'HS', N'11596452', N'49', N' ', N'49', N'16275662', N'10092817', N'11026826', N'21429392', N'10252717', N'170808
', N'574707', N'hercegovščak49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141007, N'HS', N'11596479', N'50', N' ', N'50', N'16275662', N'10092817', N'11026826', N'21429392', N'10252717', N'170807
', N'574739', N'hercegovščak50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141008, N'HS', N'11596487', N'51', N' ', N'51', N'16275662', N'10092817', N'11026826', N'21429392', N'10252717', N'170756
', N'574869', N'hercegovščak51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141009, N'HS', N'11598226', N'3', N' ', N'3', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160996
', N'574575', N'ivanjskivrh3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141010, N'HS', N'11598218', N'3', N'A', N'3A', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161059
', N'574694', N'ivanjskivrh3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141011, N'HS', N'11598242', N'5', N' ', N'5', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160914
', N'574346', N'ivanjskivrh5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141012, N'HS', N'11598277', N'7', N' ', N'7', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160946
', N'574103', N'ivanjskivrh7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141013, N'HS', N'11598285', N'8', N' ', N'8', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161032
', N'574129', N'ivanjskivrh8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141014, N'HS', N'11588719', N'26', N' ', N'26', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169747
', N'577064', N'ljutomerskacesta26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141015, N'HS', N'11588727', N'27', N' ', N'27', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169829
', N'577142', N'ljutomerskacesta27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141016, N'HS', N'11588735', N'28', N' ', N'28', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169618
', N'576965', N'ljutomerskacesta28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141017, N'HS', N'11588743', N'29', N' ', N'29', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169515
', N'577366', N'ljutomerskacesta29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141018, N'HS', N'11588751', N'30', N' ', N'30', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169494
', N'577291', N'ljutomerskacesta30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141019, N'HS', N'11588760', N'31', N' ', N'31', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169245
', N'577998', N'ljutomerskacesta31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141020, N'HS', N'11588778', N'32', N' ', N'32', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169296
', N'577690', N'ljutomerskacesta32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141021, N'HS', N'11588794', N'1', N' ', N'1', N'16184837', N'10092752', N'11026826', N'21429392', N'10253128', N'171096
', N'576012', N'maistrovtrg1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141022, N'HS', N'11588808', N'2', N' ', N'2', N'16184837', N'10092752', N'11026826', N'21429392', N'10253128', N'171103
', N'575965', N'maistrovtrg2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141023, N'HS', N'11588816', N'3', N' ', N'3', N'16184837', N'10092752', N'11026826', N'21429392', N'10253128', N'171134
', N'575952', N'maistrovtrg3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141024, N'HS', N'11588824', N'4', N' ', N'4', N'16184837', N'10092752', N'11026826', N'21429392', N'10253128', N'171187
', N'575971', N'maistrovtrg4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141025, N'HS', N'11588832', N'5', N' ', N'5', N'16184837', N'10092752', N'11026826', N'21429392', N'10253268', N'171177
', N'576026', N'maistrovtrg5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141026, N'HS', N'11588859', N'6', N' ', N'6', N'16184837', N'10092752', N'11026826', N'21429392', N'10253268', N'171215
', N'576037', N'maistrovtrg6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141027, N'HS', N'11588875', N'9', N' ', N'9', N'16184837', N'10092752', N'11026826', N'21429392', N'10253268', N'171145
', N'576125', N'maistrovtrg9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141028, N'HS', N'11588883', N'11', N' ', N'11', N'16184837', N'10092752', N'11026826', N'21429392', N'10253268', N'171146
', N'576061', N'maistrovtrg11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141029, N'HS', N'11588891', N'12', N' ', N'12', N'16184837', N'10092752', N'11026826', N'21429392', N'10253268', N'171119
', N'576061', N'maistrovtrg12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141030, N'HS', N'11592554', N'1', N' ', N'1', N'16185108', N'10092752', N'11026826', N'21429392', N'10253071', N'169883
', N'576276', N'malaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141031, N'HS', N'11592562', N'2', N' ', N'2', N'16185108', N'10092752', N'11026826', N'21429392', N'10253071', N'169919
', N'576252', N'malaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141032, N'HS', N'11592589', N'4', N' ', N'4', N'16185108', N'10092752', N'11026826', N'21429392', N'10253071', N'169891
', N'576247', N'malaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141033, N'HS', N'11592597', N'6', N' ', N'6', N'16185108', N'10092752', N'11026826', N'21429392', N'10253071', N'169865
', N'576245', N'malaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141034, N'HS', N'11588905', N'2', N' ', N'2', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'170226
', N'576421', N'mariborskacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141035, N'HS', N'11588913', N'4', N' ', N'4', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'170194
', N'576414', N'mariborskacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141036, N'HS', N'11588921', N'6', N' ', N'6', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'170159
', N'576394', N'mariborskacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141037, N'HS', N'11588930', N'8', N' ', N'8', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'170098
', N'576390', N'mariborskacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141038, N'HS', N'11588964', N'14', N' ', N'14', N'16184845', N'10092752', N'11026826', N'21429392', N'10253101', N'169800
', N'576306', N'mariborskacesta14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141039, N'HS', N'11588972', N'15', N' ', N'15', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'169860
', N'576368', N'mariborskacesta15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141040, N'HS', N'11588999', N'16', N' ', N'16', N'16184845', N'10092752', N'11026826', N'21429392', N'10253101', N'169771
', N'576299', N'mariborskacesta16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141041, N'HS', N'11589006', N'17', N' ', N'17', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'169812
', N'576365', N'mariborskacesta17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141042, N'HS', N'11592619', N'1', N' ', N'1', N'16185116', N'10092752', N'11026826', N'21429392', N'10257204', N'170130
', N'576584', N'miklošičevaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141043, N'HS', N'11592627', N'2', N' ', N'2', N'16185116', N'10092752', N'11026826', N'21429392', N'10257204', N'170107
', N'576601', N'miklošičevaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141044, N'HS', N'11592635', N'3', N' ', N'3', N'16185116', N'10092752', N'11026826', N'21429392', N'10257204', N'170160
', N'576605', N'miklošičevaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141045, N'HS', N'11611982', N'1', N' ', N'1', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'162561
', N'573470', N'negova1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141046, N'HS', N'11612008', N'2', N' ', N'2', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'162591
', N'573399', N'negova2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141047, N'HS', N'11612016', N'3', N' ', N'3', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'162562
', N'573061', N'negova3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141048, N'HS', N'11612032', N'6', N' ', N'6', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163106
', N'572375', N'negova6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141049, N'HS', N'11612059', N'7', N' ', N'7', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163086
', N'572220', N'negova7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141050, N'HS', N'11612067', N'8', N' ', N'8', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163169
', N'572318', N'negova8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141051, N'HS', N'11612075', N'10', N' ', N'10', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163170
', N'572244', N'negova10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141052, N'HS', N'11592643', N'4', N' ', N'4', N'16185116', N'10092752', N'11026826', N'21429392', N'10257204', N'170136
', N'576620', N'miklošičevaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141053, N'HS', N'11592660', N'6', N' ', N'6', N'16185116', N'10092752', N'11026826', N'21429392', N'10257204', N'170149
', N'576638', N'miklošičevaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141054, N'HS', N'11592678', N'1', N' ', N'1', N'16185124', N'10092752', N'11026826', N'21429392', N'10252768', N'170946
', N'576347', N'mladinskaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141055, N'HS', N'11604056', N'1', N' ', N'1', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161622
', N'571933', N'kunova1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141056, N'HS', N'11604072', N'3', N' ', N'3', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161898
', N'572129', N'kunova3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141057, N'HS', N'11604129', N'6', N' ', N'6', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161656
', N'572722', N'kunova6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141058, N'HS', N'11604137', N'7', N' ', N'7', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161432
', N'572513', N'kunova7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141059, N'HS', N'11604153', N'9', N' ', N'9', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161485
', N'572584', N'kunova9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141060, N'HS', N'11604161', N'10', N' ', N'10', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161524
', N'572689', N'kunova10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141061, N'HS', N'11604170', N'11', N' ', N'11', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161544
', N'572761', N'kunova11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141062, N'HS', N'11604188', N'12', N' ', N'12', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161435
', N'572843', N'kunova12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141063, N'HS', N'11604196', N'13', N' ', N'13', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161369
', N'572789', N'kunova13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141064, N'HS', N'11604218', N'15', N' ', N'15', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161101
', N'572795', N'kunova15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141065, N'HS', N'11604226', N'16', N' ', N'16', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161405
', N'573007', N'kunova16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141066, N'HS', N'11604234', N'17', N' ', N'17', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161612
', N'572868', N'kunova17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141067, N'HS', N'11604242', N'18', N' ', N'18', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161714
', N'572931', N'kunova18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141068, N'HS', N'11604269', N'19', N' ', N'19', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161740
', N'572993', N'kunova19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141069, N'HS', N'11604285', N'20', N' ', N'20', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161712
', N'573036', N'kunova20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141070, N'HS', N'11604277', N'20', N'A', N'20A', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161718
', N'573093', N'kunova20a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141071, N'HS', N'11593950', N'7', N' ', N'7', N'16185299', N'10092752', N'11026826', N'21429392', N'10253233', N'171265
', N'575481', N'vaupotičevaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141072, N'HS', N'11593968', N'2', N' ', N'2', N'16185302', N'10092752', N'11026826', N'21429392', N'10257212', N'170257
', N'576546', N'vodnikovaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141073, N'HS', N'11593976', N'3', N' ', N'3', N'16185302', N'10092752', N'11026826', N'21429392', N'10257212', N'170296
', N'576529', N'vodnikovaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141074, N'HS', N'11593992', N'6', N' ', N'6', N'16185302', N'10092752', N'11026826', N'21429392', N'10257212', N'170291
', N'576573', N'vodnikovaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141075, N'HS', N'11591752', N'1', N' ', N'1', N'16184985', N'10092752', N'11026826', N'21429392', N'10253080', N'170254
', N'576209', N'vodovodnaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141076, N'HS', N'11591779', N'2', N' ', N'2', N'16184985', N'10092752', N'11026826', N'21429392', N'10253110', N'170156
', N'576175', N'vodovodnaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141077, N'HS', N'11591787', N'3', N' ', N'3', N'16184985', N'10092752', N'11026826', N'21429392', N'10253080', N'170224
', N'576217', N'vodovodnaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141078, N'HS', N'11591795', N'4', N' ', N'4', N'16184985', N'10092752', N'11026826', N'21429392', N'10253110', N'170123
', N'576189', N'vodovodnaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141079, N'HS', N'11591809', N'5', N' ', N'5', N'16184985', N'10092752', N'11026826', N'21429392', N'10253080', N'170143
', N'576224', N'vodovodnaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141080, N'HS', N'11591817', N'6', N' ', N'6', N'16184985', N'10092752', N'11026826', N'21429392', N'10253110', N'170100
', N'576193', N'vodovodnaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141081, N'HS', N'11591825', N'7', N' ', N'7', N'16184985', N'10092752', N'11026826', N'21429392', N'10253080', N'170122
', N'576231', N'vodovodnaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141082, N'HS', N'11591833', N'8', N' ', N'8', N'16184985', N'10092752', N'11026826', N'21429392', N'10253110', N'170080
', N'576187', N'vodovodnaulica8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141083, N'HS', N'11591841', N'9', N' ', N'9', N'16184985', N'10092752', N'11026826', N'21429392', N'10253080', N'170101
', N'576225', N'vodovodnaulica9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141084, N'HS', N'11591850', N'10', N' ', N'10', N'16184985', N'10092752', N'11026826', N'21429392', N'10253110', N'170061
', N'576193', N'vodovodnaulica10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141085, N'HS', N'11591868', N'11', N' ', N'11', N'16184985', N'10092752', N'11026826', N'21429392', N'10253080', N'170081
', N'576232', N'vodovodnaulica11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141086, N'HS', N'11591876', N'12', N' ', N'12', N'16184985', N'10092752', N'11026826', N'21429392', N'10253110', N'170030
', N'576191', N'vodovodnaulica12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141087, N'HS', N'11591884', N'13', N' ', N'13', N'16184985', N'10092752', N'11026826', N'21429392', N'10253071', N'170007
', N'576220', N'vodovodnaulica13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141088, N'HS', N'11591892', N'14', N' ', N'14', N'16184985', N'10092752', N'11026826', N'21429392', N'10253110', N'170005
', N'576185', N'vodovodnaulica14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141089, N'HS', N'11591906', N'15', N' ', N'15', N'16184985', N'10092752', N'11026826', N'21429392', N'10253071', N'169982
', N'576215', N'vodovodnaulica15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141090, N'HS', N'11591914', N'16', N' ', N'16', N'16184985', N'10092752', N'11026826', N'21429392', N'10253110', N'169979
', N'576185', N'vodovodnaulica16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141091, N'HS', N'11591922', N'18', N' ', N'18', N'16184985', N'10092752', N'11026826', N'21429392', N'10253110', N'169906
', N'576175', N'vodovodnaulica18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141092, N'HS', N'11594000', N'1', N' ', N'1', N'16185329', N'10092752', N'11026826', N'21429392', N'10253071', N'169918
', N'576306', N'vrazovaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141093, N'HS', N'11594018', N'3', N' ', N'3', N'16185329', N'10092752', N'11026826', N'21429392', N'10253071', N'169913
', N'576283', N'vrazovaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141094, N'HS', N'11594026', N'4', N' ', N'4', N'16185329', N'10092752', N'11026826', N'21429392', N'10253071', N'169950
', N'576283', N'vrazovaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141095, N'HS', N'11594034', N'5', N' ', N'5', N'16185329', N'10092752', N'11026826', N'21429392', N'10253071', N'169917
', N'576227', N'vrazovaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141096, N'HS', N'11594042', N'6', N' ', N'6', N'16185329', N'10092752', N'11026826', N'21429392', N'10253071', N'169954
', N'576210', N'vrazovaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141097, N'HS', N'11587666', N'1', N' ', N'1', N'16184764', N'10092752', N'11026826', N'21429392', N'10253233', N'171569
', N'575530', N'gubčevacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141098, N'HS', N'11587674', N'2', N' ', N'2', N'16184764', N'10092752', N'11026826', N'21429392', N'10253233', N'171571
', N'575521', N'gubčevacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141099, N'HS', N'11587682', N'3', N' ', N'3', N'16184764', N'10092752', N'11026826', N'21429392', N'10253233', N'171548
', N'575499', N'gubčevacesta3')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141100, N'HS', N'11587704', N'4', N' ', N'4', N'16184764', N'10092752', N'11026826', N'21429392', N'10253233', N'171530
', N'575434', N'gubčevacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141101, N'HS', N'11604293', N'21', N' ', N'21', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161710
', N'573147', N'kunova21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141102, N'HS', N'11604315', N'22', N' ', N'22', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161673
', N'573224', N'kunova22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141103, N'HS', N'11604307', N'22', N'A', N'22A', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161653
', N'573220', N'kunova22a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141104, N'HS', N'11604323', N'23', N' ', N'23', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161530
', N'573309', N'kunova23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141105, N'HS', N'11604331', N'24', N'A', N'24A', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161477
', N'573367', N'kunova24a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141106, N'HS', N'11604366', N'26', N' ', N'26', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161767
', N'573496', N'kunova26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141107, N'HS', N'11604374', N'27', N' ', N'27', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161797
', N'573384', N'kunova27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141108, N'HS', N'11613462', N'15', N' ', N'15', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169759
', N'575888', N'noričkivrh15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141109, N'HS', N'11613489', N'16', N' ', N'16', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169738
', N'575860', N'noričkivrh16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141110, N'HS', N'11613519', N'18', N' ', N'18', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169776
', N'575873', N'noričkivrh18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141111, N'HS', N'11613527', N'19', N' ', N'19', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169826
', N'575865', N'noričkivrh19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141112, N'HS', N'11613535', N'20', N' ', N'20', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169842
', N'575844', N'noričkivrh20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141113, N'HS', N'11613551', N'22', N' ', N'22', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169874
', N'575817', N'noričkivrh22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141114, N'HS', N'11613560', N'23', N' ', N'23', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169884
', N'575792', N'noričkivrh23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141115, N'HS', N'11613578', N'24', N' ', N'24', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'170039
', N'575819', N'noričkivrh24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141116, N'HS', N'11613586', N'25', N' ', N'25', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'170059
', N'575775', N'noričkivrh25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141117, N'HS', N'11613608', N'27', N' ', N'27', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169968
', N'575723', N'noričkivrh27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141118, N'HS', N'11613616', N'28', N' ', N'28', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169889
', N'575714', N'noričkivrh28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141119, N'HS', N'11613659', N'31', N' ', N'31', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169833
', N'575670', N'noričkivrh31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141120, N'HS', N'11613667', N'32', N' ', N'32', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169807
', N'575640', N'noričkivrh32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141121, N'HS', N'11613675', N'33', N' ', N'33', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169646
', N'575742', N'noričkivrh33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141122, N'HS', N'11613683', N'34', N' ', N'34', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169655
', N'575407', N'noričkivrh34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141123, N'HS', N'11613691', N'35', N' ', N'35', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169705
', N'575371', N'noričkivrh35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141124, N'HS', N'11613705', N'36', N' ', N'36', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169699
', N'575434', N'noričkivrh36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141125, N'HS', N'11613713', N'37', N' ', N'37', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169684
', N'575441', N'noričkivrh37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141126, N'HS', N'11613721', N'38', N' ', N'38', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170029
', N'575328', N'noričkivrh38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141127, N'HS', N'11613730', N'39', N' ', N'39', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170032
', N'575317', N'noričkivrh39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141128, N'HS', N'11613756', N'41', N' ', N'41', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170092
', N'575430', N'noričkivrh41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141129, N'HS', N'11613764', N'42', N' ', N'42', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170112
', N'575453', N'noričkivrh42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141130, N'HS', N'11613772', N'43', N' ', N'43', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170139
', N'575448', N'noričkivrh43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141131, N'HS', N'11613799', N'44', N' ', N'44', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170150
', N'575473', N'noričkivrh44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141132, N'HS', N'11613802', N'45', N' ', N'45', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170165
', N'575487', N'noričkivrh45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141133, N'HS', N'11613829', N'46', N' ', N'46', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170130
', N'575511', N'noričkivrh46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141134, N'HS', N'11613837', N'47', N' ', N'47', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170141
', N'575530', N'noričkivrh47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141135, N'HS', N'11613845', N'48', N' ', N'48', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170191
', N'575506', N'noričkivrh48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141136, N'HS', N'11613853', N'49', N' ', N'49', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170218
', N'575540', N'noričkivrh49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141137, N'HS', N'11619100', N'10', N' ', N'10', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171281
', N'574743', N'podgrad10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141138, N'HS', N'11619118', N'11', N' ', N'11', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171258
', N'574696', N'podgrad11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141139, N'HS', N'11619126', N'13', N' ', N'13', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171248
', N'574649', N'podgrad13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141140, N'HS', N'11619134', N'14', N' ', N'14', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171235
', N'574619', N'podgrad14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141141, N'HS', N'11619142', N'15', N' ', N'15', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171228
', N'574609', N'podgrad15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141142, N'HS', N'11619169', N'16', N' ', N'16', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171204
', N'574591', N'podgrad16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141143, N'HS', N'11619185', N'18', N' ', N'18', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171161
', N'574621', N'podgrad18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141144, N'HS', N'11619193', N'19', N' ', N'19', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171173
', N'574600', N'podgrad19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141145, N'HS', N'11619207', N'20', N' ', N'20', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171150
', N'574579', N'podgrad20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141146, N'HS', N'11619215', N'21', N' ', N'21', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171190
', N'574551', N'podgrad21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141147, N'HS', N'11619223', N'22', N' ', N'22', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171153
', N'574553', N'podgrad22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141148, N'HS', N'11619231', N'23', N' ', N'23', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171176
', N'574525', N'podgrad23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141149, N'HS', N'11619240', N'24', N' ', N'24', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171144
', N'574502', N'podgrad24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141150, N'HS', N'11619258', N'25', N' ', N'25', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171127
', N'574483', N'podgrad25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141151, N'HS', N'11619266', N'26', N' ', N'26', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171141
', N'574441', N'podgrad26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141152, N'HS', N'11619274', N'27', N' ', N'27', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171107
', N'574406', N'podgrad27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141153, N'HS', N'11619282', N'28', N' ', N'28', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171033
', N'574313', N'podgrad28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141154, N'HS', N'11619312', N'31', N' ', N'31', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'170878
', N'573768', N'podgrad31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141155, N'HS', N'11619339', N'32', N' ', N'32', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171237
', N'574528', N'podgrad32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141156, N'HS', N'11619347', N'33', N' ', N'33', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171264
', N'574607', N'podgrad33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141157, N'HS', N'11619355', N'34', N' ', N'34', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171286
', N'574524', N'podgrad34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141158, N'HS', N'11619371', N'37', N' ', N'37', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171353
', N'574283', N'podgrad37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141159, N'HS', N'11619380', N'38', N' ', N'38', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171149
', N'574289', N'podgrad38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141160, N'HS', N'11583776', N'177', N' ', N'177', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168215
', N'575458', N'črešnjevci177')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141161, N'HS', N'11583792', N'179', N' ', N'179', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168137
', N'575209', N'črešnjevci179')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141162, N'HS', N'11583806', N'180', N' ', N'180', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168132
', N'575185', N'črešnjevci180')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141163, N'HS', N'11583814', N'181', N' ', N'181', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168065
', N'575200', N'črešnjevci181')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141164, N'HS', N'11594069', N'7', N' ', N'7', N'16185329', N'10092752', N'11026826', N'21429392', N'10253071', N'169925
', N'576209', N'vrazovaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141165, N'HS', N'11591469', N'1', N' ', N'1', N'16184969', N'10092752', N'11026826', N'21429392', N'10257212', N'170455
', N'576412', N'vrečovacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141166, N'HS', N'11591477', N'2', N' ', N'2', N'16184969', N'10092752', N'11026826', N'21429392', N'10257212', N'170421
', N'576405', N'vrečovacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141167, N'HS', N'11591493', N'4', N' ', N'4', N'16184969', N'10092752', N'11026826', N'21429392', N'10257212', N'170414
', N'576433', N'vrečovacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141168, N'HS', N'11591507', N'5', N' ', N'5', N'16184969', N'10092752', N'11026826', N'21429392', N'10257212', N'170420
', N'576454', N'vrečovacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141169, N'HS', N'11591515', N'6', N' ', N'6', N'16184969', N'10092752', N'11026826', N'21429392', N'10257212', N'170395
', N'576476', N'vrečovacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141170, N'HS', N'11591531', N'8', N' ', N'8', N'16184969', N'10092752', N'11026826', N'21429392', N'10257212', N'170386
', N'576454', N'vrečovacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141171, N'HS', N'11591540', N'9', N' ', N'9', N'16184969', N'10092752', N'11026826', N'21429392', N'10257212', N'170363
', N'576462', N'vrečovacesta9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141172, N'HS', N'11591558', N'10', N' ', N'10', N'16184969', N'10092752', N'11026826', N'21429392', N'10257212', N'170313
', N'576483', N'vrečovacesta10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141173, N'HS', N'11591566', N'11', N' ', N'11', N'16184969', N'10092752', N'11026826', N'21429392', N'10257212', N'170251
', N'576520', N'vrečovacesta11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141174, N'HS', N'11591582', N'2', N' ', N'2', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171170
', N'576200', N'vrtnaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141175, N'HS', N'11591604', N'3', N' ', N'3', N'16184977', N'10092752', N'11026826', N'21429392', N'10253225', N'171231
', N'576171', N'vrtnaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141176, N'HS', N'11587712', N'5', N' ', N'5', N'16184764', N'10092752', N'11026826', N'21429392', N'10253233', N'171528
', N'575390', N'gubčevacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141177, N'HS', N'11592279', N'2', N' ', N'2', N'16185051', N'10092752', N'11026826', N'21429392', N'10257212', N'170357
', N'576505', N'horvatovaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141178, N'HS', N'11592287', N'3', N' ', N'3', N'16185051', N'10092752', N'11026826', N'21429392', N'10257212', N'170333
', N'576520', N'horvatovaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141179, N'HS', N'11592295', N'1', N' ', N'1', N'16185060', N'10092752', N'11026826', N'21429392', N'10253233', N'171321
', N'575567', N'ilirskaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141180, N'HS', N'11592309', N'2', N' ', N'2', N'16185060', N'10092752', N'11026826', N'21429392', N'10253233', N'171342
', N'575609', N'ilirskaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141181, N'HS', N'11592317', N'3', N' ', N'3', N'16185060', N'10092752', N'11026826', N'21429392', N'10253233', N'171352
', N'575558', N'ilirskaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141182, N'HS', N'11592325', N'4', N' ', N'4', N'16185060', N'10092752', N'11026826', N'21429392', N'10253233', N'171378
', N'575612', N'ilirskaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141183, N'HS', N'11592333', N'5', N' ', N'5', N'16185060', N'10092752', N'11026826', N'21429392', N'10253233', N'171349
', N'575535', N'ilirskaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141184, N'HS', N'11592341', N'6', N' ', N'6', N'16185060', N'10092752', N'11026826', N'21429392', N'10253233', N'171389
', N'575588', N'ilirskaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141185, N'HS', N'11587747', N'1', N' ', N'1', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171202
', N'575956', N'jurkovičevaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141186, N'HS', N'11587755', N'2', N' ', N'2', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171233
', N'575980', N'jurkovičevaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141187, N'HS', N'11587763', N'3', N' ', N'3', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171239
', N'575962', N'jurkovičevaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141188, N'HS', N'11587771', N'5', N' ', N'5', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171273
', N'575955', N'jurkovičevaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141189, N'HS', N'11587780', N'7', N' ', N'7', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171290
', N'575934', N'jurkovičevaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141190, N'HS', N'11587798', N'9', N' ', N'9', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171306
', N'575947', N'jurkovičevaulica9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141191, N'HS', N'11587801', N'11', N' ', N'11', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171330
', N'575919', N'jurkovičevaulica11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141192, N'HS', N'11587836', N'15', N' ', N'15', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171381
', N'575914', N'jurkovičevaulica15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141193, N'HS', N'11587852', N'17', N' ', N'17', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171408
', N'575898', N'jurkovičevaulica17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141194, N'HS', N'11587879', N'19', N' ', N'19', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171438
', N'575877', N'jurkovičevaulica19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141195, N'HS', N'11587895', N'23', N' ', N'23', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171462
', N'575864', N'jurkovičevaulica23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141196, N'HS', N'11587909', N'25', N' ', N'25', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171475
', N'575853', N'jurkovičevaulica25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141197, N'HS', N'11587917', N'27', N' ', N'27', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171489
', N'575847', N'jurkovičevaulica27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141198, N'HS', N'11587925', N'29', N' ', N'29', N'16184772', N'10092752', N'11026826', N'21429392', N'10253128', N'171498
', N'575841', N'jurkovičevaulica29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141199, N'HS', N'11592350', N'1', N' ', N'1', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169614
', N'576334', N'kajuhovaulica1')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141200, N'HS', N'11592368', N'2', N' ', N'2', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169615
', N'576308', N'kajuhovaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141201, N'HS', N'11592376', N'3', N' ', N'3', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169616
', N'576278', N'kajuhovaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141202, N'HS', N'11592392', N'5', N' ', N'5', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169616
', N'576224', N'kajuhovaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141203, N'HS', N'11587933', N'1', N' ', N'1', N'16184799', N'10092752', N'11026826', N'21429392', N'10253128', N'171311
', N'576000', N'kerenčičevaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141204, N'HS', N'11587941', N'2', N' ', N'2', N'16184799', N'10092752', N'11026826', N'21429392', N'10253284', N'171350
', N'576013', N'kerenčičevaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141205, N'HS', N'11587950', N'3', N' ', N'3', N'16184799', N'10092752', N'11026826', N'21429392', N'10253128', N'171334
', N'575989', N'kerenčičevaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141206, N'HS', N'11598293', N'9', N' ', N'9', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161052
', N'574136', N'ivanjskivrh9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141207, N'HS', N'11598307', N'10', N' ', N'10', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161085
', N'574153', N'ivanjskivrh10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141208, N'HS', N'11598315', N'11', N' ', N'11', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161170
', N'574133', N'ivanjskivrh11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141209, N'HS', N'11613861', N'50', N' ', N'50', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170222
', N'575600', N'noričkivrh50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141210, N'HS', N'11613870', N'51', N' ', N'51', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170283
', N'575603', N'noričkivrh51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141211, N'HS', N'11613888', N'52', N' ', N'52', N'16276014', N'10093155', N'11026826', N'21429392', N'10252709', N'170261
', N'575728', N'noričkivrh52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141212, N'HS', N'11579361', N'1', N' ', N'1', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168478
', N'573312', N'aženskivrh1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141213, N'HS', N'11579388', N'3', N' ', N'3', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168430
', N'573183', N'aženskivrh3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141214, N'HS', N'11579396', N'4', N' ', N'4', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168503
', N'573155', N'aženskivrh4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141215, N'HS', N'11579400', N'5', N' ', N'5', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168366
', N'573038', N'aženskivrh5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141216, N'HS', N'11612504', N'51', N' ', N'51', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162782
', N'571336', N'negova51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141217, N'HS', N'19133036', N'25', N'A', N'25A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169938
', N'573050', N'lomanoše25a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141218, N'HS', N'11606962', N'15', N' ', N'15', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170145
', N'573235', N'lomanoše15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141219, N'HS', N'19137082', N'41', N'A', N'41A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167793
', N'572063', N'spodnjaščavnica41a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141220, N'HS', N'11609686', N'27', N' ', N'27', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168885
', N'578277', N'mele27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141221, N'HS', N'19137147', N'5', N' ', N'5', N'16185302', N'10092752', N'11026826', N'21429392', N'10257212', N'170310
', N'576552', N'vodnikovaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141222, N'HS', N'19134423', N'65', N'A', N'65A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162173
', N'570896', N'negova65a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141223, N'HS', N'19137112', N'27', N'C', N'27C', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162715
', N'577622', N'očeslavci27c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141224, N'HS', N'11635938', N'83', N' ', N'83', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168013
', N'569792', N'spodnjaščavnica83')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141225, N'HS', N'11635946', N'84', N' ', N'84', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167995
', N'569655', N'spodnjaščavnica84')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141226, N'HS', N'11635962', N'86', N' ', N'86', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167738
', N'569421', N'spodnjaščavnica86')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141227, N'HS', N'11636004', N'89', N' ', N'89', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167918
', N'569043', N'spodnjaščavnica89')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141228, N'HS', N'11636012', N'90', N' ', N'90', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168124
', N'568877', N'spodnjaščavnica90')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141229, N'HS', N'11636039', N'91', N' ', N'91', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168151
', N'568725', N'spodnjaščavnica91')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141230, N'HS', N'11636047', N'92', N' ', N'92', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167840
', N'568659', N'spodnjaščavnica92')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141231, N'HS', N'11636063', N'94', N' ', N'94', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167481
', N'568415', N'spodnjaščavnica94')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141232, N'HS', N'11636071', N'95', N' ', N'95', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167530
', N'568754', N'spodnjaščavnica95')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141233, N'HS', N'11621201', N'124', N' ', N'124', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'168696
', N'573495', N'police124')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141234, N'HS', N'11621236', N'127', N' ', N'127', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168489
', N'573404', N'police127')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141235, N'HS', N'11621244', N'128', N' ', N'128', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168446
', N'573378', N'police128')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141236, N'HS', N'11621287', N'131', N' ', N'131', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168379
', N'573363', N'police131')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141237, N'HS', N'11621295', N'132', N' ', N'132', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168134
', N'573363', N'police132')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141238, N'HS', N'11621309', N'133', N' ', N'133', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168015
', N'573364', N'police133')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141239, N'HS', N'11621317', N'134', N' ', N'134', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'167941
', N'573250', N'police134')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141240, N'HS', N'11621333', N'136', N' ', N'136', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'167887
', N'573221', N'police136')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141241, N'HS', N'11621341', N'137', N' ', N'137', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'167758
', N'573196', N'police137')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141242, N'HS', N'11621350', N'138', N' ', N'138', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'167549
', N'573146', N'police138')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141243, N'HS', N'11621376', N'140', N' ', N'140', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'167423
', N'573102', N'police140')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141244, N'HS', N'11621384', N'141', N' ', N'141', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'167398
', N'573054', N'police141')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141245, N'HS', N'11621406', N'1', N' ', N'1', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166982
', N'576971', N'ptujskacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141246, N'HS', N'11621392', N'1', N'A', N'1A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166964
', N'576961', N'ptujskacesta1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141247, N'HS', N'11621422', N'3', N'A', N'3A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166835
', N'576780', N'ptujskacesta3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141248, N'HS', N'11621457', N'4', N' ', N'4', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166756
', N'576824', N'ptujskacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141249, N'HS', N'11621473', N'6', N' ', N'6', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166736
', N'576672', N'ptujskacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141250, N'HS', N'11621481', N'7', N' ', N'7', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166606
', N'576735', N'ptujskacesta7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141251, N'HS', N'11621503', N'8', N' ', N'8', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166326
', N'576711', N'ptujskacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141252, N'HS', N'11621490', N'8', N'A', N'8A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166405
', N'576774', N'ptujskacesta8a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141253, N'HS', N'11621511', N'9', N' ', N'9', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166315
', N'576685', N'ptujskacesta9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141254, N'HS', N'11621538', N'10', N' ', N'10', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166381
', N'576583', N'ptujskacesta10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141255, N'HS', N'11621520', N'10', N'A', N'10A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166346
', N'576621', N'ptujskacesta10a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141256, N'HS', N'11621546', N'11', N' ', N'11', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166407
', N'576527', N'ptujskacesta11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141257, N'HS', N'11621554', N'12', N' ', N'12', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166391
', N'576518', N'ptujskacesta12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141258, N'HS', N'11621562', N'13', N' ', N'13', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166328
', N'576573', N'ptujskacesta13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141259, N'HS', N'11621589', N'14', N' ', N'14', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166318
', N'576495', N'ptujskacesta14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141260, N'HS', N'11629873', N'5', N' ', N'5', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166792
', N'574713', N'rodmošci5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141261, N'HS', N'11629881', N'6', N' ', N'6', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166703
', N'574669', N'rodmošci6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141262, N'HS', N'11629903', N'8', N' ', N'8', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166367
', N'574567', N'rodmošci8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141263, N'HS', N'11629920', N'10', N' ', N'10', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166325
', N'574382', N'rodmošci10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141264, N'HS', N'11629938', N'11', N' ', N'11', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166210
', N'574321', N'rodmošci11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141265, N'HS', N'11629954', N'12', N' ', N'12', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166118
', N'574243', N'rodmošci12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141266, N'HS', N'11629989', N'14', N' ', N'14', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166016
', N'574138', N'rodmošci14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141267, N'HS', N'11644058', N'59', N' ', N'59', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'166983
', N'573735', N'zbigovci59')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141268, N'HS', N'11644082', N'63', N' ', N'63', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167271
', N'573777', N'zbigovci63')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141269, N'HS', N'11644112', N'65', N'A', N'65A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167220
', N'573650', N'zbigovci65a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141270, N'HS', N'11644139', N'65', N'B', N'65B', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167107
', N'573542', N'zbigovci65b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141271, N'HS', N'11644155', N'66', N' ', N'66', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167576
', N'573792', N'zbigovci66')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141272, N'HS', N'11644163', N'67', N' ', N'67', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167656
', N'573864', N'zbigovci67')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141273, N'HS', N'11644180', N'68', N' ', N'68', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167743
', N'573863', N'zbigovci68')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141274, N'HS', N'11644171', N'68', N'A', N'68A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167868
', N'573952', N'zbigovci68a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141275, N'HS', N'11644198', N'69', N' ', N'69', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167932
', N'574082', N'zbigovci69')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141276, N'HS', N'11644210', N'71', N' ', N'71', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167669
', N'574260', N'zbigovci71')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141277, N'HS', N'19130681', N'1', N'B', N'1B', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167183
', N'577164', N'orehovci1b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141278, N'HS', N'19130541', N'50', N'A', N'50A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162872
', N'571350', N'negova50a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141279, N'HS', N'11636110', N'97', N' ', N'97', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167656
', N'569039', N'spodnjaščavnica97')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141280, N'HS', N'11636314', N'1', N' ', N'1', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161309
', N'574922', N'spodnjiivanjci1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141281, N'HS', N'11636349', N'2', N' ', N'2', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161305
', N'574584', N'spodnjiivanjci2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141282, N'HS', N'11636322', N'2', N'A', N'2A', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161266
', N'574570', N'spodnjiivanjci2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141283, N'HS', N'11636403', N'3', N' ', N'3', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161630
', N'574591', N'spodnjiivanjci3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141284, N'HS', N'11644228', N'72', N' ', N'72', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167399
', N'574094', N'zbigovci72')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141285, N'HS', N'11644236', N'73', N' ', N'73', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167656
', N'574364', N'zbigovci73')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141286, N'HS', N'11644244', N'74', N' ', N'74', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167788
', N'574503', N'zbigovci74')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141287, N'HS', N'11644252', N'75', N' ', N'75', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167995
', N'574147', N'zbigovci75')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141288, N'HS', N'11644287', N'77', N' ', N'77', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'168297
', N'574275', N'zbigovci77')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141289, N'HS', N'11644295', N'78', N' ', N'78', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'168255
', N'574255', N'zbigovci78')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141290, N'HS', N'11644317', N'80', N' ', N'80', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'168470
', N'574304', N'zbigovci80')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141291, N'HS', N'11644325', N'81', N' ', N'81', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'168618
', N'574381', N'zbigovci81')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141292, N'HS', N'11644333', N'82', N' ', N'82', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'168116
', N'574446', N'zbigovci82')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141293, N'HS', N'11634745', N'2', N' ', N'2', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168322
', N'568722', N'spodnjaščavnica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141294, N'HS', N'11634753', N'3', N' ', N'3', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168379
', N'568840', N'spodnjaščavnica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141295, N'HS', N'11634770', N'6', N' ', N'6', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168639
', N'569421', N'spodnjaščavnica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141296, N'HS', N'11634800', N'9', N' ', N'9', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168652
', N'569892', N'spodnjaščavnica9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141297, N'HS', N'11634826', N'10', N' ', N'10', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168716
', N'569943', N'spodnjaščavnica10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141298, N'HS', N'11634834', N'11', N' ', N'11', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168344
', N'570309', N'spodnjaščavnica11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141299, N'HS', N'11634842', N'12', N' ', N'12', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168531
', N'570732', N'spodnjaščavnica12')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141300, N'HS', N'11634869', N'13', N'A', N'13A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168374
', N'571376', N'spodnjaščavnica13a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141301, N'HS', N'11634885', N'14', N' ', N'14', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168480
', N'571457', N'spodnjaščavnica14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141302, N'HS', N'11634931', N'17', N' ', N'17', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168634
', N'571531', N'spodnjaščavnica17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141303, N'HS', N'11634923', N'17', N'A', N'17A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168709
', N'571560', N'spodnjaščavnica17a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141304, N'HS', N'11634940', N'18', N'A', N'18A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168591
', N'571584', N'spodnjaščavnica18a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141305, N'HS', N'11634982', N'19', N' ', N'19', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167968
', N'571193', N'spodnjaščavnica19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141306, N'HS', N'11635008', N'20', N' ', N'20', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167940
', N'571133', N'spodnjaščavnica20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141307, N'HS', N'11638937', N'51', N' ', N'51', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163608
', N'576152', N'stavešinskivrh51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141308, N'HS', N'11638945', N'52', N' ', N'52', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163595
', N'576164', N'stavešinskivrh52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141309, N'HS', N'11638961', N'54', N' ', N'54', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163565
', N'576199', N'stavešinskivrh54')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141310, N'HS', N'11639003', N'58', N' ', N'58', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163681
', N'576483', N'stavešinskivrh58')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141311, N'HS', N'11621619', N'15', N' ', N'15', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166300
', N'576453', N'ptujskacesta15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141312, N'HS', N'11621597', N'15', N'A', N'15A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166327
', N'576460', N'ptujskacesta15a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141313, N'HS', N'16171484', N'15', N'B', N'15B', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166298
', N'576450', N'ptujskacesta15b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141314, N'HS', N'11621643', N'18', N' ', N'18', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166269
', N'576322', N'ptujskacesta18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141315, N'HS', N'11642799', N'1', N' ', N'1', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166634
', N'570401', N'zagajskivrh1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141316, N'HS', N'11642772', N'1', N'A', N'1A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166608
', N'570338', N'zagajskivrh1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141317, N'HS', N'11642837', N'4', N' ', N'4', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167073
', N'570128', N'zagajskivrh4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141318, N'HS', N'11642845', N'5', N' ', N'5', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166884
', N'570163', N'zagajskivrh5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141319, N'HS', N'11642853', N'6', N' ', N'6', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166708
', N'570063', N'zagajskivrh6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141320, N'HS', N'11642888', N'8', N' ', N'8', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166756
', N'569794', N'zagajskivrh8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141321, N'HS', N'11642934', N'12', N' ', N'12', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166856
', N'569713', N'zagajskivrh12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141322, N'HS', N'11642969', N'13', N' ', N'13', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166935
', N'569687', N'zagajskivrh13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141323, N'HS', N'11642993', N'19', N' ', N'19', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167248
', N'569537', N'zagajskivrh19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141324, N'HS', N'11643019', N'20', N' ', N'20', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167374
', N'569499', N'zagajskivrh20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141325, N'HS', N'11643035', N'21', N' ', N'21', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167189
', N'569524', N'zagajskivrh21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141326, N'HS', N'11643043', N'22', N' ', N'22', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167044
', N'569517', N'zagajskivrh22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141327, N'HS', N'11636454', N'6', N' ', N'6', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161842
', N'575553', N'spodnjiivanjci6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141328, N'HS', N'11636489', N'8', N' ', N'8', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161780
', N'575533', N'spodnjiivanjci8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141329, N'HS', N'11636519', N'9', N' ', N'9', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161782
', N'575572', N'spodnjiivanjci9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141330, N'HS', N'11636497', N'9', N'A', N'9A', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161770
', N'575560', N'spodnjiivanjci9a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141331, N'HS', N'11636543', N'12', N' ', N'12', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161557
', N'575555', N'spodnjiivanjci12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141332, N'HS', N'11636551', N'13', N' ', N'13', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161516
', N'575524', N'spodnjiivanjci13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141333, N'HS', N'11636586', N'15', N' ', N'15', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161460
', N'575556', N'spodnjiivanjci15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141334, N'HS', N'11636616', N'17', N' ', N'17', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161308
', N'575499', N'spodnjiivanjci17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141335, N'HS', N'11636624', N'18', N' ', N'18', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161243
', N'575483', N'spodnjiivanjci18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141336, N'HS', N'11636667', N'21', N' ', N'21', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'160988
', N'575119', N'spodnjiivanjci21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141337, N'HS', N'11636675', N'22', N' ', N'22', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'160914
', N'575040', N'spodnjiivanjci22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141338, N'HS', N'11636721', N'26', N' ', N'26', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161178
', N'576163', N'spodnjiivanjci26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141339, N'HS', N'11636730', N'27', N' ', N'27', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161203
', N'576076', N'spodnjiivanjci27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141340, N'HS', N'11636756', N'29', N' ', N'29', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161490
', N'576123', N'spodnjiivanjci29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141341, N'HS', N'11636772', N'31', N' ', N'31', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161643
', N'576342', N'spodnjiivanjci31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141342, N'HS', N'11636799', N'32', N' ', N'32', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161445
', N'577052', N'spodnjiivanjci32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141343, N'HS', N'11636802', N'33', N' ', N'33', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161496
', N'577108', N'spodnjiivanjci33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141344, N'HS', N'11636829', N'34', N' ', N'34', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161612
', N'575524', N'spodnjiivanjci34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141345, N'HS', N'11637990', N'1', N' ', N'1', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163205
', N'576186', N'stavešinci1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141346, N'HS', N'11643060', N'23', N' ', N'23', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167052
', N'569477', N'zagajskivrh23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141347, N'HS', N'11643051', N'23', N'A', N'23A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167052
', N'569427', N'zagajskivrh23a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141348, N'HS', N'11643078', N'24', N'A', N'24A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167024
', N'569331', N'zagajskivrh24a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141349, N'HS', N'11643094', N'25', N' ', N'25', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167143
', N'569336', N'zagajskivrh25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141350, N'HS', N'11643108', N'26', N' ', N'26', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167194
', N'569330', N'zagajskivrh26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141351, N'HS', N'11643116', N'27', N' ', N'27', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167336
', N'569390', N'zagajskivrh27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141352, N'HS', N'11643124', N'28', N' ', N'28', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167371
', N'569323', N'zagajskivrh28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141353, N'HS', N'11643132', N'29', N' ', N'29', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167294
', N'569243', N'zagajskivrh29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141354, N'HS', N'11635032', N'21', N' ', N'21', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167926
', N'571104', N'spodnjaščavnica21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141355, N'HS', N'11621678', N'20', N' ', N'20', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166204
', N'576267', N'ptujskacesta20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141356, N'HS', N'11621660', N'20', N'A', N'20A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166236
', N'576306', N'ptujskacesta20a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141357, N'HS', N'11621694', N'23', N' ', N'23', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166373
', N'576171', N'ptujskacesta23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141358, N'HS', N'11621708', N'24', N' ', N'24', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166412
', N'576095', N'ptujskacesta24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141359, N'HS', N'11621716', N'25', N' ', N'25', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166276
', N'576004', N'ptujskacesta25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141360, N'HS', N'11621767', N'28', N' ', N'28', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165845
', N'576218', N'ptujskacesta28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141361, N'HS', N'11621759', N'28', N'A', N'28A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165829
', N'576259', N'ptujskacesta28a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141362, N'HS', N'11621775', N'29', N' ', N'29', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165810
', N'576240', N'ptujskacesta29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141363, N'HS', N'11621791', N'30', N' ', N'30', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165785
', N'576267', N'ptujskacesta30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141364, N'HS', N'11621856', N'32', N' ', N'32', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165507
', N'576139', N'ptujskacesta32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141365, N'HS', N'11621864', N'33', N' ', N'33', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165542
', N'576074', N'ptujskacesta33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141366, N'HS', N'11621872', N'34', N' ', N'34', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165369
', N'576005', N'ptujskacesta34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141367, N'HS', N'11621902', N'35', N' ', N'35', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165348
', N'576175', N'ptujskacesta35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141368, N'HS', N'11621899', N'35', N'A', N'35A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165299
', N'576169', N'ptujskacesta35a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141369, N'HS', N'11621953', N'39', N' ', N'39', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165600
', N'576367', N'ptujskacesta39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141370, N'HS', N'11635067', N'23', N' ', N'23', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167926
', N'571368', N'spodnjaščavnica23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141371, N'HS', N'11635075', N'24', N' ', N'24', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168062
', N'571480', N'spodnjaščavnica24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141372, N'HS', N'11635083', N'25', N' ', N'25', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168444
', N'571840', N'spodnjaščavnica25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141373, N'HS', N'11635113', N'28', N' ', N'28', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168525
', N'572023', N'spodnjaščavnica28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141374, N'HS', N'11635121', N'29', N' ', N'29', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168502
', N'572138', N'spodnjaščavnica29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141375, N'HS', N'11635130', N'30', N' ', N'30', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168402
', N'571942', N'spodnjaščavnica30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141376, N'HS', N'11635172', N'34', N' ', N'34', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167935
', N'571922', N'spodnjaščavnica34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141377, N'HS', N'11635237', N'36', N' ', N'36', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167950
', N'571696', N'spodnjaščavnica36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141378, N'HS', N'11635253', N'37', N' ', N'37', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167879
', N'571712', N'spodnjaščavnica37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141379, N'HS', N'11635270', N'39', N' ', N'39', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167336
', N'572072', N'spodnjaščavnica39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141380, N'HS', N'11635296', N'41', N' ', N'41', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167741
', N'572068', N'spodnjaščavnica41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141381, N'HS', N'11635318', N'42', N' ', N'42', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167851
', N'572040', N'spodnjaščavnica42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141382, N'HS', N'11635342', N'43', N' ', N'43', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167629
', N'572245', N'spodnjaščavnica43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141383, N'HS', N'11635334', N'43', N'B', N'43B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167640
', N'572230', N'spodnjaščavnica43b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141384, N'HS', N'11635407', N'44', N' ', N'44', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167788
', N'572321', N'spodnjaščavnica44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141385, N'HS', N'11635385', N'44', N'C', N'44C', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167678
', N'572338', N'spodnjaščavnica44c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141386, N'HS', N'11635423', N'45', N' ', N'45', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167847
', N'572303', N'spodnjaščavnica45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141387, N'HS', N'11635431', N'46', N' ', N'46', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167982
', N'572145', N'spodnjaščavnica46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141388, N'HS', N'11635440', N'47', N' ', N'47', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167982
', N'572303', N'spodnjaščavnica47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141389, N'HS', N'11635482', N'48', N' ', N'48', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168258
', N'572221', N'spodnjaščavnica48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141390, N'HS', N'11635458', N'48', N'A', N'48A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168238
', N'572199', N'spodnjaščavnica48a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141391, N'HS', N'11621961', N'40', N' ', N'40', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165618
', N'576369', N'ptujskacesta40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141392, N'HS', N'11621970', N'41', N' ', N'41', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165595
', N'576592', N'ptujskacesta41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141393, N'HS', N'11621996', N'43', N' ', N'43', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165942
', N'576556', N'ptujskacesta43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141394, N'HS', N'11622003', N'44', N' ', N'44', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166108
', N'576833', N'ptujskacesta44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141395, N'HS', N'11622011', N'45', N' ', N'45', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166431
', N'576846', N'ptujskacesta45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141396, N'HS', N'11622054', N'46', N' ', N'46', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166434
', N'576872', N'ptujskacesta46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141397, N'HS', N'11622020', N'46', N'A', N'46A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166475
', N'576902', N'ptujskacesta46a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141398, N'HS', N'11622038', N'46', N'B', N'46B', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166517
', N'576992', N'ptujskacesta46b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141399, N'HS', N'11622046', N'46', N'C', N'46C', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166642
', N'577044', N'ptujskacesta46c')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141400, N'HS', N'11622062', N'47', N' ', N'47', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166581
', N'577112', N'ptujskacesta47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141401, N'HS', N'11622097', N'49', N' ', N'49', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166592
', N'577179', N'ptujskacesta49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141402, N'HS', N'11643159', N'30', N' ', N'30', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167187
', N'569241', N'zagajskivrh30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141403, N'HS', N'11643167', N'31', N' ', N'31', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167183
', N'569202', N'zagajskivrh31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141404, N'HS', N'11643183', N'33', N' ', N'33', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167009
', N'569247', N'zagajskivrh33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141405, N'HS', N'11643191', N'34', N' ', N'34', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167026
', N'569297', N'zagajskivrh34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141406, N'HS', N'11643205', N'35', N' ', N'35', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166996
', N'569284', N'zagajskivrh35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141407, N'HS', N'11643248', N'38', N' ', N'38', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166897
', N'569229', N'zagajskivrh38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141408, N'HS', N'11643264', N'39', N' ', N'39', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166858
', N'569181', N'zagajskivrh39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141409, N'HS', N'11643299', N'40', N' ', N'40', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166730
', N'569201', N'zagajskivrh40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141410, N'HS', N'11643345', N'44', N' ', N'44', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166969
', N'568643', N'zagajskivrh44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141411, N'HS', N'11643353', N'45', N' ', N'45', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167223
', N'568279', N'zagajskivrh45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141412, N'HS', N'11643361', N'1', N' ', N'1', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167977
', N'575739', N'zbigovci1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141413, N'HS', N'11643388', N'2', N' ', N'2', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167686
', N'575621', N'zbigovci2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141414, N'HS', N'11643426', N'4', N' ', N'4', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167915
', N'575261', N'zbigovci4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141415, N'HS', N'11643434', N'6', N' ', N'6', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167873
', N'575195', N'zbigovci6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141416, N'HS', N'11637973', N'1', N'B', N'1B', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163131
', N'576327', N'stavešinci1b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141417, N'HS', N'11637981', N'1', N'C', N'1C', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163139
', N'576278', N'stavešinci1c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141418, N'HS', N'11638023', N'2', N' ', N'2', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163468
', N'575986', N'stavešinci2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141419, N'HS', N'11638007', N'2', N'A', N'2A', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163409
', N'576091', N'stavešinci2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141420, N'HS', N'11638040', N'3', N' ', N'3', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163046
', N'575979', N'stavešinci3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141421, N'HS', N'11638031', N'3', N'A', N'3A', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163409
', N'575920', N'stavešinci3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141422, N'HS', N'11638066', N'4', N' ', N'4', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'162923
', N'575731', N'stavešinci4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141423, N'HS', N'11638058', N'4', N'A', N'4A', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163034
', N'575612', N'stavešinci4a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141424, N'HS', N'11638074', N'5', N'A', N'5A', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163093
', N'575477', N'stavešinci5a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141425, N'HS', N'11638104', N'6', N' ', N'6', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163116
', N'575466', N'stavešinci6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141426, N'HS', N'11638139', N'8', N' ', N'8', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163023
', N'575324', N'stavešinci8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141427, N'HS', N'11638147', N'9', N' ', N'9', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'162994
', N'575283', N'stavešinci9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141428, N'HS', N'11638163', N'11', N' ', N'11', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163524
', N'575234', N'stavešinci11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141429, N'HS', N'11638171', N'12', N' ', N'12', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163053
', N'575204', N'stavešinci12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141430, N'HS', N'11638201', N'15', N' ', N'15', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'162554
', N'575532', N'stavešinci15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141431, N'HS', N'11638210', N'16', N' ', N'16', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'162295
', N'575663', N'stavešinci16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141432, N'HS', N'11638228', N'17', N' ', N'17', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'162298
', N'575621', N'stavešinci17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141433, N'HS', N'11638236', N'1', N' ', N'1', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'165135
', N'575782', N'stavešinskivrh1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141434, N'HS', N'11638244', N'2', N' ', N'2', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'165153
', N'576088', N'stavešinskivrh2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141435, N'HS', N'11638279', N'3', N' ', N'3', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'165117
', N'576115', N'stavešinskivrh3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141436, N'HS', N'11638252', N'3', N'A', N'3A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'165084
', N'576154', N'stavešinskivrh3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141437, N'HS', N'11638309', N'6', N' ', N'6', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164973
', N'576160', N'stavešinskivrh6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141438, N'HS', N'11638333', N'9', N' ', N'9', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164801
', N'576151', N'stavešinskivrh9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141439, N'HS', N'11638350', N'11', N' ', N'11', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164760
', N'575987', N'stavešinskivrh11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141440, N'HS', N'11643442', N'7', N' ', N'7', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167707
', N'575208', N'zbigovci7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141441, N'HS', N'11643477', N'9', N' ', N'9', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167575
', N'575184', N'zbigovci9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141442, N'HS', N'11643485', N'10', N' ', N'10', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167863
', N'575314', N'zbigovci10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141443, N'HS', N'11643493', N'11', N' ', N'11', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167547
', N'575101', N'zbigovci11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141444, N'HS', N'11643515', N'13', N' ', N'13', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167078
', N'575091', N'zbigovci13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141445, N'HS', N'11643531', N'15', N' ', N'15', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167323
', N'575117', N'zbigovci15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141446, N'HS', N'11643540', N'16', N' ', N'16', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167319
', N'575153', N'zbigovci16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141447, N'HS', N'11643558', N'17', N'A', N'17A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167316
', N'574967', N'zbigovci17a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141448, N'HS', N'11643582', N'19', N' ', N'19', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167419
', N'574897', N'zbigovci19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141449, N'HS', N'19130878', N'151', N'A', N'151A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168496
', N'575974', N'črešnjevci151a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141450, N'HS', N'11579426', N'8', N' ', N'8', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168334
', N'572997', N'aženskivrh8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141451, N'HS', N'11579434', N'9', N' ', N'9', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168337
', N'572952', N'aženskivrh9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141452, N'HS', N'11579442', N'10', N' ', N'10', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168135
', N'572957', N'aženskivrh10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141453, N'HS', N'11579477', N'11', N' ', N'11', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168076
', N'572925', N'aženskivrh11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141454, N'HS', N'11579469', N'11', N'A', N'11A', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168029
', N'572880', N'aženskivrh11a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141455, N'HS', N'11579485', N'12', N' ', N'12', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'167908
', N'572934', N'aženskivrh12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141456, N'HS', N'11579493', N'13', N' ', N'13', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'167788
', N'572921', N'aženskivrh13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141457, N'HS', N'11579507', N'14', N' ', N'14', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'167877
', N'573071', N'aženskivrh14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141458, N'HS', N'11579523', N'16', N' ', N'16', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168054
', N'572638', N'aženskivrh16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141459, N'HS', N'11579531', N'17', N' ', N'17', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168028
', N'572498', N'aženskivrh17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141460, N'HS', N'11579540', N'18', N' ', N'18', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'167880
', N'572590', N'aženskivrh18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141461, N'HS', N'11579558', N'19', N' ', N'19', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168069
', N'572417', N'aženskivrh19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141462, N'HS', N'11579574', N'21', N' ', N'21', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168231
', N'572724', N'aženskivrh21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141463, N'HS', N'11592694', N'3', N' ', N'3', N'16185124', N'10092752', N'11026826', N'21429392', N'10252768', N'170957
', N'576358', N'mladinskaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141464, N'HS', N'11592724', N'8', N' ', N'8', N'16185124', N'10092752', N'11026826', N'21429392', N'10253055', N'170800
', N'576348', N'mladinskaulica8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141465, N'HS', N'11592759', N'10', N' ', N'10', N'16185124', N'10092752', N'11026826', N'21429392', N'10253055', N'170811
', N'576359', N'mladinskaulica10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141466, N'HS', N'11592767', N'12', N' ', N'12', N'16185124', N'10092752', N'11026826', N'21429392', N'10253055', N'170822
', N'576368', N'mladinskaulica12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141467, N'HS', N'11592775', N'14', N' ', N'14', N'16185124', N'10092752', N'11026826', N'21429392', N'10253055', N'170833
', N'576396', N'mladinskaulica14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141468, N'HS', N'11638368', N'12', N' ', N'12', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164730
', N'575943', N'stavešinskivrh12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141469, N'HS', N'11638406', N'15', N' ', N'15', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164576
', N'576004', N'stavešinskivrh15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141470, N'HS', N'11638392', N'15', N'A', N'15A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164536
', N'575958', N'stavešinskivrh15a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141471, N'HS', N'11638414', N'16', N' ', N'16', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164604
', N'575922', N'stavešinskivrh16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141472, N'HS', N'11592864', N'3', N' ', N'3', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169912
', N'576749', N'obprogi3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141473, N'HS', N'11592872', N'4', N' ', N'4', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169873
', N'576773', N'obprogi4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141474, N'HS', N'11592899', N'5', N' ', N'5', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169851
', N'576785', N'obprogi5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141475, N'HS', N'11592929', N'7', N' ', N'7', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169809
', N'576846', N'obprogi7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141476, N'HS', N'11592945', N'9', N' ', N'9', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169798
', N'576819', N'obprogi9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141477, N'HS', N'11592953', N'10', N' ', N'10', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169775
', N'576847', N'obprogi10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141478, N'HS', N'11592961', N'11', N' ', N'11', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169758
', N'576875', N'obprogi11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141479, N'HS', N'11589049', N'2', N' ', N'2', N'16184853', N'10092752', N'11026826', N'21429392', N'10252636', N'170780
', N'576216', N'panonskaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141480, N'HS', N'11589057', N'3', N' ', N'3', N'16184853', N'10092752', N'11026826', N'21429392', N'10253217', N'171005
', N'576233', N'panonskaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141481, N'HS', N'11589090', N'7', N' ', N'7', N'16184853', N'10092752', N'11026826', N'21429392', N'10253268', N'171093
', N'576181', N'panonskaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141482, N'HS', N'11589103', N'8', N' ', N'8', N'16184853', N'10092752', N'11026826', N'21429392', N'10252636', N'170841
', N'576267', N'panonskaulica8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141483, N'HS', N'11589111', N'10', N' ', N'10', N'16184853', N'10092752', N'11026826', N'21429392', N'10253284', N'171038
', N'576256', N'panonskaulica10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141484, N'HS', N'11589138', N'14', N' ', N'14', N'16184853', N'10092752', N'11026826', N'21429392', N'10253284', N'171090
', N'576216', N'panonskaulica14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141485, N'HS', N'11589146', N'16', N' ', N'16', N'16184853', N'10092752', N'11026826', N'21429392', N'10253284', N'171112
', N'576201', N'panonskaulica16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141486, N'HS', N'11589154', N'18', N' ', N'18', N'16184853', N'10092752', N'11026826', N'21429392', N'10253284', N'171131
', N'576188', N'panonskaulica18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141487, N'HS', N'11589162', N'20', N' ', N'20', N'16184853', N'10092752', N'11026826', N'21429392', N'10253284', N'171148
', N'576173', N'panonskaulica20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141488, N'HS', N'11604382', N'28', N' ', N'28', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161704
', N'573239', N'kunova28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141489, N'HS', N'11604412', N'30', N' ', N'30', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162004
', N'573028', N'kunova30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141490, N'HS', N'11604439', N'31', N' ', N'31', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162032
', N'573047', N'kunova31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141491, N'HS', N'11604447', N'33', N' ', N'33', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162096
', N'573079', N'kunova33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141492, N'HS', N'11604471', N'35', N' ', N'35', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162529
', N'573295', N'kunova35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141493, N'HS', N'11604498', N'36', N' ', N'36', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162484
', N'573404', N'kunova36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141494, N'HS', N'11604501', N'37', N'A', N'37A', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162378
', N'573650', N'kunova37a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141495, N'HS', N'11604528', N'38', N' ', N'38', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162352
', N'573732', N'kunova38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141496, N'HS', N'11604544', N'40', N' ', N'40', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162297
', N'573877', N'kunova40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141497, N'HS', N'11604552', N'41', N' ', N'41', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162163
', N'573897', N'kunova41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141498, N'HS', N'11620752', N'83', N' ', N'83', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169498
', N'573606', N'police83')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141499, N'HS', N'11620779', N'84', N' ', N'84', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169515
', N'573615', N'police84')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141500, N'HS', N'11620795', N'86', N' ', N'86', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169433
', N'573792', N'police86')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141501, N'HS', N'11620817', N'88', N' ', N'88', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169439
', N'573828', N'police88')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141502, N'HS', N'11620833', N'90', N' ', N'90', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169424
', N'573980', N'police90')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141503, N'HS', N'11620841', N'91', N' ', N'91', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169475
', N'574014', N'police91')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141504, N'HS', N'11622135', N'51', N' ', N'51', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166520
', N'577220', N'ptujskacesta51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141505, N'HS', N'11622143', N'52', N' ', N'52', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166580
', N'577411', N'ptujskacesta52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141506, N'HS', N'11622160', N'53', N' ', N'53', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166656
', N'577530', N'ptujskacesta53')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141507, N'HS', N'11622151', N'53', N'A', N'53A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166665
', N'577499', N'ptujskacesta53a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141508, N'HS', N'11622186', N'55', N' ', N'55', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166850
', N'577732', N'ptujskacesta55')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141509, N'HS', N'11622208', N'56', N' ', N'56', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166977
', N'577107', N'ptujskacesta56')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141510, N'HS', N'11622194', N'56', N'A', N'56A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166953
', N'577145', N'ptujskacesta56a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141511, N'HS', N'11628940', N'1', N' ', N'1', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165412
', N'570969', N'radvenci1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141512, N'HS', N'11628966', N'2', N' ', N'2', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165454
', N'571281', N'radvenci2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141513, N'HS', N'11628974', N'3', N'A', N'3A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165581
', N'571809', N'radvenci3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141514, N'HS', N'11629008', N'4', N' ', N'4', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165477
', N'571673', N'radvenci4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141515, N'HS', N'11629059', N'9', N' ', N'9', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165222
', N'571669', N'radvenci9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141516, N'HS', N'11629067', N'10', N' ', N'10', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165256
', N'571645', N'radvenci10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141517, N'HS', N'11604579', N'42', N' ', N'42', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161784
', N'574255', N'kunova42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141518, N'HS', N'11605087', N'1', N' ', N'1', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166617
', N'573898', N'lastomerci1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141519, N'HS', N'11605095', N'2', N'A', N'2A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166537
', N'573807', N'lastomerci2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141520, N'HS', N'11605117', N'3', N' ', N'3', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166490
', N'573778', N'lastomerci3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141521, N'HS', N'11605125', N'4', N' ', N'4', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166482
', N'573760', N'lastomerci4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141522, N'HS', N'11605141', N'6', N' ', N'6', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166471
', N'573946', N'lastomerci6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141523, N'HS', N'11605168', N'9', N' ', N'9', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166346
', N'573755', N'lastomerci9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141524, N'HS', N'11605192', N'11', N' ', N'11', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166681
', N'573644', N'lastomerci11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141525, N'HS', N'11605222', N'13', N' ', N'13', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'165928
', N'572989', N'lastomerci13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141526, N'HS', N'11605214', N'13', N'A', N'13A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'165931
', N'572956', N'lastomerci13a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141527, N'HS', N'11605257', N'15', N' ', N'15', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'165863
', N'572892', N'lastomerci15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141528, N'HS', N'11605290', N'18', N' ', N'18', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'165961
', N'572494', N'lastomerci18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141529, N'HS', N'11614043', N'1', N' ', N'1', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162736
', N'576615', N'očeslavci1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141530, N'HS', N'11614051', N'2', N' ', N'2', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162680
', N'576624', N'očeslavci2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141531, N'HS', N'11614060', N'3', N' ', N'3', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162630
', N'576711', N'očeslavci3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141532, N'HS', N'11614086', N'4', N' ', N'4', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162705
', N'576756', N'očeslavci4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141533, N'HS', N'11635466', N'48', N'B', N'48B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168236
', N'572392', N'spodnjaščavnica48b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141534, N'HS', N'11635474', N'48', N'C', N'48C', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168276
', N'572450', N'spodnjaščavnica48c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141535, N'HS', N'11635504', N'49', N' ', N'49', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168469
', N'572396', N'spodnjaščavnica49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141536, N'HS', N'11635539', N'51', N' ', N'51', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167688
', N'572852', N'spodnjaščavnica51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141537, N'HS', N'11635547', N'52', N' ', N'52', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167595
', N'572774', N'spodnjaščavnica52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141538, N'HS', N'11635555', N'53', N' ', N'53', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167391
', N'572641', N'spodnjaščavnica53')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141539, N'HS', N'11635571', N'55', N' ', N'55', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167302
', N'572561', N'spodnjaščavnica55')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141540, N'HS', N'11635580', N'56', N' ', N'56', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167253
', N'572526', N'spodnjaščavnica56')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141541, N'HS', N'11635610', N'57', N' ', N'57', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167253
', N'572459', N'spodnjaščavnica57')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141542, N'HS', N'11635598', N'57', N'A', N'57A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167181
', N'572294', N'spodnjaščavnica57a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141543, N'HS', N'11635636', N'58', N' ', N'58', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167116
', N'572445', N'spodnjaščavnica58')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141544, N'HS', N'11635628', N'58', N'A', N'58A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167074
', N'572466', N'spodnjaščavnica58a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141545, N'HS', N'11635644', N'59', N' ', N'59', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167107
', N'572520', N'spodnjaščavnica59')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141546, N'HS', N'11635679', N'61', N' ', N'61', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'166794
', N'572748', N'spodnjaščavnica61')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141547, N'HS', N'11635687', N'62', N' ', N'62', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'166918
', N'572858', N'spodnjaščavnica62')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141548, N'HS', N'11635695', N'63', N' ', N'63', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'166432
', N'572544', N'spodnjaščavnica63')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141549, N'HS', N'11635709', N'64', N' ', N'64', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'166557
', N'572439', N'spodnjaščavnica64')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141550, N'HS', N'11635717', N'65', N' ', N'65', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'166855
', N'572259', N'spodnjaščavnica65')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141551, N'HS', N'11635725', N'66', N' ', N'66', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'166623
', N'572034', N'spodnjaščavnica66')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141552, N'HS', N'11635733', N'67', N' ', N'67', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'166809
', N'571845', N'spodnjaščavnica67')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141553, N'HS', N'11635741', N'68', N' ', N'68', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167177
', N'571466', N'spodnjaščavnica68')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141554, N'HS', N'11635750', N'69', N' ', N'69', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'166677
', N'571187', N'spodnjaščavnica69')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141555, N'HS', N'11635768', N'70', N' ', N'70', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167025
', N'570955', N'spodnjaščavnica70')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141556, N'HS', N'11620850', N'92', N' ', N'92', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169409
', N'574193', N'police92')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141557, N'HS', N'11620906', N'97', N' ', N'97', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169324
', N'573861', N'police97')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141558, N'HS', N'11620914', N'98', N' ', N'98', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169326
', N'573825', N'police98')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141559, N'HS', N'11620922', N'99', N' ', N'99', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169155
', N'573686', N'police99')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141560, N'HS', N'11620965', N'102', N' ', N'102', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169097
', N'573437', N'police102')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141561, N'HS', N'11620981', N'104', N' ', N'104', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169028
', N'573340', N'police104')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141562, N'HS', N'11620990', N'105', N' ', N'105', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169153
', N'574618', N'police105')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141563, N'HS', N'11621015', N'107', N' ', N'107', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169121
', N'574319', N'police107')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141564, N'HS', N'11621023', N'108', N' ', N'108', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168952
', N'574483', N'police108')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141565, N'HS', N'11621058', N'111', N' ', N'111', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169020
', N'574144', N'police111')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141566, N'HS', N'11621074', N'113', N' ', N'113', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168914
', N'574067', N'police113')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141567, N'HS', N'11621082', N'114', N' ', N'114', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168897
', N'574057', N'police114')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141568, N'HS', N'11621147', N'118', N' ', N'118', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168780
', N'573869', N'police118')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141569, N'HS', N'11621155', N'119', N' ', N'119', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169024
', N'573711', N'police119')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141570, N'HS', N'11621163', N'120', N' ', N'120', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168926
', N'573739', N'police120')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141571, N'HS', N'11621171', N'121', N' ', N'121', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168782
', N'573624', N'police121')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141572, N'HS', N'11629121', N'16', N' ', N'16', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164901
', N'571963', N'radvenci16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141573, N'HS', N'11629148', N'17', N' ', N'17', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165381
', N'572030', N'radvenci17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141574, N'HS', N'11629156', N'18', N' ', N'18', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165539
', N'572048', N'radvenci18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141575, N'HS', N'11629164', N'19', N' ', N'19', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165352
', N'572169', N'radvenci19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141576, N'HS', N'11629199', N'21', N' ', N'21', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165161
', N'572326', N'radvenci21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141577, N'HS', N'11629202', N'22', N' ', N'22', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165105
', N'572378', N'radvenci22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141578, N'HS', N'11629245', N'26', N' ', N'26', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165101
', N'572472', N'radvenci26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141579, N'HS', N'11629253', N'27', N' ', N'27', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165227
', N'572491', N'radvenci27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141580, N'HS', N'11643655', N'21', N' ', N'21', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167667
', N'574848', N'zbigovci21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141581, N'HS', N'11643698', N'24', N' ', N'24', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167783
', N'574755', N'zbigovci24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141582, N'HS', N'11643701', N'26', N' ', N'26', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167413
', N'574714', N'zbigovci26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141583, N'HS', N'11643728', N'28', N' ', N'28', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167215
', N'574693', N'zbigovci28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141584, N'HS', N'11643736', N'29', N' ', N'29', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167452
', N'574651', N'zbigovci29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141585, N'HS', N'11643744', N'30', N' ', N'30', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167286
', N'574430', N'zbigovci30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141586, N'HS', N'11643752', N'31', N' ', N'31', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167337
', N'574414', N'zbigovci31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141587, N'HS', N'11643787', N'33', N' ', N'33', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167174
', N'574260', N'zbigovci33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141588, N'HS', N'11643809', N'35', N' ', N'35', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167029
', N'574216', N'zbigovci35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141589, N'HS', N'11643817', N'36', N' ', N'36', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167047
', N'574199', N'zbigovci36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141590, N'HS', N'11643825', N'37', N' ', N'37', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166892
', N'574329', N'zbigovci37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141591, N'HS', N'11614094', N'5', N' ', N'5', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162603
', N'576750', N'očeslavci5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141592, N'HS', N'11614116', N'7', N' ', N'7', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162552
', N'576832', N'očeslavci7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141593, N'HS', N'11614132', N'8', N' ', N'8', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162551
', N'576887', N'očeslavci8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141594, N'HS', N'11614124', N'8', N'A', N'8A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162585
', N'576897', N'očeslavci8a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141595, N'HS', N'11614175', N'9', N' ', N'9', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162554
', N'576912', N'očeslavci9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141596, N'HS', N'11614167', N'9', N'B', N'9B', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162556
', N'576932', N'očeslavci9b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141597, N'HS', N'11614191', N'11', N' ', N'11', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162646
', N'577056', N'očeslavci11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141598, N'HS', N'11614221', N'12', N' ', N'12', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162690
', N'577123', N'očeslavci12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141599, N'HS', N'11614230', N'13', N' ', N'13', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162834
', N'576966', N'očeslavci13')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141600, N'HS', N'11614256', N'15', N' ', N'15', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163124
', N'577294', N'očeslavci15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141601, N'HS', N'11614264', N'16', N' ', N'16', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163037
', N'577533', N'očeslavci16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141602, N'HS', N'11614302', N'19', N' ', N'19', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162726
', N'577440', N'očeslavci19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141603, N'HS', N'11614345', N'22', N' ', N'22', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162111
', N'577551', N'očeslavci22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141604, N'HS', N'11614353', N'23', N' ', N'23', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162396
', N'577790', N'očeslavci23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141605, N'HS', N'11614388', N'26', N' ', N'26', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162596
', N'577722', N'očeslavci26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141606, N'HS', N'11635806', N'73', N' ', N'73', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167634
', N'571158', N'spodnjaščavnica73')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141607, N'HS', N'11635822', N'74', N' ', N'74', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167680
', N'571059', N'spodnjaščavnica74')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141608, N'HS', N'11635857', N'76', N' ', N'76', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167684
', N'570954', N'spodnjaščavnica76')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141609, N'HS', N'11635881', N'80', N' ', N'80', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167809
', N'570687', N'spodnjaščavnica80')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141610, N'HS', N'11635890', N'81', N'A', N'81A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167918
', N'570553', N'spodnjaščavnica81a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141611, N'HS', N'11635920', N'82', N' ', N'82', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168199
', N'570242', N'spodnjaščavnica82')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141612, N'HS', N'11638422', N'17', N' ', N'17', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164636
', N'575889', N'stavešinskivrh17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141613, N'HS', N'11638449', N'18', N' ', N'18', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164611
', N'575874', N'stavešinskivrh18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141614, N'HS', N'11638457', N'19', N' ', N'19', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164535
', N'575826', N'stavešinskivrh19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141615, N'HS', N'11638481', N'20', N' ', N'20', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164535
', N'575809', N'stavešinskivrh20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141616, N'HS', N'11638490', N'21', N' ', N'21', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164340
', N'575710', N'stavešinskivrh21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141617, N'HS', N'11638503', N'22', N' ', N'22', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164242
', N'575667', N'stavešinskivrh22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141618, N'HS', N'11638520', N'24', N' ', N'24', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164460
', N'575874', N'stavešinskivrh24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141619, N'HS', N'11638538', N'25', N' ', N'25', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164431
', N'575920', N'stavešinskivrh25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141620, N'HS', N'11638554', N'27', N' ', N'27', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164364
', N'575945', N'stavešinskivrh27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141621, N'HS', N'11638562', N'28', N' ', N'28', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164366
', N'576457', N'stavešinskivrh28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141622, N'HS', N'11638589', N'29', N' ', N'29', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164060
', N'576558', N'stavešinskivrh29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141623, N'HS', N'11638619', N'30', N' ', N'30', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164056
', N'576132', N'stavešinskivrh30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141624, N'HS', N'11638635', N'31', N' ', N'31', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164166
', N'576212', N'stavešinskivrh31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141625, N'HS', N'11638651', N'34', N' ', N'34', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164220
', N'575994', N'stavešinskivrh34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141626, N'HS', N'11638660', N'35', N' ', N'35', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164172
', N'575971', N'stavešinskivrh35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141627, N'HS', N'11638678', N'36', N'A', N'36A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164088
', N'575952', N'stavešinskivrh36a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141628, N'HS', N'11638724', N'39', N' ', N'39', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164010
', N'575969', N'stavešinskivrh39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141629, N'HS', N'11638759', N'40', N' ', N'40', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163993
', N'575932', N'stavešinskivrh40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141630, N'HS', N'11643833', N'38', N' ', N'38', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166991
', N'574179', N'zbigovci38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141631, N'HS', N'11643850', N'39', N' ', N'39', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166957
', N'574151', N'zbigovci39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141632, N'HS', N'11643876', N'40', N' ', N'40', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166841
', N'574183', N'zbigovci40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141633, N'HS', N'11643884', N'43', N' ', N'43', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166748
', N'574100', N'zbigovci43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141634, N'HS', N'11643892', N'44', N' ', N'44', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166857
', N'574079', N'zbigovci44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141635, N'HS', N'11643906', N'45', N' ', N'45', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166842
', N'574035', N'zbigovci45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141636, N'HS', N'11643914', N'46', N' ', N'46', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166721
', N'574106', N'zbigovci46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141637, N'HS', N'11643922', N'48', N'A', N'48A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166614
', N'573926', N'zbigovci48a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141638, N'HS', N'11643957', N'49', N' ', N'49', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166577
', N'574035', N'zbigovci49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141639, N'HS', N'11643965', N'50', N' ', N'50', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'166595
', N'573510', N'zbigovci50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141640, N'HS', N'11643973', N'51', N' ', N'51', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'166622
', N'573462', N'zbigovci51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141641, N'HS', N'11643981', N'52', N' ', N'52', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'166721
', N'573501', N'zbigovci52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141642, N'HS', N'11643990', N'53', N' ', N'53', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'166819
', N'573533', N'zbigovci53')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141643, N'HS', N'11644007', N'54', N' ', N'54', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'166871
', N'573591', N'zbigovci54')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141644, N'HS', N'11644023', N'56', N' ', N'56', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167005
', N'573615', N'zbigovci56')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141645, N'HS', N'11644031', N'57', N' ', N'57', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'166993
', N'573577', N'zbigovci57')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141646, N'HS', N'11644040', N'58', N' ', N'58', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167081
', N'573643', N'zbigovci58')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141647, N'HS', N'11638783', N'43', N' ', N'43', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163892
', N'575811', N'stavešinskivrh43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141648, N'HS', N'11638791', N'44', N' ', N'44', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163739
', N'575779', N'stavešinskivrh44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141649, N'HS', N'11638805', N'45', N' ', N'45', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163700
', N'575759', N'stavešinskivrh45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141650, N'HS', N'11638813', N'46', N'A', N'46A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163683
', N'575637', N'stavešinskivrh46a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141651, N'HS', N'11638830', N'47', N' ', N'47', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163681
', N'575487', N'stavešinskivrh47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141652, N'HS', N'11638848', N'48', N' ', N'48', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163420
', N'575669', N'stavešinskivrh48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141653, N'HS', N'11638856', N'49', N' ', N'49', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163757
', N'576015', N'stavešinskivrh49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141654, N'HS', N'11629318', N'33', N' ', N'33', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164602
', N'573213', N'radvenci33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141655, N'HS', N'11629326', N'34', N' ', N'34', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164634
', N'573299', N'radvenci34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141656, N'HS', N'11629369', N'37', N' ', N'37', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164027
', N'573489', N'radvenci37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141657, N'HS', N'11629385', N'39', N' ', N'39', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164472
', N'572542', N'radvenci39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141658, N'HS', N'11629393', N'40', N' ', N'40', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164454
', N'572498', N'radvenci40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141659, N'HS', N'11629407', N'41', N' ', N'41', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164504
', N'572376', N'radvenci41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141660, N'HS', N'11629415', N'42', N' ', N'42', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164672
', N'571936', N'radvenci42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141661, N'HS', N'11629423', N'45', N' ', N'45', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164301
', N'572349', N'radvenci45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141662, N'HS', N'11629431', N'46', N' ', N'46', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164180
', N'572418', N'radvenci46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141663, N'HS', N'11629440', N'47', N' ', N'47', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164093
', N'572483', N'radvenci47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141664, N'HS', N'11629458', N'48', N' ', N'48', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164015
', N'572513', N'radvenci48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141665, N'HS', N'11629822', N'1', N' ', N'1', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166979
', N'575130', N'rodmošci1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141666, N'HS', N'11629857', N'3', N' ', N'3', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166988
', N'574960', N'rodmošci3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141667, N'HS', N'11592171', N'7', N' ', N'7', N'16185035', N'10092752', N'11026826', N'21429392', N'10252687', N'171120
', N'575328', N'gasilskacesta7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141668, N'HS', N'16391212', N'60', N'A', N'60A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168959
', N'576396', N'črešnjevci60a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141669, N'HS', N'11584365', N'229', N' ', N'229', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169270
', N'575717', N'črešnjevci229')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141670, N'HS', N'16354902', N'76', N'A', N'76A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168662
', N'576130', N'črešnjevci76a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141671, N'HS', N'19124789', N'76', N'B', N'76B', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168646
', N'576150', N'črešnjevci76b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141672, N'HS', N'11582672', N'73', N' ', N'73', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168639
', N'576225', N'črešnjevci73')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141673, N'HS', N'16171280', N'31', N'A', N'31A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164929
', N'570101', N'lokavci31a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141674, N'HS', N'19118495', N'41', N'A', N'41A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166801
', N'569176', N'zagajskivrh41a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141675, N'HS', N'19118681', N'20', N'A', N'20A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170586
', N'575566', N'hercegovščak20a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141676, N'HS', N'19118690', N'26', N'A', N'26A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168389
', N'571922', N'spodnjaščavnica26a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141677, N'HS', N'16354821', N'62', N'A', N'62A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168921
', N'576386', N'črešnjevci62a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141678, N'HS', N'11584292', N'224', N'A', N'224A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169118
', N'575483', N'črešnjevci224a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141679, N'HS', N'19131203', N'71', N'A', N'71A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169132
', N'573193', N'police71a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141680, N'HS', N'11620647', N'72', N' ', N'72', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169209
', N'573266', N'police72')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141681, N'HS', N'11620957', N'101', N' ', N'101', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169133
', N'573439', N'police101')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141682, N'HS', N'11588603', N'12', N' ', N'12', N'16184829', N'10092752', N'11026826', N'21429392', N'10257204', N'170029
', N'576588', N'ljutomerskacesta12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141683, N'HS', N'19131106', N'11', N' ', N'11', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168892
', N'578417', N'mele11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141684, N'HS', N'19126803', N'12', N'C', N'12C', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170231
', N'573307', N'lomanoše12c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141685, N'HS', N'11614248', N'14', N' ', N'14', N'16276049', N'10093171', N'11026826', N'21431745', N'19127222', N'163972
', N'576943', N'očeslavci14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141686, N'HS', N'11605303', N'19', N' ', N'19', N'16275875', N'10093007', N'11026826', N'21432237', N'19127281', N'165666
', N'572298', N'lastomerci19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141687, N'HS', N'19124762', N'19', N'A', N'19A', N'16275875', N'10093007', N'11026826', N'21432237', N'19127281', N'165659
', N'572328', N'lastomerci19a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141688, N'HS', N'11620663', N'74', N' ', N'74', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169285
', N'573364', N'police74')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141689, N'HS', N'11620671', N'75', N' ', N'75', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169253
', N'573361', N'police75')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141690, N'HS', N'19125726', N'72', N' ', N'72', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168667
', N'576268', N'črešnjevci72')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141691, N'HS', N'19126021', N'1', N'A', N'1A', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169545
', N'571795', N'plitvičkivrh1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141692, N'HS', N'19134954', N'33', N'A', N'33A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162952
', N'577637', N'očeslavci33a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141693, N'HS', N'11599117', N'34', N' ', N'34', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165455
', N'574237', N'ivanjševskivrh34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141694, N'HS', N'19134261', N'31', N'C', N'31C', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165179
', N'573981', N'ivanjševskivrh31c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141695, N'HS', N'11616135', N'8', N' ', N'8', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166373
', N'575507', N'orehovskivrh8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141696, N'HS', N'19134750', N'36', N'A', N'36A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168703
', N'578248', N'mele36a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141697, N'HS', N'19133451', N'37', N'B', N'37B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167880
', N'571706', N'spodnjaščavnica37b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141698, N'HS', N'19127940', N'62', N'A', N'62A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167146
', N'573671', N'zbigovci62a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141699, N'HS', N'19118169', N'42', N'D', N'42D', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165417
', N'574632', N'ivanjševskivrh42d')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141700, N'HS', N'19134407', N'4', N'A', N'4A', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170506
', N'575964', N'prežihovaulica4a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141701, N'HS', N'19128075', N'12', N'U', N'12U', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170949
', N'576173', N'trgsvobode12u')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141702, N'HS', N'19128083', N'12', N'T', N'12T', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170941
', N'576178', N'trgsvobode12t')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141703, N'HS', N'19129721', N'28', N'F', N'28F', N'16184829', N'10092752', N'11026826', N'21429392', N'10256852', N'169266
', N'577244', N'ljutomerskacesta28f')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141704, N'HS', N'19129896', N'28', N'J', N'28J', N'16184829', N'10092752', N'11026826', N'21429392', N'10256852', N'169156
', N'577453', N'ljutomerskacesta28j')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141705, N'HS', N'11594298', N'20', N' ', N'20', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'162809
', N'574717', N'gornjiivanjci20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141706, N'HS', N'11643175', N'32', N' ', N'32', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167152
', N'569208', N'zagajskivrh32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141707, N'HS', N'11618367', N'67', N' ', N'67', N'16276103', N'10093236', N'11026826', N'21428353', N'19135012', N'169104
', N'569496', N'plitvičkivrh67')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141708, N'HS', N'11590730', N'5', N' ', N'5', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171043
', N'575959', N'šlebingerjevbreg5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141709, N'HS', N'19131157', N'15', N' ', N'15', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170830
', N'575827', N'simoničevbreg15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141710, N'HS', N'19130339', N'27', N' ', N'27', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165212
', N'574241', N'ivanjševskivrh27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141711, N'HS', N'19134270', N'100', N'A', N'100A', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168687
', N'576467', N'črešnjevci100a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141712, N'HS', N'19131297', N'30', N'B', N'30B', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168737
', N'578299', N'mele30b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141713, N'HS', N'11606164', N'9', N'A', N'9A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164364
', N'572247', N'lokavci9a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141714, N'HS', N'19134474', N'37', N'A', N'37A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169006
', N'576224', N'črešnjevci37a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141715, N'HS', N'19129802', N'4', N'A', N'4A', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169855
', N'576763', N'obprogi4a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141716, N'HS', N'11598200', N'2', N' ', N'2', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161056
', N'574495', N'ivanjskivrh2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141717, N'HS', N'11598234', N'4', N' ', N'4', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160961
', N'574562', N'ivanjskivrh4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141718, N'HS', N'19130053', N'41', N'A', N'41A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170472
', N'574084', N'hercegovščak41a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141719, N'HS', N'19130274', N'28', N'A', N'28A', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169864
', N'575758', N'noričkivrh28a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141720, N'HS', N'11636748', N'28', N' ', N'28', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161385
', N'575995', N'spodnjiivanjci28')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141721, N'HS', N'11636608', N'16', N' ', N'16', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161383
', N'575553', N'spodnjiivanjci16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141722, N'HS', N'11630049', N'20', N' ', N'20', N'16276227', N'10093350', N'11026826', N'21432237', N'19127338', N'165354
', N'573211', N'rodmošci20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141723, N'HS', N'11630057', N'21', N' ', N'21', N'16276227', N'10093350', N'11026826', N'21432237', N'19127338', N'165451
', N'573481', N'rodmošci21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141724, N'HS', N'11630065', N'22', N' ', N'22', N'16276227', N'10093350', N'11026826', N'21432237', N'19127338', N'165315
', N'573608', N'rodmošci22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141725, N'HS', N'11634737', N'1', N' ', N'1', N'16276286', N'10093414', N'11026826', N'21428353', N'19127419', N'168986
', N'568606', N'spodnjaščavnica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141726, N'HS', N'11618391', N'70', N' ', N'70', N'16276103', N'10093236', N'11026826', N'21428353', N'19127451', N'169146
', N'569386', N'plitvičkivrh70')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141727, N'HS', N'11618405', N'71', N' ', N'71', N'16276103', N'10093236', N'11026826', N'21428353', N'19127451', N'169140
', N'569367', N'plitvičkivrh71')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141728, N'HS', N'11618413', N'72', N' ', N'72', N'16276103', N'10093236', N'11026826', N'21428353', N'19127451', N'169154
', N'569347', N'plitvičkivrh72')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141729, N'HS', N'11618421', N'73', N' ', N'73', N'16276103', N'10093236', N'11026826', N'21428353', N'19127451', N'169172
', N'569317', N'plitvičkivrh73')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141730, N'HS', N'19129411', N'2', N' ', N'2', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'169116
', N'578168', N'mele2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141731, N'HS', N'19130070', N'42', N'A', N'42A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163558
', N'577654', N'očeslavci42a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141732, N'HS', N'19130100', N'14', N' ', N'14', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169590
', N'576261', N'kajuhovaulica14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141733, N'HS', N'19126374', N'100', N'A', N'100A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169143
', N'573571', N'police100a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141734, N'HS', N'19126382', N'48', N'A', N'48A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162689
', N'571436', N'negova48a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141735, N'HS', N'19126366', N'51', N'A', N'51A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168985
', N'576457', N'črešnjevci51a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141736, N'HS', N'19126439', N'15', N'A', N'15A', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166931
', N'575274', N'orehovskivrh15a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141737, N'HS', N'19130126', N'44', N' ', N'44', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164315
', N'572340', N'radvenci44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141738, N'HS', N'11636578', N'14', N' ', N'14', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161529
', N'575588', N'spodnjiivanjci14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141739, N'HS', N'11605320', N'21', N' ', N'21', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166822
', N'572961', N'lastomerci21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141740, N'HS', N'11605311', N'20', N' ', N'20', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166541
', N'572946', N'lastomerci20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141741, N'HS', N'19126447', N'20', N'A', N'20A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166224
', N'572551', N'lastomerci20a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141742, N'HS', N'11621651', N'19', N' ', N'19', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166247
', N'576264', N'ptujskacesta19')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141743, N'HS', N'19133915', N'74', N'I', N'74I', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167755
', N'570859', N'spodnjaščavnica74i')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141744, N'HS', N'19134679', N'4', N'B', N'4B', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170480
', N'575951', N'prežihovaulica4b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141745, N'HS', N'19122158', N'37', N'A', N'37A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164050
', N'573485', N'radvenci37a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141746, N'HS', N'11629377', N'38', N' ', N'38', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164168
', N'573040', N'radvenci38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141747, N'HS', N'19137368', N'35', N'A', N'35A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169067
', N'576205', N'črešnjevci35a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141748, N'HS', N'11589898', N'49', N' ', N'49', N'16184861', N'10092752', N'11026826', N'21429392', N'10253063', N'170337
', N'576448', N'partizanskacesta49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141749, N'HS', N'19134695', N'38', N'A', N'38A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167755
', N'571788', N'spodnjaščavnica38a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141750, N'HS', N'11614329', N'20', N' ', N'20', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162593
', N'577472', N'očeslavci20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141751, N'HS', N'11638996', N'57', N' ', N'57', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163699
', N'576495', N'stavešinskivrh57')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141752, N'HS', N'19137252', N'5', N' ', N'5', N'16185132', N'10092752', N'11026826', N'21429392', N'10253098', N'169657
', N'576436', N'obpotoku5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141753, N'HS', N'19134920', N'43', N'D', N'43D', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166806
', N'568820', N'zagajskivrh43d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141754, N'HS', N'11618308', N'61', N' ', N'61', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169191
', N'570190', N'plitvičkivrh61')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141755, N'HS', N'11620701', N'78', N' ', N'78', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169290
', N'573425', N'police78')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141756, N'HS', N'19137244', N'45', N'C', N'45C', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165350
', N'574774', N'ivanjševskivrh45c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141757, N'HS', N'16391034', N'15', N' ', N'15', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170922
', N'576104', N'trgsvobode15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141758, N'HS', N'16391131', N'12', N'A', N'12A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'165578
', N'573156', N'lastomerci12a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141759, N'HS', N'11643337', N'43', N' ', N'43', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166846
', N'569003', N'zagajskivrh43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141760, N'HS', N'19133435', N'30', N'C', N'30C', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169385
', N'577339', N'ljutomerskacesta30c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141761, N'HS', N'11606474', N'32', N' ', N'32', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164942
', N'569990', N'lokavci32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141762, N'HS', N'19132099', N'1', N' ', N'1', N'16185132', N'10092752', N'11026826', N'21429392', N'19132706', N'169619
', N'576409', N'obpotoku1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141763, N'HS', N'11619550', N'54', N' ', N'54', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171314
', N'573576', N'podgrad54')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141764, N'HS', N'19126293', N'151', N' ', N'151', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168495
', N'576003', N'črešnjevci151')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141765, N'HS', N'16551244', N'113', N'B', N'113B', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163574
', N'570950', N'negova113b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141766, N'HS', N'19127885', N'29', N'B', N'29B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165252
', N'574024', N'ivanjševskivrh29b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141767, N'HS', N'19127915', N'36', N'B', N'36B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167850
', N'571774', N'spodnjaščavnica36b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141768, N'HS', N'19126153', N'96', N'A', N'96A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169326
', N'573898', N'police96a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141769, N'HS', N'19127842', N'42', N'C', N'42C', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165452
', N'574681', N'ivanjševskivrh42c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141770, N'HS', N'19128008', N'25', N'A', N'25A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162517
', N'577886', N'očeslavci25a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141771, N'HS', N'19127958', N'28', N'A', N'28A', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169610
', N'577023', N'ljutomerskacesta28a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141772, N'HS', N'11596398', N'44', N' ', N'44', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170572
', N'574276', N'hercegovščak44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141773, N'HS', N'11630006', N'17', N' ', N'17', N'16276227', N'10093350', N'11026826', N'21429392', N'19128130', N'165879
', N'573809', N'rodmošci17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141774, N'HS', N'11592406', N'1', N' ', N'1', N'16185086', N'10092752', N'11026826', N'21429392', N'10253047', N'170945
', N'576527', N'kocljevaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141775, N'HS', N'11592422', N'3', N' ', N'3', N'16185086', N'10092752', N'11026826', N'21429392', N'10253047', N'170959
', N'576536', N'kocljevaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141776, N'HS', N'11592457', N'5', N' ', N'5', N'16185086', N'10092752', N'11026826', N'21429392', N'10253047', N'170971
', N'576546', N'kocljevaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141777, N'HS', N'11592473', N'9', N' ', N'9', N'16185086', N'10092752', N'11026826', N'21429392', N'10253047', N'170996
', N'576526', N'kocljevaulica9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141778, N'HS', N'11592481', N'11', N' ', N'11', N'16185086', N'10092752', N'11026826', N'21429392', N'10253047', N'171008
', N'576509', N'kocljevaulica11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141779, N'HS', N'11592490', N'13', N' ', N'13', N'16185086', N'10092752', N'11026826', N'21429392', N'10253047', N'171003
', N'576490', N'kocljevaulica13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141780, N'HS', N'19117936', N'29', N'A', N'29A', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169378
', N'577636', N'ljutomerskacesta29a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141781, N'HS', N'11592783', N'16', N' ', N'16', N'16185124', N'10092752', N'11026826', N'21429392', N'10253055', N'170827
', N'576416', N'mladinskaulica16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141782, N'HS', N'19127826', N'7', N'A', N'7A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163098
', N'572240', N'negova7a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141783, N'HS', N'11592791', N'18', N' ', N'18', N'16185124', N'10092752', N'11026826', N'21429392', N'10253055', N'170816
', N'576432', N'mladinskaulica18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141784, N'HS', N'11588786', N'34', N' ', N'34', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169270
', N'577626', N'ljutomerskacesta34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141785, N'HS', N'11642861', N'7', N' ', N'7', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166550
', N'569800', N'zagajskivrh7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141786, N'HS', N'11642918', N'11', N' ', N'11', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166837
', N'569722', N'zagajskivrh11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141787, N'HS', N'11642985', N'17', N' ', N'17', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167092
', N'569661', N'zagajskivrh17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141788, N'HS', N'11643027', N'21', N'A', N'21A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'167238
', N'569494', N'zagajskivrh21a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141789, N'HS', N'11635776', N'71', N' ', N'71', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167402
', N'571431', N'spodnjaščavnica71')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141790, N'HS', N'11635849', N'75', N' ', N'75', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167654
', N'571047', N'spodnjaščavnica75')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141791, N'HS', N'11635911', N'81', N' ', N'81', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167930
', N'570528', N'spodnjaščavnica81')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141792, N'HS', N'11589391', N'5', N' ', N'5', N'16184861', N'10092752', N'11026826', N'21429392', N'10253268', N'170947
', N'576080', N'partizanskacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141793, N'HS', N'11621686', N'21', N' ', N'21', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166324
', N'576304', N'ptujskacesta21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141794, N'HS', N'11643221', N'36', N' ', N'36', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166955
', N'569255', N'zagajskivrh36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141795, N'HS', N'11643418', N'3', N' ', N'3', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167914
', N'575313', N'zbigovci3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141796, N'HS', N'19138437', N'14', N'A', N'14A', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'166717
', N'576498', N'orehovci14a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141797, N'HS', N'11622119', N'50', N'A', N'50A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166566
', N'577242', N'ptujskacesta50a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141798, N'HS', N'11629288', N'30', N' ', N'30', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165070
', N'572681', N'radvenci30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141799, N'HS', N'11643710', N'27', N' ', N'27', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167459
', N'574703', N'zbigovci27')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141800, N'HS', N'11636411', N'4', N' ', N'4', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161983
', N'575302', N'spodnjiivanjci4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141801, N'HS', N'11636462', N'7', N' ', N'7', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161822
', N'575571', N'spodnjiivanjci7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141802, N'HS', N'11636535', N'11', N' ', N'11', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'161666
', N'575532', N'spodnjiivanjci11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141803, N'HS', N'11638341', N'10', N' ', N'10', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164789
', N'576011', N'stavešinskivrh10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141804, N'HS', N'11638384', N'14', N' ', N'14', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164675
', N'575901', N'stavešinskivrh14')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141805, N'HS', N'11638708', N'38', N' ', N'38', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164029
', N'575945', N'stavešinskivrh38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141806, N'HS', N'11638767', N'41', N' ', N'41', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163929
', N'575935', N'stavešinskivrh41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141807, N'HS', N'19136353', N'34', N'B', N'34B', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163101
', N'577735', N'očeslavci34b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141808, N'HS', N'11593097', N'3', N' ', N'3', N'16185183', N'10092752', N'11026826', N'21429392', N'10253047', N'170943
', N'576508', N'porabskaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141809, N'HS', N'11592465', N'7', N' ', N'7', N'16185086', N'10092752', N'11026826', N'21429392', N'10253047', N'170986
', N'576542', N'kocljevaulica7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141810, N'HS', N'19123294', N'88', N'A', N'88A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168612
', N'576334', N'črešnjevci88a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141811, N'HS', N'11615830', N'1', N' ', N'1', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167110
', N'577233', N'orehovci1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141812, N'HS', N'11615929', N'6', N' ', N'6', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167282
', N'576970', N'orehovci6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141813, N'HS', N'11615953', N'9', N' ', N'9', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167060
', N'576536', N'orehovci9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141814, N'HS', N'11581994', N'3', N' ', N'3', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169335
', N'576536', N'črešnjevci3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141815, N'HS', N'11616194', N'13', N' ', N'13', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166784
', N'575330', N'orehovskivrh13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141816, N'HS', N'11616232', N'17', N' ', N'17', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'166973
', N'575419', N'orehovskivrh17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141817, N'HS', N'11616291', N'22', N' ', N'22', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167423
', N'575616', N'orehovskivrh22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141818, N'HS', N'11589685', N'31', N' ', N'31', N'16184861', N'10092752', N'11026826', N'21429392', N'10253241', N'170641
', N'576322', N'partizanskacesta31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141819, N'HS', N'11592996', N'2', N' ', N'2', N'16185167', N'10092752', N'11026826', N'21429392', N'10252652', N'170387
', N'575933', N'podgozdom2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141820, N'HS', N'11590071', N'4', N' ', N'4', N'16184888', N'10092752', N'11026826', N'21429392', N'10252679', N'170885
', N'576045', N'pokopališkacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141821, N'HS', N'11616496', N'41', N' ', N'41', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167424
', N'576333', N'orehovskivrh41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141822, N'HS', N'11612881', N'87', N' ', N'87', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163089
', N'570463', N'negova87')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141823, N'HS', N'11582320', N'35', N' ', N'35', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169095
', N'576189', N'črešnjevci35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141824, N'HS', N'11582362', N'39', N' ', N'39', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168927
', N'576253', N'črešnjevci39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141825, N'HS', N'11589227', N'25', N' ', N'25', N'16184853', N'10092752', N'11026826', N'21429392', N'10253268', N'171165
', N'576129', N'panonskaulica25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141826, N'HS', N'11589260', N'29', N' ', N'29', N'16184853', N'10092752', N'11026826', N'21429392', N'10253268', N'171249
', N'576058', N'panonskaulica29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141827, N'HS', N'11589316', N'34', N' ', N'34', N'16184853', N'10092752', N'11026826', N'21429392', N'10253276', N'171300
', N'576074', N'panonskaulica34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141828, N'HS', N'11589367', N'2', N' ', N'2', N'16184861', N'10092752', N'11026826', N'21429392', N'10252679', N'170927
', N'576064', N'partizanskacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141829, N'HS', N'11589413', N'7', N' ', N'7', N'16184861', N'10092752', N'11026826', N'21429392', N'10253268', N'170943
', N'576083', N'partizanskacesta7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141830, N'HS', N'11605435', N'28', N'A', N'28A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166710
', N'573371', N'lastomerci28a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141831, N'HS', N'11592147', N'4', N' ', N'4', N'16185035', N'10092752', N'11026826', N'21429392', N'10252628', N'171103
', N'575201', N'gasilskacesta4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141832, N'HS', N'19129934', N'16', N'D', N'16D', N'16184934', N'10092752', N'11026826', N'21429392', N'10253217', N'170958
', N'576127', N'trgsvobode16d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141833, N'HS', N'11644279', N'76', N' ', N'76', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167857
', N'574412', N'zbigovci76')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141834, N'HS', N'11583024', N'107', N' ', N'107', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168505
', N'576526', N'črešnjevci107')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141835, N'HS', N'11583075', N'111', N' ', N'111', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168374
', N'576503', N'črešnjevci111')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141836, N'HS', N'11593054', N'6', N' ', N'6', N'16185175', N'10092752', N'11026826', N'21429392', N'10253101', N'169713
', N'576172', N'poličkacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141837, N'HS', N'11593127', N'6', N' ', N'6', N'16185183', N'10092752', N'11026826', N'21429392', N'10252768', N'170951
', N'576413', N'porabskaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141838, N'HS', N'11593186', N'3', N' ', N'3', N'16185191', N'10092752', N'11026826', N'21429392', N'10253071', N'169878
', N'576321', N'prečnaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141839, N'HS', N'11590136', N'2', N' ', N'2', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170754
', N'576166', N'prešernovacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141840, N'HS', N'11590195', N'7', N' ', N'7', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170712
', N'576195', N'prešernovacesta7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141841, N'HS', N'11590233', N'11', N' ', N'11', N'16184896', N'10092752', N'11026826', N'21429392', N'10252636', N'170670
', N'576173', N'prešernovacesta11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141842, N'HS', N'11590284', N'16', N' ', N'16', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170594
', N'576233', N'prešernovacesta16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141843, N'HS', N'11606512', N'35', N' ', N'35', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164698
', N'569767', N'lokavci35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141844, N'HS', N'11606563', N'39', N' ', N'39', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164497
', N'570438', N'lokavci39')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141845, N'HS', N'11606610', N'43', N' ', N'43', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'163855
', N'571040', N'lokavci43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141846, N'HS', N'11606644', N'1', N' ', N'1', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'171040
', N'573405', N'lomanoše1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141847, N'HS', N'11617999', N'32', N' ', N'32', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168832
', N'571775', N'plitvičkivrh32')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141848, N'HS', N'11583369', N'138', N' ', N'138', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167794
', N'576014', N'črešnjevci138')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141849, N'HS', N'11583415', N'143', N' ', N'143', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'167984
', N'575932', N'črešnjevci143')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141850, N'HS', N'11583474', N'149', N' ', N'149', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168221
', N'575952', N'črešnjevci149')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141851, N'HS', N'11620680', N'76', N' ', N'76', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169259
', N'573379', N'police76')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141852, N'HS', N'11607047', N'21', N' ', N'21', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170066
', N'573083', N'lomanoše21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141853, N'HS', N'11635024', N'21', N'B', N'21B', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167926
', N'571024', N'spodnjaščavnica21b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141854, N'HS', N'11635091', N'26', N' ', N'26', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168424
', N'571924', N'spodnjaščavnica26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141855, N'HS', N'19131564', N'74', N'E', N'74E', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167747
', N'570913', N'spodnjaščavnica74e')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141856, N'HS', N'19132455', N'3', N'A', N'3A', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164563
', N'574056', N'ivanjševciobščavnici3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141857, N'HS', N'11621066', N'112', N' ', N'112', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169030
', N'574118', N'police112')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141858, N'HS', N'11621139', N'117', N' ', N'117', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168621
', N'574065', N'police117')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141859, N'HS', N'11621210', N'125', N' ', N'125', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168516
', N'573811', N'police125')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141860, N'HS', N'11621279', N'130', N' ', N'130', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168406
', N'573357', N'police130')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141861, N'HS', N'11621325', N'135', N' ', N'135', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'167903
', N'573234', N'police135')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141862, N'HS', N'11621368', N'139', N' ', N'139', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'167526
', N'573140', N'police139')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141863, N'HS', N'11621414', N'2', N' ', N'2', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166898
', N'576902', N'ptujskacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141864, N'HS', N'11621465', N'5', N' ', N'5', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'166777
', N'576738', N'ptujskacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141865, N'HS', N'11588301', N'13', N' ', N'13', N'16184802', N'10092752', N'11026826', N'21429392', N'10253225', N'171301
', N'576220', N'lackovaulica13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141866, N'HS', N'19132285', N'18', N'D', N'18D', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169805
', N'575781', N'noričkivrh18d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141867, N'HS', N'16391166', N'18', N'B', N'18B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168611
', N'571554', N'spodnjaščavnica18b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141868, N'HS', N'11619002', N'1', N' ', N'1', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171288
', N'575256', N'podgrad1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141869, N'HS', N'19124665', N'15', N'A', N'15A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163256
', N'572125', N'negova15a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141870, N'HS', N'11606857', N'9', N' ', N'9', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170455
', N'573526', N'lomanoše9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141871, N'HS', N'11590390', N'26', N' ', N'26', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170469
', N'576246', N'prešernovacesta26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141872, N'HS', N'11590438', N'30', N' ', N'30', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170450
', N'576214', N'prešernovacesta30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141873, N'HS', N'11590497', N'40', N' ', N'40', N'16184896', N'10092752', N'11026826', N'21429392', N'10252652', N'170389
', N'576210', N'prešernovacesta40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141874, N'HS', N'11593313', N'9', N' ', N'9', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170438
', N'575971', N'prežihovaulica9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141875, N'HS', N'11606881', N'11', N' ', N'11', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170268
', N'573330', N'lomanoše11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141876, N'HS', N'11607071', N'23', N' ', N'23', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170082
', N'572997', N'lomanoše23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141877, N'HS', N'11613632', N'30', N' ', N'30', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169833
', N'575725', N'noričkivrh30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141878, N'HS', N'11579370', N'2', N' ', N'2', N'16275492', N'10092639', N'11026826', N'21429392', N'10252962', N'168447
', N'573228', N'aženskivrh2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141879, N'HS', N'19128385', N'17', N'B', N'17B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168757
', N'571541', N'spodnjaščavnica17b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141880, N'HS', N'11604358', N'25', N' ', N'25', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161808
', N'573570', N'kunova25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141881, N'HS', N'11613497', N'17', N' ', N'17', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169755
', N'575846', N'noričkivrh17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141882, N'HS', N'11613543', N'21', N' ', N'21', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169861
', N'575834', N'noričkivrh21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141883, N'HS', N'11613594', N'26', N' ', N'26', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169987
', N'575732', N'noričkivrh26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141884, N'HS', N'11582567', N'57', N' ', N'57', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168824
', N'576460', N'črešnjevci57')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141885, N'HS', N'11582800', N'83', N' ', N'83', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168619
', N'576039', N'črešnjevci83')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141886, N'HS', N'19128270', N'6', N' ', N'6', N'16185221', N'10092752', N'11026826', N'21429392', N'10252628', N'171011
', N'575751', N'rozmanovaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141887, N'HS', N'19128202', N'33', N'A', N'33A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167193
', N'574293', N'zbigovci33a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141888, N'HS', N'19137236', N'17', N'B', N'17B', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167348
', N'574976', N'zbigovci17b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141889, N'HS', N'19128610', N'15', N'B', N'15B', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170112
', N'573253', N'lomanoše15b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141890, N'HS', N'19136370', N'39', N'A', N'39A', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171378
', N'574216', N'podgrad39a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141891, N'HS', N'11591949', N'5', N' ', N'5', N'16184993', N'10092752', N'11026826', N'21429392', N'10253055', N'170654
', N'576479', N'cestanastadion5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141892, N'HS', N'11642896', N'9', N' ', N'9', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166798
', N'569806', N'zagajskivrh9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141893, N'HS', N'11584373', N'230', N' ', N'230', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169213
', N'575727', N'črešnjevci230')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141894, N'HS', N'19136094', N'51', N'A', N'51A', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171272
', N'573649', N'podgrad51a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141895, N'HS', N'11621198', N'123', N' ', N'123', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'168719
', N'573502', N'police123')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141896, N'HS', N'19130169', N'12', N' ', N'12', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169590
', N'576332', N'kajuhovaulica12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141897, N'HS', N'11609767', N'35', N' ', N'35', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168622
', N'578374', N'mele35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141898, N'HS', N'11609813', N'40', N' ', N'40', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168876
', N'578197', N'mele40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141899, N'HS', N'11607012', N'19', N' ', N'19', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170140
', N'573074', N'lomanoše19')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141900, N'HS', N'11599206', N'42', N'B', N'42B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165477
', N'574687', N'ivanjševskivrh42b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141901, N'HS', N'11618359', N'66', N' ', N'66', N'16276103', N'10093236', N'11026826', N'21428353', N'19135012', N'169153
', N'569705', N'plitvičkivrh66')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141902, N'HS', N'11616089', N'4', N' ', N'4', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167010
', N'575725', N'orehovskivrh4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141903, N'HS', N'11586856', N'3', N' ', N'3', N'16184713', N'10092752', N'11026826', N'21429392', N'10252687', N'171156
', N'575555', N'apaškacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141904, N'HS', N'11586929', N'8', N' ', N'8', N'16184713', N'10092752', N'11026826', N'21429392', N'10253233', N'171252
', N'575323', N'apaškacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141905, N'HS', N'11614205', N'12', N'A', N'12A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162665
', N'577159', N'očeslavci12a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141906, N'HS', N'11587984', N'5', N'B', N'5B', N'16184799', N'10092752', N'11026826', N'21429392', N'10253128', N'171392
', N'575956', N'kerenčičevaulica5b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141907, N'HS', N'19125297', N'22', N'B', N'22B', N'16276308', N'10093449', N'11026826', N'21432237', N'10255015', N'160997
', N'574746', N'spodnjiivanjci22b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141908, N'HS', N'11616453', N'37', N' ', N'37', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167616
', N'576125', N'orehovskivrh37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141909, N'HS', N'11614728', N'52', N' ', N'52', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163784
', N'577717', N'očeslavci52')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141910, N'HS', N'11599508', N'64', N'B', N'64B', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165626
', N'575026', N'ivanjševskivrh64b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141911, N'HS', N'11630022', N'20', N'A', N'20A', N'16276227', N'10093350', N'11026826', N'21432237', N'19127338', N'165410
', N'573256', N'rodmošci20a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141912, N'HS', N'19124886', N'49', N'A', N'49A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163779
', N'575975', N'stavešinskivrh49a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141913, N'HS', N'19129829', N'99', N'A', N'99A', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163800
', N'570293', N'negova99a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141914, N'HS', N'19129772', N'8', N'B', N'8B', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162589
', N'576932', N'očeslavci8b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141915, N'HS', N'11638899', N'50', N' ', N'50', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163725
', N'576047', N'stavešinskivrh50')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141916, N'HS', N'11589189', N'22', N' ', N'22', N'16184853', N'10092752', N'11026826', N'21429392', N'10253284', N'171162
', N'576185', N'panonskaulica22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141917, N'HS', N'19124592', N'94', N'A', N'94A', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'167341
', N'568191', N'spodnjaščavnica94a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141918, N'HS', N'19125025', N'94', N' ', N'94', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168688
', N'576438', N'črešnjevci94')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141919, N'HS', N'19125246', N'23', N'A', N'23A', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168719
', N'572063', N'plitvičkivrh23a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141920, N'HS', N'19127974', N'45', N'B', N'45B', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167928
', N'572341', N'spodnjaščavnica45b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141921, N'HS', N'19126412', N'35', N'B', N'35B', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165332
', N'576170', N'ptujskacesta35b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141922, N'HS', N'19138933', N'40', N'B', N'40B', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166884
', N'574081', N'zbigovci40b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141923, N'HS', N'19134091', N'2', N'A', N'2A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170981
', N'573239', N'lomanoše2a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141924, N'HS', N'19138992', N'21', N'B', N'21B', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'170030
', N'575005', N'police21b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141925, N'HS', N'19138984', N'27', N'A', N'27A', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'167091
', N'573120', N'lastomerci27a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141926, N'HS', N'11586872', N'5', N' ', N'5', N'16184713', N'10092752', N'11026826', N'21429392', N'10252687', N'171171
', N'575537', N'apaškacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141927, N'HS', N'11617824', N'16', N' ', N'16', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169002
', N'572044', N'plitvičkivrh16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141928, N'HS', N'11618065', N'38', N' ', N'38', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168940
', N'571810', N'plitvičkivrh38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141929, N'HS', N'11618138', N'46', N' ', N'46', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169118
', N'571718', N'plitvičkivrh46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141930, N'HS', N'19119459', N'6', N'A', N'6A', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164467
', N'574169', N'ivanjševciobščavnici6a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141931, N'HS', N'19126323', N'3', N'A', N'3A', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169881
', N'576752', N'obprogi3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141932, N'HS', N'11592937', N'8', N' ', N'8', N'16185159', N'10092752', N'11026826', N'21429392', N'10257204', N'169785
', N'576888', N'obprogi8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141933, N'HS', N'11589022', N'1', N' ', N'1', N'16184853', N'10092752', N'11026826', N'21429392', N'10253217', N'170965
', N'576243', N'panonskaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141934, N'HS', N'11589073', N'5', N' ', N'5', N'16184853', N'10092752', N'11026826', N'21429392', N'10253217', N'171023
', N'576220', N'panonskaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141935, N'HS', N'11589120', N'12', N' ', N'12', N'16184853', N'10092752', N'11026826', N'21429392', N'10253284', N'171066
', N'576237', N'panonskaulica12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141936, N'HS', N'11605150', N'7', N' ', N'7', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166339
', N'574062', N'lastomerci7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141937, N'HS', N'11605273', N'17', N' ', N'17', N'16275875', N'10093007', N'11026826', N'21429392', N'10252954', N'166165
', N'572740', N'lastomerci17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141938, N'HS', N'19125874', N'17', N' ', N'17', N'16185086', N'10092752', N'11026826', N'21429392', N'10253047', N'171037
', N'576474', N'kocljevaulica17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141939, N'HS', N'19135942', N'45', N'A', N'45A', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'164273
', N'572367', N'radvenci45a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141940, N'HS', N'11634907', N'15', N' ', N'15', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168931
', N'571525', N'spodnjaščavnica15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141941, N'HS', N'11634958', N'18', N' ', N'18', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168481
', N'571555', N'spodnjaščavnica18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141942, N'HS', N'11629083', N'12', N' ', N'12', N'16276197', N'10093333', N'11026826', N'21432237', N'10252938', N'165031
', N'571678', N'radvenci12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141943, N'HS', N'11638082', N'5', N' ', N'5', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163050
', N'575444', N'stavešinci5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141944, N'HS', N'11620329', N'43', N' ', N'43', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169690
', N'574056', N'police43')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141945, N'HS', N'11620710', N'79', N' ', N'79', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169311
', N'573473', N'police79')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141946, N'HS', N'11621031', N'109', N' ', N'109', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168898
', N'574295', N'police109')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141947, N'HS', N'11621228', N'126', N' ', N'126', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168505
', N'573658', N'police126')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141948, N'HS', N'11607519', N'53', N' ', N'53', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169476
', N'572913', N'lomanoše53')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141949, N'HS', N'11620230', N'36', N' ', N'36', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169934
', N'574313', N'police36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141950, N'HS', N'11584233', N'218', N' ', N'218', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'169212
', N'575164', N'črešnjevci218')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141951, N'HS', N'11584284', N'223', N' ', N'223', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169229
', N'575463', N'črešnjevci223')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141952, N'HS', N'11590900', N'23', N' ', N'23', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171015
', N'575874', N'šlebingerjevbreg23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141953, N'HS', N'11590969', N'1', N' ', N'1', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171233
', N'576435', N'trate1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141954, N'HS', N'11591019', N'5', N' ', N'5', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171201
', N'576435', N'trate5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141955, N'HS', N'11593615', N'5', N' ', N'5', N'16185248', N'10092752', N'11026826', N'21429392', N'10257212', N'170256
', N'576588', N'trstenjakovaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141956, N'HS', N'11593666', N'3', N' ', N'3', N'16185256', N'10092752', N'11026826', N'21429392', N'10253101', N'169780
', N'576209', N'trubarjevaulica3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141957, N'HS', N'11618146', N'47', N' ', N'47', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169134
', N'571763', N'plitvičkivrh47')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141958, N'HS', N'11591264', N'2', N' ', N'2', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170232
', N'576308', N'ulicasilviretomassini2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141959, N'HS', N'11591337', N'12', N' ', N'12', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170213
', N'576245', N'ulicasilviretomassini12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141960, N'HS', N'11591370', N'17', N' ', N'17', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170149
', N'576290', N'ulicasilviretomassini17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141961, N'HS', N'11591426', N'22', N' ', N'22', N'16184942', N'10092752', N'11026826', N'21429392', N'10253080', N'170104
', N'576261', N'ulicasilviretomassini22')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141962, N'HS', N'11591485', N'3', N' ', N'3', N'16184969', N'10092752', N'11026826', N'21429392', N'10257212', N'170435
', N'576425', N'vrečovacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141963, N'HS', N'11591523', N'7', N' ', N'7', N'16184969', N'10092752', N'11026826', N'21429392', N'10257212', N'170373
', N'576484', N'vrečovacesta7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141964, N'HS', N'11591574', N'1', N' ', N'1', N'16184977', N'10092752', N'11026826', N'21429392', N'10253225', N'171176
', N'576159', N'vrtnaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141965, N'HS', N'11582982', N'104', N' ', N'104', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'168477
', N'576469', N'črešnjevci104')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141966, N'HS', N'11620396', N'51', N' ', N'51', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169983
', N'573973', N'police51')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141967, N'HS', N'11620442', N'56', N' ', N'56', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169688
', N'573782', N'police56')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141968, N'HS', N'11591728', N'20', N' ', N'20', N'16184977', N'10092752', N'11026826', N'21429392', N'10253284', N'171222
', N'576275', N'vrtnaulica20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141969, N'HS', N'11594085', N'2', N' ', N'2', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163451
', N'572945', N'gornjiivanjci2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141970, N'HS', N'11594131', N'7', N' ', N'7', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163305
', N'573327', N'gornjiivanjci7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141971, N'HS', N'11594182', N'11', N' ', N'11', N'16275620', N'10092779', N'11026826', N'21432237', N'10255023', N'163072
', N'574069', N'gornjiivanjci11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141972, N'HS', N'11587208', N'5', N' ', N'5', N'16184748', N'10092752', N'11026826', N'21429392', N'10253098', N'170201
', N'576370', N'delavskapot5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141973, N'HS', N'11587259', N'9', N' ', N'9', N'16184748', N'10092752', N'11026826', N'21429392', N'10253098', N'170185
', N'576349', N'delavskapot9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141974, N'HS', N'11587305', N'16', N' ', N'16', N'16184748', N'10092752', N'11026826', N'21429392', N'10253080', N'170083
', N'576325', N'delavskapot16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141975, N'HS', N'11587356', N'24', N' ', N'24', N'16184748', N'10092752', N'11026826', N'21429392', N'10253071', N'169957
', N'576331', N'delavskapot24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141976, N'HS', N'11587372', N'2', N' ', N'2', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171222
', N'575593', N'grajskacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141977, N'HS', N'11587437', N'8', N' ', N'8', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171273
', N'575621', N'grajskacesta8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141978, N'HS', N'11596223', N'31', N' ', N'31', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170411
', N'574826', N'hercegovščak31')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141979, N'HS', N'11596274', N'35', N' ', N'35', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170412
', N'574635', N'hercegovščak35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141980, N'HS', N'11596347', N'40', N' ', N'40', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170410
', N'574036', N'hercegovščak40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141981, N'HS', N'11596380', N'44', N'A', N'44A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170490
', N'574374', N'hercegovščak44a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141982, N'HS', N'11596436', N'48', N'A', N'48A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252717', N'170832
', N'574467', N'hercegovščak48a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141983, N'HS', N'11598196', N'1', N' ', N'1', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161187
', N'574529', N'ivanjskivrh1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141984, N'HS', N'11612024', N'5', N' ', N'5', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163034
', N'572610', N'negova5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141985, N'HS', N'11587739', N'6', N' ', N'6', N'16184764', N'10092752', N'11026826', N'21429392', N'10253233', N'171487
', N'575341', N'gubčevacesta6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141986, N'HS', N'11612938', N'92', N' ', N'92', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163267
', N'570388', N'negova92')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141987, N'HS', N'11612997', N'97', N' ', N'97', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163842
', N'570240', N'negova97')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141988, N'HS', N'11599320', N'49', N' ', N'49', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164572
', N'574912', N'ivanjševskivrh49')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141989, N'HS', N'11599362', N'53', N' ', N'53', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164424
', N'575040', N'ivanjševskivrh53')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141990, N'HS', N'11589014', N'29', N' ', N'29', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'169511
', N'576420', N'mariborskacesta29')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141991, N'HS', N'11592651', N'5', N' ', N'5', N'16185116', N'10092752', N'11026826', N'21429392', N'10257204', N'170182
', N'576625', N'miklošičevaulica5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141992, N'HS', N'11599435', N'58', N' ', N'58', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164990
', N'574901', N'ivanjševskivrh58')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141993, N'HS', N'11599486', N'63', N' ', N'63', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165626
', N'575155', N'ivanjševskivrh63')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141994, N'HS', N'11613217', N'117', N' ', N'117', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'164030
', N'570646', N'negova117')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141995, N'HS', N'11613322', N'1', N' ', N'1', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169812
', N'576146', N'noričkivrh1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141996, N'HS', N'11613381', N'7', N' ', N'7', N'16276014', N'10093155', N'11026826', N'21429392', N'10252695', N'169669
', N'575971', N'noričkivrh7')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141997, N'HS', N'19127800', N'1', N'B', N'1B', N'16184713', N'10092752', N'11026826', N'21429392', N'10253250', N'171133
', N'575642', N'apaškacesta1b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141998, N'HS', N'11643272', N'40', N'A', N'40A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166761
', N'569202', N'zagajskivrh40a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (141999, N'HS', N'11643841', N'39', N'A', N'39A', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'166952
', N'574136', N'zbigovci39a')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142000, N'HS', N'16171522', N'1', N' ', N'1', N'16185035', N'10092752', N'11026826', N'21429392', N'10252687', N'171191
', N'575332', N'gasilskacesta1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142001, N'HS', N'11609775', N'36', N' ', N'36', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168687
', N'578257', N'mele36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142002, N'HS', N'19119530', N'3', N'A', N'3A', N'16185205', N'10092752', N'11026826', N'21429392', N'10252652', N'170487
', N'576030', N'prežihovaulica3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142003, N'HS', N'11607446', N'48', N' ', N'48', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169151
', N'572177', N'lomanoše48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142004, N'HS', N'11589880', N'48', N' ', N'48', N'16184861', N'10092752', N'11026826', N'21429392', N'19132641', N'170293
', N'576423', N'partizanskacesta48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142005, N'HS', N'11592848', N'10', N' ', N'10', N'16185132', N'10092752', N'11026826', N'21429392', N'19132706', N'169613
', N'576588', N'obpotoku10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142006, N'HS', N'11592414', N'2', N' ', N'2', N'16185086', N'10092752', N'11026826', N'21429392', N'19132765', N'170841
', N'576546', N'kocljevaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142007, N'HS', N'11634877', N'13', N' ', N'13', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168429
', N'571355', N'spodnjaščavnica13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142008, N'HS', N'11644104', N'64', N' ', N'64', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167232
', N'573509', N'zbigovci64')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142009, N'HS', N'19138925', N'108', N'A', N'108A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169069
', N'574261', N'police108a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142010, N'HS', N'11606342', N'20', N' ', N'20', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164667
', N'570920', N'lokavci20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142011, N'HS', N'11638732', N'40', N'A', N'40A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163975
', N'575909', N'stavešinskivrh40a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142012, N'HS', N'16391026', N'3', N'A', N'3A', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167193
', N'577139', N'orehovci3a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142013, N'HS', N'19139026', N'35', N'A', N'35A', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171306
', N'574486', N'podgrad35a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142014, N'HS', N'16551333', N'132', N'A', N'132A', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'168158
', N'573374', N'police132a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142015, N'HS', N'11644309', N'79', N' ', N'79', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'168299
', N'574234', N'zbigovci79')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142016, N'HS', N'11589570', N'21', N' ', N'21', N'16184861', N'10092752', N'11026826', N'21429392', N'16398071', N'170751
', N'576239', N'partizanskacesta21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142017, N'HS', N'19138593', N'17', N' ', N'17', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170855
', N'575745', N'simoničevbreg17')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142018, N'HS', N'11637965', N'1', N'A', N'1A', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163117
', N'576310', N'stavešinci1a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142019, N'HS', N'11629997', N'15', N' ', N'15', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'165953
', N'574068', N'rodmošci15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142020, N'HS', N'19138330', N'4', N'A', N'4A', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160960
', N'574604', N'ivanjskivrh4a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142021, N'HS', N'19138259', N'1', N'D', N'1D', N'16276359', N'10093481', N'11026826', N'21432237', N'10255180', N'163173
', N'576299', N'stavešinci1d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142022, N'HS', N'11606458', N'30', N' ', N'30', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'164868
', N'570210', N'lokavci30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142023, N'HS', N'11606768', N'7', N'A', N'7A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'170626
', N'573526', N'lomanoše7a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142024, N'HS', N'11635997', N'88', N' ', N'88', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168008
', N'569183', N'spodnjaščavnica88')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142025, N'HS', N'11589774', N'40', N' ', N'40', N'16184861', N'10092752', N'11026826', N'21429392', N'19132641', N'170419
', N'576344', N'partizanskacesta40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142026, N'HS', N'19131084', N'26', N'A', N'26A', N'16275891', N'10093023', N'11026826', N'21432237', N'10255228', N'165057
', N'571082', N'lokavci26a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142027, N'HS', N'11588026', N'8', N' ', N'8', N'16184799', N'10092752', N'11026826', N'21429392', N'10253284', N'171390
', N'575987', N'kerenčičevaulica8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142028, N'HS', N'16563005', N'2', N'B', N'2B', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167720
', N'575559', N'zbigovci2b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142029, N'HS', N'11643400', N'3', N'B', N'3B', N'16276464', N'10093619', N'11026826', N'21429392', N'10252784', N'167986
', N'575384', N'zbigovci3b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142030, N'HS', N'11621848', N'32', N'B', N'32B', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165565
', N'576170', N'ptujskacesta32b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142031, N'HS', N'11609856', N'45', N' ', N'45', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168958
', N'578163', N'mele45')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142032, N'HS', N'11609341', N'5', N' ', N'5', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168935
', N'578277', N'mele5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142033, N'HS', N'11609392', N'12', N' ', N'12', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168859
', N'578419', N'mele12')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142034, N'HS', N'11609457', N'17', N'A', N'17A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168816
', N'578596', N'mele17a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142035, N'HS', N'19129853', N'53', N'A', N'53A', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'164510
', N'575138', N'ivanjševskivrh53a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142036, N'HS', N'19129888', N'30', N'B', N'30B', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169366
', N'577445', N'ljutomerskacesta30b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142037, N'HS', N'19136469', N'35', N'B', N'35B', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168633
', N'578287', N'mele35b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142038, N'HS', N'11612156', N'18', N' ', N'18', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163213
', N'572156', N'negova18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142039, N'HS', N'11612440', N'46', N' ', N'46', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162671
', N'571514', N'negova46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142040, N'HS', N'11612806', N'80', N' ', N'80', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163406
', N'570854', N'negova80')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142041, N'HS', N'11613047', N'101', N' ', N'101', N'16276006', N'10093147', N'11026826', N'21432237', N'10255210', N'163774
', N'570347', N'negova101')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142042, N'HS', N'11619304', N'30', N' ', N'30', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'170802
', N'573799', N'podgrad30')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142043, N'HS', N'11619363', N'35', N' ', N'35', N'16276120', N'10093252', N'11026826', N'21429392', N'10253039', N'171262
', N'574515', N'podgrad35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142044, N'HS', N'11583857', N'184', N' ', N'184', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168128
', N'574650', N'črešnjevci184')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142045, N'HS', N'11584225', N'217', N' ', N'217', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'169200
', N'575131', N'črešnjevci217')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142046, N'HS', N'11590594', N'8', N' ', N'8', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170921
', N'575970', N'simoničevbreg8')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142047, N'HS', N'11590659', N'16', N' ', N'16', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170931
', N'575899', N'simoničevbreg16')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142048, N'HS', N'11593470', N'2', N' ', N'2', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171180
', N'575475', N'strmaulica2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142049, N'HS', N'11593518', N'6', N' ', N'6', N'16185230', N'10092752', N'11026826', N'21429392', N'10252687', N'171155
', N'575449', N'strmaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142050, N'HS', N'11590691', N'1', N' ', N'1', N'16184918', N'10092752', N'11026826', N'21429392', N'10253250', N'171025
', N'575984', N'šlebingerjevbreg1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142051, N'HS', N'11592384', N'4', N' ', N'4', N'16185078', N'10092752', N'11026826', N'21429392', N'10253101', N'169617
', N'576251', N'kajuhovaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142052, N'HS', N'11598331', N'13', N'A', N'13A', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161566
', N'574358', N'ivanjskivrh13a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142053, N'HS', N'11598404', N'15', N' ', N'15', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161324
', N'574096', N'ivanjskivrh15')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142054, N'HS', N'11598455', N'20', N' ', N'20', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161085
', N'574000', N'ivanjskivrh20')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142055, N'HS', N'11598501', N'25', N' ', N'25', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160940
', N'573759', N'ivanjskivrh25')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142056, N'HS', N'11612199', N'21', N' ', N'21', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163208
', N'572112', N'negova21')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142057, N'HS', N'11607225', N'35', N' ', N'35', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169844
', N'572791', N'lomanoše35')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142058, N'HS', N'11607292', N'40', N' ', N'40', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169963
', N'572685', N'lomanoše40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142059, N'HS', N'11607381', N'45', N'A', N'45A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169768
', N'572376', N'lomanoše45a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142060, N'HS', N'11607438', N'48', N'A', N'48A', N'16275905', N'10093031', N'11026826', N'21429392', N'10253306', N'169154
', N'572217', N'lomanoše48a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142061, N'HS', N'11612334', N'36', N' ', N'36', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163064
', N'572116', N'negova36')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142062, N'HS', N'11612385', N'40', N' ', N'40', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163030
', N'571955', N'negova40')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142063, N'HS', N'11588140', N'1', N' ', N'1', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171223
', N'576336', N'lackovaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142064, N'HS', N'11588204', N'6', N' ', N'6', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171312
', N'576272', N'lackovaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142065, N'HS', N'11599095', N'33', N' ', N'33', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'164974
', N'573985', N'ivanjševskivrh33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142066, N'HS', N'11599150', N'38', N' ', N'38', N'16275735', N'10092868', N'11026826', N'21432237', N'10252776', N'165461
', N'574373', N'ivanjševskivrh38')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142067, N'HS', N'11612571', N'58', N' ', N'58', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162577
', N'571232', N'negova58')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142068, N'HS', N'11612610', N'62', N' ', N'62', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162240
', N'571094', N'negova62')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142069, N'HS', N'11638970', N'55', N' ', N'55', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'163537
', N'576239', N'stavešinskivrh55')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142070, N'HS', N'11596410', N'46', N' ', N'46', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170581
', N'574398', N'hercegovščak46')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142071, N'HS', N'19139549', N'30', N'A', N'30A', N'16184829', N'10092752', N'11026826', N'21429392', N'10257239', N'169402
', N'577379', N'ljutomerskacesta30a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142072, N'HS', N'19139484', N'19', N'A', N'19A', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167930
', N'571225', N'spodnjaščavnica19a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142073, N'HS', N'19139077', N'28', N'A', N'28A', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164365
', N'576439', N'stavešinskivrh28a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142074, N'HS', N'19139573', N'227', N'B', N'227B', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169318
', N'575745', N'črešnjevci227b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142075, N'HS', N'19139395', N'229', N'B', N'229B', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'169250
', N'575758', N'črešnjevci229b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142076, N'HS', N'19139441', N'166', N' ', N'166', N'16275565', N'10092698', N'11026826', N'21429392', N'10252822', N'168444
', N'575714', N'črešnjevci166')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142077, N'HS', N'11615872', N'5', N' ', N'5', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167247
', N'577027', N'orehovci5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142078, N'HS', N'19139301', N'148', N'B', N'148B', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168153
', N'575968', N'črešnjevci148b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142079, N'HS', N'11615864', N'4', N' ', N'4', N'16276065', N'10093198', N'11026826', N'21429392', N'10256836', N'167259
', N'577123', N'orehovci4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142080, N'HS', N'19139310', N'15', N'A', N'15A', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161313
', N'574128', N'ivanjskivrh15a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142081, N'HS', N'11599567', N'65', N' ', N'65', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165876
', N'575016', N'ivanjševskivrh65')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142082, N'HS', N'11612466', N'48', N' ', N'48', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162731
', N'571449', N'negova48')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142083, N'HS', N'11616429', N'34', N' ', N'34', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167582
', N'575997', N'orehovskivrh34')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142084, N'HS', N'11621783', N'30', N'A', N'30A', N'16276154', N'10093295', N'11026826', N'21429392', N'10252792', N'165709
', N'576258', N'ptujskacesta30a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142085, N'HS', N'19139093', N'41', N' ', N'41', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166808
', N'569202', N'zagajskivrh41')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142086, N'HS', N'19128326', N'41', N'B', N'41B', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163430
', N'577638', N'očeslavci41b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142087, N'HS', N'19139476', N'38', N'B', N'38B', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168787
', N'578226', N'mele38b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142088, N'HS', N'11617760', N'10', N' ', N'10', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'169181
', N'572068', N'plitvičkivrh10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142089, N'HS', N'11598269', N'6', N' ', N'6', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'160910
', N'574145', N'ivanjskivrh6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142090, N'HS', N'19139034', N'40', N'A', N'40A', N'16275956', N'10093082', N'11026826', N'21431745', N'19129179', N'168866
', N'578191', N'mele40a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142091, N'HS', N'19138658', N'33', N'B', N'33B', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170411
', N'574665', N'hercegovščak33b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142092, N'HS', N'19138976', N'2', N'D', N'2D', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169377
', N'576592', N'črešnjevci2d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142093, N'HS', N'11643256', N'39', N'A', N'39A', N'16276456', N'10093597', N'11026826', N'21429392', N'10252890', N'166824
', N'569210', N'zagajskivrh39a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142094, N'HS', N'11591060', N'11', N' ', N'11', N'16184926', N'10092752', N'11026826', N'21429392', N'10252750', N'171239
', N'576458', N'trate11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142095, N'HS', N'19139450', N'2', N' ', N'2', N'16185132', N'10092752', N'11026826', N'21429392', N'10253098', N'169578
', N'576392', N'obpotoku2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142096, N'HS', N'11638511', N'23', N' ', N'23', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164068
', N'575793', N'stavešinskivrh23')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142097, N'HS', N'11584047', N'201', N' ', N'201', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168369
', N'575205', N'črešnjevci201')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142098, N'HS', N'11620523', N'63', N' ', N'63', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169939
', N'573528', N'police63')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142099, N'HS', N'19125670', N'37', N'A', N'37A', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'163219
', N'577719', N'očeslavci37a')
GO
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142100, N'HS', N'11583768', N'176', N' ', N'176', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'168220
', N'575415', N'črešnjevci176')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142101, N'HS', N'11604340', N'24', N' ', N'24', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'161456
', N'573348', N'kunova24')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142102, N'HS', N'11589065', N'4', N' ', N'4', N'16184853', N'10092752', N'11026826', N'21429392', N'10252636', N'170795
', N'576225', N'panonskaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142103, N'HS', N'11614213', N'12', N'B', N'12B', N'16276049', N'10093171', N'11026826', N'21432237', N'10259371', N'162659
', N'577273', N'očeslavci12b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142104, N'HS', N'19139212', N'22', N'A', N'22A', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167457
', N'575639', N'orehovskivrh22a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142105, N'HS', N'11644201', N'70', N' ', N'70', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167732
', N'574229', N'zbigovci70')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142106, N'HS', N'19126510', N'36', N'A', N'36A', N'16275662', N'10092817', N'11026826', N'21429392', N'10252725', N'170475
', N'574474', N'hercegovščak36a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142107, N'HS', N'11582834', N'86', N' ', N'86', N'16275565', N'10092698', N'11026826', N'21429392', N'10252814', N'168549
', N'576315', N'črešnjevci86')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142108, N'HS', N'11598439', N'18', N' ', N'18', N'16275719', N'10092841', N'11026826', N'21432237', N'10255287', N'161135
', N'574003', N'ivanjskivrh18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142109, N'HS', N'11588271', N'10', N' ', N'10', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171334
', N'576207', N'lackovaulica10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142110, N'HS', N'19135560', N'214', N'A', N'214A', N'16275565', N'10092698', N'11026826', N'21429392', N'10252849', N'169267
', N'574936', N'črešnjevci214a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142111, N'HS', N'19139131', N'10', N' ', N'10', N'16184845', N'10092752', N'11026826', N'21429392', N'10253098', N'170046
', N'576368', N'mariborskacesta10')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142112, N'HS', N'11644074', N'62', N' ', N'62', N'16276464', N'10093619', N'11026826', N'21429392', N'10252857', N'167124
', N'573697', N'zbigovci62')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142113, N'HS', N'11604510', N'37', N' ', N'37', N'16275832', N'10092973', N'11026826', N'21432237', N'10255279', N'162336
', N'573620', N'kunova37')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142114, N'HS', N'11612407', N'42', N' ', N'42', N'16276006', N'10093147', N'11026826', N'21432237', N'10255201', N'163108
', N'571892', N'negova42')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142115, N'HS', N'19139387', N'15', N'B', N'15B', N'16276367', N'10093490', N'11026826', N'21432237', N'10255171', N'164540
', N'575994', N'stavešinskivrh15b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142116, N'HS', N'19139565', N'71', N'B', N'71B', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169097
', N'573159', N'police71b')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142117, N'HS', N'19139492', N'75', N' ', N'75', N'16276006', N'10093147', N'11026826', N'21432237', N'10255074', N'162736
', N'570620', N'negova75')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142118, N'HS', N'19139646', N'33', N' ', N'33', N'16184926', N'10092752', N'11026826', N'21429392', N'19132765', N'171013
', N'576677', N'trate33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142119, N'HS', N'11587127', N'5', N' ', N'5', N'16184730', N'10092752', N'11026826', N'21429392', N'10253284', N'171106
', N'576286', N'ciril-metodovacesta5')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142120, N'HS', N'19138941', N'11', N' ', N'11', N'16185132', N'10092752', N'11026826', N'21429392', N'19132706', N'169634
', N'576493', N'obpotoku11')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142121, N'HS', N'11589308', N'33', N' ', N'33', N'16184853', N'10092752', N'11026826', N'21429392', N'10253268', N'171301
', N'576036', N'panonskaulica33')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142122, N'HS', N'11635652', N'60', N' ', N'60', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'166841
', N'572636', N'spodnjaščavnica60')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142123, N'HS', N'11592252', N'1', N' ', N'1', N'16185051', N'10092752', N'11026826', N'21429392', N'10257212', N'170354
', N'576473', N'horvatovaulica1')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142124, N'HS', N'11588085', N'13', N' ', N'13', N'16184799', N'10092752', N'11026826', N'21429392', N'10253128', N'171472
', N'575900', N'kerenčičevaulica13')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142125, N'HS', N'11587399', N'3', N' ', N'3', N'16184756', N'10092752', N'11026826', N'21429392', N'10253233', N'171240
', N'575559', N'grajskacesta3')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142126, N'HS', N'11599443', N'59', N' ', N'59', N'16275735', N'10092868', N'11026826', N'21432237', N'10252911', N'165179
', N'575583', N'ivanjševskivrh59')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142127, N'HS', N'19138852', N'9', N' ', N'9', N'16185132', N'10092752', N'11026826', N'21429392', N'19132706', N'169632
', N'576479', N'obpotoku9')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142128, N'HS', N'19125815', N'24', N'A', N'24A', N'16276103', N'10093236', N'11026826', N'21429392', N'10253144', N'168695
', N'572077', N'plitvičkivrh24a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142129, N'HS', N'11620884', N'95', N' ', N'95', N'16276146', N'10093287', N'11026826', N'21429392', N'10252946', N'169358
', N'573978', N'police95')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142130, N'HS', N'11586848', N'2', N' ', N'2', N'16184713', N'10092752', N'11026826', N'21429392', N'10253233', N'171175
', N'575831', N'apaškacesta2')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142131, N'HS', N'11588174', N'4', N' ', N'4', N'16184802', N'10092752', N'11026826', N'21429392', N'10253284', N'171307
', N'576319', N'lackovaulica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142132, N'HS', N'11589081', N'6', N' ', N'6', N'16184853', N'10092752', N'11026826', N'21429392', N'10252636', N'170806
', N'576237', N'panonskaulica6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142133, N'HS', N'11590667', N'18', N' ', N'18', N'16184900', N'10092752', N'11026826', N'21429392', N'10252644', N'170904
', N'575850', N'simoničevbreg18')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142134, N'HS', N'11634761', N'4', N' ', N'4', N'16276286', N'10093414', N'11026826', N'21429392', N'10252997', N'168863
', N'569035', N'spodnjaščavnica4')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142135, N'HS', N'11635105', N'27', N' ', N'27', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'168458
', N'571964', N'spodnjaščavnica27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142136, N'HS', N'11635393', N'44', N'D', N'44D', N'16276286', N'10093414', N'11026826', N'21429392', N'10253004', N'167717
', N'572321', N'spodnjaščavnica44d')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142137, N'HS', N'11598595', N'6', N' ', N'6', N'16275727', N'10092850', N'11026826', N'21432237', N'10255198', N'164487
', N'574135', N'ivanjševciobščavnici6')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142138, N'HS', N'19132234', N'18', N'C', N'18C', N'16276014', N'10093155', N'11026826', N'21429392', N'10638950', N'169792
', N'575798', N'noričkivrh18c')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142139, N'HS', N'19131467', N'26', N' ', N'26', N'16184900', N'10092752', N'11026826', N'21429392', N'19132463', N'170914
', N'575745', N'simoničevbreg26')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142140, N'HS', N'19137309', N'4', N'A', N'4A', N'16276227', N'10093350', N'11026826', N'21429392', N'10252920', N'166849
', N'574793', N'rodmošci4a')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142141, N'HS', N'11616348', N'27', N' ', N'27', N'16276073', N'10093201', N'11026826', N'21429392', N'10252806', N'167437
', N'575851', N'orehovskivrh27')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142142, N'HS', N'11582435', N'44', N' ', N'44', N'16275565', N'10092698', N'11026826', N'21429392', N'10256844', N'169157
', N'576466', N'črešnjevci44')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142143, N'HS', N'11620485', N'59', N' ', N'59', N'16276146', N'10093287', N'11026826', N'21429392', N'10253012', N'169939
', N'573793', N'police59')
INSERT [dbo].[tbl_hs] ([Id], [ENOTA], [HS_MID], [HS], [HD], [LABELA], [ULMID], [NA_MID], [OB_MID], [PT_MID], [PO_MID], [X], [Y], [index_hs]) VALUES (142144, N'HS', N'11620949', N'100', N' ', N'100', N'16276146', N'10093287', N'11026826', N'21429392', N'10252580', N'169171
', N'573637', N'police100')
SET IDENTITY_INSERT [dbo].[tbl_hs] OFF
