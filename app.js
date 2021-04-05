const express = require('express');
const bodyParser = require('body-parser');
let app = express();
let roomsRouter = require('./routes/rooms');


app.use(bodyParser.urlencoded({extended: false}));
app.use(bodyParser.json());

app.get('/', (req, res, next) => {
    res.status(200).json({
        status: "SUCCESS",
        errors: null,
        data: {
            result: "Truy cập thành công"
        }
    });
});
app.use('/rooms', roomsRouter);


module.exports = app;