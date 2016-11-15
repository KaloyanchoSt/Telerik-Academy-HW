CREATE INDEX IDX_Trainers_PostDate
ON Trainers(PostDate)

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Trainers
WHERE PostDate BETWEEN GETDATE() AND GETDATE() + 15

-- Elapsed Time: 00:00:05