using System;

namespace my_movies.ViewModels
{
    public class MovieCommentModel
    {
        public string Comment { get; set; }
        public string Username { get; set; }
        public DateTime DateCreated { get; set; }
    }
}