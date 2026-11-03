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


    }
}
