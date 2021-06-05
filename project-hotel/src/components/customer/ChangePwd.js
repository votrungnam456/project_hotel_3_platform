import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';
class ChangePwd extends Component {
     constructor(props){
          super(props);
          this.state = {
               userID: '',
               oldPwd: '',
               newPwd:'',
               confirmNewPwd:'',
               message:0
          }
     }

     componentDidMount(){
          let dataUser = JSON.parse(localStorage.getItem("user"));
          if(dataUser != null){
               this.setState({
                    userID:dataUser.ID_KH,
               })
          }
     }

     onChange = (ev) =>{
          let name = ev.target.name;
          let value = ev.target.value
          this.setState({
               [name]:value
          })    
     }

     onSubmit = (ev) =>{
          ev.preventDefault();
          let {oldPwd,newPwd,confirmNewPwd,userID} = this.state;
          if(newPwd != confirmNewPwd){
               this.setState({
                    message:1
               })
               return;
          }
          axios.put('http://localhost:4444/customers/changePassword/'+userID, {
               oldPwd,
               newPwd
          })
               .then(response=>{
                    if (response.data.data == 0) {
                         this.setState({
                              message:2
                         })
                    }
                    else {
                         this.setState({
                              message:3,
                              oldPwd: '',
                              newPwd:'',
                              confirmNewPwd:'',
                         })
                         
                    }
               })
               .catch(error=> {
                    console.log(error);
               });
     }
     render() {
          let {message} = this.state;
          return (
               <div style={{ height: "80vh" }} className="container" id="form-login" >
                    <h1>Đổi mật khẩu</h1>
                    <form onSubmit={this.onSubmit}>
                         <div className="form-group">
                              <label htmlFor="user">Mật khẩu cũ:</label><br />
                              <input onChange={this.onChange} value={this.state.oldPwd} type="password" name="oldPwd" placeholder="Mật khẩu cũ" required /><br />
                         </div>
                         <div className="form-group">
                              <label htmlFor="pwd">Mật khẩu mới:</label><br />
                              <input onChange={this.onChange} value={this.state.newPwd} type="password" name="newPwd" placeholder=" Mật khẩu mới" required /><br />
                         </div>
                         <div className="form-group">
                              <label htmlFor="pwd">Xác nhận mật khẩu mới:</label><br />
                              <input onChange={this.onChange} value={this.state.confirmNewPwd} type="password" name="confirmNewPwd" placeholder="Xác nhận mật khẩu mới" required /><br />
                         </div>
                         <span id="err" />
                         <div className="submit-g">
                              <input className="btn btn-default" type="submit" value="Đổi mật khẩu" />
                         </div>
                    </form>
                    <div className="line" />
                    <p  style={message == 3?{color : "green"}:{message:"red"}}>{message == 1 ? 'Mật khẩu mới và xác nhận mật khẩu không khớp': message == 2? 'Mật khẩu cũ không chính xác' : message == 3 ? 'Đổi mật khẩu thành công' :'' }</p>
               </div>
          );
     }
}

export default ChangePwd;