

use StudentManager

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
	