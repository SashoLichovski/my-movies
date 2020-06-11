using my_movies.Data;
using my_movies.Repository.Interfaces;
using my_movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Service
{
    public class CommentService : ICommentService
    {
        public ICommentsRepository CommentsRepository { get; }
        public CommentService(ICommentsRepository commentsRepository)
        {
            CommentsRepository = commentsRepository;
        }

        public void Add(string comment, int movieId, int userId)
        {
            var movieComment = new MovieComment()
            {
                Comment = comment,
                UserId = userId,
                MovieId = movieId,
                DateCreated = DateTime.Now
            };
            CommentsRepository.Add(movieComment);
        }
    }
}
