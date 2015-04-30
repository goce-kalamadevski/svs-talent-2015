--CREATE SCHEMA [data]


IF NOT EXISTS(SELECT * FROM sys.sysobjects WHERE name = 'BikeOwners' and xtype='U')
BEGIN
	CREATE TABLE data.BikeOwners
	(
		BikeOwnerId INT IDENTITY(1,1) NOT NULL,
		FirstName nvarchar(50) NULL,
		LastName nvarchar(100) NULL
	)
END

IF NOT EXISTS(SELECT * FROM sys.sysobjects WHERE name = 'PK_BikeOwners' and xtype='PK')
BEGIN
	ALTER TABLE data.BikeOwners 
	ADD CONSTRAINT PK_BikeOwners 
	PRIMARY KEY (BikeOwnerId)
END

IF OBJECT_ID('data.Bikes') IS NULL
BEGIN
	CREATE TABLE data.Bikes 
	(
		BikeId INT IDENTITY(1,1) NOT NULL,
		BikeOwnerId INT NOT NULL,
		RegNumber NVARCHAR(50) NOT NULL,
		Colour NVARCHAR(20) NULL,
		Producer NVARCHAR(50) NULL,
		Model NVARCHAR(20) NULL,
		City NVARCHAR(50) NULL,
		SpeedCount tinyint NULL,
		TStamp timestamp not null
	)
END

IF OBJECT_ID('data.PK_Bikes',N'PK') IS NULL
BEGIN
	ALTER TABLE data.Bikes 
	ADD CONSTRAINT PK_Bikes 
	PRIMARY KEY(BikeID)
END

IF OBJECT_ID('data.FK_Bikes_BikeOwnerId_X_BikeOwners_BikeOwnerId',N'F') IS NULL
BEGIN
	ALTER TABLE data.Bikes
	ADD CONSTRAINT FK_Bikes_BikeOwnerId_X_BikeOwners_BikeOwnerId
	FOREIGN KEY (BikeOwnerId)
	REFERENCES data.BikeOwners(BikeOwnerId)
END

select c.* 
from sys.syscolumns c
join sys.sysobjects o on c.id = o.id
where o.name in ('Bikes','BikeOwners')
