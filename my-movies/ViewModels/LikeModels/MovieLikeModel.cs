using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_movies.ViewModels.LikeModels
{
    public class MovieLikeModel
    {
        public int Id { get; set; }
        public bool IsLiked { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
    }
}
