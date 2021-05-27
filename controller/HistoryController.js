'use strict'
const HistoryService = require("../service/HistoryService");
class HistoryController {
    static async historyBookingRoom(req, res, next) {
        try {
            let data = await HistoryService.HistoryBookingRoomService(req);
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
            let data = await HistoryService.HistoryService(req);
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
            let data = await HistoryService.HistoryBillService(req);
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