﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using my_movies.Helpers;
using my_movies.Service.Interfaces;
using my_movies.ViewModels;

namespace my_movies.Controllers
{
    public class HomeController : Controller
    {
        public IMovieService MovieService { get; }
        public HomeController(IMovieService movieService)
        {
            MovieService = movieService;
        }

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

            return View();
        }
    }
}