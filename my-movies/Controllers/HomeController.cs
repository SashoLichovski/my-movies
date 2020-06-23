using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using my_movies.Helpers;
using my_movies.Service.Interfaces;
using my_movies.ViewModels;
using my_movies.ViewModels.LikeModels;

namespace my_movies.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IMovieService MovieService { get; }
        public HomeController(IMovieService movieService)
        {
            MovieService = movieService;
        }
        [AllowAnonymous]
        public IActionResult HomePage(string search)
        {
            ViewBag.header = "All movies";
            var allMovies = MovieService.GetAll();
            var homePageData = new HomePageDataModel();
            var converted = new List<HomePageModel>();
            if (search != null)
            {
                var searchedMovies = MovieService.SearchMovies(search);
                converted = new List<HomePageModel>();
                searchedMovies.ForEach(x => converted.Add(ConvertModel.ConvertHomePageModel(x)));
            }
            else
            {
                foreach (var movie in allMovies)
                {
                    converted.Add(ConvertModel.ConvertHomePageModel(movie));
                }
            }
            var sidebarData = MovieService.SidebarData();
            homePageData.Movies = converted;
            homePageData.SidebarData = sidebarData;
            return View(homePageData);
        }
        [AllowAnonymous]
        public IActionResult MovieDetails(int id)
        {
            ViewBag.header = "Movie details";

            var movie = MovieService.MovieDetailsById(id);
            var sidebarData = MovieService.SidebarData();

            var converted = ConvertModel.ConvertMovieDetailsModel(movie);
            converted.SidebarData = sidebarData;

            if (User.Identity.IsAuthenticated)
            {
                var userId = int.Parse(User.FindFirst("Id").Value);
                var currentUserLike = converted.Likes.FirstOrDefault(x => x.UserId == userId);
                if (currentUserLike != null)
                {
                    if (currentUserLike.IsLiked)
                    {
                        converted.LikeStatus = LikeStatus.Liked;
                    }
                    else
                    {
                        converted.LikeStatus = LikeStatus.Disliked;
                    }
                }
            }

            return View(converted);
        }

        public IActionResult CreateMovie()
        {
            ViewBag.header = "Create new movie";
            var newMovie = new CreateMovieModel();
            return View(newMovie);
        }
        [HttpPost]
        public IActionResult CreateMovie(CreateMovieModel createdMovie)
        {
            if (ModelState.IsValid)
            {
                var movie = ConvertModel.ToMovieModel(createdMovie);
                MovieService.AddForApproval(movie);
                return RedirectToAction("ApprovalMessage");
            }
            return View(createdMovie);
        }
        public IActionResult ApprovalMessage()
        {
            ViewBag.header = "Success";
            return View();
        }
        public IActionResult MoviesForApproval()
        {
            ViewBag.header = "Approve movies";
            var movies = MovieService.GetAllForApprove();
            var converted = new List<ApproveMovieModel>();
            foreach (var movie in movies)
            {
                converted.Add(ConvertModel.ToApproveMovieModel(movie));
            }
            return View(converted);
        }
        public IActionResult ApproveMovie(int id)
        {
            var movie = MovieService.GetById(id);
            MovieService.ApproveMovie(movie);
            return RedirectToAction("HomePage");
        }
        public IActionResult ModifyMovies()
        {
            ViewBag.header = "Modify movies";
            var allMovies = MovieService.GetAll();
            var converted = new List<ModifyMoviesModel>();
            allMovies.ForEach(x => converted.Add(ConvertModel.ConvertToModifyMoviesModel(x)));
            return View(converted);
        }
        [Authorize(Policy = "Role")]
        public IActionResult DeleteMovie(int id)
        {
            MovieService.Remove(id);
            return RedirectToAction("ModifyMovies");
        }
        [Authorize(Policy = "Role")]
        public IActionResult EditMovie(int id)
        {
            ViewBag.header = "Edit movie";
            var movie = MovieService.GetById(id);
            var converted = ConvertModel.ConvertToEditMovieModel(movie);
            return View(converted);
        }
        [HttpPost]
        public IActionResult EditMovie(EditMovieModel model)
        {
            if (ModelState.IsValid)
            {
                var converted = ConvertModel.EditMovieToMovie(model);
                MovieService.Update(converted);
                return RedirectToAction("ModifyMovies");
            }
            return View(model);
        }
        
    }
}
