﻿--select * from Track where trackTitle like '%con mua ngang qua%'

--select artistName from ArtistHasTrack join Artist on Artist.artistID=ArtistHasTrack.artistID where trackID=14

--select top 20 * from (select *, ROW_NUMBER() OVER(PARTITION BY trackTitle ORDER BY trackID DESC) rn

--from Track where trackTitle like '%bua yeu%') as temp
--where rn=1

--use Tify

--select * from Artist where artistID='https://chiasenhac.vn/ca-si/ho-trung-dung-zsswzc36q91vwk.html'
--select * from Album




--alter table Album 
--add constraint FK_Album_Artist foreign key (artistID) references Artist(artistID)

--select Album.*,artistName from Album join Artist on Album.artistID=Artist.artistID

--insert into Playlist output inserted.playlistID values('asdasd')


--alter table  Playlist
--add playlistID int identity (1,1) primary key




--alter table  PlaylistHasTrack
--add constraint  FK__playlistID_PlaylistHasTrack foreign key (playlistID) references Playlist(playlistID)

--alter table  Playlist
--drop pk_Playlist

--alter table UserHasPlaylist
--add constraint fk_playlistID_UserHasPlaylist foreign key (playlistID) references Playlist(playlistID)

--alter table MyMix
--add myMixID int identity(1,1) primary key

--alter table MyMix
--drop pk_MyMix

--alter table MyMixHasTrack
--add constraint fk_myMixID_MyMixHasTrack foreign key (myMixID) references MyMix(myMixID)



--create table UserHasMix
--(
--	myMixID int identity(1,1) primary key,
--	userID int foreign key references Account(userID)
--)

--alter table UserHasMix
--add constraint FK_myMixID_MyMix foreign key (myMixID) references MyMix(myMixID)

--alter table UserHasMix
--add constraint PK_UserHasMix primary key(myMixID,userID)

--alter table UserHasMix
--add constraint FK_userID_UserHasMix foreign key(userID) references Account(userID)


--select * from Album join AlbumHasTrack on Album.albumID=AlbumHasTrack.albumID
--join Track on AlbumHasTrack.trackID=Track.trackID

--select * from Album where albumLink like'%hac-ngot-moi-tr%'
--select * from Track where trackLink not like '%nghe-album%'

--/*	https://vi.chiasenhac.vn/nghe-album/3-tuyen-tap-nhac-ngot-moi-tre-soi-dong-2019-xss7773tqtttwf.html?playlist=6

--	https://vi.chiasenhac.vn/nghe-album/2017-battle-choi-b-ray-full-xss7qr5vqteah2.html?playlist=6
--*/
--select Album.albumTitle,Album.albumYear,Album.albumID,Track.*,Artist.*,albumArt.artistName from AlbumHasTrack join Album on AlbumHasTrack.albumID=Album.albumID
--join Track on Track.trackID=AlbumHasTrack.trackID 
--join ArtistHasTrack on Track.trackID=ArtistHasTrack.trackID
--join Artist on Artist.artistID=ArtistHasTrack.artistID
--join Artist as albumArt on albumArt.artistID=Album.artistID
--where Album.albumID=25

--select * from UserHasPlaylist
--select * from Playlist



--select top 5000 * from Track where trackID='40998'

--select count(*) from AlbumHasTrack

--select * from Account

--select * from MyMix
--select * from UserHasMix
--insert into UserHasMix values(8,3)
--insert into MyMix values('My Mix 3')
--select * from MyMixHasTrack
--insert into MyMixHasTrack values(3,19836)

--select count(*) from UserHasMix where userID=8

--select MyMix.*,Track.*,Artist.* from 
--MyMix join MyMixHasTrack on MyMix.myMixID=MyMixHasTrack.myMixID
--join Track on Track.trackID=MyMixHasTrack.trackID
--join ArtistHasTrack on Track.trackID=ArtistHasTrack.trackID
--join Artist on Artist.artistID=ArtistHasTrack.artistID
--where MyMix.myMixID=1 order by trackTitle;

--select * from UserHasMix where userID=8 order by myMixID asc;


--select distinct artistName from 
--MyMix join MyMixHasTrack on MyMix.myMixID=MyMixHasTrack.myMixID
--join Track on Track.trackID=MyMixHasTrack.trackID
--join ArtistHasTrack on Track.trackID=ArtistHasTrack.trackID
--join Artist on Artist.artistID=ArtistHasTrack.artistID
--where MyMix.myMixID=1;

