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
    static async listCustomerExistService(req) {
        try {
            let check = await queryBuilder('phong').select('MaPDK').havingRaw("MaPDK IS NOT ?", [null]);
            let arrUser = []
            for(let i = 0 ; i< check.length ; i++){
                    let checkZ = await queryBuilder('phieu_dang_ky').select('ID_KH').where('MaPDK',check[i]["MaPDK"]).first();
                    arrUser.push(checkZ['ID_KH'])

            }
            let uniqueValues = [...new Set(arrUser)];
            let lastResult = [];
            for(let i = 0 ; i< uniqueValues.length ; i++){
                let query = await queryBuilder('khachhang').where('ID_KH',uniqueValues[i]).first();
                lastResult.push(query);
            }
            return lastResult;
        } catch (e) {
            console.log(e);
            return e
        }
    } 
    static async getListBookingCustomerService(req){
        try {
            let ID_KH = req.params.ID_KH;
            let roomUsing = await queryBuilder().select('*').from('phieu_dang_ky').join('phong',{'phieu_dang_ky.MaPDK':'phong.MaPDK'}).where('ID_KH',ID_KH);
            let all = await queryBuilder().select('phieu_dang_ky.MaPDK','phieu_dang_ky.Ngayden','phieu_dang_ky.Ngaydi','phieu_dang_ky.Maphong','phieu_dang_ky.GiaPhong').from('phieu_dang_ky').where('ID_KH',ID_KH).orderBy('phieu_dang_ky.Maphong');


            for(let PDK of all){
                let getTenPhong = await queryBuilder().select('phong.Tenphong').from('phong').where('Maphong',PDK.Maphong).first();
                PDK.TenPhong = getTenPhong.Tenphong;
            }
            all.forEach(PDK_ALL => {
                let check = false;
                roomUsing.forEach(PDK_USING => {
                    if(PDK_ALL.MaPDK == PDK_USING.MaPDK){
                        PDK_ALL.TinhTrangPDK = PDK_USING.TinhTrang;
                        check = true;
                        return;
                    }
                });
                if(!check){
                    PDK_ALL.TinhTrangPDK = 0;
                }
            });



            return all;
        } catch (e) {
            console.log(e);
            return e;
        }
    }
    static async getCustomerService(req){
        try {
            let params = req.body;
            let Email = params.Email;
            let MatKhau = params.MatKhau;
            let result = await queryBuilder('khachhang')
            .select('khachhang.ID_KH','khachhang.TenKH','khachhang.Gtinh','khachhang.Cmnd','khachhang.Dchi','khachhang.Qtich','khachhang.Sodt','khachhang.Email')
            .where({
                "Email":Email,
                "MatKhau":MatKhau
            }).first();
            if(result != null){
                return result;
            }
            else{return 0}
        } catch (e) {
            console.log(e);
            return e;
        }
    }
    static async createCustomerService(req){
        try {
            let params = req.body;
            let email = params.Email;
            let cmnd = params.CMND
            let checkCMND = await queryBuilder('khachhang').where("CMND",cmnd).first();
            if(checkCMND != null){
                return -2;//trùng cmnd
            }
            let checkEmail = await queryBuilder('khachhang').where("Email",email).first();
            if(checkEmail != null){
                return -1;//trùng email
            }
            let dataInsert = {
                ID_KH: uuid.v4(),
                TenKH: params.TenKH,
                GTinh: params.GTinh,
                Cmnd: params.CMND,
                Dchi: params.Dchi || null,
                QTich: params.QTich,
                Sodt:params.SoDT || null,
                Email:email,
                MatKhau:params.MatKhau
            }
            
            await queryBuilder('khachhang').insert(dataInsert);
            return 1;//Thêm thành công
        } catch (e) {
            console.log(e);
            return e
        }
    }
    
    static async changePwdCustomerService(req){
        try {
            
            let params = req.body;
            let ID_KH = req.params.ID_KH;
            let oldPwd = params.oldPwd;
            let check = await queryBuilder('khachhang').where({
                "ID_KH":ID_KH,
                "MatKhau":oldPwd
            }).first();
            if(check == null){
                return 0;
            }
            let dataChangePwd = {
                MatKhau:params.newPwd
            }
            await queryBuilder('khachhang').where("ID_KH", ID_KH).update(dataChangePwd);
            return 1;

        } catch (e) {
            console.log(e);
            return 0;
        }
    }
    static async updateCustomerService(req){
        try {
            
            let params = req.body;
            let ID_KH = req.params.ID_KH;
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
            return 1;
        } catch (e) {
            console.log(e);
            return 0;
        }
    }
}
module.exports = RoomService