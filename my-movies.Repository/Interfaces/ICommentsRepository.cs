using my_movies.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Repository.Interfaces
{
    public interface ICommentsRepository
    {
        void Add(MovieComment movieComment);
    }
}
