'use strict'
const Service = require("../service/Service");
class ServiceController {
    static async listServiceController(req, res, next) {
        try {
            let data = await Service.listService(req);
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
    // static async listCheckIn(req, res, next) {
    //     try {
    //         let data = await RoomsService.listCheckInRoomService(req);
    //         res.status(200).json({
    //             status: "SUCCESS",
    //             errors: null,
    //            data
    //         });
    //     } catch (e) {
    //         res.status(200).json({
    //             status: "FAIL",
    //             errors: [{
    //                 code: 1000,
    //                 message: "Server Error"
    //             }],
    //             data: null
    //         });
    //     }
    // }
    // static async typeRoom(req, res, next) {
    //     try {
    //         let data = await RoomsService.typeRoomService(req);
    //         res.status(200).json({
    //             status: "SUCCESS",
    //             errors: null,
    //             data
    //         });
    //     } catch (e) {
    //         res.status(200).json({
    //             status: "FAIL",
    //             errors: [{
    //                 code: 1000,
    //                 message: "Server Error"
    //             }],
    //             data: null
    //         });
    //     }
    // }
    // static async getItem(req, res, next) {
    //     try {
    //         let data = await RoomsService.getItemService(req);
    //         console.log(data)
    //         res.status(200).json({
    //             status: "SUCCESS",
    //             errors: null,
    //            data
    //         });
    //     } catch (e) {
    //         res.status(200).json({
    //             status: "FAIL",
    //             errors: [{
    //                 code: 1000,
    //                 message: "Server Error"
    //             }],
    //             data: null
    //         });
    //     }
    // }
    static async createServiceController(req, res, next){
        try {
            let data = await Service.createService(req);
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
    static async updateServiceController(req, res, next){
        try {
            let data = await Service.updateService(req);
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
    // static async checkInRoom(req, res, next){
    //     try {
    //         let data = await RoomsService.checkInRoomService(req);
    //         res.status(200).json({
    //             status: "SUCCESS",
    //             errors:null,
    //            data
    //         });
    //     } catch (e) {
    //         res.status(200).json({
    //             status: "FAIL",
    //             errors: [{
    //                 code: 1000,
    //                 message: "Server Error"
    //             }],
    //             data: null
    //         });
    //     }
    // }
    // static async checkOutRoom(req, res, next){
    //     try {
    //         let data = await RoomsService.checkOutRoomService(req);
    //         res.status(200).json({
    //             status: "SUCCESS",
    //             errors:null,
    //            data
    //         });
    //     } catch (e) {
    //         res.status(200).json({
    //             status: "FAIL",
    //             errors: [{
    //                 code: 1000,
    //                 message: "Server Error"
    //             }],
    //             data: null
    //         });
    //     }
    // }
    // static async listCheckOut(req, res, next){
    //     try {
    //         let data = await RoomsService.listCheckOutRoomService(req);
    //         res.status(200).json({
    //             status: "SUCCESS",
    //             errors:null,
    //            data
    //         });
    //     } catch (e) {
    //         res.status(200).json({
    //             status: "FAIL",
    //             errors: [{
    //                 code: 1000,
    //                 message: "Server Error"
    //             }],
    //             data: null
    //         });
    //     }
    // }
    static async deleteServiceController(req, res, next){
        try {
            let data = await Service.deleteService(req);
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
module.exports = ServiceController