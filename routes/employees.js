const express = require('express');
const router = express.Router();
const employeesController = require('../controller/EmployeesController');

router.get('/list', employeesController.listEmployeesController);
// router.get('/list', employeesController.listAccount);
router.get('/decentralization', employeesController.listDecentralizationController);
router.post('/create', employeesController.createEmployeesController);
router.post('/user', employeesController.loginEmployeesController);
// router.put('/:MaPhong', BookingController.updateCustomer);
// router.delete('/:MaPDK', BookingController.deleteBooking);
module.exports = router;