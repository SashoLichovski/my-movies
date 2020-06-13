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
                DateCreated = DateTime.Now,
                IsApproved = false
            };
            CommentsRepository.Add(movieComment);
        }

        public List<MovieComment> GetAllForApproval()
        {
            return CommentsRepository.GetAllForApproval();
        }

        public MovieComment GetById(int commentId)
        {
            return CommentsRepository.GetById(commentId);
        }

        public void Approve(MovieComment comment)
        {
            comment.IsApproved = true;
            CommentsRepository.Update(comment);
        }

        public void Remove(MovieComment comment)
        {
            CommentsRepository.Remove(comment);
        }
    }
}
