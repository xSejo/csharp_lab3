using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Media> mediaList = new List<Media>();
            ReadData("Data.txt", mediaList);

            bool exit = false;
            while (!exit)
            {
                DisplayMenu();

                // Error checking for user input
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:
                            foreach (var media in mediaList.OfType<Book>())
                                Console.WriteLine($"Book: {media.Title} ({media.Year}) - Author: {media.Author}");
                            break;
                        case 2:
                            foreach (var media in mediaList.OfType<Movie>())
                                Console.WriteLine($"Movie: {media.Title} ({media.Year}) - Director: {media.Director}");
                            break;
                        case 3:
                            foreach (var media in mediaList.OfType<Song>())
                                Console.WriteLine($"Song: {media.Title} ({media.Year}) - Album: {media.Album} - Artist: {media.Artist}");
                            break;
                        case 4:
                            foreach (var media in mediaList)
                            {
                                if (media is Book b) Console.WriteLine($"Book: {b.Title} ({b.Year}) - Author: {b.Author}");
                                else if (media is Movie m) Console.WriteLine($"Movie: {m.Title} ({m.Year}) - Director: {m.Director}");
                                else if (media is Song s) Console.WriteLine($"Song: {s.Title} ({s.Year}) - Album: {s.Album} - Artist: {s.Artist}");
                            }
                            break;
                        case 5:
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
                            break;
                        case 6:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select an option from 1 to 6.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        static void ReadData(string fileName, List<Media> mediaList)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Trim() == "-----")
                        {
                            continue;
                        }

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


    }
}
