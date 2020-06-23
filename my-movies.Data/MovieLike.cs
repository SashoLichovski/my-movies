using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace my_movies.Data
{
    public class MovieLike
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
