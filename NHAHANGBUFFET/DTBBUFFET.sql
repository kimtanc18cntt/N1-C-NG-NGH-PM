
create database QuanLyNhaHang
go
use QuanLyNhaHang
Go
/*-------------------- Bảng nhân viên -------------------*/
create table NhanVien
(
	IdNhanVien varchar(10)primary key,
	HoTen nvarchar(100),
	ChucVu nvarchar(100),
	NgaySinh datetime,
	GioiTinh nvarchar(10),
	Dienthoai varchar(15),
	Email varchar(100),
	DiaChi nvarchar(100)

)
go
/*-------------------- hiển thị thông tin nhân viên -------------------*/

create procedure spgetNhanVien
as
Begin
	select *from Nhanvien
End
go
/*-------------------- hiển thị thông tin nhân viên bằng id nhân viên -------------------*/

create procedure spgetNhanVienByIdNhanVien
(
	@IdNhanVien varchar(50)
)
as
Begin
	select *from NhanVien where IdNhanVien=@IdNhanVien
End
go
/*-------------------- thêm mới bảng nhân viên -------------------*/
create procedure spInsertNhanVien
(
	@IdNhanVien varchar(10),
	@HoTen nvarchar(100),
	@ChucVu nvarchar(100),
	@NgaySinh datetime,
	@GioiTinh nvarchar(10),
	@Dienthoai varchar(15),
	@Email varchar(100),
	@DiaChi nvarchar(100)
)
as
Begin
	insert into NhanVien(IdNhanVien, HoTen, ChucVu, NgaySinh, GioiTinh, Dienthoai, Email, DiaChi)
	values(@IdNhanvien, @HoTen, @ChucVu, @NgaySinh, @GioiTinh, @Dienthoai, @Email, @DiaChi)
End
go
/*-------------------- cập nhập bảng nhân viên -------------------*/
create procedure spUpdateNhanVien
(
	@IdNhanVien varchar(10),
	@HoTen nvarchar(100),
	@ChucVu nvarchar(100),
	@NgaySinh datetime,
	@GioiTinh nvarchar(10),
	@Dienthoai varchar(15),
	@Email varchar(100),
	@DiaChi nvarchar(100)
)
as
Begin
	update NhanVien set
						HoTen = @HoTen,
						ChucVu = @ChucVu,
						NgaySinh = @NgaySinh, 
						GioiTinh = @GioiTinh,
						Dienthoai = @Dienthoai,
						Email = @Email,
						DiaChi = @DiaChi
			where IdNhanVien = @IdNhanVien
End
go
/*-------------------- Delete bảng nhân viên -------------------*/
create procedure spDeleteNhanVien
(
	@idNhanVien varchar (10)
)
as
Begin
	delete from NhanVien where IdNhanVien=@idNhanVien
End
go
/*-------------------- Tìm nhân viên theo tên NV -------------------*/
create procedure spSearchNVByTenNV
(
	@ChucVu nvarchar(100)
)
as
Begin
	select * from NhanVien where ChucVu like N'%'+@ChucVu+'%'
End
go
/*-------------------- Tìm nhân viên theo tên DD -------------------*/
create procedure spSearchNVByTenDayDu
(
	@HoTen nvarchar(100)
)
as
Begin
	select * from NhanVien where HoTen like N'%'+@HoTen+'%'
End
go
/*-------------------- Tìm nhân viên theo tên ID -------------------*/
create procedure spSearchNVByIdNV
(
	@IdNhanVien varchar(10)
)
as
Begin
	select * from NhanVien where IdNhanVien like N'%'+@IdNhanVien+'%'
End
go
/*-------------------- BẢNG KHU VỰC -------------------*/
Create table KhuVuc
(
	IdKhuVuc varchar(5) primary key,
	TenKhuVuc nvarchar(100),
	DienGiai nvarchar(100),
	TrangThai nvarchar(30),
	Constraint Unique_KhuVuc unique(TenKhuVuc)
)
GO
/*Hiển thị thông tin khu vực*/
create procedure spgetKhuVuc
as
Begin
	select * from KhuVuc
