using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Song : Media
    {
        public string Album { get; set; }
        public string Artist { get; set; }
        public Song(string title, int year, string album, string artist) : base(title, year)
        {
            Album = album;
            Artist = artist;
        }
    }
}
