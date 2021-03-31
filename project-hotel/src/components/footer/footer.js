import React, { Component } from 'react';
import { Route, Link } from 'react-router-dom'

const links = [
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
      to: "/info",
      exact: false
      },
 ]
 const QuickLink = ({ label, to, activeOnlyWhenExact }) => {
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
class Footer extends Component {
     render() {
          return (
               <footer className="spacer">
               <div className="container">
               <div className="row">
                    <div className="col-sm-5">
                    <h4>Holiday Crown Hotel</h4>
                    <p>140 Lê Trọng Tấn</p>
                    <p>0908002xxx</p>
                    </div>              
                    <div className="col-sm-3">
                    <h4>Truy cập nhanh</h4>
                    <ul className="list-unstyled">
                         {this.quickLinks(links)}
                    </ul>
                    </div>
                    <div className="col-sm-4 subscribe">
                    <h4>Đăng ký nhận tin</h4>
                    <div className="input-group">
                         <input type="text" className="form-control" placeholder="Nhập email" />
                         <span className="input-group-btn">
                         <button className="btn btn-default" type="button">Đăng ký</button>
                         </span>
                    </div>
                    <div className="social">
                         <a href="#"><i className="fa fa-facebook-square" data-toggle="tooltip" data-placement="top" data-original-title="facebook" /></a>
                         <a href="#"><i className="fa fa-instagram" data-toggle="tooltip" data-placement="top" data-original-title="instragram" /></a>
                         <a href="#"><i className="fa fa-twitter-square" data-toggle="tooltip" data-placement="top" data-original-title="twitter" /></a>
                         <a href="#"><i className="fa fa-pinterest-square" data-toggle="tooltip" data-placement="top" data-original-title="pinterest" /></a>
                         <a href="#"><i className="fa fa-tumblr-square" data-toggle="tooltip" data-placement="top" data-original-title="tumblr" /></a>
                         <a href="#"><i className="fa fa-youtube-square" data-toggle="tooltip" data-placement="top" data-original-title="youtube" /></a>
                    </div>
                    </div>
               </div>
               {/*/.row*/} 
               </div>
               {/*/.container*/}    
               {/*/.footer-bottom*/} 
               </footer>

          );
     }
     quickLinks = (links) =>{
          let result = null
          if(links.length > 0){
              result = links.map((link,index) => {
                  return (<QuickLink key = {index} label={link.name} to = {link.to} activeOnlyWhenExact={link.exact}></QuickLink>)
              })
          }
          return result
      }
}

export default Footer;