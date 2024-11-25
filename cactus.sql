USE [PractikaProgg]
GO
/****** Object:  Table [dbo].[Cactus]    Script Date: 30.10.2024 18:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cactus](
	[id_Cactus] [int] IDENTITY(1,1) NOT NULL,
	[Species] [nvarchar](50) NOT NULL,
	[Origin] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Cost] [decimal](10, 2) NOT NULL,
	[CareInstructions] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cactus] PRIMARY KEY CLUSTERED 
(
	[id_Cactus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cactus_Exhibition1]    Script Date: 30.10.2024 18:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cactus_Exhibition1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cactus] [int] NOT NULL,
	[id_Exhibition] [int] NOT NULL,
 CONSTRAINT [PK_Cactus_Exhibition1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exhibition]    Script Date: 30.10.2024 18:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exhibition](
	[id_Exhibition] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Location] [nvarchar](100) NOT NULL,
	[Awards] [nvarchar](50) NOT NULL,
	[Comments] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Exhibition] PRIMARY KEY CLUSTERED 
(
	[id_Exhibition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 30.10.2024 18:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[roleType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cactus] ON 

INSERT [dbo].[Cactus] ([id_Cactus], [Species], [Origin], [Age], [Cost], [CareInstructions]) VALUES (1, N'Остролист', N'Мексика', 5, CAST(10.99 AS Decimal(10, 2)), N'Поливать скудно, полный солнечный свет')
INSERT [dbo].[Cactus] ([id_Cactus], [Species], [Origin], [Age], [Cost], [CareInstructions]) VALUES (2, N'Сагуаро', N'Аризона, США', 10, CAST(29.99 AS Decimal(10, 2)), N'Поливать регулярно, частичная тень')
INSERT [dbo].[Cactus] ([id_Cactus], [Species], [Origin], [Age], [Cost], [CareInstructions]) VALUES (3, N'Рождественский кактус', N'Бразилия', 3, CAST(7.99 AS Decimal(10, 2)), N'Поливать умеренно, яркий косвенный свет')
INSERT [dbo].[Cactus] ([id_Cactus], [Species], [Origin], [Age], [Cost], [CareInstructions]) VALUES (4, N'Пинкшн', N'Техас, США', 7, CAST(14.99 AS Decimal(10, 2)), N'Поливать скудно, полный солнечный свет')
INSERT [dbo].[Cactus] ([id_Cactus], [Species], [Origin], [Age], [Cost], [CareInstructions]) VALUES (5, N'Старушка', N'Мексика', 12, CAST(39.99 AS Decimal(10, 2)), N'Поливать регулярно, частичная тень')
INSERT [dbo].[Cactus] ([id_Cactus], [Species], [Origin], [Age], [Cost], [CareInstructions]) VALUES (6, N'Ушастый кактус', N'Аризона, США', 4, CAST(9.99 AS Decimal(10, 2)), N'Поливать умеренно, яркий косвенный свет')
INSERT [dbo].[Cactus] ([id_Cactus], [Species], [Origin], [Age], [Cost], [CareInstructions]) VALUES (7, N'Звездчатый кактус', N'Южная Африка', 8, CAST(19.99 AS Decimal(10, 2)), N'Поливать скудно, полный солнечный свет')
INSERT [dbo].[Cactus] ([id_Cactus], [Species], [Origin], [Age], [Cost], [CareInstructions]) VALUES (10, N'Звездчатый кактус', N'Южная Африка', 8, CAST(19.99 AS Decimal(10, 2)), N'Поливать скудно, полный солнечный свет и также')
INSERT [dbo].[Cactus] ([id_Cactus], [Species], [Origin], [Age], [Cost], [CareInstructions]) VALUES (11, N'Звездчатый кактус и кактус', N'Южная Африка', 8, CAST(19.99 AS Decimal(10, 2)), N'Поливать скудно, полный солнечный свет и также')
INSERT [dbo].[Cactus] ([id_Cactus], [Species], [Origin], [Age], [Cost], [CareInstructions]) VALUES (12, N'DFVDFGDFG', N'DFGDFFD', 3, CAST(55.00 AS Decimal(10, 2)), N'SDFFDSFS')
SET IDENTITY_INSERT [dbo].[Cactus] OFF
GO
SET IDENTITY_INSERT [dbo].[Cactus_Exhibition1] ON 

INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (1, 1, 1)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (2, 2, 2)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (3, 3, 3)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (4, 4, 4)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (5, 5, 5)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (6, 6, 6)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (7, 7, 7)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (10, 4, 1)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (11, 1, 1)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (12, 4, 2)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (13, 6, 6)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (14, 2, 1)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (15, 1, 14)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (16, 12, 14)
INSERT [dbo].[Cactus_Exhibition1] ([id], [id_Cactus], [id_Exhibition]) VALUES (1010, 4, 3)
SET IDENTITY_INSERT [dbo].[Cactus_Exhibition1] OFF
GO
SET IDENTITY_INSERT [dbo].[Exhibition] ON 

INSERT [dbo].[Exhibition] ([id_Exhibition], [Date], [Location], [Awards], [Comments]) VALUES (1, CAST(N'2022-01-15' AS Date), N'Третьяковская галерея', N'Гран-при', N'Первая выставка года                              ')
INSERT [dbo].[Exhibition] ([id_Exhibition], [Date], [Location], [Awards], [Comments]) VALUES (2, CAST(N'2022-03-20' AS Date), N'Эрмитаж', N'Диплом', N'Выставка современного искусства                   ')
INSERT [dbo].[Exhibition] ([id_Exhibition], [Date], [Location], [Awards], [Comments]) VALUES (3, CAST(N'2022-05-01' AS Date), N'Национальная галерея', N'Приз зрительских симпатий', N'Выставка татарского искусства                     ')
INSERT [dbo].[Exhibition] ([id_Exhibition], [Date], [Location], [Awards], [Comments]) VALUES (4, CAST(N'2022-07-10' AS Date), N'Музей изобразительных искусств', N'Специальный приз', N'Выставка сибирских художников                     ')
INSERT [dbo].[Exhibition] ([id_Exhibition], [Date], [Location], [Awards], [Comments]) VALUES (5, CAST(N'2022-09-15' AS Date), N'Музей изобразительных искусств', N'Гран-при', N'Выставка уральских художников                     ')
INSERT [dbo].[Exhibition] ([id_Exhibition], [Date], [Location], [Awards], [Comments]) VALUES (6, CAST(N'2022-11-20' AS Date), N'Музей изобразительных искусств', N'Диплом', N'Выставка донских художников                       ')
INSERT [dbo].[Exhibition] ([id_Exhibition], [Date], [Location], [Awards], [Comments]) VALUES (7, CAST(N'2022-12-25' AS Date), N'Приморская государственная картинная ', N'Приз зрительских симпатий', N'Выставка дальневосточных художников               ')
INSERT [dbo].[Exhibition] ([id_Exhibition], [Date], [Location], [Awards], [Comments]) VALUES (13, CAST(N'2022-12-08' AS Date), N'Приморская государственная картинная ', N'Приз зрительских симпатий и также', N'Выставка дальневосточных художников               ')
INSERT [dbo].[Exhibition] ([id_Exhibition], [Date], [Location], [Awards], [Comments]) VALUES (14, CAST(N'2024-09-10' AS Date), N'DFGDGDF', N'DFGDGDFGDFGD', N'DFGDFGDF                                          ')
SET IDENTITY_INSERT [dbo].[Exhibition] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [login], [password], [name], [roleType]) VALUES (1, N'admin', N'admin', N'Ramil', N'admin')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Cactus_Exhibition1]  WITH CHECK ADD  CONSTRAINT [FK_Cactus_Exhibition1_Cactus] FOREIGN KEY([id_Cactus])
REFERENCES [dbo].[Cactus] ([id_Cactus])
GO
ALTER TABLE [dbo].[Cactus_Exhibition1] CHECK CONSTRAINT [FK_Cactus_Exhibition1_Cactus]
GO
ALTER TABLE [dbo].[Cactus_Exhibition1]  WITH CHECK ADD  CONSTRAINT [FK_Cactus_Exhibition1_Exhibition] FOREIGN KEY([id_Exhibition])
REFERENCES [dbo].[Exhibition] ([id_Exhibition])
GO
ALTER TABLE [dbo].[Cactus_Exhibition1] CHECK CONSTRAINT [FK_Cactus_Exhibition1_Exhibition]
GO
