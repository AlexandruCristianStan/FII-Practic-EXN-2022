USE [ExnCars]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [Email], [BirthDate], [Avatar]) VALUES (1, N'Cristian', N'Alexandru', N'cristian.alexandru@expertnetwork.ro', CAST(N'1988-08-27' AS Date), NULL)
GO
INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [Email], [BirthDate], [Avatar]) VALUES (2, N'Florin', N'Constantin', N'florin.constantin@expertnetwork.ro', CAST(N'1995-04-15' AS Date), NULL)
GO
INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [Email], [BirthDate], [Avatar]) VALUES (3, N'Diana', N'Dobrincu', N'diana.dobrincu@expertnetwork.ro', CAST(N'1991-06-21' AS Date), NULL)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (1, N'Alfa Romeo', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (2, N'Audi', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (3, N'BMW', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (4, N'Fiat', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (5, N'Ford', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (6, N'Honda', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (7, N'Hyundai', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (8, N'Jaguar', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (9, N'Jeep', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (10, N'Kia', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (11, N'Land Rover', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (12, N'Lexus', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (13, N'Mazda', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (14, N'Mercedes-Benz', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (15, N'Mini', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (16, N'Mitsubishi', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (17, N'Nissan', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (18, N'Porsche', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (19, N'Subaru', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (20, N'Suzuki', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (21, N'Tesla', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (22, N'Toyota', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (23, N'Volkswagen', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (24, N'Volvo', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (25, N'Dacia', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (26, N'Renault', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (27, N'Peugeot', NULL)
GO
INSERT [dbo].[Brands] ([ID], [Name], [Logo]) VALUES (28, N'Opel', NULL)
GO
SET IDENTITY_INSERT [dbo].[Brands] OFF 
GO
SET IDENTITY_INSERT [dbo].[Models] ON 
GO
INSERT [dbo].[Models] ([ID], [Name], [ModelYear], [FuelType], [EngineDisplacement], [BrandID]) VALUES (1, N'Astra GTC', N'2016', N'Gasoline', 1598, 28)
GO
INSERT [dbo].[Models] ([ID], [Name], [ModelYear], [FuelType], [EngineDisplacement], [BrandID]) VALUES (2, N'Mokka X', N'2019', N'Gasoline', 1364, 28)
GO
INSERT [dbo].[Models] ([ID], [Name], [ModelYear], [FuelType], [EngineDisplacement], [BrandID]) VALUES (6, N'Insignia Grand Sport', N'2020', N'Diesel', 1955, 28)
GO
INSERT [dbo].[Models] ([ID], [Name], [ModelYear], [FuelType], [EngineDisplacement], [BrandID]) VALUES (9, N'Astra K', N'2021', N'Gasoline', 1496, 28)
GO
INSERT [dbo].[Models] ([ID], [Name], [ModelYear], [FuelType], [EngineDisplacement], [BrandID]) VALUES (10, N'RX', N'2021', N'Full Hybrid', 3456, 12)
GO
INSERT [dbo].[Models] ([ID], [Name], [ModelYear], [FuelType], [EngineDisplacement], [BrandID]) VALUES (12, N'Corolla XI (E170)', N'2015', N'Gasoline', 1598, 22)
GO
INSERT [dbo].[Models] ([ID], [Name], [ModelYear], [FuelType], [EngineDisplacement], [BrandID]) VALUES (13, N'Kona', N'2021', N'Mild Hybrid', 998, 7)
GO
SET IDENTITY_INSERT [dbo].[Models] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehicles] ON 
GO
INSERT [dbo].[Vehicles] ([ID], [VIN], [RegistrationNumber], [RegistrationDate], [InspectionValidUntil], [ExteriorColor], [InteriorColor], [ModelID]) VALUES (1, N'JTEZU5JR8F5093816', N'IS 999 EXN', CAST(N'2015-06-12' AS Date), CAST(N'2023-01-15' AS Date), N'Grey', N'Black', 12)
GO
INSERT [dbo].[Vehicles] ([ID], [VIN], [RegistrationNumber], [RegistrationDate], [InspectionValidUntil], [ExteriorColor], [InteriorColor], [ModelID]) VALUES (2, N'WD4PG2EE3J3342736', N'IS 001 EXN', CAST(N'2018-01-01' AS Date), CAST(N'2022-07-05' AS Date), N'White', N'Grey', 1)
GO
INSERT [dbo].[Vehicles] ([ID], [VIN], [RegistrationNumber], [RegistrationDate], [InspectionValidUntil], [ExteriorColor], [InteriorColor], [ModelID]) VALUES (4, N'JTMBA31V905002995', N'IS 404 EXN', CAST(N'2021-09-19' AS Date), CAST(N'2023-03-04' AS Date), N'Green', N'Grey', 10)
GO
SET IDENTITY_INSERT [dbo].[Vehicles] OFF
GO
INSERT [dbo].[UserVehicles] ([UserID], [VehicleID]) VALUES (1, 1)
GO
INSERT [dbo].[UserVehicles] ([UserID], [VehicleID]) VALUES (2, 2)
GO
INSERT [dbo].[UserVehicles] ([UserID], [VehicleID]) VALUES (3, 4)
GO
SET IDENTITY_INSERT [dbo].[DriverLicenses] ON 
GO
INSERT [dbo].[DriverLicenses] ([ID], [UserID], [IssuedDate], [ExpirationDate], [Categories]) VALUES (1, 1, CAST(N'2015-06-01' AS Date), CAST(N'2025-06-01' AS Date), N'B')
GO
INSERT [dbo].[DriverLicenses] ([ID], [UserID], [IssuedDate], [ExpirationDate], [Categories]) VALUES (2, 2, CAST(N'2018-01-03' AS Date), CAST(N'2028-01-03' AS Date), N'B,C')
GO
INSERT [dbo].[DriverLicenses] ([ID], [UserID], [IssuedDate], [ExpirationDate], [Categories]) VALUES (3, 3, CAST(N'2011-07-21' AS Date), CAST(N'2021-07-21' AS Date), N'B')
GO
SET IDENTITY_INSERT [dbo].[DriverLicenses] OFF 
GO