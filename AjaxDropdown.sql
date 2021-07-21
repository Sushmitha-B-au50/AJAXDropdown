CREATE TABLE Country (
    CountryID int NOT NULL,
    Name varchar(255) NOT NULL,
    PRIMARY KEY (CountryID)
);

select * from Country


CREATE TABLE States (
    StatesID int NOT NULL,
    StateName varchar(255) NOT NULL,
	CountryID int
    PRIMARY KEY (StatesID)
);

select * from States

CREATE TABLE Cities (
    CityID int NOT NULL,
    CityName varchar(255) NOT NULL,
	StatesID int
    PRIMARY KEY (CityID)
);

select * from Cities