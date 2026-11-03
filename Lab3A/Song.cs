/*
  Name: Joseph Perez
  Student Number: 000977171
  Date: November 2026
  Purpose: Represents a Song media object within the collection.
  Statement of Authorship: I certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    /// <summary>
    /// Represents a song, inheriting basic search functionality from the Media base class.
    /// </summary>
    internal class Song : Media
    {
        public string Album { get; set; }
        public string Artist { get; set; }

        /// <summary>
        /// Initializes a new instance of the Song class.
        /// </summary>
        /// <param name="title">The title of the song.</param>
        /// <param name="year">The year the song was released.</param>
        /// <param name="album">The album the song appears on.</param>
        /// <param name="artist">The artist who performs the song.</param>
        public Song(string title, int year, string album, string artist) : base(title, year)
        {
            Album = album;
            Artist = artist;
        }
    }
}