using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoGameNames = new List<string>();
            videoGameNames.Add("Nba2k");
            videoGameNames.Add("Madden");
            videoGameNames.Add("Nhl");
            videoGameNames.Add("Mlb the show");
            videoGameNames.Add("Call of Duty vangaurd");
            var gamesOreded = (videoGameNames.OrderByDescending(x => x.Count()));
            foreach (var item in gamesOreded)
            {
                Console.WriteLine(item);
            }
        } 
    }
}
