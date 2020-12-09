USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tbl_Podrocja_dela]    Script Date: 9. 12. 2020 21:13:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Podrocja_dela](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Podrocje] [nvarchar](50) NULL,
	[Opombe] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_Podrocja_dela] ON 

INSERT [dbo].[tbl_Podrocja_dela] ([Id], [Podrocje], [Opombe]) VALUES (1, N'Vodovod', N'Področje dela - vodovod')
INSERT [dbo].[tbl_Podrocja_dela] ([Id], [Podrocje], [Opombe]) VALUES (2, N'Kanalizacija', N'Kanalizacija')
INSERT [dbo].[tbl_Podrocja_dela] ([Id], [Podrocje], [Opombe]) VALUES (3, N'Ceste', N'Področje ceste')
INSERT [dbo].[tbl_Podrocja_dela] ([Id], [Podrocje], [Opombe]) VALUES (4, N'Javna snaga', N'Področje javna snaga')
INSERT [dbo].[tbl_Podrocja_dela] ([Id], [Podrocje], [Opombe]) VALUES (5, N'Ravnanje z odpadki', N'Področje odpadki')
INSERT [dbo].[tbl_Podrocja_dela] ([Id], [Podrocje], [Opombe]) VALUES (6, N'Čistilna naprava', N'Področje čistilna naprava')
SET IDENTITY_INSERT [dbo].[tbl_Podrocja_dela] OFF
