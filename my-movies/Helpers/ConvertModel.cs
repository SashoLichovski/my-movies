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
                ImageUrl = movie.ImageUrl,
                IsApproved = movie.IsApproved,
                Genre = movie.Genre
            };
            return model;
        }
        public static MovieCommentModel ToMovieCommentModel(MovieComment movieComment)
        {
            return new MovieCommentModel()
            {
                Comment = movieComment.Comment,
                Username = movieComment.User.Username,
                DateCreated = movieComment.DateCreated
            };
        }
        public static MovieDetailsModel ConvertMovieDetailsModel(Movie movie)
        {
            var model = new MovieDetailsModel()
            {
                Id = movie.Id,
                ImageUrl = movie.ImageUrl,
                Title = movie.Title,
                Description = movie.Description,
                Cast = movie.Cast,
                Genre = movie.Genre,
                DateCreated = movie.DateCreated,
                Duration = movie.Duration,
                Views = movie.Views,
                Comments = movie.MovieComments.Select(x => ToMovieCommentModel(x)).ToList()
            };
            return model;
        }
        public static ChangeUsernameModel ToChangeUsernameModel(User user)
        {
            var model = new ChangeUsernameModel()
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password
            };
            return model;
        }
        public static ChangePasswordModel ToChangePasswordModel(User user)
        {
            var model = new ChangePasswordModel()
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password
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
        internal static Movie ToMovieForDb(CreateMovieModel createdMovie)
        {
            var model = new Movie()
            {
                Title = createdMovie.Title,
                Description = createdMovie.Description,
                ImageUrl = createdMovie.ImageUrl,
                Genre = createdMovie.Genre,
                Cast = createdMovie.Cast,
                Duration = createdMovie.Duration,
                Views = 0,
                DateCreated = new DateTime()
            };
            return model;
        }
        public static ModifyMoviesModel ConvertToModifyMoviesModel(Movie movie)
        {
            var model = new ModifyMoviesModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                IsApproved = movie.IsApproved
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
        public static User ConvertToUser(UserModel model)
        {
            var user = new User()
            {
                Username = model.Username,
                Password = model.Password
            };
            return user;
        }
        public static User ConvertToUser(ChangeUsernameModel model)
        {
            var user = new User()
            {
                Id = model.Id
            };
            return user;
        }
        public static User ConvertToUser(RegisterUserModel model)
        {
            var user = new User()
            {
                Username = model.Username,
                Password = model.Password
            };
            return user;
        }
        public static UserDetailsModel ConvertToUserDetailsModel(User user)
        {
            var currentUser = new UserDetailsModel()
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password
            };
            return currentUser;
        }
        public static ManageUsersModel ToManageUsersModel(User user)
        {
            var model = new ManageUsersModel()
            {
                Id = user.Id,
                Username = user.Username,
                Role = user.Role
            };
            return model;
        }
        public static Movie ToMovieModel(CreateMovieModel createdMovie)
        {
            var model = new Movie()
            {
                Title = createdMovie.Title,
                Description = createdMovie.Description,
                ImageUrl = createdMovie.ImageUrl,
                Cast = createdMovie.Cast,
                Genre = createdMovie.Genre,
                Duration = createdMovie.Duration,
                Views = 0,
                DateCreated = DateTime.Now
            };
            return model;
        }
        public static ApproveMovieModel ToApproveMovieModel(Movie movie)
        {
            var model = new ApproveMovieModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                ImageUrl = movie.ImageUrl,
                IsApproved = movie.IsApproved
            };
            return model;
        }
    }
}
