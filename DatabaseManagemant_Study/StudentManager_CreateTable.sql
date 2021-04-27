create database StudentManager
go
-------------- BACK UP DATABASE --------
BACKUP DATABASE StudentManager TO disk = 'P:\StudentManagerBAK.bak'

use StudentManager
go
create table University (
ID char(4),
UNI_NAME nvarchar(50),
primary key (ID)
)
go
create table Department(
ID char(4),
DEP_NAME nvarchar(50),
UNI_ID char(4),
primary key (ID,UNI_ID)
)
go
create table Class(
ID char(4),
CLA_NAME nvarchar(50),
UNI_ID char(4),
DEP_ID char(4),
primary key (ID,UNI_ID,DEP_ID)
)
go
create table Student(
ID char(4),
STU_NAME nvarchar(50),
DATE_OF_BIRTH date,
CLA_ID char(4),
UNI_ID char(4),
DEP_ID char(4),
primary key (ID,UNI_ID)
)
go
ALTER TABLE Student ADD FOREIGN KEY(CLA_ID,UNI_ID,DEP_ID) REFERENCES Class (ID, UNI_ID,DEP_ID)
go
alter table Class add foreign key (DEP_ID,UNI_ID) references Department (ID,UNI_ID)
go
alter table Department add foreign key (UNI_ID) references University(ID)
go

	