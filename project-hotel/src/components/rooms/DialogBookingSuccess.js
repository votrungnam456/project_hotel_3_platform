
import React, { Component } from 'react';
import * as api from '../../constant/api';
import axios from 'axios';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogContentText from '@material-ui/core/DialogContentText';
import DialogTitle from '@material-ui/core/DialogTitle';

export default class DialogBookingSuccess extends Component {
     constructor(props) {
          super(props);
          this.state = {
               openDialog: false,
          }
     }


     handleClickOpen = () => {

          this.setState({
               openDialog: true
          })
     };

     handleClose = () => {
          this.props.history.push('/rooms');
          this.setState({
               openDialog: false
          })
     };

     render() {
          console.log(this.state.maPhong)
          return (
               <div>
                    {/* <button className="btn btn-default" onClick={this.handleClickOpen}>
                         Huỷ đặt phòng
                    </button> */}
                    <Dialog
                         open={this.state.openDialog}
                         onClose={this.handleClose}
                         aria-labelledby="alert-dialog-title"
                         aria-describedby="alert-dialog-description"
                    >
                         <DialogTitle id="alert-dialog-title">{"Đặt phòng thành công"}</DialogTitle>
                         <DialogContent>
                              <DialogContentText id="alert-dialog-description">
                                   Đặt phòng thành công
                              </DialogContentText>
                         </DialogContent>
                         <DialogActions>
                              <button className="btn btn-default" onClick={()=>this.handleClose()} color="primary">
                                   Xác nhận
                              </button>
                         </DialogActions>
                    </Dialog>
               </div>
          );
     }
}
