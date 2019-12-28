

USE [TestApi]
GO

/****** Object:  Table [dbo].[tbl_001]    Script Date: 12/28/2019 7:52:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_001](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[email] [varchar](50) NULL,
	[password] [nvarchar](max) NULL,
	[gender] [varchar](50) NULL,
	[dept_id] [bigint] NULL,
	[salary] [decimal](18, 0) NULL,
	[national_id] [varchar](50) NULL,
	[created_by] [nvarchar](50) NULL,
	[created_at] [datetime] NULL,
	[updated_by] [nvarchar](50) NULL,
	[updated_at] [date] NULL,
 CONSTRAINT [PK_tbl_001] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

