CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

CREATE TABLE Trainers(
	TrainerId int NOT NULL PRIMARY KEY IDENTITY,
	TrainerName varchar(100),
	PostDate date
)
GO

INSERT INTO Trainers(TrainerName, PostDate) VALUES ('Nikolay Kostov', GETDATE())
INSERT INTO Trainers(TrainerName, PostDate) VALUES ('Doncho Minkov', GETDATE() + 1)
INSERT INTO Trainers(TrainerName, PostDate) VALUES ('Ivaylo Kenov', GETDATE() + 2)
INSERT INTO Trainers(TrainerName, PostDate) VALUES ('Evlogi Hristov', GETDATE() + 3)
INSERT INTO Trainers(TrainerName, PostDate) VALUES ('Bay Ivan', GETDATE() + 4)
INSERT INTO Trainers(TrainerName, PostDate) VALUES ('Kaka Penka', GETDATE() + 5)
INSERT INTO Trainers(TrainerName, PostDate) VALUES ('Bat Boiko', GETDATE() + 6)
INSERT INTO Trainers(TrainerName, PostDate) VALUES ('Bash Maistora', GETDATE() + 7)
INSERT INTO Trainers(TrainerName, PostDate) VALUES ('Lelya Ginka', GETDATE() + 8)
INSERT INTO Trainers(TrainerName, PostDate) VALUES ('Chicho Mitko', GETDATE() + 9)
GO

DECLARE @Counter int = 0
WHILE (SELECT COUNT(*) FROM Trainers) < 10000000
BEGIN
	INSERT INTO Trainers(TrainerName, PostDate)
	SELECT TrainerName + CONVERT(varchar, @Counter), GETDATE() + @Counter FROM Trainers
	SET @Counter = @Counter + 1
END
GO

//Elapsed Time: 00:01:06