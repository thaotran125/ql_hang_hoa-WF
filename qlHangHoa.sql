create database QLHANGHOA
use QLHANGHOA

Create table [HANGHOA]
(
	[MAHH] varchar(10) CONSTRAINT PK_HH primary key(MAHH),
	[TENHH] Nvarchar(50) NULL,
	[DVT] Nvarchar(10) NULL,
	[DONGIA] Decimal(18,0) NULL,
) 

go

Create table [KHACHHANG]
(
	[MAKH] varchar(10) constraint pk_KH primary key(MAKH),
	[TENKH] Nvarchar(50) NULL,
	[DIACHI] Nvarchar(50) NULL,
	[DIENTHOAI] Varchar(11) NULL,
) 

go

Create table [XUATNHAP]
(
	[SOPHIEU] varchar(10) constraint pk_XN primary key(SOPHIEU),
	[LOAI] Varchar(5) NULL,
	[NGAY] Datetime NULL,
	[MAKH] varchar(10) NOT NULL,
	constraint fk_kh foreign key (MAKH) REFERENCES [KHACHHANG](MAKH)
) 
go

Create table [CTPHIEUXUAT]
(
	[MAHH] varchar(10) NOT NULL,
	[SOPHIEU] varchar(10) NOT NULL,
	[SL] Integer NULL,
constraint pk_CTPX Primary Key ([MAHH],[SOPHIEU])
) 
go
alter table CTPHIEUXUAT
add constraint fk_mahh FOREIGN KEY ([MAHH]) REFERENCES HANGHOA(MAHH)
alter table CTPHIEUXUAT
add constraint fk_SP FOREIGN KEY ([SOPHIEU]) REFERENCES XUATNHAP(SOPHIEU)

INSERT INTO HANGHOA VALUES ('001',N'Sữa Bột Cô Gái Hà Lan Lon 900gr',N'Lon',113000)
INSERT INTO HANGHOA VALUES ('002',N'Sữa Tươi VINAMILK',N'Lốc',18500)
INSERT INTO HANGHOA VALUES ('003',N'Sữa Đặc Có Đường Ông Thọ',N'Hộp',6300)
INSERT INTO HANGHOA VALUES ('004',N'Đường Cát Biên Hòa',N'Kg',122000)
INSERT INTO HANGHOA VALUES ('005',N'Sữa Chua YOUR MOST',N'Lốc',250000)
INSERT INTO HANGHOA VALUES ('006',N'Kẹo Sữa',N'Bịch',350000)
INSERT INTO HANGHOA VALUES ('007',N'Sữa Bột Hộp Giấy 500gr',N'Hộp',750000)
INSERT INTO HANGHOA VALUES ('008',N'Trà Sữa',N'Ly',8000)
INSERT INTO HANGHOA VALUES ('009',N'Trà SỮa Dâu',N'Ly',9000)
-------------------
insert into KHACHHANG values('KH01',N'Cửa Hàng Báo Đen',N'181 Phan Đăng Lưu, Phú Nhuận','083990000')
insert into KHACHHANG values('KH02',N'Đại lý Hoa Hòng',N'8 CMNT, quận 3','083589598')
insert into KHACHHANG values('KH03',N'Cửa Hàng Tạp Hóa ABC',N'99 Điện Biên Phủ, quận 3','083698514')
---------------
insert into XUATNHAP values('N001','N','3/18/2019','KH03')
insert into XUATNHAP values('X001','X','3/14/2019','KH02')
insert into XUATNHAP values('X002','X','4/22/2019','KH02')
insert into XUATNHAP values('X003','X','3/10/2019','KH01')
insert into XUATNHAP values('X004','X','3/17/2019','KH01')
-------------------------
INSERT INTO CTPHIEUXUAT VALUES('001','N001',5)
INSERT INTO CTPHIEUXUAT VALUES('004','x002',6)
INSERT INTO CTPHIEUXUAT VALUES('002','x004',30)
INSERT INTO CTPHIEUXUAT VALUES('003','x004',50)
INSERT INTO CTPHIEUXUAT VALUES('004','x004',45)
INSERT INTO CTPHIEUXUAT VALUES('005','x004',20)
-----
INSERT INTO CTPHIEUXUAT VALUES('005','x001',20)
INSERT INTO CTPHIEUXUAT VALUES('002','x003',20)

select MAKH, TENKH from KHACHHANG

create table account(
tenuser nvarchar(50) ,
tenlogin varchar(50) constraint pk_name primary key (tenlogin),
pass varchar(20),
confirm varchar(20),
quyen varchar(10),
)
insert into account values (N'trần văn a','user1','123','123','user')
insert into account values (N'ng thi b','admin1','456','456','admin')

go
create proc acc (@ten varchar(10), @pass varchar(10))
as begin
select * from account where tenlogin=@ten and pass=@pass
end
exec acc 'user1','123'

--=======XUAT NHAP=================
go
create proc insertXN
(@idsp varchar(10), @loai varchar(5), @ngay datetime, @idkh varchar(10))
as
	insert into XUATNHAP values(@idsp,@loai,@ngay,@idkh)

	exec insertXN 'X005','X','3/27/2019','KH01'

	select * from XUATNHAP
	select * from CTPHIEUXUAT

