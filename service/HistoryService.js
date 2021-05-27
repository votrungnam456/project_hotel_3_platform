'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
class HistoryService {
    // lấy danh sách phiếu đăng ký
    static async HistoryBookingRoomService(req) {
        try {
            let result = await queryBuilder().select('phieu_dang_ky.MaPDK','phong.Tenphong','khachhang.TenKH','phieu_dang_ky.Ngayden','phieu_dang_ky.Ngaydi','phieu_dang_ky.GiaPhong','phieu_dang_ky.Chuthich').
                                            from('phieu_dang_ky').
                                            join('phong', {'phieu_dang_ky.Maphong': 'phong.Maphong'}).
                                            join('khachhang',{'phieu_dang_ky.ID_KH':'khachhang.ID_KH'});
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async HistoryService(req) {
        try {
            let result = await queryBuilder().select('hoadondichvu.IDHDDV','dichvu.TenDV','khachhang.TenKH','hoadondichvu.NgayLap','hoadondichvu.GiaDichVu').
                                                from('hoadondichvu').
                                                join('phieu_dang_ky',{'phieu_dang_ky.MaPDK':'hoadondichvu.MaPDK'}).
                                                join('khachhang',{'khachhang.ID_KH':'phieu_dang_ky.ID_KH'}).
                                                join('dichvu',{'dichvu.ID_DV':'hoadondichvu.ID_DV'});
            return result;
        } catch (e) {
            console.log(e);
            return e;
        }
    }
    static async HistoryBillService(req) {
        try {
            let result = await queryBuilder().select('phieu_thanh_toan.MaPTT','phieu_thanh_toan.MaPDK','khachhang.TenKH','phieu_thanh_toan.TienThuePhong','phieu_thanh_toan.TienDichVu','phieu_thanh_toan.TongTien','phieu_thanh_toan.NgayThanhToan','phieu_thanh_toan.ID_NV','nhanvien.TenNV').
                                            from('phieu_thanh_toan').
                                            join('phieu_dang_ky',{'phieu_dang_ky.MaPDK':'phieu_thanh_toan.MaPDK'}).
                                            join('khachhang',{'khachhang.ID_KH':'phieu_dang_ky.ID_KH'}).
                                            join('nhanvien',{'nhanvien.ID_NV':'phieu_thanh_toan.ID_NV'});
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
}
module.exports = HistoryService