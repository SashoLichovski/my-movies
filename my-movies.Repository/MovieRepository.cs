using my_movies.Data;
using my_movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public MyMoviesContext Context { get; set; }
        public MovieRepository(MyMoviesContext context)
        {
            Context = context;
        }
    }
}
