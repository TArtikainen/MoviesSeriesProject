

using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace MoviesSeriesProject
{
    static class Sql
    {
        //Database connection details
        private const string HOST = "localhost";
        private const string USERNAME = "postgres";
        private const string PASSWORD = "Grespost99";
        private const string DB = "Movies";
        private const string CONNECTION_STRING = "Host=" + HOST + ";Username=" + USERNAME + ";Password=" + PASSWORD + ";Database=" + DB;

        static private NpgsqlConnection connection;
        static private NpgsqlCommand SelectMovie = null;
        static private NpgsqlCommand SelectSerie = null;
        static private NpgsqlCommand InsertMovie = null;
        static private NpgsqlCommand DeleteMovie = null;

        internal static Program Program
        {
            get => default;
            set
            {
            }
        }

        //Connecting to the database
        public static void Connection()
        {
            connection = new NpgsqlConnection(CONNECTION_STRING);
            connection.Open();
        }

        //Adding Movie to database
        public static void AddMovie(Movie MoviesDb)
        {
            using (InsertMovie = new NpgsqlCommand("INSERT INTO moviedb(title, releaseyear, director, writers, stars, genreid, productionperiods)" + "VALUES (@title, @releaseyear, @director,@writers,@stars,@genreid, @productionperiods)", connection))
            {
                InsertMovie.Parameters.AddWithValue("title", MoviesDb.Title);
                InsertMovie.Parameters.AddWithValue("releaseyear", MoviesDb.Releaseyear);
                InsertMovie.Parameters.AddWithValue("director", MoviesDb.Director);
                InsertMovie.Parameters.AddWithValue("writers", MoviesDb.Writers);
                InsertMovie.Parameters.AddWithValue("stars", MoviesDb.Stars);
                InsertMovie.Parameters.AddWithValue("genreid", MoviesDb.Genre);
                InsertMovie.Parameters.AddWithValue("productionperiods", MoviesDb.ProductionPeriods);

                InsertMovie.ExecuteNonQuery();
            }
        }

        //Deleting movie or serie from the database
        public static void DeleteMovies(int id)
        {
            using (DeleteMovie = new NpgsqlCommand($"DELETE FROM moviedb WHERE ID ='{id}';", connection))
            {
                DeleteMovie.Prepare();
                using NpgsqlDataReader npgsql = DeleteMovie.ExecuteReader();
            }
        }

        // Select movies from the database
        public static List<Movie> SelectMovies()
        {
            List<Movie> listMovie = new List<Movie>();
            using (SelectMovie = new NpgsqlCommand("SELECT moviedb.id, moviedb.title, moviedb.releaseyear, moviedb.director, moviedb.writers, moviedb.stars, moviegenre.genre, moviedb.productionperiods FROM moviedb LEFT JOIN moviegenre on moviedb.genreid = moviegenre.idgenre WHERE productionperiods = 0", connection))

              

            {
                SelectMovie.Prepare();
                using (NpgsqlDataReader movie = SelectMovie.ExecuteReader())

                    while (movie.Read())
                    {
                        listMovie.Add(new Movie(movie.GetInt16(0), movie.GetString(1), movie.GetInt32(2), movie.GetString(3),movie.GetString(4), movie.GetString(5), movie.GetString(6), movie.GetInt32(7)));



                        Console.WriteLine($"ID number is {movie.GetInt16(0)}.\nMovie title is {movie.GetString(1)}.\nThe Movie was released in {movie.GetInt32(2)}.\nThe movie is directed by {movie.GetString(3)}.\nThe writers of the movie are {movie.GetString(4)}.\nThe stars of the movie are {movie.GetString(5)}.\nThe genre of the movie is {movie.GetString(6)}.\nNumber of seasons {movie.GetInt32(7)} ");
                        Console.WriteLine();
                    }
                return listMovie;


            }
        }


        //Select series from the database
        static public List<Serie> SelectSeries()
        {
            List<Serie> listSerie = new List<Serie>();
            using (SelectSerie = new NpgsqlCommand("SELECT moviedb.id, moviedb.title, moviedb.releaseyear, moviedb.director, moviedb.writers, moviedb.stars, moviegenre.genre, moviedb.productionperiods FROM moviedb LEFT JOIN moviegenre on moviedb.genreid = moviegenre.idgenre WHERE productionperiods > 0", connection))
            {
                SelectSerie.Prepare();

                using (NpgsqlDataReader movie = SelectSerie.ExecuteReader())

                    while (movie.Read())
                    {
                        listSerie.Add(new Serie(movie.GetInt16(0), movie.GetString(1), movie.GetInt32(2), movie.GetString(3), movie.GetString(4), movie.GetString(5), movie.GetString(6), movie.GetInt32(7)));

                        Console.WriteLine($"ID number is {movie.GetInt16(0)}.\nSerie title is {movie.GetString(1)}.\nThe serie was released in {movie.GetInt32(2)}.\nThe serie is directed by {movie.GetString(3)}.\nThe writers of the serie are {movie.GetString(4)}.\nThe stars of the serie are {movie.GetString(5)}.\nThe genre of the series is {movie.GetString(6)}.\nNumber of seasons {movie.GetInt32(7)} ");
                        Console.WriteLine();
                    }
                return listSerie;
            }
        }
    }
}