USE [ISPHaircutCenter]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 19/4/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Country] [varchar](255) NOT NULL,
	[HP] [int] NOT NULL,
 CONSTRAINT [PK_tblAccount] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblAppointment]    Script Date: 19/4/2022 12:04:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAppointment](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Date] [varchar](255) NOT NULL,
	[Time] [varchar](255) NOT NULL,
	[Item] [text] NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Status] [char](4) NULL,
	[Change] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tblAppointment] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblAppointment]  WITH CHECK ADD  CONSTRAINT [FK_tblAppointment_tblAppointment] FOREIGN KEY([OrderID])
REFERENCES [dbo].[tblAppointment] ([OrderID])
GO
ALTER TABLE [dbo].[tblAppointment] CHECK CONSTRAINT [FK_tblAppointment_tblAppointment]
GO
