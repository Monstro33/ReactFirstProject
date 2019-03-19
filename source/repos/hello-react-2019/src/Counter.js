import React, { Component } from "react";
import Incrementer from "./Incrementer";
import ValueDisplayer from "./ValueDisplayer";
import Decrementer from "./Decrementer";

class Counter extends Component {

    constructor() {
        super();
        this.state = {
            currentValue: 50
        };
    }

    increment = () => {
        const newValue = this.state.currentValue + 1;
        this.setState({currentValue: newValue});
    }

    decrement = () => {
        const newValue = this.state.currentValue - 1;
        this.setState({currentValue: newValue});
    }

    render() {
      return (
        <main>
            <Decrementer decrement={this.decrement} />
            <ValueDisplayer currentValue={this.state.currentValue} />
            <Incrementer increment={this.increment} />
        </main>
       );
    }
}

export default Counter;