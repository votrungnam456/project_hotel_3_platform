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
]
const BonusMenuNoneUser =[
    {
        name : "Đăng nhập",
        to:"/login",
        exact : true
    },
    {
        name : "Đăng ký",
        to:"/register",
        exact : true
    }
]
const BonusMenuHasUser =[
    {
        name : "Thông tin cá nhân",
        to:"/infoCustomer",
        exact : true
    },
    {
        name : "Đăng xuất",
        to:"/logout",
        exact : true
    }
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
                    <Link className="navbar-brand" to="/"><img src="images/logo.png" alt="holiday crown" /></Link>
                    </div>
                    {/* Collect the nav links, forms, and other content for toggling */}
                    <div className="collapse navbar-collapse navbar-right" id="bs-example-navbar-collapse-1">
                    <ul className="nav navbar-nav">        
                         {this.showMenu(menus)}
                         {/* {user != null ? <MenuLink label={"Đổi mật khẩu"} to="/changePwd" exact="true"></MenuLink> : ""} */}
                         {/* <MenuLink  label={user == null ? "Đăng nhập" : "Đăng xuất"} to={user == null ? "/login" : "/logout"} exact="true"></MenuLink> */}
                         {
                            user == null ? BonusMenuNoneUser.map((value,key)=>
                                <MenuLink key={key} label={value.name} to={value.to} exact={value.exact}></MenuLink>
                            ):
                            BonusMenuHasUser.map((value,key)=>
                                <MenuLink key={key} label={value.name} to={value.to} exact={value.exact}></MenuLink>
                            )
                         }

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