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
            let Ngayden= new Date(params.Ngayden);
            let Ngaydi=new Date(params.Ngaydi)|| null;
            Ngayden = Ngayden.toISOString().split("T")[0]
            Ngaydi = Ngaydi != null ? Ngaydi.toISOString().split("T")[0] : null
            let Maphong = params.Maphong;
            let dataInsert = {
                MaPDK:uuid.v4(),
                Ngayden,
                Ngaydi,
                Chuthich:params.Chuthich,
                Maphong,
                ID_KH: params.ID_KH
            }
            await queryBuilder('phieu_dang_ky').insert(dataInsert);
            await queryBuilder('phong').where("Maphong",Maphong).update({TinhTrang:1});
            return 1;
        } catch (e) {
            console.log(e);
            return 0;
        }
    }
    static async createBookingRoomServiceNumber(req){
        try {
            let params = req.body;
            let numRoom = params.SoPhongDat;
            let typeRoom = params.LoaiPhong;
            // let Maphong = params.Maphong;

            let checkRoom = await queryBuilder('phong').where(
                {
                    "MaKP":typeRoom,
                    "TinhTrang":0
                });
            if(checkRoom.length < numRoom)
            {
                return 0;
            }
            let Ngayden= new Date(params.Ngayden);
            let Ngaydi=new Date(params.Ngaydi)|| null;
            Ngayden = Ngayden.toISOString().split("T")[0]
            Ngaydi = Ngaydi.toISOString().split("T")[0]
            let Chuthich=params.Chuthich  || null;
            let ID_KH= params.ID_KH
            for(var i = 0 ; i < numRoom ; i++){
                let dataInsert = {
                    MaPDK:uuid.v4(),
                    Ngayden,
                    Ngaydi,
                    Chuthich,
                    Maphong: checkRoom[i].Maphong,
                    ID_KH
                }
                await queryBuilder('phieu_dang_ky').insert(dataInsert);
                await queryBuilder('phong').where("Maphong",checkRoom[i].Maphong).update({TinhTrang:1});
            }
            return 1;
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

                await queryBuilder('phong').where("Maphong",MaPhong[0].MaPhong).update({TinhTrang:0});
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