create table [Events]
(EventId int primary key identity(1,1),
TiteleEvent varchar(20) not null unique,
CountryId int,
EDescription nvarchar(3000),
ECity varchar(30),
EYear int,
EventDate date)

create table Country
(CountryId int primary key identity(1,1),
CountryName varchar(25) not null unique,
FromYear int,ToYear int,
StateBorders nvarchar(3000)
)
create table People
(PeopleId int primary key identity(1,1),
PeopleName varchar(25) not null unique,
PeopleRole varchar(20),BirthDate date,DeathDate date,CityId int
)
