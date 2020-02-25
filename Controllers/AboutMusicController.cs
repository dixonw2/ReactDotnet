using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AboutMusic.Controller {
    [ApiController]
    [Route("api/[controller]")]
    public class AboutMusicController : ControllerBase {

        [HttpGet]
        public AboutMusic Get() {
            return new AboutMusic();
        }

        public class AboutMusic {
            public string History { get; set; }
            public string Genres { get; set; }
            public Song[] Favorites2017 { get; set; }
            public Song[] Favorites2018 { get; set; }
            public Song[] Favorites2019 { get; set; }

            public AboutMusic() {
                this.History = "One of my favorite hobbies is listening to and playing music.  I have played guitar for over thirteen years and piano for about six years.  "
                    + "I'd like to get more into playing drums, but it's a bit too loud to practice while living in an apartment.";
                this.Genres = "I can enjoy just about any genre (except maybe not country), ranging from Rock to Kpop to Metal to Rap, although Rock, Metal, and the "
                    + "multitude of various subgenres are definitely my favorites.";
                this.Favorites2017 = new Song[] {new Song("Bear Claws", "The Academic", "https://music.apple.com/us/album/bear-claws/1481420364?i=1481420639&app=music&ign-mpt=uo%3D4"),
                                                 new Song("Never Sorry", "All That Remains", "")};
                this.Favorites2018 = new Song[13];
                this.Favorites2019 = new Song[13];
            }
        }
        public class Song {
            public string SongName { get; set; }
            public string SongArtist { get; set; }
            public string SongLink { get; set; }
            public Song(string songName, string songArtist, string songLink) {
                SongName = songName;
                SongArtist = songArtist;
                SongLink = songLink;
            }
        }
    }

}