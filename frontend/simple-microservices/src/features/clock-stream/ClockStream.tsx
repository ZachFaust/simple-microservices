import React from 'react';
import * as signalR from '@microsoft/signalr';
import Moment from 'react-moment';
import Button from '@material-ui/core/Button';
import DialogTitle from '@material-ui/core/DialogTitle';
import Dialog from '@material-ui/core/Dialog';

interface IState {
    currentTime: string
    clockStreamConnection: signalR.HubConnection
    isOpen: boolean
}
export class ClockStream extends React.Component{
    state: IState;
    clockStreamSub: any;
    constructor(props: any) {
        super(props);
        this.state = {
            currentTime: 'init',
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
                    this.clockStreamSub = this.state.clockStreamConnection.stream("StreamClock").subscribe({
                        next: (item) => {this.setState({currentTime: item.toString()})},
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
                  Open ClockStream dialog
                </Button>
                <Dialog open={this.state.isOpen} onClose={this.handleClose}>
                    <DialogTitle>Clock Stream: Websocket -&gt; GRPC</DialogTitle>
                    <p>Current Time: <Moment unix>{this.state.currentTime}</Moment></p>
                    <p>This time display receives data from a websocket connection, that receives data from a GRPC stream.</p>
                </Dialog>
            </div>
        )
    }
}
