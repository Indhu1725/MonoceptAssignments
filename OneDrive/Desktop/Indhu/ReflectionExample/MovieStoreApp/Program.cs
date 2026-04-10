using System;
using System.Collections.Generic;

namespace MovieStoreApp
{
    // Movie Class
    class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public string Genre { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Year: {YearOfRelease}, Genre: {Genre}");
        }
    }

    class Program
    {
        static List<Movie> movies = new List<Movie>();
        const int MAX_MOVIES = 5;

        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Welcome to movie store developed by : Indira");

            do
            {
                Console.WriteLine("\n1. Add new Movie");
                Console.WriteLine("2. Display All Movies");
                Console.WriteLine("3. Find Movie by ID");
                Console.WriteLine("4. Remove Movie by ID");
                Console.WriteLine("5. Clear All Movies");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddMovie();
                        break;

                    case 2:
                        DisplayMovies();
                        break;

                    case 3:
                        FindMovie();
                        break;

                    case 4:
                        RemoveMovie();
                        break;

                    case 5:
                        ClearMovies();
                        break;

                    case 6:
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 6);
        }

        static void AddMovie()
        {
            if (movies.Count >= MAX_MOVIES)
            {
                Console.WriteLine("Movie store is full (Max 5 movies).");
                return;
            }

            Movie m = new Movie();

            Console.Write("Enter Movie ID: ");
            m.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Movie Name: ");
            m.Name = Console.ReadLine();

            Console.Write("Enter Year of Release: ");
            m.YearOfRelease = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Genre: ");
            m.Genre = Console.ReadLine();

            movies.Add(m);
            Console.WriteLine("Movie added successfully!");
        }

        static void DisplayMovies()
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            Console.WriteLine("\n--- Movie List ---");
            foreach (var movie in movies)
            {
                movie.Display();
            }
        }

        static void FindMovie()
        {
            Console.Write("Enter Movie ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var movie = movies.Find(m => m.Id == id);

            if (movie != null)
            {
                Console.WriteLine("Movie found:");
                movie.Display();
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }
        }

        static void RemoveMovie()
        {
            Console.Write("Enter Movie ID to remove: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var movie = movies.Find(m => m.Id == id);

            if (movie != null)
            {
                movies.Remove(movie);
                Console.WriteLine("Movie removed successfully!");
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }
        }

        static void ClearMovies()
        {
            movies.Clear();
            Console.WriteLine("All movies cleared!");
        }
    }
}