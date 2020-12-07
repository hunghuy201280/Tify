select * from Track where trackTitle like '%con mua ngang qua%'

select artistName from ArtistHasTrack join Artist on Artist.artistID=ArtistHasTrack.artistID where trackID=14

select top 20 * from (select *, ROW_NUMBER() OVER(PARTITION BY trackTitle ORDER BY trackID DESC) rn

from Track where trackTitle like '%bua yeu%') as temp
where rn=1

use Tify

select * from Artist
select * from Album

alter table Artist
add spotifyID nvarchar(200)

update Artist set spotifyID=null where artistName='2B'