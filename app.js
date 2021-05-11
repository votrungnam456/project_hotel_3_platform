const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');
let app = express();
let roomsRouter = require('./routes/rooms');
let customerRouter = require('./routes/customers')
let bookingRouter = require('./routes/booking');

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

module.exports = app;