

using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesSeriesProject
{
    class Movie : MoviesDb
    {

        //Constructor is used to create and add a new movie
        public Movie(string _title, int _releaseyear, string _director, string _writers, string _stars, int _genre, int _productionperiods) : base(_title, _releaseyear, _director, _writers, _stars, _genre, _productionperiods)
        {
        }

        //Constructor that is used when getting data from the database
        public Movie(int id, string _title, int _releaseyear, string _director, string _writers, string _stars, string genre, int _productionperiods) : base(id, _title, _releaseyear, _director, _writers, _stars, genre, _productionperiods)
        {

        }
    }
}
