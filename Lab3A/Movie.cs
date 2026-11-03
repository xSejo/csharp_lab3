using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Movie : Media, IEncryptable
    {
        public string Director { get; set; }
        public string Summary { get; set; }
        public Movie(string title, int year, string director, string summary) : base(title, year)
        {
            Director = director;
            Summary = summary;
        }

        public string Encrypt()
        {

            return null;
        }

        public string Decrypt()
        {
            // This method is not to be altered.
            return null;
        }
    }
}
