const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');
let app = express();
let roomsRouter = require('./routes/rooms');
let customerRouter = require('./routes/customers')
let bookingRouter = require('./routes/booking');
let payingRouter = require('./routes/paying');
let serviceRouter = require('./routes/service');
let employeesRouter = require('./routes/employees');
// app.use(cors);
app.use(bodyParser.urlencoded({extended: false}));
app.use(bodyParser.json());

app.get('/',cors() ,(req, res, next) => {
    res.status(200).json({
        status: "SUCCESS",
        errors: null,
        data: {
            result: "Truy cập thành công"
        }
    });
});
app.use('/rooms',cors() ,roomsRouter);
app.use('/customers',cors(),customerRouter);
app.use('/booking',cors(),bookingRouter);
app.use('/paying',cors(),payingRouter);
app.use('/service',cors(),serviceRouter);
app.use('/employees',cors(),employeesRouter);
module.exports = app;