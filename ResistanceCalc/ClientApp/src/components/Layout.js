import React, { Component } from 'react';
import { Col, Grid, Row } from 'react-bootstrap';

export class Layout extends Component {
  displayName = Layout.name

  render() {
      return (
          <Grid xs={12} xsoffset={0} md={8} mdoffset={2} >
            <Row>
                <Col className="body-content">
                    {this.props.children}
                    <hr />
                    <footer>
                        <p style={{ textAlign: "center" }}>2018 - ResistanceCalc</p>
                    </footer>
                </Col>
            </Row>
        </Grid>
    );
    }
}
