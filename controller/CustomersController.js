'use strict'
const CustomersService = require("../service/CustomersService");
class CustomersController {
    static async list(req, res, next) {
        try {
            let data = await CustomersService.listCustomerService(req);
            res.status(200).json({
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
    static async listExist(req, res, next) {
        try {
            let data = await CustomersService.listCustomerExistService(req);
            res.status(200).json({
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
    static async getCustomer(req, res, next) {
        try {
            let data = await CustomersService.getCustomerService(req);
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

    static async createCustomer(req, res, next){
        try {
            let data = await CustomersService.createCustomerService(req);
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
            let data = await CustomersService.updateCustomerService(req);
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
module.exports = CustomersController