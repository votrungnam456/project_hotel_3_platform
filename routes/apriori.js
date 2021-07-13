const express = require('express');
const router = express.Router();
const AprioriController = require('../controller/AprioriController');

router.get('/listFieldName', AprioriController.listFieldNameController);
router.get('/listData/:MaKP', AprioriController.listDataController);

module.exports = router;