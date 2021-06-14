'use strict'
const HistoryService = require("../service/HistoryService");
class HistoryController {
    static async historyBookingRoomController(req, res, next) {
        try {
            let data = await HistoryService.historyBookingRoomService(req);
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
    static async searchHistoryBookingRoom(req, res, next) {
        try {
            let data = await HistoryService.searchHistoryBookingRoomService(req);
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
    
    static async historyServiceController(req, res, next) {
        try {
            let data = await HistoryService.historyService(req);
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
    static async searchHistoryServiceController(req, res, next) {
        try {
            let data = await HistoryService.searchHistoryService(req);
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
    static async historyBillController(req, res, next) {
        try {
            let data = await HistoryService.historyBillService(req);
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
    static async searchHistoryBillController(req, res, next) {
        try {
            let data = await HistoryService.searchHistoryBillService(req);
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
}
module.exports = HistoryController