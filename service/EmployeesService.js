'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
const date = require('date-and-time');
class EmployeesService {
    static async listEmployeesService(req) {
        try {
            let result = await queryBuilder().select('*').from('nhanvien').
                                join('taikhoan_nhanvien',{'nhanvien.ID_NV':'taikhoan_nhanvien.ID_NV'}).
                                join('phanquyen',{'phanquyen.ID_Quyen':'taikhoan_nhanvien.ID_Quyen'}).where('Enable',1).orderBy('nhanvien.ID_NV');
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async searchEmployeesService(req) {
        try {
            let filter = req.params.content;
            let result = await queryBuilder().select('*').from('nhanvien').
                                join('taikhoan_nhanvien',{'nhanvien.ID_NV':'taikhoan_nhanvien.ID_NV'}).
                                join('phanquyen',{'phanquyen.ID_Quyen':'taikhoan_nhanvien.ID_Quyen'}).where('Enable',1).where('TenNV','like','%'+filter+'%').orderBy('nhanvien.ID_NV');
            if(result.length > 0){
                return result;
            }                    
            else{
                return [{
                    ID_NV:"-1"
                }];
            }
        } catch (e) {
            console.log(e);
            return e
        }
    }
    
    static async getEmployeeService(req) {
        try {
            let ID_NV = req.params.ID_NV;
            let result = await queryBuilder().select('*').from('nhanvien').
                                join('taikhoan_nhanvien',{'nhanvien.ID_NV':'taikhoan_nhanvien.ID_NV'}).
                                join('phanquyen',{'phanquyen.ID_Quyen':'taikhoan_nhanvien.ID_Quyen'})
                                .where(
                                    {
                                        'nhanvien.ID_NV':ID_NV,
                                        'Enable':1
                                    }
                                );
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async listDecentralizationService(req){
        try {
            let result = await queryBuilder('phanquyen').select('*');
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
                Enable:1
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
            let check = await queryBuilder('taikhoan_nhanvien').join('nhanvien',{'nhanvien.ID_NV':'taikhoan_nhanvien.ID_NV'})
            .where({
                Email:email,
                MatKhau:pwd,
                Enable:1
            }).first();
            if(check == null){
                return [{
                    ID_NV:'-1'
                }]
            }
            let result = await queryBuilder('nhanvien').select('*').where('ID_NV',check['ID_NV']).first();
            let PG = await queryBuilder('phanquyen').where('ID_Quyen',check['ID_Quyen']).first();
                return [{
                    ID_NV:result['ID_NV'],
                    Quyen:PG['TenQuyen'],
                    TenNV:result['TenNV'],
                    CoQuyen:PG['CoQuyen'],
                }]
        } catch (e) {
            console.log(e);
            return -1;
        }
    }
    static async deleteEmployeesService(req){
        try {
            let ID_NV = req.params.ID_NV;
            await queryBuilder('nhanvien').where("ID_NV",ID_NV).update('Enable',0);
            return 1;
        } catch (e) {
            console.log(e);
            return 0;
        }
    }
    static async updateEmployeesService(req){
        try {
            let ID_NV = req.params.ID_NV;
            let params = req.body;
            let dataUpdateEmp = {
                TenNV:params.TenNV,
                Gtinh:params.GTinh,
                Cmnd:params.CMND,
                Dchi:params.DChi,
                Sodt:params.SoDT,
            }
            let dataUpdateEmpAccount = {
                Email:params.Email,
                MatKhau:params.MatKhau,
                ID_Quyen:params.ID_Quyen
            }
            await queryBuilder('nhanvien').where("ID_NV", ID_NV).update(dataUpdateEmp);
            await queryBuilder('taikhoan_nhanvien').where("ID_NV", ID_NV).update(dataUpdateEmpAccount);
            return 1;
        } catch (e) {
            console.log(e);
            return 0;
        }
    }
}
module.exports = EmployeesService