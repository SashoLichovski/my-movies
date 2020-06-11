using my_movies.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Service.Interfaces
{
    public interface ICommentService
    {
        void Add(string comment, int movieId, int userId);
    }
}
