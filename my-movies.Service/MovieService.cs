using my_movies.Data;
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
            var movie = MovieRepo.MovieDetailsById(id);
            movie.Views++;
            return movie;
        }

        public List<Movie> SearchMovies(string search)
        {
            return MovieRepo.SearchMovies(search);
        }

        public void AddMovie(Movie movie)
        {
            MovieRepo.Add(movie);
        }

        public void Remove(int id)
        {
            MovieRepo.Remove(id);
        }

        public Movie GetById(int id)
        {
            return MovieRepo.GetById(id);
        }

        public void Update(Movie movie)
        {
            MovieRepo.UpdateMovie(movie);
        }

        public void AddForApproval(Movie movie)
        {
            MovieRepo.Add(movie);
        }

        public List<Movie> GetAllForApprove()
        {
            return MovieRepo.GetAllForApprove();
        }

        public void ApproveMovie(Movie movie)
        {
            movie.IsApproved = true;
            MovieRepo.UpdateMovie(movie);
        }
    }
}