--select * from ArtistHasTrack join Artist on Artist.artistID=ArtistHasTrack.artistID where trackID=25;

--select Track.*,artistName from Track join ArtistHasTrack on Track.trackID=ArtistHasTrack.trackId
--join Artist on Artist.artistID=ArtistHasTrack.artistID
--where artistName ='min';

--/*
--3
--Ghen (MCO Remix)	https://vi.chiasenhac.vn/mp3/erik-min/ghen-mco-remix-tsvdrmbsqma8q4.html	19832	MIN
--Ghen (Tez Remix)	https://vi.chiasenhac.vn/mp3/erik-min/ghen-tez-remix-tsvdv5trqm2hfa.html	19833	MIN
--Em Mới Là Người Yêu Anh	https://vi.chiasenhac.vn/mp3/min/em-moi-la-nguoi-yeu-anh-tsvc00rdqvnnam.html	19835	MIN
--Ghen	https://vi.chiasenhac.vn/mp3/erik-min/ghen-tsvdd5mcqmmh8v.html	19834	MIN
--I ♥ You (I Heart You)	https://vi.chiasenhac.vn/mp3/min-erik/i-you-i-heart-you-ts3vbr0rq2qana.html	19836	MIN


--2

--Hôn Anh	https://vi.chiasenhac.vn/mp3/min/hon-anh-tsvdw3mwqm9w89.html	19825	MIN
--Có Em Chờ	https://vi.chiasenhac.vn/mp3/min-mra/co-em-cho-tsvdqrqdqmeaem.html	19826	MIN
--Đừng Yêu Nữa, Em Mệt Rồi	https://vi.chiasenhac.vn/mp3/min/dung-yeu-nua-em-met-roi-tsvrzdwsqa1m94.html	19827	MIN
--Đừng Xin Lỗi Nữa	https://vi.chiasenhac.vn/mp3/erik-min/dung-xin-loi-nua-tsvcb0mqqvqn8e.html	19828	MIN
--Chưa Bao Giờ Mẹ Kể (Violin Version)	https://vi.chiasenhac.vn/mp3/min-erik/chua-bao-gio-me-ke-violin-version-tsvdrrs5qmaa4h.html	19829	MIN
--Steps2Fame	https://vi.chiasenhac.vn/mp3/min/steps2fame-tsvccvqbqvv2eq.html	19830	MIN
--1
--Love Note	https://vi.chiasenhac.vn/mp3/binz-min/love-note-tsvmt3ztq8fw1f.html	25	MIN
--Shine Your Light	https://vi.chiasenhac.vn/mp3/min-justatee/shine-your-light-ts3vzvm3q2128w.html	13904	MIN
--Tìm (Remix)	https://vi.chiasenhac.vn/mp3/min-microwave/tim-remix-ts33wd7wqw9mt9.html	19407	MIN
--Trên Tình Bạn Dưới Tình Yêu	https://vi.chiasenhac.vn/mp3/min/tren-tinh-ban-duoi-tinh-yeu-tsvmrcq3q8avew.html	19821	MIN
--Khúc Giao Mùa	https://vi.chiasenhac.vn/mp3/min-soobin-hoang-son/khuc-giao-mua-tsvcmd5rqv8mha.html	19822	MIN
--Y.Ê.U (EDM Version)	https://vi.chiasenhac.vn/mp3/min/yeu-edm-version-ts3vbsrtq2q4af.html	19823	MIN
--Gọi Tên Em	https://vi.chiasenhac.vn/mp3/min/goi-ten-em-tsvdqcbzqmevq1.html	19824	MIN
--*/
--alter Table UserHasMix
--add myMixID int not null

--alter Table UserHasMix
--add constraint PK_UserHasMix primary key(myMixID)

--alter Table UserHasMix
--add constraint FK_myMixID_MyMix foreign key (myMixID) references MyMix(myMixID)

--/*
--12046
--117588
--*/

--select * from UserHasPlaylist
----delete  from UserHasPlaylist where userID=8
--select * from Playlist
---- delete from Playlist

--select * from PlaylistHasTrack




--select * from Track where trackLink='https://vi.chiasenhac.vn/mp3/k-icm-jack/song-gio-tsvwts3bq9f4wq.html'

--select * from Album

--select * from Artist where artistName='2B'

