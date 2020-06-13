using Microsoft.EntityFrameworkCore;
using my_movies.Data;
using my_movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<MovieComment> GetAllForApproval()
        {
            return Context.MovieComments.Where(x => x.IsApproved == false).ToList();
        }

        public MovieComment GetById(int commentId)
        {
            return Context.MovieComments.FirstOrDefault(x => x.Id == commentId);
        }

        public void Update(MovieComment comment)
        {
            Context.MovieComments.Update(comment);
            Context.SaveChanges();
        }

        public void Remove(MovieComment comment)
        {
            Context.MovieComments.Remove(comment);
            Context.SaveChanges();
        }
    }
}
