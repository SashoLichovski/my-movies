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
            var allMovies = MovieService.GetAll();
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

            return View(converted);
        }
        [AllowAnonymous]
        public IActionResult MovieDetails(int id)
        {
            var movie = MovieService.MovieDetailsById(id);
            var converted = ConvertModel.ConvertMovieDetailsModel(movie);
            return View(converted);
        }

        public IActionResult CreateMovie()
        {
            var newMovie = new CreateMovieModel();
            return View(newMovie);
        }
        [HttpPost]
        public IActionResult CreateMovie(CreateMovieModel createdMovie)
        {
            if (ModelState.IsValid)
            {
                MovieService.AddMovie(ConvertModel.ConvertToMovieModel(createdMovie));
                return RedirectToAction("HomePage");
            }
            return View(createdMovie);
        }

        public IActionResult ModifyMovies()
        {
            var allMovies = MovieService.GetAll();
            var converted = new List<ModifyMoviesModel>();
            allMovies.ForEach(x => converted.Add(ConvertModel.ConvertToModifyMoviesModel(x)));
            return View(converted);
        }

        public IActionResult DeleteMovie(int id)
        {
            MovieService.Remove(id);
            return RedirectToAction("ModifyMovies");
        }

        public IActionResult EditMovie(int id)
        {
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
