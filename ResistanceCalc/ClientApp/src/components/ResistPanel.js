import React, { Component } from 'react';
import { PanelBody } from './PanelBody';

export class ResistPanel extends Component {
    displayName = ResistPanel.name

    constructor(props) {
        super(props);


        this.onPChange = this.onPChange.bind(this);
        this.onPClick = this.onPClick.bind(this);
        this.state = {
            resistance: "Select Resistor Colors",
            firstColor: "Black",
            secondColor: "Black",
            thirdColor: "Pink",
            fourthColor: "None"
        };
    }

    onPChange(name, value) {
        this.setState({ [name]: value });
    }

    async postResistance() {
        let response = await fetch('https://localhost:44345/Resist/GetResistance',
            {
                method: 'POST',
                headers:
                    {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                body: JSON.stringify({
                    ColorA: this.state.firstColor,
                    ColorB: this.state.secondColor,
                    ColorC: this.state.thirdColor,
                    ColorD: this.state.fourthColor,
                    Resistance: ""
                })
            })
            .then(res => { return res.text() })
            .catch(err => {
                console.log('Error: ', err)
            })
        
        return response.replace(/^"(.*)"$/, '$1');
    }

    async onPClick() {
        const content = "Resistance is " + (await this.postResistance()) + ".";
        this.setState({ "resistance" : content });
    }

    render() {
    return (
        <div>
            <div className="row ">
                <br />
                <div className="col-xs-12 col-xs-offset-0 col-md-4 col-md-offset-4">
                    <div className="panel panel-default">
                        <div className="panel-heading">
                            <div className="text-primary panelheader">{this.state.resistance}</div>
                        </div>
                        <div className="panel-body">
                            <PanelBody
                                onPClick={this.onPClick}
                                onPChange={this.onPChange}
                                firstColor={this.state.firstColor}
                                secondColor={this.state.secondColor}
                                thirdColor={this.state.thirdColor}
                                fourthColor={this.state.fourthColor} />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
    }


}
