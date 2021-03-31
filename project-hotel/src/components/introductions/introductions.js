import React, { Component } from 'react';

class Introductions extends Component {
     render() {
          return (
               <div className="container" style={{height:"60vh"}}>
                    <h1 className="title">Introduction</h1>
                    <div className="row">
                         <div className="col-sm-6">
                              <p>MSSV: 2001181219</p>
                              <p>Võ Trung Nam</p>
                         </div>
                         <div className="col-sm-6">
                              <p>MSSV: 2001181143</p>
                              <p>Đỗ Đức Huy</p>
                         </div>
                    </div>
               </div>

          );
     }
}

export default Introductions;