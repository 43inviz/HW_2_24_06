using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_24_06_2_
{
    internal class Performance:IDisposable
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public string Theatre { get; set; }

        public int Year { get; set; }
        public List<string> Actors { get; set; }

        public Performance() { }

        public Performance(string title, string genre, string theatre, int year, List<string> actors)
        {
            Title = title;
            Genre = genre;
            Theatre = theatre;
            Year = year;
            Actors = actors;
        }

        public void Show()
        {
            Console.WriteLine($"Title: {Title}\nGenre: {Genre}\nTheatre: {Theatre}\nYear: {Year}\nActors: ");
            foreach ( var actor in Actors )
            {
                Console.WriteLine($"{actor} " );
            }

        }

        public void Dispose() {
            Console.WriteLine("End of performance");
        }

        ~ Performance() {
            Console.WriteLine("End of performance");
        }
    }
}
