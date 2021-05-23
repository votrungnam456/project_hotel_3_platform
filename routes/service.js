const express = require('express');
const router = express.Router();
const serviceController = require('../controller/ServiceController');

router.get('/list', serviceController.listServiceController);
// // router.get('/:MaPhong', CustomersController.getItem);
router.post('/create', serviceController.createServiceController);
// router.post('/createNumber', BookingController.createBookingRoomNumber);
router.put('/:ID_DV', serviceController.updateServiceController);
router.delete('/:ID_DV', serviceController.deleteServiceController);
module.exports = router;