End
go

/*Hiển thị thông tin khu vực bang idkhuvuc*/

create procedure spgetKhuVucByIdKhuVuc
(
	@IdKhuVuc varchar(5)
)
as
Begin
	select * from KhuVuc where IdKhuVuc= @IdKhuVuc
End
go
/*-------------------- Thêm mới khu vực-------------------*/
create procedure spInsertKhuVuc
(
	@IdKhuVuc varchar(5),
	@TenKhuVuc nvarchar(100),
	@DienGiai nvarchar(100),
	@TrangThai nvarchar(30)
)
as
Begin
	insert into KhuVuc(IdKhuVuc, TenKhuVuc, DienGiai, TrangThai)
	values (@IdKhuVuc, @TenKhuVuc, @DienGiai, @TrangThai)
End
go
/*-------------------- update khu vực -------------------*/
create procedure spUpdateKhuVuc
(
	@IdKhuVuc varchar(5),
	@TenKhuVuc nvarchar(100),
	@DienGiai nvarchar(100),
	@TrangThai nvarchar(30)
)
as
Begin
	update KhuVuc set
						TenKhuVuc=@TenKhuVuc,
						DienGiai=@DienGiai,
						TrangThai=@TrangThai
			where IdKhuVuc=@IdKhuVuc
End
go
/*-------------------- delete khu vưc -------------------*/
create procedure spDeleteKhuVuc
(
	@IdKhuVuc    Varchar(5)
)
as
Begin
	delete KhuVuc where IdKhuVuc=@IdKhuVuc
End
go

/*Bang BÀN*/

create table Ban
(
	IdBan varchar(5) primary key,
	TenKhuVuc nvarchar(100) foreign key references KhuVuc(TenKhuVuc),
	TenBan nvarchar(100)unique,
	DienGiai nvarchar(100),
	TrangThai nvarchar(30),
	constraint Unique_Ban unique(TenBan) 
)
go
/* Hiển thị thông tin bàn */
create procedure spgetBan
as
Begin
	select IdBan, TenBan, TenKhuVuc, DienGiai, TrangThai from Ban
End
go 
/*-------------------- hiển thị thông thin bàn bằng id -------------------*/
create procedure spgetBanByIdBan
(
	@IdBan varchar(5)
)
as
Begin
	select * from Ban where IdBan = @IdBan
end
go
/*-------------------- thêm mới bàn -------------------*/
create procedure spInsertBan
(
	@IdBan varchar(5),
	@TenKhuVuc nvarchar(100),
	@TenBan nvarchar(100),
	@DienGiai nvarchar(100),
	@TrangThai nvarchar(30)
)
as
begin
	insert into Ban(IdBan,TenKhuVuc, TenBan, DienGiai, TrangThai)
	values(@IdBan, @TenKhuVuc, @TenBan, @DienGiai, @TrangThai)
End
go
/*--------------------update bàn -------------------*/
create procedure spUpdateBan
(
	@IdBan varchar(5),
	@TenKhuVuc nvarchar(100),
	@TenBan nvarchar(100),
	@DienGiai nvarchar(100),
	@TrangThai nvarchar(30)
)
as
begin
	Update Ban set
					TenKhuVuc = @TenKhuVuc,
					TenBan = @TenBan,
					DienGiai = @DienGiai,
					TrangThai = @TrangThai
			Where IdBan=@IdBan
	
End
go
/*-------------------- xóa bàn -------------------*/
create procedure spDeleteBan
(
	@IdBan varchar(5)
)
as
begin
	delete Ban where IdBan = @IdBan
