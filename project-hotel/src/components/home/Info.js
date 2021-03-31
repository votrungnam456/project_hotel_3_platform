import React, { Component } from 'react';

class Info extends Component {
     render() {
          return (
               /* reservation-information */
               <div id="information" className="spacer reserve-info ">
                    <div className="container">
                         <div className="row">
                              <div className="col-sm-6 col-md-7">
                                   <div className="embed-responsive embed-responsive-16by9 wowload fadeInLeft"><iframe className="embed-responsive-item" src="//player.vimeo.com/video/55057393?title=0" width="100%" height={400} frameBorder={0} webkitallowfullscreen mozallowfullscreen allowFullScreen /></div>
                              </div>
                              <div className="col-sm-6 col-md-5">
                                   <h3>Đặt phòng ngay</h3>
                                   <form role="form" className="wowload fadeInRight">
                                        <div className="form-group">
                                             <input type="text" className="form-control" placeholder="Tên" />
                                        </div>
                                        <div className="form-group">
                                             <input type="email" className="form-control" placeholder="Email" />
                                        </div>
                                        <div className="form-group">
                                             <input type="Phone" className="form-control" placeholder="Số điện thoại" />
                                        </div>
                                        <div className="form-group">
                                             <div className="row">
                                                  <div className="col-xs-4">
                                                       <select className="form-control">
                                                            <option>Số phòng đặt</option>
                                                            <option>1</option>
                                                            <option>2</option>
                                                            <option>3</option>
                                                            <option>4</option>
                                                            <option>5</option>
                                                       </select>
                                                  </div>
                                                  <div className="col-xs-4">
                                                       <select className="form-control">
                                                            <option>Số người</option>
                                                            <option>1</option>
                                                            <option>2</option>
                                                            <option>3</option>
                                                            <option>4</option>
                                                            <option>5</option>
                                                       </select>
                                                  </div>
                                                  <div className="col-xs-4">
                                                       <select className="form-control">
                                                            <option>Kiểu phòng</option>
                                                            <option>Đơn</option>
                                                            <option>Đơn - VIP</option>
                                                            <option>Đôi</option>
                                                            <option>Đôi - VIP</option>
                                                       </select>
                                                  </div>
                                             </div>
                                        </div>
                                        <div className="form-group">
                                             <div className="row">
                                                  <div className="col-xs-4">
                                                       <select className="form-control col-sm-2" name="expiry-month" id="expiry-month">
                                                            <option>Ngày</option>
                                                            <option value="">1</option>
                                                            <option value="">2</option>
                                                            <option value="">Mar (03)</option>
                                                            <option value="">Apr (04)</option>
                                                            <option value="">May (05)</option>
                                                            <option value="">June (06)</option>
                                                            <option value="">July (07)</option>
                                                            <option value="">Aug (08)</option>
                                                            <option value="">Sep (09)</option>
                                                            <option value="">Oct (10)</option>
                                                            <option value="">Nov (11)</option>
                                                            <option value="">Dec (12)</option>
                                                       </select>
                                                  </div>
                                                  <div className="col-xs-4">
                                                       <select className="form-control col-sm-2" name="expiry-month" id="expiry-month">
                                                            <option>Tháng</option>
                                                            <option value="">Jan (01)</option>
                                                            <option value="">Feb (02)</option>
                                                            <option value="">Mar (03)</option>
                                                            <option value="">Apr (04)</option>
                                                            <option value="">May (05)</option>
                                                            <option value="">June (06)</option>
                                                            <option value="">July (07)</option>
                                                            <option value="">Aug (08)</option>
                                                            <option value="">Sep (09)</option>
                                                            <option value="">Oct (10)</option>
                                                            <option value="">Nov (11)</option>
                                                            <option value="">Dec (12)</option>
                                                       </select>
                                                  </div>
                                                  <div className="col-xs-4">
                                                       <select className="form-control" name="expiry-year">
                                                            <option >Năm</option>
                                                            <option value="">2013</option>
                                                            <option value="">2014</option>
                                                            <option value="">2015</option>
                                                            <option value="">2016</option>
                                                            <option value="">2017</option>
                                                            <option value="">2018</option>
                                                            <option value="">2019</option>
                                                            <option value="">2020</option>
                                                            <option value="">2021</option>
                                                            <option value="">2022</option>
                                                            <option value="">2023</option>
                                                       </select>
                                                  </div>
                                             </div>
                                        </div>
                                        <div className="form-group">
                                             <textarea className="form-control" placeholder="Lời nhắn" rows={4} defaultValue={""} />
                                        </div>
                                        <button className="btn btn-default">Đặt phòng</button>
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