----INSERT INTO Playlist (playlistTitle) OUTPUT inserted.playlistID VALUES('" + playlistname + "')


--select * from PlaylistHastrack

--insert into PlaylistHastrack values(25,38)

--select * from Playlist

--select * from ArtistHasTrack join Artist on Artist.artistID=ArtistHasTrack.artistID
--join Track on ArtistHasTrack.trackID=Track.trackID
--where trackTitle like '%con mua ngang qua%'

--select * from PlaylistHasTrack join Track on Track.trackID=PlaylistHasTrack.trackID

--select * from UserLikeTrack join Track on Track.trackID=UserLikeTrack.trackID
--where userID=8

--select UserHasMix.myMixID from UserLikeTrack 
--join UserHasMix on UserLikeTrack.userID=UserHasMix.userID
--join MyMixHasTrack  on MyMixHasTrack.trackID=UserLikeTrack.trackID and UserHasMix.myMixID=MyMixHasTrack.myMixID
--where UserLikeTrack.userID=8 and UserLikeTrack.trackID=25

--select * from UserHasMix join MyMixHasTrack on UserHasMix.myMixID=MyMixHasTrack.myMixID

--select * from Track where trackTitle like '%chang con mua xuan%'

--select * from Artist Where artistID='https://chiasenhac.vn/ca-si/quynh-giao-zssmtddrq8fmma.html'



--select Playlist.*,Track.*,Artist.*,Account.*,dateAdded from Playlist
--join PlaylistHasTrack  on PlaylistHasTrack.playlistID=Playlist.playlistID
--join Track on Track.trackID=PlaylistHasTrack.trackID
--join ArtistHasTrack on ArtistHasTrack.trackID=Track.trackID
--join Artist on Artist.artistID=ArtistHasTrack.artistID
--join Account on Account.userID=Playlist.owner
--where Playlist.playlistID=39 order by trackTitle


--select * from PlaylistHasTrack join Playlist on PlaylistHasTrack.playlistID=Playlist.playlistID

--select * from UserLikeTrack

--alter table Playlist
--add owner int references Account(userID)

--alter table PlaylistHasTrack
--add dateAdded date


--select * from UserHasPlaylist
--join Account on Account.userID=UserHasPlaylist.userID


--where playlistID=39

--select Album.*,Track.*,Artist.artistName,Artist.artistID artistLink,spotifyID from Album
--join AlbumHasTrack on Album.albumID=AlbumHasTrack.albumID
--join Track on Track.trackID=AlbumHasTrack.trackID
--join ArtistHasTrack on ArtistHasTrack.trackID=Track.trackID
--join Artist on ArtistHasTrack.artistID=Artist.artistID
--where Album.albumID=570 order by Track.trackID


--select Album.*,Track.*,Artist.artistName from Album
--join AlbumHasTrack on Album.albumID=AlbumHasTrack.albumID
--join Track on Track.trackID=AlbumHasTrack.trackID
--join ArtistHasTrack on ArtistHasTrack.trackID=Track.trackID
--join Artist on ArtistHasTrack.artistID=Artist.artistID
--where Album.albumID=570 order by Track.trackID asc


--select * from 
--(select trackID from Track except
--select Track.trackID from Track  join
--ArtistHasTrack on Track.trackID=ArtistHasTrack.trackID ) A
--join Track on A.trackID=Track.trackID

--select * from PlaylistHasTrack



--select userID,dateAdded,Track.*,artistName,Artist.artistID from UserLikeTrack join Track on Track.trackID=UserLikeTrack.trackID
--               join ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID 
--               join Artist on ArtistHasTrack.artistID = Artist.artistID   
--               where userID = 8 order by trackTitle


--select * from UserLikeAlbum


--/*
--Em	2003	https://chiasenhac.vn/nghe-album/em-xssmv750q82thn.html	8	https://chiasenhac.vn/ca-si/5-dong-ke-zssmmz5zq881h1.html
--Mùa Noel Đó	2008	https://chiasenhac.vn/nghe-album/mua-noel-do-xssmm30tq88wnf.html	10	https://chiasenhac.vn/ca-si/dam-vinh-hung-zsswz57mq91ht8.html
--Chắc Anh Phải Tu Ngàn Kiếp Mới Được Em Yêu (Single)	2020	https://chiasenhac.vn/nghe-album/chac-anh-phai-tu-ngan-kiep-moi-duoc-em-yeu-single-xss7vq0sqt2en4.html	53	https://chiasenhac.vn/ca-si/akira-phan-zssmtwz0q8f91n.html
--*/
--select * from Album

