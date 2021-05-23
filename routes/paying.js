const express = require('express');
const router = express.Router();
const PayingController = require('../controller/PayingController');

// router.get('/list', BookingController.listBookingRoom);
// // router.get('/:MaPhong', CustomersController.getItem);
router.post('/createPaying', PayingController.createPaying);
router.post('/createPayingService', PayingController.createPayingService);
// router.post('/createNumber', BookingController.createBookingRoomNumber);
// router.put('/:MaPhong', BookingController.updateCustomer);
// router.delete('/:MaPDK', BookingController.deleteBooking);
module.exports = router;