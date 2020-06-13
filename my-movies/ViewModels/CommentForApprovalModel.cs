using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_movies.ViewModels
{
    public class CommentForApprovalModel
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public bool IsApproved { get; set; }

    }
}
