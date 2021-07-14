import React, { Component } from 'react';
import axios from 'axios';
import * as api from '../../constant/api'
class Info extends Component {
     constructor(props){
          super(props);
          this.state = {
               id:"",
               name : "",
               email:"",
               sdt: "",
               numRoom : 0,
               typeRoom: "",
               checkIn: "",
               checkOut: "",
               ghiChu:"",
               listkieuPhong : [],
               error:0

          }
     }
     componentDidMount(){
          axios.get(api.BASE_API+'/rooms/typeRooms')
          .then(res=>{
               this.setState({
                    listkieuPhong:res.data.data
               })
          })
          let dataUser = JSON.parse(localStorage.getItem("user"));
          if(dataUser != null){
               this.setState({
                    id:dataUser.ID_KH,
                    name:dataUser.TenKH,
                    email:dataUser.Email,
                    sdt:dataUser.Sodt
               })
          }
     }
     onChange = (ev) =>{
          let name = ev.target.name;
          let value = ev.target.value
          console.log(name , value)
          this.setState({
               [name]:value
          })
          
     }
     
     onSubmit = (ev) =>{
          ev.preventDefault();
          let {id,numRoom,typeRoom,checkIn,checkOut,ghiChu,error} = this.state;
          console.log(this.props.history);
          if(id == ""){
               this.props.history.push("/login");
               return;
          }
          let dateIn = new Date(checkIn);
          let date = new Date();
          let now = new Date(date.getFullYear()+'-'+(date.getMonth()+1)+'-'+(date.getDate()+1));
          if(+now > +dateIn){
               this.setState({
                    error:1
               })
               return ;
          }
          let dateOut = null;
          if(checkOut != ""){
               dateOut = new Date(checkOut);
          }
          else if(checkIn == ""){
               this.setState({
                    error:2
               })
               return;
          }
          if(dateOut != null){
               if(+dateIn > +dateOut){
                    this.setState({
                         error:1
                    })
                    return ;
               }
          }
          if(typeRoom == "" || checkIn == "" || numRoom == "")
          {
               this.setState({
                    error:2
               })
               return ;
          }
          axios.post('http://localhost:4444/booking/createNumber',{
               Ngayden: dateIn,
               Ngaydi: dateOut,
               Chuthich:ghiChu,
               LoaiPhong: typeRoom,
               SoPhongDat: numRoom,
               ID_KH : id
          }).then(res=>{
               console.log(res.data.data)
               if(res.data.data == 0){
                    this.setState({
                         error:3
                    })
               }
               else if(res.data.data == 1){
                    this.setState({
                         error:4,
                         numRoom : 0,
                         typeRoom: "",
                         checkIn: "",
                         checkOut: "",
                         ghiChu:"",
                    })
               }
          }).catch(error=>console.log(error))
     }
     render() {
          let {listkieuPhong,error} = this.state
          return (
               /* reservation-information */
               <div id="information" className="spacer reserve-info ">
                    <div className="container">
                         <div className="row">
                              <div className="col-sm-6 col-md-7">
                                   <div className="embed-responsive embed-responsive-16by9 wowload fadeInLeft"><iframe className="embed-responsive-item" src="//player.vimeo.com/video/55057393?title=0" width="100%" height={400} frameBorder={0} webkitallowfullscreen="true" mozallowfullscreen="true" allowFullScreen={true} /></div>
                              </div>
                              <div className="col-sm-6 col-md-5">
                                   <h3>Đặt phòng ngay</h3>
                                   <form onSubmit={this.onSubmit} role="form" className="wowload fadeInRight">
                                        <div className="form-group">
                                             <input disabled name="name" value={this.state.name || ""} type="text" onChange={this.onChange} className="form-control" placeholder="Tên" />
                                        </div>
                                        <div className="form-group">
                                             <input disabled name="email" value={this.state.email || ""} type="email"onChange={this.onChange} className="form-control" placeholder="Email" />
                                        </div>
                                        <div className="form-group">
                                             <input disabled name="sdt" value={this.state.sdt || ""} type="Phone"onChange={this.onChange} className="form-control" placeholder="Số điện thoại" />
                                        </div>
                                        <div className="form-group">
                                             <div className="row">
                                                  <div className="col-xs-6">
                                                       <select id="test" value={this.state.soPhongDat} name="numRoom"onChange={this.onChange} className="form-control">
                                                            <option value="">Số phòng đặt</option>
                                                            <option value= {1}>1</option>
                                                            <option value= {2}>2</option>
                                                            <option value={3}>3</option>
                                                            <option value={4}>4</option>
                                                            <option value={5}>5</option>
                                                       </select>
                                                  </div>
                                                  <div className="col-xs-6">
                                                       <select value={this.state.kieuPhong} onChange={this.onChange}  name="typeRoom" className="form-control">
                                                            <option>Kiểu phòng</option>
                                                            {listkieuPhong.map((value,index) =>{
                                                                 return (
                                                                      <option key={index} value={value.MaKP}>{value.TenKP}</option>
                                                                 )
                                                            })}
                                                       </select>
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
                                                       <input value={this.state.checkOut} onChange={this.onChange} name="checkOut" type="date"></input>
                                                  </div>
                                             </div>
                                        </div>
                                        <div className="form-group">
                                             <textarea value={this.state.ghiChu || ""} name="ghiChu" onChange={this.onChange} className="form-control" placeholder="Lời nhắn" rows={4} />
                                        </div>
                                        <button type="submit" className="btn btn-default">Đặt phòng</button>
                                        <p style={error == 4?{color : "green"}:{color:"red"}}>{error == 1 ? "Ngày trả phòng phải lớn hơn ngày đặt phòng và ngày đặt phòng không được nhỏ hơn ngày hôm nay":error == 2? "Các thông tin cần thiết không được để trống" : error==3?`Số phòng hiện tại không đủ`:error == 4 ? "Đặt phòng thành công" : ""}</p>
                                   </form>
                              </div>
                         </div>
                    </div>
               </div>
               /* reservation-information */
          );
     }
}

export default Info;