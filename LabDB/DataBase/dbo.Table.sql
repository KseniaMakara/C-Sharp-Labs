CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Position] NVARCHAR(50) NOT NULL, 
    [Salary] NVARCHAR(50) NOT NULL, 
    [Children] NVARCHAR(50) NOT NULL, 
    [Experience] NVARCHAR(50) NOT NULL
)
