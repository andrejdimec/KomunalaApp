USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_sm]    Script Date: 30. 12. 2020 13:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sm](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[koda_sm] [nchar](10) NULL,
	[opis_sm] [nvarchar](50) NULL,
	[nadrejeno_sm] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_sm] ON 

INSERT [dbo].[tbl_sm] ([Id], [koda_sm], [opis_sm], [nadrejeno_sm]) VALUES (1, N'02        ', N'Splošno uprava', 0)
INSERT [dbo].[tbl_sm] ([Id], [koda_sm], [opis_sm], [nadrejeno_sm]) VALUES (2, N'121       ', N'Kataster', 0)
INSERT [dbo].[tbl_sm] ([Id], [koda_sm], [opis_sm], [nadrejeno_sm]) VALUES (3, N'12        ', N'Vodovod priklopi', 0)
INSERT [dbo].[tbl_sm] ([Id], [koda_sm], [opis_sm], [nadrejeno_sm]) VALUES (4, N'1214      ', N'Vodovod priklop Lomanoše 14', 3)
SET IDENTITY_INSERT [dbo].[tbl_sm] OFF
