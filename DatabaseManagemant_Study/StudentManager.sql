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
------------add values-----------
insert into University values ('KHTN',N'Khoa học tự nhiên')
insert into University values ('UIT',N'Công nghệ thông tin')
insert into University values ('UEL',N'Kinh tế luật')
go
insert into Department values ('C01',N'Công nghệ thông tin','UIT')
insert into Department values ('T01',N'Trí tuệ nhân tạo','UIT')
insert into Department values ('A01',N'An toàn thông tin','UIT')
insert into Department values ('HTMT',N'Hệ thống máy tính','KHTN')
insert into Department values ('ATTT',N'An toàn thông tin','KHTN')
insert into Department values ('CNTT',N'Công nghệ thông tin','KHTN')
go

insert into Class values ('19C1',N'Lớp cntt 1 khóa 19','KHTN','CNTT')
insert into Class values ('19C2',N'Lớp cntt 2 khóa 19','KHTN','CNTT')
insert into Class values ('19C3',N'Lớp cntt 3 khóa 19','KHTN','CNTT')
insert into Class values ('19C4',N'Lớp cntt 4 khóa 19','KHTN','CNTT')
insert into Class values ('20C1',N'Lớp cntt 1 khóa 20','KHTN','CNTT')
insert into Class values ('20C2',N'Lớp cntt 2 khóa 20','KHTN','CNTT')
insert into Class values ('20C3',N'Lớp cntt 3 khóa 20','KHTN','CNTT')
insert into Class values ('20C4',N'Lớp cntt 4 khóa 20','KHTN','CNTT')
insert into Class values ('19A1',N'Lớp attt 1 khóa 19','KHTN','ATTT')
insert into Class values ('1C19',N'Lớp cntt 1 khóa 19','UIT','C01')
insert into Class values ('2C20',N'Lớp cntt 2 khóa 20','UIT','C01')
insert into Class values ('1T00',N'Lớp trí tuệ nhân tạo','UIT','T01')
go
insert into Student values ('0001',N'Nguyễn Văn A','1/1/2001','19C1','KHTN','CNTT')
insert into Student values ('0002',N'Nguyễn Văn B','1/1/2001','19C1','KHTN','CNTT')
insert into Student values ('0003',N'Nguyễn Văn C','1/1/2001','19C1','KHTN','CNTT')
insert into Student values ('0004',N'Nguyễn Văn D','1/1/2001','19C1','KHTN','CNTT')
insert into Student values ('0005',N'Nguyễn Văn E','1/1/2001','19C2','KHTN','CNTT')
insert into Student values ('0006',N'Nguyễn Văn F','1/1/2001','19C2','KHTN','CNTT')
insert into Student values ('0007',N'Nguyễn Văn G','1/1/2001','19C2','KHTN','CNTT')
insert into Student values ('0008',N'Nguyễn Văn H','1/1/2001','19C2','KHTN','CNTT')
insert into Student values ('0009',N'Nguyễn Văn I','1/1/2001','19C3','KHTN','CNTT')
insert into Student values ('0010',N'Nguyễn Văn J','1/1/2001','19C4','KHTN','CNTT')
insert into Student values ('0011',N'Nguyễn Văn K','1/1/2001','19C4','KHTN','CNTT')
insert into Student values ('0012',N'Nguyễn Văn L','1/1/2001','19A1','KHTN','ATTT')
insert into Student values ('0013',N'Nguyễn Văn M','1/1/2001','19A1','KHTN','ATTT')
insert into Student values ('0014',N'Nguyễn Văn N','1/1/2001','19A1','KHTN','ATTT')
insert into Student values ('0015',N'Nguyễn Văn O','1/1/2001','20C1','KHTN','CNTT')
insert into Student values ('0016',N'Nguyễn Văn P','1/1/2001','20C1','KHTN','CNTT')
insert into Student values ('0017',N'Nguyễn Văn Q','1/1/2001','20C2','KHTN','CNTT')
insert into Student values ('0018',N'Nguyễn Văn R','1/1/2001','20C3','KHTN','CNTT')
insert into Student values ('0019',N'Nguyễn Văn S','1/1/2001','1C19','UIT','C01')
insert into Student values ('0020',N'Nguyễn Văn T','1/1/2001','1C19','UIT','C01')
insert into Student values ('0021',N'Nguyễn Văn U','1/1/2001','1C19','UIT','C01')
insert into Student values ('0022',N'Nguyễn Văn V','1/1/2001','1C19','UIT','C01')
insert into Student values ('0023',N'Nguyễn Văn X','1/1/2001','1C19','UIT','C01')
insert into Student values ('0024',N'Nguyễn Văn Y','1/1/2001','1C19','UIT','C01')
go
---------add column create_date---------
alter table University add create_date date

alter table Department add create_date date

alter table Class add create_date date
go

------select where-----

--thong tin cac sinh vien hoc lop 1c19
select Student.*
from Student
where Student.CLA_ID='1C19'
---thong tin cac sinh vien truong khoa hoc tu nhien hoc khoa cntt
select Student.*
from Student,University
where Student.UNI_ID=University.ID and University.UNI_NAME=N'Khoa học tự nhiên'and Student.DEP_ID='CNTT'
--- ten cac sinh vien va ten lop tuong ung
select Student.STU_NAME,Class.CLA_NAME
from Student,Class
where Student.CLA_ID=Class.ID
go

------------update-------------
--chuyen lop sinh vien ma so 0016
update Student set CLA_ID='20C3' where Student.ID='0016'
go

----------define procedure----------

create procedure GetAllStudent
as
select* from Student

go
---sua ngay sinh dong loat  tat ca hoc sinh
create procedure ResetDateOfBirth
@day date ='1/1/2001'
as 
update Student set DATE_OF_BIRTH=@day 

go
---------set trigger---------

---'Không được thêm sinh viên sinh trước năm 1990 hay sau năm 2003'
create trigger Student_AbortInsert on Student
for insert
as
begin
	declare @count int =0

	select @count = count(*) from inserted where (YEAR(DATE_OF_BIRTH)<1990 or year(DATE_OF_BIRTH)>2003)
	if(@count>0)
	begin
		print N'Không được thêm sinh viên sinh trước năm 1990 hay sau năm 2003'
		rollback tran
	end
end
go
--test
insert into Student values ('0025',N'Nguyễn Văn X','1/1/2005','1C19','UIT','C01')
go


---khong duoc xoa sinh vien truong uit hay khtn
create trigger Student_AbortDelete on Student
for delete
as
begin 
	declare @count int =0
	select @count= count(*) from deleted where  (UNI_ID='KHTN' or UNI_ID='UIT')
	if(@count>0)
		begin
			print N'Khong duoc xoa cac sinh vien nay'
			rollback tran
		end
end
go
--test
DELETE FROM Student WHERE Student.UNI_ID='KHTN';
go

create trigger Student_AbortUpdate on Student
for update
as
begin
	declare @count int =0
	select @count = count(*) from inserted where (YEAR(DATE_OF_BIRTH)<1990 or year(DATE_OF_BIRTH)>2003)	
	if(@count>0)
	begin
			print N'Khong duoc update ngay sinh sinh vien nam sinh <1990 hay >2003 '
			rollback tran
	end
end
go
--test
 update Student set DATE_OF_BIRTH='1/1/1880' where ID='0001'

---------Indexes--------
create index UniversityIndex on University(ID)
go
create index DepartmentIndex on Department(ID)
go
create index ClassIndex on Class(ID)
go
create index StudentIndex on Student(ID)

	