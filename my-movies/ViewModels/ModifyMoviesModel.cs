﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_movies.ViewModels
{
    public class ModifyMoviesModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsApproved { get; set; }
    }
}
