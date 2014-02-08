create table Utilizatori
(
ID numeric(6) Primary Key,
Username varchar(20) Unique,
Data_Inregistrarii date,
Parola varchar(20),
Email varchar(40),
victorii numeric(6),
infrangeri numeric(6),
scor numeric(6)
);
select * from utilizatori

drop table utilizatori

insert into Utilizatori
values (1,'catalin',getdate(),'catalin','catalin@c.com',0,0,0)
insert into Utilizatori
values (2,'sorin',getdate(),'sorin','sorin@c.com',0,0,0)
insert into Utilizatori
values (3,'alin',getdate(),'alin','alin@c.com',0,0,0)
insert into Utilizatori
values ((select max(id)+1 from utilizatori),'cristi',getdate(),'cristi','cristi@c.com',0,0,0)
insert into Utilizatori
values ((select max(id)+1 from utilizatori),'bogdan',getdate(),'bogdan','bogdan@c.com',0,0,0)

use master
create login usr with password = 'IPGame12'
create user usr from login usr
grant select to usr
grant exec to usr

select * from Utilizatori

create function dbo.UserLogin(@user varchar(20), @pass varchar(20))
returns table
as
return
(select count(username) Numar from Utilizatori where Username=@user and parola=@pass
)


drop function UserLogin


Select * from UserLogin('sorin','gigel')

create table Personaje
(
ID numeric(6) Primary Key,
Nume varchar(20),
Mof1 float(4),
Mof2 float(4),
Mof3 float(4),
Mdef1 float(4),
Mdef2 float(4),
Mdef3 float(4),
Lore varchar(255),
AdresaImagine varchar(255)
);

insert into personaje
values(1,'Robotix',1.2,1,0.8,1.2,1,0.8,null,null)
insert into personaje
values((select max(id)+1 from personaje),'Roboton',1,1.2,0.8,1,1.2,0.8,null,null)
insert into personaje
values((select max(id)+1 from personaje),'Agrobot',0.8,1.2,1,0.8,1.2,1,null,null)
select * from personaje

create table Istoric
(
ID numeric(10) Primary Key,
ID_Player1 numeric(6) Foreign Key References Utilizatori(ID),
ID_Personaj1 numeric(6) Foreign Key References Personaje(ID),
ID_Player2 numeric(6) Foreign Key References Utilizatori(ID),
ID_Personaj2 numeric(6) Foreign Key References Personaje(ID),
Winner numeric(1)
);

CREATE PROCEDURE newUser
@Username varchar(20),
@Parola varchar(20),
@Email varchar(40)
AS 
BEGIN 
insert into Utilizatori 
values((select max(id)+1 from utilizatori) ,@Username ,getdate() ,@Parola ,@Email ,0,0,0 )
  END 

  exec newuser 'gogu','samsung','gsamsung@gg.com'

Create Procedure UpdateUserData
@Username varchar(20),
@Parola varchar(20),
@email varchar(40)
as begin
update utilizatori set parola=@parola, email=@email where username=@username
end 

drop table istoric

create procedure EndOfGame
@user1 varchar(20),
@user2 varchar(20),
@char1 varchar(20),
@char2 varchar(20),
@winner numeric(2)
as begin
insert into istoric
values((select isnull(max(id),0)+1 from istoric),(select id from utilizatori where username=@user1),(select id from personaje where nume=@char1),(select id from utilizatori where username=@user2),(select id from personaje where nume=@char2),@winner)
if @winner=1 
begin
update utilizatori set scor=(select scor+5 from utilizatori where username=@user1), victorii=(select victorii+1 from utilizatori where username=@user1) where username=@user1
update utilizatori set scor=(select scor-2 from utilizatori where username=@user2), infrangeri=(select infrangeri+1 from utilizatori where username=@user2) where username=@user2
end
 else
 begin
 update utilizatori set scor=(select scor+5 from utilizatori where username=@user2), victorii=(select victorii+1 from utilizatori where username=@user2) where username=@user2
update utilizatori set scor=(select scor-2 from utilizatori where username=@user1), infrangeri=(select infrangeri+1 from utilizatori where username=@user1) where username=@user1
end
end

drop procedure endofgame
create function dbo.GetScore(@user varchar(20))
returns table
as
return
(select scor from Utilizatori where Username=@user
)

create function dbo.Getrank(@user varchar(20))
returns table
as
return
(select trueth from ranking where username=@user)


drop function dbo.getrank

select * from getrank('sorin')

create function Top10()
returns table
as 
return(

with gg as
(select rank() over (order by scor desc) as Rak, username, scor, row_number() over (order by scor desc) as r from utilizatori )
 select * from gg where r<11
 )
select * from top10()
drop function top10
--
--create function last10(@user varchar(20))
--returns table
--as 
--begin
--   declare @row numeric(6);
--return
--(	with his as(
--select rank() over (order by id) as r , row_number() over(order by id) as ro , id_player1, id_player2, winner from istoric where ID_Player1=(select id from utilizatori where username=@user) 
--or ID_Player2=(select id from utilizatori where username=@user))

--set @row=(select count(*) from his)
--select * from his where ro>@row-10
--)

drop function last10
--

create function UHist(@user varchar(20))
returns table
as
return
(with s1 as (select ID_player1,(select username from utilizatori u where u.ID=i.ID_player1 ) P1,ID_Player2,(select username from utilizatori u where u.ID=i.ID_player2) P2, winner  from istoric i)
select P1,P2,Winner from s1 where P1=@user or P2=@user
)

select * from UHist('sorin')
select * from personaje

create view Ranking
as select Username, Victorii, Infrangeri, scor, rank() over (order by scor desc) 'Rank', row_number() over (order by scor desc) 'trueth' from Utilizatori

select * from istoric
select * from utilizatori

select * from ranking where username='sorin'

drop view ranking

select * from top10()