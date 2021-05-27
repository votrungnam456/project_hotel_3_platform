'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
const { DateTime } = require('mssql');
const date = require('date-and-time');

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
    static async listCheckOutRoomService(req) {
        try {
            let result = await queryBuilder().select('phong.MaPhong','phong.Tenphong','kieuphong.TenKP','khachhang.TenKH','khachhang.CMND','phieu_dang_ky.MaPDK').
                                            from('phong').
                                            join('kieuphong', {'Phong.MaKP': 'KieuPhong.MaKP'}).
                                            join('phieu_dang_ky',{'Phong.MaPDK':'phieu_dang_ky.MaPDK'}).
                                            join('khachhang',{'phieu_dang_ky.ID_KH':'khachhang.ID_KH'}).where('TinhTrang',2);
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
    static async now(req){
        try {
            let params = req.body;
            // let today = new Date();

            // now = now.toISOString().split("T")[0]

            // let NgayDen = await queryBuilder('phieu_dang_ky').select("Ngayden").where("MaPDK","24182a6a-742a-444f-a2ae-fc7de27ee93e").first();
            // NgayDen = new Date(NgayDen["Ngayden"]);
            // // NgayDi = NgayDi.toISOString().split("T")[0]
            // if(date.isSameDay(NgayDi,NgayDi)){
            //     return true;
            // }
            // let MaPhong = await queryBuilder('phieu_dang_ky').select("Maphong").where("MaPDK","181c2374-6041-4c34-80a5-457819b9a5a0").first();
            // let GiaPhong =  await queryBuilder('phong').select("Gia").where("Maphong",MaPhong["Maphong"]).first();
            // let dichvu = await queryBuilder('hoadondichvu').select().where("MaPDK","181c2374-6041-4c34-80a5-457819b9a5a0").first();
            // if(dichvu == null){
            //     return true;
            // }
            // return false;
            
            // let NgayDen = await queryBuilder('phieu_dang_ky').select("Ngayden").where("MaPDK",MaPDK).first();
            // let gia = params.Gia;


        //    let check = await queryBuilder('phong').select('MaPDK').havingRaw("MaPDK IS NOT ?", [null]);
        //    let arrUser = []
        //    for(let i = 0 ; i< check.length ; i++){
        //         let checkZ = await queryBuilder('phieu_dang_ky').select('ID_KH').where('MaPDK',check[i]["MaPDK"]).first();
        //         arrUser.push(checkZ['ID_KH'])

        //    }
        //    let uniqueValues = [...new Set(arrUser)];
        //    let lastResult = [];
        //    for(let i = 0 ; i< uniqueValues.length ; i++){
        //        let query = await queryBuilder('khachhang').where('ID_KH',uniqueValues[i]).first();
        //        lastResult.push(query);
        //    }
            // let now = new Date("2021-5-21");
            // let d = new Date("2021-5-27")
            // let TienPhong = date.subtract(d,now).toDays();
            // return TienPhong;

            // let result = await queryBuilder('hoadondichvu').where("MaPDK","bab699ac-d953-4e95-9ad8-4bf90181acd");
            // let tien = 0;
            // result.forEach(hoadon => {
            //     tien +=hoadon["GiaDichVu"]
            // });
            let today = new Date();
            let now = new Date(today.getFullYear()+'-'+(today.getMonth()+1)+'-'+(today.getDate()+1));
            now = now.toISOString().split("T")[0]
            return now;
        // let check = await queryBuilder('phong').select('MaPDK').havingRaw("MaPDK IS NOT ?", [null]);
        // let arrUser = []
        // for(let i = 0 ; i< check.length ; i++){
        //      let checkZ = await queryBuilder('phieu_dang_ky').select('ID_KH').where('MaPDK',check[i]["MaPDK"]).first();
        //      arrUser.push(checkZ['ID_KH'])

        // }
        // let uniqueValues = [...new Set(arrUser)];
        // let lastResult = [];
        // for(let i = 0 ; i< uniqueValues.length ; i++){
        //     let query = await queryBuilder('khachhang').where('ID_KH',uniqueValues[i]).first();
        //     lastResult.push(query);
        // }
        // let a = await queryBuilder('khachhang').whereNotExists(lastResult)
        //  return a;
        } catch (e) {
            console.log(e);
            return e
        }
    }
}
module.exports = RoomService