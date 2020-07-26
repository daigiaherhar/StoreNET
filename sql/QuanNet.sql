Create database QLNet
use QLNet

CREATE TABLE QuanLi
 (
	SoMay INT  Constraint PK_QuanLi Primary key(SoMay),
	TinhTrang nvarchar(30) NOT NULL,
	TenNguoiDung varchar(15),
	SoGio Time,
	SoTien float
	,GoiMon nvarchar(30)
 )
 Drop table QuanLi
  INSERT INTO QuanLi
 (
	SoMay,
	TinhTrang,
	TenNguoiDung,
	SoGio,
	SoTien
	,GoiMon
 ) 
 VALUES
	(1,N'Không hoạt động','',null,null,N'Chưa gọi')
	,(2,N'Không hoạt động','',null,null,N'Chưa gọi')
	,(3,N'Không hoạt động','',null,null,N'Chưa gọi')
	,(4,N'Không hoạt động','',null,null,N'Chưa gọi')
	,(5,N'Không hoạt động','',null,null,N'Chưa gọi')
	
	
	
Delete from QuanLi

 

  CREATE TABLE NguoiDung
 (
	id INT IDENTITY (1,1)Constraint PK_NguoiDung Primary key(id),
	TenNguoiDung varchar(15),
	MatKhau nvarchar(15),
	SoGio time,
	SoTien float
 )
 Drop table NguoiDung
  INSERT INTO NguoiDung
 (
	
	TenNguoiDung,
	MatKhau,
	SoGio,
	SoTien
 )
 VALUES
	('Tung','123','10:0:0',100000)
	,('Pro','456','5:0:0',50000)

Delete From NguoiDung

Create table DoAn5
(
	id INT IDENTITY (1,1)Constraint PK_DoAn Primary key(id),
	MonAn nvarchar(255),
	SoTien float
)
 Drop table DoAn
  INSERT INTO DoAn
 (
	
	MonAn,
	SoTien
 )
 VALUES
	(N'Mì xào trứng',13000)
	,(N'Mì xào mực',25000)
	,(N'Cơm net làm',20000)
	,(N'Cơm vui vẽ',25000)
	,(N'Mi u sầu',25000)
	,(N'Cơm chiên cá',30000)
	,(N'Mì cô dơn',15000)
	,(N'Mì dành cho FA',10000)
delete from DoAn

Create table DoUong
(
	id INT IDENTITY (1,1)Constraint PK_DoUong Primary key(id),
	MonAn nvarchar(255),
	SoTien float
)
 Drop table DoUong
 INSERT INTO DoUong
 (
	MonAn,
	SoTien
 )
 VALUES
	(N'Sting',13000)
	,(N'Coca co la ahii',5000)
	,(N'Trà đá',3000)
	,(N'Trà đường',5000)
	,(N'Trà không có đá',2000)
	,(N'Trà không có đường và đá',7000)
delete from DoUong
	Create table khachGoiDoAn
(
	id INT IDENTITY (1,1)Constraint PK_khachGoiDoAn Primary key(id),
	MonAn nvarchar(255),
	SoLuong varchar(255),
	SoTien float
)
drop table khachGoiDoAn

	Create table dangNhap
(
	id INT Constraint PK_dangNhap Primary key(id),
	TenNguoiDung varchar(15),
	SoGio time,
	SoTien float
	,GoiMon nvarchar(30)
)
delete from dangNhap

Create table Chat
(
	TK varchar(15),
	ThoiGian Time
	,NoiDung nvarchar(255)
)
