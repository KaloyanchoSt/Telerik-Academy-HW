
-- Without partitioning
CREATE SCHEMA `trainers`;

CREATE TABLE `trainers`.`logs` (
	`Id` INT NOT NULL AUTO_INCREMENT,
	`TrainerName` TEXT NOT NULL,
	`PostDate` DATETIME NOT NULL,
	PRIMARY KEY (`Id`));

-- With partitioning
CREATE SCHEMA `trainers`;

CREATE TABLE `trainers`.`logs` (
	`Id` INT NOT NULL AUTO_INCREMENT,
	`TrainerName` TEXT NOT NULL,
	`PostDate` DATETIME NOT NULL,
	PRIMARY KEY (`Id`, `PostDate`)
) PARTITION BY RANGE(YEAR(PostDate)) (
    PARTITION p0 VALUES LESS THAN (1990),
    PARTITION p1 VALUES LESS THAN (2000),
    PARTITION p2 VALUES LESS THAN (2010),
    PARTITION p3 VALUES LESS THAN MAXVALUE
);

-- EXPLAIN PARTITIONS SELECT * FROM Logs;