﻿using System;
using System.Collections.Generic;
using System.Text;
using my_movies.Data;

namespace my_movies.Repository.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie MovieDetailsById(int id);
        List<Movie> SearchMovies(string search);
        void Add(Movie movie);
    }
}