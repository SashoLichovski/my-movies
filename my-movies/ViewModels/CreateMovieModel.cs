using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace my_movies.ViewModels
{
    public class CreateMovieModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Cast { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Duration { get; set; }
    }
}
