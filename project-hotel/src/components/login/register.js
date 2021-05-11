import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';
class register extends Component {
     constructor(props) {
          super(props);
          this.state = {
               message:"",
               name:"",
               email:"",
               gender:"Nam",
               cmnd:"",
               address:"",
               country:"Việt Nam",
               sdt:"",
               pwd:"",
               ConfirmPwd:""
          }
     }

     onChange = (ev) => {
          let name = ev.target.name;
          let value = ev.target.value
          console.log(name, value);
          this.setState({
               [name]: value
          })

     }
     // ValidateEmail = (mail) =>
     // {
     //      let mailformat = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
     //      if (mail.match(mailformat))
     //      {
     //           return true
     //      }
     //      return false
     // }
     onSubmit = (ev) => {
          ev.preventDefault();
          let { history } = this.props
          let {name,email,gender,cmnd,address,country,sdt,pwd,ConfirmPwd} = this.state;
          if(cmnd.length != 9){
               this.setState({
                    message:"CMND không đúng định dạng"
               })
               return;
          }
          if(pwd == ConfirmPwd){
               axios.post('http://localhost:4444/customers/create', {
                    TenKH:name,
                    GTinh:gender,
                    CMND:cmnd,
                    Dchi:address,
                    QTich:country,
                    SoDT:sdt,
                    Email:email,
                    MatKhau:pwd
               })
               .then(response=> {
                    console.log(response.data.data)
                    if(response.data.data == 1){                        
                         history.push("/")
                    }
                    else if(response.data.data == -1)
                    {
                         this.setState({
                              message:"Email đã tồn tại"
                         })
                    }
                    else if(response.data.data == -2)
                    {
                         this.setState({
                              message:"CMND đã tồn tại"
                         })
                    }
                    else{
                         this.setState({
                              message:"Có lỗi trong quá trình xử lý vui lòng thử lại"
                         })
                         return;
                    }
               })
               .catch(function (error) {
                    console.log(error);
               });
          }
          else{
               this.setState({
                    message:"Mật khẩu và xác nhận mật khẩu không khớp!!"
               })
               return;
          }
     }
     render() {
          return (
               <div>
                    <form onSubmit={this.onSubmit}>
                         <div className="container">
                              <h1>Đăng ký</h1>
                              <p>Hãy điền thông tin vào form này để trở thành khách hàng của chúng tôi</p>
                              <div className="form-group">
                                   <label htmlFor="user">Họ tên: </label><br />
                                   <input onChange={this.onChange} className="form-control" type="text" name="name" placeholder="Vui lòng nhập họ tên" required />
                              </div>
                              <div className="form-group">
                                   <label htmlFor="user">Email:</label><br />
                                   <input onChange={this.onChange} className="form-control" type="email" name="email" placeholder="example@abc.com" required />
                              </div>
                              <div className="form-group">
                                   <div className="row">
                                        <div className="col-xs-6">
                                             <label htmlFor="user">Giới tính:</label><br />
                                             <select name="gender" onChange={this.onChange} className="form-control">
                                                  <option value="Nam">Nam</option>
                                                  <option value="Nữ">Nữ</option>
                                                  <option value="Khác">Khác</option>
                                             </select>
                                        </div>
                                        <div className="col-xs-6">
                                             <label htmlFor="user">CMND:</label><br />
                                             <input onChange={this.onChange} className="form-control" type="text" name="cmnd"required />
                                        </div>
                                   </div>
                              </div>
                              <div className="form-group">
                                   <label htmlFor="user">Địa chỉ:</label><br />
                                   <input onChange={this.onChange} className="form-control" type="text" name="address" placeholder="140 Lê Trọng Tấn..."/>
                              </div>
                              <div className="form-group">
                                   <div className="row">
                                        <div className="col-xs-6">
                                             <label htmlFor="user">Quốc tịch:</label><br />
                                             <select name="country" onChange={this.onChange} className="form-control">
                                                  <option value="Việt Nam">Việt Nam</option>
                                                  <option value="Nhật Bản">Nhật Bản</option>
                                                  <option value="Mỹ">Mỹ</option>
                                                  <option value="Indonesia">Indonesia</option>
                                                  <option value="Campuchia">Campuchia</option>
                                                  <option value="Lào">Lào</option>
                                             </select>
                                        </div>
                                        <div className="col-xs-6">
                                             <label htmlFor="user">Số điện thoại</label><br />
                                             <input onChange={this.onChange} className="form-control" type="text" name="sdt" placeholder="090xxxx"/>
                                        </div>
                                   </div>
                              </div>
                              <div className="form-group">
                                   <div className="row">
                                        <div className="col-xs-6">
                                             <label htmlFor="user">Mật khẩu</label><br />
                                             <input onChange={this.onChange} className="form-control" type="password" name="pwd" placeholder="*******" required />
                                        </div>
                                        <div className="col-xs-6">
                                             <label htmlFor="user">Nhập lại mật khẩu</label><br />
                                             <input onChange={this.onChange} className="form-control" type="password" name="ConfirmPwd" placeholder="*******" required />
                                        </div>
                                   </div>
                              </div>
                              <div className="submit-g">
                                   <input className="btn btn-default" type="submit" value="Đăng ký" />
                              </div>
                              <p style={{color:"red"}}>{this.state.message}</p>
                         </div>
                         <div className="container signin">
                              <p>Bạn đã có tài khoản ? | <Link to="/login">Đăng nhập</Link>.</p>
                         </div>
                    </form>
               </div>

          );
     }
}

export default register;