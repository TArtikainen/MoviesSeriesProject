

using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesSeriesProject
{
    class Serie : MoviesDb
    {

        //The constructor is used to create and add a new serie

        public Serie(string _title, int _releaseyear, string _director, string _stars, string _writers, int _genre, int _productionperiods) : base(_title, _releaseyear, _director, _stars, _writers, _genre, _productionperiods)
        {
        }
        //Constructor that is used when getting data from the database
        public Serie(int id, string _title, int _releaseyear, string _director, string _writers, string _stars, string genre, int _productionperiods) : base(id, _title, _releaseyear, _director, _writers, _stars, genre, _productionperiods)
        {
        }
    }
}