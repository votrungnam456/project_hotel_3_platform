
import React, { Component } from 'react';
import * as api from '../../constant/api';
import axios from 'axios';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogContentText from '@material-ui/core/DialogContentText';
import DialogTitle from '@material-ui/core/DialogTitle';

export default class DialogCancelBooking extends Component {
     constructor(props) {
          super(props);
          this.state = {
               openDialog: false,
               maPhong: this.props.maPhong,
               user:this.props.user
          }
     }
     // const [open, setOpen] = React.useState(false);

     handleClickOpen = () => {

          this.setState({
               openDialog: true
          })
     };

     handleClose = (param) => {
          console.log(param)
          if(param){
               axios.delete(api.BASE_API + '/rooms/cancelBooking/'+this.state.maPhong).
               then(res => {
                    axios.get(api.BASE_API + '/customers/bookingInfo/' + this.state.user.ID_KH)
                    .then(res => {
                         this.props.data(res.data.data);
                    })
               })
          }
          this.setState({
               openDialog: false
          })
     };

     render() {
          console.log(this.state.maPhong)
          return (
               <div>
                    <button className="btn btn-default" onClick={this.handleClickOpen}>
                         Huỷ đặt phòng
                    </button>
                    <Dialog
                         open={this.state.openDialog}
                         onClose={this.handleClose}
                         aria-labelledby="alert-dialog-title"
                         aria-describedby="alert-dialog-description"
                    >
                         <DialogTitle id="alert-dialog-title">{"Huỷ đặt phòng ??"}</DialogTitle>
                         <DialogContent>
                              <DialogContentText id="alert-dialog-description">
                                   Bạn có chắc là muốn huỷ đặt phòng
                              </DialogContentText>
                         </DialogContent>
                         <DialogActions>
                              <button className="btn btn-default" onClick={()=>this.handleClose(true)} color="primary">
                                   Đồng ý
                              </button>
                              <button className="btn btn-default" onClick={()=>this.handleClose(false)} color="primary" autoFocus>
                                   Không đồng ý
                              </button>
                         </DialogActions>
                    </Dialog>
               </div>
          );
     }
}
