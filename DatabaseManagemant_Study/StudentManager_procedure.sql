
use StudentManager
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
	