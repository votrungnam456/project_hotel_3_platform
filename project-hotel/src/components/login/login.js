import React, { Component } from 'react';
import { Link, Redirect } from 'react-router-dom';
import axios from 'axios';
class login extends Component {
     constructor(props) {
          super(props);
          this.state = {
               email: "",
               pwd: "",
          }
     }
     onChange = (ev) => {
          let name = ev.target.name;
          let value = ev.target.value
          this.setState({
               [name]: value
          })

     }

     onSubmit = (ev) => {
          let userFunc = (user) => {
               this.props.userFunc(user)
          }
          let { history,location } = this.props
          ev.preventDefault();
          let { pwd, email } = this.state;
          axios.post('http://localhost:4444/customers/user', {
               Email: email,
               MatKhau: pwd
          })
               .then(function (response) {
                    if (response.data.data == null) {
                    }
                    else {
                         localStorage.setItem('user', JSON.stringify(response.data.data));
                         userFunc({
                              user: JSON.stringify(response.data.data)
                         })
                         history.push("/");  
                    }
               })
               .catch(function (error) {
                    console.log(error);
               });
     }
     render() {
          
          return (
               <div style={{ height: "80vh" }} className="container">
                    <div className="login-form">
                         <h1>Đăng nhập</h1>
                         <div id="form-login" >
                              <form onSubmit={this.onSubmit}>
                                   <div className="form-group">
                                        <label htmlFor="user">Email:</label><br />
                                        <input onChange={this.onChange} value={this.state.email} type="text" name="email" placeholder="example@abc.com" required /><br />
                                   </div>
                                   <div className="form-group">
                                        <label htmlFor="pwd">Mật khẩu:</label><br />
                                        <input onChange={this.onChange} value={this.state.pwd} type="password" name="pwd" placeholder=" Mật khẩu" required /><br />
                                   </div>
                                   <span id="err" />
                                   <div className="submit-g">
                                        <input className="btn btn-default" type="submit" value="Đăng nhập" />
                                   </div>
                              </form>
                              <div className="line" />
                              <div className="sign-up-btn">
                                   <p id="sign-up">Bạn chưa có tài khoản?|<Link to="/register">đăng ký</Link> ngay</p>
                              </div>
                         </div>
                    </div>
               </div>
          );
     }
}

export default login;