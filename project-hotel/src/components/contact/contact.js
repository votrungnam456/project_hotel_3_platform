import React, { Component } from 'react';

class Contact extends Component {
     render() {
          return (
               <div className="container">
                    <h1 className="title">Contact</h1>
                    {/* form */}
                    <div className="contact">
                         <div className="row">
                              <div className="col-sm-12">
                                   <div className="map">
                                        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.0626359427183!2d106.62666801434081!3d10.806514792301138!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752be27d8b4f4d%3A0x92dcba2950430867!2zVHLGsOG7nW5nIMSQYcyjaSBob8yjYyBDw7RuZyBuZ2hp4buHcCBUaOG7sWMgcGjhuqltIFRow6BuaCBwaOG7kSBI4buTIENow60gTWluaA!5e0!3m2!1svi!2s!4v1626920775262!5m2!1svi!2s" width="100%" height={300} frameBorder={0} ></iframe>
                                   </div>
                                   <div className="col-sm-6 col-sm-offset-3">
                                        <div className="spacer">
                                             <h4>Write to us</h4>
                                             <form role="form">
                                                  <div className="form-group">
                                                       <input type="text" className="form-control" id="name" placeholder="Name" />
                                                  </div>
                                                  <div className="form-group">
                                                       <input type="email" className="form-control" id="email" placeholder="Enter email" />
                                                  </div>
                                                  <div className="form-group">
                                                       <input type="phone" className="form-control" id="phone" placeholder="Phone" />
                                                  </div>
                                                  <div className="form-group">
                                                       <textarea type="email" className="form-control" placeholder="Message" rows={4} defaultValue={""} />
                                                  </div>
                                                  <button type="submit" className="btn btn-default">Send</button>
                                             </form>
                                        </div>
                                   </div>
                              </div>
                         </div>
                    </div>
                    {/* form */}
               </div>

          );
     }
}

export default Contact;