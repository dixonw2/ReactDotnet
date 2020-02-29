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
                this.Genres = "I can enjoy just about any genre (except for maybe country), ranging from Rock to Kpop to Metal to Rap, although Rock, Metal, and the "
                    + "multitude of various subgenres are definitely my favorites.";
                this.Favorites2017 = new Song[] {
                                                 new Song("Bear Claws",
                                                          "The Academic",
                                                          "https://music.apple.com/us/album/bear-claws/1481420364?i=1481420639&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/3lJIMpVTbmEwUXy0m4U9lU"),
                                                 new Song("Never Sorry",
                                                          "All That Remains",
                                                          "https://music.apple.com/us/album/never-sorry/1440946633?i=1440946653&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/3LNYKMfgG2UScseEv92XeP"),
                                                 new Song("Shape of You",
                                                          "Ed Sheeran",
                                                          "https://music.apple.com/us/album/shape-of-you/1193701079?i=1193701392&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/7qiZfU4dY1lWllzX7mPBI3"),
                                                 new Song("Sleeping Powder",
                                                          "Gorillaz",
                                                          "https://music.apple.com/us/album/sleeping-powder/1247590076?i=1247590729&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/5pE9vMyvVNOpZFutt6lyy4"),
                                                 new Song("Call Ins",
                                                          "He Is Legend",
                                                          "https://music.apple.com/us/album/call-ins/1440879185?i=1440879889&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/2sIPY6ELRwL5ZKswDhAdpD"),
                                                 new Song("State of the Art",
                                                          "Incubus",
                                                          "https://music.apple.com/us/album/state-of-the-art/1440881253?i=1440881901&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/7mVIEjxqffN2F1Q3NUHKPG"),
                                                 new Song("Black Butterflies and Déjà Vu",
                                                          "The Maine",
                                                          "https://music.apple.com/us/album/black-butterflies-and-d%C3%A9j%C3%A0-vu/1209457468?i=1209457776&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/6QZ8h3RqIgTRTo3hfaqryx"),
                                                 new Song("How Do You Feel?",
                                                          "The Maine",
                                                          "https://music.apple.com/us/album/how-do-you-feel/1209457468?i=1209458135&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/6AH3IbS61PiabZYKVBqKAk"),
                                                 new Song("Less Than",
                                                          "Nine Inch Nails",
                                                          "https://music.apple.com/us/album/less-than/1260014946?i=1260015502&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/7jDKJSjIjT93v7brsZDcoT"),
                                                 new Song("The Doomed",
                                                          "A Perfect Circle",
                                                          "https://music.apple.com/us/album/the-doomed/1340651075?i=1340651425&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/44OUZyiPnJc4pOZw4J6pid"),
                                                 new Song("Fabuless",
                                                          "Stone Sour",
                                                          "https://music.apple.com/us/album/fabuless/1229163139?i=1229163686&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/72GH838JaxrCA8IFcXqgXm"),
                                                 new Song("Rx (Medicate)",
                                                          "Theory of a Deadman",
                                                          "https://music.apple.com/us/album/rx-medicate/1262126917?i=1262126920&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/2UZtI2HUyLRzqBjodvcUmY"),
                                                 new Song("Feels Like Summer",
                                                          "Weezer",
                                                          "https://music.apple.com/us/album/feels-like-summer/1270328038?i=1270328050&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/2jz1bw1p0WQj0PDnVDP0uY")
                };
                this.Favorites2018 = new Song[] {
                                                 new Song("Voices in my Head",
                                                          "Ashley Tisdale",
                                                          "https://music.apple.com/us/album/voices-in-my-head/1457934050?i=1457934215&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/0Tyt3SyqRIsN0XHRyhD75J"),
                                                 new Song("Starlight",
                                                          "BABYMETAL",
                                                          "https://music.apple.com/us/album/starlight/1475662687?i=1475663365&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/2iAIBHvSNH5oHrCCpmeaBV"),
                                                 new Song("Zombie",
                                                          "Bad Wolves",
                                                          "https://music.apple.com/us/album/zombie/1337765138?i=1337765670&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/1vNoA9F5ASnlBISFekDmg3"),
                                                 new Song("Dice",
                                                          "BAND-MAID",
                                                          "https://music.apple.com/us/album/dice/1339560562?i=1339560706&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/26P0PvxuRYcgzxeHZ4rjD0"),
                                                 new Song("The Dark Sentencer",
                                                          "Coheed and Cambria",
                                                          "https://music.apple.com/us/album/the-dark-sentencer/1403404699?i=1403404719&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/0mP3O68nZjScrbgiD9UilH"),
                                                 new Song("Age of Man",
                                                          "Greta Van Fleet",
                                                          "https://music.apple.com/us/album/age-of-man/1435351050?i=1435351490&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/54DIzLw4LLxB3n1XiiQftU"),
                                                 new Song("Supplies",
                                                          "Justin Timberlake",
                                                          "https://music.apple.com/us/album/supplies/1330759954?i=1330760178&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/6jT85s2dZ55HBqjXYi2rfI"),
                                                 new Song("Over and Out",
                                                          "Nine Inch Nails",
                                                          "https://music.apple.com/us/album/over-and-out/1383304609?i=1383305129&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/1J8CqSsS6ErrveimQyCvZa"),
                                                 new Song("Disillusioned",
                                                          "A Perfect Circle",
                                                          "https://music.apple.com/us/album/disillusioned/1340651075?i=1340651416&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/1O9DWF3578RHMxZg2nLPeM"),
                                                 new Song("Body Talks",
                                                          "The Struts",
                                                          "https://music.apple.com/us/album/body-talks/1435805372?i=1435805536&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/6spaGIZEfeDYlgAupMI34k"),
                                                 new Song("COLORS",
                                                          "Tenacious D",
                                                          "https://music.apple.com/us/album/colors/1434624186?i=1434624879&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/40rChMoUd1VXb4TKgTuTSP"),
                                                 new Song("My Blood",
                                                          "twenty one pilots",
                                                          "https://music.apple.com/us/album/my-blood/1422828208?i=1422828213&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/5HeKOKc4phmLn8e4I7EkzD"),
                                                 new Song("What is Love?",
                                                          "TWICE",
                                                          "https://music.apple.com/us/album/what-is-love/1369699737?i=1369699742&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/3xTVxp0fQTm5hvUmQ1vU5C")
                };
                this.Favorites2019 = new Song[] {
                                                 new Song("Feeling so Good",
                                                          "Ashley Tisdale",
                                                          "https://music.apple.com/us/album/feeling-so-good/1457934050?i=1457934217&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/4GAFlFLouTialsJv1kiKaC"),
                                                 new Song("Brand New Day (feat. Tim Henson and Scott LePage",
                                                          "BABYMETAL",
                                                          "https://music.apple.com/us/album/brand-new-day-feat-tim-henson-scott-lepage/1475662687?i=1475663063&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/0FpJdOwxVYjN0UCIG6ovcR"),
                                                 new Song("Promise Me",
                                                          "Bad Flower",
                                                          "https://music.apple.com/us/album/promise-me/1440357164?i=1440357294&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/5TU1cWjUGyVKjSnIIxRSEf"),
                                                 new Song("mother tongue",
                                                          "Bring Me the Horizon",
                                                          "https://music.apple.com/us/album/mother-tongue/1439239477?i=1439240076&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/5IwUFTiNkarb5HEtNRtRtc"),
                                                 new Song("THE INNOCENT",
                                                          "FEVER 333",
                                                          "https://music.apple.com/us/album/the-innocent/1441326645?i=1441326655&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/1Y2FJpsOmfqfFuqS0KatUu"),
                                                 new Song("Flowers on the Grave",
                                                          "The Maine",
                                                          "https://music.apple.com/us/album/flowers-on-the-grave/1451377141?i=1451377387&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/2rsgWz1uCAsUlcjD12axTx"),
                                                 new Song("Miracle Man",
                                                          "Oliver Tree",
                                                          "https://music.apple.com/us/album/miracle-man/1474296525?i=1474296994&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/0ijiuWyVbNzg6Kw1Z1BVb8"),
                                                 new Song("Diseased Almost",
                                                          "Puddle of Mudd",
                                                          "https://music.apple.com/us/album/diseased-almost/1471037643?i=1471037656&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/7HaT692mQsfESjwD3TH8Uo"),
                                                 new Song("Beast",
                                                          "Saint Asonia",
                                                          "https://music.apple.com/us/album/beast/1478636853?i=1478637002&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/0AVKG4Qu7ubCzPlrWuhpMS"),
                                                 new Song("Nero Forte",
                                                          "Slipknot",
                                                          "https://music.apple.com/us/album/nero-forte/1463706038?i=1463706044&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/56fiFTRrSiHHH3gBeaTg2P"),
                                                 new Song("Descending",
                                                          "Tool",
                                                          "https://music.apple.com/us/album/descending/1475686696?i=1475687061&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/0aTiUssEOy0Mt69bsavj6K"),
                                                 new Song("LOVE FOOLISH",
                                                          "TWICE",
                                                          "https://music.apple.com/us/album/love-foolish/1480249009?i=1480249128&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/5L002vJ4NC0lRM8RtncBBp"),
                                                 new Song("Blow Me Away (feat. Jason Aalon Butler)",
                                                          "The Used",
                                                          "https://music.apple.com/us/album/blow-me-feat-jason-aalon-butler/1488189107?i=1488189112&app=music&ign-mpt=uo%3D4",
                                                          "https://open.spotify.com/track/5pvZGipNqXbamr7K8TVolA")
                };
            }
        }
        public class Song {
            public string SongName { get; set; }
            public string SongArtist { get; set; }
            public string SongAppleLink { get; set; }
            public string SongSpotifyLink { get; set; }
            public Song(string songName, string songArtist, string songAppleLink, string songSpotifyLink) {
                SongName = songName;
                SongArtist = songArtist;
                SongAppleLink = songAppleLink;
                SongSpotifyLink = songSpotifyLink;
            }
        }
    }

}