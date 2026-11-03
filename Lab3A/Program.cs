/*
  Name: Joseph Perez
  Student Number: 000977171
  Date: November 01, 2026
  Purpose: Reads a text file of media objects and provides an interactive console menu for viewing and searching.
  Statement of Authorship: I certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab3A
{
    /// <summary>
    /// Contains the main entry point and modular console menu methods for the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main execution loop that routes user input to the corresponding menu actions.
        /// </summary>
        /// <param name="args">Command line arguments passed to the application.</param>
        static void Main(string[] args)
        {
            List<Media> mediaList = new List<Media>();
            ReadData("Data.txt", mediaList);

            bool exit = false;
            while (!exit)
            {
                DisplayMenu();

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1: ListBooks(mediaList); break;
                        case 2: ListMovies(mediaList); break;
                        case 3: ListSongs(mediaList); break;
                        case 4: ListAllMedia(mediaList); break;
                        case 5: SearchMedia(mediaList); break;
                        case 6: exit = true; break;
                        default: Console.WriteLine("Invalid choice. Please select an option from 1 to 6."); break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        /// <summary>
        /// Displays the core navigation menu to the console.
        /// </summary>
        static void DisplayMenu()
        {
            Console.WriteLine("\n--- Media Collection Menu ---");
            Console.WriteLine("1. List All Books");
            Console.WriteLine("2. List All Movies");
            Console.WriteLine("3. List All Songs");
            Console.WriteLine("4. List All Media");
            Console.WriteLine("5. Search All Media by Title");
            Console.WriteLine("6. Exit Program");
            Console.Write("Enter your choice: ");
        }

        /// <summary>
        /// Filters and outputs all Book objects from the provided collection.
        /// </summary>
        /// <param name="mediaList">The full collection of loaded media objects.</param>
        static void ListBooks(List<Media> mediaList)
        {
            foreach (var media in mediaList.OfType<Book>())
            {
                Console.WriteLine($"Book: {media.Title} ({media.Year}) - Author: {media.Author}");
            }
        }

        /// <summary>
        /// Filters and outputs all Movie objects from the provided collection.
        /// </summary>
        /// <param name="mediaList">The full collection of loaded media objects.</param>
        static void ListMovies(List<Media> mediaList)
        {
            foreach (var media in mediaList.OfType<Movie>())
            {
                Console.WriteLine($"Movie: {media.Title} ({media.Year}) - Director: {media.Director}");
            }
        }

        /// <summary>
        /// Filters and outputs all Song objects from the provided collection.
        /// </summary>
        /// <param name="mediaList">The full collection of loaded media objects.</param>
        static void ListSongs(List<Media> mediaList)
        {
            foreach (var media in mediaList.OfType<Song>())
            {
                Console.WriteLine($"Song: {media.Title} ({media.Year}) - Album: {media.Album} - Artist: {media.Artist}");
            }
        }

        /// <summary>
        /// Outputs every media object in the collection without its summary data.
        /// </summary>
        /// <param name="mediaList">The full collection of loaded media objects.</param>
        static void ListAllMedia(List<Media> mediaList)
        {
            foreach (var media in mediaList)
            {
                if (media is Book b) Console.WriteLine($"Book: {b.Title} ({b.Year}) - Author: {b.Author}");
                else if (media is Movie m) Console.WriteLine($"Movie: {m.Title} ({m.Year}) - Director: {m.Director}");
                else if (media is Song s) Console.WriteLine($"Song: {s.Title} ({s.Year}) - Album: {s.Album} - Artist: {s.Artist}");
            }
        }

        /// <summary>
        /// Prompts the user for a search key, iterates through the collection, and prints detailed information (including decrypted summaries) for matches.
        /// </summary>
        /// <param name="mediaList">The full collection of loaded media objects.</param>
        static void SearchMedia(List<Media> mediaList)
        {
            Console.Write("Enter search string: ");
            string searchKey = Console.ReadLine();
            bool found = false;
            Console.WriteLine();

            foreach (var media in mediaList)
            {
                if (media.Search(searchKey))
                {
                    found = true;
                    if (media is Book b)
                        Console.WriteLine($"Book: {b.Title} ({b.Year}) - Author: {b.Author}\nSummary: {b.Decrypt()}\n");
                    else if (media is Movie m)
                        Console.WriteLine($"Movie: {m.Title} ({m.Year}) - Director: {m.Director}\nSummary: {m.Decrypt()}\n");
                    else if (media is Song s)
                        Console.WriteLine($"Song: {s.Title} ({s.Year}) - Album: {s.Album} - Artist: {s.Artist}\n");
                }
            }
            if (!found) Console.WriteLine("No matching media found.");
        }

        /// <summary>
        /// Parses the external data file, extracts delimited strings, and instantiates proper media objects.
        /// </summary>
        /// <param name="fileName">The local file path containing the raw media data.</param>
        /// <param name="mediaList">The list where instantiated objects will be stored.</param>
        static void ReadData(string fileName, List<Media> mediaList)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Trim() == "-----") continue;

                        string[] parts = line.Split('|');
                        string mediaType = parts[0];
                        string title = parts[1];
                        int year = int.Parse(parts[2]);

                        if (mediaType == "BOOK")
                        {
                            string author = parts[3];
                            string summary = reader.ReadLine();
                            mediaList.Add(new Book(title, year, author, summary));
                            reader.ReadLine();
                        }
                        else if (mediaType == "MOVIE")
                        {
                            string director = parts[3];
                            string summary = reader.ReadLine();
                            mediaList.Add(new Movie(title, year, director, summary));
                            reader.ReadLine();
                        }
                        else if (mediaType == "SONG")
                        {
                            string album = parts[3];
                            string artist = parts[4];
                            mediaList.Add(new Song(title, year, album, artist));
                            reader.ReadLine();
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: The file {fileName} could not be found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
        }
    }
}