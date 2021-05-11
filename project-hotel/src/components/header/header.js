import React, { Component } from 'react';
import { Route, Link } from 'react-router-dom'


let user = JSON.parse(localStorage.getItem('user'));
let checkUser = (user == null ? true : false);
const menus = [
    {
        name: "Trang chủ",
        to: "/",
        exact: true
    },
    {
        name: "Đặt phòng",
        to: "/rooms",
        exact: false
    },
    {
        name: "Liên hệ",
        to: "/contact",
        exact: false
    },
    {
        name: "Kho hình",
        to: "/gallery",
        exact: false
    },
    {
     name: "Giới thiệu",
     to: "/intro",
     exact: false
     },
    // {
    //     name: checkUser == true ? "Đăng nhập" : "Đăng xuất",
    //     to: checkUser == true ? "/login" : "/logout",
    //     exact: false
    // },
]
const MenuLink = ({ label, to, activeOnlyWhenExact }) => {
     return (
         <Route path={to} exact={activeOnlyWhenExact} children={({ match }) => {
             let active = match ? 'active abcClassTest ' : '';
             return (
                 <li>
                     <Link to={to}>{label}</Link>
                 </li>
             )
         }}></Route>
     )
 }
class Header extends Component {
    constructor(props){
        super(props);
        this.state = {
            user:null
        }
    }

    // loginFunc = (user) =>{
    //     this.props.loginFunc(user);
    // }

    // componentDidMount(){
    //     this.setState({
    //         user: JSON.parse(localStorage.getItem('user'))
    //     })
    // }
     render() {
         let {user} = this.props
          return (
              
               <div>
               {/* header */}
               <nav className="navbar  navbar-default" role="navigation">
               <div className="container">
                    {/* Brand and toggle get grouped for better mobile display */}
                    <div className="navbar-header">
                    <button type="button" className="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                         <span className="sr-only">Toggle navigation</span>
                         <span className="icon-bar" />
                         <span className="icon-bar" />
                         <span className="icon-bar" />
                    </button>
                    <a className="navbar-brand" href="index.php"><img src="images/logo.png" alt="holiday crown" /></a>
                    </div>
                    {/* Collect the nav links, forms, and other content for toggling */}
                    <div className="collapse navbar-collapse navbar-right" id="bs-example-navbar-collapse-1">
                    <ul className="nav navbar-nav">        
                         {this.showMenu(menus)}
                         <MenuLink  label={user == null ? "Đăng nhập" : "Đăng xuất"} to={user == null ? "/login" : "/logout"} exact="true"></MenuLink>
                    </ul>
                    </div>{/* Wnavbar-collapse */}
               </div>{/* container-fluid */}
               </nav>
               {/* header */}
               </div>
          );
     }
     showMenu = (menus) =>{
          let result = null
          if(menus.length > 0){
              result = menus.map((menu,index) => {
                  return (<MenuLink key = {index} label={menu.name} to = {menu.to} activeOnlyWhenExact={menu.exact}></MenuLink>)
              })
          }
          return result
      }
}

export default Header;