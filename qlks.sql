-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 13, 2021 at 06:19 PM
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
('71010692-ac69-49f3-8619-cad583acaaad', 'Dịch vụ đặt vé máy bay, tour du lịch', 20000, 1),
('90c8952d-b040-486c-9b8f-b22f6fc2e02c', 'Massage', 100000, 1);

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
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', '23abab46-0fac-402d-ba1c-b73587dbff0a', '2021-06-14', 25000, '3649fb40-c4b2-4f30-bdf9-2a0e98dcf67d'),
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', '330c2260-26af-4338-8ff3-45c032905194', '2021-06-08', 25000, 'eafd1145-64ef-43fc-9167-ee2d72498106'),
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', '42d11ec7-68fd-4ba0-84c8-b4b305bf7fa9', '2021-06-08', 25000, '58dafa13-058a-453a-b00a-71682be7bd8c'),
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', '48b3f91a-ce18-4c9e-84b5-d91122557b2d', '2021-06-07', 25000, '62c91c96-2b81-44a1-beca-42821f0342a8'),
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', '6c027959-6234-4c4a-907b-efbbe16f95c7', '2021-06-08', 25000, '1d42e73f-141d-4224-964b-3a3437be9bb4'),
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', '88f05c3a-2149-4a7a-8847-558c0ecbcfdb', '2021-06-08', 25000, '74b4061c-8d44-4830-bda0-720a2cdeb011'),
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', '9c0d20ea-c4ca-4df4-9877-6018764adc82', '2021-06-07', 25000, 'd6f65c4b-f4a4-43e1-8cb7-e5a493414c8b'),
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', 'acd513a7-b9b5-4d76-b0fd-f369654e4f60', '2021-06-14', 25000, '3e715660-fb38-4d6a-97ab-71bc00fc826b'),
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', 'bab699ac-d953-4e95-9ad8-4bf90181acd6', '2021-05-21', 20000, '72bebad7-6233-4d85-b302-84dda38098f5'),
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', 'be4a5198-ca24-499e-89ff-460a92c05f9f', '2021-06-08', 25000, 'cb3fd54d-a0eb-469b-9772-2771c5d0117e'),
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', 'be4a5198-ca24-499e-89ff-460a92c05f9f', '2021-06-08', 25000, 'cdc7b232-0962-48d5-a6f6-9976bb5de2dc'),
('110eff4b-c703-44f0-b427-f3d9e74c2ccc', 'e5a41d45-c95e-4b0c-ba03-8a8457c047b2', '2021-06-08', 25000, 'f333e60c-65e7-4135-a430-f995523d91d0'),
('26573b47-8af6-4047-8e6e-d8da984c3fb7', '23abab46-0fac-402d-ba1c-b73587dbff0a', '2021-06-14', 50000, '0da03df4-dd8f-4a02-8c54-0990b792ec47'),
('26573b47-8af6-4047-8e6e-d8da984c3fb7', '330c2260-26af-4338-8ff3-45c032905194', '2021-06-07', 50000, '11b1ed78-3036-442e-8a54-cd53a8bcf49b'),
('26573b47-8af6-4047-8e6e-d8da984c3fb7', '42d11ec7-68fd-4ba0-84c8-b4b305bf7fa9', '2021-06-08', 50000, '0d1caafa-0423-4b9e-a22a-b62777a02388'),
('26573b47-8af6-4047-8e6e-d8da984c3fb7', '81d12206-7b0f-4263-a2ad-9c4ae68b7ccf', '2021-06-07', 50000, '7770a317-db2e-4bd0-b3b9-a8ba4ca4698b'),
('26573b47-8af6-4047-8e6e-d8da984c3fb7', '9c0d20ea-c4ca-4df4-9877-6018764adc82', '2021-06-07', 50000, '29d403b7-188d-48d4-b956-0ed3fc67db52'),
('26573b47-8af6-4047-8e6e-d8da984c3fb7', 'acd513a7-b9b5-4d76-b0fd-f369654e4f60', '2021-06-14', 50000, 'ae9fd2bd-e0ce-454c-b7cf-2d3fecd122b7'),
('26573b47-8af6-4047-8e6e-d8da984c3fb7', 'be4a5198-ca24-499e-89ff-460a92c05f9f', '2021-06-08', 50000, '40987d06-c750-4aed-aeb8-20433044a780'),
('26573b47-8af6-4047-8e6e-d8da984c3fb7', 'be4a5198-ca24-499e-89ff-460a92c05f9f', '2021-06-08', 50000, 'bc78eac4-4f23-4d08-bde7-c4776b2864f5'),
('26573b47-8af6-4047-8e6e-d8da984c3fb7', 'c95fa774-8980-420e-962c-d4b89c9d5906', '2021-06-07', 50000, '2f1b894c-9382-4dc7-b000-25a260807928'),
('26573b47-8af6-4047-8e6e-d8da984c3fb7', 'ca029ec8-b8d0-446c-9fcd-714804a9b3b3', '2021-06-07', 50000, '8fc72601-7f38-4975-98ab-e4eae6be1dc0'),
('3561fc18-0136-4502-a9ce-3fdf157414f4', 'bab699ac-d953-4e95-9ad8-4bf90181acd6', '2021-05-21', 100000, '298e9a05-4333-49a8-809b-34b90718be41'),
('71010692-ac69-49f3-8619-cad583acaaad', '330c2260-26af-4338-8ff3-45c032905194', '2021-06-08', 20000, '32f4ff8a-ee1b-45da-bb91-5337e6650ffd'),
('71010692-ac69-49f3-8619-cad583acaaad', '330c2260-26af-4338-8ff3-45c032905194', '2021-06-08', 20000, 'eabf380f-8783-4dbb-8ab0-53e56c867953'),
('71010692-ac69-49f3-8619-cad583acaaad', '48b3f91a-ce18-4c9e-84b5-d91122557b2d', '2021-06-07', 20000, 'afe84dc5-345f-499f-ac5c-1078d5d3c85c'),
('71010692-ac69-49f3-8619-cad583acaaad', '81d12206-7b0f-4263-a2ad-9c4ae68b7ccf', '2021-06-07', 20000, 'c5fe8043-687a-46d5-98f9-c12e313c5219'),
('71010692-ac69-49f3-8619-cad583acaaad', '9c0d20ea-c4ca-4df4-9877-6018764adc82', '2021-06-07', 20000, 'aeb5d3f0-058e-41e7-852f-226662d66347');

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
('f20c069d-0199-4634-a244-57f7bad57adb', 'Võ Trung Nghĩa', 'Nam', '123456789', '38/3 Nguyễn Trọng Trí', '0123456789', 1),
('f8def17c-b3ab-47b4-a88d-0f0580ec6ddf', 'Huỳnh Thị Văn Cá', 'Nữ', '987654123', '48 Nam Kỳ Khởi Nghĩa', '0231567891', 1);

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
('0a67e6a2-6e3d-425d-a2d2-8c51f50fb272', '2021-06-15', '2021-06-15', '', 'P102', '5a2d1014-2d11-4e47-8', 150000),
('19f3502a-1381-4edd-af48-c2d53689a6fb', '2021-06-14', '2021-06-14', '', 'P108', '5a2d1014-2d11-4e47-8', 130000),
('23abab46-0fac-402d-ba1c-b73587dbff0a', '2021-06-08', '2021-06-08', '', 'P103', 'f1600c1f-5f0d-4827-9', 1000000),
('330c2260-26af-4338-8ff3-45c032905194', '2021-06-07', '2021-06-09', 'Test 123', 'P203', 'a583ff83-be30-4a5b-b3bd-4d0ea894f4e2', 1000000),
('3dcaee42-23b8-4912-a655-43443b033ebe', '2021-06-16', '2021-06-18', 'data test filter ', 'P106', 'f1600c1f-5f0d-4827-9', 120000),
('42d11ec7-68fd-4ba0-84c8-b4b305bf7fa9', '2021-06-08', '2021-06-10', 'Test để lấy data Apriori', 'P105', 'f1600c1f-5f0d-4827-9', 120000),
('45c5c683-57f5-4320-a20e-80a0942b25c1', '2021-06-15', '2021-06-16', 'test filter', 'P104', 'a583ff83-be30-4a5b-b3bd-4d0ea894f4e2', 500000),
('48b3f91a-ce18-4c9e-84b5-d91122557b2d', '2021-05-19', NULL, 'Test 2', 'P204', '601bd552-3922-4892-9', 1000000),
('6c027959-6234-4c4a-907b-efbbe16f95c7', '2021-06-08', '2021-06-08', '', 'P109', 'f1600c1f-5f0d-4827-9', 550000),
('6c1fd42e-be14-4933-8c8f-b2e882c8d86a', '2021-05-20', '2021-05-20', '', 'P107', '5a2d1014-2d11-4e47-8', 130000),
('81d12206-7b0f-4263-a2ad-9c4ae68b7ccf', '2021-05-19', NULL, 'Test 2', 'P103', '601bd552-3922-4892-9', 1000000),
('838876a9-b4fe-4fab-9d72-ff7bc1bca7ab', '2021-06-16', '2021-06-18', 'data test filter ', 'P105', 'f1600c1f-5f0d-4827-9', 120000),
('88f05c3a-2149-4a7a-8847-558c0ecbcfdb', '2021-06-08', '2021-06-10', 'Test để lấy data Apriori', 'P111', 'f1600c1f-5f0d-4827-9', 120000),
('9c0d20ea-c4ca-4df4-9877-6018764adc82', '2021-05-21', '2021-05-21', '', 'P201', '5a2d1014-2d11-4e47-8', 100000),
('9debdb47-21c3-4c7a-a6a4-29f5159379e6', '2021-06-08', '2021-06-10', 'Test để lấy data Apriori', 'P106', 'f1600c1f-5f0d-4827-9', 120000),
('a3a650f3-ad80-4955-8403-5b04a52d88c0', '2021-06-16', '2021-06-18', 'data test filter ', 'P104', 'f1600c1f-5f0d-4827-9', 500000),
('acd513a7-b9b5-4d76-b0fd-f369654e4f60', '2021-06-08', '2021-06-08', '', 'P204', 'f1600c1f-5f0d-4827-9', 1000000),
('b0b9d13a-588a-4fb2-9ec0-83f35ab1cf63', '2021-06-14', '2021-06-14', '', 'P203', '5a2d1014-2d11-4e47-8', 1000000),
('bab699ac-d953-4e95-9ad8-4bf90181acd6', '2021-05-17', NULL, 'Test ', 'P101', '601bd552-3922-4892-9', 100000),
('be4a5198-ca24-499e-89ff-460a92c05f9f', '2021-06-08', '2021-06-10', 'Test để lấy data Apriori', 'P101', 'f1600c1f-5f0d-4827-9', 100000),
('c95fa774-8980-420e-962c-d4b89c9d5906', '2021-06-07', '2021-06-09', 'Test 123', 'P109', 'a583ff83-be30-4a5b-b3bd-4d0ea894f4e2', 550000),
('ca029ec8-b8d0-446c-9fcd-714804a9b3b3', '2021-05-20', '2021-05-20', '', 'P107', '5a2d1014-2d11-4e47-8', 130000),
('d1602bf5-8771-4bf7-9016-66a1534f0c8c', '2021-05-20', '2021-05-20', 'test', 'P106', 'f1600c1f-5f0d-4827-9', 120000),
('e5a41d45-c95e-4b0c-ba03-8a8457c047b2', '2021-06-08', '2021-06-08', '', 'P103', 'f1600c1f-5f0d-4827-9', 1000000),
('f3592567-dd84-4798-b3b4-017a2713f0a9', '2021-06-17', '2021-06-19', '', 'P202', '601bd552-3922-4892-9', 100000),
('fb2b3011-f516-4c78-beb3-128ec050b20d', '2021-06-17', '2021-06-19', '', 'P201', '601bd552-3922-4892-9', 100000);

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
('09e615a9-3a7d-4cba-bc25-5362b729525c', 'bab699ac-d953-4e95-9ad8-4bf90181acd6', 1100000, 120000, 1220000, '2021-05-27', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('22dfa6ed-b2f2-4858-92b0-edfb50d74bda', 'be4a5198-ca24-499e-89ff-460a92c05f9f', 100000, 150000, 250000, '2021-06-08', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('267fe00c-4ff4-4b79-bef4-f4097e388767', '9c0d20ea-c4ca-4df4-9877-6018764adc82', 1800000, 95000, 1895000, '2021-06-07', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('3328a145-3e22-4fc2-9c4e-957dfad38688', 'acd513a7-b9b5-4d76-b0fd-f369654e4f60', 36000000, 75000, 36075000, '2021-07-13', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('40593ebe-b391-4f49-a53e-ae352b80dc10', '81d12206-7b0f-4263-a2ad-9c4ae68b7ccf', 20000000, 70000, 20070000, '2021-06-07', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('474a3f0c-4fca-4c36-ba44-eb4dda0a5f93', 'e5a41d45-c95e-4b0c-ba03-8a8457c047b2', 1000000, 25000, 1025000, '2021-06-08', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('5c021fb7-480b-4f20-b31d-874e11555400', '23abab46-0fac-402d-ba1c-b73587dbff0a', 36000000, 75000, 36075000, '2021-07-13', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('6b83c9b8-c4cd-4204-8871-af12318c0827', '6c027959-6234-4c4a-907b-efbbe16f95c7', 550000, 25000, 575000, '2021-06-08', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('7006a176-b93f-4079-8cea-258f30b2ce62', '330c2260-26af-4338-8ff3-45c032905194', 2000000, 115000, 2115000, '2021-06-08', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('8841748c-ee38-473d-b545-dcedd0e7ca14', 'c95fa774-8980-420e-962c-d4b89c9d5906', 1100000, 50000, 1150000, '2021-06-08', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('b3aadf81-930c-4061-94da-4a6bcebe92ac', 'd1602bf5-8771-4bf7-9016-66a1534f0c8c', 2280000, 0, 2280000, '2021-06-07', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('c26eeddb-919b-47af-82bb-6ab3fd7da689', '88f05c3a-2149-4a7a-8847-558c0ecbcfdb', 120000, 25000, 145000, '2021-06-08', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('c4859935-a66c-4f27-9abf-4c611bebfbdf', '42d11ec7-68fd-4ba0-84c8-b4b305bf7fa9', 120000, 75000, 195000, '2021-06-08', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('cca3f9c1-f720-44bf-b097-86542f4d2bce', '48b3f91a-ce18-4c9e-84b5-d91122557b2d', 20000000, 45000, 20045000, '2021-06-07', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('d393ee56-71f2-4d1b-8509-6c94ed2dfbae', 'ca029ec8-b8d0-446c-9fcd-714804a9b3b3', 2470000, 50000, 2520000, '2021-06-07', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('e4c02215-ae4c-404a-ab32-d314ccef8848', '9debdb47-21c3-4c7a-a6a4-29f5159379e6', 120000, 0, 120000, '2021-06-08', 'a65175b6-3e81-46af-85ea-b65b570197da'),
('e7d02827-44f4-406b-998d-720f0b3252d8', '00005291-4bfc-4a6a-89f9-446091676e37', 2470000, 0, 2470000, '2021-06-07', 'a65175b6-3e81-46af-85ea-b65b570197da');

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
('P102', 'Phòng P102', 'Đầy đủ thiết bị, có wifi', 'KP02', 150000, 1, '0a67e6a2-6e3d-425d-a2d2-8c51f50fb272'),
('P103', 'Phòng 103', 'Đầy đủ thiết bị, có hồ bơi riêng', 'KP04', 1000000, 0, NULL),
('P104', 'Phòng 104', 'Đầy đủ thiết bị, phòng hướng ra biểng', 'KP03', 500000, 0, NULL),
('P105', 'Phòng 105', 'Nội thất phương tây, hiện đại', 'KP01', 120000, 0, NULL),
('P106', 'Phòng 106', 'Nội thất phương tây, hiện đại', 'KP01', 120000, 0, NULL),
('P107', 'Phòng 107', 'Nội thất phương tây, cổ', 'KP02', 130000, 0, NULL),
('P108', 'Phòng 108', 'Nội thất phương tây, cổ', 'KP02', 130000, 2, '19f3502a-1381-4edd-af48-c2d53689a6fb'),
('P109', 'Phòng P109', 'Hướng ra biển, có ban công rộng, đầy đủ tiện nghi', 'KP03', 550000, 0, NULL),
('P111', 'Phòng 111', 'Nội thất phương tây, hiện đại', 'KP01', 120000, 0, NULL),
('P201', 'Phòng 201', 'Đầy đủ thiết bị, có wifi', 'KP02', 100000, 1, 'fb2b3011-f516-4c78-beb3-128ec050b20d'),
('P202', 'Phòng 202', 'Đầy đủ thiết bị, có wifi', 'KP02', 100000, 1, 'f3592567-dd84-4798-b3b4-017a2713f0a9'),
('P203', 'Phòng 203', 'Đầy đủ thiết bị, có wifi', 'KP03', 1000000, 2, 'b0b9d13a-588a-4fb2-9ec0-83f35ab1cf63'),
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
-- Dumping data for table `taikhoan_nhanvien`
--

INSERT INTO `taikhoan_nhanvien` (`ID_NV`, `Email`, `MatKhau`, `ID_Quyen`) VALUES
('a65175b6-3e81-46af-85ea-b65b570197da', 'votrungnam@gmail.com', '123', 'PQ01'),
('f20c069d-0199-4634-a244-57f7bad57adb', 'votrungnghia2015@gmail.com', '123', 'PQ03'),
('f8def17c-b3ab-47b4-a88d-0f0580ec6ddf', 'huynhthica@gmail.com', '123', 'PQ03');

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
  ADD PRIMARY KEY (`ID_DV`,`MaPDK`,`IDHDDV`),
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
