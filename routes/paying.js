const express = require('express');
const router = express.Router();
const PayingController = require('../controller/PayingController');


router.post('/createPaying', PayingController.createPaying);
router.post('/createPayingService', PayingController.createPayingService);

module.exports = router;