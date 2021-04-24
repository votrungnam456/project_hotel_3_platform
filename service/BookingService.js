'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
class RoomService {
    static async listBookingRoomService(req) {
        try {
            let result = await queryBuilder('phieu_dang_ky').select();
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    // static async getItemService(req){
    //     try {

    //         let MaPhong = req.params.MaPhong;
    //         let result = await queryBuilder('phong').where("MaPhong",MaPhong).first();
    //         return result;
    //     } catch (e) {
    //         console.log(e);
    //         return e
    //     }
    // }
    static async createBookingRoomService(req){
        try {
            let params = req.body;
            let dataInsert = {
                MaPDK:uuid.v4(),
                Ngayden:params.Ngayden,
                Ngaydi:params.Ngaydi || null,
                Chuthich:params.Chuthich,
                Maphong:params.Maphong,
                ID_KH: params.ID_KH
            }
            let Maphong = params.Maphong;
            let result = await queryBuilder('phong').where({
                "Maphong": Maphong
            }).select("Trangthai");
            if(result[0].Trangthai == 0){
                await queryBuilder('phieu_dang_ky').insert(dataInsert);
                await queryBuilder('phong').where("Maphong",Maphong).update({Trangthai:1});
                return "Đặt phòng thành công";
            }
            else {
                return "Phòng đang được sử dụng";
            }
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async updateBookingRoomService(req){
        try {
            
            let params = req.body;
            let MaPDK= params.MaPDK;
            let dataUpdate = {
                Ngayden:params.Ngayden,
                Ngaydi:params.Ngaydi || null,
                Chuthich:params.Chuthich,
                Maphong:params.Maphong,
                ID_KH: params.ID_KH
            }
            await queryBuilder('phieu_dang_ky').where("MaPDK", MaPDK).update(dataUpdate);
            return "Cập nhật thông tin đặt phòng thành công";
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async deleteBookingService(req){
        try {
            let idBooking = req.params.MaPDK;
            let MaPhong = await queryBuilder('phieu_dang_ky').where({
                "MaPDK": idBooking
            }).select("MaPhong");
            let result = await queryBuilder('phong').where({
                "Maphong": MaPhong[0].MaPhong,
                "Trangthai": 1
            }).select();
            if(result.length != 0) {
                await queryBuilder('phieu_dang_ky').where({
                    "MaPDK": idBooking
                }).del();

                await queryBuilder('phong').where("Maphong",MaPhong[0].MaPhong).update({Trangthai:0});
                return "Xóa thành công"
            }
            else return "Phòng đã nhận không thể xóa"
        } catch (e) {
            console.log(e);
            return e
        }
    }
}
module.exports = RoomService