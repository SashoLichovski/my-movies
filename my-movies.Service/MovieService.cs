using my_movies.Repository.Interfaces;
using my_movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Service
{
    public class MovieService : IMovieService
    {
        public IMovieRepository MovieRepo { get; set; }
        public MovieService(IMovieRepository movieRepo)
        {
            MovieRepo = movieRepo;
        }
    }
}
