const express = require('express');
const router = express.Router();
const CustomersController = require('../controller/CustomersController');

router.get('/list', CustomersController.list);
router.get('/listExist', CustomersController.listExist);
router.post('/user', CustomersController.getCustomer);
router.post('/create', CustomersController.createCustomer);
router.put('/:ID_KH', CustomersController.updateCustomer);
router.put('/changePassword/:ID_KH', CustomersController.changePwdCustomer);
module.exports = router;