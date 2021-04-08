'use strict'
const RoomsService = require("../service/RoomsService");
class RoomsController {
    static async list(req, res, next) {
        try {
            let data = await RoomsService.listRoomService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors: null,
                data: {
                    result: data
                }
            });
        } catch (e) {
            res.status(200).json({
                status: "FAIL",
                errors: [{
                    code: 1000,
                    message: "Server Error"
                }],
                data: null
            });
        }
    }
    static async getItem(req, res, next) {
        try {
            let data = await RoomsService.getItemService(req);
            console.log(data)
            res.status(200).json({
                status: "SUCCESS",
                errors: null,
                data: {
                    result: data
                }
            });
        } catch (e) {
            res.status(200).json({
                status: "FAIL",
                errors: [{
                    code: 1000,
                    message: "Server Error"
                }],
                data: null
            });
        }
    }
    static async createRoom(req, res, next){
        try {
            let data = await RoomsService.createRoomsService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors:null,
                data: {
                    result: data
                }
            });
        } catch (e) {
            res.status(200).json({
                status: "FAIL",
                errors: [{
                    code: 1000,
                    message: "Server Error"
                }],
                data: null
            });
        }
    }
    static async updateRoom(req, res, next){
        try {
            let data = await TodoService.updateRoomService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors:null,
                data: {
                    result: data
                }
            });
        } catch (e) {
            res.status(200).json({
                status: "FAIL",
                errors: [{
                    code: 1000,
                    message: "Server Error"
                }],
                data: null
            });
        }
    }
}
module.exports = RoomsController