end
go
/*-------------------- bang loại thưc đon -------------------*/
create table LoaiThucDon
(
	IdLoaiThucDon varchar(5) primary key,
	TenLoaiThucDon nvarchar(100)unique,
	DienGiai nvarchar(100),
	TrangThai nvarchar(30)
)
go
/*-------------------- hiển thị loại thực đơn -------------------*/
create procedure spgetLoaiThucDon
as
Begin
	select * from LoaiThucDon
End
go 
/*-------------------- hiển thị loại thực đôn băng id -------------------*/
create procedure spgetLoaiThucDonByIdLoaiThucDon
(
	@IdLoaiThucDon varchar(5)
)
as
Begin
	select * from LoaiThucDon where IdLoaiThucDon = @IdLoaiThucDon
end
go
/*-------------------- thêm mới loại thực đơn -------------------*/
create procedure spInsertLoaiThucDon
(
	@IdLoaiThucDon varchar(5),
	@TenLoaiThucDon nvarchar(100),
	@DienGiai nvarchar(100),
	@TrangThai nvarchar(30)
)
as
begin
	insert into LoaiThucDon(IdLoaiThucDon, TenLoaiThucDon, DienGiai, TrangThai)
	values(@IdLoaiThucDon, @TenLoaiThucDon, @DienGiai, @TrangThai)
End
go
/*-------------------- update loại thực đơn -------------------*/
create procedure spUpdateLoaiThucDon
(
	@IdLoaiThucDon varchar(5),
	@TenLoaiThucDon nvarchar(100),
	@DienGiai nvarchar(100),
	@TrangThai nvarchar(30)
)
as
begin
	Update LoaiThucDon set
					TenLoaiThucDon = @TenLoaiThucDon,
					DienGiai = @DienGiai,
					TrangThai = @TrangThai
			Where IdLoaiThucDon = @IdLoaiThucDon
	
End
go
/*-------------------- xóa loại thực đơn -------------------*/
create procedure spDeleteLoaiThucDon
(
	@IdLoaiThucDon varchar(5)
)
as
begin
	delete LoaiThucDon where IdLoaiThucDon=@IdLoaiThucDon
end
go

/*-------------------- Bảng thực đơn -------------------*/
create table ThucDon
(
	IdThucDon varchar(5) primary key,
	TenLoaiThucDon nvarchar(100)foreign key references LoaiThucDon(TenLoaiThucDon) ,
	TenThucDon nvarchar(100)unique,
	DonViTinh nvarchar(10),
	SoLuongTon float,
	DonGiaTon float,
	TonToiThieu float,
	TrangThai nvarchar(30)
)
go
/*-------------------- hiển thị bảng thực đơn -------------------*/
create procedure spgetThucDon
as
Begin
	select IdThucDon, TenLoaiThucDon, TenThucDon, DonViTinh, SoLuongTon,DonGiaTon, TonToiThieu,TrangThai
	from ThucDon
End
go 
/*-------------------- hiển thị bảng thực đơn theo id -------------------*/
create procedure spgetThucDonByIdThucDon
(
	@IdThucDon varchar(5)
)
as
Begin
	select * from ThucDon where IdThucDon = @IdThucDon
end
go
/*-------------------- thêm thực đơn -------------------*/
create procedure spInsertThucDon
(
	@IdThucDon varchar(5),
	@TenLoaiThucDon nvarchar(100) ,
	@TenThucDon nvarchar(100),
	@DonViTinh nvarchar(10),
	@SoLuongTon float,
	@DonGiaTon float,
	@TonToiThieu float,
	@TrangThai nvarchar(30)
)
as
begin
	insert into ThucDon(IdThucDon, TenLoaiThucDon, TenThucDon, DonViTinh, SoLuongTon, DonGiaTon, TonToiThieu,TrangThai)
	values(@IdThucDon, @TenLoaiThucDon, @TenThucDon, @DonViTinh, @SoLuongTon, @DonGiaTon, @TonToiThieu, @TrangThai )
