import React, {Component} from 'react';

class Header extends Component{
    render(){
        const logourl = "https://s3.amazonaws.com/poly-screenshots.angel.co/enhanced_screenshots/1348311-original.jpg";
        return ( 
        <header>
            <img src ={logourl} alt ="Logo" style={{width: '10vh'}}/>
            Header
        </header>);           
    }
}

export default Header;