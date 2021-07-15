'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
const { DateTime } = require('mssql');
const date = require('date-and-time');

class RoomService {
    static async listRoomService(req) {
        try {
            let result = await queryBuilder().select('phong.MaPhong','phong.Tenphong','phong.Mota','phong.Gia','kieuphong.TenKP','Phong.MaKP','Phong.TinhTrang').from('phong').join('kieuphong', {'Phong.MaKP': 'KieuPhong.MaKP'}).orderBy('phong.Maphong');
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async changeRoomsService(req) {
        try {
            let MaPhongBiDoi= req.body.MaPhongBiDoi;
            let MaPhongDoi= req.body.MaPhongDoi;
            let PhongDoi = await queryBuilder().select('*').from('phong').where("Maphong",MaPhongDoi).first();
            let PhongBiDoi = await queryBuilder().select('*').from('phong').where("Maphong",MaPhongBiDoi).first();
            await queryBuilder('phieu_dang_ky').where("MaPDK", PhongDoi.MaPDK).update({
                'Maphong':MaPhongBiDoi,
                'GiaPhong':PhongBiDoi.Gia
            });
            await queryBuilder('phong').where("Maphong", MaPhongDoi).update({
                'TinhTrang':0,
                'MaPDK':null
            });
            await queryBuilder('phong').where("Maphong", MaPhongBiDoi).update({
                'TinhTrang':PhongDoi.TinhTrang,
                'MaPDK':PhongDoi.MaPDK
            });
            return 1
        } catch (e) {
            console.log(e);
            return 0
        }
    }

    static async listUsingRoomsService(req) {
        try {
            let result = await queryBuilder().select('phong.MaPhong','phong.Tenphong').
                                            from('phong').where({
                                                'TinhTrang':1
                                            }).orWhere({'TinhTrang':2}).orderBy('phong.Maphong');
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async listEmptyRoomsService(req) {
        try {
            let result = await queryBuilder().select('phong.MaPhong','phong.Tenphong').
                                            from('phong').where('TinhTrang',0).orderBy('phong.Maphong');
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
                                            join('khachhang',{'phieu_dang_ky.ID_KH':'khachhang.ID_KH'}).where('TinhTrang',1).orderBy('phong.Maphong');
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async searchCheckInRoomService(req) {
        try {
            let filter = req.params.content;
            let result = await queryBuilder().select('phong.MaPhong','phong.Tenphong','phong.Gia','kieuphong.TenKP','khachhang.TenKH','khachhang.Email','khachhang.CMND','khachhang.SoDT','phieu_dang_ky.NgayDen').
                                            from('phong').
                                            join('kieuphong', {'Phong.MaKP': 'KieuPhong.MaKP'}).
                                            join('phieu_dang_ky',{'Phong.MaPDK':'phieu_dang_ky.MaPDK'}).
                                            join('khachhang',{'phieu_dang_ky.ID_KH':'khachhang.ID_KH'}).
                                            where('TinhTrang',1).where('khachhang.TenKH','like','%'+filter+'%').orderBy('phong.Maphong');
            if(result.length > 0){
                return result;
            }
            else{
                return [{
                    'MaPhong':'-1'
                }]
            }
            
        } catch (e) {
            console.log(e);
            return e
        }
    }   
    static async listCheckOutRoomService(req) {
        try {
            let result = await queryBuilder().select('phong.MaPhong','phong.Tenphong','kieuphong.TenKP','khachhang.TenKH','khachhang.CMND','phieu_dang_ky.MaPDK').
                                            from('phong').
                                            join('kieuphong', {'Phong.MaKP': 'KieuPhong.MaKP'}).
                                            join('phieu_dang_ky',{'Phong.MaPDK':'phieu_dang_ky.MaPDK'}).
                                            join('khachhang',{'phieu_dang_ky.ID_KH':'khachhang.ID_KH'}).where('TinhTrang',2).orderBy('khachhang.TenKH');
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async listSearchCheckOutRoomService(req) {
        try {
            let filter = req.params.content;
            let result = await queryBuilder().select('phong.MaPhong','phong.Tenphong','kieuphong.TenKP','khachhang.TenKH','khachhang.CMND','phieu_dang_ky.MaPDK').
                                            from('phong').
                                            join('kieuphong', {'Phong.MaKP': 'KieuPhong.MaKP'}).
                                            join('phieu_dang_ky',{'Phong.MaPDK':'phieu_dang_ky.MaPDK'}).
                                            join('khachhang',{'phieu_dang_ky.ID_KH':'khachhang.ID_KH'}).
                                            where('TinhTrang',2).where('khachhang.TenKH','like','%'+filter+'%').orderBy('khachhang.TenKH');
            if(result.length > 0){
                return result;
            }
            else{
                return [{
                    'MaPhong':'-1'
                }]
            }
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
            let dataUpdate = {
                Tenphong: params.Tenphong,
                Mota: params.Mota,
                MaKP: params.MaKP,
                Gia: params.Gia,
                TinhTrang: parseInt(params.TinhTrang)
            }
            await queryBuilder('phong').where("MaPhong", MaPhong).update(dataUpdate);
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
    static async checkOutRoomService(req){
        try {
            let MaPhong = req.params.MaPhong;
            let params = req.body;
            let MaPDK = params.MaPDK;
            let today = new Date();
            let now = new Date(today.getFullYear()+'-'+(today.getMonth()+1)+'-'+(today.getDate()+1));
            let check = await queryBuilder('phong').where("MaPhong",MaPhong).first();
            if(check == null){
                return 0;
            }
            let checkOut = await queryBuilder('phieu_dang_ky').select("Ngaydi").where("MaPDK",MaPDK).first();
            if(checkOut["Ngaydi"] == null || !date.isSameDay(checkOut,now)){
                now = now.toISOString().split("T")[0]
                await queryBuilder('phieu_dang_ky').where("MaPDK", MaPDK).update({
                    'Ngaydi':now
                });
            }
            await queryBuilder('phong').where("MaPhong", MaPhong).update({
                'TinhTrang':0,
                'MaPDK':null
            });
            return 1;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async cancelBookingService(req){
        try {
            let maPhong = req.params.MaPhong;

            let getMaPDK = await queryBuilder('phong').select('phong.MaPDK').where('Maphong',maPhong).first();

            await queryBuilder('phong').where('MaPDK',getMaPDK.MaPDK).update({
                'TinhTrang':0,
                'MaPDK':null
            })
            await queryBuilder('phieu_dang_ky').where('MaPDK',getMaPDK.MaPDK).del()
            return 1;
        } catch (e) {
            console.log(e);
            return 0;
        }
    }
}
module.exports = RoomService