const express = require('express');
const router = express.Router();
const CustomersController = require('../controller/CustomersController');

router.get('/list', CustomersController.list);
// router.get('/:MaPhong', CustomersController.getItem);
router.post('/create', CustomersController.createCustomer);
router.put('/:MaKH', CustomersController.updateCustomer);
module.exports = router;