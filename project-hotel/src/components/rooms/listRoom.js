import React, { Component } from 'react';
import axios from 'axios';
import RoomItem from './RoomItem';
import * as api from '../../constant/api';
class ListRoom extends Component {
     constructor(props) {
          super(props);
          this.state = {
               dataLoad:[],
            dataGot: [],
            currentPage:1
          };
        }
     componentDidMount(){
          axios.get(api.BASE_API+'/rooms/list')
               .then(res=>{
                    this.setState({
                         dataGot:res.data.data
                    }, () =>{
                         this.setState({
                              dataLoad:this.state.dataGot.slice(0,8)
                         })
                    })
               })
     }
     //load các nút phân trang
     loadButtonPaging = (arr)  => {
          let numberButton = Math.ceil(arr.length / 8);
          let result = [];
          if(numberButton <=1 ){
               result.push(<li key={1}><a key={1}>1</a></li>)
          }
          else{
               for(let i = 1 ; i <= numberButton ; i++){
                    result.push(<li className={this.state.currentPage == i ? "active":""} key={i}><a onClick={() => this.actionPaging(i)}>{i}</a></li>)
               }
          }
          return result;
     }
     actionPaging = (number) =>{
          this.setState({
               dataLoad:this.state.dataGot.slice(number*8 -8,8*number),
               currentPage:number
          })
          // console.log(number*8-8)
     }
     render() {
          let {dataLoad,currentPage,dataGot} = this.state;
          return (
               <div className="container">
                    <div className="row"> 
                         {dataLoad.length > 0 ?(
                         dataLoad.map((value,index)=>{
                              return (
                                   <RoomItem key={index} value={value}></RoomItem>
                              )
                         })): (
                              <div className="spinner-border" role="status">
                                  <span className="sr-only">Loading...</span>
                              </div>
                          )}  
                    </div>
                    <div className="text-center">
                         <ul className="pagination">
                              {currentPage == 1 ? "" :<li><a onClick={()=>this.actionPaging(currentPage-1)}>«</a></li>}
                              {
                                   dataGot.length >0 ? this.loadButtonPaging(dataGot):""
                              }
                              {currentPage == Math.ceil(dataGot.length / 8) ? "": <li><a onClick={()=>this.actionPaging(currentPage+1)}>»</a></li>}

                         </ul>
                    </div>
               </div>

          );
     }
}

export default ListRoom;