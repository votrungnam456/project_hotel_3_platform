import React, { Component } from 'react';
import Header from './components/header/Header'
import Footer from './components/footer/Footer'
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom'
import routes from './routes'
import './App.css';
import Login from './components/login/login'
import Logout from './components/login/logout';
import ChangePwd from './components/customer/ChangePwd'
import InfomationCustomer from './components/customer/InfomationCustomer';
class App extends Component {
  constructor(props){
    super(props)
    this.state = {
      user : null
    }
  }

  componentDidMount(){
    this.setState({
      user: JSON.parse(localStorage.getItem('user'))
    })
  }
  userFunc = (user) =>{
    console.log(user)
    this.setState({
      user
    })
  }

  render() {
    return (
      <Router>
        <div>
          <Header user={this.state.user} />
          <Switch>
            <Route path="/login" exact={true} component={({history})=><Login userFunc={this.userFunc} history={history}></Login>}></Route>
            <Route path="/logout" exact={true} component={({history})=><Logout userFunc={this.userFunc} history={history}></Logout>}></Route>
            <Route path="/changePwd" exact={true} component={({history})=><ChangePwd userFunc={this.userFunc} history={history}></ChangePwd>}></Route>
            {/* <Route path="/infoCustomer" exact={true} component={({history})=><InfomationCustomer user={this.state.user} history={history}></InfomationCustomer>}></Route> */}
            {this.setRoutes(routes)}

          </Switch>
          <Footer />
        </div>
      </Router>
    );
  }
  setRoutes = (routes) => {
    let result = null;
    if (routes.length > 0) {
      result = routes.map((route, index) => {
        // console.log(login)
        return (<Route key={index} path={route.path} exact={route.exact} component={route.main}></Route>)
      })
    }
    return result
  }
}

export default App;