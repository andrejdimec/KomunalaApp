USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[ren_Strehe_tmp]    Script Date: 28. 02. 2021 21:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ren_Strehe_tmp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ObjectID] [nvarchar](10) NULL,
	[SID] [nvarchar](8) NULL,
	[Neto] [float] NULL,
	[Dvojna] [nvarchar](13) NULL,
	[HSMID] [nvarchar](8) NULL,
	[HSMID_GL] [nvarchar](8) NULL,
	[Glavna_streha] [nvarchar](1) NULL,
	[Povrsina] [float] NULL,
	[Povrsina_skupna] [float] NULL,
	[Opomba] [nvarchar](150) NULL,
	[kanalizacija] [nvarchar](1) NULL,
	[EMSO_LAST_REN] [nvarchar](13) NULL,
	[OM_ime] [nvarchar](1500) NULL,
	[OM_naslov] [nvarchar](150) NULL,
	[OM_labela] [nvarchar](30) NULL,
	[OM_posta] [nvarchar](150) NULL,
	[Vecstanovanjska] [int] NULL
) ON [PRIMARY]

GO
