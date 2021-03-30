import React, { Component } from 'react';

class header extends Component {
     render() {
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
                         <li><a href="#">Home </a></li>
                         <li><a href="#">Rooms &amp; Tariff</a></li>        
                         <li><a href="#">Introduction</a></li>
                         <li><a href="#">Gallery</a></li>
                         <li><a href="#">Contact</a></li>
                    </ul>
                    </div>{/* Wnavbar-collapse */}
               </div>{/* container-fluid */}
               </nav>
               {/* header */}
               </div>
          );
     }
}

export default header;