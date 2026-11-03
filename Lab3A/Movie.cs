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
            char[] chars = Summary.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char letter = chars[i];

                if (letter >= 'a' && letter <= 'z')
                {
                    if (letter > 'm')
                    {
                        letter -= (char)13;
                    }
                    else
                    {
                        letter += (char)13;
                    }
                    chars[i] = letter;
                }
                else if (letter >= 'A' && letter <= 'Z')
                {
                    if (letter > 'M')
                    {
                        letter -= (char)13;
                    }
                    else
                    {
                        letter += (char)13;
                    }
                    chars[i] = letter;
                }
            }
            return new string(chars);
        }

        public string Decrypt()
        {
            return Encrypt();
        }
    }
}
