USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_hise_dod]    Script Date: 30. 12. 2020 13:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_hise_dod](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[hsmid] [nchar](10) NULL,
	[kan_ne] [int] NULL,
	[vod_ne] [int] NULL,
	[vod_op] [nvarchar](250) NULL,
	[kan_op] [nvarchar](250) NULL,
	[opomba] [nvarchar](850) NULL,
	[dodatni_opis] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_hise_dod] ON 

INSERT [dbo].[tbl_hise_dod] ([Id], [hsmid], [kan_ne], [vod_ne], [vod_op], [kan_op], [opomba], [dodatni_opis]) VALUES (1, N'19137481  ', 0, 0, N'', N'', N'Tu pride dodatna opomba', N'Varovani blok na Tratah')
SET IDENTITY_INSERT [dbo].[tbl_hise_dod] OFF
