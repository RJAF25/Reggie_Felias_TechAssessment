USE [ZapperTechExam]
GO

/****** Object:  Table [dbo].[Transaction]    Script Date: 23/8/2024 2:18:42 pm ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Transaction](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[customerId] [int] NULL,
	[merchantId] [int] NULL,
	[transactionDetails] [nvarchar](max) NULL,
	[created] [datetime] NULL,
	[createdBy] [nvarchar](128) NULL,
	[modified] [datetime] NULL,
	[modifiedBy] [nvarchar](128) NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Customer] FOREIGN KEY([customerId])
REFERENCES [dbo].[Customer] ([id])
GO

ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Customer]
GO

ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Merchant] FOREIGN KEY([merchantId])
REFERENCES [dbo].[Merchant] ([id])
GO

ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Merchant]
GO

