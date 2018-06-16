import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { ResistPanel } from './components/ResistPanel';


export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <Layout>
            
            <Route component={ResistPanel} />
      </Layout>
    );
    }

    //<Route exact path='/' component={ResistPanel} />
//<Layout>
//    <Route exact path='/Home' component={Home} />
//    <Route path='/fetchdata' component={FetchData} />
//    <Route path='/TestComp' component={TestComp} />
//</Layout>
}
