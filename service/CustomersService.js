'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
class RoomService {
    static async listCustomerService(req) {
        try {
            let result = await queryBuilder('khachhang').select();
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async getCustomerService(req){
        try {
            let params = req.body;
            let Email = params.Email;
            let MatKhau = params.MatKhau;
            let result = await queryBuilder('khachhang').where({
                "Email":Email,
                "MatKhau":MatKhau
            }).first();
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async createCustomerService(req){
        try {
            let params = req.body;
            let email = params.Email;
            let check = await queryBuilder('khachhang').where("Email",email).first();
            if(check != null){
                return -1;//trùng email
            }
            let dataInsert = {
                ID_KH: uuid.v4(),
                TenKH: params.TenKH || null,
                GTinh: params.GTinh || null,
                CMND: params.CMND || null,
                Dchi: params.Dchi || null,
                QTich: params.QTich || null,
                SoDT:params.SoDT || null,
                Email:params.Email,
                MatKhau:params.MatKhau
            }
            
            await queryBuilder('khachhang').insert(dataInsert);
            return 1;//Thêm thành công
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async updateCustomerService(req){
        try {
            
            let params = req.body;
            let ID_KH = params.ID_KH;
            let dataUpdate = {
                TenKH: params.TenKH || null,
                GTinh: params.GTinh || null,
                CMND: params.CMND || null,
                Dchi: params.Dchi || null,
                QTich: params.QTich || null,
                SoDT:params.SoDT || null,
                Email:params.Email || null,
                MatKhau:params.MatKhau || null
            }
            await queryBuilder('khachhang').where("ID_KH", ID_KH).update(dataUpdate);
            return "Cập nhật thông tin khách hàng thành công";
        } catch (e) {
            console.log(e);
            return e
        }
    }
}
module.exports = RoomService