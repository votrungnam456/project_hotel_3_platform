const express = require('express');
const router = express.Router();
const RoomsController = require('../controller/RoomsController');

router.get('/list', RoomsController.list);
router.get('/typeRooms',RoomsController.typeRoom)
router.get('/:MaPhong', RoomsController.getItem);
router.post('/create', RoomsController.createRoom);
router.put('/:MaPhong', RoomsController.updateRoom);
module.exports = router;