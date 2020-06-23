using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Service.Interfaces
{
    public interface ILikeService
    {
        void AddLike(int userId, int movieId);
        void AddDislike(int userId, int movieId);
    }
}
