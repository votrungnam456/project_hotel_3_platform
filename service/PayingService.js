'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
const date = require('date-and-time');
class PayingService {
    // static async listCustomerService(req) {
    //     try {
    //         let result = await queryBuilder('khachhang').select();
    //         return result;
    //     } catch (e) {
    //         console.log(e);
    //         return e
    //     }
    // }
    // static async getCustomerService(req){
    //     try {
    //         let params = req.body;
    //         let Email = params.Email;
    //         let MatKhau = params.MatKhau;
    //         let result = await queryBuilder('khachhang').where({
    //             "Email":Email,
    //             "MatKhau":MatKhau
    //         }).first();
    //         return result;
    //     } catch (e) {
    //         console.log(e);
    //         return e
    //     }
    // }
    //Tạo hoá đơn
    static async createPaying(req){
        try {
            let params = req.body;
            let MaPDK = params.MaPDK;
            let ID_NV = params.ID_NV;
            let MaPhong = params.MaPhong
            let today = new Date();
            let now = new Date(today.getFullYear()+'-'+(today.getMonth()+1)+'-'+(today.getDate()+1));

            
            let data =  await queryBuilder('phieu_dang_ky').select("GiaPhong","Ngayden").where("MaPDK",MaPDK).first();
            let NgayDen = new Date(data["Ngayden"]);
            let TienPhong;
            if( date.subtract(now,NgayDen).toDays() == 0){
                TienPhong = data["GiaPhong"];
            }
            else {
                TienPhong = data["GiaPhong"] * date.subtract(now,NgayDen).toDays();
            }
            now = now.toISOString().split("T")[0]
            let getHHDV = await queryBuilder('hoadondichvu').where("MaPDK",MaPDK);
            let TienDichVu = 0;
            getHHDV.forEach(hoadon => {
                TienDichVu +=hoadon["GiaDichVu"]
            });

            let dataInsert = {
                MaPTT : uuid.v4(),
                MaPDK,
                TienThuePhong:TienPhong,
                TienDichVu,
                NgayThanhToan:now,
                ID_NV:ID_NV
            }
            await queryBuilder('phieu_thanh_toan').insert(dataInsert);
            await queryBuilder('phong').where("MaPhong", MaPhong).update({
                TinhTrang:0,
                MaPDK:null
            });
            return 1;//Thêm thành công
        } catch (e) {
            console.log(e);
            return 0;
        }
    }
    //Tạo hoá đơn dịch vụ
    static async createPayingService(req){
        try {
            let params = req.body;
            let MaPDK = params.MaPDK;
            let check = await queryBuilder('phong').where("MaPDK",MaPDK).first();
            if(check == null) return 0;
            let ID_DV = params.ID_DV;
            let today = new Date();
            let now = new Date(today.getFullYear()+'-'+(today.getMonth()+1)+'-'+(today.getDate()+1));
            now = now.toISOString().split("T")[0]



            let getPrice = await queryBuilder('dichvu').select("Gia").where("ID_DV",ID_DV).first();
            if(getPrice == null){
                return 0;
            }
            let dataInsert = {
                IDHDDV:uuid.v4(),
                ID_DV,
                MaPDK,
                NgayLap:now,
                GiaDichVu:getPrice["Gia"]
            }
            await queryBuilder('hoadondichvu').insert(dataInsert);
            // let data =  await queryBuilder('phieu_dang_ky').select("GiaPhong","Ngayden").where("MaPDK",MaPDK).first();
            // let NgayDen = new Date(data["Ngayden"]);
            // let TienPhong = GiaPhong * date.subtract(now,NgayDen).toDays();
            // let TienDichVu = 0;
            // // let dichvu = await queryBuilder('hoadondichvu').select().where("MaPDK",MaPDK).first();
            // // if(dichvu != null){
            // //     return true;
            // // }
            return 1;//Thêm thành công
        } catch (e) {
            console.log(e);
            return e
        }
    }
    // static async updateCustomerService(req){
    //     try {
            
    //         let params = req.body;
    //         let ID_KH = params.ID_KH;
    //         let dataUpdate = {
    //             TenKH: params.TenKH || null,
    //             GTinh: params.GTinh || null,
    //             CMND: params.CMND || null,
    //             Dchi: params.Dchi || null,
    //             QTich: params.QTich || null,
    //             SoDT:params.SoDT || null,
    //             Email:params.Email || null,
    //             MatKhau:params.MatKhau || null
    //         }
    //         await queryBuilder('khachhang').where("ID_KH", ID_KH).update(dataUpdate);
    //         return "Cập nhật thông tin khách hàng thành công";
    //     } catch (e) {
    //         console.log(e);
    //         return e
    //     }
    // }
}
module.exports = PayingService