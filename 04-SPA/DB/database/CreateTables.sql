-- Da se koristi samo ako vekje postojat ovie tabeli

--DROP TABLE registar.dbo.Bikes;
--DROP TABLE registar.dbo.BikeHistory

CREATE TABLE registar.dbo.Bikes (
	Id int NOT NULL IDENTITY (1, 1),
	RegNumber nvarchar(10) NULL,
	Producer nvarchar(30) NULL,
	Model nvarchar(30) NULL,
	Colour nvarchar(15) NULL,
	Tstamp timestamp NULL
	CONSTRAINT PK_BikesId PRIMARY KEY (Id), 	
)  ON [PRIMARY]

CREATE TABLE registar.dbo.BikeHistories (
	Id int NOT NULL, 
	OnDate datetime NULL,
	CONSTRAINT PK_BikeHistoryId PRIMARY KEY (Id),
	CONSTRAINT FK_BikeHistories_Bikes FOREIGN KEY (Id) 
    REFERENCES Bikes (Id) 
    ON DELETE CASCADE
    ON UPDATE CASCADE,
) ON [PRIMARY]