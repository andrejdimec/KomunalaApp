USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_Vrstadela]    Script Date: 30. 12. 2020 13:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Vrstadela](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Opis] [nvarchar](50) NULL,
	[Dodatni_opis] [nvarchar](50) NULL
) ON [PRIMARY]

GO