go
create proc deleteXN (@idsp varchar(10))
as
begin
	if exists (select SOPHIEU from CTPHIEUXUAT where SOPHIEU=@idsp)
	begin
		delete CTPHIEUXUAT where SOPHIEU=@idsp
		delete XUATNHAP where SOPHIEU=@idsp
	end
	else delete XUATNHAP where SOPHIEU=@idsp
end

exec deleteXN 'X002'

go
create proc selectXN
as
select SOPHIEU, TENKH, LOAI, NGAY
from KHACHHANG, XUATNHAP
where KHACHHANG.MAKH=XUATNHAP.MAKH
go
create proc updateXN (@id varchar(10), @loai varchar(5), @ngay datetime, @makh varchar(10))
as
begin
	update XUATNHAP
	set LOAI=@loai, NGAY=@ngay, MAKH=@makh
	where SOPHIEU=@id
end
exec updateXN 'N001', 'N', '03/15/2020', 'KH01'
select * from XUATNHAP
--================CTPX==============
go
create proc updateCTPX (@idhh varchar(10), @idpx varchar(10), @sl int)
as
begin
update CTPHIEUXUAT
set SL=@sl
where MAHH=@idhh and SOPHIEU=@idpx
end

exec updateCTPX '001','N001',10
select * from CTPHIEUXUAT

GO
create proc deleteCTPX (@idhh varchar(10), @idpx varchar(10))as
begin
delete CTPHIEUXUAT
where MAHH=@idhh and SOPHIEU=@idpx
end
exec deleteCTPX '009','X005'
--=================================KHACH HANG-===============
go
create proc insertKH
(@id varchar(10), @ten nvarchar(50), @dc nvarchar(50), @dt varchar(11))
as
begin
	insert into KHACHHANG values(@id,@ten,@dc,@dt)
end
exec insertKH 'KH04',N'Cửa Hàng Tạp Hóa ABC',N'99 Điện Biên Phủ, quận 3','083698514'
select * from KHACHHANG

go


go
create proc updateKH
(@id varchar(10), @ten nvarchar(50), @dc nvarchar(50), @dt varchar(11))
as
begin
	update KHACHHANG
	set TENKH=@ten, DIACHI=@dc, DIENTHOAI=@dt
	where MAKH=@id
end
go

create proc rpHnagHoa
as
select * from HANGHOA

exec rpHnagHoa

create function sumin
(@ngaybd date, @ngaykt date)
returns int
as begin
declare @sumin int
	 if not exists(select MAHH from XUATNHAP, CTPHIEUXUAT
	 where XUATNHAP.SOPHIEU=CTPHIEUXUAT.SOPHIEU and XUATNHAP.SOPHIEU like 'N%' and  NGAY between @ngaybd and @ngaykt) 
		set @sumin=0
	else
	begin
		 set @sumin=select sum(SL) as [tong so luong]  from CTPHIEUXUAT, XUATNHAP 
where XUATNHAP.SOPHIEU=CTPHIEUXUAT.SOPHIEU and XUATNHAP.SOPHIEU like 'x%' and  NGAY between '03/01/2019' and '04/01/2019' 
	end
	return @sumin
end
go
select MAHH, XUATNHAP.SOPHIEU, NGAY from CTPHIEUXUAT, XUATNHAP 
where XUATNHAP.SOPHIEU=CTPHIEUXUAT.SOPHIEU and XUATNHAP.SOPHIEU like 'x%' and  NGAY between '03/01/2019' and '04/01/2019' 

select MAHH,  sum(SL) as [tong so luong]  from CTPHIEUXUAT, XUATNHAP 
where XUATNHAP.SOPHIEU=CTPHIEUXUAT.SOPHIEU and XUATNHAP.SOPHIEU like 'x%' and  NGAY between '03/01/2019' and '04/01/2019' 
group by MAHH

go
alter proc reportHH (@ngaybd date, @ngaykt date)
as begin
select HANGHOA.MAHH, TENHH, LOAI, sum(SL) as SL  from CTPHIEUXUAT, XUATNHAP, HANGHOA
where XUATNHAP.SOPHIEU=CTPHIEUXUAT.SOPHIEU  and HANGHOA.MAHH=CTPHIEUXUAT.MAHH and  NGAY between @ngaybd and @ngaykt
group by HANGHOA.MAHH, TENHH, LOAI
end
exec reportHH '03/01/2019', '04/01/2019'

GO
alter proc reporthangHoa (@ngaybd date, @ngaykt date)
as begin
select TENHH, LOAI, NGAY, SL
from HANGHOA, XUATNHAP, CTPHIEUXUAT
where HANGHOA.MAHH=CTPHIEUXUAT.MAHH and CTPHIEUXUAT.SOPHIEU=XUATNHAP.SOPHIEU and  NGAY between @ngaybd and @ngaykt
end
exec reporthangHoa '03/01/2019', '04/01/2019'
exec reporthangHoa '12/7/2020 11:05:37 AM', '12/7/2020 11:05:37 AM'
