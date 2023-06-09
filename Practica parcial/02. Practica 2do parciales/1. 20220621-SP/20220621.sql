CREATE DATABASE 20220621SP
GO
USE [20220621SP]
GO
/****** Object:  Table [dbo].[paises]    Script Date: 21/06/2022 18:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paises](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pais] [varchar](50) NOT NULL,
 CONSTRAINT [PK_paises] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehiculos]    Script Date: 21/06/2022 18:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehiculos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](50) NOT NULL,
 CONSTRAINT [PK_vehiculos_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[paises] ON 

INSERT [dbo].[paises] ([id], [pais]) VALUES (1, N'Afghanistan')
INSERT [dbo].[paises] ([id], [pais]) VALUES (2, N'Argentina')
INSERT [dbo].[paises] ([id], [pais]) VALUES (3, N'Bahamas')
INSERT [dbo].[paises] ([id], [pais]) VALUES (4, N'Belarus')
INSERT [dbo].[paises] ([id], [pais]) VALUES (5, N'Bosnia')
INSERT [dbo].[paises] ([id], [pais]) VALUES (6, N'Brazil')
INSERT [dbo].[paises] ([id], [pais]) VALUES (7, N'Cameroon')
INSERT [dbo].[paises] ([id], [pais]) VALUES (8, N'Canada')
INSERT [dbo].[paises] ([id], [pais]) VALUES (9, N'Chile')
INSERT [dbo].[paises] ([id], [pais]) VALUES (10, N'China')
INSERT [dbo].[paises] ([id], [pais]) VALUES (11, N'Italy')
INSERT [dbo].[paises] ([id], [pais]) VALUES (12, N'Denmark')
INSERT [dbo].[paises] ([id], [pais]) VALUES (13, N'Egypt')
INSERT [dbo].[paises] ([id], [pais]) VALUES (14, N'France')
INSERT [dbo].[paises] ([id], [pais]) VALUES (15, N'Germany')
INSERT [dbo].[paises] ([id], [pais]) VALUES (16, N'Greece')
INSERT [dbo].[paises] ([id], [pais]) VALUES (17, N'Iceland')
INSERT [dbo].[paises] ([id], [pais]) VALUES (18, N'Indonesia')
INSERT [dbo].[paises] ([id], [pais]) VALUES (19, N'Japan')
INSERT [dbo].[paises] ([id], [pais]) VALUES (20, N'Malaysia')
INSERT [dbo].[paises] ([id], [pais]) VALUES (21, N'Morocco')
INSERT [dbo].[paises] ([id], [pais]) VALUES (22, N'Panama')
INSERT [dbo].[paises] ([id], [pais]) VALUES (23, N'Peru')
INSERT [dbo].[paises] ([id], [pais]) VALUES (24, N'Philippines')
INSERT [dbo].[paises] ([id], [pais]) VALUES (25, N'Portugal')
INSERT [dbo].[paises] ([id], [pais]) VALUES (26, N'Russia')
INSERT [dbo].[paises] ([id], [pais]) VALUES (27, N'Bolivia')
INSERT [dbo].[paises] ([id], [pais]) VALUES (28, N'Sudan')
INSERT [dbo].[paises] ([id], [pais]) VALUES (29, N'Sweden')
INSERT [dbo].[paises] ([id], [pais]) VALUES (30, N'Thailand')
INSERT [dbo].[paises] ([id], [pais]) VALUES (31, N'Ukraine')
INSERT [dbo].[paises] ([id], [pais]) VALUES (32, N'England')
INSERT [dbo].[paises] ([id], [pais]) VALUES (33, N'Mexico')
INSERT [dbo].[paises] ([id], [pais]) VALUES (34, N'Venezuela')
INSERT [dbo].[paises] ([id], [pais]) VALUES (35, N'Yemen')
SET IDENTITY_INSERT [dbo].[paises] OFF
GO
SET IDENTITY_INSERT [dbo].[vehiculos] ON 

INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (1, N'Acura')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (2, N'Audi')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (3, N'Bentley')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (4, N'BMW')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (5, N'Buick')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (6, N'Cadillac')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (7, N'Chevrolet')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (8, N'Dodge')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (9, N'Ferrari')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (10, N'Ford')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (11, N'GMC')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (12, N'Honda')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (13, N'Infiniti')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (14, N'Isuzu')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (15, N'Jaguar')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (16, N'Jeep')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (17, N'Kia')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (18, N'Lamborghini')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (19, N'Land Rover')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (20, N'Lexus')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (21, N'Lincoln')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (22, N'Maserati')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (23, N'Maybach')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (24, N'Mazda')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (25, N'MercedezBenz')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (26, N'Mercury')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (27, N'Mitsubishi')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (28, N'Nissan')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (29, N'Oldsmobile')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (30, N'Plymouth')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (31, N'Pontiac')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (32, N'Porsche')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (33, N'Smart')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (34, N'Subaru')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (35, N'Suzuki')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (36, N'Toyota')
INSERT [dbo].[vehiculos] ([id], [marca]) VALUES (37, N'Volkswagen')
SET IDENTITY_INSERT [dbo].[vehiculos] OFF
GO
