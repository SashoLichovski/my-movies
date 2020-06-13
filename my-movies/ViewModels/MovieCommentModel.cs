using System;

namespace my_movies.ViewModels
{
    public class MovieCommentModel
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Username { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsApproved { get; set; }
    }
}