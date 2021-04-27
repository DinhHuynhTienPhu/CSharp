

use StudentManager
go



------------update-------------
--chuyen lop sinh vien ma so 0016
update Student set CLA_ID='20C3' where Student.ID='0016'
go
---------add column create_date---------
alter table University add create_date date

alter table Department add create_date date

alter table Class add create_date date
go
