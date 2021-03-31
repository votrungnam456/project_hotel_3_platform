import React, { Component } from 'react';
import Header from './components/header/Header'
import Footer from './components/footer/Footer'
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom'
import routes from './routes'
class App extends Component {
  render() {
    return (
      <Router>
        <div>
          <Header />
          <Switch>
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
        return (<Route key={index} path={route.path} exact={route.exact} component={route.main}></Route>)
      })
    }
    return result
  }
}

export default App;