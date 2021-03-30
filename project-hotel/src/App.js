import React, { Component } from 'react';
import Header from './components/header/header'
import Footer from './components/footer/footer'
import ListRoom from './components/rooms/listRoom'
class App extends Component {
  render() {
    return (
      <div>
        <Header/>
        <ListRoom/>
        <Footer/>
      </div>
    );
  }
}

export default App;