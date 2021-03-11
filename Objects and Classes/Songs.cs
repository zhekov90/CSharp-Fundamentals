using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                string type = data[0];
                string name = data[1];
                string time = data[2];
                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                songs.Add(song);
            }
            string targerListType = Console.ReadLine();
            if (targerListType=="all")
            {
                foreach (Song currentSong in songs)
                {
                    Console.WriteLine(currentSong.Name); 
                }
            }
            else
            {
                songs.Where(x => x.TypeList == targerListType).ToList().ForEach(x => Console.WriteLine(x.Name));
            }
            
        }
        
      
    }
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
