const express = require('express');
const router = express.Router();
const serviceController = require('../controller/ServiceController');

router.get('/list', serviceController.listServiceController);
// // router.get('/:MaPhong', CustomersController.getItem);
router.post('/create', serviceController.createServiceController);
// router.post('/createNumber', BookingController.createBookingRoomNumber);
// router.put('/:MaPhong', BookingController.updateCustomer);
// router.delete('/:MaPDK', BookingController.deleteBooking);
module.exports = router;