--select * from UserLikeTrack join Track on Track.trackID=UserLikeTrack.trackID

--select * from PlaylistHasTrack join Track on Track.trackID=PlaylistHasTrack.trackID order by playlistID

--select Track.*,Artist.* from Track join 
--ArtistHasTrack on ArtistHasTrack.trackID=Track.trackID
--join Artist on Artist.artistID=ArtistHasTrack.artistID
--where Track.trackID=25

--select * from UserLikeAlbum where userID=8


--select distinct UserHasPlaylist.playlistID from UserLikeTrack  
--                join UserHasPlaylist on UserLikeTrack.userID = UserHasPlaylist.userID 
--                join PlaylistHasTrack  on PlaylistHasTrack.trackID = UserLikeTrack.trackID 
--				and UserHasPlaylist.playlistID = PlaylistHasTrack.playlistID 
--                where UserLikeTrack.userID = 8 and UserLikeTrack.trackID = 25


--select Artist.*,Track.* from Artist
--join ArtistHasTrack on Artist.artistID=ArtistHasTrack.artistID
--join Track on Track.trackID=ArtistHasTrack.trackID
--where Artist.artistID='https://chiasenhac.vn/ca-si/khac-viet-zsswvzdcq921mv.html'

--insert into UserFollowArtist values(8,'https://chiasenhac.vn/ca-si/khac-viet-zsswvzdcq921mv.html')

--select * from UserFollowArtist

--select * from UserHasPlaylist

--/* command to delete playlist
--delete from UserHasPlaylist where playlistID=50

--delete From PlaylistHasTrack where playlistID=50

--delete From Playlist where playlistID=50
--*/
--select * from Account

--select * from Track

--select Album.*,Track.*,Artist.artistName,Artist.artistID artistLink,spotifyID from Album 
--                join AlbumHasTrack on Album.albumID = AlbumHasTrack.albumID
--                join Track on Track.trackID = AlbumHasTrack.trackID
--                left join ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID
--                left join Artist on ArtistHasTrack.artistID = Artist.artistID
--               where Album.albumTitle like '%ai cho toi%' order by Album.albumID

--			   select * from UserLikeAlbum


--			   select * from Album join AlbumHasTrack on AlbumHasTrack.albumID=Album.albumID
--			   join Track on Track.trackID=AlbumHasTrack.trackID where albumTitle like '%ai cho toi%'
--			   left join ArtistHasTrack
--			   select * from Album where albumTitle like '%ai cho toi%'


--select Track.* from Track except select Track.* from Track join ArtistHasTrack on Track.trackID=ArtistHasTrack.trackID

--select Track.*,Artist.* from Track left join ArtistHasTrack on Track.trackID=ArtistHasTrack.trackID
--left join Artist on Artist.artistID=ArtistHasTrack.artistID 
--where Track.trackID=115084
----2729
--select * from UserLikeAlbum

--select * from Artist where artistID='https://chiasenhac.vn/ca-si/bao-yen-zsswzwqtq919ef.html';

--select Album.*,Track.*,Artist.artistName,Artist.artistID artistLink,spotifyID from Album 
--                join AlbumHasTrack on Album.albumID = AlbumHasTrack.albumID
--                join Track on Track.trackID = AlbumHasTrack.trackID
--                left join ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID
--                left join Artist on ArtistHasTrack.artistID = Artist.artistID
--               where Album.artistID='https://chiasenhac.vn/ca-si/binz-zsswvs3bq924wq.html' order by Album.albumID

--select Album.* from Album where artistID='https://chiasenhac.vn/ca-si/son-tung-m-tp-zssw0b3tq9nqwf.html'

--select * from Artist where artistName like '%son tung%'

--select Album.*,Track.*,Artist.artistName,Artist.artistID artistLink,spotifyID from Album 
--                join AlbumHasTrack on Album.albumID = AlbumHasTrack.albumID 
--                join Track on Track.trackID = AlbumHasTrack.trackID 
--                left join ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID 
--                left join Artist on ArtistHasTrack.artistID = Artist.artistID 
--                where Album.albumID = 4559 order by Track.trackID


