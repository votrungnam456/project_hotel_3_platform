const express = require('express');
const router = express.Router();
const RoomsController = require('../controller/RoomsController');

router.get('/list', RoomsController.list);

module.exports = router;