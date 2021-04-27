

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
