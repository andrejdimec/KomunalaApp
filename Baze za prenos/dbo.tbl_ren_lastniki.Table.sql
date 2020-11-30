USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_ren_lastniki]    Script Date: 29. 11. 2020 22:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ren_lastniki](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[nen_id] [nchar](15) NULL,
	[emso_ms] [nvarchar](50) NULL,
	[ime] [nvarchar](150) NULL,
	[naslov] [nvarchar](150) NULL,
	[leto] [nchar](4) NULL,
	[delez_stev_izr] [int] NULL,
	[delez_imen_izr] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
