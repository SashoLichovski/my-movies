using my_movies.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Service.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        Movie MovieDetailsById(int id);
        List<Movie> SearchMovies(string search);
        void AddMovie(Movie movie);
        void Remove(int id);
        Movie GetById(int id);
        void Update(Movie movie);
    }
}
