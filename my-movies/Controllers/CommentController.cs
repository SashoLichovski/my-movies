using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_movies.Helpers;
using my_movies.Service.Interfaces;
using my_movies.ViewModels;

namespace my_movies.Controllers
{
    public class CommentController : Controller
    {
        public ICommentService CommentService { get; }
        public CommentController(ICommentService commentService)
        {
            CommentService = commentService;
        }
        
        public IActionResult ApproveComment(int id)
        {
            var comment = CommentService.GetById(id);
            CommentService.Approve(comment);
            return RedirectToAction("CommentsForApproval");
        }

        public IActionResult DeleteComment(int id)
        {
            var comment = CommentService.GetById(id);
            CommentService.Remove(comment);
            return RedirectToAction("CommentsForApproval");
        }

        public IActionResult AddForApproval(string comment, int movieId)
        {
            var userId = int.Parse(User.FindFirst("Id").Value);
            CommentService.Add(comment, movieId, userId);
            return RedirectToAction("MovieDetails", "Home", new { Id = movieId});
        }

        public IActionResult CommentsForApproval()
        {
            ViewBag.header = "Approve comments";
            var comments = CommentService.GetAllForApproval();
            var converted = comments.Select(x => ConvertModel.ToCommentForApproval(x)).ToList();
            return View(converted);
        }

        public IActionResult RateMovie(int id, int rating)
        {

            return RedirectToAction("MovieDetails","Home", new { Id = id });
        }
    }
}