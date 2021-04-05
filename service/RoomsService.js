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
}
module.exports = RoomService