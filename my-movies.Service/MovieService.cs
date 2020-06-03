﻿using my_movies.Data;
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

        public List<Movie> GetAll()
        {
            return MovieRepo.GetAll();
        }

        public Movie MovieDetailsById(int id)
        {
            return MovieRepo.MovieDetailsById(id);
        }

        public List<Movie> SearchMovies(string search)
        {
            return MovieRepo.SearchMovies(search);
        }

        public void AddMovie(Movie movie)
        {
            MovieRepo.Add(movie);
        }
    }
}
