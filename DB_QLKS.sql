create database QLKS
use QLKS
go

--Tạo table

set dateformat dmy;
create table KhachHang (
	ID_KH char(20) not null primary key,
	TenKH nvarchar(50),
	Gtinh nvarchar(10),
	Cmnd char(10),
	Dchi nvarchar(50),
	Qtich nvarchar(50),
	Sodt char(11),
	Email char(50),
	MatKhau nchar(10)
);

create table KieuPhong (
	MaKP char(20) not null primary key,
	TenKP nvarchar(50)
);

create table Phong (
	Maphong char(20) not null primary key,
	Tenphong nvarchar(50),
	Mota nvarchar(50),
	MaKP char(20),
	Gia int,
	TinhTrang int
)

create table HoaDonDatPhong (
	MaHDDP char(20) not null primary key,
	MaPDK char(20),
	NgayLap date
);



create table HoaDonDichVu(
	ID_HDDV char(20) not null primary key,
	ID_DV char(20),
	ID_KH char(20),
	NgayLap date
)


create table DichVu(
	ID_DV char(20) not null primary key,
	TenDV nvarchar(50),
	Gia int
)

create table Phieu_Thanh_Toan (
	MaPTT char(20) not null primary key,
	ID_KH char(20),
	TienThuePhong int,
	TienDichVu int,
	TongTien int,
	NgayThanhToan date,
	ID_NV char(20)
);


create table Phieu_Dang_Ky (
	MaPDK char(20) not null primary key,
	Ngayden date,
	Ngaydi date,
	Chuthich nvarchar(100),
	Maphong char(20),
	ID_KH char(20)
);

create table PhanQuyen (
	ID_Quyen char(20) not null primary key,
	TenQuyen nvarchar(20),
	CoQuyen bit,
);
create table TaiKhoan_NhanVien (
	ID_NV char(20) not null primary key,
	Email char(20),
	MatKhau char(20),
	ID_Quyen char(20),
);



create table NhanVien (
	ID_NV char(20) not null primary key,
	TenNV nvarchar(50),
	Gtinh nvarchar(10),
	Cmnd char(10),
	Dchi nvarchar(50),
	Sodt nchar(11),
);



--Tạo khóa ngoại



alter table TaiKhoan_NhanVien
add constraint FK_TKNV_NhanVien foreign key (ID_NV) references NhanVien(ID_NV);
alter table TaiKhoan_NhanVien
add constraint FK_TKNV_PhanQuyen foreign key (ID_Quyen) references PhanQuyen(ID_Quyen);


alter table Phieu_Dang_Ky
add constraint FK_PhieuDK_KhachHang foreign key (ID_KH) references KhachHang(ID_KH);

alter table Phieu_Dang_Ky
add constraint FK_PhieuDK_Phong foreign key (MaPhong) references Phong(MaPhong);


alter table HoaDonDichVu
add constraint FK_HoaDonDichVu_DichVu foreign key (ID_DV) references DichVu(ID_DV);
alter table HoaDonDichVu
add constraint FK_HoaDonDichVu_KhachHang foreign key (ID_KH) references KhachHang(ID_KH);

alter table Phong
add constraint FK_Phong_KieuPhong foreign key (MaKP) references KieuPhong(MaKP);
alter table HoaDonDatPhong
add constraint FK_HoaDonDatPhong_PhieuDK foreign key (MaPDK) references Phieu_Dang_Ky(MaPDK);

alter table Phieu_Thanh_Toan
add constraint FK_PhieuTT_KhachHang foreign key (ID_KH) references KhachHang(ID_KH);
alter table Phieu_Thanh_Toan
add constraint FK_PTT_NhanVien foreign key (ID_NV) references NhanVien(ID_NV);