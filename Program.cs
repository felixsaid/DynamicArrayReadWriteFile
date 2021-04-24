using System;
using System.IO;

namespace DynamicArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Movie[] objMovies = new Movie[1];
            int choice = 0;


            do
            {
                Console.WriteLine("1. Loading Data");
                Console.WriteLine("2. Display all Movies");
                Console.WriteLine("3. Add a Movie");
                Console.WriteLine("4. Exit");
                Console.Write("Make a choice from 1 - 4: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LoadData(ref objMovies);
                        break;

                    case 2:
                        DisplayAllMovies(objMovies);
                        break;

                    case 3:
                        AddMovie(ref objMovies);
                        break;

                    default:
                        break;
                }

                Console.Clear();

            } while (choice != 4);
        }

        public static void LoadData(ref Movie[] objMovies)
        {
            StreamReader reader = new StreamReader("Movies.txt");
            int size = Convert.ToInt32(reader.ReadLine());
            objMovies = new Movie[size];

            for(int index = 0; index < objMovies.Length; index++)
            {
                objMovies[index] = new Movie();
                objMovies[index].Title = reader.ReadLine();
                objMovies[index].Director = reader.ReadLine();
                objMovies[index].Year = Convert.ToInt32(reader.ReadLine());
            }

            reader.Close();

            Console.WriteLine("Data was loaded. Press ay key to continue...");
            Console.ReadKey();
        }

        public static void DisplayAllMovies(Movie[] objMovies)
        {
            Console.Clear();

            for(int index = 0; index < objMovies.Length; index++)
            {
                objMovies[index].DisplayInformation();
            }

            Console.WriteLine("Press ay key to continue...");
            Console.ReadKey();
        }

        public static void AddMovie(ref Movie[] objMovies)
        {
            StreamWriter writer = new StreamWriter("Movies.txt");
            writer.WriteLine(objMovies.Length + 1);

            Movie temp = new Movie();

            Console.Write("Enter Title: ");
            temp.Title = Console.ReadLine();

            Console.Write("Enter Director: ");
            temp.Director = Console.ReadLine();

            Console.Write("Enter Year: ");
            temp.Year = Convert.ToInt32(Console.ReadLine());


            //write the new data to the file

            writer.WriteLine(temp.Title);
            writer.WriteLine(temp.Director);
            writer.WriteLine(temp.Year);

            //put old movies back to the file

            for(int index = 0; index < objMovies.Length; index++)
            {
                writer.WriteLine(objMovies[index].Title);
                writer.WriteLine(objMovies[index].Director);
                writer.WriteLine(objMovies[index].Year);
            }

            //close the file

            writer.Close();

            //update our array

            LoadData(ref objMovies);
        }
    }
}
