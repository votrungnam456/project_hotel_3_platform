import React, { Component } from 'react'
import Banner from './Banner'
import Info from './Info'
import Service from './Service'


export default class Index extends Component {
     render() {
          return (
               <div>
                    <Banner/>
                    <Info history ={this.props.history}/>
                    <Service/>
               </div>
          )
     }
}
