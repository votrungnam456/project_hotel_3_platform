'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
const date = require('date-and-time');
class EmployeesService {
    static async listEmployeesService(req) {
        try {
            let result = await queryBuilder().select('*').from('nhanvien').join('taikhoan_nhanvien',{'nhanvien.ID_NV':'taikhoan_nhanvien.ID_NV'});
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async listAccountService(req){
        try {
            let params = req.body;
            let Email = params.Email;
            let MatKhau = params.MatKhau;
            let result = await queryBuilder('taikhoan_nhanvien').where({
                "Email":Email,
                "MatKhau":MatKhau
            }).first();
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async listDecentralizationService(req){
        try {
            let result = await queryBuilder('phanquyen').select();
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    
    static async createEmployeesService(req){
        try {
            let params = req.body;
            let ID_NV = uuid.v4();
            let email = params.Email;
            let cmnd = params.Cmnd
            let checkCMND = await queryBuilder('nhanvien').where("CMND",cmnd).first();
            if(checkCMND != null){
                return -2;//trùng cmnd
            }
            let checkEmail = await queryBuilder('taikhoan_nhanvien').where("Email",email).first();
            if(checkEmail != null){
                return -1;//trùng email
            }
            let dataInsertNV = {
                ID_NV,
                TenNV: params.TenNV,
                Gtinh: params.Gtinh,
                Cmnd: cmnd,
                Dchi: params.Dchi,
                Sodt:params.Sodt,
            }
            
            await queryBuilder('nhanvien').insert(dataInsertNV);
            let dataInsertAccount = {
                ID_NV,
                Email:email,
                MatKhau: params.MatKhau,
                ID_Quyen: params.ID_Quyen
            }
            await queryBuilder('taikhoan_nhanvien').insert(dataInsertAccount);
            return 1
        } catch (e) {
            console.log(e);
            return -1;
        }
    }
    static async loginEmployeesService(req){
        try {
            let params = req.body;
            let email = params.Email
            let pwd = params.pwd
            let check = await queryBuilder('taikhoan_nhanvien').where({
                Email:email,
                MatKhau:pwd
            }).first();
            if(check == null){
                return [{
                    ID_NV:null,
                    Quyen:null,
                    TenNV:null,
                    CoQuyen:null,
                    checkError:0
                }];
            }
            let result = await queryBuilder('nhanvien').select('*').where('ID_NV',check['ID_NV']).first();
            let PG = await queryBuilder('phanquyen').where('ID_Quyen',check['ID_Quyen']).first();
                return [{
                    ID_NV:result['ID_NV'],
                    Quyen:PG['TenQuyen'],
                    TenNV:result['TenNV'],
                    CoQuyen:PG['CoQuyen'],
                    checkError : 1   
                }]
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
module.exports = EmployeesService