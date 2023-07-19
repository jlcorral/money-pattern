CREATE DATABASE [InvoiceDemo]
GO

USE [InvoiceDemo]
GO

CREATE TABLE [Invoice](
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Approval] INT NOT NULL,
    [Leasing] INT NOT NULL,
	[ProcessingFee] INT NOT NULL
)
GO
 