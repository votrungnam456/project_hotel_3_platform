import React, { Component } from 'react';
import { Redirect } from 'react-router';

class logout extends Component {

     userFunc = (user) => {
          this.props.userFunc(user)
     }
     componentDidMount(){
          localStorage.removeItem("user");
          this.userFunc(null);
     }
     render() {
          return (
                    <Redirect to="/"></Redirect>
          );
     }
}

export default logout;