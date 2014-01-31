create database joc
use joc
create table Utilizatori
(
ID numeric(6) Primary Key,
Username varchar(20),
Data_Inregistrarii date,
Parola varchar(20),
Email varchar(40),
scor numeric(6)
);

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

create table Istoric
(
ID numeric(10) Primary Key,
ID_Player1 numeric(6) Foreign Key References Utilizatori(ID),
ID_Personaj1 numeric(6) Foreign Key References Personaje(ID),
ID_Player2 numeric(6) Foreign Key References Utilizatori(ID),
ID_Personaj2 numeric(6) Foreign Key References Personaje(ID),
Winner varchar(10)
);

create view rank as
select username , scor from Utilizatori 

select * from rank
order by scor desc

insert into Utilizatori(id,username , rang)
values (1,'catalin','12500')
insert into Utilizatori(id,username , rang)
values (2,'sorin','2500')
insert into Utilizatori(id,username , rang)
values (3,'alin','34500')


create login alin with password = 'Proiect1'
create user alin from login alin



