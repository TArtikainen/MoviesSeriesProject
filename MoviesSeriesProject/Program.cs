

using System;

namespace MoviesSeriesProject
{
    class Program
    {
        
        private static int Moviereleaseyear;

        public MoviesDb MoviesDb
        {
            get => default;
            set
            {
            }
        }

        static void Main(string[] args)
        {

            //Int input to be used on switch case
            int input;


            //While loop
            bool loopBreak = true;
            while (loopBreak == true)
            {
                //Menu
                Console.WriteLine(" 1 - Add new movie or serie ");
                Console.WriteLine(" 2 - Show a list of all movies or series ");
                Console.WriteLine(" 3 - Delete movie or serie from the database");
                Console.WriteLine(" 4 - Quit ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    // Case1 : Adding new movie or serie to database
                    case 1:

                        
                        Console.WriteLine("Enter the movie or serie title: ");
                        string Title = Console.ReadLine();

                        Console.WriteLine("Enter the releaseyear");
                        try                                                 //try catch 
                        {
                            Moviereleaseyear = int.Parse(Console.ReadLine());

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        Console.WriteLine("Enter the name of the director: ");
                        string Director = Console.ReadLine();

                        Console.WriteLine("Enter the names of the writers");
                        string Writers = Console.ReadLine();

                        Console.WriteLine("Enter the names of the stars");
                        string Stars = Console.ReadLine();


                        int Genre = MoviesDb.GetGenre();
                        int ProductionPeriods = MoviesDb.GetProductionPeriods();

                        //Connecting to database
                        Sql.Connection();
                        //If production periods is 0 -> MoviedDb is defined as Movie, else as Serie
                        if (ProductionPeriods == 0)
                        {
                            //Creating new movie
                            Movie MoviesDb = new Movie(Title, Moviereleaseyear, Director, Stars, Writers, Genre, ProductionPeriods);
                            //Adding Movie to database
                            Sql.AddMovie(MoviesDb);
                        }
                        else
                        {
                            //Creating new serie
                            Movie MoviesDb = new Movie(Title, Moviereleaseyear, Director, Stars, Writers, Genre, ProductionPeriods);
                            //Adding Serie to database
                            Sql.AddMovie(MoviesDb);
                        }
                        break;

                    
                        

                    //Print movies and series from the database
                    case 2:

                        //Connection to database
                        Sql.Connection();
                        //Select movies from the database
                        Console.WriteLine("All movies in the database: ");
                        Sql.SelectMovies();
                        //Select series from the database
                        Console.WriteLine("All series in the database ");
                        Sql.SelectSeries();

                        break;

                    //Delete movie from the database
                    case 3:
                        //Print all the movies and series
                        Sql.Connection();
                        Sql.SelectMovies();
                        Sql.SelectSeries();
                        //The user is asked which movie or serie to delete
                        Console.WriteLine("Enter the id number of the movie/serie you want to delete");
                        int id = int.Parse(Console.ReadLine());
                        //Delete movie/serie from database
                        Sql.DeleteMovies(id);
                        Console.WriteLine("The movie / serie you selected has been deleted");
                        Console.WriteLine();
                        break;

                    //Quit program 
                    case 4:
                        loopBreak = false;

                        break;
                }
            }
        }
    }
}