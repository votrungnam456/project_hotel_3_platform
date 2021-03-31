use QLKS
go

--Tạo table
create table THONG_TIN_KS (
	TenKS nvarchar(20) not null primary key,
	Dchi nvarchar(50),
	Tphho nvarchar(20),
	Qgia nvarchar(20),
	Sodt nchar(11),
	Email nchar(10),
	Website nchar(10)
);

set dateformat dmy;
create table KhachHang (
	MaKH nchar(10) not null primary key,
	TenKH nvarchar(20),
	Gtinh nvarchar(10),
	Cmnd nchar(10),
	Dchi nvarchar(20),
	Qtich nvarchar(20),
	Sodt nchar(11),
	Email nchar(10)
);

create table KieuPhong (
	MaKP nchar(10) not null primary key,
	TenKP nvarchar(20)
);

create table Phong (
	Maphong nchar(10) not null primary key,
	Tenphong nvarchar(20),
	Mota nvarchar(50),
	MaKP nchar(10),
	MaLP nchar(10),
	Trangthai nchar(2)
);

create table Dichvu (
	MaDV nchar(10) not null primary key,
	TenDV nvarchar(20),
	GiaDV float
);

create table Hoadon (
	MaHD nchar(10) not null primary key,
	TenKhaiThue nvarchar(20),
	Masothue nchar(10),
	DchiKhaiThue nvarchar(50),
	MaPTT nchar(10)
);

create table Phieu_Thanh_Toan (
	MaPTT nchar(10) not null primary key,
	SoNgay int,
	Ngaythanhtoan date,
	ThueVAT nchar(10),
	TongTien float,
	Tienphaitra float,
	MaPDK nchar(10)
);

create table Phieu_Dang_Ky (
	MaPDK nchar(10) not null primary key,
	Ngayden date,
	Ngaydi date,
	TreEm int,
	NguoiLon int,
	Tratruoc nchar(10),
	Chuthich nvarchar(100),
	Maphong nchar(10),
	MaDV nchar(10),
	MaKH nchar(10)
);

set dateformat dmy;
create table TaiKhoan_NhanVien (
	ID_NV nchar(10) not null primary key,
	HoTen_NV nvarchar(50),
	ChucVu nchar(10),
	TenTK nchar(10),
	MatKhau nchar(10)
);


--Tạo khóa ngoại
alter table Phong
add constraint FK_Phong_KieuPhong foreign key (MaKP) references KieuPhong(MaKP)

alter table Phong
add constraint FK_Phong_LoaiPhong foreign key (MaLP) references LoaiPhong(MaLP)

alter table HoaDon
add constraint FK_HoaDon_PhieuTT foreign key (MaPTT) references Phieu_Thanh_Toan(MaPTT)

alter table Phieu_Thanh_Toan
add constraint FK_PhieuTT_PhieuDK foreign key (MaPTT) references Phieu_Dang_Ky(MaPDK);

alter table Phieu_Dang_Ky
add constraint FK_PhieuDK_DichVu foreign key (MaDV) references Dichvu(MaDV);
alter table Phieu_Dang_Ky
add constraint FK_PhieuDK_KhachHang foreign key (MaKH) references KhachHang(MaKH);
alter table Phieu_Dang_Ky
add constraint FK_PhieuDK_Phong foreign key (MaPhong) references Phong(MaPhong);