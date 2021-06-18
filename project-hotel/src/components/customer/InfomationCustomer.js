import React, { Component } from 'react';
import { Link } from 'react-router-dom'
import * as api from '../../constant/api';
import axios from 'axios';
import date from 'date-and-time';
class InfomationCustomer extends Component {
     constructor(props) {
          super(props);
          this.state = {
               user: {},
               data: [],
               enableTable: 0
          }
     }
     componentDidMount() {
          // if (this.props.user != null) {
          //      this.setState({
          //           user: this.props.user
          //      })
          // }
          let dataUser = JSON.parse(localStorage.getItem("user"));
          if(dataUser != null){
               this.setState({
                    user:dataUser
               })
          }
     }
     onClick = (params) => {
          if(params === 0){
               if (this.state.enableTable == 0) {
                    this.setState({
                         enableTable: 1
                    }, () => {
                         axios.get(api.BASE_API + '/customers/bookingInfo/' + this.state.user.ID_KH)
                              .then(res => {
                                   this.setState({
                                        data: res.data.data
                                   })
                              })
                    })
               }
               else {
                    this.setState({
                         enableTable: 0
                    })
               }
          }
          else {
               axios.delete(api.BASE_API + '/rooms/cancelBooking/'+params).
                    then(res => {
                         axios.get(api.BASE_API + '/customers/bookingInfo/' + this.state.user.ID_KH)
                         .then(res => {
                              this.setState({
                                   data: res.data.data
                              })
                         })
                    })
          }
     }
     render() {
          let { user, data } = this.state;
          return (
               <div className="container">
                    <div>
                         <h1 style={{ textAlign: "center" }}>Thông tin khách hàng</h1>
                    </div>

                    <div>
                         <div className="row">
                              <div className="col-xs-5 col-sm-5 col-md-5 col-lg-5">
                                   <p>ID khách hàng:</p>
                              </div>
                              <div className="col-xs-7 col-sm-7 col-md-7 col-lg-7">
                                   <p>{user.ID_KH}</p>
                              </div>
                         </div>
                         <div className="row">
                              <div className="col-xs-5 col-sm-5 col-md-5 col-lg-5">
                                   <p>Họ tên:</p>
                              </div>
                              <div className="col-xs-7 col-sm-7 col-md-7 col-lg-7">
                                   <p>{user.TenKH}</p>
                              </div>
                         </div>
                         <div className="row">
                              <div className="col-xs-5 col-sm-5 col-md-5 col-lg-5">
                                   <p>Giới tính:</p>
                              </div>
                              <div className="col-xs-7 col-sm-7 col-md-7 col-lg-7">
                                   <p>{user.Gtinh}</p>
                              </div>
                         </div>
                         <div className="row">
                              <div className="col-xs-5 col-sm-5 col-md-5 col-lg-5">
                                   <p>CMND: </p>
                              </div>
                              <div className="col-xs-7 col-sm-7 col-md-7 col-lg-7">
                                   <p>{user.Cmnd}</p>
                              </div>
                         </div>
                         <div className="row">
                              <div className="col-xs-5 col-sm-5 col-md-5 col-lg-5">
                                   <p>Số điện thoại: </p>
                              </div>
                              <div className="col-xs-7 col-sm-7 col-md-7 col-lg-7">
                                   <p>{user.Sodt}</p>
                              </div>
                         </div>
                         <div className="row">
                              <div className="col-xs-5 col-sm-5 col-md-5 col-lg-5">
                                   <p>Địa chỉ: </p>
                              </div>
                              <div className="col-xs-7 col-sm-7 col-md-7 col-lg-7">
                                   <p>{user.Dchi}</p>
                              </div>
                         </div>
                         <div className="row">
                              <div className="col-xs-5 col-sm-5 col-md-5 col-lg-5">
                                   <p>Quốc tịch: </p>
                              </div>
                              <div className="col-xs-7 col-sm-7 col-md-7 col-lg-7">
                                   <p>{user.Qtich}</p>
                              </div>
                         </div>
                         <div className="row">
                              <div className="col-xs-5 col-sm-5 col-md-5 col-lg-5">
                                   <p>Email: </p>
                              </div>
                              <div className="col-xs-7 col-sm-7 col-md-7 col-lg-7">
                                   <p>{user.Email}</p>
                              </div>
                         </div>
                         <div className="row">
                              <div className="col-xs-5 col-sm-5 col-md-5 col-lg-5">
                                   <p>Mật khẩu:</p>
                              </div>
                              <div className="col-xs-7 col-sm-7 col-md-7 col-lg-7">
                                   <span>*************</span> &nbsp;&nbsp;&nbsp;&nbsp;
                                   <Link to="/changePwd">Đổi mật khẩu</Link>
                              </div>
                              <div className="col-xs-1 col-sm-1 col-md-1 col-lg-1">

                              </div>
                         </div>
                         <div className="row">
                              <div className="col-xs-4 col-sm-4 col-md-4 col-lg-4"></div>
                              <div className="col-xs-4 col-sm-4 col-md-4 col-lg-4">
                                   <button onClick={() => this.onClick(0)} className="btn btn-default">Hiện thông tin đặt phòng</button>
                              </div>

                         </div>
                    </div>     
                    <div>
                         {
                              this.state.enableTable == 1 ? <div>
                                   <h1 style={{ textAlign: "center" }}>Thông tin phòng đã đặt</h1>
                                             <div>
                                                  <table className="table">
                                                       <thead>
                                                            <tr>
                                                                 <th scope="col">Mã phiếu đăng ký</th>
                                                                 <th scope="col">Ngày đến</th>
                                                                 <th scope="col">Ngày đi</th>
                                                                 <th scope="col">Tên phòng</th>
                                                                 <th scope="col">Giá phòng</th>
                                                                 <th scope="col">Tình trạng</th>
                                                                 <th scope="col"></th>
                                                            </tr>
                                                       </thead>
                                                       <tbody>
                                                            {
                                                                 // this.state.enableTable == 1 ? this.loadData(data) : ""
                                                                 data.length > 0 ? (
                                                                      data.map((value,index) =>{
                                                                           let formatNgayDen = new Date(value.Ngayden);
                                                                           let formatNgayDi = new Date(value.Ngaydi);
                                                                           let getMaPDK = value.MaPDK
                                                                           return(
                                                                                <tr key={index}>
                                                                                     <td>{value.MaPDK}</td>
                                                                                     <td>{date.format(formatNgayDen,'DD/MM/YYYY')}</td>
                                                                                     <td>{date.format(formatNgayDi,'DD/MM/YYYY')}</td>
                                                                                     <td>{value.TenPhong}</td>
                                                                                     <td>{value.GiaPhong}</td>
                                                                                     <td style={value.TinhTrangPDK === 0 ? {color:"green"} : value.TinhTrangPDK === 1 ? {color:"orange"} :{color:"red"}}>{value.TinhTrangPDK === 0 ? "Đã thanh toán" : value.TinhTrangPDK === 1 ? "Đã đặt" : "Đang sử dụng"}</td>
                                                                                     <td>{value.TinhTrangPDK === 1 ? <button className="btn btn-default" onClick={()=>this.onClick(getMaPDK)}>Huỷ đặt</button> :"" }</td>
                                                                                </tr>
                                                                           )
                                                                      })
                                                                 ):<tr>
                                                                      <td>B</td>
                                                                 </tr>
                                                            }
                                                            {/* <td>A</td> */}
                                                       </tbody>
                                                  </table>
                                             </div>
                                        </div> :""
                         }
                    </div>
               </div>



          );
     }
     loadData = (data) =>{
          data.map((value,index)=>{
               return(
                    // <tr key={index}>
                         // <td>{value.MaPDK}</td>
                    // </tr>
                    <tr>{value.MaPDK}</tr>
               )
               // console.log(value.MaPDK)
          })
          
     }
}

export default InfomationCustomer;