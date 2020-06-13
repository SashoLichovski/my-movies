using my_movies.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Repository.Interfaces
{
    public interface ICommentsRepository
    {
        void Add(MovieComment movieComment);
        List<MovieComment> GetAllForApproval();
        MovieComment GetById(int commentId);
        void Update(MovieComment comment);
        void Remove(MovieComment comment);
    }
}
