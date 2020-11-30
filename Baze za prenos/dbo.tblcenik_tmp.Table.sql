USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL11.SQLEXPRESS\MSSQL\DATA\KOMUNALA_DB.MDF]
GO
/****** Object:  Table [dbo].[tblcenik_tmp]    Script Date: 29. 11. 2020 22:17:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcenik_tmp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Skupina] [int] NULL,
	[Storitev] [nvarchar](150) NULL,
	[em] [nvarchar](10) NULL,
	[ddv] [nvarchar](10) NULL,
	[cena] [nvarchar](20) NULL,
	[cena95] [nvarchar](20) NULL,
	[cena22] [nvarchar](20) NULL,
	[fcena] [float] NULL,
	[fcena22] [float] NULL,
	[fcena95] [float] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblcenik_tmp] ON 

INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11412, 7, N'JCB', N'ura', N'1', N'32.92', N'36.05', N'40.16', 32.92, 40.1624, 36.0474)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11413, 2, N'Inženir', N'ura', N'1', N'20.00', N'21.90', N'24.40', 20, 24.4, 21.9)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11414, 2, N'Diplomirani inženir', N'ura', N'1', N'25.00', N'27.38', N'30.50', 25, 30.5, 27.375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11415, 2, N'Monter', N'ura', N'1', N'12.80', N'14.02', N'15.62', 12.8, 15.616, 14.016)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11416, 4, N'HILTI', N'ura', N'1', N'5.00', N'5.48', N'6.10', 5, 6.1, 5.475)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11417, 2, N'Dežurstvo zimska služba', N'ura', N'1', N'9.40', N'10.29', N'11.47', 9.4, 11.468, 10.293)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11418, 2, N'Nabijač - vibro plošča', N'ura', N'1', N'7.00', N'7.67', N'8.54', 7, 8.54, 7.665)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11419, 2, N'PK delavec', N'ura', N'1', N'10.50', N'11.50', N'12.81', 10.5, 12.81, 11.4975)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11420, 2, N'KV delavec', N'ura', N'1', N'12.80', N'14.02', N'15.62', 12.8, 15.616, 14.016)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11421, 2, N'Varilec', N'ura', N'1', N'12.80', N'14.02', N'15.62', 12.8, 15.616, 14.016)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11422, 2, N'Traktor (do 25 kW) + plug', N'ura', N'1', N'28.00', N'30.66', N'34.16', 28, 34.16, 30.66)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11423, 2, N'Preglednik', N'ura', N'1', N'12.36', N'13.53', N'15.08', 12.36, 15.079199999999998, 13.534199999999999)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11424, 7, N'Kamion do 5 m3', N'ura', N'1', N'40.30', N'44.13', N'49.17', 40.3, 49.166, 44.128499999999995)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11425, 7, N'Kamion nad 5 m3', N'ura', N'1', N'42.54', N'46.58', N'51.90', 42.54, 51.8988, 46.5813)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11426, 7, N'Kamion nad 5 m3 s selitveno prikolico', N'ura', N'1', N'30.00', N'32.85', N'36.60', 30, 36.6, 32.85)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11427, 7, N'Kamion fekalist 5 m3', N'ura', N'1', N'55.00', N'60.23', N'67.10', 55, 67.1, 60.225)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11428, 7, N'Traktor s priključki (rotacijska kosa, obračalnik, mulčar)', N'ura', N'1', N'30.38', N'33.27', N'37.06', 30.38, 37.0636, 33.2661)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11429, 7, N'Bager 10 - 15 t', N'ura', N'1', N'46.57', N'50.99', N'56.82', 46.57, 56.8154, 50.99415)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11430, 7, N'Mini bager', N'ura', N'1', N'30.60', N'33.51', N'37.33', 30.6, 37.332, 33.507)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11431, 7, N'Valjar nad 1 t', N'ura', N'1', N'30.38', N'33.27', N'37.06', 30.38, 37.0636, 33.2661)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11432, 7, N'Teleskopski mulčar s = 1,00 m', N'ura', N'1', N'32.92', N'36.05', N'40.16', 32.92, 40.1624, 36.0474)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11433, 7, N'Teleskopski mulčar s = 0,70 m', N'ura', N'1', N'28.56', N'31.27', N'34.84', 28.56, 34.843199999999996, 31.2732)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11434, 7, N'Pometalni stroj', N'ura', N'1', N'30.38', N'33.27', N'37.06', 30.38, 37.0636, 33.2661)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11435, 7, N'Poltovorno vozilo', N'ura', N'1', N'26.86', N'29.41', N'32.77', 26.86, 32.7692, 29.4117)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11436, 7, N'Pregledniško vozilo', N'ura', N'1', N'18.73', N'20.51', N'22.85', 18.73, 22.8506, 20.50935)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11437, 7, N'Servisno vozilo - vodovod', N'ura', N'1', N'20.00', N'21.90', N'24.40', 20, 24.4, 21.9)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11438, 8, N'Kamion + plug', N'ura', N'1', N'50.13', N'54.89', N'61.16', 50.13, 61.1586, 54.89235)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11439, 8, N'Kamion + posipalec', N'ura', N'1', N'51.14', N'56.00', N'62.39', 51.14, 62.3908, 55.9983)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11440, 8, N'Kamion + plug + posipalec', N'ura', N'1', N'63.28', N'69.29', N'77.20', 63.28, 77.2016, 69.2916)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11441, 8, N'Traktor + plug', N'ura', N'1', N'34.94', N'38.26', N'42.63', 34.94, 42.626799999999996, 38.259299999999996)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11442, 8, N'Traktor + posipalec', N'ura', N'1', N'35.95', N'39.37', N'43.86', 35.95, 43.859, 39.36525)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11443, 8, N'Traktor + plug + posipalec', N'ura', N'1', N'45.94', N'50.30', N'56.05', 45.94, 56.0468, 50.3043)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11444, 8, N'Fastrack + plug', N'ura', N'1', N'40.01', N'43.81', N'48.81', 40.01, 48.8122, 43.81095)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11445, 8, N'Fastrack + plug + posipalec', N'ura', N'1', N'51.01', N'55.86', N'62.23', 51.01, 62.2322, 55.85595)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11446, 7, N'Fastrack + posipalec', N'ura', N'1', N'41.02', N'44.92', N'50.04', 41.02, 50.0444, 44.916900000000005)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11447, 8, N'Nakladač v zimski službi', N'ura', N'1', N'40.00', N'43.80', N'48.80', 40, 48.8, 43.8)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11448, 8, N'Traktor (do 25 kW) + plug', N'ura', N'1', N'28.00', N'30.66', N'34.16', 28, 34.16, 30.66)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11449, 8, N'Snežna freza', N'ura', N'1', N'25.00', N'27.38', N'30.50', 25, 30.5, 27.375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11450, 8, N'Posipni material - sol + frakcija (razmerje 30/70)', N'm3', N'1', N'82.01', N'89.80', N'100.05', 82.01, 100.0522, 89.80095)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11451, 8, N'Snežni koli - postavljanje', N'kos', N'1', N'1.60', N'1.75', N'1.95', 1.6, 1.952, 1.752)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11452, 8, N'Snežni koli - odstranjevanje', N'kos', N'1', N'1.20', N'1.31', N'1.46', 1.2, 1.464, 1.3139999999999998)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11453, 9, N'Košnja s traktorjem', N'ura', N'1', N'30.38', N'33.27', N'37.06', 30.38, 37.0636, 33.2661)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11454, 9, N'Košnja s traktorsko kosilnico do 25 KM', N'ura', N'1', N'20.25', N'22.17', N'24.71', 20.25, 24.705, 22.17375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11455, 9, N'Košnja s traktorsko kosilnico nad 25 KM', N'ura', N'1', N'30.38', N'33.27', N'37.06', 30.38, 37.0636, 33.2661)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11456, 4, N'Kanalete ', N'ura', N'1', N'13.60', N'14.89', N'16.59', 13.6, 16.592, 14.892)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11457, 4, N'Prometni znak', N'ura', N'1', N'77.00', N'84.32', N'93.94', 77, 93.94, 84.315)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11458, 4, N'Vodna črpalka - potopna', N'ura', N'1', N'3.50', N'3.83', N'4.27', 3.5, 4.27, 3.8325)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11459, 4, N'Stroj za rezanje žive meje', N'ura', N'1', N'4.00', N'4.38', N'4.88', 4, 4.88, 4.38)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11460, 4, N'Motorna žaga', N'ura', N'1', N'5.00', N'5.48', N'6.10', 5, 6.1, 5.475)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11461, 4, N'Ročne škarje', N'ura', N'1', N'1.00', N'1.10', N'1.22', 1, 1.22, 1.095)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11462, 4, N'Rezanje asfalta', N'm', N'1', N'4.00', N'4.38', N'4.88', 4, 4.88, 4.38)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11463, 4, N'Ročni pihalnik', N'ura', N'1', N'2.50', N'2.74', N'3.05', 2.5, 3.05, 2.7375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11464, 4, N'Žaga za vodovod', N'ura', N'1', N'7.00', N'7.67', N'8.54', 7, 8.54, 7.665)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11465, 4, N'Vrtna kosilnica', N'ura', N'1', N'2.50', N'2.74', N'3.05', 2.5, 3.05, 2.7375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11466, 4, N'Nitkarica', N'ura', N'1', N'2.50', N'2.74', N'3.05', 2.5, 3.05, 2.7375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11467, 5, N'Strojno odmaševanje notranje kanalizacije (stroj za odmaševanje)', N'ura', N'1', N'60.00', N'65.70', N'73.20', 60, 73.2, 65.7)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11468, 5, N'Odvoz fekalij', N'm3', N'1', N'13.00', N'14.24', N'15.86', 13, 15.86, 14.235)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11469, 5, N'Snemanje kanalizacije', N'ura', N'1', N'70.00', N'76.65', N'85.40', 70, 85.399999999999991, 76.649999999999991)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11470, 5, N'Zakoličenje komunalnih vodov', N'kos', N'1', N'22.50', N'24.64', N'27.45', 22.5, 27.45, 24.6375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11471, 5, N'Izdelava ocene obratovanja mKČN', N'kos', N'1', N'0.00', N'0.00', N'0.00', 0, 0, 0)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11472, 5, N'Talne označbe m2', N'm2', N'1', N'10.00', N'10.95', N'12.20', 10, 12.2, 10.95)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11473, 5, N'Najem vertikalne prometne signalizacije (polovična ali popolna zapora)', N'dan', N'1', N'40.00', N'43.80', N'48.80', 40, 48.8, 43.8)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11474, 5, N'Trajanje zapore nad 10 dni', N'dan', N'1', N'25.00', N'27.38', N'30.50', 25, 30.5, 27.375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11475, 5, N'Odvoz smeti, odpadnega materiala', N'm3', N'1', N'30.00', N'32.85', N'36.60', 30, 36.6, 32.85)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11476, 5, N'Krpanje udarnih jam - vroča masa', N't', N'1', N'184.66', N'202.20', N'225.29', 184.66, 225.2852, 202.2027)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11477, 5, N'Krpanje udarnih jam - hladna masa', N't', N'1', N'315.59', N'345.57', N'385.02', 315.59, 385.0198, 345.57104999999996)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11478, 5, N'Izkop jarka z odvozom na deponijo', N'm', N'1', N'3.22', N'3.53', N'3.93', 3.22, 3.9284000000000003, 3.5259)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11479, 5, N'Porez bankin', N'm', N'1', N'1.35', N'1.48', N'1.65', 1.35, 1.647, 1.47825)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11480, 5, N'Meritev tlaka hidrantov', N'kos', N'1', N'8.00', N'8.76', N'9.76', 8, 9.76, 8.76)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11481, 5, N'Talne označbe m', N'm', N'1', N'0.49', N'0.54', N'0.60', 0.49, 0.5978, 0.53655)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11482, 4, N'Fotokopiranje A4 sprememba', N'kos', N'1', N'0.15', N'0.16', N'0.18', 0.15, 0.183, 0.16424999999999998)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11483, 6, N'Fotokopiranje A3', N'kos', N'1', N'0.30', N'0.33', N'0.37', 0.3, 0.366, 0.32849999999999996)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11484, 6, N'Fotokopiranje A4 sprememba', N'kos', N'1', N'0.15', N'0.16', N'0.18', 0.15, 0.183, 0.16424999999999998)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11485, 6, N'Izris komunalnih vodov A4', N'kos', N'1', N'1.00', N'1.10', N'1.22', 1, 1.22, 1.095)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11486, 6, N'Izris komunalnih vodov A3', N'kos', N'1', N'2.00', N'2.19', N'2.44', 2, 2.44, 2.19)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11487, 6, N'Izdelava skenograma na CD', N'kos', N'1', N'40.00', N'43.80', N'48.80', 40, 48.8, 43.8)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11488, 6, N'Izdaja digitalnih podatkov iz katastra - priprava podatkov', N'kos', N'1', N'25.00', N'27.38', N'30.50', 25, 30.5, 27.375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11489, 6, N'Vodovod', N'kos', N'1', N'40.00', N'43.80', N'48.80', 40, 48.8, 43.8)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11490, 6, N'Kanalizacija', N'kos', N'1', N'45.00', N'49.28', N'54.90', 45, 54.9, 49.275)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11491, 6, N'Izris detaljnega lista', N'kos', N'1', N'20.00', N'21.90', N'24.40', 20, 24.4, 21.9)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11492, 6, N'Izdelava CD-ja2', N'kos', N'1', N'25.00', N'27.38', N'30.50', 25, 30.5, 27.375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11493, 6, N'Po elektronski pošti', N'kos', N'1', N'25.00', N'27.38', N'30.50', 25, 30.5, 27.375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11494, 6, N'CD po pošti', N'kos', N'1', N'30.00', N'32.85', N'36.60', 30, 36.6, 32.85)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11495, 6, N'Izris katastra vodovoda v klasični obiki, format A0', N'kos', N'1', N'12.00', N'13.14', N'14.64', 12, 14.64, 13.14)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11496, 6, N'Izris katastra vodovoda v klasični obliki, format A1', N'kos', N'1', N'8.00', N'8.76', N'9.76', 8, 9.76, 8.76)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11497, 6, N'Izris katastra vodovoda v klasični obliki, format A3', N'kos', N'1', N'4.00', N'4.38', N'4.88', 4, 4.88, 4.38)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11498, 6, N'Izris katastra vodovoda v klasični obliki, format A4', N'kos', N'1', N'3.00', N'3.29', N'3.66', 3, 3.66, 3.285)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11499, 6, N'Snemanje komunalnih vodov', N'km', N'1', N'700.00', N'766.50', N'854.00', 700, 854, 766.5)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11500, 6, N'Izvedba posnetka izvedenega stanja priključka in vnos v operativni kataster upravljalca', N'kos', N'1', N'55.00', N'60.23', N'67.10', 55, 67.1, 60.225)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11501, 5, N'Drog za znak', N'kos', N'1', N'56.00', N'61.32', N'68.32', 56, 68.32, 61.32)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11502, 5, N'Prometni znak', N'kos', N'1', N'62.00', N'67.89', N'75.64', 62, 75.64, 67.89)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11503, 5, N'Beton', N'm3', N'1', N'82.00', N'89.79', N'100.04', 82, 100.03999999999999, 89.789999999999992)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11504, 5, N'Gramoz drobljenec - Kloch s prevozom', N't', N'1', N'10.08', N'11.04', N'12.30', 10.08, 12.2976, 11.0376)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11505, 5, N'Gramoz drobljenec - Segrap s prevozom', N't', N'1', N'11.38', N'12.46', N'13.88', 11.38, 13.883600000000001, 12.4611)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11506, 5, N'Prevoz gramoza - Kloch', N't', N'1', N'3.50', N'3.83', N'4.27', 3.5, 4.27, 3.8325)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11507, 5, N'Prevoz gramoza - Segrap', N't', N'1', N'4.00', N'4.38', N'4.88', 4, 4.88, 4.38)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11508, 5, N'Cestno ogledalo', N'kos', N'1', N'205.00', N'224.48', N'250.10', 205, 250.1, 224.475)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11509, 5, N'Odvoz odpadnega asfalta', N'kos', N'1', N'70.00', N'76.65', N'85.40', 70, 85.399999999999991, 76.649999999999991)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11510, 5, N'Cestno ogledalo', N'kos', N'1', N'0.00', N'0.00', N'0.00', 0, 0, 0)
GO
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11511, 5, N'KV delavec', N't', N'1', N'7.00', N'7.67', N'8.54', 7, 8.54, 7.665)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11512, 5, N'Fugolit ', N'kg', N'1', N'5.00', N'5.48', N'6.10', 5, 6.1, 5.475)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11513, 10, N'Kanalete ', N'kos', N'1', N'12.00', N'13.14', N'14.64', 12, 14.64, 13.14)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11514, 10, N'LTŽ pokrov 250kN', N'kos', N'1', N'145.50', N'159.32', N'177.51', 145.5, 177.51, 159.3225)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11515, 4, N'Stroj za vrtanje ', N'ura', N'1', N'5.00', N'5.48', N'6.10', 5, 6.1, 5.475)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11516, 4, N'Pihalnik-Čiščenje', N'ura', N'1', N'2.50', N'2.74', N'3.05', 2.5, 3.05, 2.7375)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11517, 5, N'Kanalete ', N'kos', N'1', N'13.20', N'14.45', N'16.10', 13.2, 16.104, 14.453999999999999)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11518, 10, N'travne plošče', N'kos', N'1', N'2.69', N'2.95', N'3.28', 2.69, 3.2818, 2.94555)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11519, 5, N'Sanacija vozišča ZG. Ivanjci 606104', N'kos', N'1', N'3155.76', N'3455.56', N'3850.03', 3155.76, 3850.0272, 3455.5572)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11520, 5, N'pranje in čiščenje s strojem AGJ ', N'ura', N'1', N'65.00', N'71.18', N'79.30', 65, 79.3, 71.175)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11521, 10, N'mleti asfalt z prevozom ', N't', N'1', N'17.75', N'19.44', N'21.66', 17.75, 21.655, 19.43625)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11522, 8, N'Unimog s plugom', N'ura', N'1', N'40.01', N'43.81', N'48.81', 40.01, 48.8122, 43.81095)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11523, 8, N'Unimog s posipalcem', N'ura', N'1', N'41.02', N'44.92', N'50.04', 41.02, 50.0444, 44.916900000000005)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11524, 8, N'Unimog s plugom in posipalcem', N'ura', N'1', N'51.01', N'55.86', N'62.23', 51.01, 62.2322, 55.85595)
INSERT [dbo].[tblcenik_tmp] ([Id], [Skupina], [Storitev], [em], [ddv], [cena], [cena95], [cena22], [fcena], [fcena22], [fcena95]) VALUES (11525, 2, N'cestar-čiščenje ', N'ura', N'1', N'10.50', N'11.50', N'12.81', 10.5, 12.81, 11.4975)
SET IDENTITY_INSERT [dbo].[tblcenik_tmp] OFF
