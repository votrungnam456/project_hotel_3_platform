const express = require('express');
const router = express.Router();
const AprioriController = require('../controller/AprioriController');

router.get('/listData', AprioriController.listDataController);
router.get('/listFieldName', AprioriController.listFieldNameController);
module.exports = router;