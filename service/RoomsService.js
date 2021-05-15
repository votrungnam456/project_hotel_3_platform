'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
class RoomService {
    static async listRoomService(req) {
        try {
            let result = await queryBuilder().select('phong.MaPhong','phong.Tenphong','phong.Mota','phong.Gia','kieuphong.TenKP','Phong.MaKP','Phong.TinhTrang').from('phong').join('kieuphong', {'Phong.MaKP': 'KieuPhong.MaKP'});
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async listCheckInRoomService(req) {
        try {
            let result = await queryBuilder().select('phong.MaPhong','phong.Tenphong','phong.Gia','kieuphong.TenKP','khachhang.TenKH','khachhang.Email','khachhang.CMND','khachhang.SoDT','phieu_dang_ky.NgayDen').
                                            from('phong').
                                            join('kieuphong', {'Phong.MaKP': 'KieuPhong.MaKP'}).
                                            join('phieu_dang_ky',{'Phong.MaPDK':'phieu_dang_ky.MaPDK'}).
                                            join('khachhang',{'phieu_dang_ky.ID_KH':'khachhang.ID_KH'}).where('TinhTrang',1);
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async typeRoomService(req) {
        try {
            let result = await queryBuilder('kieuphong').select('*');
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async getItemService(req){
        try {

            let MaPhong = req.params.MaPhong;
            let result = await queryBuilder().select('phong.MaPhong','phong.Tenphong','phong.Mota','phong.Gia','kieuphong.TenKP','phong.TinhTrang')
            .from('phong').join('kieuphong', {'Phong.MaKP': 'KieuPhong.MaKP'}).where("MaPhong",MaPhong).first();
            //.where("MaPhong",MaPhong).first();
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
                TinhTrang: 0
                
            }
            let check = await queryBuilder('phong').where("MaPhong",id).first();
            if(check != null){
                return 0;
            }
            else{
                await queryBuilder('phong').insert(dataInsert);
                return 1;
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
            let check = await queryBuilder('phong').where("MaPhong",MaPhong).first();
            if(check == null){
                return 0;
            }
            let dataInsert = {
                Tenphong: params.Tenphong,
                Mota: params.Mota,
                MaKP: params.MaKP,
                Gia: params.Gia,
                TinhTrang: parseInt(params.TinhTrang)
            }
            await queryBuilder('phong').where("MaPhong", MaPhong).update(dataInsert);
            return 1;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async checkInRoomService(req){
        try {
            let MaPhong = req.params.MaPhong;
            // let params = req.body;
            let check = await queryBuilder('phong').where("MaPhong",MaPhong).first();
            if(check == null){
                return 0;
            }
            
            await queryBuilder('phong').where("MaPhong", MaPhong).update('TinhTrang',2);
            return 1;
        } catch (e) {
            console.log(e);
            return e
        }
    }
}
module.exports = RoomService