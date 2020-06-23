using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_movies.Service.Interfaces;
using my_movies.ViewModels.LikeModels;

namespace my_movies.Controllers
{
    public class LikeController : Controller
    {
        private readonly ILikeService likeService;

        public LikeController(ILikeService likeService)
        {
            this.likeService = likeService;
        }
        public IActionResult LikeMovie([FromBody]MovieLikeRequestModel request)
        {
            var userId = int.Parse(User.FindFirst("Id").Value);

            likeService.AddLike(userId, request.MovieId);

            return Ok();
        }

        public IActionResult DislikeMovie([FromBody]MovieLikeRequestModel request)
        {
            var userId = int.Parse(User.FindFirst("Id").Value);

            likeService.AddDislike(userId, request.MovieId);

            return Ok();
        }
    }
}