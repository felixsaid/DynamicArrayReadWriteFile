using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }

        public Movie()
        {
            Title = "Title";
            Director = "John Doe";
            Year = 1900;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Director: {0}", Director);
            Console.WriteLine("Year: {0}", Year);
            Console.WriteLine("...................................");
        }
    }
}