End
go
/*-------------------- update thục đơn -------------------*/
create procedure spUpdateThucDon
(
	@IdThucDon varchar(5),
	@TenLoaiThucDon nvarchar(100) ,
	@TenThucDon nvarchar(100),
	@DonViTinh nvarchar(10),
	@SoLuongTon float,
	@DonGiaTon float,
	@TonToiThieu float,
	@TrangThai nvarchar(30)
)

as
begin
	Update ThucDon set
					TenLoaiThucDon = @TenLoaiThucDon,
					TenThucDon = @TenThucDon,
					DonViTinh= @DonViTinh,
					SoLuongTon = @SoLuongTon,
					DonGiaTon = @DonGiaTon,
					TonToiThieu = @TonToiThieu,
					TrangThai = @TrangThai
			Where IdThucDon = @IdThucDon
	
End
go
/*-------------------- xóa thực đơn -------------------*/
create procedure spDeleteThucDon
(
	@IdThucDon varchar(5)
)
as
begin
	delete ThucDon where IdThucDon=@IdThucDon
end
go


/*get ten khu vưc*/
create procedure spgetTenKhuVuc
as
Begin
	select TenKhuVuc from KhuVuc
end
go

/*get ten loai thuc don*/
create procedure spgetTenLoaiThucDon
as
Begin
	select TenLoaiThucDon from LoaiThucDon
end
go


 /*Khuyến mãi*/
 create table KhuyenMai
(
	IdKM varchar(5) primary key,
	NoiDung nvarchar(100),
	DienGiai nvarchar(100),
	DoiTuong nvarchar(30)
)
go 
/*-------------------- hiển thị khuyên mãi -------------------*/

create procedure spgetKhuyenMai
as
Begin
	select * from KhuyenMai
End
go 
/*-------------------- hiển thị khuyến mãi theo id-------------------*/
create procedure spgetKhuyenMaiByIdKM
(
	@IdKM varchar(5)
)
as
Begin
	select * from KhuyenMai where IdKM = @IdKM
end
go
/*-------------------- thêm mới khuyến mãi -------------------*/
create procedure spInsertKhuyenMai
(
	@IdKM varchar(5),
	@NoiDung nvarchar(100),
	@DienGiai nvarchar(100),
	@DoiTuong nvarchar(30)
)
as
begin
	insert into KhuyenMai(IdKM, NoiDung, DienGiai, DoiTuong)
	values(@IdKM, @NoiDung, @DienGiai, @DoiTuong)
End
go
/*-------------------- update khuyến mãi -------------------*/
create procedure spUpdateKhuyenMai
(
	@IdKM varchar(5),
	@NoiDung nvarchar(100),
	@DienGiai nvarchar(100),
	@DoiTuong nvarchar(30)
)
as
begin
	Update KhuyenMai set
					NoiDung = @NoiDung,
					DienGiai = @DienGiai,
					DoiTuong = @DoiTuong
			Where IdKM = @IdKM
	
End
go
/*-------------------- xóa khuyến mãi -------------------*/
create procedure spDeleteKhuyenMai
(
	@IdKM varchar(5)
)
as
begin
	delete KhuyenMai where IdKM=@IdKM
end
go
/*-------------------- bảng gọi món -------------------*/
create table GoiMon
(
	IdBan				varchar (5) foreign key references Ban(IdBan),
	IdThucDon			varchar(5) foreign key references ThucDon (IdThucDon),
	TenThucDon			nvarchar(100),
	DonGiaTon			decimal ,
	SoLuong				int,
	ThoiGian			datetime,
	ThanhTien			decimal
)
go
/*Get danh sach ban_ goimon*/
create procedure spgetDanhSachBan_GoiMon
as
Begin
	select DISTINCT b.IdBan as 'Id Bàn' , TenBan as 'Tên Bàn', TenKhuVuc as 'Tên Khu Vực', DienGiai as 'Diễn giải'
	from Ban b, GoiMon gm
	where b.IdBan=gm.IdBan
end
go

