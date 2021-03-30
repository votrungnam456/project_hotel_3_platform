import React, { Component } from 'react';

class roomDetails extends Component {
     render() {
          return (
               <div className="container">
                    <h1 className="title">Luxirious Suites</h1>
                    {/* RoomDetails */}
                    <div id="RoomDetails" className="carousel slide" data-ride="carousel">
                         <div className="carousel-inner">
                              <div className="item active"><img src="images/photos/8.jpg" className="img-responsive" alt="slide" /></div>
                              <div className="item  height-full"><img src="images/photos/9.jpg" className="img-responsive" alt="slide" /></div>
                              <div className="item  height-full"><img src="images/photos/10.jpg" className="img-responsive" alt="slide" /></div>
                         </div>
                         {/* Controls */}
                         <a className="left carousel-control" href="#RoomDetails" role="button" data-slide="prev"><i className="fa fa-angle-left" /></a>
                         <a className="right carousel-control" href="#RoomDetails" role="button" data-slide="next"><i className="fa fa-angle-right" /></a>
                    </div>
                    {/* RoomCarousel*/}
                    <div className="room-features spacer">
                         <div className="row">
                              <div className="col-sm-12 col-md-5">
                                   <p>Space in your house How to sell faster than your neighbors How to make a strategic use. To discourage you by telling. To discourage you by telling. I m going to outline 14 different ways that I ve found you. The real goal of any talk or speech. The real goal of any talk or speech. I m going to outline 14 different ways that I ve found you. The real goal of any talk or speech. I m going to outline 14 different ways that I ve found you. The real goal of any talk or speech. To discourage you by telling. To discourage you by telling. Space in your house How to sell faster than your neighbors How to make a strategic use. The real goal of any talk or speech.</p>
                                   <p>By Learning Ways To Become Peaceful. One of the greatest barriers to making the sale is your prospect's natural. Don't stubbornly. Don't stubbornly. Don't stubbornly. -And Gain Power By Learning Ways To Become Peaceful. </p>
                              </div>
                              <div className="col-sm-6 col-md-3 amenitites">
                                   <h3>Amenitites</h3>
                                   <ul>
                                        <li>One of the greatest barriers to making the sale is your prospect.</li>
                                        <li>Principle to work to make more money while having more fun.</li>
                                        <li>Unlucky people. Don't stubbornly.</li>
                                        <li>Principle to work to make more money while having more fun.</li>
                                        <li>Space in your house How to sell faster than your neighbors</li>
                                   </ul>
                              </div>
                              <div className="col-sm-3 col-md-2">
                                   <div className="size-price">Size<span>44 sq</span></div>
                              </div>
                              <div className="col-sm-3 col-md-2">
                                   <div className="size-price">Price<span>$200.00</span></div>
                              </div>
                         </div>
                    </div>
               </div>

          );
     }
}

export default roomDetails;