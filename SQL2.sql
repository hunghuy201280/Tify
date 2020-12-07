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
