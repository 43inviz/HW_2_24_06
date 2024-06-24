using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_24_06_2_
{
    internal class Movie:IDisposable
    {
        public string Title { get; set; }
        public string PRodactionStudio { get; set; }

        public string Genre { get; set; }

        public int Duration { get; set; }

        public int Year { get; set; }

        public Movie() { }
        public Movie(string title, string pRodactionStudio, string genre, int duration, int year)
        {
            Title = title;
            PRodactionStudio = pRodactionStudio;
            Genre = genre;

            Duration = duration;
            Year = year;
        }

        public override string ToString()
        {
            return $"Title: {Title}\nStudio: {PRodactionStudio}\nGenre: {Genre}\nDuration: {Duration}\nYear: {Year}";
        }

        public void Dispose()
        {
            Console.WriteLine("Movie dispose");
        }

        ~Movie(){ 

            Console.WriteLine("\nData cleared");
        }

    }
}
