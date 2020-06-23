using my_movies.Data;
using my_movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace my_movies.Repository
{
    public class LikeRepository : ILikeRepository
    {
        private readonly MyMoviesContext context;

        public LikeRepository(MyMoviesContext context)
        {
            this.context = context;
        }

        public void Add(MovieLike newLike)
        {
            context.MovieLikes.Add(newLike);
            context.SaveChanges();
        }

        public MovieLike Get(int userId, int movieId)
        {
            return context.MovieLikes.FirstOrDefault(x => x.UserId == userId && x.MovieId == movieId);
        }

        public void Update(MovieLike currentLike)
        {
            context.MovieLikes.Update(currentLike);
            context.SaveChanges();
        }
    }
}
