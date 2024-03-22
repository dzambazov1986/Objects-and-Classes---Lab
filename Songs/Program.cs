using System;
using System.Collections.Generic;
using System.Linq;

public class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        int numberOfSongs = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 0; i < numberOfSongs; i++)
        {
            string[] songData = Console.ReadLine().Split('_');
            songs.Add(new Song { TypeList = songData[0], Name = songData[1], Time = songData[2] });
        }

        string command = Console.ReadLine();
        if (command == "all")
        {
            foreach (var song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            foreach (var song in songs.Where(s => s.TypeList == command))
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}
