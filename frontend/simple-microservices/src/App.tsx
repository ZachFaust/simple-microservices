import React from 'react';
import {Card, Paper} from '@material-ui/core';
import logo from './logo.svg';
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
            <img src={logo} className="App-logo" alt="logo" />
            <div className="ButtonColumn">
              <Card className="Card" elevation={5}>
                <ClockStream></ClockStream>
                <ClockTimer></ClockTimer>
              </Card>
            </div><br></br>
            <div className="ButtonColumn">
              <Card elevation={5}>
                <AddForm></AddForm>
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
