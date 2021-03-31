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
                                        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d9933.460884430251!2d-0.13301252240929382!3d51.50651527467666!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47d8a00baf21de75%3A0x52963a5addd52a99!2sLondon%2C+UK!5e0!3m2!1sen!2snp!4v1414314152341" width="100%" height={300} frameBorder={0} />
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