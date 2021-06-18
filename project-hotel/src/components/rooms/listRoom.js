import React, { Component } from 'react';
import axios from 'axios';
import RoomItem from './RoomItem';
import * as api from '../../constant/api';
class ListRoom extends Component {
     constructor(props) {
          super(props);
          this.state = {
            data:[]
          };
        }
     componentDidMount(){
          axios.get(api.BASE_API+'/rooms/list')
               .then(res=>{
                    console.log(res.data.data.result)
                    this.setState({
                         data:res.data.data
                    })
               })
     }
     render() {
          // console.log(this.state.data);
          let {data} = this.state;
          return (
               <div className="container">
                    <div className="row"> 
                         {data.map((value,index)=>{
                              return (
                                   <RoomItem key={index} value={value}></RoomItem>
                              )
                         })}  
                    </div>
                    <div className="text-center">
                         <ul className="pagination">
                              <li className="disabled"><a href="#">«</a></li>
                              <li className="active"><a href="#">1 <span className="sr-only">(current)</span></a></li>
                              <li><a href="#">2</a></li>
                              <li><a href="#">3</a></li>
                              <li><a href="#">4</a></li>
                              <li><a href="#">5</a></li>
                              <li><a href="#">»</a></li>
                         </ul>
                    </div>
               </div>

          );
     }
}

export default ListRoom;