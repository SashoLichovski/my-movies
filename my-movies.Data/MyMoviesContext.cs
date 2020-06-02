using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Data
{
    public class MyMoviesContext : DbContext
    {
        public MyMoviesContext(DbContextOptions<MyMoviesContext> options) : base(options)
        {

        }

        public virtual DbSet<Movie> Movies { get; set; }
    }
}
