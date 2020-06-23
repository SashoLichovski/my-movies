using my_movies.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Repository.Interfaces
{
    public interface ILikeRepository
    {
        MovieLike Get(int userId, int movieId);
        void Update(MovieLike currentLike);
        void Add(MovieLike newLike);
    }
}
