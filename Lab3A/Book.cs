/*
  Name: Joseph Perez
  Student Number: 000977171
  Date: November 2026
  Purpose: Represents a Book media object capable of encrypting and decrypting its summary.
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
    /// Represents a book, inheriting from Media and implementing IEncryptable to handle ROT13 summaries.
    /// </summary>
    internal class Book : Media, IEncryptable
    {
        public string Author { get; set; }
        public string Summary { get; set; }

        /// <summary>
        /// Initializes a new instance of the Book class.
        /// </summary>
        /// <param name="title">The title of the book.</param>
        /// <param name="year">The year the book was published.</param>
        /// <param name="author">The author of the book.</param>
        /// <param name="summary">The ROT13 encrypted summary of the book.</param>
        public Book(string title, int year, string author, string summary) : base(title, year)
        {
            Author = author;
            Summary = summary;
        }

        /// <summary>
        /// Applies the ROT13 substitution cipher to the book's summary.
        /// </summary>
        /// <returns>A new string containing the shifted characters.</returns>
        public string Encrypt()
        {
            char[] chars = Summary.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char letter = chars[i];

                if (letter >= 'a' && letter <= 'z')
                {
                    if (letter > 'm') letter -= (char)13;
                    else letter += (char)13;
                    chars[i] = letter;
                }
                else if (letter >= 'A' && letter <= 'Z')
                {
                    if (letter > 'M') letter -= (char)13;
                    else letter += (char)13;
                    chars[i] = letter;
                }
            }
            return new string(chars);
        }

        /// <summary>
        /// Decrypts the book's summary by re-applying the symmetric ROT13 cipher.
        /// </summary>
        /// <returns>The decrypted readable summary.</returns>
        public string Decrypt()
        {
            return Encrypt();
        }
    }
}