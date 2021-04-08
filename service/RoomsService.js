'use strict'
const queryBuilder = require('../config/database');
const uuid = require('uuid');
class RoomService {
    static async listRoomService(req) {
        try {
            let result = await queryBuilder('phong').select();
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async getItemService(req){
        try {

            let MaPhong = req.params.MaPhong;
            let result = await queryBuilder('phong').where("MaPhong",MaPhong).first();
            return result;
        } catch (e) {
            console.log(e);
            return e
        }
    }
    static async createRoomsService(req){
        try {
            let params = req.body;
            let dataInsert = {
                MaPhong: params.MaPhong,
                Tenphong: params.Tenphong || null,
                Mota: params.Mota || null,
                MaKP: params.MaKP,
                MaLP: null,
                Trangthai: 1
                
            }
            await queryBuilder('phong').insert(dataInsert);
            return "Tạo phòng thành công";
        } catch (e) {
            console.log(e);
            return e
        }
    }
    ///not done
    static async updateRoomService(req){
        try {
            let idTodo = req.params.MaPhong;
            let params = req.body;
            let dataInsert = {
                title: params.title,
                description: params.description,
                updated_at: new Date(),
            }
            await queryBuilder('todo').where("id", idTodo).update(dataInsert);
            return "Cập nhật công việc thành công";
        } catch (e) {
            console.log(e);
            return e
        }
    }
}
module.exports = RoomService