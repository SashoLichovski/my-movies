using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using my_movies.Service.Interfaces;

namespace my_movies.Controllers
{
    public class HomeController : Controller
    {
        public IMovieService MovieService { get; }
        public HomeController(IMovieService movieService)
        {
            MovieService = movieService;
        }

        public IActionResult HomePage()
        {
            return View();
        }
    }
}
