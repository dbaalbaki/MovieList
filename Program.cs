using System;
using System.Collections.Generic;

namespace MoviesLab
{
    class MovieList
    {
        public string MovieName;
  
        public MovieList(string NameOfMovie)
        {
            MovieName = NameOfMovie;
        }
    }
    
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Movie List Application! ");
            Console.WriteLine("\nThere are 15 movies in the list.");

            while (true)
            {

                string CategoryChoosen;

                Console.Write("\nWhat category are you interseted in (Comedy, Horror, Romantic)? ");
                CategoryChoosen = Console.ReadLine();

                List<MovieList> Comedy = new List<MovieList>();
                Comedy.Add(new MovieList("The Sandlot"));
                Comedy.Add(new MovieList("Billy Madison"));
                Comedy.Add(new MovieList("50 First Dates"));
                Comedy.Add(new MovieList("Big Daddy"));
                Comedy.Add(new MovieList("Mr.Deeds"));

                List<MovieList> Horror = new List<MovieList>();
                Horror.Add(new MovieList("American Psyhco"));
                Horror.Add(new MovieList("Black Christmas"));
                Horror.Add(new MovieList("Scanner"));
                Horror.Add(new MovieList("Black Sheep"));
                Horror.Add(new MovieList("Hell Raiser"));

                List<MovieList> Romantic = new List<MovieList>();
                Romantic.Add(new MovieList("The Big Stick"));
                Romantic.Add(new MovieList("Call Me By Your Name"));
                Romantic.Add(new MovieList("Top Hat"));
                Romantic.Add(new MovieList("Carol"));
                Romantic.Add(new MovieList("Before Midnight (2013)"));

                if (CategoryChoosen == "Comedy")
                {

                    foreach (MovieList current in Comedy)
                    {

                        Console.WriteLine($"{current.MovieName}");
                    }
                }
                else if (CategoryChoosen == "Horror")
                {
                    foreach (MovieList current in Horror)
                    {
                        Console.WriteLine($"{current.MovieName}");
                    }
                }
                else if (CategoryChoosen == "Romantic")
                {
                    foreach (MovieList current in Romantic)
                    {
                        Console.WriteLine($"{current.MovieName}");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input! PLease enter: (Horror , Comedy, or Romantic)");
                }
                string UserInputYN;
                Console.Write("\nWould you like to choose another genre? (y/n) ");
                UserInputYN = Console.ReadLine().ToLower();
                if (UserInputYN == "y")
                {
                    Console.WriteLine();
                }
                else if (UserInputYN == "n")
                {
                    Console.WriteLine("\nHave a wonderful day!");
                    break;
                }
                else if (UserInputYN != "y" && UserInputYN != "n")
                {
                    Console.WriteLine("\nInvalid Input! PLease enter (y or n)");
                }
            }

        }
    }
}
