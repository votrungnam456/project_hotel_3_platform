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
let historyRouter = require('./routes/history');
let aprioriRouter = require('./routes/apriori');

app.use(bodyParser.urlencoded({extended: false}));
app.use(bodyParser.json());

app.get('/',cors() ,(req, res, next) => {
    res.status(200).json({
        status: "SUCCESS",
        errors: null,
        data: {
            "/customers":{
                "GET":{
                    "/list":"Lấy danh sách khách hàng",
                    "/listExist":"Lấy danh sách khách hàng đang thuê phòng",
                    "/bookingInfo/:ID_KH":"Lấy thông tin đặt phòng của 1 khách hàng"
                },
                "POST":{
                    "/user":"Gửi thông tin đăng nhập của khách hàng (Emaiil - mật khẩu) trả về thông tin của khách nếu có",
                    "/create":"Tạo khách hàng - gửi thông tin bao gồm: tên khách hàng, giới tính, cmnd, địa chỉ, quốc tịch, số điện thoại, email, mật khẩu - Trả về 1 nếu thành công, -1 nếu trùng email, -2 nếu trùng cmnd"
                },
                "PUT":{
                    "/:ID_KH":"Sửa thông tin khách hàng - truyền các thông tin cần gửi cùng với ID của khách hàng",
                    "/changePassword/:ID_KH":"Đổi mật khẩu - nhận mật khẩu cũ, mật khẩu mới - trả về 1 là thanh công, 0 là sai mật khẩu cũ"
                }
            },
            "/employees":{
                "GET":{
                    "/list":"Lấy danh sách nhân viên",
                    "/decentralization":"Lấy danh sách phân quyền của nhân viên",
                    "/search/:content":"tìm kiếm nhân viên theo tên",
                    "/ID_NV":"Lấy 1 nhân viên"
                },
                "POST":{
                    "/create":"Thêm 1 nhân viên",
                    "/user":"Đăng nhập bằng email - mật khẩu, trả về thông tin của nhân viên"
                },
                "PUT":{
                    "/:ID_NV":"Sửa thông tin nhân viên"
                },
                "DELETE":{
                    "/:ID_NV":"Xoá nhân viên"
                }
            }
        }
    });
});
app.use('/rooms',cors() ,roomsRouter);
app.use('/customers',cors(),customerRouter);
app.use('/booking',cors(),bookingRouter);
app.use('/paying',cors(),payingRouter);
app.use('/service',cors(),serviceRouter);
app.use('/employees',cors(),employeesRouter);
app.use('/history',cors(),historyRouter);
app.use('/apriori',cors(),aprioriRouter);
module.exports = app;