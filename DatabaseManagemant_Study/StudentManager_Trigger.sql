
use StudentManager
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


	