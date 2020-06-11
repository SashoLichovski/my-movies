using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_movies.Service.Interfaces;

namespace my_movies.Controllers
{
    public class CommentController : Controller
    {
        public ICommentService CommentService { get; }
        public CommentController(ICommentService commentService)
        {
            CommentService = commentService;
        }

        public IActionResult AddComment(string comment, int movieId)
        {
            var userId = int.Parse(User.FindFirst("Id").Value);
            CommentService.Add(comment, movieId, userId);
            return RedirectToAction("MovieDetails", "Home", new { Id = movieId });
        }
    }
}