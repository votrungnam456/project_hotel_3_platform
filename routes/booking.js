const express = require('express');
const router = express.Router();
const BookingController = require('../controller/BookingController');

router.get('/list', BookingController.listBookingRoom);
// router.get('/:MaPhong', CustomersController.getItem);
router.post('/create', BookingController.createBookingRoom);
router.put('/:MaPhong', BookingController.updateCustomer);
router.delete('/:MaPDK', BookingController.deleteBooking);
module.exports = router;