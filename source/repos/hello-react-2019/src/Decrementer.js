import React, { Component } from 'react';

class Decrementer extends Component {
    render() {
        const {decrement}= this.props;
        return <button onClick={decrement}>--</button>;
    }
}

export default Decrementer;