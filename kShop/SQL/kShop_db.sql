
USE [kShop]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2/6/2022 8:36:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(10000000,1) NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[MobileNumber] [varchar](11) NULL,
	[Email] [varchar](50) NOT NULL,
	[Address] [varchar](500) NULL,
	[SetDate] [datetime] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2/6/2022 8:36:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [varchar](20) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[ProductType] [varchar](50) NULL,
	[ProductPrice] [decimal](18, 0) NOT NULL,
	[Description] [varchar](500) NULL,
	[SetDate] [datetime] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [MobileNumber], [Email], [Address], [SetDate]) VALUES (10000000, N'khan', N'01738767493', N'asdf@gmail.com', N'Dhaka', CAST(N'2022-02-04T00:44:15.010' AS DateTime))
SET IDENTITY_INSERT [dbo].[Customer] OFF
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_SetDate]  DEFAULT (getdate()) FOR [SetDate]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_SetDate]  DEFAULT (getdate()) FOR [SetDate]
GO
USE [master]
GO
ALTER DATABASE [kShop] SET  READ_WRITE 
GO
