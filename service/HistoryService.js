'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
class HistoryService {
    // lấy danh sách phiếu đăng ký
    static async historyBookingRoomService(req) {
        try {
            let result = await queryBuilder().select('phieu_dang_ky.MaPDK','phong.Tenphong','khachhang.TenKH','phieu_dang_ky.Ngayden','phieu_dang_ky.Ngaydi','phieu_dang_ky.GiaPhong','phieu_dang_ky.Chuthich').
                                            from('phieu_dang_ky').
                                            join('phong', {'phieu_dang_ky.Maphong': 'phong.Maphong'}).
                                            join('khachhang',{'phieu_dang_ky.ID_KH':'khachhang.ID_KH'}).orderBy('phieu_dang_ky.Ngayden');
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    // tìm kiếm danh sách phiếu đăng ký
    static async searchHistoryBookingRoomService(req) {
        try {
            let filter = req.params.content;
            let result = await queryBuilder().select('phieu_dang_ky.MaPDK','phong.Tenphong','khachhang.TenKH','phieu_dang_ky.Ngayden','phieu_dang_ky.Ngaydi','phieu_dang_ky.GiaPhong','phieu_dang_ky.Chuthich').
                                            from('phieu_dang_ky').
                                            join('phong', {'phieu_dang_ky.Maphong': 'phong.Maphong'}).
                                            join('khachhang',{'phieu_dang_ky.ID_KH':'khachhang.ID_KH'}).where('khachhang.TenKH','like','%'+filter+'%').orderBy('phieu_dang_ky.Ngayden');
            if(result.length > 0){
                return result;
            }                    
            else{
                return [{
                    MaPDK:"-1"
                }];
            }
        } catch (e) {
            console.log(e);
            return e
        }
    }
    //lấy danh sách lịch sử sử dụng dịch vụ
    static async historyService(req) {
        try {
            let result = await queryBuilder().select('hoadondichvu.IDHDDV','dichvu.TenDV','khachhang.TenKH','hoadondichvu.NgayLap','hoadondichvu.GiaDichVu').
                                                from('hoadondichvu').
                                                join('phieu_dang_ky',{'phieu_dang_ky.MaPDK':'hoadondichvu.MaPDK'}).
                                                join('khachhang',{'khachhang.ID_KH':'phieu_dang_ky.ID_KH'}).
                                                join('dichvu',{'dichvu.ID_DV':'hoadondichvu.ID_DV'}).orderBy('hoadondichvu.NgayLap');
            return result;
        } catch (e) {
            console.log(e);
            return e;
        }
    }
    //tim kiếm danh sách lịch sử sử dụng dịch vụ
    static async searchHistoryService(req) {
        try {
            let filter = req.params.content;
            let result = await queryBuilder().select('hoadondichvu.IDHDDV','dichvu.TenDV','khachhang.TenKH','hoadondichvu.NgayLap','hoadondichvu.GiaDichVu').
                                                from('hoadondichvu').
                                                join('phieu_dang_ky',{'phieu_dang_ky.MaPDK':'hoadondichvu.MaPDK'}).
                                                join('khachhang',{'khachhang.ID_KH':'phieu_dang_ky.ID_KH'}).
                                                join('dichvu',{'dichvu.ID_DV':'hoadondichvu.ID_DV'}).where('khachhang.TenKH','like','%'+filter+'%').orderBy('hoadondichvu.NgayLap');
            if(result.length > 0){
                return result;
            }                    
            else{
                return [{
                    IDHDDV:"-1"
                }];
            }
        } catch (e) {
            console.log(e);
            return e;
        }
    }
    // lấy danh sách hoá đơn
    static async historyBillService(req) {
        try {
            let result = await queryBuilder().select('phieu_thanh_toan.MaPTT','phieu_thanh_toan.MaPDK','khachhang.TenKH','phieu_thanh_toan.TienThuePhong','phieu_thanh_toan.TienDichVu','phieu_thanh_toan.TongTien','phieu_thanh_toan.NgayThanhToan','phieu_thanh_toan.ID_NV','nhanvien.TenNV').
                                            from('phieu_thanh_toan').
                                            join('phieu_dang_ky',{'phieu_dang_ky.MaPDK':'phieu_thanh_toan.MaPDK'}).
                                            join('khachhang',{'khachhang.ID_KH':'phieu_dang_ky.ID_KH'}).
                                            join('nhanvien',{'nhanvien.ID_NV':'phieu_thanh_toan.ID_NV'}).orderBy('phieu_thanh_toan.NgayThanhToan');
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }

    // tìm kiếm hoá đơn
    static async searchHistoryBillService(req) {
        try {
            let filter = req.params.content;
            let result = await queryBuilder().select('phieu_thanh_toan.MaPTT','phieu_thanh_toan.MaPDK','khachhang.TenKH','phieu_thanh_toan.TienThuePhong','phieu_thanh_toan.TienDichVu','phieu_thanh_toan.TongTien','phieu_thanh_toan.NgayThanhToan','phieu_thanh_toan.ID_NV','nhanvien.TenNV').
                                            from('phieu_thanh_toan').
                                            join('phieu_dang_ky',{'phieu_dang_ky.MaPDK':'phieu_thanh_toan.MaPDK'}).
                                            join('khachhang',{'khachhang.ID_KH':'phieu_dang_ky.ID_KH'}).
                                            join('nhanvien',{'nhanvien.ID_NV':'phieu_thanh_toan.ID_NV'}).where('khachhang.TenKH','like','%'+filter+'%').orderBy('phieu_thanh_toan.NgayThanhToan');
            if(result.length > 0){
                return result;
            }                    
            else{
                return [{
                    MaPDK:"-1"
                }];
            }
        } catch (e) {
            console.log(e);
            return e
        }
    }
}
module.exports = HistoryService