using System;
using System.Collections.Generic;
using System.Text;

namespace SongsLibrary
{
    public class Song
    {
        public string SongTitle { get; set; }
        public string SongArtist { get; set; }
        public string SongGenre { get; set; }

        public Song() { }

        public override string ToString()
        {
            return "Song Title: " + SongTitle + "\n" +
                                    SongArtist + "\n" +
                                    SongGenre + "\n";
        }
    }
}
