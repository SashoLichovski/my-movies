using my_movies.Data;
using my_movies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_movies.Helpers
{
    public static class ConvertModel
    {
        public static HomePageModel ConvertHomePageModel(Movie movie)
        {
            var model = new HomePageModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                ImageUrl = movie.ImageUrl
            };
            return model;
        }
        public static MovieDetailsModel ConvertMovieDetailsModel(Movie movie)
        {
            var model = new MovieDetailsModel()
            {
                ImageUrl = movie.ImageUrl,
                Title = movie.Title,
                Description = movie.Description,
                Cast = movie.Cast,
                Genre = movie.Genre,
                DateCreated = movie.DateCreated,
                Duration = movie.Duration,
                Views = movie.Views
            };
            return model;
        }
        public static Movie ConvertToMovieModel(CreateMovieModel movieModel)
        {
            var model = new Movie()
            {
                ImageUrl = movieModel.ImageUrl,
                Title = movieModel.Title,
                Description = movieModel.Description,
                Cast = movieModel.Cast,
                Duration = movieModel.Duration,
                Genre = movieModel.Genre,
                DateCreated = DateTime.Now,
                Views = 0,
            };
            return model;
        }
        public static ModifyMoviesModel ConvertToModifyMoviesModel(Movie movie)
        {
            var model = new ModifyMoviesModel()
            {
                Id = movie.Id,
                Title = movie.Title
            };
            return model;
        }
        public static EditMovieModel ConvertToEditMovieModel(Movie movie)
        {
            var model = new EditMovieModel()
            {
                Id = movie.Id,
                ImageUrl = movie.ImageUrl,
                Title = movie.Title,
                Description = movie.Description,
                Cast = movie.Cast,
                Genre = movie.Genre,
                Duration = movie.Duration,
                DateCreated = movie.DateCreated,
                Views = movie.Views
            };
            return model;
        }
        public static Movie EditMovieToMovie(EditMovieModel movie)
        {
            var model = new Movie()
            {
                Id = movie.Id,
                ImageUrl = movie.ImageUrl,
                Title = movie.Title,
                Description = movie.Description,
                Cast = movie.Cast,
                Duration = movie.Duration,
                Genre = movie.Genre,
                DateCreated = movie.DateCreated,
                Views = movie.Views,
            };
            return model;
        }
    }
}
