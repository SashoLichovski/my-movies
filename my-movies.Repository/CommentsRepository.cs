using my_movies.Data;
using my_movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Repository
{
    public class CommentsRepository : ICommentsRepository
    {
        public MyMoviesContext Context { get; }
        public CommentsRepository(MyMoviesContext context)
        {
            Context = context;
        }

        public void Add(MovieComment movieComment)
        {
            Context.MovieComments.Add(movieComment);
            Context.SaveChanges();
        }
    }
}
