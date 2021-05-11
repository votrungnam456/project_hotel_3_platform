import React, { Component } from 'react';
import { Link } from 'react-router-dom';

class Service extends Component {
     render() {
          return (
               /* services */
               < div className = "spacer services wowload fadeInUp" >
                    <div className="container">
                         <div className="row">
                              <div className="col-sm-4">
                                   {/* RoomCarousel */}
                                   <div id="RoomCarousel" className="carousel slide" data-ride="carousel">
                                        <div className="carousel-inner">
                                             <div className="item active"><img src="images/photos/8.jpg" className="img-responsive" alt="slide" /></div>
                                             <div className="item  height-full"><img src="images/photos/9.jpg" className="img-responsive" alt="slide" /></div>
                                             <div className="item  height-full"><img src="images/photos/10.jpg" className="img-responsive" alt="slide" /></div>
                                        </div>
                                        {/* Controls */}
                                        <a className="left carousel-control" href="#RoomCarousel" role="button" data-slide="prev"><i className="fa fa-angle-left" /></a>
                                        <a className="right carousel-control" href="#RoomCarousel" role="button" data-slide="next"><i className="fa fa-angle-right" /></a>
                                   </div>
                                   {/* RoomCarousel*/}
                                   <div className="caption">Rooms
                                        <Link className="pull-right" to="/rooms"><i className="fa fa-edit" /></Link>
                                   </div>
                              </div>
                              <div className="col-sm-4">
                                   {/* RoomCarousel */}
                                   <div id="TourCarousel" className="carousel slide" data-ride="carousel">
                                        <div className="carousel-inner">
                                             <div className="item active"><img src="images/photos/6.jpg" className="img-responsive" alt="slide" /></div>
                                             <div className="item  height-full"><img src="images/photos/3.jpg" className="img-responsive" alt="slide" /></div>
                                             <div className="item  height-full"><img src="images/photos/4.jpg" className="img-responsive" alt="slide" /></div>
                                        </div>
                                        {/* Controls */}
                                        <a className="left carousel-control" href="#TourCarousel" role="button" data-slide="prev"><i className="fa fa-angle-left" /></a>
                                        <a className="right carousel-control" href="#TourCarousel" role="button" data-slide="next"><i className="fa fa-angle-right" /></a>
                                   </div>
                                   {/* RoomCarousel*/}
                                   <div className="caption">Trải nghiệm
                                        <Link className="pull-right" to="/gallery"><i className="fa fa-edit" /></Link>
                                   </div>
                              </div>
                              <div className="col-sm-4">
                                   {/* RoomCarousel */}
                                   <div id="FoodCarousel" className="carousel slide" data-ride="carousel">
                                        <div className="carousel-inner">
                                             <div className="item active"><img src="images/photos/1.jpg" className="img-responsive" alt="slide" /></div>
                                             <div className="item  height-full"><img src="images/photos/2.jpg" className="img-responsive" alt="slide" /></div>
                                             <div className="item  height-full"><img src="images/photos/5.jpg" className="img-responsive" alt="slide" /></div>
                                        </div>
                                        {/* Controls */}
                                        <a className="left carousel-control" href="#FoodCarousel" role="button" data-slide="prev"><i className="fa fa-angle-left" /></a>
                                        <a className="right carousel-control" href="#FoodCarousel" role="button" data-slide="next"><i className="fa fa-angle-right" /></a>
                                   </div>
                                   {/* RoomCarousel*/}
                                   <div className="caption">Thức ăn và đồ uống<Link className="pull-right" to="/gallery"><i className="fa fa-edit" /></Link></div>
                              </div>
                         </div>
                    </div>
               </div >
               /* services */

          );
     }
}

export default Service;