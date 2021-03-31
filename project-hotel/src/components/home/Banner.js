import React, { Component } from 'react'

export default class Banner extends Component {
     render() {
          return (
               <div>
               {/* banner */}
                    <div className="banner">    	   
                    <img src="images/photos/banner.jpg" className="img-responsive" alt="slide" />
                    <div className="welcome-message">
                         <div className="wrap-info">
                         <div className="information">
                              <h1 className="animated fadeInDown">Chào mừng đến với Holiday Crown Hotel</h1>
                              <p className="animated fadeInUp">Khách sạn sang trọng với đầy đủ tiện nghi</p>                
                         </div>
                         <a href="#information" className="arrow-nav scroll wowload fadeInDownBig"><i className="fa fa-angle-down" /></a>
                         </div>
                    </div>
                    </div>
               {/* banner*/}
               </div>

          )
     }
}
