-- Creating full-text catalog and full-text index
CREATE FULLTEXT CATALOG TrainerNameFullTextCatalog
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON Trainers(TrainerName)
KEY INDEX PK__Trainers__366A1A7C3E923D38
ON TrainerNameFullTextCatalog
WITH CHANGE_TRACKING AUTO


-- Searching without full-text index
CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache
SELECT * FROM Trainers
WHERE TrainerName LIKE 'Doncho%'
GO

-- Elapsed Time: 00:00:07

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache
SELECT * FROM Trainers
WHERE TrainerName LIKE 'Nikolay%'
GO

-- Elapsed Time: 00:00:10

-- Searching with full-text index
CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache
SELECT * FROM Trainers
WHERE CONTAINS(TrainerName, 'Nikolay')
GO

-- Elapsed Time: 00:00:07

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache
SELECT * FROM Trainers
WHERE CONTAINS(TrainerName, 'Doncho')
GO

-- Elapsed Time: 00:00:07