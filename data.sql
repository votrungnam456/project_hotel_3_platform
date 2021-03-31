--Nhập dữ liệu table Tài khoản nhân viên
INSERT INTO TaiKhoan_NhanVien
VALUES 
('NV001',N'Lê Thu Na',N'Tiếp tân','NV1','123456'),
('NV002',N'Đình Trọng Ta',N'Nhân viên phục vụ phòng','NV1','123456'),
('NV003',N'Trần Thị My Kha',N'Nhân viên quầy bar','NV2','123456'),
('NV004',N'Lê Trọng Văn Hoàng',N'Quản lý khu giặt','NV3','123456'),
('NV005',N'Phạm Thị Ngọc Lan',N'Quản lý đưa đón khách và spa','NV4','123456'),
('NV006',N'Lê Trọng Kêu',N'Nhân viên lái xe','NV5','123456'),
('NV007',N'Lê Trần Tina',N'Quản lý tổ chức tiệc cưới','NV6','123456'),
('NV008',N'Phạm Nguyễn Gia Huy',N'Quản lý phòng tập thể hình','NV7','123456'),
('NV009',N'Trần Thanh Bảo',N'Nhân viên bảo vệ','NV8','123456'),
('NV010',N'La Trọng Khiêm',N'Nhân viên bảo vệ','NV9','123456'),
('NV011',N'Quách Tuấn Du',N'Quản lý sân thể thao','NV10','123456')

--Nhập dữ liệu table dịch vụ
INSERT INTO Dichvu
VALUES 
('DV001',N'Spa',350000),
('DV002',N'Thuê xe ô tô',800000),
('DV003',N'Tổ chức tiệc cưới',10000000),
('DV004',N'Giặt đồ',60000),
('DV005',N'Xe đưa đón sân bay',1000000),
('DV006',N'Phòng tập thể hình',150000),
('DV007',N'Sân golf, tennis',150000)

--Nhập dữ liệu table khách hàng
SET DATEFORMAT DMY
INSERT INTO KhachHang
VALUES
('KH001',N'Vũ Thị Thuyên','24/11/1984',N'Nữ','11142','0552684421','vtthuyen@gmail.com','123456'),
('KH002',N'Lê Sỹ Minh','6/5/1986',N'Nam','11114','060992758','lsinh@gmail.com','123456'),
('KH003',N'Đỗ Mạnh Tuấn','6/9/1982',N'Nam','11118','0932558624','dmtuan@gmail.com','123456'),
('KH004',N'Nguyễn Phương Thảo','4/5/1985',N'Nữ','11115','0756883625','npthao@gmail.com','123456'),
('KH005',N'Lê Phương Linh','3/3/1989',N'Nữ','11255','0563448552','lplinh@gmail.com','123456'),
('KH006',N'Trần Hoàng Bảo','15/2/2000',N'Nam','20053','0693458552','thbao@gmail.com','123456'),
('KH007',N'Võ Phước Mạnh','10/8/1999',N'Nam','12555','0574156552','vpmanh@gmail.com','123456')

--Nhập dữ liệu table kiểu phòng
insert into KieuPhong values
('KP01','Đơn'),
('KP01V','Đơn VIP'),
('KP02','Đôi'),
('KP02V','Đôi VIP')