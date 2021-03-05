USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_KO]    Script Date: 28. 02. 2021 21:19:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KO](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ko_mid] [nchar](8) NULL,
	[ko_id] [nchar](4) NULL,
	[ko_ime] [nvarchar](60) NULL,
	[ko_pov] [float] NULL,
	[y_c] [float] NULL,
	[x_c] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_KO] ON 

INSERT [dbo].[tbl_KO] ([Id], [ko_mid], [ko_id], [ko_ime], [ko_pov], [y_c], [x_c]) VALUES (1, NULL, N'188 ', N'Police', NULL, NULL, NULL)
INSERT [dbo].[tbl_KO] ([Id], [ko_mid], [ko_id], [ko_ime], [ko_pov], [y_c], [x_c]) VALUES (2, NULL, N'189 ', N'Hercegovščak', NULL, NULL, NULL)
INSERT [dbo].[tbl_KO] ([Id], [ko_mid], [ko_id], [ko_ime], [ko_pov], [y_c], [x_c]) VALUES (3, NULL, N'184 ', N'Gornja Radgona', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_KO] OFF
