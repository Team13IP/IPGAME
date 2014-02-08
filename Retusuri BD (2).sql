select * from getrank('alin')

select * from getscore('sorin')

select * from personaje

insert into istoric
values(1,1,1,2,2,1)
insert into istoric
values(2,2,1,3,2,0)
select ID_player1,(select username from utilizatori u where u.ID=i.ID_player1 ) P1,ID_Player2,(select username from utilizatori u where u.ID=i.ID_player2) P2, winner  from istoric i

