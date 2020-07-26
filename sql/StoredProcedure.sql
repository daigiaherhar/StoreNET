/*quanli*/
Create procedure getQuanLi
  AS
	Select * From QuanLi
  Go
    Create procedure dangNhapNgDvaoQuanL(@aId int,@aTinhTrang nvarchar(30),@aTenNguoiDung varchar(15),@aSoGio time,@aSoTien float,@aGoiMon nvarchar(30))
  AS
	Update QuanLi
	Set
	SoMay =@aId,
	TinhTrang =@aTinhTrang,
	TenNguoiDung=@aTenNguoiDung,
	SoGio=@aSoGio,
	SoTien=@aSoTien
	,GoiMon=@aGoiMon
	Where SoMay=@aId
  Go

     Create procedure capnhatDangNhapNgDvaoQuanL(@aId int,@aTenNguoiDung varchar(15),@aSoGio time,@aSoTien float)
  AS
	Update QuanLi
	Set
	SoMay =@aId,
	TenNguoiDung=@aTenNguoiDung,
	SoGio=@aSoGio,
	SoTien=@aSoTien
	Where SoMay=@aId
  Go

      Create procedure themMay(@aSoMay INT,@aTinhTrang nvarchar(30) ,@aTenNguoiDung varchar(15),@aSoGio time,@aSoTien float,@aGoiMon nvarchar(30))
  AS
	Insert Into QuanLi(SoMay,TinhTrang,TenNguoiDung,SoGio,SoTien,GoiMon) Values(@aSoMay,@aTinhTrang,@aTenNguoiDung,@aSoGio,@aSoTien,@aGoiMon)
  Go

    Create procedure deleteMay(@aSoMay INT)
  As
	Delete from QuanLi where SoMay=@aSoMay
  Go
  exec deleteMay 26
  Create procedure userGoiMon(@aId int,@aGoi nvarchar(30))
  AS
	Update QuanLi
	Set
	GoiMon = @aGoi
	Where SoMay=@aId;		
  Go

     Create procedure iDQL(@aid int)
  AS
	select *from QuanLi Where SoMay=@aid
  Go
  
  /**/
 
   /*NguoiDung*/
Create procedure getTaiKhoan
  AS
	Select id,
	TenNguoiDung,
	SoGio,
	SoTien From NguoiDung
  Go

Create procedure capNhatTaiKhoan(@aId int ,@aSoGio time,@aSoTien float)
  AS
	Update NguoiDung
	set
	SoGio=@aSoGio,
	SoTien=@aSoTien
	Where id=@aId
  Go

	Create procedure themGioUser(@aid int,@aSoGio time,@aSoTien float)
	as 
		Update NguoiDung
	Set
	SoGio = @aSoGio,
	SoTien=@aSoTien
	Where id=@aid;
	Go

	exec themGioUser 7,'4:0',5000
  
  Create procedure getTaiKhoanUser
  AS
	Select * From NguoiDung
  Go
 

  Create procedure doiMKUser(@aid int,@aMatKhau nvarchar(15))
  As
	Update NguoiDung
	Set
	MatKhau = @aMatKhau
	Where id=@aid;
  Go


  Create procedure themTaiKhoan(@aTenNguoiDung varchar(15),@aMatKhau nvarchar(15),@aSoGio time,@aSoTien float)
  AS
	InSert into NguoiDung(TenNguoiDung,MatKhau,SoGio,SoTien) Values(@aTenNguoiDung,@aMatKhau,@aSoGio,@aSoTien)
  Go
  

  Create procedure xoaTaiKhoan(@aid int)
  AS
	Delete NguoiDung Where id=@aid
  Go
  Create procedure timKiemTaiKhoan(@aTenNguoiDung varchar(15))
  AS
	Select * From NguoiDung Where  TenNguoiDung like '%'+@aTenNguoiDung+'%' 
  Go
  
  /**/

  /*DoAn DoUong*/
  Create procedure getDoAn
  AS
	Select * From DoAn
  Go
  

    Create procedure getDoUong
  AS
	Select * From DoUong
  Go


  Create procedure UserGoiDoAnn(@aMonAn nvarchar(255),
	@aSoTien int)
	AS
		Insert into khachGoiDoAn(MonAn,SoTien) VALUES (@aMonAn,@aSoTien)
	Go

	Create procedure deleteUserGoiDoAnn(@aId int)
	as
	Delete khachGoiDoAn where id=@aId
	go



	Create procedure themDoAn(@aMonAn nvarchar(255),
	@aSoTien float)
	As
		INSERT INTO DoAn(MonAn,SoTien) Values(@aMonAn,@aSoTien)
	Go

	Create procedure themDoUong(@aMonAn nvarchar(255),@aSoTien float)
	AS
		INSERT INTO DoUong(MonAn,SoTien) Values(@aMonAn,@aSoTien)
	Go

	Create procedure deleteDoAn(@aId int,@aMonAn nvarchar(255))
	As
		Delete from DoAn Where id = @aId and MonAn = @aMonAn
	Go

	Create procedure deleteDoUong(@aId int,@aMonAn nvarchar(255))
	As
		Delete from DoUong Where id = @aId and MonAn = @aMonAn
	Go

		Create procedure updateDoAn(@aId int,@aMonAn nvarchar(255),@aSoTien float)
	As
		Update DoAn
		Set
		MonAn = @aMonAn,
		SoTien = @aSoTien
		Where id=@aId
	Go

	Create procedure updateDoUong(@aId int,@aMonAn nvarchar(255),@aSoTien float)
	As
		Update DoUong
		Set
		MonAn = @aMonAn,
		SoTien = @aSoTien
		Where id=@aId
	Go
	

	Create procedure listMonAnKhach
	AS
		Select * from khachGoiDoAn
	Go
	
	Create procedure inputMonAnKhach( @aMonAn nvarchar(255),@aSoLuong varchar(255),@aSoTien float)
	AS
		Insert Into khachGoiDoAn(MonAn,SoLuong,SoTien) values(@aMonAn,@aSoLuong,@aSoTien)
	Go
	
	Create procedure deleteListMonAnKhach
	AS
		Delete from khachGoiDoAn
	Go
	
  /*dangnhap*/
  Create procedure dangNhapVao(@aid int,@aTenNguoiDung varchar(15),@aSoGio time,@aSoTien float )
  AS
	INSERT INTO dangNhap(id,TenNguoiDung,SoGio ,SoTien) values(@aid,@aTenNguoiDung,@aSoGio,@aSoTien)
  Go

  CREATE PROCEDURE xoaDangNhap(@aid int)
  AS
	delete dangNhap Where id=@aid
  GO

  CREATE PROCEDURE xoaSachDangNhap
  AS
	delete from dangNhap 
  Go

  /*chat*/
  Create procedure chatList
  AS
	SELECT * FROM Chat
  Go

    Create procedure inputChatList(@aTenNguoiDung varchar(15),@aThoiGian time,@ANoiDung nvarchar(255))
  AS
	INSERT INTO Chat(tk,ThoiGian,NoiDung) values(@aTenNguoiDung,@aThoiGian,@ANoiDung)
  Go

    Create procedure clearChatList
  AS
	Delete  from Chat
  Go

