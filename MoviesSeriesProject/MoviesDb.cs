

using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesSeriesProject
{
    public abstract class MoviesDb
    {
        private string _title;
        private int _releaseyear;
        private string _director;
        private string _writers;
        private string _stars;
        private int _genre;
        private int _productionperiods;
        private static int productionperiods;



        //Values which to be used when getting data from database

        private readonly int id;
        private readonly string genre;



        //Constructor is used to create and add a new moviedb 
        public MoviesDb(string _title, int _releaseyear, string _director, string _writers, string _stars, int _genre, int _productionPeriods)
        {
            Title = _title;
            Releaseyear = _releaseyear;
            Director = _director;
            Writers = _writers;
            Stars = _stars;
            Genre = _genre;
            ProductionPeriods = _productionPeriods;

        }

        
        //Constructor which is used when getting data from the database
        public MoviesDb(int id, string _title, int _releaseyear, string _director, string _writers, string _stars, string genre, int _ProductionPeriods)
        {
            this.id = id;
            this._title = _title;
            this._releaseyear = _releaseyear;
            this._director = _director;
            this._writers = _writers;
            this._stars = _stars;
            this.genre = genre;
            _productionperiods = _ProductionPeriods;

        }

        //Getters and setters
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public int Releaseyear
        {
            get { return _releaseyear; }
            set { _releaseyear = value; }
        }
        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }

        public string Stars
        {
            get { return _stars; }
            set { _stars = value; }
        }

        public string Writers
        {
            get { return _writers; }
            set { _writers = value; }
        }

        public int Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public int ProductionPeriods
        {
            get { return _productionperiods; }
            set { _productionperiods = value; }
        }


        public static int GetProductionPeriods()
        {
            //If adding movie user must enter productionperiods 0, otherwise it defined as serie

            do
            {

                while (true)
                {
                    Console.WriteLine("Number of seasons. If you are adding a movie, enter 0 for number of seasons ");
                    try
                    {
                        productionperiods = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    return productionperiods;
                }
            } while (productionperiods < 0);
        }

        public static int GetGenre()
        {
            //Array to add genre     
            string[] genre = new string[] { "1 - Comedy", "2 - Thriller", "3 - Action", "4 - Romance", "5 - Horror", "6 - Drama", "7 - Sci-Fi", "8 - Superhero", "9 - Mystery", "10 - Crime", "11 - Animation", "12 - Adventure", "13 - Fantasy", "14 - Comedy-Romance", "15 - Action-Comedy" };

            while (true)
            {
                int moviegenre = 0;
                Console.WriteLine("Select a movie genre: ");

                //Print genre from array
                foreach (var item in genre)
                {
                    Console.WriteLine(item);
                }
                try
                {
                    moviegenre = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex);
                }

                //The program only allows values between 1 and 15

                if (moviegenre >= 1 && moviegenre <= genre.Length)
                {
                    return moviegenre;
                }
                
            }
        }
    
            //Getters that are used when getting data from the database

            public string GenreDB()
            { return genre; }

            public int IdDB()
            { 
            return id; 
            }
    }
}