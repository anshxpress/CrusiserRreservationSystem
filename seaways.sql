USE [seaways]
GO
/****** Object:  Table [dbo].[CancelReservation]    Script Date: 19-01-2023 15:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CancelReservation](
	[PnrNo] [nchar](10) NULL,
	[FirstName] [nchar](20) NULL,
	[LastName] [nchar](20) NULL,
	[RefundAmount] [nchar](10) NULL,
	[date] [nchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Collections]    Script Date: 19-01-2023 15:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Collections](
	[PnrNo] [nchar](10) NOT NULL,
	[Date] [nchar](30) NOT NULL,
	[Collection] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cruisers]    Script Date: 19-01-2023 15:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cruisers](
	[CruisersTypeId] [nchar](10) NOT NULL,
	[cruiseName] [varchar](50) NOT NULL,
	[FirstClassSeats] [nchar](10) NOT NULL,
	[BusinessClassSeats] [nchar](10) NOT NULL,
	[EconomyClassSeats] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Cruisers] PRIMARY KEY CLUSTERED 
(
	[CruisersTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Crusier]    Script Date: 19-01-2023 15:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Crusier](
	[CruiseNo] [nchar](10) NOT NULL,
	[DepartureTime] [nchar](10) NULL,
	[ArrivalTime] [nchar](10) NULL,
	[CruisersTypeID] [nchar](10) NULL,
	[SectorID] [nchar](10) NULL,
 CONSTRAINT [PK_Crusier] PRIMARY KEY CLUSTERED 
(
	[CruiseNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Refunds]    Script Date: 19-01-2023 15:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Refunds](
	[PnrNo] [nchar](10) NULL,
	[Date] [nchar](30) NULL,
	[RefundAmount] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 19-01-2023 15:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[PnrNo] [nchar](10) NOT NULL,
	[CruiseNo] [nchar](10) NULL,
	[TravelDate] [nchar](30) NULL,
	[Fname] [varchar](50) NULL,
	[Lname] [varchar](50) NULL,
	[Age] [nchar](10) NULL,
	[Gender] [nchar](10) NULL,
	[Class] [nchar](20) NULL,
	[SeatPref] [nchar](10) NULL,
	[MealPref] [nchar](10) NULL,
	[SSR] [varchar](50) NULL,
	[Fare] [nchar](10) NULL,
	[Source] [nchar](20) NULL,
	[Destination] [nchar](20) NULL,
	[Rstatus] [nchar](20) NULL,
	[SePassword] [nchar](10) NULL,
 CONSTRAINT [PK_Passengers] PRIMARY KEY CLUSTERED 
(
	[PnrNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScheduleCruise]    Script Date: 19-01-2023 15:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScheduleCruise](
	[ScheduleID] [nchar](10) NOT NULL,
	[CruiseNo] [nchar](10) NULL,
	[TourDate] [nchar](30) NULL,
	[FirstClassSeatAvailable] [nchar](10) NULL,
	[BusinessClassSeatAvailable] [nchar](10) NULL,
	[EconomyClassSeatAvailable] [nchar](10) NULL,
 CONSTRAINT [PK_ScheduleCruise] PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector]    Script Date: 19-01-2023 15:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector](
	[SectorID] [nchar](10) NOT NULL,
	[Source] [nchar](20) NULL,
	[Destination] [nchar](20) NULL,
	[Weekdays] [varchar](100) NULL,
	[FirstClassFare] [nchar](10) NULL,
	[BusinessClassFare] [nchar](10) NULL,
	[EconomyClassFare] [nchar](10) NULL,
 CONSTRAINT [PK_Sector] PRIMARY KEY CLUSTERED 
(
	[SectorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 19-01-2023 15:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[UserName] [nchar](15) NOT NULL,
	[Password] [nchar](15) NULL,
	[Name] [nchar](15) NULL,
	[Age] [int] NULL,
	[Sex] [nchar](1) NULL,
	[ContactNo] [nchar](13) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Collections]  WITH CHECK ADD  CONSTRAINT [FK_DailyCollections_Reservations] FOREIGN KEY([PnrNo])
REFERENCES [dbo].[Reservations] ([PnrNo])
GO
ALTER TABLE [dbo].[Collections] CHECK CONSTRAINT [FK_DailyCollections_Reservations]
GO
ALTER TABLE [dbo].[Crusier]  WITH CHECK ADD  CONSTRAINT [FK_Crusier_Cruisers] FOREIGN KEY([CruisersTypeID])
REFERENCES [dbo].[Cruisers] ([CruisersTypeId])
GO
ALTER TABLE [dbo].[Crusier] CHECK CONSTRAINT [FK_Crusier_Cruisers]
GO
ALTER TABLE [dbo].[Crusier]  WITH CHECK ADD  CONSTRAINT [FK_Crusier_Sector] FOREIGN KEY([SectorID])
REFERENCES [dbo].[Sector] ([SectorID])
GO
ALTER TABLE [dbo].[Crusier] CHECK CONSTRAINT [FK_Crusier_Sector]
GO
ALTER TABLE [dbo].[Refunds]  WITH CHECK ADD  CONSTRAINT [FK_DailyRefunds_Reservations] FOREIGN KEY([PnrNo])
REFERENCES [dbo].[Reservations] ([PnrNo])
GO
ALTER TABLE [dbo].[Refunds] CHECK CONSTRAINT [FK_DailyRefunds_Reservations]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Crusier] FOREIGN KEY([CruiseNo])
REFERENCES [dbo].[Crusier] ([CruiseNo])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Crusier]
GO
ALTER TABLE [dbo].[ScheduleCruise]  WITH CHECK ADD  CONSTRAINT [FK_ScheduleCruise_Crusier] FOREIGN KEY([CruiseNo])
REFERENCES [dbo].[Crusier] ([CruiseNo])
GO
ALTER TABLE [dbo].[ScheduleCruise] CHECK CONSTRAINT [FK_ScheduleCruise_Crusier]
GO
