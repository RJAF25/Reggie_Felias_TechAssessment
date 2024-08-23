USE [ZapperTechExam]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 23/8/2024 2:16:16 pm ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clientName] [nvarchar](128) NULL,
	[created] [datetime] NULL,
	[createdBy] [nvarchar](128) NULL,
	[modified] [datetime] NULL,
	[modifiedBy] [nvarchar](128) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_created]  DEFAULT (getdate()) FOR [created]
GO

ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_createdBy]  DEFAULT (suser_sname()) FOR [createdBy]
GO

