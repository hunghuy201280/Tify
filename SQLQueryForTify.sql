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

insert into Album (albumTitle,albumYear,albumLink)
values ('1',2,'3')

ALTER TABLE Account DROP COLUMN userID
ALTER TABLE Account ADD userID INT IDENTITY(1,1)

ALTER TABLE Account 
Add constraint pk_account primary key (userID)


ALTER TABLE Album DROP COLUMN albumID
ALTER TABLE Album ADD albumID INT IDENTITY(1,1)

ALTER TABLE Album 
Add constraint pk_album primary key (albumID)



ALTER TABLE AlbumHasTrack 
Add constraint pk_albumHasTrack primary key (albumID,trackID)



ALTER TABLE Artist DROP COLUMN csnArtistID
ALTER TABLE Artist ADD artistID nvarchar(200) 

ALTER TABLE Artist 
Add constraint pk_artistTable primary key (artistID)


UPDATE Artist 
SET artistID = artistID+1
where artistID=0;


ALTER TABLE Artist
ALTER COLUMN artistID nvarchar(200) NOT NULL;

ALTER TABLE Artist
add  artistID

ALTER TABLE Artist
drop column artistID 

delete  from Artist where artistName=N'Camkytiwa'


select * from Artist where artistName=N'Sơn Tùng M-TP'

delete from Album
select * from Album

ALTER TABLE Track DROP COLUMN trackID
ALTER TABLE Track ADD trackID INT IDENTITY(1,1)

ALTER TABLE Track 
Add constraint pk_track primary key (trackID)

Alter table MyMix
add constraint pk_MyMix primary key (myMixID)

Alter table MyMix
drop pk_MyMix


Alter table MyMix
drop column myMixTitle
Alter table MyMix
add myMixTitle nvarchar(100) not null

alter table MyMixHasTrack
add constraint pk_MyMixHasTrack primary key(myMixID,trackID)

alter table Playlist
add constraint pk_Playlist primary key (playlistID)

alter table UserFollowArtist
add constraint pk_UserFollowArtist primary key (userID,artistID)

alter table UserLikeAlbum
add constraint pk_UserLikeAlbum primary key (userID,albumID)

alter table UserLikePlaylist
add constraint pk_UserLikePlaylist primary key (userID,playlistID)


alter table UserLikeTrack
add constraint pk_UserLikeTrack primary key (userID,trackID)


alter table AlbumHasTrack
add constraint fk_trackID_AlbumHasTrack foreign key (trackID) references Track(trackID)

alter table AlbumHasTrack
add constraint fk_albumID_AlbumHasTrack foreign key (albumID) references Album(albumID)

alter table Artist
add constraint fk_albumID_Artist foreign key (albumID) references Album(albumID)

alter table Artist
add constraint fk_trackID_Artist foreign key (trackID) references Track(trackID)

alter table MyMixHasTrack
add constraint fk_myMixID_MyMixHasTrack foreign key (myMixID) references MyMix(myMixID)

alter table MyMixHasTrack
add constraint fk_trackID_MyMixHasTrack foreign key (trackID) references Track(trackID)

create table PlaylistHasTrack
(
	trackID int not null foreign key references Track(trackID) ,
	playlistID int not null foreign key references Playlist(playlistID),
	primary key(trackID,playlistID)
)

alter table Playlist 
drop column trackID

alter table UserFollowArtist
add constraint fk_userID_UserFollowArtist foreign key (userID) references Account(userID)

alter table UserFollowArtist
add constraint fk_artistID_UserFollowArtist foreign key (artistID) references Artist(artistID)

alter table UserLikeAlbum
add constraint fk_userID_UserLikeAlbum foreign key (userID) references Account(userID)

alter table UserLikeAlbum
add constraint fk_albumID_UserLikeAlbum foreign key (albumID) references Album(albumID)

alter table UserHasPlaylist
add constraint fk_userID_UserHasPlaylist foreign key (userID) references Account(userID)

alter table UserHasPlaylist
add constraint fk_playlistID_UserHasPlaylist foreign key (playlistID) references Playlist(playlistID)

alter table UserLikeTrack
add constraint fk_userID_UserLikeTrack foreign key (userID) references Account(userID)

alter table UserLikeTrack
add constraint fk_trackID_UserLikeTrack foreign key (trackID) references Track(trackID)

select* from Artist


alter table Track
drop column trackGenre

insert into Track values('1','2')
select * from Track




create table ArtistHasTrack
(
	artistID nvarchar(200) not null references Artist(artistID),
	trackID int not null references Track(trackID),
	primary key(artistID,trackID)
)

 
select distinct top 5 trackTitle from Track where trackTitle like N'%tình yêu%' 
select * from Artist

insert into Track values('Big City Boi','https://vi.chiasenhac.vn/mp3/binz-touliver/big-city-boi-tsvwzbwrq91q9a.html')
ALTER TABLE Track
ADD CONSTRAINT UN_Track UNIQUE (trackTitle,trackLink);

select * from Track order by trackID 

select * from Artist where artistID='https://chiasenhac.vn/ca-si/anh-tu-zsswztvzq91f21.html'


select * from Track;
insert into ArtistHasTrack values('https://bn.vn/ca-si/binz-zsswvs3bq924wq.html',5)
insert into Artist values('Binz',null,'https://chiasenhac.vn/ca-si/binz-zsswvs3bq924wq.html')


insert into ArtistHasTrack values("https://vi.chiasenhac.vn/ca-si/binz-zsswvs3bq924wq.html",@trackID)

select * from Track order by trackID
select count(*) from ArtistHasTrack 
select* from Artist

select * from Track,ArtistHasTrack,Artist where Track.trackID=ArtistHasTrack.trackID and ArtistHasTrack.artistID=Artist.artistID;



https://chiasenhac.vn/ca-si/anh-tu-zsswztvzq91f21.html
https://chiasenhac.vn/ca-si/anh-tu-zsswztvzq91f21.html

insert into ArtistHasTrack values('https://chiasenhac.vn/ca-si/anh-tu-zsswztvzq91f21.html',1631)

select * from Album



select * from AlbumHasTrack

alter table Account
add constraint Unique_Account UNIQue (username);



insert into Account values('admin','admin','1');

insert into UserLikeTrack ("trackID","userID") values(130,8);


select * from  (Account join UserLikeTrack on Account.userID=UserLikeTrack.userID ) 
join Track on Track.trackID=UserLikeTrack.trackID;

select * from Artist
select * from Track where trackTitle like '%tao%'


ALTER TABLE Album ALTER COLUMN albumTitle nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AI

alter table Album drop UNique_Album


alter table Album add constraint Unique_album unique(albumTitle,albumLink)
select * from ArtistHasTrack


alter table Track add constraint Unique_Track unique(trackTitle,trackLink)

ALTER TABLE Track ALTER COLUMN trackTitle nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AI


alter table Track drop UN_Track

delete from Account where username='admin01'

select* from Account
