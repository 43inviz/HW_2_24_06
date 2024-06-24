using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_24_06_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Movie movie = new Movie("123", "123", "123", 23, 2000);
                Console.WriteLine(movie);
                movie.Dispose();
            }




            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            {

                Performance per = new Performance("123", "123", "123", 2000,list);

                per.Show();
                per.Dispose();
            }
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            
            

            Console.ReadLine();
        }
    }
}