/*Get danh sach ban_ chu goi mon*/
create procedure spgetDanhSachBan_ChuaGoiMon
as
Begin
	select DISTINCT IdBan as 'Id Bàn' , TenBan as 'Tên Bàn', TenKhuVuc as 'Tên Khu Vực', DienGiai as 'Diễn giải'
	from Ban where IdBan not in (select IdBan from GoiMon)
	ORDER BY IdBAN, TenBan, TenKhuVuc, DienGiai
	
end
go
/*-------------------- hiển thị bảng gọi món -------------------*/
create procedure spgetGoiMon
as
Begin
	select IdBan, TenThucDon, DonGiaTon, SoLuong, ThoiGian, (SoLUONG * DonGiaTon) as ThanhTien
	from GoiMon
	ORDER BY IdBan
end
go
/*-------------------- hiển thị gọi món theo idban -------------------*/
create procedure spgetGoiMonByIdBan
(
	@IdBan	varchar (5)
)
as
begin
	select  IdBan as 'Id Bàn', TenThucDon as 'Tên Thực Đơn',DonGiaTon as 'Đơn Giá',SoLuong as 'Số Lượng ',ThoiGian as 'Thời Gian',(ThanhTien)as 'Thành Tiền'
	from GoiMon where IdBan = @IdBan
end
go
/*-------------------- thêm mới gọi món -------------------*/
Create procedure spInsertGoiMon
(
	@IdBan varchar(5),
	@TenThucDon nvarchar(100),
	@DonGiaTon decimal,
	@SoLuong int,
	@ThoiGian datetime,
	@ThanhTien decimal
)
as
begin
	insert into GoiMon(IdBan, TenThucDon, DonGiaTon, SoLuong,ThoiGian,ThanhTien)
	
	values (@IdBan, @TenThucDon, @DonGiaTon, @SoLuong, @ThoiGian, @SoLuong*@DonGiaTon)
end
go
/*-------------------- cập nhập gọi món -------------------*/
create procedure spUpdateGoiMon
(
	@IdBan varchar(5),
	@TenThucDon nvarchar(100),
	@DonGiaTon decimal,
	@SoLuong int,
	@ThoiGian datetime,
	@ThanhTien decimal
)
as
begin
		update GoiMon set
							TenThucDon = @TenThucDon,
							DonGiaTon = @DonGiaTon,
							SoLuong = @SoLuong,
							ThoiGian = @ThoiGian, 
							ThanhTien = @DonGiaTon*@SoLuong
			Where IdBan =@IdBan
end
go

/*-------------------- xóa gọi món -------------------*/
create procedure spDeleteGoiMon
(
	@IdBan varchar (5)
)
as
begin
	delete GoiMon where IdBan = @IdBan
end
go
/*-------------------- set tên thực đơn -------------------*/
create procedure spgetTenThucDon
as
begin
	select TenThucDon from ThucDon
end
go
/*-------------------- lấy tên thục đơn-------------------*/
create procedure spgetThucDonNotTTT
as
Begin
	select IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TrangThai	
	from ThucDon
End
Go
 /*-- BANG KHACH HANG -- */
create table KhachHang
(
		IdKhachHang				varchar(10)primary key,
		TenKhachHang			nvarchar(100),
		DienThoai				varchar(15),
		Email					varchar(100),
		DiaChi					nvarchar(100),
		Dacquyen				nvarchar(100)
)
 go
 /*-- BANG KHACH HANG -- */
						
/*--------- Hien thi thong tin KhachHang ----------------*/
create procedure spgetKhachHang
as
Begin
	select IdKhachHang, TenKhachHang,  DienThoai, Email,DiaChi,Dacquyen
	from Khachhang
End
go
/*----------- Hien thi thong tin KhachHang bang IdKhachHang --------------*/
create procedure spgetKhachHangByIdKhachHang
(
	@IdKhachHang		varchar (10)
)
as
begin
	select * from Khachhang where IdKhachHang = @IdKhachHang
