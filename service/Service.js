'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
const date = require('date-and-time');
const { Int } = require('mssql');
class Service {
    static async listService(req) {
        try {
            let result = await queryBuilder('dichvu').select();
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
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
    static async createService(req){
        try {
            let params = req.body;
            let tenDichVu = params.TenDV;
            let gia = params.Gia;
            gia = parseInt(gia);
            let check = await queryBuilder('dichvu').where('TenDV',tenDichVu).first();
            if(check != null){
                return 0;
            }
            let dataInsert = {
                ID_DV : uuid.v4(),
                TenDV : tenDichVu,
                Gia :gia
            }

            await queryBuilder('dichvu').insert(dataInsert);
            return 1;
        } catch (e) {
            console.log(e);
            return -1;
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
module.exports = Service