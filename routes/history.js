const express = require('express');
const router = express.Router();
const HistoryController = require('../controller/HistoryController');

router.get('/historyBookingRoom', HistoryController.historyBookingRoom);
router.get('/historyService', HistoryController.historyServiceController);
router.get('/historyBill', HistoryController.historyBillController);
module.exports = router;