end
go
/*---------------- Insert KhachHang -------------------*/
create procedure spInsertKhachHang
( 
		@IdKhachHang			varchar(10),
		@TenKhachHang			nvarchar(100),
		@DienThoai				varchar(15),
		@Email					varchar(100),
		@DiaChi					nvarchar(100),
		@Dacquyen				nvarchar(100)
)
as
Begin
	insert into KhachHang(IdKhachHang, TenKhachHang, DienThoai, Email, DiaChi, Dacquyen)
	values(@IdKhachHang, @TenKhachHang, @DienThoai, @Email, @DiaChi, @Dacquyen)
End
Go



/*---------------- Update KhachHang -----------------*/
create procedure spUpdateKhachHang
(
		@IdKhachHang			varchar(10),
		@TenKhachHang			nvarchar(100),
		@DienThoai				varchar(15),
		@Email					varchar(100),
		@DiaChi					nvarchar(100),
		@Dacquyen				nvarchar(100)
)
as
Begin
	update Khachhang set 
						TenKhachHang = @TenKhachHang,
						DienThoai =@DienThoai,
						Email	=@Email,
						DiaChi	=@DiaChi,
						Dacquyen = @Dacquyen
											 
		where IdKhachHang =@IdKhachHang
End
Go
/*-------------------- Delete KhachHang -------------------*/
create procedure spDeleteKhachHang
(
	@IdKhachHang		varchar(10)
)
as
begin
	delete Khachhang where IdKhachHang = @IdKhachHang
end
go
/* Bảng thu chi*/
create table ThuChi
(
		IdThuChi				varchar(10)primary key,
		TenThuChi			nvarchar(100),
		Ngay			datetime,
		Thu					float,
		Chi					float,
)
go
/*--------- Hien thi thong tin Thu chi ----------------*/
create procedure spgetThuChi
as
Begin
	select IdThuChi, TenThuChi,  Ngay, Thu,Chi
	from ThuChi
End
go
/*----------- Hien thi thong tin thu chi bang Idthuchi --------------*/
create procedure spgetThuChiByIdThuChi
(
	@IdThuChi		varchar (10)
)
as
begin
	select * from ThuChi where IdThuChi = @IdThuChi
end
go
/*---------------- Insert thuchi -------------------*/
create procedure spInsertThuChi
( 	
		@IdThuChi				varchar(10),
		@TenThuChi			nvarchar(100),
		@Ngay				datetime,
		@Thu					float,
		@Chi					float
)
as
Begin
	insert into ThuChi(IdThuChi, TenThuChi, Ngay, Thu, Chi)
	values(@IdThuChi, @TenThuChi,@Ngay, @Thu,@Chi)
End
Go



/*---------------- Update ThuCHI -----------------*/
create procedure spUpdateThuChi
(
		@IdThuChi				varchar(10),
		@TenThuChi			nvarchar(100),
		@Ngay				datetime,
		@Thu					float,
		@Chi					float
)
as
Begin
	update ThuChi set 
						TenThuChi = @TenThuChi,
						Ngay = @Ngay,
						Thu = @Thu,
						chi = @Chi
											 
		where IdThuChi= @IdThuChi
End
Go
/*-------------------- Delete thu chi -------------------*/
create procedure spDeleteThuChi
(
	@IdThuChi		varchar(10)
)
as
begin
	delete ThuChi where IdThuChi = @IdThuChi
end
 GO
 create table Taikhoan
(
	IdDangNhap varchar(100) primary key,
	MatKhau varchar(100),
)
insert into Taikhoan values ('kimtan','kimtan')
	Go
create procedure Dangky
(
	@IdDangNhap varchar(100),
	@MatKhau Varchar(100)

)
as
Begin
	insert into Taikhoan(IdDangNhap, MatKhau)
	values(@IdDangNhap, @MatKhau)
End

 Go 