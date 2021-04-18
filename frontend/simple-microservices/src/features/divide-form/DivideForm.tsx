import React, { ChangeEvent } from 'react';
import Button from '@material-ui/core/Button';
import { TrackChangesRounded } from '@material-ui/icons';
import styles from './DivideForm.module.css';
import  axios from 'axios';


interface IState {
    numbers: number[]
    result: string
}
export class DivideForm extends React.Component {
    state: IState;

    constructor(props: any) {
        super(props);
        this.state = {
            numbers: [],
            result: '',
        };
    }
    handleAddNumber = () => {
        this.setState({numbers: this.state.numbers.concat(1)});
    }
    handleRemoveNumber = (index: number) => {
        let arr = [...this.state.numbers];
        arr.splice(index, 1);
        this.setState({numbers: arr});
    }
    handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        const target = event.target;
        console.log(target.value);
        if (target.name === "number") {
            let arr = [...this.state.numbers];
            console.log(Number(target.value));
            arr[Number(target.id)] = Number(target.value);
            console.log(arr);
            this.setState({numbers: arr});
            console.log(this.state.numbers);
        }
        console.log(this.state.numbers);
    }
    handleCalculateDivide = () => {
        axios({
            method: 'post',
            headers: { 'Content-Type': 'application/json', },
            url: 'http://localhost:5000/math/divide',
            data: {Numbers: this.state.numbers}
        }).then((response) => {
            console.log(response.data);
            this.setState({result: response.data});
        }).catch((err) => console.log(err))
    }
    render() {
        return (
            <div className={styles.outer}>
                <h3>Result: {this.state.result}</h3>
                <form>
                    Dividing Numbers
                    <br></br>
                    {this.state.numbers.map((val, index) => (
                        <div key={index} className="inputDiv">
                            <input 
                                type="number" 
                                name="number" 
                                onChange={this.handleChange} 
                                defaultValue={val}
                                id={index.toString()}>
                            </input>
                            <Button color="primary" onClick={() => this.handleRemoveNumber(index)}> - </Button>
                        </div>
                    ))}
                    
                </form>
                <Button color="primary" onClick={this.handleAddNumber}>
                    Add Number
                </Button>
                <Button color="primary" onClick={this.handleCalculateDivide}>
                    Calculate Division
                </Button>
            </div>
        )
    }
}