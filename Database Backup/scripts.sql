USE [cooperTest]
GO
/****** Object:  Table [dbo].[athlete]    Script Date: 5/3/2019 5:40:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[athlete](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[record_status] [varchar](10) NULL,
	[created_date] [datetime] NULL,
	[created_by] [varchar](50) NULL,
	[last_updated] [datetime] NULL,
	[updated_by] [varchar](50) NULL,
 CONSTRAINT [PK_athlete] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[athlete_tests]    Script Date: 5/3/2019 5:40:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[athlete_tests](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[athlete_id] [int] NULL,
	[test_id] [int] NULL,
	[distance] [decimal](18, 0) NULL,
	[record_status] [varchar](10) NULL,
	[create_date] [datetime] NULL,
	[created_by] [varchar](50) NULL,
	[last_updated] [datetime] NULL,
	[updated_by] [varchar](50) NULL,
 CONSTRAINT [PK_athlete_tests] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tests]    Script Date: 5/3/2019 5:40:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tests](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[test_date] [datetime] NULL,
	[created_date] [datetime] NULL,
	[created_by] [varchar](50) NULL,
	[record_status] [varchar](10) NULL,
	[last_updated] [datetime] NULL,
	[updated_by] [varchar](50) NULL,
 CONSTRAINT [PK_tests] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[athlete] ADD  CONSTRAINT [DF_athlete_record_status]  DEFAULT ('Active') FOR [record_status]
GO
ALTER TABLE [dbo].[athlete] ADD  CONSTRAINT [DF_athlete_created_date]  DEFAULT ('2019-05-01 13:59:33.347') FOR [created_date]
GO
ALTER TABLE [dbo].[athlete] ADD  CONSTRAINT [DF_athlete_created_by]  DEFAULT ('Test') FOR [created_by]
GO
ALTER TABLE [dbo].[athlete] ADD  CONSTRAINT [DF_athlete_last_updated]  DEFAULT ('2019-05-01 13:59:33.347') FOR [last_updated]
GO
ALTER TABLE [dbo].[athlete] ADD  CONSTRAINT [DF_athlete_updated_by]  DEFAULT ('Test') FOR [updated_by]
GO
ALTER TABLE [dbo].[athlete_tests] ADD  CONSTRAINT [DF_athlete_tests_record_status]  DEFAULT ('Active') FOR [record_status]
GO
ALTER TABLE [dbo].[athlete_tests] ADD  CONSTRAINT [DF_athlete_tests_create_date]  DEFAULT ('2019-05-01 13:59:33.347') FOR [create_date]
GO
ALTER TABLE [dbo].[athlete_tests] ADD  CONSTRAINT [DF_athlete_tests_created_by]  DEFAULT ('Test') FOR [created_by]
GO
ALTER TABLE [dbo].[athlete_tests] ADD  CONSTRAINT [DF_athlete_tests_last_updated]  DEFAULT ('2019-05-01 13:59:33.347') FOR [last_updated]
GO
ALTER TABLE [dbo].[athlete_tests] ADD  CONSTRAINT [DF_athlete_tests_updated_by]  DEFAULT ('Test') FOR [updated_by]
GO
ALTER TABLE [dbo].[tests] ADD  CONSTRAINT [DF_tests_created_date]  DEFAULT ('2019-05-01 13:59:33.347') FOR [created_date]
GO
ALTER TABLE [dbo].[tests] ADD  CONSTRAINT [DF_tests_created_by]  DEFAULT ('Test') FOR [created_by]
GO
ALTER TABLE [dbo].[tests] ADD  CONSTRAINT [DF_tests_record_status]  DEFAULT ('Active') FOR [record_status]
GO
ALTER TABLE [dbo].[tests] ADD  CONSTRAINT [DF_tests_last_updated]  DEFAULT ('2019-05-01 13:59:33.347') FOR [last_updated]
GO
ALTER TABLE [dbo].[tests] ADD  CONSTRAINT [DF_tests_updated_by]  DEFAULT ('Test') FOR [updated_by]
GO
ALTER TABLE [dbo].[athlete_tests]  WITH CHECK ADD  CONSTRAINT [FK_athlete_tests_athlete] FOREIGN KEY([athlete_id])
REFERENCES [dbo].[athlete] ([id])
GO
ALTER TABLE [dbo].[athlete_tests] CHECK CONSTRAINT [FK_athlete_tests_athlete]
GO
ALTER TABLE [dbo].[athlete_tests]  WITH CHECK ADD  CONSTRAINT [FK_athlete_tests_tests] FOREIGN KEY([test_id])
REFERENCES [dbo].[tests] ([id])
GO
ALTER TABLE [dbo].[athlete_tests] CHECK CONSTRAINT [FK_athlete_tests_tests]
GO
