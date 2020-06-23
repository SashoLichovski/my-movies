using my_movies.Data;
using my_movies.Repository.Interfaces;
using my_movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Service
{
    public class LikeService : ILikeService
    {
        private readonly ILikeRepository likeRepository;

        public LikeService(ILikeRepository likeRepository)
        {
            this.likeRepository = likeRepository;
        }

        public void AddDislike(int userId, int movieId)
        {
            var currentLike = likeRepository.Get(userId, movieId);
            if (currentLike != null)
            {
                currentLike.Status = false;
                likeRepository.Update(currentLike);
            }
            else
            {
                var newLike = new MovieLike()
                {
                    DateCreated = DateTime.Now,
                    Status = false,
                    UserId = userId,
                    MovieId = movieId,
                };
                likeRepository.Add(newLike);
            }
        }

        public void AddLike(int userId, int movieId)
        {
            var currentLike = likeRepository.Get(userId, movieId);
            if (currentLike != null)
            {
                currentLike.Status = true;
                likeRepository.Update(currentLike);
            }
            else
            {
                var newLike = new MovieLike()
                {
                    DateCreated = DateTime.Now,
                    Status = true,
                    UserId = userId,
                    MovieId = movieId,
                };
                likeRepository.Add(newLike);
            }
        }
    }
}
