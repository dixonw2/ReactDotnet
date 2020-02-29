import React from 'react';
import Tabs from 'react-bootstrap/Tabs';
import Tab from 'react-bootstrap/Tab';
import { FavTable } from './FavTable';

export class AboutMusic extends React.Component {

  constructor(props) {
    super(props);
    this.state = {
      history: null,
      genres: null,
      favorites2017: [],
      favorites2018: [],
      favorites2019: [],
      loading: true
    };
  }

  componentDidMount() {
    this.populateFavoritesData();
  }

  renderButtons() {
    return (
      <Tabs id="uncontrolled-tab-example">
        <Tab eventKey="home" title="Favorites of 2017">
          <FavTable year="2017" favorites={this.state.favorites2017} />
        </Tab>
        <Tab eventKey="profile" title="Favorites of 2018">
          <FavTable year="2018" favorites={this.state.favorites2018} />
        </Tab>
        <Tab eventKey="contact" title="Favorites of 2019">
          <FavTable year="2019" favorites={this.state.favorites2019} />
        </Tab>
      </Tabs>);
  }

  render() {
    let contents = this.state.loading ? <p><em>Loading...</em></p> : this.renderButtons();
    return (
      <div>
        <h1 id="tableLabel">Music</h1>
        <p>{this.state.history}</p>
        <p>{this.state.genres}</p>
        {contents}
      </div>
    );
  }

  async populateFavoritesData() {
    const response = await fetch('api/aboutmusic');
    const data = await response.json();
    this.setState({ history: data.history, genres: data.genres, favorites2017: data.favorites2017, favorites2018: data.favorites2018, favorites2019: data.favorites2019, loading: false });
  }

}