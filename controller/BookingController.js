'use strict'
const BookingService = require("../service/BookingService");
class BookingController {
    static async listBookingRoom(req, res, next) {
        try {
            let data = await BookingService.listBookingRoomService(req);
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

    static async createBookingRoom(req, res, next){
        try {
            let data = await BookingService.createBookingRoomService(req);
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
    static async createBookingRoomNumber(req, res, next){
        try {
            let data = await BookingService.createBookingRoomServiceNumber(req);
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

    static async updateCustomer(req, res, next){
        try {
            let data = await BookingService.updateBookingRoomService(req);
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
    static async deleteBooking(req, res, next){
        try {
            let data = await BookingService.deleteBookingService(req);
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
module.exports = BookingController