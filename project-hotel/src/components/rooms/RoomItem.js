import React, { Component } from 'react';
import {Link} from 'react-router-dom';
class RoomItem extends Component {
     constructor(props) {
          super(props);
        }
     render() {
          let {value} = this.props;
          return (
                    <div className="col-sm-6 wowload fadeInUp">
                         <div className="rooms">
                              <img src="images/photos/8.jpg" className="img-responsive" />
                              <div className="info">
                                   <h3>{value.Tenphong}</h3>
                                   <p>{value.TenKP}</p>
                                   <Link to= {`/rooms/${value.MaPhong}`} type="button" className="btn btn-default">Xem chi tiết</Link>
                              </div>
                         </div>
                    </div>
          );
     }
}

export default RoomItem;