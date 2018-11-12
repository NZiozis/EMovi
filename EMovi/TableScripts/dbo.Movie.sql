CREATE TABLE [dbo].[Movie]
(
	[MovieId] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(100) NOT NULL, 
    [Description] VARCHAR(255) NULL, 
    [ReleaseDate] DATE NOT NULL
)
