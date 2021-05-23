'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
const date = require('date-and-time');
const { Int } = require('mssql');
class Service {
    static async listService(req) {
        try {
            let result = await queryBuilder('dichvu').select().where("Enable",1);
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async deleteService(req){
        try {
            let ID_DV = req.params.ID_DV;
            await queryBuilder('dichvu').update("Enable", 0).where("ID_DV",ID_DV);
            return 1;
        } catch (e) {
            console.log(e);
            return 0;
        }
    }
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
                Gia :gia,
                Enable:1
            }

            await queryBuilder('dichvu').insert(dataInsert);
            return 1;
        } catch (e) {
            console.log(e);
            return -1;
        }
    }
    static async updateService(req){
        try {
            
            let params = req.body;
            let ID_DV = req.params.ID_DV;
            let dataUpdate = {
                TenDV:params.TenDV,
                Gia :params.Gia
            }
            await queryBuilder('dichvu').where("ID_DV", ID_DV).update(dataUpdate);
            return 1;
        } catch (e) {
            console.log(e);
            return 0;
        }
    }
}
module.exports = Service