﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_movies.ViewModels
{
    public class MovieDetailsModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Cast { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public DateTime DateCreated { get; set; }
        public int Views { get; set; }
    }
}