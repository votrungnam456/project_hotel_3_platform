-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 15, 2021 at 01:38 PM
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
  `Gia` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `hoadondatphong`
--

CREATE TABLE `hoadondatphong` (
  `MaHDDP` char(50) NOT NULL,
  `MaPDK` char(50) DEFAULT NULL,
  `NgayLap` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `hoadondichvu`
--

CREATE TABLE `hoadondichvu` (
  `ID_DV` char(50) NOT NULL,
  `MaPDK` char(50) NOT NULL,
  `NgayLap` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
('601bd552-3922-4892-9', 'Cao Quang Sơn', 'Nam', '123456789', 'TP.HCM', 'Việt Nam', '0908123456', 'votrungnam2015@gmail.com', '123456789'),
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
  `Sodt` char(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `phanquyen`
--

CREATE TABLE `phanquyen` (
  `ID_Quyen` char(50) NOT NULL,
  `TenQuyen` varchar(20) DEFAULT NULL,
  `CoQuyen` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
  `ID_KH` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `phieu_dang_ky`
--

INSERT INTO `phieu_dang_ky` (`MaPDK`, `Ngayden`, `Ngaydi`, `Chuthich`, `Maphong`, `ID_KH`) VALUES
('181c2374-6041-4c34-80a5-457819b9a5a0', '2021-05-17', NULL, 'test', 'P101', '601bd552-3922-4892-9'),
('24182a6a-742a-444f-a2ae-fc7de27ee93e', '2021-05-14', '2021-05-14', 'Test Form', 'P102', '5a2d1014-2d11-4e47-8'),
('298bd336-471b-4a97-996b-f17aae7cb21b', '2021-05-14', '2021-05-15', '', 'P106', '5a2d1014-2d11-4e47-8'),
('546a73ad-cee1-4c3b-bece-3f4bb3925174', '2021-05-20', NULL, 'test 3', 'P105', '601bd552-3922-4892-9');

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
('P101', 'Phòng P101', 'Đầy đủ thiết bị, có wifi', 'KP01', 100000, 1, '181c2374-6041-4c34-80a5-457819b9a5a0'),
('P102', 'Phòng P102', 'Đầy đủ thiết bị, có wifi', 'KP02', 150000, 2, '24182a6a-742a-444f-a2ae-fc7de27ee93e'),
('P103', 'Phòng 103', 'Đầy đủ thiết bị, có hồ bơi riêng', 'KP04', 1000000, 0, NULL),
('P104', 'Phòng 104', 'Đầy đủ thiết bị, phòng hướng ra biểng', 'KP03', 500000, 0, NULL),
('P105', 'Phòng 105', 'Nội thất phương tây, hiện đại', 'KP01', 120000, 1, '546a73ad-cee1-4c3b-bece-3f4bb3925174'),
('P106', 'Phòng 106', 'Nội thất phương tây, hiện đại', 'KP01', 120000, 2, '298bd336-471b-4a97-996b-f17aae7cb21b'),
('P107', 'Phòng 107', 'Nội thất phương tây, cổ', 'KP02', 130000, 0, NULL),
('P108', 'Phòng 108', 'Nội thất phương tây, cổ', 'KP02', 130000, 0, NULL),
('P109', 'Phòng P109', 'Hướng ra biển, có ban công rộng, đầy đủ tiện nghi', 'KP03', 550000, 0, NULL),
('P201', 'Phòng 201', 'Đầy đủ thiết bị, có wifi', 'KP02', 100000, 0, NULL),
('P202', 'Phòng 202', 'Đầy đủ thiết bị, có wifi', 'KP02', 100000, 0, NULL),
('P203', 'Phòng 203', 'Đầy đủ thiết bị, có wifi', 'KP03', 1000000, 0, NULL),
('P204', 'Phòng 204', 'Đầy đủ thiết bị, có wifi', 'KP04', 1000000, 0, NULL);

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
-- Indexes for dumped tables
--

--
-- Indexes for table `dichvu`
--
ALTER TABLE `dichvu`
  ADD PRIMARY KEY (`ID_DV`);

--
-- Indexes for table `hoadondatphong`
--
ALTER TABLE `hoadondatphong`
  ADD PRIMARY KEY (`MaHDDP`),
  ADD KEY `FK_HoaDonDatPhong_PhieuDK` (`MaPDK`);

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
-- Constraints for table `hoadondatphong`
--
ALTER TABLE `hoadondatphong`
  ADD CONSTRAINT `FK_HoaDonDatPhong_PhieuDK` FOREIGN KEY (`MaPDK`) REFERENCES `phieu_dang_ky` (`MaPDK`);

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
