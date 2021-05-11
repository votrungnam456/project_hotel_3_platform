import React, { Component } from 'react';
import axios from 'axios'
import {Link} from 'react-router-dom';
class RoomDetails extends Component {
     constructor(props) {
          super(props);
          this.state = {
               data:[],
               user:{}
          }   
     }

     componentDidMount(){
          axios.get(`http://localhost:4444/rooms/${this.props.match.params.id}`)
          .then(res=>{
               // console.log(res.data.data.result)
               this.setState({
                    data:res.data.data
               })
          })
          let checkUser = JSON.parse(localStorage.getItem("user"));
          if(checkUser != null){
               this.setState({
                    user:checkUser
               })
          }
     }
     onSubmit = (ev) =>{
          ev.preventDefault();
          if(localStorage.getItem("bookingDetail") != null){
               localStorage.removeItem("bookingDetail");
          }
          localStorage.setItem("bookingDetail",JSON.stringify(this.state.data))
          this.props.history.push("/bookingComplete")
     }
     render() {
          console.log(this.state.data)
          let {data} = this.state;
          return (
               <div className="container">
                    <h1 className="title">{data.Tenphong}</h1>
                    {/* RoomDetails */}
                    <div id="RoomDetails" className="carousel slide" data-ride="carousel">
                         <div className="carousel-inner">
                              <div className="item active"><img src="../../images/photos/8.jpg" className="img-responsive" alt="slide" /></div>
                              <div className="item  height-full"><img src="../../images/photos/9.jpg" className="img-responsive" alt="slide" /></div>
                              <div className="item  height-full"><img src="../../images/photos/10.jpg" className="img-responsive" alt="slide" /></div>
                         </div>
                         {/* Controls */}
                         <a className="left carousel-control" href="#RoomDetails" role="button" data-slide="prev"><i className="fa fa-angle-left" /></a>
                         <a className="right carousel-control" href="#RoomDetails" role="button" data-slide="next"><i className="fa fa-angle-right" /></a>
                    </div>
                    {/* RoomCarousel*/}
                    <div className="room-features spacer">
                         <div className="row">
                              <div className="col-sm-12 col-md-5">
                                   <h3>Tình trạng</h3>
                                   <p style={data.TinhTrang === 0 ? {color:"green"} : data.TinhTrang === 1 ? {color:"orange"} :{color:"red"}}>{data.TinhTrang === 0 ? "Còn trống" : data.TinhTrang === 1 ? "Đã được đặt" : "Đang sử dụng"}</p>
                              </div>
                              <div className="col-sm-6 col-md-3 amenitites">
                                   <h3>Mô tả</h3>
                                   <ul>
                                        <li>{data.Mota}</li>
                                   </ul>
                              </div>
                              <div className="col-sm-3 col-md-2">
                                   <div className="size-price">Size<span>44 sq</span></div>
                              </div>
                              <div className="col-sm-3 col-md-2">
                                   <div className="size-price">Giá<span>{data.Gia}đ</span></div>
                              </div>
                              <div>
                                   {data.TinhTrang === 0 ? (<button onClick={this.onSubmit} type="submit" className="btn btn-default">Đặt phòng</button>) : ""}
                              </div>
                         </div>
                    </div>
               </div>

          );
     }
}

export default RoomDetails;