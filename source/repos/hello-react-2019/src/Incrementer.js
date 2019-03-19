import React, { Component } from 'react';

class Incrementer extends Component {
    render() {
        const {increment} = this.props;
        return <button onClick={increment}>++</button>;
    }
}

export default Incrementer;