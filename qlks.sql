-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 29, 2021 at 07:56 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `qlks`
--

-- --------------------------------------------------------

--
-- Table structure for table `dichvu`
--

CREATE TABLE `dichvu` (
  `ID_DV` char(50) NOT NULL,
  `TenDV` varchar(50) DEFAULT NULL,
  `Gia` int(11) DEFAULT NULL,
  `Enable` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `dichvu`
--

INSERT INTO `dichvu` (`ID_DV`, `TenDV`, `Gia`, `Enable`) VALUES
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', 'Dịch vụ đặt taxi', 25000, 1),
('26573b47-8af6-4047-8e6e-d8da984c3fb7', 'Ăn Sáng', 50000, 1),
('3561fc18-0136-4502-a9ce-3fdf157414f4', 'Dịch vụ karaoke', 100000, 0),
('71010692-ac69-49f3-8619-cad583acaaad', 'Dịch vụ đặt vé máy bay, tour du lịch', 20000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `hoadondichvu`
--

CREATE TABLE `hoadondichvu` (
  `ID_DV` char(50) NOT NULL,
  `MaPDK` char(50) NOT NULL,
  `NgayLap` date DEFAULT NULL,
  `GiaDichVu` int(11) NOT NULL,
  `IDHDDV` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `hoadondichvu`
--

INSERT INTO `hoadondichvu` (`ID_DV`, `MaPDK`, `NgayLap`, `GiaDichVu`, `IDHDDV`) VALUES
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', 'bab699ac-d953-4e95-9ad8-4bf90181acd6', '2021-05-21', 20000, '72bebad7-6233-4d85-b302-84dda38098f5'),
('3561fc18-0136-4502-a9ce-3fdf157414f4', 'bab699ac-d953-4e95-9ad8-4bf90181acd6', '2021-05-21', 100000, '298e9a05-4333-49a8-809b-34b90718be41');

-- --------------------------------------------------------

--
-- Table structure for table `khachhang`
--

CREATE TABLE `khachhang` (
  `ID_KH` char(50) NOT NULL,
  `TenKH` varchar(50) DEFAULT NULL,
  `Gtinh` varchar(10) DEFAULT NULL,
  `Cmnd` char(10) DEFAULT NULL,
  `Dchi` varchar(50) DEFAULT NULL,
  `Qtich` varchar(50) DEFAULT NULL,
  `Sodt` char(11) DEFAULT NULL,
  `Email` char(50) DEFAULT NULL,
  `MatKhau` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `khachhang`
--

INSERT INTO `khachhang` (`ID_KH`, `TenKH`, `Gtinh`, `Cmnd`, `Dchi`, `Qtich`, `Sodt`, `Email`, `MatKhau`) VALUES
('5a2d1014-2d11-4e47-8', 'Võ Trung Nghĩa', 'Nam', '026066167', '38/3 Nguyễn Trọng Trí, Phường An Lạc A, Q. BT', 'Việt Nam', '0703197183', 'votrungnam456@gmail.com', 'Konachan12'),
('601bd552-3922-4892-9', 'Võ Trung Niên', 'Nam', '123456789', 'TP.HCM', 'Việt Nam', '0908123456', 'votrungnam2015@gmail.com', '123456789'),
('a583ff83-be30-4a5b-b3bd-4d0ea894f4e2', 'Trần Thị Tina', 'Nữ', '123151623', '34/5', 'Hàn Quốc', '123121256', 'tina@gmail.com', '123'),
('f1600c1f-5f0d-4827-9', 'Võ Trung Nam', 'Nam', '026066168', '38/3 Nguyễn Trọng Trí, P. An Lạc A. Q. BT', 'Việt Nam', '0703197183', 'votrungnam2013@gmail.com', '123456789');

-- --------------------------------------------------------

--
-- Table structure for table `kieuphong`
--

CREATE TABLE `kieuphong` (
  `MaKP` char(50) NOT NULL,
  `TenKP` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kieuphong`
--

INSERT INTO `kieuphong` (`MaKP`, `TenKP`) VALUES
('KP01', 'Giường đơn'),
('KP02', 'Giường đôi'),
('KP03', 'Giường đơn - VIP'),
('KP04', 'Giường đôi - VIP');

-- --------------------------------------------------------

--
-- Table structure for table `nhanvien`
--

CREATE TABLE `nhanvien` (
  `ID_NV` char(50) NOT NULL,
  `TenNV` varchar(50) DEFAULT NULL,
  `Gtinh` varchar(10) DEFAULT NULL,
  `Cmnd` char(10) DEFAULT NULL,
  `Dchi` varchar(50) DEFAULT NULL,
  `Sodt` char(11) DEFAULT NULL,
  `Enable` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nhanvien`
--

INSERT INTO `nhanvien` (`ID_NV`, `TenNV`, `Gtinh`, `Cmnd`, `Dchi`, `Sodt`, `Enable`) VALUES
('a65175b6-3e81-46af-85ea-b65b570197da', 'Huỳnh Văn B', 'Nam', '123456989', '38/3', '0703197184', 1),
('f8def17c-b3ab-47b4-a88d-0f0580ec6ddf', 'Huỳnh Văn CC', 'Nam', '123456987', '38/3', '0703197184', 1);

-- --------------------------------------------------------

--
-- Table structure for table `phanquyen`
--

CREATE TABLE `phanquyen` (
  `ID_Quyen` char(50) NOT NULL,
  `TenQuyen` varchar(20) DEFAULT NULL,
  `CoQuyen` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `phanquyen`
--

INSERT INTO `phanquyen` (`ID_Quyen`, `TenQuyen`, `CoQuyen`) VALUES
('PQ01', 'Quản lý', 0),
('PQ03', 'Nhân viên', 1);

-- --------------------------------------------------------

--
-- Table structure for table `phieu_dang_ky`
--

CREATE TABLE `phieu_dang_ky` (
  `MaPDK` char(50) NOT NULL,
  `Ngayden` date DEFAULT NULL,
  `Ngaydi` date DEFAULT NULL,
  `Chuthich` varchar(100) DEFAULT NULL,
  `Maphong` char(50) DEFAULT NULL,
  `ID_KH` char(50) DEFAULT NULL,
  `GiaPhong` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `phieu_dang_ky`
--

INSERT INTO `phieu_dang_ky` (`MaPDK`, `Ngayden`, `Ngaydi`, `Chuthich`, `Maphong`, `ID_KH`, `GiaPhong`) VALUES
('00005291-4bfc-4a6a-89f9-446091676e37', '2021-05-20', '2021-05-27', '', 'P108', '5a2d1014-2d11-4e47-8', 130000),
('48b3f91a-ce18-4c9e-84b5-d91122557b2d', '2021-05-19', NULL, 'Test 2', 'P204', '601bd552-3922-4892-9', 1000000),
('6c1fd42e-be14-4933-8c8f-b2e882c8d86a', '2021-05-20', '2021-05-20', '', 'P107', '5a2d1014-2d11-4e47-8', 130000),
('81d12206-7b0f-4263-a2ad-9c4ae68b7ccf', '2021-05-19', NULL, 'Test 2', 'P103', '601bd552-3922-4892-9', 1000000),
('9c0d20ea-c4ca-4df4-9877-6018764adc82', '2021-05-21', '2021-05-21', '', 'P201', '5a2d1014-2d11-4e47-8', 100000),
('bab699ac-d953-4e95-9ad8-4bf90181acd6', '2021-05-17', NULL, 'Test ', 'P101', '601bd552-3922-4892-9', 100000),
('ca029ec8-b8d0-446c-9fcd-714804a9b3b3', '2021-05-20', '2021-05-20', '', 'P107', '5a2d1014-2d11-4e47-8', 130000),
('d1602bf5-8771-4bf7-9016-66a1534f0c8c', '2021-05-20', '2021-05-20', 'test', 'P106', 'f1600c1f-5f0d-4827-9', 120000);

-- --------------------------------------------------------

--
-- Table structure for table `phieu_thanh_toan`
--

CREATE TABLE `phieu_thanh_toan` (
  `MaPTT` char(50) NOT NULL,
  `MaPDK` char(50) DEFAULT NULL,
  `TienThuePhong` int(11) DEFAULT NULL,
  `TienDichVu` int(11) DEFAULT NULL,
  `TongTien` int(11) DEFAULT NULL,
  `NgayThanhToan` date DEFAULT NULL,
  `ID_NV` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `phieu_thanh_toan`
--

INSERT INTO `phieu_thanh_toan` (`MaPTT`, `MaPDK`, `TienThuePhong`, `TienDichVu`, `TongTien`, `NgayThanhToan`, `ID_NV`) VALUES
('01', '81d12206-7b0f-4263-a2ad-9c4ae68b7ccf', 10000, 20000, 30000, '2021-05-27', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('09e615a9-3a7d-4cba-bc25-5362b729525c', 'bab699ac-d953-4e95-9ad8-4bf90181acd6', 1100000, 120000, 1220000, '2021-05-27', 'a65175b6-3e81-46af-85ea-b65b570197da');

--
-- Triggers `phieu_thanh_toan`
--
DELIMITER $$
CREATE TRIGGER `trigger_TongTien` BEFORE INSERT ON `phieu_thanh_toan` FOR EACH ROW BEGIN
	SET NEW.TongTien := NEW.TienThuePhong + NEW.TienDichVu;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `phong`
--

CREATE TABLE `phong` (
  `Maphong` char(50) NOT NULL,
  `Tenphong` varchar(50) DEFAULT NULL,
  `Mota` varchar(50) DEFAULT NULL,
  `MaKP` char(50) DEFAULT NULL,
  `Gia` int(11) DEFAULT NULL,
  `TinhTrang` int(1) DEFAULT NULL,
  `MaPDK` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `phong`
--

INSERT INTO `phong` (`Maphong`, `Tenphong`, `Mota`, `MaKP`, `Gia`, `TinhTrang`, `MaPDK`) VALUES
('P101', 'Phòng P101', 'Đầy đủ thiết bị, có wifi', 'KP01', 100000, 0, NULL),
('P102', 'Phòng P102', 'Đầy đủ thiết bị, có wifi', 'KP02', 150000, 0, NULL),
('P103', 'Phòng 103', 'Đầy đủ thiết bị, có hồ bơi riêng', 'KP04', 1000000, 1, '81d12206-7b0f-4263-a2ad-9c4ae68b7ccf'),
('P104', 'Phòng 104', 'Đầy đủ thiết bị, phòng hướng ra biểng', 'KP03', 500000, 0, NULL),
('P105', 'Phòng 105', 'Nội thất phương tây, hiện đại', 'KP01', 120000, 0, NULL),
('P106', 'Phòng 106', 'Nội thất phương tây, hiện đại', 'KP01', 120000, 1, 'd1602bf5-8771-4bf7-9016-66a1534f0c8c'),
('P107', 'Phòng 107', 'Nội thất phương tây, cổ', 'KP02', 130000, 1, 'ca029ec8-b8d0-446c-9fcd-714804a9b3b3'),
('P108', 'Phòng 108', 'Nội thất phương tây, cổ', 'KP02', 130000, 2, '00005291-4bfc-4a6a-89f9-446091676e37'),
('P109', 'Phòng P109', 'Hướng ra biển, có ban công rộng, đầy đủ tiện nghi', 'KP03', 550000, 0, NULL),
('P111', 'Phòng 111', 'Nội thất phương tây, hiện đại', 'KP01', 120000, 0, NULL),
('P201', 'Phòng 201', 'Đầy đủ thiết bị, có wifi', 'KP02', 100000, 2, '9c0d20ea-c4ca-4df4-9877-6018764adc82'),
('P202', 'Phòng 202', 'Đầy đủ thiết bị, có wifi', 'KP02', 100000, 0, NULL),
('P203', 'Phòng 203', 'Đầy đủ thiết bị, có wifi', 'KP03', 1000000, 0, NULL),
('P204', 'Phòng 204', 'Đầy đủ thiết bị, có wifi', 'KP04', 1000000, 2, '48b3f91a-ce18-4c9e-84b5-d91122557b2d');

-- --------------------------------------------------------

--
-- Table structure for table `taikhoan_nhanvien`
--

CREATE TABLE `taikhoan_nhanvien` (
  `ID_NV` char(50) NOT NULL,
  `Email` char(50) DEFAULT NULL,
  `MatKhau` char(50) DEFAULT NULL,
  `ID_Quyen` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `taikhoan_nhanvien`
--

INSERT INTO `taikhoan_nhanvien` (`ID_NV`, `Email`, `MatKhau`, `ID_Quyen`) VALUES
('a65175b6-3e81-46af-85ea-b65b570197da', 'votrungnam@gmail.com', '123', 'PQ01'),
('f8def17c-b3ab-47b4-a88d-0f0580ec6ddf', 'votrungnam456@gmail.com', '123', 'PQ01');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dichvu`
--
ALTER TABLE `dichvu`
  ADD PRIMARY KEY (`ID_DV`);

--
-- Indexes for table `hoadondichvu`
--
ALTER TABLE `hoadondichvu`
  ADD PRIMARY KEY (`ID_DV`,`MaPDK`),
  ADD KEY `FK_HoaDonDichVu_DichVu` (`ID_DV`),
  ADD KEY `FK_HoaDonDichVu_PhieuDangKy` (`MaPDK`);

--
-- Indexes for table `khachhang`
--
ALTER TABLE `khachhang`
  ADD PRIMARY KEY (`ID_KH`);

--
-- Indexes for table `kieuphong`
--
ALTER TABLE `kieuphong`
  ADD PRIMARY KEY (`MaKP`);

--
-- Indexes for table `nhanvien`
--
ALTER TABLE `nhanvien`
  ADD PRIMARY KEY (`ID_NV`);

--
-- Indexes for table `phanquyen`
--
ALTER TABLE `phanquyen`
  ADD PRIMARY KEY (`ID_Quyen`);

--
-- Indexes for table `phieu_dang_ky`
--
ALTER TABLE `phieu_dang_ky`
  ADD PRIMARY KEY (`MaPDK`),
  ADD KEY `FK_PhieuDK_KhachHang` (`ID_KH`),
  ADD KEY `FK_PhieuDK_Phong` (`Maphong`);

--
-- Indexes for table `phieu_thanh_toan`
--
ALTER TABLE `phieu_thanh_toan`
  ADD PRIMARY KEY (`MaPTT`),
  ADD KEY `FK_PTT_NhanVien` (`ID_NV`),
  ADD KEY `FK_PTT_PhieuDangKy` (`MaPDK`);

--
-- Indexes for table `phong`
--
ALTER TABLE `phong`
  ADD PRIMARY KEY (`Maphong`),
  ADD KEY `FK_Phong_KieuPhong` (`MaKP`),
  ADD KEY `FK_Phong_PhieuDangKy` (`MaPDK`);

--
-- Indexes for table `taikhoan_nhanvien`
--
ALTER TABLE `taikhoan_nhanvien`
  ADD PRIMARY KEY (`ID_NV`),
  ADD KEY `FK_TKNV_PhanQuyen` (`ID_Quyen`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `hoadondichvu`
--
ALTER TABLE `hoadondichvu`
  ADD CONSTRAINT `FK_HoaDonDichVu_DichVu` FOREIGN KEY (`ID_DV`) REFERENCES `dichvu` (`ID_DV`),
  ADD CONSTRAINT `FK_HoaDonDichVu_PhieuDangKy` FOREIGN KEY (`MaPDK`) REFERENCES `phieu_dang_ky` (`MaPDK`);

--
-- Constraints for table `phieu_dang_ky`
--
ALTER TABLE `phieu_dang_ky`
  ADD CONSTRAINT `FK_PhieuDK_KhachHang` FOREIGN KEY (`ID_KH`) REFERENCES `khachhang` (`ID_KH`),
  ADD CONSTRAINT `FK_PhieuDK_Phong` FOREIGN KEY (`Maphong`) REFERENCES `phong` (`Maphong`);

--
-- Constraints for table `phieu_thanh_toan`
--
ALTER TABLE `phieu_thanh_toan`
  ADD CONSTRAINT `FK_PTT_NhanVien` FOREIGN KEY (`ID_NV`) REFERENCES `nhanvien` (`ID_NV`),
  ADD CONSTRAINT `FK_PTT_PhieuDangKy` FOREIGN KEY (`MaPDK`) REFERENCES `phieu_dang_ky` (`MaPDK`);

--
-- Constraints for table `phong`
--
ALTER TABLE `phong`
  ADD CONSTRAINT `FK_Phong_KieuPhong` FOREIGN KEY (`MaKP`) REFERENCES `kieuphong` (`MaKP`),
  ADD CONSTRAINT `FK_Phong_PhieuDangKy` FOREIGN KEY (`MaPDK`) REFERENCES `phieu_dang_ky` (`MaPDK`);

--
-- Constraints for table `taikhoan_nhanvien`
--
ALTER TABLE `taikhoan_nhanvien`
  ADD CONSTRAINT `FK_TKNV_NhanVien` FOREIGN KEY (`ID_NV`) REFERENCES `nhanvien` (`ID_NV`),
  ADD CONSTRAINT `FK_TKNV_PhanQuyen` FOREIGN KEY (`ID_Quyen`) REFERENCES `phanquyen` (`ID_Quyen`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
