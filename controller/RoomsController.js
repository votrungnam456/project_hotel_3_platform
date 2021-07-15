'use strict'
const RoomsService = require("../service/RoomsService");
class RoomsController {
    static async list(req, res, next) {
        try {
            let data = await RoomsService.listRoomService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors: null,
               data
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
    static async changeRooms(req, res, next) {
        try {
            let data = await RoomsService.changeRoomsService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors: null,
               data
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
    static async listUsingRooms(req, res, next) {
        try {
            let data = await RoomsService.listUsingRoomsService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors: null,
               data
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
    
    static async listEmptyRooms(req, res, next) {
        try {
            let data = await RoomsService.listEmptyRoomsService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors: null,
               data
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
    
    static async listCheckIn(req, res, next) {
        try {
            let data = await RoomsService.listCheckInRoomService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors: null,
               data
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
    static async listSearchCheckIn(req, res, next){
        try {
            let data = await RoomsService.searchCheckInRoomService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors:null,
               data
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
    static async typeRoom(req, res, next) {
        try {
            let data = await RoomsService.typeRoomService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors: null,
                data
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
               data
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
               data
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
            let data = await RoomsService.updateRoomService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors:null,
               data
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
    static async checkInRoom(req, res, next){
        try {
            let data = await RoomsService.checkInRoomService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors:null,
               data
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
    static async checkOutRoom(req, res, next){
        try {
            let data = await RoomsService.checkOutRoomService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors:null,
               data
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
    static async listCheckOut(req, res, next){
        try {
            let data = await RoomsService.listCheckOutRoomService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors:null,
               data
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

    static async listSearchCheckOut(req, res, next){
        try {
            let data = await RoomsService.listSearchCheckOutRoomService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors:null,
               data
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
    static async cancelBooking(req, res, next){
        try {
            let data = await RoomsService.cancelBookingService(req);
            res.status(200).json({
                status: "SUCCESS",
                errors:null,
               data
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