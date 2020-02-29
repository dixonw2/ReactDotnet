import React from 'react';

export const FavTable = props => (
    <>
        <h2 style={{marginTop: "10px", marginBottom: "10px", textAlign: "center"}}>Top {props.favorites.length} Favorite Songs of {props.year}</h2>
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
                {props.favorites.map((song, index) =>
                    <tr key={song.songName}>
                        <td>{index + 1}</td>
                        <td>{song.songName}</td>
                        <td>{song.songArtist}</td>
                        <td><a href={song.songAppleLink} rel="noopener noreferrer" target="_blank"><img src="https://linkmaker.itunes.apple.com/embed/v1/app-icon.svg" style={{ display: "inlineBlock", overflow: "hidden", width: "40px", height: "40px" }} /></a>
                            <a href={song.songSpotifyLink} rel="noopener noreferrer" target="_blank"><img src="https://www.freeiconspng.com/uploads/spotify-icon-2.png" style={{ display: "inlineBlock", overflow: "hidden", width: "40px", height: "40px", marginLeft: "3px" }} /></a>
                        </td>
                    </tr>
                )}
            </tbody>
        </table>
    </>
);