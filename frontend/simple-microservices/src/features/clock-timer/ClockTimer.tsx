import React from 'react';
import * as signalR from '@microsoft/signalr';
import Moment from 'react-moment';
import Button from '@material-ui/core/Button';
import DialogTitle from '@material-ui/core/DialogTitle';
import Dialog from '@material-ui/core/Dialog';

interface IState {
    timeRemaining: string
    message: string
    clockStreamConnection: signalR.HubConnection
    isOpen: boolean
}
export class ClockTimer extends React.Component{
    state: IState;
    clockStreamSub: any;
    constructor(props: any) {
        super(props);
        this.state = {
            timeRemaining: '',
            message: '',
            clockStreamConnection: new signalR.HubConnectionBuilder().withUrl("http://localhost:5000/api/clockstream").build(),
            isOpen: false
        }
    }
    componentWillUnmount() {
        (this.clockStreamSub as signalR.ISubscription<any>).dispose();
        this.state.clockStreamConnection.stop();
    }
    handleClickOpen = () => {
        this.setState({isOpen: true}, () => {
            this.state.clockStreamConnection.start()
                .then(() => {
                    console.log("SignalR Started");
                    this.clockStreamSub = this.state.clockStreamConnection.stream("StreamTimer",{
                        Length: 5,
                        Message: 'test'
                    }).subscribe({
                        next: (item) => {this.setState({timeRemaining: item.timeRemaining.toString(), message: item.message})},
                        complete: () => {console.log("Done")},
                        error: (err) => {console.log(err)}
                    });
                })
                .catch(err => console.log("Error starting SignalR: " + err));
        });
      };
      handleClose = () => {
          this.setState({isOpen: false});
          this.setState(() => {
            (this.clockStreamSub as signalR.ISubscription<any>).dispose();
            this.state.clockStreamConnection.stop();
          });
      };
    render(){
        return (
            <div>
                <Button variant="outlined" color="primary" onClick={this.handleClickOpen}>
                  Open ClockTimer dialog
                </Button>
                <Dialog open={this.state.isOpen} onClose={this.handleClose}>
                    <DialogTitle>Clock Timer: Websocket -&gt; GRPC</DialogTitle>
                    <p>Time Remaining: {this.state.timeRemaining}</p>
                    <p>Message: {this.state.message}</p>
                    <p>This time display receives data from a websocket connection, that receives data from a GRPC stream.</p>
                </Dialog>
            </div>
        )
    }
}
