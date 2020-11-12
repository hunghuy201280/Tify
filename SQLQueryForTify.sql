CREATE TABLE Track
(
	trackID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	trackGenre nvarchar(50),
	trackTitle nvarchar(200),
	trackLink Text,
	--trackSuggestID int foreignkey
	--artistID foreignkey
	--albumID foreignkey
	--playlistID foreignkey
)


CREATE TABLE Artist
(
	artistID nvarchar(22) NOT NULL  PRIMARY KEY,
	artistName nvarchar (100),
	
	--trackID foreignkey
)

CREATE TABLE Account
(
	username nvarchar(50) NOT NULL PRIMARY KEY,
	password nvarchar(50) ,
	--playlistID foreignkey
	--albumID foreignkey
	aritstID nvarchar(22) FOREIGN KEY REFERENCES Artist(artistID),
)
Alter table Track
Add artistID nvarchar(22);

Alter table track
add constraint fk_artistID foreign key (artistID) references Artist(artistID);

Delete  from Artist where artistID='@id';
select * from Artist;