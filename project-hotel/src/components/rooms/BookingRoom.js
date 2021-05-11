import React, { Component } from 'react';
import axios from 'axios'
class BookingRoom extends Component {
     constructor(props){
          super(props);
          this.state = {
               id:"",
               name : "",
               email:"",
               sdt: "",
               checkIn: "",
               checkOut: "",
               ghiChu:"",
               message:"",
               roomDetail:{}
          }
     }
     componentDidMount(){
          let dataUser = JSON.parse(localStorage.getItem("user"));
          if(dataUser != null){
               this.setState({
                    id:dataUser.ID_KH,
                    name:dataUser.TenKH,
                    email:dataUser.Email,
                    sdt:dataUser.Sodt
               })
          }
          else{
               this.props.history.push("/login");
          }
          let dataBooking = JSON.parse(localStorage.getItem("bookingDetail"));
          if(dataBooking != null){
               this.setState({
                    roomDetail:dataBooking
               })
          }
     }
     onSubmit = (ev) =>{
          ev.preventDefault();
          let {checkIn, checkOut} = this.state;
          if(checkOut != null){
               if(+checkIn > +checkOut){
                    this.setState({
                         message:2
                    })
                    return ;
               }
          }
          else if(checkIn == null){
               this.setState({
                    message:3
               })
               return;
          }
          console.log(this.state.roomDetail.MaPhong)
          axios.post("http://localhost:4444/booking/create",{
               Ngayden: this.state.checkIn,
               Ngaydi:this.state.checkOut,
               Chuthich: this.state.ghiChu,
               Maphong:this.state.roomDetail.MaPhong,
               ID_KH:this.state.id
          }).then(res=>{
               this.setState({
                    message:res.data.data
               })
               // console.log(res)
          }).catch(error=>console.log(error))
     }
     onChange = (ev) =>{
          let name = ev.target.name;
          let value = ev.target.value
          console.log(name , value)
          this.setState({
               [name]:value
          })
          
     }
     render() {
          let {roomDetail,message} = this.state;
          console.log(roomDetail)
          return (  
               <div className="container">
                    <h3 style={{paddingTop:"5px"}}>Vui lòng kiểm tra lại thông tin và xác nhận ngày giờ nhận, trả phòng</h3>
                    <form onSubmit={this.onSubmit} role="form" className="wowload fadeInRight">
                         <div className="form-group">
                              <p>Họ tên: </p>
                              <input disabled name="name" value={this.state.name || ""} type="text"  className="form-control"/>
                         </div>
                         <div className="form-group">
                              <p>Email: </p>
                              <input disabled name="email" value={this.state.email || ""} type="email" className="form-control"/>
                         </div>
                         <div className="form-group">
                              <p>Số điện thoại: </p>
                              <input disabled name="sdt" value={this.state.sdt || ""} type="Phone" className="form-control" />
                         </div>
                         <div className="form-group">
                              <div className="row">
                                   <div className="col-xs-6">
                                        <p>Phòng: </p>
                                        <input disabled name="sdt" name="nameRoom" value={roomDetail.Tenphong || ""}  className="form-control"/>
                                   </div>
                                   <div className="col-xs-6">
                                        <p>Loại phòng: </p>
                                        <input disabled name="sdt" name="typeRoom" value={roomDetail.TenKP || ""}  className="form-control"/>
                                   </div>
                              </div>
                         </div>
                         <div className="form-group">
                              <div className="row">
                                   <div className="col-xs-6">
                                        <p>Check-in</p>
                                        <input value={this.state.checkIn} onChange={this.onChange} name="checkIn" type="date"></input>
                                   </div>
                                   <div className="col-xs-6">
                                        <p>Check-out</p>
                                        <input value={this.state.checkOut} onChange={this.onChange}  name="checkOut" type="date"></input>
                                   </div>
                              </div>
                         </div>
                         <div className="form-group">
                              <textarea value={this.state.ghiChu || ""} onChange={this.onChange}  name="ghiChu" className="form-control" placeholder="Lời nhắn" rows={4} />
                         </div>
                         <button type="submit" className="btn btn-default">Xác nhận đặt phòng</button>
                         <p style={message == 1?{color : "green"}:{message:"red"}}>{message == 1? "Đặt phòng thành công": message == 2 ? "Ngày trả phòng phải lớn hơn ngày đặt phòng" : message == 3 ? "Ngày nhận phòng không được để trống hoặc nhỏ hơn ngày hiện tại" : ""}</p>
                    </form>
               </div>
          );
     }
}

export default BookingRoom;