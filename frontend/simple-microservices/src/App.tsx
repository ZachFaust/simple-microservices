import React from 'react';
import {Card, CardContent, CardHeader, Paper} from '@material-ui/core';
import mainImage from './16_9x1080.png';
import { ClockStream } from './features/clock-stream/ClockStream';
import {ClockTimer} from './features/clock-timer/ClockTimer';
import { Header } from './features/header/Header';
import { AddForm } from './features/add-form/AddForm';
import { DivideForm } from './features/divide-form/DivideForm';
import { AverageForm } from './features/average-form/AverageForm';

import './App.css';

function App() {
  return (
    <div className="App">
        <Header></Header>
        <body>
          <div className="Row">
            <img src={mainImage} className="App-logo" alt="logo" />
            <Card>
              <CardHeader>Microservices Simplified</CardHeader>
              <CardContent> Paragraph</CardContent>
            </Card>
          </div>
            <div className="ButtonColumn">
              <Card className="Card" elevation={5}>
                <ClockStream></ClockStream>
                <ClockTimer></ClockTimer>
                <CardContent> These items use grpc streams to retrieve data.</CardContent>
              </Card>
            </div><br></br>
            <div className="ButtonColumn">
              <Card elevation={5} className="sidewaysCard">
                <AddForm></AddForm>
                <DivideForm></DivideForm>
                <AverageForm></AverageForm>
                <CardContent>These items use http requests to retrieve data.</CardContent>
              </Card>
              <Card elevation={5}>
                <DivideForm></DivideForm>
              </Card>
              <Card elevation={5}>
                <AverageForm></AverageForm>
              </Card>
            </div>
            <br></br>
        </body>
    </div>
  );
}

export default App;
