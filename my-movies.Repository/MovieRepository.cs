using my_movies.Data;
using my_movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Movie> GetAll()
        {
            return Context.Movies.ToList();
        }

        public Movie MovieDetailsById(int id)
        {
            var movie =  Context.Movies.FirstOrDefault(x => x.Id == id);
            movie.Views++;
            Context.SaveChanges();
            return movie;
        }

        public List<Movie> SearchMovies(string search)
        {
            return Context.Movies.Where(x => x.Title.Contains(search)).ToList();
        }

        public void Add(Movie movie)
        {
            Context.Movies.Add(movie);
            Context.SaveChanges();
        }
    }
}
