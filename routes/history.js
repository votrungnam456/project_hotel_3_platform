const express = require('express');
const router = express.Router();
const HistoryController = require('../controller/HistoryController');

router.get('/historyBookingRoom', HistoryController.historyBookingRoomController);
router.get('/historyBookingRoom/search/:content', HistoryController.searchHistoryBookingRoom);
router.get('/historyService', HistoryController.historyServiceController);
router.get('/historyService/search/:content', HistoryController.searchHistoryServiceController);
router.get('/historyBill', HistoryController.historyBillController);
router.get('/historyBill/search/:content', HistoryController.searchHistoryBillController);
module.exports = router;