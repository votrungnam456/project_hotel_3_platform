'use strict'
const AprioriService = require("../service/AprioriService");
class AprioriController {
    static async listDataController(req, res, next) {
        try {
            let data = await AprioriService.listDataService(req);
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
    static async listFieldNameController(req, res, next) {
        try {
            let data = await AprioriService.listFieldNameService(req);
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
module.exports = AprioriController