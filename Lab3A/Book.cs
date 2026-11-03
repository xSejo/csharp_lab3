using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Book : Media, IEncryptable
    {
        public string Author { get; set; }
        public string Summary { get; set; }

        public Book(string title, int year, string author, string summary) : base(title, year)
        {
            Author = author;
            Summary = summary;
        }

        public string Encrypt()
        {
            return null;
        }

        public string Decrypt()
        {
            return null;
        }
    }
}
