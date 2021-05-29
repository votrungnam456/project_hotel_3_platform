const express = require('express');
const router = express.Router();
const employeesController = require('../controller/EmployeesController');

router.get('/list', employeesController.listEmployeesController);
// router.get('/list', employeesController.listAccount);
router.get('/decentralization', employeesController.listDecentralizationController);
router.post('/create', employeesController.createEmployeesController);
router.post('/user', employeesController.loginEmployeesController);
router.put('/:ID_NV', employeesController.updateEmployeesController);
router.delete('/:ID_NV', employeesController.deleteEmployeesController);
module.exports = router;