CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(50) NOT NULL, 
    [Descriotion] NCHAR(500) NULL, 
    [Price] NUMERIC NULL, 
    [IsOnStorage] BIT NOT NULL
)
