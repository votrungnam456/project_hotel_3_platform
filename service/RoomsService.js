'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
class RoomService {
    static async listRoomService(req) {
        try {
            let result = await queryBuilder().select('phong.Tenphong','phong.Mota','phong.Gia','kieuphong.TenKP').from('phong').join('kieuphong', {'Phong.MaKP': 'KieuPhong.MaKP'});
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async getItemService(req){
        try {

            let MaPhong = req.params.MaPhong;
            let result = await queryBuilder().select('*').from('phong').join('kieuphong', {'Phong.MaKP': 'KieuPhong.MaKP'})
            // where("MaPhong",MaPhong).first();
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async createRoomsService(req){
        try {
            let params = req.body;
            let id = params.MaPhong;
            let dataInsert = {
                MaPhong: params.MaPhong,
                Tenphong: params.Tenphong || null,
                Mota: params.Mota || null,
                MaKP: params.MaKP,
                Gia: params.Gia,
                Trangthai: 1
                
            }
            let check = await queryBuilder('phong').where("MaPhong",id).first();
            if(check != null){
                return "Mã phòng đã tồn tại";
            }
            else{
                await queryBuilder('phong').insert(dataInsert);
                return "Tạo phòng thành công";
            }

        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async updateRoomService(req){
        try {
            let MaPhong = req.params.MaPhong;
            let params = req.body;
            let dataInsert = {
                Tenphong: params.Tenphong,
                Mota: params.Mota,
                MaKP: params.MaKP,
                Gia: params.Gia,
                Trangthai: params.Trangthai
            }
            await queryBuilder('phong').where("MaPhong", MaPhong).update(dataInsert);
            return "Cập nhật công việc thành công";
        } catch (e) {
            console.log(e);
            return e
        }
    }
}
module.exports = RoomService