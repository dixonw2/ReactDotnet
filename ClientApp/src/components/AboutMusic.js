import React from 'react';

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

  static renderFavoritesTable(favorites2017, favorites2018) {
    let itunesImg = "https://linkmaker.itunes.apple.com/embed/v1/app-icon.svg";
    return (
      <>
        <table className='table table-striped' aria-labelledby="tableLabel">
          <thead>
            <tr>
              <th style={{ width: "5%" }}>Number</th>
              <th style={{ width: "45%" }}>Song</th>
              <th style={{ width: "35%" }}>Artist</th>
              <th style={{ width: "15%" }}>Link</th>
            </tr>
          </thead>
          <tbody>
            {favorites2017.map((song, index) =>
              <tr key={song.songName}>
                <td>{index + 1}</td>
                <td>{song.songName}</td>
                <td>{song.songArtist}</td>
                <td><a href={song.songLink}><img src={itunesImg} style={{ display: "inlineBlock", overflow: "hidden", width: "40px", height: "40px" }} /></a></td>
              </tr>
            )}
          </tbody>
        </table>
        <table className='table table-striped' aria-labelledby="tabelLabel">
          <thead>
            <tr>
              <th style={{ width: "5%" }}>Number</th>
              <th style={{ width: "45%" }}>Song</th>
              <th style={{ width: "35%" }}>Artist</th>
              <th style={{ width: "15%" }}>Link</th>
            </tr>
          </thead>
          <tbody>
            {favorites2018.map((song, index) =>
              <tr key={song.songName}>
                <td>{index + 1}</td>
                <td>{song.songName}</td>
                <td>{song.songArtist}</td>
                <td><a href={song.songLink}><img src={itunesImg} style={{ display: "inlineBlock", overflow: "hidden", width: "40px", height: "40px" }} /></a></td>
              </tr>
            )}
          </tbody>
        </table>
      </>
    );
  }

  render() {
    let contents = this.state.loading ? <p><em>Loading...</em></p> : AboutMusic.renderFavoritesTable(this.state.favorites2017, this.state.favorites2018);
    return (
      <div>
        <h1 id="tableLabel" >Music</h1>
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