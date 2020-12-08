select * from Track where trackTitle like '%con mua ngang qua%'

select artistName from ArtistHasTrack join Artist on Artist.artistID=ArtistHasTrack.artistID where trackID=14

select top 20 * from (select *, ROW_NUMBER() OVER(PARTITION BY trackTitle ORDER BY trackID DESC) rn

from Track where trackTitle like '%bua yeu%') as temp
where rn=1

use Tify

select * from Artist where artistID='https://chiasenhac.vn/ca-si/ho-trung-dung-zsswzc36q91vwk.html'
select * from Album

alter table Artist
drop column albumID

update Artist set spotifyID=null where artistName='2B'

alter table Album 
add constraint FK_Album_Artist foreign key (artistID) references Artist(artistID)

select Album.*,artistName from Album join Artist on Album.artistID=Artist.artistID

insert into Playlist output inserted.playlistID values('asdasd')


alter table  Playlist
add playlistID int identity (1,1) primary key




alter table  PlaylistHasTrack
add constraint  FK__playlistID_PlaylistHasTrack foreign key (playlistID) references Playlist(playlistID)

alter table  Playlist
drop pk_Playlist

alter table UserHasPlaylist
add constraint fk_playlistID_UserHasPlaylist foreign key (playlistID) references Playlist(playlistID)

alter table MyMix
add myMixID int identity(1,1) primary key

alter table MyMix
drop pk_MyMix

alter table MyMixHasTrack
add constraint fk_myMixID_MyMixHasTrack foreign key (myMixID) references MyMix(myMixID)



create table UserHasMix
(
	myMixID int identity(1,1) primary key,
	userID int foreign key references Account(userID)
)

alter table UserHasMix
add constraint FK_myMixID_MyMix foreign key (myMixID) references MyMix(myMixID)

alter table UserHasMix
add constraint PK_UserHasMix primary key(myMixID,userID)

alter table UserHasMix
add constraint FK_userID_UserHasMix foreign key(userID) references Account(userID)


select * from Album join AlbumHasTrack on Album.albumID=AlbumHasTrack.albumID
join Track on AlbumHasTrack.trackID=Track.trackID

select * from Album where albumLink like'%hac-ngot-moi-tr%'
select * from Track where trackLink not like '%nghe-album%'

/*	https://vi.chiasenhac.vn/nghe-album/3-tuyen-tap-nhac-ngot-moi-tre-soi-dong-2019-xss7773tqtttwf.html?playlist=6

	https://vi.chiasenhac.vn/nghe-album/2017-battle-choi-b-ray-full-xss7qr5vqteah2.html?playlist=6
*/
select Album.albumTitle,Album.albumYear,Album.albumID,Track.*,Artist.*,albumArt.artistName from AlbumHasTrack join Album on AlbumHasTrack.albumID=Album.albumID
join Track on Track.trackID=AlbumHasTrack.trackID 
join ArtistHasTrack on Track.trackID=ArtistHasTrack.trackID
join Artist on Artist.artistID=ArtistHasTrack.artistID
join Artist as albumArt on albumArt.artistID=Album.artistID
where Album.albumID=25

select * from UserHasPlaylist
select * from Playlist

delete from UserHasPlaylist
delete from Playlist

select top 5000 * from Track where trackID='40998'

select count(*) from AlbumHasTrack
/*
12046
117588
*/