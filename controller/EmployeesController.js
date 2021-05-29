'use strict'
const EmployeesService = require("../service/EmployeesService");
class EmployeesController {
    static async listEmployeesController(req, res, next) {
        try {
            let data = await EmployeesService.listEmployeesService(req);
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
    static async listAccount(req, res, next) {
        try {
            let data = await EmployeesService.listAccountService(req);
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
    static async updateEmployeesController(req, res, next) {
        try {
            let data = await EmployeesService.updateEmployeesService(req);
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
    static async listDecentralizationController(req, res, next) {
        try {
            let data = await EmployeesService.listDecentralizationService(req);
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
    static async createEmployeesController(req, res, next){
        try {
            let data = await EmployeesService.createEmployeesService(req);
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
    static async deleteEmployeesController(req, res, next){
        try {
            let data = await EmployeesService.deleteEmployeesService(req);
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
    static async loginEmployeesController(req, res, next){
        try {
            let data = await EmployeesService.loginEmployeesService(req);
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
module.exports = EmployeesController