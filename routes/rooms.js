const express = require('express');
const router = express.Router();
const RoomsController = require('../controller/RoomsController');

router.get('/list', RoomsController.list);
router.get('/listCheckIn', RoomsController.listCheckIn);
router.get('/listCheckIn/search/:content', RoomsController.listSearchCheckIn);
router.get('/listCheckOut', RoomsController.listCheckOut);
router.get('/listCheckOut/search/:content', RoomsController.listSearchCheckOut);
router.get('/typeRooms',RoomsController.typeRoom)
router.get('/:MaPhong', RoomsController.getItem);
router.post('/create', RoomsController.createRoom);
router.put('/:MaPhong', RoomsController.updateRoom);
router.put('/checkIn/:MaPhong', RoomsController.checkInRoom);
router.put('/checkOut/:MaPhong', RoomsController.checkOutRoom);
router.delete('/cancelBooking/:MaPhong',RoomsController.cancelBooking)
module.exports = router;