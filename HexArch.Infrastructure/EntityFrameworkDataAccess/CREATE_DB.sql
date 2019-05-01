IF OBJECT_ID('dbo.Students', 'U') IS NULL
BEGIN
	CREATE TABLE Students ( Id UNIQUEIDENTIFIER, FirstName NVARCHAR(255), LastName NVARCHAR(255) )
END

IF NOT EXISTS(SELECT 1 FROM Students)
BEGIN
	INSERT INTO Students VALUES ( newid(), 'Linus', 'Torvalds' ), ( newid(), 'Bill', 'Gates' ), ( newid(), 'Steve', 'Wozniak' )
END