import React, { Component } from 'react';
import { valueColors, magnitudeColors, toleranceColors } from './colors/colors';

export class PanelBody extends Component {
    displayName = PanelBody.name

    constructor(props) {
        super(props);

        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleOnClick = this.handleOnClick.bind(this);        
    }

    handleInputChange(event) {
        const name = event.target.name;
        const value = event.target.value;
        this.props.onPChange(name, value);
    }

    handleOnClick() {
        this.props.onPClick();
    }

    

    createSelectItems(colorDictionary) {
        let colors = colorDictionary.map(q =>
            (<option value={q.color} key={q.color}>{q.color}</option>)
        );
        return colors;
    }

    render() {
        return (
            <div>
                <div className="form-group">
                    <label>First Color </label>
                    <select className="form-control" name="firstColor" onChange={this.handleInputChange} label="First Color">
                        {this.createSelectItems(valueColors)}
                    </select>
                </div>
                <div className="form-group">
                    <label>Second Color </label>
                    <select className="form-control" name="secondColor" onChange={this.handleInputChange} label="Second Color">
                        {this.createSelectItems(valueColors)}
                    </select>
                </div>
                <div className="form-group">
                    <label>Third Color </label>
                    <select className="form-control" name="thirdColor" onChange={this.handleInputChange} label="Third Color">
                        {this.createSelectItems(magnitudeColors)}
                    </select>
                </div>
                <div className="form-group">
                    <label>Fourth Color </label>
                    <select className="form-control" name="fourthColor" onChange={this.handleInputChange} label="Fourth Color">
                        {this.createSelectItems(toleranceColors)}
                    </select>
                </div>
                <div className="col-xs-12 col-xs-offset-0">
                    <div>
                        <table className="hor-resistor" align="center">
                            <tbody>
                                <tr>
                                    <td className="hor-ends"></td>
                                    <td className={ `hor-band ${this.props.firstColor.toLowerCase()}`}></td>
                                    <td className="hor-blank"></td>
                                    <td className={`hor-band ${this.props.secondColor.toLowerCase()}`}></td>
                                    <td className="hor-blank"></td>
                                    <td className={`hor-band ${this.props.thirdColor.toLowerCase()}`}></td>
                                    <td className="hor-blank"></td>
                                    <td className="hor-blank"></td>
                                    <td className="hor-blank"></td>
                                    <td className="hor-blank"></td>
                                    <td className={`hor-band ${this.props.fourthColor.toLowerCase()}`}></td>
                                    <td className="hor-ends"></td>
                                </tr>
                            </tbody>
                        </table>
                        <br />
                    </div>
                </div>
                <button className="btn btn-primary" onClick={this.handleOnClick} id="submitButton">Show Your Resistance</button>
            </div>
        );
    }

//                  <div className="col-xs-12 col-xs-offset-0">
//    <div>
//        <table className="hor-resistor" align="center">
//            <tr>
//                <td className="hor-ends"></td>
//                <td className="hor-band" id="bandA"></td>
//                <td className="hor-blank"></td>
//                <td className="hor-band" id="bandB"></td>
//                <td className="hor-blank"></td>
//                <td className="hor-band" id="bandC"></td>
//                <td className="hor-blank"></td>
//                <td className="hor-blank"></td>
//                <td className="hor-blank"></td>
//                <td className="hor-blank"></td>
//                <td className="hor-band" id="bandD"></td>
//                <td className="hor-ends"></td>
//            </tr>
//        </table>
//        <br />
//    </div>
//</div>
}