select Playlist.*,Track.*,Artist.*,Account.*,dateAdded from Playlist 
                join PlaylistHasTrack  on PlaylistHasTrack.playlistID = Playlist.playlistID 
                join Track on Track.trackID = PlaylistHasTrack.trackID 
                left join ArtistHasTrack on ArtistHasTrack.trackID = Track.trackID 
                left  join Artist on Artist.artistID = ArtistHasTrack.artistID
                join Account on Account.userID = Playlist.owner 
                where Playlist.playlistID = 58 order by trackTitle

select * from PlaylistHasTrack where playlistID=58

select top 10 * from Track order by trackID desc



--create table RecentlyPlayed
--(
--	userID int  references Account(userID),
--	trackID int  references Track(trackID),
--	stackIndex int  identity (1,1),
--	primary key(userID,trackID)
--)

select * from RecentlyPlayed where userID=8 order by stackIndex desc



select top 1 * from Track order by trackID desc

select top 8000  * from Track left join ArtistHasTrack on Track.trackID=ArtistHasTrack.trackID
left join Artist on ArtistHasTrack.artistID=Artist.artistID
order by Track.trackID desc;

select * from Artist where artistName like '%soob%'

select * from Account

--update Account 
--set DOB= (select convert(datetime, '29/12/2009', 103))
--where userID=15

select  * from Track where trackLink like '%nghe-album%'

select top 1* from AlbumHasTrack

select top 1000 * from Album
select * from Track where trackLink ='https://vi.chiasenhac.vn/mp3/5-dong-ke/canh-dong-tinh-yeu-tsvqr766qeatkk.html'

--delete from Track where trackLink like '%nghe-album%'

--delete from Track where trackID in( 
--select trackID from ArtistHasTrack join Track on ArtistHasTrack.trackID=Track.trackID where trackLink like '%nghe-album%')

--delete from ArtistHasTrack where ArtistHasTrack.trackID in
--(select temp.trackID from ArtistHasTrack join Track temp on ArtistHasTrack.trackID=temp.trackID where trackLink like '%nghe-album%')

select top 1000 * from Track order by trackID desc

select top 1000 * from AlbumHasTrack order by albumID desc




select top 1000 * from ArtistHasTrack order by trackID desc

select top 10 * from Album  order by albumID desc


select * from Account 

select * from Playlist

select * from Track where trackTitle like '%chung ta cua%'

--15 tifyadmin
--viet nam 87,88 US UK,89 Chinese, 90 Korea, 91 Japanese

select count(*) from PlaylistHasTrack where playlistID=89




select top 1 * from ArtistHasTrack
select * from Track where trackLink='https://vi.chiasenhac.vn/mp3/den-justatee/di-ve-nha-tsvm7cwsq8tv94.html'

select * from PlaylistHasTrack join Track on Track.trackID=PlaylistHasTrack.trackID
join Playlist on Playlist.playlistID=PlaylistHasTrack.playlistID
where playlistTitle ='108'

select * from Artist where spotifyID ='24Wn81dwdDeTCuB1BWGoVJ'

select * from MyMix



select * from UserHasMix where userID=8 order by myMixID desc

select * from UserFollowArtist where userID=14

select * from Playlist

select myMixID from MyMixHasTrack group by myMixID having count(*) <20

select * from MyMixHasTrack where myMixID=34

 /*
             delete from UserHasPlaylist where playlistID=50

delete From PlaylistHasTrack where playlistID=50

delete From Playlist where playlistID=50

 delete from UserHasMix where myMixID=5

delete From MyMixHasTrack where myMixID=5

delete From MyMix where myMixID=5
             */
			
			select _order from MyMix join UserHasMix on UserHasMix.myMixID=MyMix.myMixID Where userID=8 and MyMix.myMixID=16

		
select * from PlaylistHasTrack

/*
delete from Artist where artistID='https://chiasenhac.vn/ca-si/amee-zss7vbrwqt2qa9.html'



delete from ArtistHasTrack where artistID='https://chiasenhac.vn/ca-si/amee-zss7vbrwqt2qa9.html'
*/

create trigger default_name_Account
on Account
for insert
as
	Declare @userID int,@name nvarchar(50)

	select @userID=userID from inserted
	select @name=name from inserted

	if(@name is NULL)
	begin
	update Account
	set name='no name'
	where userID=@userID
	
	end
	

	select * from ArtistHasTrack where artistID='https://chiasenhac.vn/ca-si/le-bao-binh-zsswv00tq92nnf.html'