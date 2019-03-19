import React, { Component } from 'react';

class ValueDisplayer extends Component {
    render() {
        const {currentValue} = this.props;
        return  <span>{currentValue}</span> ;
    }
}

export default ValueDisplayer;