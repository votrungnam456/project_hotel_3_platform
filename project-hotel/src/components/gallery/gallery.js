import React, { Component } from 'react';

class Gallery extends Component {
     render() {
          return (
               <div className="container">
               <h1 className="title">Gallery</h1>
               <div className="row gallery">
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/1.jpg" title="Foods" className="gallery-image" data-gallery><img src="images/photos/1.jpg" className="img-responsive" /></a></div>
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/2.jpg" title="Coffee" className="gallery-image" data-gallery><img src="images/photos/2.jpg" className="img-responsive" /></a></div>
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/3.jpg" title="Travel" className="gallery-image" data-gallery><img src="images/photos/3.jpg" className="img-responsive" /></a></div>
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/4.jpg" title="Adventure" className="gallery-image" data-gallery><img src="images/photos/4.jpg" className="img-responsive" /></a></div>
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/5.jpg" title="Fruits" className="gallery-image" data-gallery><img src="images/photos/5.jpg" className="img-responsive" /></a></div>
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/6.jpg" title="Summer" className="gallery-image" data-gallery><img src="images/photos/6.jpg" className="img-responsive" /></a></div>
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/7.jpg" title="Bathroom" className="gallery-image" data-gallery><img src="images/photos/7.jpg" className="img-responsive" /></a></div>
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/8.jpg" title="Rooms" className="gallery-image" data-gallery><img src="images/photos/8.jpg" className="img-responsive" /></a></div>
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/9.jpg" title="Big Room" className="gallery-image" data-gallery><img src="images/photos/9.jpg" className="img-responsive" /></a></div>
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/11.jpg" title="Living Room" className="gallery-image" data-gallery><img src="images/photos/11.jpg" className="img-responsive" /></a></div>
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/1.jpg" title="Fruits" className="gallery-image" data-gallery><img src="images/photos/1.jpg" className="img-responsive" /></a></div>
               <div className="col-sm-4 wowload fadeInUp"><a href="images/photos/3.jpg" title="Travel" className="gallery-image" data-gallery><img src="images/photos/3.jpg" className="img-responsive" /></a></div>
               </div>
               </div>
          );
     }
}

export default Gallery;